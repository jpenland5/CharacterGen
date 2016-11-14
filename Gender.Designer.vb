<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gender
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gender))
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.btnMale = New System.Windows.Forms.Button()
        Me.btnFemale = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(12, 12)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.ReadOnly = True
        Me.RichTextBox2.Size = New System.Drawing.Size(353, 70)
        Me.RichTextBox2.TabIndex = 11
        Me.RichTextBox2.Text = resources.GetString("RichTextBox2.Text")
        '
        'btnMale
        '
        Me.btnMale.Location = New System.Drawing.Point(99, 90)
        Me.btnMale.Name = "btnMale"
        Me.btnMale.Size = New System.Drawing.Size(75, 23)
        Me.btnMale.TabIndex = 12
        Me.btnMale.Text = "Male"
        Me.btnMale.UseVisualStyleBackColor = True
        '
        'btnFemale
        '
        Me.btnFemale.Location = New System.Drawing.Point(180, 90)
        Me.btnFemale.Name = "btnFemale"
        Me.btnFemale.Size = New System.Drawing.Size(75, 23)
        Me.btnFemale.TabIndex = 13
        Me.btnFemale.Text = "Female"
        Me.btnFemale.UseVisualStyleBackColor = True
        '
        'Gender
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 125)
        Me.Controls.Add(Me.btnFemale)
        Me.Controls.Add(Me.btnMale)
        Me.Controls.Add(Me.RichTextBox2)
        Me.Name = "Gender"
        Me.Text = "Gender"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RichTextBox2 As RichTextBox
    Friend WithEvents btnMale As Button
    Friend WithEvents btnFemale As Button
End Class
