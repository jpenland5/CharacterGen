Public Class Skills

    'Creates variable to hold the number of available skill points
    Dim mSkillPoints As Integer

    Private Sub Skills_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initializes the contents of the skills dictionary to default values
        Initial.Skills.Add("Appraise", 0)
        Initial.Skills.Add("Bluff", 0)
        Initial.Skills.Add("Concentration", 0)
        Initial.Skills.Add("Discipline", 0)
        Initial.Skills.Add("Intimidate", 0)
        Initial.Skills.Add("Parry", 0)

        'Calculates the number of available skill points based on class & Intelligence
        mSkillPoints = (Math.Floor(((Initial.AbScores("INT") - 8) / 2) + Initial.mClassSkillMod) * 4)

        lblSkillPoints.Text = mSkillpoints

    End Sub

    Private Sub lblAppraise_Click_1(sender As Object, e As EventArgs) Handles lblAppraise.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Appraise" & vbCrLf & "Ability: Intelligence" & vbCrLf & "Specifics: The character makes an opposed roll against the merchant's appraise skill. If the merchant wins, the character pays more for the goods in the store. If the character wins, he pays less. The first time the player interacts with a merchant dictates the prices in that store until his appraise skill improves."
    End Sub

    Private Sub btnAppraiseUp_Click(sender As Object, e As EventArgs) Handles btnAppraiseUp.Click

        'Modifies the value of the skill if the player still has skill points to spend
        If mSkillPoints > 0 Then
            Initial.Skills("Appraise") += 1
            lblAppraise.Text = "Appraise: " & Initial.Skills("Appraise")
            mSkillPoints -= 1
            lblSkillPoints.Text = mSkillPoints
        Else
            MessageBox.Show("You don't have any skill points remaining!")
        End If
    End Sub

    Private Sub btnAppraiseDown_Click(sender As Object, e As EventArgs) Handles btnAppraiseDown.Click

        If Initial.Skills("Appraise") > 0 Then
            Initial.Skills("Appraise") -= 1
            lblAppraise.Text = "Appraise: " & Initial.Skills("Appraise")
            mSkillPoints += 1
            lblSkillPoints.Text = mSkillPoints
        Else
            MessageBox.Show("You can't decrease this skill any further!")
        End If

    End Sub
End Class