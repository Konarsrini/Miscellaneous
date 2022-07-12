<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Btn1 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BtnX = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'LblName
        '
        Me.LblName.AutoSize = True
        Me.LblName.Location = New System.Drawing.Point(33, 20)
        Me.LblName.Name = "LblName"
        Me.LblName.Size = New System.Drawing.Size(39, 15)
        Me.LblName.TabIndex = 0
        Me.LblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(88, 19)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(366, 23)
        Me.txtName.TabIndex = 1
        '
        'Btn1
        '
        Me.Btn1.Location = New System.Drawing.Point(88, 69)
        Me.Btn1.Name = "Btn1"
        Me.Btn1.Size = New System.Drawing.Size(75, 23)
        Me.Btn1.TabIndex = 2
        Me.Btn1.Text = "OK"
        Me.Btn1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 69)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Message"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BtnX
        '
        Me.BtnX.Location = New System.Drawing.Point(379, 69)
        Me.BtnX.Name = "BtnX"
        Me.BtnX.Size = New System.Drawing.Size(75, 23)
        Me.BtnX.TabIndex = 4
        Me.BtnX.Text = "Exit"
        Me.BtnX.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DisplayMember = "ji"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Apple", "PineApple", "Orange", "Grapes", "Banana", "Cherries"})
        Me.ComboBox1.Location = New System.Drawing.Point(87, 124)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 23)
        Me.ComboBox1.TabIndex = 5
        Me.ComboBox1.ValueMember = "ji"
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(89, 185)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(120, 94)
        Me.CheckedListBox1.TabIndex = 7
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"TEST", "PROD", "UAT"})
        Me.ListBox1.Location = New System.Drawing.Point(284, 193)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 94)
        Me.ListBox1.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.CheckedListBox1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.BtnX)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Btn1)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.LblName)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Btn1 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BtnX As Button
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents ListBox1 As ListBox
End Class
