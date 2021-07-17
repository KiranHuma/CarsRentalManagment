Imports System.Data.SqlClient
Public Class Customers
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aimal\Documents\CarRentalVbDb.mdf;Integrated Security=True;Connect Timeout=30")


    Private Sub Customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate_cust()
    End Sub
    'insert customer data into database
    Private Sub insert()
        If CustNameTb.Text = "" Or CustAddressTb.Text = "" Or CustPhoneTb.Text = "" Then

            MsgBox("Missing Information")
        Else
            Try

                con.Open()
                Dim query = "insert into CustomerTbl values('" & CustNameTb.Text & "','" & CustAddressTb.Text & "','" & CustPhoneTb.Text & "')"
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Successfully Saved ")
                con.Close()
                Clear()
                populate_cust()
            Catch ex As Exception
                MsgBox("Customer Insertion Failed because " & ex.Message)
                Me.Dispose()
            End Try
        End If
    End Sub
    Private Sub populate_cust()
        Try

            con.Open()
            Dim sql = "Select * from CustomerTbl"
            Dim cmd = New SqlCommand(sql, con)
            Dim adapter = New SqlDataAdapter
            adapter = New SqlDataAdapter(cmd)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            customerdgv.DataSource = ds.Tables(0)

            con.close()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
        End Try
    End Sub
    Dim Key = 0
    Private Sub deletecust()
        If Key = 0 Then

            MsgBox("Select the Customer")
        Else
            Try

                con.Open()
                Dim query = "delete from CustomerTbl where CustId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Successfully Deleted ")
                con.Close()
                Clear()
                populate_cust()
            Catch ex As Exception
                MsgBox("Customer Deletion Failed because " & ex.Message)
                Me.Dispose()
            End Try
        End If
    End Sub
    'edit the customer records

    Private Sub updatecust()
        If CustNameTb.Text = "" Or CustAddressTb.Text = "" Or CustPhoneTb.Text = "" Then

            MsgBox("Missing Information")
        Else
            Try

                con.Open()
                Dim query = "update CustomerTbl set CustName='" & CustNameTb.Text & "', CustAdd='" & CustAddressTb.Text & "',CustPhone= '" & CustPhoneTb.Text & "' where CustId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Customer Successfully Updated ")
                con.Close()
                Clear()
                populate_cust()
            Catch ex As Exception
                MsgBox("Customer Updation Failed because " & ex.Message)
                Me.Dispose()
            End Try
        End If
    End Sub
    'Clear the data from textboxes
    Private Sub Clear()
        CustNameTb.Text = ""
        CustAddressTb.Text = ""
        CustPhoneTb.Text = ""


    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insert()
    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        updatecust()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        deletecust()
    End Sub

    Private Sub customerdgv_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles customerdgv.CellMouseClick
        Dim row As DataGridViewRow = customerdgv.Rows(e.RowIndex)
        CustNameTb.Text = row.Cells(1).Value.ToString
        CustAddressTb.Text = row.Cells(3).Value.ToString
        CustPhoneTb.Text = row.Cells(3).Value.ToString

        If CustNameTb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub
End Class