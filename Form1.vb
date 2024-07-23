Imports System.Data.SQLite

Public Class Form1
    Private conn As SQLiteConnection

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize database connection
        conn = New SQLiteConnection("Data Source=bookorder.db;Version=3;")
        conn.Open()

        ' Create tables if they don't exist
        Dim createBooksTable As String = "CREATE TABLE IF NOT EXISTS Books (Id INTEGER PRIMARY KEY, Title TEXT, Author TEXT, Price REAL)"
        Dim createOrdersTable As String = "CREATE TABLE IF NOT EXISTS Orders (Id INTEGER PRIMARY KEY, BookId INTEGER, Quantity INTEGER, TotalPrice REAL)"
        Dim cmd As New SQLiteCommand(createBooksTable, conn)
        cmd.ExecuteNonQuery()
        cmd.CommandText = createOrdersTable
        cmd.ExecuteNonQuery()

        ' Populate ComboBox with books
        PopulateBooksComboBox()
        LoadOrders()
    End Sub

    Private Sub PopulateBooksComboBox()
        Dim query As String = "SELECT Id, Title FROM Books"
        Dim cmd As New SQLiteCommand(query, conn)
        Dim reader As SQLiteDataReader = cmd.ExecuteReader()

        ComboBoxBooks.Items.Clear()
        While reader.Read()
            ComboBoxBooks.Items.Add(New KeyValuePair(Of Integer, String)(reader("Id"), reader("Title")))
        End While

        ComboBoxBooks.DisplayMember = "Value"
        ComboBoxBooks.ValueMember = "Key"
    End Sub

    Private Sub LoadOrders()
        Dim query As String = "SELECT Orders.Id, Books.Title, Orders.Quantity, Orders.TotalPrice FROM Orders INNER JOIN Books ON Orders.BookId = Books.Id"
        Dim cmd As New SQLiteCommand(query, conn)
        Dim adapter As New SQLiteDataAdapter(cmd)
        Dim dt As New DataTable()
        adapter.Fill(dt)
        DataGridViewOrders.DataSource = dt
    End Sub

    Private Sub ButtonOrder_Click(sender As Object, e As EventArgs) Handles ButtonOrder.Click
        If ComboBoxBooks.SelectedItem Is Nothing Then
            MessageBox.Show("Please select a book.")
            Return
        End If

        Dim selectedBook As KeyValuePair(Of Integer, String) = CType(ComboBoxBooks.SelectedItem, KeyValuePair(Of Integer, String))
        Dim quantity As Integer

        If Not Integer.TryParse(TextBoxQuantity.Text, quantity) Then
            MessageBox.Show("Please enter a valid quantity.")
            Return
        End If

        If quantity <= 0 Then
            MessageBox.Show("Quantity must be greater than zero.")
            Return
        End If

        Dim price As Double
        Dim getPriceQuery As String = "SELECT Price FROM Books WHERE Id = @Id"
        Dim getPriceCmd As New SQLiteCommand(getPriceQuery, conn)
        getPriceCmd.Parameters.AddWithValue("@Id", selectedBook.Key)
        price = getPriceCmd.ExecuteScalar()

        Dim totalPrice As Double = quantity * price

        ' Use Select Case to handle different books dynamically
        Select Case selectedBook.Key
            Case 1
                MessageBox.Show("You've selected 'To Kill a Mockingbird'!")
            Case 2
                MessageBox.Show("You've selected '1984'!")
            Case 3
                MessageBox.Show("You've selected 'The Great Gatsby'!")
            Case 4
                MessageBox.Show("You've selected 'The Catcher in the Rye'!")
            Case 5
                MessageBox.Show("You've selected 'The Hobbit'!")
            Case 6
                MessageBox.Show("You've selected 'Fahrenheit 451'!")
            Case 7
                MessageBox.Show("You've selected 'Pride and Prejudice'!")
            Case 8
                MessageBox.Show("You've selected 'Animal Farm'!")
            Case 9
                MessageBox.Show("You've selected 'Jane Eyre'!")
            Case 10
                MessageBox.Show("You've selected 'Moby-Dick'!")
            Case 11
                MessageBox.Show("You've selected 'The Lord of the Rings'!")
            Case 12
                MessageBox.Show("You've selected 'War and Peace'!")
            Case 13
                MessageBox.Show("You've selected 'The Odyssey'!")
            Case 14
                MessageBox.Show("You've selected 'The Adventures of Huckleberry Finn'!")
            Case 15
                MessageBox.Show("You've selected 'Crime and Punishment'!")
            Case 16
                MessageBox.Show("You've selected 'Wuthering Heights'!")
            Case 17
                MessageBox.Show("You've selected 'Brave New World'!")
            Case 18
                MessageBox.Show("You've selected 'The Scarlet Letter'!")
            Case 19
                MessageBox.Show("You've selected 'The Kite Runner'!")
            Case 20
                MessageBox.Show("You've selected 'Great Expectations'!")
            Case 21
                MessageBox.Show("You've selected 'The Diary of a Young Girl'!")
            Case 22
                MessageBox.Show("You've selected 'The Brothers Karamazov'!")
            Case 23
                MessageBox.Show("You've selected 'The Iliad'!")
            Case 24
                MessageBox.Show("You've selected 'Catch-22'!")
            Case 25
                MessageBox.Show("You've selected 'Les Misérables'!")
            Case 26
                MessageBox.Show("You've selected 'The Grapes of Wrath'!")
            Case 27
                MessageBox.Show("You've selected 'Dracula'!")
            Case 28
                MessageBox.Show("You've selected 'The Count of Monte Cristo'!")
            Case 29
                MessageBox.Show("You've selected 'Gone with the Wind'!")
            Case 30
                MessageBox.Show("You've selected 'Frankenstein'!")
            Case 31
                MessageBox.Show("You've selected 'The Picture of Dorian Gray'!")
            Case 32
                MessageBox.Show("You've selected 'Anna Karenina'!")
            Case 33
                MessageBox.Show("You've selected 'The Shining'!")
            Case 34
                MessageBox.Show("You've selected 'Don Quixote'!")
            Case 35
                MessageBox.Show("You've selected 'One Hundred Years of Solitude'!")
            Case 36
                MessageBox.Show("You've selected 'Beloved'!")
            Case 37
                MessageBox.Show("You've selected 'A Tale of Two Cities'!")
            Case 38
                MessageBox.Show("You've selected 'Lolita'!")
            Case 39
                MessageBox.Show("You've selected 'Rebecca'!")
            Case 40
                MessageBox.Show("You've selected 'Heart of Darkness'!")
            Case 41
                MessageBox.Show("You've selected 'The Sun Also Rises'!")
            Case 42
                MessageBox.Show("You've selected 'Slaughterhouse-Five'!")
            Case 43
                MessageBox.Show("You've selected 'The Road'!")
            Case 44
                MessageBox.Show("You've selected 'The Handmaid's Tale'!")
            Case 45
                MessageBox.Show("You've selected 'Invisible Man'!")
            Case 46
                MessageBox.Show("You've selected 'Life of Pi'!")
            Case 47
                MessageBox.Show("You've selected 'The Alchemist'!")
            Case 48
                MessageBox.Show("You've selected 'The Da Vinci Code'!")
            Case 49
                MessageBox.Show("You've selected 'Memoirs of a Geisha'!")
            Case 50
                MessageBox.Show("You've selected another book!")
            Case Else
                MessageBox.Show("You've selected another book!")
        End Select

        ' Use a loop to simulate processing multiple orders (example)
        For i As Integer = 1 To quantity
            ' Insert order into the Orders table
            Dim insertOrderQuery As String = "INSERT INTO Orders (BookId, Quantity, TotalPrice) VALUES (@BookId, @Quantity, @TotalPrice)"
            Dim insertOrderCmd As New SQLiteCommand(insertOrderQuery, conn)
            insertOrderCmd.Parameters.AddWithValue("@BookId", selectedBook.Key)
            insertOrderCmd.Parameters.AddWithValue("@Quantity", 1)
            insertOrderCmd.Parameters.AddWithValue("@TotalPrice", price)
            insertOrderCmd.ExecuteNonQuery()
        Next

        ' Refresh orders DataGridView
        LoadOrders()

        MessageBox.Show("Order placed successfully!")
    End Sub

    Private Sub ButtonAddBook_Click(sender As Object, e As EventArgs) Handles ButtonAddBook.Click
        Dim formBookInput As New FormBookInput(conn)
        formBookInput.ShowDialog()
        PopulateBooksComboBox()
    End Sub
End Class
