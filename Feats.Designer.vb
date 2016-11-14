<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Feats
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
        Me.chkAmbidex = New System.Windows.Forms.CheckBox()
        Me.chkArmorH = New System.Windows.Forms.CheckBox()
        Me.chkArmorM = New System.Windows.Forms.CheckBox()
        Me.chkArmorL = New System.Windows.Forms.CheckBox()
        Me.chkBlindFight = New System.Windows.Forms.CheckBox()
        Me.chkBlooded = New System.Windows.Forms.CheckBox()
        Me.chkPowerAttack = New System.Windows.Forms.CheckBox()
        Me.chkCleave = New System.Windows.Forms.CheckBox()
        Me.rtbFeatInfo = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.chkAlertness = New System.Windows.Forms.CheckBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkAmbidex
        '
        Me.chkAmbidex.AutoSize = True
        Me.chkAmbidex.Location = New System.Drawing.Point(13, 36)
        Me.chkAmbidex.Name = "chkAmbidex"
        Me.chkAmbidex.Size = New System.Drawing.Size(88, 17)
        Me.chkAmbidex.TabIndex = 1
        Me.chkAmbidex.Text = "Ambidexterity"
        Me.chkAmbidex.UseVisualStyleBackColor = True
        '
        'chkArmorH
        '
        Me.chkArmorH.AutoSize = True
        Me.chkArmorH.Location = New System.Drawing.Point(13, 59)
        Me.chkArmorH.Name = "chkArmorH"
        Me.chkArmorH.Size = New System.Drawing.Size(148, 17)
        Me.chkArmorH.TabIndex = 2
        Me.chkArmorH.Text = "Armor Proficiency (Heavy)"
        Me.chkArmorH.UseVisualStyleBackColor = True
        '
        'chkArmorM
        '
        Me.chkArmorM.AutoSize = True
        Me.chkArmorM.Location = New System.Drawing.Point(13, 82)
        Me.chkArmorM.Name = "chkArmorM"
        Me.chkArmorM.Size = New System.Drawing.Size(154, 17)
        Me.chkArmorM.TabIndex = 3
        Me.chkArmorM.Text = "Armor Proficiency (Medium)"
        Me.chkArmorM.UseVisualStyleBackColor = True
        '
        'chkArmorL
        '
        Me.chkArmorL.AutoSize = True
        Me.chkArmorL.Location = New System.Drawing.Point(13, 105)
        Me.chkArmorL.Name = "chkArmorL"
        Me.chkArmorL.Size = New System.Drawing.Size(140, 17)
        Me.chkArmorL.TabIndex = 4
        Me.chkArmorL.Text = "Armor Proficiency (Light)"
        Me.chkArmorL.UseVisualStyleBackColor = True
        '
        'chkBlindFight
        '
        Me.chkBlindFight.AutoSize = True
        Me.chkBlindFight.Location = New System.Drawing.Point(13, 128)
        Me.chkBlindFight.Name = "chkBlindFight"
        Me.chkBlindFight.Size = New System.Drawing.Size(78, 17)
        Me.chkBlindFight.TabIndex = 5
        Me.chkBlindFight.Text = "Blight Fight"
        Me.chkBlindFight.UseVisualStyleBackColor = True
        '
        'chkBlooded
        '
        Me.chkBlooded.AutoSize = True
        Me.chkBlooded.Location = New System.Drawing.Point(13, 151)
        Me.chkBlooded.Name = "chkBlooded"
        Me.chkBlooded.Size = New System.Drawing.Size(65, 17)
        Me.chkBlooded.TabIndex = 6
        Me.chkBlooded.Text = "Blooded"
        Me.chkBlooded.UseVisualStyleBackColor = True
        '
        'chkPowerAttack
        '
        Me.chkPowerAttack.AutoSize = True
        Me.chkPowerAttack.Location = New System.Drawing.Point(13, 174)
        Me.chkPowerAttack.Name = "chkPowerAttack"
        Me.chkPowerAttack.Size = New System.Drawing.Size(90, 17)
        Me.chkPowerAttack.TabIndex = 7
        Me.chkPowerAttack.Text = "Power Attack"
        Me.chkPowerAttack.UseVisualStyleBackColor = True
        '
        'chkCleave
        '
        Me.chkCleave.AutoSize = True
        Me.chkCleave.Location = New System.Drawing.Point(13, 197)
        Me.chkCleave.Name = "chkCleave"
        Me.chkCleave.Size = New System.Drawing.Size(59, 17)
        Me.chkCleave.TabIndex = 8
        Me.chkCleave.Text = "Cleave"
        Me.chkCleave.UseVisualStyleBackColor = True
        '
        'rtbFeatInfo
        '
        Me.rtbFeatInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtbFeatInfo.Location = New System.Drawing.Point(191, 82)
        Me.rtbFeatInfo.Name = "rtbFeatInfo"
        Me.rtbFeatInfo.ReadOnly = True
        Me.rtbFeatInfo.Size = New System.Drawing.Size(251, 134)
        Me.rtbFeatInfo.TabIndex = 9
        Me.rtbFeatInfo.Text = ""
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(191, 13)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(251, 63)
        Me.RichTextBox2.TabIndex = 10
        Me.RichTextBox2.Text = "Welcome to feat selection! Some feats may only be available if your character mee" &
    "ts certain requirements. Click on a feat's name to display additional informatio" &
    "n."
        '
        'chkAlertness
        '
        Me.chkAlertness.AutoSize = True
        Me.chkAlertness.Location = New System.Drawing.Point(13, 13)
        Me.chkAlertness.Name = "chkAlertness"
        Me.chkAlertness.Size = New System.Drawing.Size(69, 17)
        Me.chkAlertness.TabIndex = 11
        Me.chkAlertness.Text = "Alertness"
        Me.chkAlertness.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(13, 220)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(108, 23)
        Me.btnSave.TabIndex = 12
        Me.btnSave.Text = "Save Feats"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(16, 249)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(105, 23)
        Me.btnBack.TabIndex = 13
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Feats
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(454, 283)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.chkAlertness)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.rtbFeatInfo)
        Me.Controls.Add(Me.chkCleave)
        Me.Controls.Add(Me.chkPowerAttack)
        Me.Controls.Add(Me.chkBlooded)
        Me.Controls.Add(Me.chkBlindFight)
        Me.Controls.Add(Me.chkArmorL)
        Me.Controls.Add(Me.chkArmorM)
        Me.Controls.Add(Me.chkArmorH)
        Me.Controls.Add(Me.chkAmbidex)
        Me.Name = "Feats"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Feats"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents chkAmbidex As CheckBox
    Friend WithEvents chkArmorH As CheckBox
    Friend WithEvents chkArmorM As CheckBox
    Friend WithEvents chkArmorL As CheckBox
    Friend WithEvents chkBlindFight As CheckBox
    Friend WithEvents chkBlooded As CheckBox
    Friend WithEvents chkPowerAttack As CheckBox
    Friend WithEvents chkCleave As CheckBox
    Friend WithEvents rtbFeatInfo As RichTextBox
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents chkAlertness As CheckBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
End Class
