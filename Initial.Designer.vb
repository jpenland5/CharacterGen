<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Initial
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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCHA = New System.Windows.Forms.Label()
        Me.lblWIS = New System.Windows.Forms.Label()
        Me.lblINT = New System.Windows.Forms.Label()
        Me.lblCON = New System.Windows.Forms.Label()
        Me.lblDEX = New System.Windows.Forms.Label()
        Me.lblSTR = New System.Windows.Forms.Label()
        Me.btnScores = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveCharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoadCharacterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnSkills = New System.Windows.Forms.Button()
        Me.btnFeats = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnClass = New System.Windows.Forms.Button()
        Me.btnRace = New System.Windows.Forms.Button()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnAlign = New System.Windows.Forms.Button()
        Me.lblGender = New System.Windows.Forms.Label()
        Me.btnGender = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(62, 31)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name: "
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(14, 391)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(280, 120)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(18, 372)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Biography (Optional): "
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCHA)
        Me.GroupBox1.Controls.Add(Me.lblWIS)
        Me.GroupBox1.Controls.Add(Me.lblINT)
        Me.GroupBox1.Controls.Add(Me.lblCON)
        Me.GroupBox1.Controls.Add(Me.lblDEX)
        Me.GroupBox1.Controls.Add(Me.lblSTR)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 186)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 157)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ability Scores"
        '
        'lblCHA
        '
        Me.lblCHA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCHA.Location = New System.Drawing.Point(15, 122)
        Me.lblCHA.Name = "lblCHA"
        Me.lblCHA.Size = New System.Drawing.Size(90, 20)
        Me.lblCHA.TabIndex = 6
        Me.lblCHA.Text = "Charisma: 8"
        Me.lblCHA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWIS
        '
        Me.lblWIS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblWIS.Location = New System.Drawing.Point(15, 102)
        Me.lblWIS.Name = "lblWIS"
        Me.lblWIS.Size = New System.Drawing.Size(90, 20)
        Me.lblWIS.TabIndex = 5
        Me.lblWIS.Text = "Wisdom: 8"
        Me.lblWIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblINT
        '
        Me.lblINT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblINT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblINT.Location = New System.Drawing.Point(15, 82)
        Me.lblINT.Name = "lblINT"
        Me.lblINT.Size = New System.Drawing.Size(90, 20)
        Me.lblINT.TabIndex = 3
        Me.lblINT.Text = "Intelligence: 8"
        Me.lblINT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCON
        '
        Me.lblCON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCON.Location = New System.Drawing.Point(15, 62)
        Me.lblCON.Name = "lblCON"
        Me.lblCON.Size = New System.Drawing.Size(90, 20)
        Me.lblCON.TabIndex = 2
        Me.lblCON.Text = "Constitution: 8"
        Me.lblCON.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDEX
        '
        Me.lblDEX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDEX.Location = New System.Drawing.Point(15, 42)
        Me.lblDEX.Name = "lblDEX"
        Me.lblDEX.Size = New System.Drawing.Size(90, 20)
        Me.lblDEX.TabIndex = 1
        Me.lblDEX.Text = "Dexterity: 8"
        Me.lblDEX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSTR
        '
        Me.lblSTR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblSTR.Location = New System.Drawing.Point(15, 22)
        Me.lblSTR.Name = "lblSTR"
        Me.lblSTR.Size = New System.Drawing.Size(90, 20)
        Me.lblSTR.TabIndex = 0
        Me.lblSTR.Text = "Strength: 8"
        Me.lblSTR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnScores
        '
        Me.btnScores.Location = New System.Drawing.Point(165, 186)
        Me.btnScores.Name = "btnScores"
        Me.btnScores.Size = New System.Drawing.Size(129, 23)
        Me.btnScores.TabIndex = 5
        Me.btnScores.Text = "Choose Ability Scores"
        Me.btnScores.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ViewToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(304, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripMenuItem, Me.SaveCharacterToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "New Character"
        '
        'SaveCharacterToolStripMenuItem
        '
        Me.SaveCharacterToolStripMenuItem.Name = "SaveCharacterToolStripMenuItem"
        Me.SaveCharacterToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveCharacterToolStripMenuItem.Text = "Save Character"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LoadCharacterToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'LoadCharacterToolStripMenuItem
        '
        Me.LoadCharacterToolStripMenuItem.Name = "LoadCharacterToolStripMenuItem"
        Me.LoadCharacterToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.LoadCharacterToolStripMenuItem.Text = "Load Character"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(122, 22)
        Me.ContentsToolStripMenuItem.Text = "Contents"
        '
        'btnSkills
        '
        Me.btnSkills.Location = New System.Drawing.Point(165, 244)
        Me.btnSkills.Name = "btnSkills"
        Me.btnSkills.Size = New System.Drawing.Size(129, 23)
        Me.btnSkills.TabIndex = 7
        Me.btnSkills.Text = "Choose Skills"
        Me.btnSkills.UseVisualStyleBackColor = True
        '
        'btnFeats
        '
        Me.btnFeats.Location = New System.Drawing.Point(165, 215)
        Me.btnFeats.Name = "btnFeats"
        Me.btnFeats.Size = New System.Drawing.Size(129, 23)
        Me.btnFeats.TabIndex = 8
        Me.btnFeats.Text = "Choose Feats"
        Me.btnFeats.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Enabled = False
        Me.btnSave.Location = New System.Drawing.Point(165, 273)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(129, 23)
        Me.btnSave.TabIndex = 9
        Me.btnSave.Text = "Save Character"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnClass
        '
        Me.btnClass.Location = New System.Drawing.Point(165, 128)
        Me.btnClass.Name = "btnClass"
        Me.btnClass.Size = New System.Drawing.Size(129, 23)
        Me.btnClass.TabIndex = 10
        Me.btnClass.Text = "Choose Class"
        Me.btnClass.UseVisualStyleBackColor = True
        '
        'btnRace
        '
        Me.btnRace.Location = New System.Drawing.Point(165, 70)
        Me.btnRace.Name = "btnRace"
        Me.btnRace.Size = New System.Drawing.Size(129, 23)
        Me.btnRace.TabIndex = 11
        Me.btnRace.Text = "Choose Race"
        Me.btnRace.UseVisualStyleBackColor = True
        '
        'lblRace
        '
        Me.lblRace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblRace.Location = New System.Drawing.Point(21, 71)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(118, 20)
        Me.lblRace.TabIndex = 7
        Me.lblRace.Text = "Race: "
        Me.lblRace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClass
        '
        Me.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblClass.Location = New System.Drawing.Point(21, 129)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(118, 20)
        Me.lblClass.TabIndex = 12
        Me.lblClass.Text = "Class: "
        Me.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label3.Location = New System.Drawing.Point(21, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Alignment: "
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAlign
        '
        Me.btnAlign.Location = New System.Drawing.Point(165, 157)
        Me.btnAlign.Name = "btnAlign"
        Me.btnAlign.Size = New System.Drawing.Size(129, 23)
        Me.btnAlign.TabIndex = 14
        Me.btnAlign.Text = "Choose Alignment"
        Me.btnAlign.UseVisualStyleBackColor = True
        '
        'lblGender
        '
        Me.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblGender.Location = New System.Drawing.Point(21, 100)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(118, 20)
        Me.lblGender.TabIndex = 15
        Me.lblGender.Text = "Gender: "
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnGender
        '
        Me.btnGender.Location = New System.Drawing.Point(165, 99)
        Me.btnGender.Name = "btnGender"
        Me.btnGender.Size = New System.Drawing.Size(129, 23)
        Me.btnGender.TabIndex = 16
        Me.btnGender.Text = "Choose Gender"
        Me.btnGender.UseVisualStyleBackColor = True
        '
        'Initial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(304, 523)
        Me.Controls.Add(Me.btnGender)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.btnAlign)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblRace)
        Me.Controls.Add(Me.btnRace)
        Me.Controls.Add(Me.btnClass)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnFeats)
        Me.Controls.Add(Me.btnSkills)
        Me.Controls.Add(Me.btnScores)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Initial"
        Me.Text = "D&D 3rd Ed Character Creator"
        Me.GroupBox1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCHA As Label
    Friend WithEvents lblWIS As Label
    Friend WithEvents lblINT As Label
    Friend WithEvents lblCON As Label
    Friend WithEvents lblDEX As Label
    Friend WithEvents lblSTR As Label
    Friend WithEvents btnScores As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveCharacterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoadCharacterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnSkills As Button
    Friend WithEvents btnFeats As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnClass As Button
    Friend WithEvents btnRace As Button
    Friend WithEvents lblRace As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnAlign As Button
    Friend WithEvents lblGender As Label
    Friend WithEvents btnGender As Button
End Class
