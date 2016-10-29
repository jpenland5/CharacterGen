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
        Me.btnSTRUp = New System.Windows.Forms.Button()
        Me.btnCHAUp = New System.Windows.Forms.Button()
        Me.btnSTRDown = New System.Windows.Forms.Button()
        Me.btnWISUp = New System.Windows.Forms.Button()
        Me.lblBluff = New System.Windows.Forms.Label()
        Me.btnINTUp = New System.Windows.Forms.Button()
        Me.lblConcentration = New System.Windows.Forms.Label()
        Me.btnCONUp = New System.Windows.Forms.Button()
        Me.lblDiscipline = New System.Windows.Forms.Label()
        Me.btnDEXUp = New System.Windows.Forms.Button()
        Me.lblIntimidate = New System.Windows.Forms.Label()
        Me.btnCHADown = New System.Windows.Forms.Button()
        Me.lblParry = New System.Windows.Forms.Label()
        Me.btnWISDown = New System.Windows.Forms.Button()
        Me.btnDEXDown = New System.Windows.Forms.Button()
        Me.btnINTDown = New System.Windows.Forms.Button()
        Me.btnCONDown = New System.Windows.Forms.Button()
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
        Me.lblSkillPoints.Text = "8"
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
        'btnSTRUp
        '
        Me.btnSTRUp.Location = New System.Drawing.Point(142, 78)
        Me.btnSTRUp.Name = "btnSTRUp"
        Me.btnSTRUp.Size = New System.Drawing.Size(20, 20)
        Me.btnSTRUp.TabIndex = 27
        Me.btnSTRUp.Text = "+"
        Me.btnSTRUp.UseVisualStyleBackColor = True
        '
        'btnCHAUp
        '
        Me.btnCHAUp.Location = New System.Drawing.Point(142, 178)
        Me.btnCHAUp.Name = "btnCHAUp"
        Me.btnCHAUp.Size = New System.Drawing.Size(20, 20)
        Me.btnCHAUp.TabIndex = 44
        Me.btnCHAUp.Text = "+"
        Me.btnCHAUp.UseVisualStyleBackColor = True
        '
        'btnSTRDown
        '
        Me.btnSTRDown.Location = New System.Drawing.Point(20, 78)
        Me.btnSTRDown.Name = "btnSTRDown"
        Me.btnSTRDown.Size = New System.Drawing.Size(20, 20)
        Me.btnSTRDown.TabIndex = 28
        Me.btnSTRDown.Text = "-"
        Me.btnSTRDown.UseVisualStyleBackColor = True
        '
        'btnWISUp
        '
        Me.btnWISUp.Location = New System.Drawing.Point(142, 158)
        Me.btnWISUp.Name = "btnWISUp"
        Me.btnWISUp.Size = New System.Drawing.Size(20, 20)
        Me.btnWISUp.TabIndex = 43
        Me.btnWISUp.Text = "+"
        Me.btnWISUp.UseVisualStyleBackColor = True
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
        'btnINTUp
        '
        Me.btnINTUp.Location = New System.Drawing.Point(142, 138)
        Me.btnINTUp.Name = "btnINTUp"
        Me.btnINTUp.Size = New System.Drawing.Size(20, 20)
        Me.btnINTUp.TabIndex = 42
        Me.btnINTUp.Text = "+"
        Me.btnINTUp.UseVisualStyleBackColor = True
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
        'btnCONUp
        '
        Me.btnCONUp.Location = New System.Drawing.Point(142, 118)
        Me.btnCONUp.Name = "btnCONUp"
        Me.btnCONUp.Size = New System.Drawing.Size(20, 20)
        Me.btnCONUp.TabIndex = 41
        Me.btnCONUp.Text = "+"
        Me.btnCONUp.UseVisualStyleBackColor = True
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
        'btnDEXUp
        '
        Me.btnDEXUp.Location = New System.Drawing.Point(142, 98)
        Me.btnDEXUp.Name = "btnDEXUp"
        Me.btnDEXUp.Size = New System.Drawing.Size(20, 20)
        Me.btnDEXUp.TabIndex = 40
        Me.btnDEXUp.Text = "+"
        Me.btnDEXUp.UseVisualStyleBackColor = True
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
        'btnCHADown
        '
        Me.btnCHADown.Location = New System.Drawing.Point(20, 178)
        Me.btnCHADown.Name = "btnCHADown"
        Me.btnCHADown.Size = New System.Drawing.Size(20, 20)
        Me.btnCHADown.TabIndex = 39
        Me.btnCHADown.Text = "-"
        Me.btnCHADown.UseVisualStyleBackColor = True
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
        'btnWISDown
        '
        Me.btnWISDown.Location = New System.Drawing.Point(20, 158)
        Me.btnWISDown.Name = "btnWISDown"
        Me.btnWISDown.Size = New System.Drawing.Size(20, 20)
        Me.btnWISDown.TabIndex = 38
        Me.btnWISDown.Text = "-"
        Me.btnWISDown.UseVisualStyleBackColor = True
        '
        'btnDEXDown
        '
        Me.btnDEXDown.Location = New System.Drawing.Point(20, 98)
        Me.btnDEXDown.Name = "btnDEXDown"
        Me.btnDEXDown.Size = New System.Drawing.Size(20, 20)
        Me.btnDEXDown.TabIndex = 35
        Me.btnDEXDown.Text = "-"
        Me.btnDEXDown.UseVisualStyleBackColor = True
        '
        'btnINTDown
        '
        Me.btnINTDown.Location = New System.Drawing.Point(20, 138)
        Me.btnINTDown.Name = "btnINTDown"
        Me.btnINTDown.Size = New System.Drawing.Size(20, 20)
        Me.btnINTDown.TabIndex = 37
        Me.btnINTDown.Text = "-"
        Me.btnINTDown.UseVisualStyleBackColor = True
        '
        'btnCONDown
        '
        Me.btnCONDown.Location = New System.Drawing.Point(20, 118)
        Me.btnCONDown.Name = "btnCONDown"
        Me.btnCONDown.Size = New System.Drawing.Size(20, 20)
        Me.btnCONDown.TabIndex = 36
        Me.btnCONDown.Text = "-"
        Me.btnCONDown.UseVisualStyleBackColor = True
        '
        'Skills
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 354)
        Me.Controls.Add(Me.lblAppraise)
        Me.Controls.Add(Me.btnSTRUp)
        Me.Controls.Add(Me.btnCHAUp)
        Me.Controls.Add(Me.btnSTRDown)
        Me.Controls.Add(Me.btnWISUp)
        Me.Controls.Add(Me.lblBluff)
        Me.Controls.Add(Me.btnINTUp)
        Me.Controls.Add(Me.lblConcentration)
        Me.Controls.Add(Me.btnCONUp)
        Me.Controls.Add(Me.lblDiscipline)
        Me.Controls.Add(Me.btnDEXUp)
        Me.Controls.Add(Me.lblIntimidate)
        Me.Controls.Add(Me.btnCHADown)
        Me.Controls.Add(Me.lblParry)
        Me.Controls.Add(Me.btnWISDown)
        Me.Controls.Add(Me.btnDEXDown)
        Me.Controls.Add(Me.btnINTDown)
        Me.Controls.Add(Me.btnCONDown)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Controls.Add(Me.rtbSkillInfo)
        Me.Name = "Skills"
        Me.Text = "Skills"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents rtbSkillInfo As RichTextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblSkillPoints As Label
    Friend WithEvents lblAppraise As Label
    Friend WithEvents btnSTRUp As Button
    Friend WithEvents btnCHAUp As Button
    Friend WithEvents btnSTRDown As Button
    Friend WithEvents btnWISUp As Button
    Friend WithEvents lblBluff As Label
    Friend WithEvents btnINTUp As Button
    Friend WithEvents lblConcentration As Label
    Friend WithEvents btnCONUp As Button
    Friend WithEvents lblDiscipline As Label
    Friend WithEvents btnDEXUp As Button
    Friend WithEvents lblIntimidate As Label
    Friend WithEvents btnCHADown As Button
    Friend WithEvents lblParry As Label
    Friend WithEvents btnWISDown As Button
    Friend WithEvents btnDEXDown As Button
    Friend WithEvents btnINTDown As Button
    Friend WithEvents btnCONDown As Button
End Class
