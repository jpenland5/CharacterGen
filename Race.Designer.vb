<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Race
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Race))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnHuman = New System.Windows.Forms.Button()
        Me.btnDwarf = New System.Windows.Forms.Button()
        Me.btnElf = New System.Windows.Forms.Button()
        Me.btnGnome = New System.Windows.Forms.Button()
        Me.btnOrc = New System.Windows.Forms.Button()
        Me.btnHalf = New System.Windows.Forms.Button()
        Me.btnElf2 = New System.Windows.Forms.Button()
        Me.rtbRaceDetail = New System.Windows.Forms.RichTextBox()
        Me.btnSaveRace = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(111, 13)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(257, 63)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'btnHuman
        '
        Me.btnHuman.Location = New System.Drawing.Point(13, 13)
        Me.btnHuman.Name = "btnHuman"
        Me.btnHuman.Size = New System.Drawing.Size(75, 23)
        Me.btnHuman.TabIndex = 1
        Me.btnHuman.Text = "Human"
        Me.btnHuman.UseVisualStyleBackColor = True
        '
        'btnDwarf
        '
        Me.btnDwarf.Location = New System.Drawing.Point(13, 43)
        Me.btnDwarf.Name = "btnDwarf"
        Me.btnDwarf.Size = New System.Drawing.Size(75, 23)
        Me.btnDwarf.TabIndex = 2
        Me.btnDwarf.Text = "Dwarf"
        Me.btnDwarf.UseVisualStyleBackColor = True
        '
        'btnElf
        '
        Me.btnElf.Location = New System.Drawing.Point(13, 73)
        Me.btnElf.Name = "btnElf"
        Me.btnElf.Size = New System.Drawing.Size(75, 23)
        Me.btnElf.TabIndex = 3
        Me.btnElf.Text = "Elf"
        Me.btnElf.UseVisualStyleBackColor = True
        '
        'btnGnome
        '
        Me.btnGnome.Location = New System.Drawing.Point(13, 103)
        Me.btnGnome.Name = "btnGnome"
        Me.btnGnome.Size = New System.Drawing.Size(75, 23)
        Me.btnGnome.TabIndex = 4
        Me.btnGnome.Text = "Gnome"
        Me.btnGnome.UseVisualStyleBackColor = True
        '
        'btnOrc
        '
        Me.btnOrc.Location = New System.Drawing.Point(13, 133)
        Me.btnOrc.Name = "btnOrc"
        Me.btnOrc.Size = New System.Drawing.Size(75, 23)
        Me.btnOrc.TabIndex = 5
        Me.btnOrc.Text = "Half-Orc"
        Me.btnOrc.UseVisualStyleBackColor = True
        '
        'btnHalf
        '
        Me.btnHalf.Location = New System.Drawing.Point(13, 163)
        Me.btnHalf.Name = "btnHalf"
        Me.btnHalf.Size = New System.Drawing.Size(75, 23)
        Me.btnHalf.TabIndex = 6
        Me.btnHalf.Text = "Halfling"
        Me.btnHalf.UseVisualStyleBackColor = True
        '
        'btnElf2
        '
        Me.btnElf2.Location = New System.Drawing.Point(13, 192)
        Me.btnElf2.Name = "btnElf2"
        Me.btnElf2.Size = New System.Drawing.Size(75, 23)
        Me.btnElf2.TabIndex = 7
        Me.btnElf2.Text = "Half-Elf"
        Me.btnElf2.UseVisualStyleBackColor = True
        '
        'rtbRaceDetail
        '
        Me.rtbRaceDetail.BackColor = System.Drawing.SystemColors.Control
        Me.rtbRaceDetail.Location = New System.Drawing.Point(111, 73)
        Me.rtbRaceDetail.Name = "rtbRaceDetail"
        Me.rtbRaceDetail.ReadOnly = True
        Me.rtbRaceDetail.Size = New System.Drawing.Size(257, 284)
        Me.rtbRaceDetail.TabIndex = 8
        Me.rtbRaceDetail.Text = ""
        '
        'btnSaveRace
        '
        Me.btnSaveRace.Location = New System.Drawing.Point(13, 250)
        Me.btnSaveRace.Name = "btnSaveRace"
        Me.btnSaveRace.Size = New System.Drawing.Size(75, 23)
        Me.btnSaveRace.TabIndex = 10
        Me.btnSaveRace.Text = "Save Race"
        Me.btnSaveRace.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 279)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 11
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Race
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 369)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSaveRace)
        Me.Controls.Add(Me.rtbRaceDetail)
        Me.Controls.Add(Me.btnElf2)
        Me.Controls.Add(Me.btnHalf)
        Me.Controls.Add(Me.btnOrc)
        Me.Controls.Add(Me.btnGnome)
        Me.Controls.Add(Me.btnElf)
        Me.Controls.Add(Me.btnDwarf)
        Me.Controls.Add(Me.btnHuman)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Race"
        Me.Text = "Race"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnHuman As Button
    Friend WithEvents btnDwarf As Button
    Friend WithEvents btnElf As Button
    Friend WithEvents btnGnome As Button
    Friend WithEvents btnOrc As Button
    Friend WithEvents btnHalf As Button
    Friend WithEvents btnElf2 As Button
    Friend WithEvents rtbRaceDetail As RichTextBox
    Friend WithEvents btnSaveRace As Button
    Friend WithEvents btnBack As Button
End Class
