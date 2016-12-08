<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Alignment
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Alignment))
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btnChaN = New System.Windows.Forms.Button()
        Me.btnChaG = New System.Windows.Forms.Button()
        Me.btnChaE = New System.Windows.Forms.Button()
        Me.btnNeuG = New System.Windows.Forms.Button()
        Me.btnTruN = New System.Windows.Forms.Button()
        Me.btnNeuE = New System.Windows.Forms.Button()
        Me.btnLawG = New System.Windows.Forms.Button()
        Me.btnLawN = New System.Windows.Forms.Button()
        Me.btnLawE = New System.Windows.Forms.Button()
        Me.rtbAlignInfo = New System.Windows.Forms.RichTextBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.statusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RichTextBox1.Size = New System.Drawing.Size(343, 100)
        Me.RichTextBox1.TabIndex = 24
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'btnChaN
        '
        Me.btnChaN.Location = New System.Drawing.Point(239, 147)
        Me.btnChaN.Name = "btnChaN"
        Me.btnChaN.Size = New System.Drawing.Size(100, 23)
        Me.btnChaN.TabIndex = 28
        Me.btnChaN.Text = "Chaotic Neutral"
        Me.btnChaN.UseVisualStyleBackColor = True
        '
        'btnChaG
        '
        Me.btnChaG.Location = New System.Drawing.Point(239, 118)
        Me.btnChaG.Name = "btnChaG"
        Me.btnChaG.Size = New System.Drawing.Size(100, 23)
        Me.btnChaG.TabIndex = 29
        Me.btnChaG.Text = "Chaotic Good"
        Me.btnChaG.UseVisualStyleBackColor = True
        '
        'btnChaE
        '
        Me.btnChaE.Location = New System.Drawing.Point(239, 176)
        Me.btnChaE.Name = "btnChaE"
        Me.btnChaE.Size = New System.Drawing.Size(100, 23)
        Me.btnChaE.TabIndex = 30
        Me.btnChaE.Text = "Chaotic Evil"
        Me.btnChaE.UseVisualStyleBackColor = True
        '
        'btnNeuG
        '
        Me.btnNeuG.Location = New System.Drawing.Point(133, 118)
        Me.btnNeuG.Name = "btnNeuG"
        Me.btnNeuG.Size = New System.Drawing.Size(100, 23)
        Me.btnNeuG.TabIndex = 31
        Me.btnNeuG.Text = "Neutral Good"
        Me.btnNeuG.UseVisualStyleBackColor = True
        '
        'btnTruN
        '
        Me.btnTruN.Location = New System.Drawing.Point(133, 147)
        Me.btnTruN.Name = "btnTruN"
        Me.btnTruN.Size = New System.Drawing.Size(100, 23)
        Me.btnTruN.TabIndex = 32
        Me.btnTruN.Text = "True Neutral"
        Me.btnTruN.UseVisualStyleBackColor = True
        '
        'btnNeuE
        '
        Me.btnNeuE.Location = New System.Drawing.Point(133, 176)
        Me.btnNeuE.Name = "btnNeuE"
        Me.btnNeuE.Size = New System.Drawing.Size(100, 23)
        Me.btnNeuE.TabIndex = 33
        Me.btnNeuE.Text = "Neutral Evil"
        Me.btnNeuE.UseVisualStyleBackColor = True
        '
        'btnLawG
        '
        Me.btnLawG.Location = New System.Drawing.Point(27, 118)
        Me.btnLawG.Name = "btnLawG"
        Me.btnLawG.Size = New System.Drawing.Size(100, 23)
        Me.btnLawG.TabIndex = 34
        Me.btnLawG.Text = "Lawful Good"
        Me.btnLawG.UseVisualStyleBackColor = True
        '
        'btnLawN
        '
        Me.btnLawN.Location = New System.Drawing.Point(27, 147)
        Me.btnLawN.Name = "btnLawN"
        Me.btnLawN.Size = New System.Drawing.Size(100, 23)
        Me.btnLawN.TabIndex = 35
        Me.btnLawN.Text = "Lawful Neutral"
        Me.btnLawN.UseVisualStyleBackColor = True
        '
        'btnLawE
        '
        Me.btnLawE.Location = New System.Drawing.Point(27, 176)
        Me.btnLawE.Name = "btnLawE"
        Me.btnLawE.Size = New System.Drawing.Size(100, 23)
        Me.btnLawE.TabIndex = 36
        Me.btnLawE.Text = "Lawful Evil"
        Me.btnLawE.UseVisualStyleBackColor = True
        '
        'rtbAlignInfo
        '
        Me.rtbAlignInfo.BackColor = System.Drawing.SystemColors.Control
        Me.rtbAlignInfo.Location = New System.Drawing.Point(12, 205)
        Me.rtbAlignInfo.Name = "rtbAlignInfo"
        Me.rtbAlignInfo.ReadOnly = True
        Me.rtbAlignInfo.Size = New System.Drawing.Size(343, 147)
        Me.rtbAlignInfo.TabIndex = 37
        Me.rtbAlignInfo.Text = ""
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(133, 358)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(100, 23)
        Me.btnSave.TabIndex = 38
        Me.btnSave.Text = "Save Alignment"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Location = New System.Drawing.Point(133, 387)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(100, 23)
        Me.btnBack.TabIndex = 39
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.statusLabel})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 417)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(367, 22)
        Me.StatusStrip1.TabIndex = 40
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'statusLabel
        '
        Me.statusLabel.Name = "statusLabel"
        Me.statusLabel.Size = New System.Drawing.Size(0, 17)
        '
        'Alignment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(367, 439)
        Me.ControlBox = False
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.rtbAlignInfo)
        Me.Controls.Add(Me.btnLawE)
        Me.Controls.Add(Me.btnLawN)
        Me.Controls.Add(Me.btnLawG)
        Me.Controls.Add(Me.btnNeuE)
        Me.Controls.Add(Me.btnTruN)
        Me.Controls.Add(Me.btnNeuG)
        Me.Controls.Add(Me.btnChaE)
        Me.Controls.Add(Me.btnChaG)
        Me.Controls.Add(Me.btnChaN)
        Me.Controls.Add(Me.RichTextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Alignment"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alignment"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents btnChaN As Button
    Friend WithEvents btnChaG As Button
    Friend WithEvents btnChaE As Button
    Friend WithEvents btnNeuG As Button
    Friend WithEvents btnTruN As Button
    Friend WithEvents btnNeuE As Button
    Friend WithEvents btnLawG As Button
    Friend WithEvents btnLawN As Button
    Friend WithEvents btnLawE As Button
    Friend WithEvents rtbAlignInfo As RichTextBox
    Friend WithEvents btnSave As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents statusLabel As ToolStripStatusLabel
End Class
