
Imports System.Data.SqlClient
Public Class Cars
    Dim con = New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Aimal\Documents\CarRentalVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        insert()
    End Sub
    'insert car data into database
    Private Sub insert()
        Try

            con.Open()
            Dim query = "insert into CarTbl values('" & RegNumTb.Text & "','" & BrandCb.SelectedItem.ToString() & "','" & ModelTb.Text & "','" & PriceTb.Text & "','" & ColorTb.Text & "','" & AvailableCb.SelectedItem.ToString() & "')"
            Dim cmd As SqlCommand
            cmd = New SqlCommand(query, con)
            cmd.ExecuteNonQuery()
            MsgBox("Car Successfully Saved ")
            con.Close()
            Clear()
            populate()
        Catch ex As Exception
            MsgBox("Car Insertion Failed because " & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    'delete car data from database
    Dim Key = 0
    Private Sub deletecar()
        If Key = 0 Then

            MsgBox("Select the car")
        Else
            Try

                con.Open()
                Dim query = "delete from CarTbl where CId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Car Successfully Deleted ")
                con.Close()
                Clear()
                populate()
            Catch ex As Exception
                MsgBox("Car Deletion Failed because " & ex.Message)
                Me.Dispose()
            End Try
        End If
    End Sub
    'edit the car records

    Private Sub updateCars()
        If RegNumTb.Text = "" Or BrandCb.SelectedIndex = -1 Or ModelTb.Text = "" Or PriceTb.Text Or ColorTb.Text = "" Or AvailableCb.SelectedIndex = -1 Then

            MsgBox("Missing Information")
        Else
            Try

                con.Open()
                Dim query = "update CarTbl set RegNo='" & RegNumTb.Text & "', Brand='" & BrandCb.SelectedItem.ToString() & "', Model='" & ModelTb.Text & "',Price= '" & PriceTb.Text & "',Color= '" & ColorTb.Text & "',Available= '" & AvailableCb.SelectedItem.ToString() & "' where CId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Car Successfully Updated ")
                con.Close()
                Clear()
                populate()
            Catch ex As Exception
                MsgBox("Car Updation Failed because " & ex.Message)
                Me.Dispose()
            End Try
        End If
    End Sub
    Private Sub Cars_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        populate()
    End Sub
    'Clear the data from textboxes
    Private Sub Clear()
        RegNumTb.Text = ""
        BrandCb.SelectedIndex = -1
        ModelTb.Text = ""
        PriceTb.Text = ""
        ColorTb.Text = ""
        AvailableCb.SelectedIndex = -1

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Clear()
    End Sub
    'Show data of cars in grid
    Private Sub populate()
        Try

            con.Open()
            Dim sql = "Select * from CarTbl"
            Dim cmd = New SqlCommand(sql, con)
            Dim adapter = New SqlDataAdapter
            adapter = New SqlDataAdapter(cmd)
            Dim builder As SqlCommandBuilder
            builder = New SqlCommandBuilder(adapter)
            Dim ds As DataSet
            ds = New DataSet
            adapter.Fill(ds)
            Cardgv.DataSource = ds.Tables(0)

            con.close()
        Catch ex As Exception
            MessageBox.Show("Failed:Retrieving Data" & ex.Message)
            Me.Dispose()
        End Try
    End Sub
    Private Sub Guna2DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles Cardgv.CellMouseClick
        Dim row As DataGridViewRow = Cardgv.Rows(e.RowIndex)
        RegNumTb.Text = row.Cells(1).Value.ToString
        BrandCb.SelectedItem = row.Cells(2).Value.ToString
        ModelTb.Text = row.Cells(3).Value.ToString
        PriceTb.Text = row.Cells(4).Value.ToString
        ColorTb.Text = row.Cells(5).Value.ToString
        AvailableCb.SelectedItem = row.Cells(6).Value.ToString
        If RegNumTb.Text = "" Then
            Key = 0
        Else
            Key = Convert.ToInt32(row.Cells(0).Value.ToString)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        deletecar()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If RegNumTb.Text = "" Or BrandCb.SelectedIndex = -1 Or ModelTb.Text = "" Or PriceTb.Text = "" Or ColorTb.Text = "" Or AvailableCb.SelectedIndex = -1 Then
            'Or ModelTb.Text = "" Or PriceTb.Text="" Or ColorTb.Text = "" Or AvailableCb.SelectedIndex = -1
            MsgBox("Missing Information")
        Else
            Try

                con.Open()
                Dim query = "update CarTbl set RegNo='" & RegNumTb.Text & "', Brand='" & BrandCb.SelectedItem.ToString() & "', Model='" & ModelTb.Text & "',Price= '" & PriceTb.Text & "',Color= '" & ColorTb.Text & "',Available= '" & AvailableCb.SelectedItem.ToString() & "' where CId=" & Key & ""
                Dim cmd As SqlCommand
                cmd = New SqlCommand(query, con)
                cmd.ExecuteNonQuery()
                MsgBox("Car Successfully Updated ")
                con.Close()
                Clear()
                populate()
            Catch ex As Exception
                MsgBox("Car Updation Failed because " & ex.Message)
                Me.Dispose()
            End Try
        End If
    End Sub
End Class