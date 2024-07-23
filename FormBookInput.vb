Imports System.Data.SQLite

Public Class FormBookInput
    Private conn As SQLiteConnection

    Public Sub New(connection As SQLiteConnection)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        conn = connection
    End Sub

    Private Sub ButtonSave_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Dim title As String = TextBoxTitle.Text
        Dim author As String = TextBoxAuthor.Text
        Dim price As Double

        If Double.TryParse(TextBoxPrice.Text, price) Then
            Dim query As String = "INSERT INTO Books (Title, Author, Price) VALUES (@Title, @Author, @Price)"
            Dim cmd As New SQLiteCommand(query, conn)
            cmd.Parameters.AddWithValue("@Title", title)
            cmd.Parameters.AddWithValue("@Author", author)
            cmd.Parameters.AddWithValue("@Price", price)
            cmd.ExecuteNonQuery()

            MessageBox.Show("Book added successfully!")
            Me.Close()
        Else
            MessageBox.Show("Please enter a valid price.")
        End If
    End Sub
End Class
