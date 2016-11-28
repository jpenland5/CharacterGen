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
        If Initial.Skills("Appraise") < 4 Then
            If mSkillPoints > 0 Then
                Initial.Skills("Appraise") += 1
                lblAppraise.Text = "Appraise: " & Initial.Skills("Appraise")
                mSkillPoints -= 1
                lblSkillPoints.Text = mSkillPoints
            Else
                MessageBox.Show("You don't have any skill points remaining!")
            End If
        Else
            MessageBox.Show("You can't put more than 4 points into a skill at character creation!")
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

    Private Sub lblBluff_Click(sender As Object, e As EventArgs) Handles lblBluff.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Bluff" & vbCrLf & "Ability: Charisma" & vbCrLf & "Specifics: The character can make the outrageous or the untrue seem plausible. The skill encompasses acting, conning, fast talking, misdirection and misleading body language. By succeeding at a Bluff, the character may be able to convince others to render more assistance than they might normally give, or get them to provide extra rewards by exaggerating the difficulty of a completed task."

    End Sub

    Private Sub btnBluffUp_Click(sender As Object, e As EventArgs) Handles btnBluffUp.Click

        'Modifies the value of the skill if the player still has skill points to spend
        If Initial.Skills("Bluff") < 4 Then
            If mSkillPoints > 0 Then
                Initial.Skills("Bluff") += 1
                lblBluff.Text = "Bluff: " & Initial.Skills("Bluff")
                mSkillPoints -= 1
                lblSkillPoints.Text = mSkillPoints
            Else
                MessageBox.Show("You don't have any skill points remaining!")
            End If
        Else
            MessageBox.Show("You can't put more than 4 points into a skill at character creation!")
        End If

    End Sub

    Private Sub btnBluffDown_Click(sender As Object, e As EventArgs) Handles btnBluffDown.Click

        If Initial.Skills("Bluff") > 0 Then
            Initial.Skills("Bluff") -= 1
            lblBluff.Text = "Bluff: " & Initial.Skills("Bluff")
            mSkillPoints += 1
            lblSkillPoints.Text = mSkillPoints
        Else
            MessageBox.Show("You can't decrease this skill any further!")
        End If

    End Sub

    Private Sub lblConcentration_Click(sender As Object, e As EventArgs) Handles lblConcentration.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Concentration" & vbCrLf & "Ability: Constitution" & vbCrLf & "Specifics: Concentration checks are made whenever a character is distracted (such as by taking damage from an enemy attack) during the act of casting a spell. It is also used to avoid the effects of the taunt skill. This skill is essential for spellcasting classes."

    End Sub

    Private Sub btnConcentrationUp_Click(sender As Object, e As EventArgs) Handles btnConcentrationUp.Click

        'Modifies the value of the skill if the player still has skill points to spend
        If Initial.Skills("Concentration") < 4 Then
            If mSkillPoints > 0 Then
                Initial.Skills("Concentration") += 1
                lblConcentration.Text = "Concentration: " & Initial.Skills("Concentration")
                mSkillPoints -= 1
                lblSkillPoints.Text = mSkillPoints
            Else
                MessageBox.Show("You don't have any skill points remaining!")
            End If
        Else
            MessageBox.Show("You can't put more than 4 points into a skill at character creation!")
        End If

    End Sub

    Private Sub btnConcentrationDown_Click(sender As Object, e As EventArgs) Handles btnConcentrationDown.Click

        If Initial.Skills("Concentration") > 0 Then
            Initial.Skills("Concentration") -= 1
            lblConcentration.Text = "Concentration: " & Initial.Skills("Concentration")
            mSkillPoints += 1
            lblSkillPoints.Text = mSkillPoints
        Else
            MessageBox.Show("You can't decrease this skill any further!")
        End If

    End Sub

    Private Sub lblDiscipline_Click(sender As Object, e As EventArgs) Handles lblDiscipline.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Discipline" & vbCrLf & "Ability: Strength" & vbCrLf & "Specifics: A successful check allows the character to resist any combat feat (disarm, called shot, knockdown, or sap). This skill is essential for close-combat classes such as Fighters, preventing opponents with similar skills from crippling their effectiveness."

    End Sub

    Private Sub btnDisciplineUp_Click(sender As Object, e As EventArgs) Handles btnDisciplineUp.Click

        'Modifies the value of the skill if the player still has skill points to spend
        If Initial.Skills("Discipline") < 4 Then
            If mSkillPoints > 0 Then
                Initial.Skills("Discipline") += 1
                lblDiscipline.Text = "Discipline: " & Initial.Skills("Discipline")
                mSkillPoints -= 1
                lblSkillPoints.Text = mSkillPoints
            Else
                MessageBox.Show("You don't have any skill points remaining!")
            End If
        Else
            MessageBox.Show("You can't put more than 4 points into a skill at character creation!")
        End If

    End Sub

    Private Sub btnDisciplineDown_Click(sender As Object, e As EventArgs) Handles btnDisciplineDown.Click

        If Initial.Skills("Discipline") > 0 Then
            Initial.Skills("Discipline") -= 1
            lblDiscipline.Text = "Discipline: " & Initial.Skills("Discipline")
            mSkillPoints += 1
            lblSkillPoints.Text = mSkillPoints
        Else
            MessageBox.Show("You can't decrease this skill any further!")
        End If

    End Sub

    Private Sub lblIntimidate_Click(sender As Object, e As EventArgs) Handles lblIntimidate.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Intimidate" & vbCrLf & "Ability: Charisma" & vbCrLf & "Specifics: The character can use this skill to get a bully to back down or make a prisoner give him the information he wants. Intimidation is often used to coerce individuals into cooperating with the character, whether through additional assistance or information, or forcefully collecting extra rewards for a task."

    End Sub

    Private Sub btnIntimidateUp_Click(sender As Object, e As EventArgs) Handles btnIntimidateUp.Click

        'Modifies the value of the skill if the player still has skill points to spend
        If Initial.Skills("Intimidate") < 4 Then
            If mSkillPoints > 0 Then
                Initial.Skills("Intimidate") += 1
                lblIntimidate.Text = "Intimidate: " & Initial.Skills("Intimidate")
                mSkillPoints -= 1
                lblSkillPoints.Text = mSkillPoints
            Else
                MessageBox.Show("You don't have any skill points remaining!")
            End If
        Else
            MessageBox.Show("You can't put more than 4 points into a skill at character creation!")
        End If

    End Sub

    Private Sub btnIntimidateDown_Click(sender As Object, e As EventArgs) Handles btnIntimidateDown.Click

        If Initial.Skills("Intimidate") > 0 Then
            Initial.Skills("Intimidate") -= 1
            lblIntimidate.Text = "Intimidate: " & Initial.Skills("Intimidate")
            mSkillPoints += 1
            lblSkillPoints.Text = mSkillPoints
        Else
            MessageBox.Show("You can't decrease this skill any further!")
        End If

    End Sub

    Private Sub lblParry_Click(sender As Object, e As EventArgs) Handles lblParry.Click

        'Updates the skill details to reflect the selected skill
        rtbSkillInfo.Text = "Parry" & vbCrLf & "Ability: Dexterity" & vbCrLf & "Specifics: Parry allows the character to block incoming attacks and make spectacular counterattacks. Used by activating Parry Mode, parrying can prevent the character from taking damage while dealing additional damage to attacking foes. The higher the Parry score, the better your chances of parrying an attack."

    End Sub

    Private Sub btnParryUp_Click(sender As Object, e As EventArgs) Handles btnParryUp.Click

        'Modifies the value of the skill if the player still has skill points to spend
        If Initial.Skills("Parry") < 4 Then
            If mSkillPoints > 0 Then
                Initial.Skills("Parry") += 1
                lblParry.Text = "Parry: " & Initial.Skills("Parry")
                mSkillPoints -= 1
                lblSkillPoints.Text = mSkillPoints
            Else
                MessageBox.Show("You don't have any skill points remaining!")
            End If
        Else
            MessageBox.Show("You can't put more than 4 points into a skill at character creation!")
        End If

    End Sub

    Private Sub btnParryDown_Click(sender As Object, e As EventArgs) Handles btnParryDown.Click

        If Initial.Skills("Parry") > 0 Then
            Initial.Skills("Parry") -= 1
            lblParry.Text = "Parry: " & Initial.Skills("Parry")
            mSkillPoints += 1
            lblSkillPoints.Text = mSkillPoints
        Else
            MessageBox.Show("You can't decrease this skill any further!")
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Resets all skill points and closes the form
        Initial.Skills("Appraise") = 0
        Initial.Skills("Bluff") = 0
        Initial.Skills("Concentration") = 0
        Initial.Skills("Discipline") = 0
        Initial.Skills("Intimidate") = 0
        Initial.Skills("Parry") = 0

        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Simply closes the form; all skill points are already stored in the dictionary
        Me.Close()

    End Sub
End Class