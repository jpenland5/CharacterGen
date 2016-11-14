Public Class Feats
    Private Sub chkAlertness_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

        'Updates the feat details to reflect the chosen feat
        rtbFeatInfo.Text = "Alertness" & vbCrLf & "Prerequisites: None" & vbCrLf & "Specifics: +2 bonus to spot and listen skills due to finely tuned senses."
    End Sub

    Private Sub Feats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class