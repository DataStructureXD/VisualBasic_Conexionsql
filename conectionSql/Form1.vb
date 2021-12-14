Imports System.Data.SqlClient
Public Class Form1

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter
        //Investigar cuenta por cobrar
    End Sub

    Private Sub Name_Click(sender As Object, e As EventArgs) Handles txt1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New SqlConnection(MySettings.database2ConnectionString)
        Dim sql As String = "SELECT name1, lastname, phone, email from Table_1"
        Dim CMD As New SqlCommand(sql, con)

        Try
            Dim da As New SqlDataAdapter(CMD)
            Dim ds As New DataSet

            da.Fill(ds, "Table_1")
            Me.DataGridView1.DataSource = ds.Tables("Table_1")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        'TODO: esta línea de código carga datos en la tabla 'Database2DataSet.Table_1' Puede moverla o quitarla según sea necesario.
        'Me.Table_1TableAdapter.Fill(Me.Database2DataSet.Table_1)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Table1BindingSource.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Table1BindingSource.AddNew()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Table1BindingSource.MoveNext()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Table1BindingSource.EndEdit()
        Table_1TableAdapter.Update(Database2DataSet)
        MessageBox.Show("Data Saved")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Table1BindingSource.RemoveCurrent()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub
End Class
