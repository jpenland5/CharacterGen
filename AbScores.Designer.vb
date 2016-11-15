<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AbScores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AbScores))
        Me.btnSTRUp = New System.Windows.Forms.Button()
        Me.btnSTRDown = New System.Windows.Forms.Button()
        Me.lblCHA = New System.Windows.Forms.Label()
        Me.lblWIS = New System.Windows.Forms.Label()
        Me.lblINT = New System.Windows.Forms.Label()
        Me.lblCON = New System.Windows.Forms.Label()
        Me.lblDEX = New System.Windows.Forms.Label()
        Me.lblSTR = New System.Windows.Forms.Label()
        Me.btnDEXDown = New System.Windows.Forms.Button()
        Me.btnCONDown = New System.Windows.Forms.Button()
        Me.btnINTDown = New System.Windows.Forms.Button()
        Me.btnWISDown = New System.Windows.Forms.Button()
        Me.btnCHADown = New System.Windows.Forms.Button()
        Me.btnDEXUp = New System.Windows.Forms.Button()
        Me.btnCONUp = New System.Windows.Forms.Button()
        Me.btnINTUp = New System.Windows.Forms.Button()
        Me.btnWISUp = New System.Windows.Forms.Button()
        Me.btnCHAUp = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblPoints = New System.Windows.Forms.Label()
        Me.btnSaveScores = New System.Windows.Forms.Button()
        Me.btnResetScores = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSTRUp
        '
        Me.btnSTRUp.Location = New System.Drawing.Point(136, 26)
        Me.btnSTRUp.Name = "btnSTRUp"
        Me.btnSTRUp.Size = New System.Drawing.Size(20, 20)
        Me.btnSTRUp.TabIndex = 0
        Me.btnSTRUp.Text = "+"
        Me.btnSTRUp.UseVisualStyleBackColor = True
        '
        'btnSTRDown
        '
        Me.btnSTRDown.Location = New System.Drawing.Point(14, 26)
        Me.btnSTRDown.Name = "btnSTRDown"
        Me.btnSTRDown.Size = New System.Drawing.Size(20, 20)
        Me.btnSTRDown.TabIndex = 1
        Me.btnSTRDown.Text = "-"
        Me.btnSTRDown.UseVisualStyleBackColor = True
        '
        'lblCHA
        '
        Me.lblCHA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCHA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCHA.Location = New System.Drawing.Point(40, 126)
        Me.lblCHA.Name = "lblCHA"
        Me.lblCHA.Size = New System.Drawing.Size(90, 20)
        Me.lblCHA.TabIndex = 12
        Me.lblCHA.Text = "Charisma: 8"
        Me.lblCHA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWIS
        '
        Me.lblWIS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblWIS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblWIS.Location = New System.Drawing.Point(40, 106)
        Me.lblWIS.Name = "lblWIS"
        Me.lblWIS.Size = New System.Drawing.Size(90, 20)
        Me.lblWIS.TabIndex = 11
        Me.lblWIS.Text = "Wisdom: 8"
        Me.lblWIS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblINT
        '
        Me.lblINT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblINT.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblINT.Location = New System.Drawing.Point(40, 86)
        Me.lblINT.Name = "lblINT"
        Me.lblINT.Size = New System.Drawing.Size(90, 20)
        Me.lblINT.TabIndex = 10
        Me.lblINT.Text = "Intelligence: 8"
        Me.lblINT.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCON
        '
        Me.lblCON.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCON.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblCON.Location = New System.Drawing.Point(40, 66)
        Me.lblCON.Name = "lblCON"
        Me.lblCON.Size = New System.Drawing.Size(90, 20)
        Me.lblCON.TabIndex = 9
        Me.lblCON.Text = "Constitution: 8"
        Me.lblCON.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDEX
        '
        Me.lblDEX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblDEX.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblDEX.Location = New System.Drawing.Point(40, 46)
        Me.lblDEX.Name = "lblDEX"
        Me.lblDEX.Size = New System.Drawing.Size(90, 20)
        Me.lblDEX.TabIndex = 8
        Me.lblDEX.Text = "Dexterity: 8"
        Me.lblDEX.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSTR
        '
        Me.lblSTR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSTR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblSTR.Location = New System.Drawing.Point(40, 26)
        Me.lblSTR.Name = "lblSTR"
        Me.lblSTR.Size = New System.Drawing.Size(90, 20)
        Me.lblSTR.TabIndex = 7
        Me.lblSTR.Text = "Strength: 8"
        Me.lblSTR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnDEXDown
        '
        Me.btnDEXDown.Location = New System.Drawing.Point(14, 46)
        Me.btnDEXDown.Name = "btnDEXDown"
        Me.btnDEXDown.Size = New System.Drawing.Size(20, 20)
        Me.btnDEXDown.TabIndex = 13
        Me.btnDEXDown.Text = "-"
        Me.btnDEXDown.UseVisualStyleBackColor = True
        '
        'btnCONDown
        '
        Me.btnCONDown.Location = New System.Drawing.Point(14, 66)
        Me.btnCONDown.Name = "btnCONDown"
        Me.btnCONDown.Size = New System.Drawing.Size(20, 20)
        Me.btnCONDown.TabIndex = 14
        Me.btnCONDown.Text = "-"
        Me.btnCONDown.UseVisualStyleBackColor = True
        '
        'btnINTDown
        '
        Me.btnINTDown.Location = New System.Drawing.Point(14, 86)
        Me.btnINTDown.Name = "btnINTDown"
        Me.btnINTDown.Size = New System.Drawing.Size(20, 20)
        Me.btnINTDown.TabIndex = 15
        Me.btnINTDown.Text = "-"
        Me.btnINTDown.UseVisualStyleBackColor = True
        '
        'btnWISDown
        '
        Me.btnWISDown.Location = New System.Drawing.Point(14, 106)
        Me.btnWISDown.Name = "btnWISDown"
        Me.btnWISDown.Size = New System.Drawing.Size(20, 20)
        Me.btnWISDown.TabIndex = 16
        Me.btnWISDown.Text = "-"
        Me.btnWISDown.UseVisualStyleBackColor = True
        '
        'btnCHADown
        '
        Me.btnCHADown.Location = New System.Drawing.Point(14, 126)
        Me.btnCHADown.Name = "btnCHADown"
        Me.btnCHADown.Size = New System.Drawing.Size(20, 20)
        Me.btnCHADown.TabIndex = 17
        Me.btnCHADown.Text = "-"
        Me.btnCHADown.UseVisualStyleBackColor = True
        '
        'btnDEXUp
        '
        Me.btnDEXUp.Location = New System.Drawing.Point(136, 46)
        Me.btnDEXUp.Name = "btnDEXUp"
        Me.btnDEXUp.Size = New System.Drawing.Size(20, 20)
        Me.btnDEXUp.TabIndex = 18
        Me.btnDEXUp.Text = "+"
        Me.btnDEXUp.UseVisualStyleBackColor = True
        '
        'btnCONUp
        '
        Me.btnCONUp.Location = New System.Drawing.Point(136, 66)
        Me.btnCONUp.Name = "btnCONUp"
        Me.btnCONUp.Size = New System.Drawing.Size(20, 20)
        Me.btnCONUp.TabIndex = 19
        Me.btnCONUp.Text = "+"
        Me.btnCONUp.UseVisualStyleBackColor = True
        '
        'btnINTUp
        '
        Me.btnINTUp.Location = New System.Drawing.Point(136, 86)
        Me.btnINTUp.Name = "btnINTUp"
        Me.btnINTUp.Size = New System.Drawing.Size(20, 20)
        Me.btnINTUp.TabIndex = 20
        Me.btnINTUp.Text = "+"
        Me.btnINTUp.UseVisualStyleBackColor = True
        '
        'btnWISUp
        '
        Me.btnWISUp.Location = New System.Drawing.Point(136, 106)
        Me.btnWISUp.Name = "btnWISUp"
        Me.btnWISUp.Size = New System.Drawing.Size(20, 20)
        Me.btnWISUp.TabIndex = 21
        Me.btnWISUp.Text = "+"
        Me.btnWISUp.UseVisualStyleBackColor = True
        '
        'btnCHAUp
        '
        Me.btnCHAUp.Location = New System.Drawing.Point(136, 126)
        Me.btnCHAUp.Name = "btnCHAUp"
        Me.btnCHAUp.Size = New System.Drawing.Size(20, 20)
        Me.btnCHAUp.TabIndex = 22
        Me.btnCHAUp.Text = "+"
        Me.btnCHAUp.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 244)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox1.Size = New System.Drawing.Size(213, 128)
        Me.RichTextBox1.TabIndex = 23
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSTR)
        Me.GroupBox1.Controls.Add(Me.btnSTRUp)
        Me.GroupBox1.Controls.Add(Me.btnCHAUp)
        Me.GroupBox1.Controls.Add(Me.btnSTRDown)
        Me.GroupBox1.Controls.Add(Me.btnWISUp)
        Me.GroupBox1.Controls.Add(Me.lblDEX)
        Me.GroupBox1.Controls.Add(Me.btnINTUp)
        Me.GroupBox1.Controls.Add(Me.lblCON)
        Me.GroupBox1.Controls.Add(Me.btnCONUp)
        Me.GroupBox1.Controls.Add(Me.lblINT)
        Me.GroupBox1.Controls.Add(Me.btnDEXUp)
        Me.GroupBox1.Controls.Add(Me.lblWIS)
        Me.GroupBox1.Controls.Add(Me.btnCHADown)
        Me.GroupBox1.Controls.Add(Me.lblCHA)
        Me.GroupBox1.Controls.Add(Me.btnWISDown)
        Me.GroupBox1.Controls.Add(Me.btnDEXDown)
        Me.GroupBox1.Controls.Add(Me.btnINTDown)
        Me.GroupBox1.Controls.Add(Me.btnCONDown)
        Me.GroupBox1.Location = New System.Drawing.Point(32, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 165)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ability Scores"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblPoints)
        Me.GroupBox2.Location = New System.Drawing.Point(59, 183)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(103, 55)
        Me.GroupBox2.TabIndex = 25
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Points Remaining"
        '
        'lblPoints
        '
        Me.lblPoints.AutoSize = True
        Me.lblPoints.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPoints.Location = New System.Drawing.Point(31, 20)
        Me.lblPoints.Name = "lblPoints"
        Me.lblPoints.Size = New System.Drawing.Size(36, 25)
        Me.lblPoints.TabIndex = 0
        Me.lblPoints.Text = "25"
        '
        'btnSaveScores
        '
        Me.btnSaveScores.Location = New System.Drawing.Point(59, 378)
        Me.btnSaveScores.Name = "btnSaveScores"
        Me.btnSaveScores.Size = New System.Drawing.Size(117, 23)
        Me.btnSaveScores.TabIndex = 26
        Me.btnSaveScores.Text = "Save Scores"
        Me.btnSaveScores.UseVisualStyleBackColor = True
        '
        'btnResetScores
        '
        Me.btnResetScores.Location = New System.Drawing.Point(59, 407)
        Me.btnResetScores.Name = "btnResetScores"
        Me.btnResetScores.Size = New System.Drawing.Size(117, 23)
        Me.btnResetScores.TabIndex = 27
        Me.btnResetScores.Text = "Star Over"
        Me.btnResetScores.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(59, 436)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(117, 23)
        Me.btnBack.TabIndex = 28
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'AbScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(237, 475)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnResetScores)
        Me.Controls.Add(Me.btnSaveScores)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "AbScores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buy Ability Scores"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSTRUp As Button
    Friend WithEvents btnSTRDown As Button
    Friend WithEvents lblCHA As Label
    Friend WithEvents lblWIS As Label
    Friend WithEvents lblINT As Label
    Friend WithEvents lblCON As Label
    Friend WithEvents lblDEX As Label
    Friend WithEvents lblSTR As Label
    Friend WithEvents btnDEXDown As Button
    Friend WithEvents btnCONDown As Button
    Friend WithEvents btnINTDown As Button
    Friend WithEvents btnWISDown As Button
    Friend WithEvents btnCHADown As Button
    Friend WithEvents btnDEXUp As Button
    Friend WithEvents btnCONUp As Button
    Friend WithEvents btnINTUp As Button
    Friend WithEvents btnWISUp As Button
    Friend WithEvents btnCHAUp As Button
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblPoints As Label
    Friend WithEvents btnSaveScores As Button
    Friend WithEvents btnResetScores As Button
    Friend WithEvents btnBack As Button
End Class
