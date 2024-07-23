# Aplikasi Pemesanan Buku

## Overview

"Aplikasi Pemesanan Buku" is a simple Windows Forms application built using Visual Basic. This application allows users to order books from a predefined list, manage book collections, and view the order history. The application utilizes SQLite as its database for storing book and order information.

## Features

- **Book Ordering**: Select a book and specify the quantity to place an order.
- **Book Collection Management**: Add new books to the collection.
- **Order History**: View a list of all placed orders.

## Logic Implementation

### `If` Statements

- **Quantity Validation**: Ensures that the user enters a valid quantity for the order.
- **Selection Validation**: Ensures that a book is selected before placing an order.

### `Select Case` Statements

- **Dynamic Book Handling**: Displays a specific message based on the selected book's ID.

### Looping

- **Order Processing**: Simulates processing multiple orders by inserting them into the database.

## Database

The application uses SQLite as the database to store information about books and orders. The database schema consists of two tables:

1. **Books**
   - `Id` (INTEGER, PRIMARY KEY)
   - `Title` (TEXT)
   - `Author` (TEXT)
   - `Price` (REAL)

2. **Orders**
   - `Id` (INTEGER, PRIMARY KEY)
   - `BookId` (INTEGER, FOREIGN KEY)
   - `Quantity` (INTEGER)
   - `TotalPrice` (REAL)

## Project Structure

```
AplikasiPemesananBuku/
│
├── AplikasiPemesananBuku.vbproj
├── Form1.vb
├── Form1.Designer.vb
├── FormBookInput.vb
├── FormBookInput.Designer.vb
├── Program.vb
└── bookorder.db
```

## Installation

1. **Clone the repository**:
   ```sh
   git clone <repository-url>
   cd AplikasiPemesananBuku
   ```

2. **Install dependencies**:
   Ensure you have the .NET SDK and SQLite installed on your machine.

3. **Build the project**:
   ```sh
   dotnet build
   ```

4. **Run the project**:
   ```sh
   dotnet run
   ```

## Usage

1. **Book Ordering**:
   - Launch the application.
   - Select a book from the dropdown list.
   - Enter the quantity.
   - Click "Place Order" to submit your order.

2. **Add New Book**:
   - Click the "Add Book" button.
   - Fill in the book details (Title, Author, Price).
   - Click "Save" to add the book to the collection.

3. **View Order History**:
   - The order history is displayed in the DataGridView at the bottom of the main form.

## Example Logic Snippets

### If Statements

```vb
If ComboBoxBooks.SelectedItem Is Nothing Then
    MessageBox.Show("Please select a book.")
    Return
End If

If Not Integer.TryParse(TextBoxQuantity.Text, quantity) Then
    MessageBox.Show("Please enter a valid quantity.")
    Return
End If

If quantity <= 0 Then
    MessageBox.Show("Quantity must be greater than zero.")
    Return
End If
```

### Select Case Statements

```vb
Select Case selectedBook.Key
    Case 1
        MessageBox.Show("You've selected 'To Kill a Mockingbird'!")
    Case 2
        MessageBox.Show("You've selected '1984'!")
    ' Additional cases here...
    Case Else
        MessageBox.Show("You've selected another book!")
End Select
```

### Looping

```vb
For i As Integer = 1 To quantity
    Dim insertOrderQuery As String = "INSERT INTO Orders (BookId, Quantity, TotalPrice) VALUES (@BookId, @Quantity, @TotalPrice)"
    Dim insertOrderCmd As New SQLiteCommand(insertOrderQuery, conn)
    insertOrderCmd.Parameters.AddWithValue("@BookId", selectedBook.Key)
    insertOrderCmd.Parameters.AddWithValue("@Quantity", 1)
    insertOrderCmd.Parameters.AddWithValue("@TotalPrice", price)
    insertOrderCmd.ExecuteNonQuery()
Next
```

