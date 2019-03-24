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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Save_Button = New System.Windows.Forms.Button()
        Me.Run_Button = New System.Windows.Forms.Button()
        Me.FileNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PathTextbox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ISSavedTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Date_Label = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Lavender
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Navy
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 27)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(563, 377)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = "//Perl Code Here"
        '
        'Save_Button
        '
        Me.Save_Button.Location = New System.Drawing.Point(401, 407)
        Me.Save_Button.Name = "Save_Button"
        Me.Save_Button.Size = New System.Drawing.Size(75, 23)
        Me.Save_Button.TabIndex = 1
        Me.Save_Button.Text = "Save"
        Me.Save_Button.UseVisualStyleBackColor = True
        '
        'Run_Button
        '
        Me.Run_Button.Location = New System.Drawing.Point(482, 407)
        Me.Run_Button.Name = "Run_Button"
        Me.Run_Button.Size = New System.Drawing.Size(75, 23)
        Me.Run_Button.TabIndex = 2
        Me.Run_Button.Text = "Run"
        Me.Run_Button.UseVisualStyleBackColor = True
        '
        'FileNameTextBox
        '
        Me.FileNameTextBox.Location = New System.Drawing.Point(66, 430)
        Me.FileNameTextBox.Name = "FileNameTextBox"
        Me.FileNameTextBox.Size = New System.Drawing.Size(162, 20)
        Me.FileNameTextBox.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 430)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "File Name"
        '
        'PathTextbox
        '
        Me.PathTextbox.Location = New System.Drawing.Point(66, 409)
        Me.PathTextbox.Name = "PathTextbox"
        Me.PathTextbox.Size = New System.Drawing.Size(329, 20)
        Me.PathTextbox.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 409)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Location"
        '
        'ISSavedTextBox
        '
        Me.ISSavedTextBox.Location = New System.Drawing.Point(552, 4)
        Me.ISSavedTextBox.Name = "ISSavedTextBox"
        Me.ISSavedTextBox.Size = New System.Drawing.Size(23, 20)
        Me.ISSavedTextBox.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(398, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Current Script Saved Status"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.MenuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.MenuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MdiWindowListItem = Me.ToolStripMenuItem1
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(586, 24)
        Me.MenuStrip1.TabIndex = 10
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(61, 20)
        Me.ToolStripMenuItem1.Text = "Settings"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(158, 22)
        Me.ToolStripMenuItem2.Text = "Global Perl Path"
        '
        'Date_Label
        '
        Me.Date_Label.AutoSize = True
        Me.Date_Label.Location = New System.Drawing.Point(203, 7)
        Me.Date_Label.Name = "Date_Label"
        Me.Date_Label.Size = New System.Drawing.Size(58, 13)
        Me.Date_Label.TabIndex = 11
        Me.Date_Label.Text = "Last Save:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.ClientSize = New System.Drawing.Size(586, 454)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Date_Label)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ISSavedTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PathTextbox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FileNameTextBox)
        Me.Controls.Add(Me.Run_Button)
        Me.Controls.Add(Me.Save_Button)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "PerlyWhirly"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents Save_Button As System.Windows.Forms.Button
    Friend WithEvents Run_Button As System.Windows.Forms.Button
    Friend WithEvents FileNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PathTextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ISSavedTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Date_Label As System.Windows.Forms.Label

End Class
