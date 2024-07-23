<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    Private components As System.ComponentModel.IContainer = Nothing

    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBoxBooks = New System.Windows.Forms.ComboBox()
        Me.TextBoxQuantity = New System.Windows.Forms.TextBox()
        Me.ButtonOrder = New System.Windows.Forms.Button()
        Me.ButtonAddBook = New System.Windows.Forms.Button()
        Me.DataGridViewOrders = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridViewOrders, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(30, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Select a Book:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(30, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Quantity:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(30, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Orders:"
        '
        'ComboBoxBooks
        '
        Me.ComboBoxBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxBooks.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ComboBoxBooks.FormattingEnabled = True
        Me.ComboBoxBooks.Location = New System.Drawing.Point(130, 27)
        Me.ComboBoxBooks.Name = "ComboBoxBooks"
        Me.ComboBoxBooks.Size = New System.Drawing.Size(300, 24)
        Me.ComboBoxBooks.TabIndex = 3
        '
        'TextBoxQuantity
        '
        Me.TextBoxQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxQuantity.Location = New System.Drawing.Point(130, 67)
        Me.TextBoxQuantity.Name = "TextBoxQuantity"
        Me.TextBoxQuantity.Size = New System.Drawing.Size(300, 23)
        Me.TextBoxQuantity.TabIndex = 4
        '
        'ButtonOrder
        '
        Me.ButtonOrder.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonOrder.Location = New System.Drawing.Point(130, 110)
        Me.ButtonOrder.Name = "ButtonOrder"
        Me.ButtonOrder.Size = New System.Drawing.Size(150, 30)
        Me.ButtonOrder.TabIndex = 5
        Me.ButtonOrder.Text = "Place Order"
        Me.ButtonOrder.UseVisualStyleBackColor = True
        '
        'ButtonAddBook
        '
        Me.ButtonAddBook.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonAddBook.Location = New System.Drawing.Point(280, 110)
        Me.ButtonAddBook.Name = "ButtonAddBook"
        Me.ButtonAddBook.Size = New System.Drawing.Size(150, 30)
        Me.ButtonAddBook.TabIndex = 7
        Me.ButtonAddBook.Text = "Add Book"
        Me.ButtonAddBook.UseVisualStyleBackColor = True
        '
        'DataGridViewOrders
        '
        Me.DataGridViewOrders.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridViewOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewOrders.Location = New System.Drawing.Point(30, 180)
        Me.DataGridViewOrders.Name = "DataGridViewOrders"
        Me.DataGridViewOrders.Size = New System.Drawing.Size(600, 200)
        Me.DataGridViewOrders.TabIndex = 6
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 411)
        Me.Controls.Add(Me.DataGridViewOrders)
        Me.Controls.Add(Me.ButtonAddBook)
        Me.Controls.Add(Me.ButtonOrder)
        Me.Controls.Add(Me.TextBoxQuantity)
        Me.Controls.Add(Me.ComboBoxBooks)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Aplikasi Pemesanan Buku"
        AddHandler Me.Load, AddressOf Me.Form1_Load
        CType(Me.DataGridViewOrders, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Private WithEvents Label3 As Label
    Private WithEvents ComboBoxBooks As ComboBox
    Private WithEvents TextBoxQuantity As TextBox
    Private WithEvents ButtonOrder As Button
    Private WithEvents ButtonAddBook As Button
    Private WithEvents DataGridViewOrders As DataGridView
End Class
