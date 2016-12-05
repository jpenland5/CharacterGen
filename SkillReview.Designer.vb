<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SkillReview
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
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lblAppraise = New System.Windows.Forms.Label()
        Me.lblBluff = New System.Windows.Forms.Label()
        Me.lblConcentration = New System.Windows.Forms.Label()
        Me.lblDiscipline = New System.Windows.Forms.Label()
        Me.lblIntimidate = New System.Windows.Forms.Label()
        Me.lblParry = New System.Windows.Forms.Label()
        Me.rtbSkillInfo = New System.Windows.Forms.RichTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(12, 227)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 23)
        Me.btnBack.TabIndex = 54
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lblAppraise
        '
        Me.lblAppraise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAppraise.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblAppraise.Location = New System.Drawing.Point(12, 9)
        Me.lblAppraise.Name = "lblAppraise"
        Me.lblAppraise.Size = New System.Drawing.Size(90, 20)
        Me.lblAppraise.TabIndex = 48
        Me.lblAppraise.Text = "Appraise: 0"
        Me.lblAppraise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBluff
        '
        Me.lblBluff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBluff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblBluff.Location = New System.Drawing.Point(12, 29)
        Me.lblBluff.Name = "lblBluff"
        Me.lblBluff.Size = New System.Drawing.Size(90, 20)
        Me.lblBluff.TabIndex = 49
        Me.lblBluff.Text = "Bluff: 0"
        Me.lblBluff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConcentration
        '
        Me.lblConcentration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblConcentration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblConcentration.Location = New System.Drawing.Point(12, 49)
        Me.lblConcentration.Name = "lblConcentration"
        Me.lblConcentration.Size = New System.Drawing.Size(90, 20)
        Me.lblConcentration.TabIndex = 50
        Me.lblConcentration.Text = "Concentration: 0"
        Me.lblConcentration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDiscipline
        '
        Me.lblDiscipline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscipline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDiscipline.Location = New System.Drawing.Point(12, 69)
        Me.lblDiscipline.Name = "lblDiscipline"
        Me.lblDiscipline.Size = New System.Drawing.Size(90, 20)
        Me.lblDiscipline.TabIndex = 51
        Me.lblDiscipline.Text = "Discipline: 0"
        Me.lblDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIntimidate
        '
        Me.lblIntimidate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIntimidate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblIntimidate.Location = New System.Drawing.Point(12, 89)
        Me.lblIntimidate.Name = "lblIntimidate"
        Me.lblIntimidate.Size = New System.Drawing.Size(90, 20)
        Me.lblIntimidate.TabIndex = 52
        Me.lblIntimidate.Text = "Intimidate: 0"
        Me.lblIntimidate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblParry
        '
        Me.lblParry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblParry.Location = New System.Drawing.Point(12, 109)
        Me.lblParry.Name = "lblParry"
        Me.lblParry.Size = New System.Drawing.Size(90, 20)
        Me.lblParry.TabIndex = 53
        Me.lblParry.Text = "Parry: 0"
        Me.lblParry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'rtbSkillInfo
        '
        Me.rtbSkillInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtbSkillInfo.Location = New System.Drawing.Point(117, 40)
        Me.rtbSkillInfo.Name = "rtbSkillInfo"
        Me.rtbSkillInfo.ReadOnly = True
        Me.rtbSkillInfo.Size = New System.Drawing.Size(251, 210)
        Me.rtbSkillInfo.TabIndex = 47
        Me.rtbSkillInfo.Text = ""
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Click on a skill to learn more."
        '
        'SkillReview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 264)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblAppraise)
        Me.Controls.Add(Me.lblBluff)
        Me.Controls.Add(Me.lblConcentration)
        Me.Controls.Add(Me.lblDiscipline)
        Me.Controls.Add(Me.lblIntimidate)
        Me.Controls.Add(Me.lblParry)
        Me.Controls.Add(Me.rtbSkillInfo)
        Me.Name = "SkillReview"
        Me.Text = "Skills"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBack As Button
    Friend WithEvents lblAppraise As Label
    Friend WithEvents lblBluff As Label
    Friend WithEvents lblConcentration As Label
    Friend WithEvents lblDiscipline As Label
    Friend WithEvents lblIntimidate As Label
    Friend WithEvents lblParry As Label
    Friend WithEvents rtbSkillInfo As RichTextBox
    Friend WithEvents Label1 As Label
End Class
