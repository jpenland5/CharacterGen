Public Class SkillFunc

    Function SkillUp(ByVal Skill As String, ByVal Points As Integer)



    End Function

    Function SkillUp(ByVal Points As Integer)

        If Initial.Skills("Appraise") < 4 Then
            Initial.Skills("Appraise") += 1
            'lblAppraise.Text = "Appraise: " & Initial.Skills("Appraise")
            Points -= 1
            ' lblSkillPoints.Text = mSkillPoints
        Else
            MessageBox.Show("You can't put more than 4 points into a skill at character creation!")
        End If

    End Function

End Class
