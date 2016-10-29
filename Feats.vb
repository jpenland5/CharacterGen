Public Class Feats
    Private Sub chkAlertness_CheckedChanged(sender As Object, e As EventArgs) Handles chkAlertness.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        rtbFeatInfo.Text = "Alertness" & vbCrLf & "Prerequisites: None" & vbCrLf & "Specifics: +2 bonus to spot and listen skills due to finely tuned senses."
    End Sub
End Class