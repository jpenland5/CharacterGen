<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Skills
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Skills))
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.rtbSkillInfo = New System.Windows.Forms.RichTextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblSkillPoints = New System.Windows.Forms.Label()
        Me.lblAppraise = New System.Windows.Forms.Label()
        Me.btnAppraiseUp = New System.Windows.Forms.Button()
        Me.btnParryUp = New System.Windows.Forms.Button()
        Me.btnAppraiseDown = New System.Windows.Forms.Button()
        Me.btnIntimidateUp = New System.Windows.Forms.Button()
        Me.lblBluff = New System.Windows.Forms.Label()
        Me.btnDisciplineUp = New System.Windows.Forms.Button()
        Me.lblConcentration = New System.Windows.Forms.Label()
        Me.btnConcentrationUp = New System.Windows.Forms.Button()
        Me.lblDiscipline = New System.Windows.Forms.Label()
        Me.btnBluffUp = New System.Windows.Forms.Button()
        Me.lblIntimidate = New System.Windows.Forms.Label()
        Me.btnParryDown = New System.Windows.Forms.Button()
        Me.lblParry = New System.Windows.Forms.Label()
        Me.btnIntimidateDown = New System.Windows.Forms.Button()
        Me.btnBluffDown = New System.Windows.Forms.Button()
        Me.btnDisciplineDown = New System.Windows.Forms.Button()
        Me.btnConcentrationDown = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(190, 12)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(251, 86)
        Me.RichTextBox2.TabIndex = 22
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'rtbSkillInfo
        '
        Me.rtbSkillInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtbSkillInfo.Location = New System.Drawing.Point(190, 104)
        Me.rtbSkillInfo.Name = "rtbSkillInfo"
        Me.rtbSkillInfo.ReadOnly = True
        Me.rtbSkillInfo.Size = New System.Drawing.Size(251, 210)
        Me.rtbSkillInfo.TabIndex = 21
        Me.rtbSkillInfo.Text = ""
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblSkillPoints)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 55)
        Me.GroupBox2.TabIndex = 26
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Skill Points"
        '
        'lblSkillPoints
        '
        Me.lblSkillPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSkillPoints.Location = New System.Drawing.Point(6, 16)
        Me.lblSkillPoints.Name = "lblSkillPoints"
        Me.lblSkillPoints.Size = New System.Drawing.Size(91, 25)
        Me.lblSkillPoints.TabIndex = 0
        Me.lblSkillPoints.Text = "0"
        Me.lblSkillPoints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAppraise
        '
        Me.lblAppraise.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAppraise.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblAppraise.Location = New System.Drawing.Point(46, 78)
        Me.lblAppraise.Name = "lblAppraise"
        Me.lblAppraise.Size = New System.Drawing.Size(90, 20)
        Me.lblAppraise.TabIndex = 29
        Me.lblAppraise.Text = "Appraise: 0"
        Me.lblAppraise.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAppraiseUp
        '
        Me.btnAppraiseUp.Location = New System.Drawing.Point(142, 78)
        Me.btnAppraiseUp.Name = "btnAppraiseUp"
        Me.btnAppraiseUp.Size = New System.Drawing.Size(20, 20)
        Me.btnAppraiseUp.TabIndex = 27
        Me.btnAppraiseUp.Text = "+"
        Me.btnAppraiseUp.UseVisualStyleBackColor = True
        '
        'btnParryUp
        '
        Me.btnParryUp.Location = New System.Drawing.Point(142, 178)
        Me.btnParryUp.Name = "btnParryUp"
        Me.btnParryUp.Size = New System.Drawing.Size(20, 20)
        Me.btnParryUp.TabIndex = 44
        Me.btnParryUp.Text = "+"
        Me.btnParryUp.UseVisualStyleBackColor = True
        '
        'btnAppraiseDown
        '
        Me.btnAppraiseDown.Location = New System.Drawing.Point(20, 78)
        Me.btnAppraiseDown.Name = "btnAppraiseDown"
        Me.btnAppraiseDown.Size = New System.Drawing.Size(20, 20)
        Me.btnAppraiseDown.TabIndex = 28
        Me.btnAppraiseDown.Text = "-"
        Me.btnAppraiseDown.UseVisualStyleBackColor = True
        '
        'btnIntimidateUp
        '
        Me.btnIntimidateUp.Location = New System.Drawing.Point(142, 158)
        Me.btnIntimidateUp.Name = "btnIntimidateUp"
        Me.btnIntimidateUp.Size = New System.Drawing.Size(20, 20)
        Me.btnIntimidateUp.TabIndex = 43
        Me.btnIntimidateUp.Text = "+"
        Me.btnIntimidateUp.UseVisualStyleBackColor = True
        '
        'lblBluff
        '
        Me.lblBluff.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblBluff.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblBluff.Location = New System.Drawing.Point(46, 98)
        Me.lblBluff.Name = "lblBluff"
        Me.lblBluff.Size = New System.Drawing.Size(90, 20)
        Me.lblBluff.TabIndex = 30
        Me.lblBluff.Text = "Bluff: 0"
        Me.lblBluff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDisciplineUp
        '
        Me.btnDisciplineUp.Location = New System.Drawing.Point(142, 138)
        Me.btnDisciplineUp.Name = "btnDisciplineUp"
        Me.btnDisciplineUp.Size = New System.Drawing.Size(20, 20)
        Me.btnDisciplineUp.TabIndex = 42
        Me.btnDisciplineUp.Text = "+"
        Me.btnDisciplineUp.UseVisualStyleBackColor = True
        '
        'lblConcentration
        '
        Me.lblConcentration.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblConcentration.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblConcentration.Location = New System.Drawing.Point(46, 118)
        Me.lblConcentration.Name = "lblConcentration"
        Me.lblConcentration.Size = New System.Drawing.Size(90, 20)
        Me.lblConcentration.TabIndex = 31
        Me.lblConcentration.Text = "Concentration: 0"
        Me.lblConcentration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnConcentrationUp
        '
        Me.btnConcentrationUp.Location = New System.Drawing.Point(142, 118)
        Me.btnConcentrationUp.Name = "btnConcentrationUp"
        Me.btnConcentrationUp.Size = New System.Drawing.Size(20, 20)
        Me.btnConcentrationUp.TabIndex = 41
        Me.btnConcentrationUp.Text = "+"
        Me.btnConcentrationUp.UseVisualStyleBackColor = True
        '
        'lblDiscipline
        '
        Me.lblDiscipline.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDiscipline.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDiscipline.Location = New System.Drawing.Point(46, 138)
        Me.lblDiscipline.Name = "lblDiscipline"
        Me.lblDiscipline.Size = New System.Drawing.Size(90, 20)
        Me.lblDiscipline.TabIndex = 32
        Me.lblDiscipline.Text = "Discipline: 0"
        Me.lblDiscipline.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBluffUp
        '
        Me.btnBluffUp.Location = New System.Drawing.Point(142, 98)
        Me.btnBluffUp.Name = "btnBluffUp"
        Me.btnBluffUp.Size = New System.Drawing.Size(20, 20)
        Me.btnBluffUp.TabIndex = 40
        Me.btnBluffUp.Text = "+"
        Me.btnBluffUp.UseVisualStyleBackColor = True
        '
        'lblIntimidate
        '
        Me.lblIntimidate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblIntimidate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblIntimidate.Location = New System.Drawing.Point(46, 158)
        Me.lblIntimidate.Name = "lblIntimidate"
        Me.lblIntimidate.Size = New System.Drawing.Size(90, 20)
        Me.lblIntimidate.TabIndex = 33
        Me.lblIntimidate.Text = "Intimidate: 0"
        Me.lblIntimidate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnParryDown
        '
        Me.btnParryDown.Location = New System.Drawing.Point(20, 178)
        Me.btnParryDown.Name = "btnParryDown"
        Me.btnParryDown.Size = New System.Drawing.Size(20, 20)
        Me.btnParryDown.TabIndex = 39
        Me.btnParryDown.Text = "-"
        Me.btnParryDown.UseVisualStyleBackColor = True
        '
        'lblParry
        '
        Me.lblParry.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblParry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblParry.Location = New System.Drawing.Point(46, 178)
        Me.lblParry.Name = "lblParry"
        Me.lblParry.Size = New System.Drawing.Size(90, 20)
        Me.lblParry.TabIndex = 34
        Me.lblParry.Text = "Parry: 0"
        Me.lblParry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnIntimidateDown
        '
        Me.btnIntimidateDown.Location = New System.Drawing.Point(20, 158)
        Me.btnIntimidateDown.Name = "btnIntimidateDown"
        Me.btnIntimidateDown.Size = New System.Drawing.Size(20, 20)
        Me.btnIntimidateDown.TabIndex = 38
        Me.btnIntimidateDown.Text = "-"
        Me.btnIntimidateDown.UseVisualStyleBackColor = True
        '
        'btnBluffDown
        '
        Me.btnBluffDown.Location = New System.Drawing.Point(20, 98)
        Me.btnBluffDown.Name = "btnBluffDown"
        Me.btnBluffDown.Size = New System.Drawing.Size(20, 20)
        Me.btnBluffDown.TabIndex = 35
        Me.btnBluffDown.Text = "-"
        Me.btnBluffDown.UseVisualStyleBackColor = True
        '
        'btnDisciplineDown
        '
        Me.btnDisciplineDown.Location = New System.Drawing.Point(20, 138)
        Me.btnDisciplineDown.Name = "btnDisciplineDown"
        Me.btnDisciplineDown.Size = New System.Drawing.Size(20, 20)
        Me.btnDisciplineDown.TabIndex = 37
        Me.btnDisciplineDown.Text = "-"
        Me.btnDisciplineDown.UseVisualStyleBackColor = True
        '
        'btnConcentrationDown
        '
        Me.btnConcentrationDown.Location = New System.Drawing.Point(20, 118)
        Me.btnConcentrationDown.Name = "btnConcentrationDown"
        Me.btnConcentrationDown.Size = New System.Drawing.Size(20, 20)
        Me.btnConcentrationDown.TabIndex = 36
        Me.btnConcentrationDown.Text = "-"
        Me.btnConcentrationDown.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(46, 262)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(90, 23)
        Me.btnSave.TabIndex = 45
        Me.btnSave.Text = "Save Skills"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(46, 291)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(90, 23)
        Me.btnBack.TabIndex = 46
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'Skills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 354)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblAppraise)
        Me.Controls.Add(Me.btnAppraiseUp)
        Me.Controls.Add(Me.btnParryUp)
        Me.Controls.Add(Me.btnAppraiseDown)
        Me.Controls.Add(Me.btnIntimidateUp)
        Me.Controls.Add(Me.lblBluff)
        Me.Controls.Add(Me.btnDisciplineUp)
        Me.Controls.Add(Me.lblConcentration)
        Me.Controls.Add(Me.btnConcentrationUp)
        Me.Controls.Add(Me.lblDiscipline)
        Me.Controls.Add(Me.btnBluffUp)
        Me.Controls.Add(Me.lblIntimidate)
        Me.Controls.Add(Me.btnParryDown)
        Me.Controls.Add(Me.lblParry)
        Me.Controls.Add(Me.btnIntimidateDown)
        Me.Controls.Add(Me.btnBluffDown)
        Me.Controls.Add(Me.btnDisciplineDown)
        Me.Controls.Add(Me.btnConcentrationDown)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.rtbSkillInfo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Skills"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Skills"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents rtbSkillInfo As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblSkillPoints As Label
    Friend WithEvents lblAppraise As Label
    Friend WithEvents btnAppraiseUp As Button
    Friend WithEvents btnParryUp As Button
    Friend WithEvents btnAppraiseDown As Button
    Friend WithEvents btnIntimidateUp As Button
    Friend WithEvents lblBluff As Label
    Friend WithEvents btnDisciplineUp As Button
    Friend WithEvents lblConcentration As Label
    Friend WithEvents btnConcentrationUp As Button
    Friend WithEvents lblDiscipline As Label
    Friend WithEvents btnBluffUp As Button
    Friend WithEvents lblIntimidate As Label
    Friend WithEvents btnParryDown As Button
    Friend WithEvents lblParry As Label
    Friend WithEvents btnIntimidateDown As Button
    Friend WithEvents btnBluffDown As Button
    Friend WithEvents btnDisciplineDown As Button
    Friend WithEvents btnConcentrationDown As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
End Class
