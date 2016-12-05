Public Class SkillReview

    Private Sub SkillReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblAppraise.Text = "Appraise: " & Initial.Skills("0")
        lblBluff.Text = "Bluff: " & Initial.Skills("1")
        lblConcentration.Text = "Concentration: " & Initial.Skills("2")
        lblDiscipline.Text = "Discipline: " & Initial.Skills("3")
        lblIntimidate.Text = "Intimidate: " & Initial.Skills("4")
        lblParry.Text = "Parry: " & Initial.Skills("5")

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
    End Sub

    Private Sub lblAppraise_Click_1(sender As Object, e As EventArgs) Handles lblAppraise.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Appraise" & vbCrLf & "Ability: Intelligence" & vbCrLf & "Specifics: The character makes an opposed roll against the merchant's appraise skill. If the merchant wins, the character pays more for the goods in the store. If the character wins, he pays less. The first time the player interacts with a merchant dictates the prices in that store until his appraise skill improves."
    End Sub

    Private Sub lblBluff_Click(sender As Object, e As EventArgs) Handles lblBluff.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Bluff" & vbCrLf & "Ability: Charisma" & vbCrLf & "Specifics: The character can make the outrageous or the untrue seem plausible. The skill encompasses acting, conning, fast talking, misdirection and misleading body language. By succeeding at a Bluff, the character may be able to convince others to render more assistance than they might normally give, or get them to provide extra rewards by exaggerating the difficulty of a completed task."

    End Sub

    Private Sub lblConcentration_Click(sender As Object, e As EventArgs) Handles lblConcentration.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Concentration" & vbCrLf & "Ability: Constitution" & vbCrLf & "Specifics: Concentration checks are made whenever a character is distracted (such as by taking damage from an enemy attack) during the act of casting a spell. It is also used to avoid the effects of the taunt skill. This skill is essential for spellcasting classes."

    End Sub

    Private Sub lblDiscipline_Click(sender As Object, e As EventArgs) Handles lblDiscipline.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Discipline" & vbCrLf & "Ability: Strength" & vbCrLf & "Specifics: A successful check allows the character to resist any combat feat (disarm, called shot, knockdown, or sap). This skill is essential for close-combat classes such as Fighters, preventing opponents with similar skills from crippling their effectiveness."

    End Sub

    Private Sub lblIntimidate_Click(sender As Object, e As EventArgs) Handles lblIntimidate.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Intimidate" & vbCrLf & "Ability: Charisma" & vbCrLf & "Specifics: The character can use this skill to get a bully to back down or make a prisoner give him the information he wants. Intimidation is often used to coerce individuals into cooperating with the character, whether through additional assistance or information, or forcefully collecting extra rewards for a task."

    End Sub

    Private Sub lblParry_Click(sender As Object, e As EventArgs) Handles lblParry.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Parry" & vbCrLf & "Ability: Dexterity" & vbCrLf & "Specifics: Parry allows the character to block incoming attacks and make spectacular counterattacks. Used by activating Parry Mode, parrying can prevent the character from taking damage while dealing additional damage to attacking foes. The higher the Parry score, the better your chances of parrying an attack."

    End Sub

End Class