<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Review
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
        Me.lblGender = New System.Windows.Forms.Label()
        Me.lblAlign = New System.Windows.Forms.Label()
        Me.lblClass = New System.Windows.Forms.Label()
        Me.lblRace = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblCHA = New System.Windows.Forms.Label()
        Me.lblWIS = New System.Windows.Forms.Label()
        Me.lblINT = New System.Windows.Forms.Label()
        Me.lblCON = New System.Windows.Forms.Label()
        Me.lblDEX = New System.Windows.Forms.Label()
        Me.lblSTR = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.btnSkills = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblGender
        '
        Me.lblGender.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblGender.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblGender.Location = New System.Drawing.Point(87, 81)
        Me.lblGender.Name = "lblGender"
        Me.lblGender.Size = New System.Drawing.Size(141, 20)
        Me.lblGender.TabIndex = 34
        Me.lblGender.Text = "Gender: "
        Me.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAlign
        '
        Me.lblAlign.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAlign.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblAlign.Location = New System.Drawing.Point(87, 139)
        Me.lblAlign.Name = "lblAlign"
        Me.lblAlign.Size = New System.Drawing.Size(141, 20)
        Me.lblAlign.TabIndex = 32
        Me.lblAlign.Text = "Alignment: "
        Me.lblAlign.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClass
        '
        Me.lblClass.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblClass.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblClass.Location = New System.Drawing.Point(87, 110)
        Me.lblClass.Name = "lblClass"
        Me.lblClass.Size = New System.Drawing.Size(141, 20)
        Me.lblClass.TabIndex = 31
        Me.lblClass.Text = "Class: "
        Me.lblClass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRace
        '
        Me.lblRace.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblRace.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblRace.Location = New System.Drawing.Point(87, 52)
        Me.lblRace.Name = "lblRace"
        Me.lblRace.Size = New System.Drawing.Size(141, 20)
        Me.lblRace.TabIndex = 26
        Me.lblRace.Text = "Race: "
        Me.lblRace.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(99, 509)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(129, 23)
        Me.btnBack.TabIndex = 30
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCHA)
        Me.GroupBox1.Controls.Add(Me.lblWIS)
        Me.GroupBox1.Controls.Add(Me.lblINT)
        Me.GroupBox1.Controls.Add(Me.lblCON)
        Me.GroupBox1.Controls.Add(Me.lblDEX)
        Me.GroupBox1.Controls.Add(Me.lblSTR)
        Me.GroupBox1.Location = New System.Drawing.Point(99, 171)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(118, 157)
        Me.GroupBox1.TabIndex = 23
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 333)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Biography: "
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox1.Location = New System.Drawing.Point(8, 352)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(301, 120)
        Me.RichTextBox1.TabIndex = 21
        Me.RichTextBox1.Text = ""
        '
        'lblName
        '
        Me.lblName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblName.Location = New System.Drawing.Point(87, 23)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(141, 20)
        Me.lblName.TabIndex = 35
        Me.lblName.Text = "Name: "
        Me.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnSkills
        '
        Me.btnSkills.Location = New System.Drawing.Point(99, 478)
        Me.btnSkills.Name = "btnSkills"
        Me.btnSkills.Size = New System.Drawing.Size(129, 23)
        Me.btnSkills.TabIndex = 36
        Me.btnSkills.Text = "View Skills"
        Me.btnSkills.UseVisualStyleBackColor = True
        '
        'Review
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 544)
        Me.Controls.Add(Me.btnSkills)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblGender)
        Me.Controls.Add(Me.lblAlign)
        Me.Controls.Add(Me.lblClass)
        Me.Controls.Add(Me.lblRace)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Name = "Review"
        Me.Text = "Character Review"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblGender As Label
    Friend WithEvents lblAlign As Label
    Friend WithEvents lblClass As Label
    Friend WithEvents lblRace As Label
    Friend WithEvents btnBack As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblCHA As Label
    Friend WithEvents lblWIS As Label
    Friend WithEvents lblINT As Label
    Friend WithEvents lblCON As Label
    Friend WithEvents lblDEX As Label
    Friend WithEvents lblSTR As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents lblName As Label
    Friend WithEvents btnSkills As Button
End Class
