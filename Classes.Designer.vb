<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Classes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Classes))
        Me.btnBarb = New System.Windows.Forms.Button()
        Me.btnBard = New System.Windows.Forms.Button()
        Me.btnCleric = New System.Windows.Forms.Button()
        Me.btnDruid = New System.Windows.Forms.Button()
        Me.btnFighter = New System.Windows.Forms.Button()
        Me.btnMonk = New System.Windows.Forms.Button()
        Me.btnPal = New System.Windows.Forms.Button()
        Me.btnRogue = New System.Windows.Forms.Button()
        Me.btnRanger = New System.Windows.Forms.Button()
        Me.btnWiz = New System.Windows.Forms.Button()
        Me.btnSorc = New System.Windows.Forms.Button()
        Me.rtbClassDetail = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBarb
        '
        Me.btnBarb.Location = New System.Drawing.Point(12, 12)
        Me.btnBarb.Name = "btnBarb"
        Me.btnBarb.Size = New System.Drawing.Size(75, 23)
        Me.btnBarb.TabIndex = 0
        Me.btnBarb.Text = "Barbarian"
        Me.btnBarb.UseVisualStyleBackColor = True
        '
        'btnBard
        '
        Me.btnBard.Location = New System.Drawing.Point(12, 41)
        Me.btnBard.Name = "btnBard"
        Me.btnBard.Size = New System.Drawing.Size(75, 23)
        Me.btnBard.TabIndex = 1
        Me.btnBard.Text = "Bard"
        Me.btnBard.UseVisualStyleBackColor = True
        '
        'btnCleric
        '
        Me.btnCleric.Location = New System.Drawing.Point(12, 70)
        Me.btnCleric.Name = "btnCleric"
        Me.btnCleric.Size = New System.Drawing.Size(75, 23)
        Me.btnCleric.TabIndex = 2
        Me.btnCleric.Text = "Cleric"
        Me.btnCleric.UseVisualStyleBackColor = True
        '
        'btnDruid
        '
        Me.btnDruid.Location = New System.Drawing.Point(12, 99)
        Me.btnDruid.Name = "btnDruid"
        Me.btnDruid.Size = New System.Drawing.Size(75, 23)
        Me.btnDruid.TabIndex = 3
        Me.btnDruid.Text = "Druid"
        Me.btnDruid.UseVisualStyleBackColor = True
        '
        'btnFighter
        '
        Me.btnFighter.Location = New System.Drawing.Point(12, 128)
        Me.btnFighter.Name = "btnFighter"
        Me.btnFighter.Size = New System.Drawing.Size(75, 23)
        Me.btnFighter.TabIndex = 4
        Me.btnFighter.Text = "Fighter"
        Me.btnFighter.UseVisualStyleBackColor = True
        '
        'btnMonk
        '
        Me.btnMonk.Location = New System.Drawing.Point(12, 157)
        Me.btnMonk.Name = "btnMonk"
        Me.btnMonk.Size = New System.Drawing.Size(75, 23)
        Me.btnMonk.TabIndex = 5
        Me.btnMonk.Text = "Monk"
        Me.btnMonk.UseVisualStyleBackColor = True
        '
        'btnPal
        '
        Me.btnPal.Location = New System.Drawing.Point(12, 186)
        Me.btnPal.Name = "btnPal"
        Me.btnPal.Size = New System.Drawing.Size(75, 23)
        Me.btnPal.TabIndex = 6
        Me.btnPal.Text = "Paladin"
        Me.btnPal.UseVisualStyleBackColor = True
        '
        'btnRogue
        '
        Me.btnRogue.Location = New System.Drawing.Point(12, 244)
        Me.btnRogue.Name = "btnRogue"
        Me.btnRogue.Size = New System.Drawing.Size(75, 23)
        Me.btnRogue.TabIndex = 7
        Me.btnRogue.Text = "Rogue"
        Me.btnRogue.UseVisualStyleBackColor = True
        '
        'btnRanger
        '
        Me.btnRanger.Location = New System.Drawing.Point(12, 215)
        Me.btnRanger.Name = "btnRanger"
        Me.btnRanger.Size = New System.Drawing.Size(75, 23)
        Me.btnRanger.TabIndex = 7
        Me.btnRanger.Text = "Ranger"
        Me.btnRanger.UseVisualStyleBackColor = True
        '
        'btnWiz
        '
        Me.btnWiz.Location = New System.Drawing.Point(12, 302)
        Me.btnWiz.Name = "btnWiz"
        Me.btnWiz.Size = New System.Drawing.Size(75, 23)
        Me.btnWiz.TabIndex = 8
        Me.btnWiz.Text = "Wizard"
        Me.btnWiz.UseVisualStyleBackColor = True
        '
        'btnSorc
        '
        Me.btnSorc.Location = New System.Drawing.Point(12, 273)
        Me.btnSorc.Name = "btnSorc"
        Me.btnSorc.Size = New System.Drawing.Size(75, 23)
        Me.btnSorc.TabIndex = 9
        Me.btnSorc.Text = "Sorcerer"
        Me.btnSorc.UseVisualStyleBackColor = True
        '
        'rtbClassDetail
        '
        Me.rtbClassDetail.BackColor = System.Drawing.SystemColors.Control
        Me.rtbClassDetail.Location = New System.Drawing.Point(93, 99)
        Me.rtbClassDetail.Name = "rtbClassDetail"
        Me.rtbClassDetail.ReadOnly = True
        Me.rtbClassDetail.Size = New System.Drawing.Size(322, 328)
        Me.rtbClassDetail.TabIndex = 11
        Me.rtbClassDetail.Text = ""
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(93, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(322, 81)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(12, 355)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 13
        Me.btnSave.Text = "Save Class"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 384)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(75, 23)
        Me.btnBack.TabIndex = 14
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Classes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(427, 439)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.rtbClassDetail)
        Me.Controls.Add(Me.btnSorc)
        Me.Controls.Add(Me.btnWiz)
        Me.Controls.Add(Me.btnRanger)
        Me.Controls.Add(Me.btnRogue)
        Me.Controls.Add(Me.btnPal)
        Me.Controls.Add(Me.btnMonk)
        Me.Controls.Add(Me.btnFighter)
        Me.Controls.Add(Me.btnDruid)
        Me.Controls.Add(Me.btnCleric)
        Me.Controls.Add(Me.btnBard)
        Me.Controls.Add(Me.btnBarb)
        Me.Name = "Classes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Classes"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnBarb As Button
    Friend WithEvents btnBard As Button
    Friend WithEvents btnCleric As Button
    Friend WithEvents btnDruid As Button
    Friend WithEvents btnFighter As Button
    Friend WithEvents btnMonk As Button
    Friend WithEvents btnPal As Button
    Friend WithEvents btnRogue As Button
    Friend WithEvents btnRanger As Button
    Friend WithEvents btnWiz As Button
    Friend WithEvents btnSorc As Button
    Friend WithEvents rtbClassDetail As RichTextBox
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
End Class
