<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormBookInput
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.LabelTitle = New System.Windows.Forms.Label()
        Me.TextBoxTitle = New System.Windows.Forms.TextBox()
        Me.LabelAuthor = New System.Windows.Forms.Label()
        Me.TextBoxAuthor = New System.Windows.Forms.TextBox()
        Me.LabelPrice = New System.Windows.Forms.Label()
        Me.TextBoxPrice = New System.Windows.Forms.TextBox()
        Me.ButtonSave = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelTitle
        '
        Me.LabelTitle.AutoSize = True
        Me.LabelTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelTitle.Location = New System.Drawing.Point(30, 30)
        Me.LabelTitle.Name = "LabelTitle"
        Me.LabelTitle.Size = New System.Drawing.Size(39, 17)
        Me.LabelTitle.TabIndex = 0
        Me.LabelTitle.Text = "Title:"
        '
        'TextBoxTitle
        '
        Me.TextBoxTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxTitle.Location = New System.Drawing.Point(100, 27)
        Me.TextBoxTitle.Name = "TextBoxTitle"
        Me.TextBoxTitle.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxTitle.TabIndex = 1
        '
        'LabelAuthor
        '
        Me.LabelAuthor.AutoSize = True
        Me.LabelAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelAuthor.Location = New System.Drawing.Point(30, 70)
        Me.LabelAuthor.Name = "LabelAuthor"
        Me.LabelAuthor.Size = New System.Drawing.Size(54, 17)
        Me.LabelAuthor.TabIndex = 2
        Me.LabelAuthor.Text = "Author:"
        '
        'TextBoxAuthor
        '
        Me.TextBoxAuthor.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxAuthor.Location = New System.Drawing.Point(100, 67)
        Me.TextBoxAuthor.Name = "TextBoxAuthor"
        Me.TextBoxAuthor.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxAuthor.TabIndex = 3
        '
        'LabelPrice
        '
        Me.LabelPrice.AutoSize = True
        Me.LabelPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.LabelPrice.Location = New System.Drawing.Point(30, 110)
        Me.LabelPrice.Name = "LabelPrice"
        Me.LabelPrice.Size = New System.Drawing.Size(44, 17)
        Me.LabelPrice.TabIndex = 4
        Me.LabelPrice.Text = "Price:"
        '
        'TextBoxPrice
        '
        Me.TextBoxPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.TextBoxPrice.Location = New System.Drawing.Point(100, 107)
        Me.TextBoxPrice.Name = "TextBoxPrice"
        Me.TextBoxPrice.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxPrice.TabIndex = 5
        '
        'ButtonSave
        '
        Me.ButtonSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.ButtonSave.Location = New System.Drawing.Point(100, 150)
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.Size = New System.Drawing.Size(200, 30)
        Me.ButtonSave.TabIndex = 6
        Me.ButtonSave.Text = "Save"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'FormBookInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 211)
        Me.Controls.Add(Me.ButtonSave)
        Me.Controls.Add(Me.TextBoxPrice)
        Me.Controls.Add(Me.LabelPrice)
        Me.Controls.Add(Me.TextBoxAuthor)
        Me.Controls.Add(Me.LabelAuthor)
        Me.Controls.Add(Me.TextBoxTitle)
        Me.Controls.Add(Me.LabelTitle)
        Me.Name = "FormBookInput"
        Me.Text = "Add New Book"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents LabelTitle As Label
    Private WithEvents TextBoxTitle As TextBox
    Private WithEvents LabelAuthor As Label
    Private WithEvents TextBoxAuthor As TextBox
    Private WithEvents LabelPrice As Label
    Private WithEvents TextBoxPrice As TextBox
    Private WithEvents ButtonSave As Button
End Class
