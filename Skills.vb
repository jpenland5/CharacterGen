Public Class Skills

    Private Sub lblAppraise_Click_1(sender As Object, e As EventArgs) Handles lblAppraise.Click
        rtbSkillInfo.Text = "Appraise" & vbCrLf & "Ability: Intelligence" & vbCrLf & "Specifics: The character makes an opposed roll against the merchant's appraise skill. If the merchant wins, the character pays more for the goods in the store. If the character wins, he pays less. The first time the player interacts with a merchant dictates the prices in that store until his appraise skill improves."
    End Sub

End Class