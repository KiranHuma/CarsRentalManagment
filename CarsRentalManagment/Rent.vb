Imports System.Data.SqlClient
Public Class Rent
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aimal\Documents\CarRentalVbDb.mdf;Integrated Security=True;Connect Timeout=30")

    Private Sub fillcustomer()
        con.open()
        Dim sql = "select * from CustomerTbl"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        CustIdCb.DataSource = Tbl
        CustIdCb.DisplayMember = "CustId"
        CustIdCb.ValueMember = "CustId"

        con.close()

    End Sub
    Private Sub fillregistration()
        con.open()
        Dim sql = "select * from CarTbl"
        Dim cmd As New SqlCommand(sql, con)
        Dim adapter As New SqlDataAdapter(cmd)
        Dim Tbl As New DataTable()
        adapter.Fill(Tbl)
        RegNumCb.DataSource = Tbl
        RegNumCb.DisplayMember = "RegNo"
        RegNumCb.ValueMember = "RegNo"

        con.close()
    End Sub
    Private Sub GetCustName()
        con.open()
        Dim sql = "select * from CustomerTbl where CustId=" & CustIdCb.SelectedValue.ToString() & ""
        Dim cmd As New SqlCommand(sql, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read
            CustnameTb.Text = reader(1).ToString()
        End While

        con.close()

    End Sub
    Dim Cost = 0
    Private Sub GetCarRate()
        con.open()
        Dim sql = "select * from CarTbl where RegNo='" & RegNumCb.SelectedValue.ToString() & "'"
        Dim cmd As New SqlCommand(sql, con)
        Dim dt As New DataTable
        Dim reader As SqlDataReader
        reader = cmd.ExecuteReader
        While reader.Read

            Cost = Convert.ToInt32(reader(4).ToString())

        End While

        con.close()
    End Sub
    Private Sub Rent_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fillcustomer()
        fillregistration()
        populate()
    End Sub

    Private Sub CustIdCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles CustIdCb.SelectionChangeCommitted
        GetCustName()

    End Sub
    Private Sub Clear()
        CustnameTb.Text = ""

        FeesTb.Text = ""


    End Sub
    'Show data  in grid
    Private Sub populate()
        Try

            con.Open()
            Dim sql = "Select * from RentTbl"
            Dim cmd = New SqlCommand(sql, con)
            Dim adapter = New SqlDataAdapter
            adapter = New SqlDataAdapter(cmd)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            rentdgv.DataSource = ds.Tables(0)

            con.close()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub calculatefees()




        'calculate the number of days the car will be rented
        Dim diff As System.TimeSpan = ReturnDate.Value.Date.Subtract(RentDate.Value.Date)
        'MsgBox(diff.TotalDays)
        Dim Days = diff.TotalDays

        Dim fees = Days * Cost
        FeesTb.Text = fees
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If CustnameTb.Text = "" Or RegNumCb.SelectedIndex = -1 Or FeesTb.Text = "" Then

            MsgBox("Missing Information")
        Else
            Try

                con.Open()
                Dim query = "insert into RentTbl values('" & RegNumCb.SelectedValue.ToString() & "','" & CustIdCb.SelectedValue.ToString() & "','" & CustnameTb.Text & "','" & RentDate.Value.Date & "','" & ReturnDate.Value.Date & "','" & FeesTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Car Successfully Rented.Enjoy ")
                con.Close()
                Clear()
                populate()
            Catch ex As Exception
                MsgBox(" Failed because " & ex.Message)
                Me.Dispose()
            End Try
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub

    Private Sub ReturnDate_ValueChanged(sender As Object, e As EventArgs) Handles ReturnDate.ValueChanged
        calculatefees()
    End Sub

    Private Sub RegNumCb_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles RegNumCb.SelectionChangeCommitted
        GetCarRate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GetCarRate()
    End Sub
End Class