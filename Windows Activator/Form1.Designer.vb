<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
    Me.Label1 = New System.Windows.Forms.Label()
    Me.Label2 = New System.Windows.Forms.Label()
    Me.Label3 = New System.Windows.Forms.Label()
    Me.TextBox1 = New System.Windows.Forms.TextBox()
    Me.Button1 = New System.Windows.Forms.Button()
    Me.Button2 = New System.Windows.Forms.Button()
    Me.GroupBox1 = New System.Windows.Forms.GroupBox()
    Me.TextBox2 = New System.Windows.Forms.TextBox()
    Me.ListBox1 = New System.Windows.Forms.ListBox()
    Me.CheckBox1 = New System.Windows.Forms.CheckBox()
    Me.Label4 = New System.Windows.Forms.Label()
    Me.Label5 = New System.Windows.Forms.Label()
    Me.TextBox3 = New System.Windows.Forms.TextBox()
    Me.Label6 = New System.Windows.Forms.Label()
    Me.ListBox2 = New System.Windows.Forms.ListBox()
    Me.GroupBox1.SuspendLayout()
    Me.SuspendLayout()
    '
    'Label1
    '
    Me.Label1.AutoSize = True
    Me.Label1.Location = New System.Drawing.Point(24, 34)
    Me.Label1.Name = "Label1"
    Me.Label1.Size = New System.Drawing.Size(54, 13)
    Me.Label1.TabIndex = 0
    Me.Label1.Text = "Windows:"
    '
    'Label2
    '
    Me.Label2.AutoSize = True
    Me.Label2.Location = New System.Drawing.Point(24, 73)
    Me.Label2.Name = "Label2"
    Me.Label2.Size = New System.Drawing.Size(28, 13)
    Me.Label2.TabIndex = 1
    Me.Label2.Text = "Key:"
    '
    'Label3
    '
    Me.Label3.AutoSize = True
    Me.Label3.ForeColor = System.Drawing.Color.Aqua
    Me.Label3.Location = New System.Drawing.Point(84, 34)
    Me.Label3.Name = "Label3"
    Me.Label3.Size = New System.Drawing.Size(16, 13)
    Me.Label3.TabIndex = 2
    Me.Label3.Text = "..."
    '
    'TextBox1
    '
    Me.TextBox1.Location = New System.Drawing.Point(58, 70)
    Me.TextBox1.Name = "TextBox1"
    Me.TextBox1.Size = New System.Drawing.Size(310, 20)
    Me.TextBox1.TabIndex = 3
    '
    'Button1
    '
    Me.Button1.Location = New System.Drawing.Point(6, 36)
    Me.Button1.Name = "Button1"
    Me.Button1.Size = New System.Drawing.Size(92, 21)
    Me.Button1.TabIndex = 4
    Me.Button1.Text = "Install"
    Me.Button1.UseVisualStyleBackColor = True
    '
    'Button2
    '
    Me.Button2.Location = New System.Drawing.Point(6, 63)
    Me.Button2.Name = "Button2"
    Me.Button2.Size = New System.Drawing.Size(92, 21)
    Me.Button2.TabIndex = 5
    Me.Button2.Text = "UnInstall"
    Me.Button2.UseVisualStyleBackColor = True
    '
    'GroupBox1
    '
    Me.GroupBox1.Controls.Add(Me.ListBox2)
    Me.GroupBox1.Controls.Add(Me.Label5)
    Me.GroupBox1.Controls.Add(Me.Label4)
    Me.GroupBox1.Controls.Add(Me.ListBox1)
    Me.GroupBox1.Controls.Add(Me.CheckBox1)
    Me.GroupBox1.Controls.Add(Me.TextBox2)
    Me.GroupBox1.Controls.Add(Me.Button1)
    Me.GroupBox1.Controls.Add(Me.Button2)
    Me.GroupBox1.Location = New System.Drawing.Point(27, 112)
    Me.GroupBox1.Name = "GroupBox1"
    Me.GroupBox1.Size = New System.Drawing.Size(684, 297)
    Me.GroupBox1.TabIndex = 6
    Me.GroupBox1.TabStop = False
    Me.GroupBox1.Text = "Licence"
    '
    'TextBox2
    '
    Me.TextBox2.BackColor = System.Drawing.Color.Black
    Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
    Me.TextBox2.Dock = System.Windows.Forms.DockStyle.Bottom
    Me.TextBox2.ForeColor = System.Drawing.Color.Lime
    Me.TextBox2.Location = New System.Drawing.Point(3, 189)
    Me.TextBox2.Multiline = True
    Me.TextBox2.Name = "TextBox2"
    Me.TextBox2.ReadOnly = True
    Me.TextBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both
    Me.TextBox2.Size = New System.Drawing.Size(678, 105)
    Me.TextBox2.TabIndex = 8
    '
    'ListBox1
    '
    Me.ListBox1.FormattingEnabled = True
    Me.ListBox1.Location = New System.Drawing.Point(104, 36)
    Me.ListBox1.Name = "ListBox1"
    Me.ListBox1.Size = New System.Drawing.Size(267, 147)
    Me.ListBox1.TabIndex = 7
    '
    'CheckBox1
    '
    Me.CheckBox1.AutoSize = True
    Me.CheckBox1.Location = New System.Drawing.Point(3, 109)
    Me.CheckBox1.Name = "CheckBox1"
    Me.CheckBox1.Size = New System.Drawing.Size(101, 17)
    Me.CheckBox1.TabIndex = 9
    Me.CheckBox1.Text = "By Manufacture"
    Me.CheckBox1.UseVisualStyleBackColor = True
    '
    'Label4
    '
    Me.Label4.AutoSize = True
    Me.Label4.Location = New System.Drawing.Point(6, 152)
    Me.Label4.Name = "Label4"
    Me.Label4.Size = New System.Drawing.Size(33, 13)
    Me.Label4.TabIndex = 10
    Me.Label4.Text = "Keys:"
    '
    'Label5
    '
    Me.Label5.AutoSize = True
    Me.Label5.Location = New System.Drawing.Point(45, 152)
    Me.Label5.Name = "Label5"
    Me.Label5.Size = New System.Drawing.Size(13, 13)
    Me.Label5.TabIndex = 11
    Me.Label5.Text = "0"
    '
    'TextBox3
    '
    Me.TextBox3.Location = New System.Drawing.Point(434, 70)
    Me.TextBox3.Name = "TextBox3"
    Me.TextBox3.Size = New System.Drawing.Size(274, 20)
    Me.TextBox3.TabIndex = 8
    '
    'Label6
    '
    Me.Label6.AutoSize = True
    Me.Label6.Location = New System.Drawing.Point(387, 73)
    Me.Label6.Name = "Label6"
    Me.Label6.Size = New System.Drawing.Size(41, 13)
    Me.Label6.TabIndex = 7
    Me.Label6.Text = "Server:"
    '
    'ListBox2
    '
    Me.ListBox2.FormattingEnabled = True
    Me.ListBox2.Items.AddRange(New Object() {"kms.jm33.me", "kms7.MSGuides.com", "kms8.MSGuides.com", "kms9.MSGuides.com"})
    Me.ListBox2.Location = New System.Drawing.Point(395, 36)
    Me.ListBox2.Name = "ListBox2"
    Me.ListBox2.Size = New System.Drawing.Size(283, 147)
    Me.ListBox2.TabIndex = 12
    '
    'Form1
    '
    Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
    Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
    Me.ClientSize = New System.Drawing.Size(723, 425)
    Me.Controls.Add(Me.TextBox3)
    Me.Controls.Add(Me.Label6)
    Me.Controls.Add(Me.GroupBox1)
    Me.Controls.Add(Me.TextBox1)
    Me.Controls.Add(Me.Label3)
    Me.Controls.Add(Me.Label2)
    Me.Controls.Add(Me.Label1)
    Me.Name = "Form1"
    Me.Text = "Form1"
    Me.GroupBox1.ResumeLayout(False)
    Me.GroupBox1.PerformLayout()
    Me.ResumeLayout(False)
    Me.PerformLayout()

  End Sub
  Friend WithEvents Label1 As System.Windows.Forms.Label
  Friend WithEvents Label2 As System.Windows.Forms.Label
  Friend WithEvents Label3 As System.Windows.Forms.Label
  Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
  Friend WithEvents Button1 As System.Windows.Forms.Button
  Friend WithEvents Button2 As System.Windows.Forms.Button
  Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
  Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
  Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
  Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
  Friend WithEvents Label5 As System.Windows.Forms.Label
  Friend WithEvents Label4 As System.Windows.Forms.Label
  Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
  Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
  Friend WithEvents Label6 As System.Windows.Forms.Label

End Class
