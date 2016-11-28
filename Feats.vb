Public Class Feats

    Dim mFeats As Integer = 1

    Private Sub Feats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Initial.Feats.Add("Alertness", 0)
        Initial.Feats.Add("Ambidexterity", 0)
        Initial.Feats.Add("ArmorH", 0)
        Initial.Feats.Add("ArmorM", 0)
        Initial.Feats.Add("ArmorL", 0)
        Initial.Feats.Add("BlindFight", 0)
        Initial.Feats.Add("Blooded", 0)
        Initial.Feats.Add("PowerAttack", 0)
        Initial.Feats.Add("Cleave", 0)

        If Initial.AbScores("STR") >= 13 Then
            chkPowerAttack.Enabled = True
        End If

        If Initial.mRace = 1 Then
            mFeats += 1
        End If

        If Initial.mClass = 5 Then
            mFeats += 1
        End If

        lblFeats.Text = mFeats

    End Sub

    Private Sub chkAlertness_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

        'Updates the feat details to reflect the chosen feat
        rtbFeatInfo.Text = "Alertness" & vbCrLf & "Prerequisites: None" & vbCrLf & "Specifics: +2 bonus to spot and listen skills due to finely tuned senses."
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Enables the button for the next step
        Initial.btnSkills.Enabled = True

        'Closes the form
        Me.Close()

    End Sub

    Private Sub lblAlertness_Click(sender As Object, e As EventArgs) Handles lblAlertness.Click

        rtbFeatInfo.Text = "Alertness" & vbCrLf & "Prerequisites: None" & vbCrLf & "Specifics: +2 bonus to spot and listen checks due to finely tuned senses."

    End Sub

    Private Sub lblAmbidexterity_Click(sender As Object, e As EventArgs) Handles lblAmbidexterity.Click

        rtbFeatInfo.Text = "Ambidexterity" & vbCrLf & "Prerequisites: DEX 15+" & vbCrLf & "Specifics: When fighting with two weapons, this feat reduces the penalty of the off-hand weapon by 4." & vbCrLf & "Required for: Two-Weapon Fighting"

    End Sub

    Private Sub lblArmorH_Click(sender As Object, e As EventArgs) Handles lblArmorH.Click

        rtbFeatInfo.Text = "Armor Proficiency: Heavy" & vbCrLf & "Prerequisites: Armor Proficiency (Medium)" & vbCrLf & "Specifics: Allows the use of heavyweight armors."

    End Sub

    Private Sub lblArmorM_Click(sender As Object, e As EventArgs) Handles lblArmorM.Click

        rtbFeatInfo.Text = "Armor Proficiency: Medium" & vbCrLf & "Prerequisites: Armor Proficiency (Light)" & vbCrLf & "Specifics: Allows the use of medium-weight armors." & vbCrLf & "Required for: Armor Proficiency (Heavy)"

    End Sub

    Private Sub lblArmorL_Click(sender As Object, e As EventArgs) Handles lblArmorL.Click

        rtbFeatInfo.Text = "Armor Proficiency: Light" & vbCrLf & "Prerequisites: None" & vbCrLf & "Specifics: Allows the use of lightweight armors." & vbCrLf & "Required for: Armor Proficiency (Medium)"

    End Sub

    Private Sub lblBlindFight_Click(sender As Object, e As EventArgs) Handles lblBlindFight.Click

        rtbFeatInfo.Text = "Blind Fight" & vbCrLf & "Prerequisites: None" & vbCrLf & "Specifics: This feat grants the character the ability to fight well, even if blinded or against invisible creatures. The character gets to re-roll its miss chance percentile one time to see if it actually hits. Furthermore, invisible creatures get no bonus to hit the character in melee."

    End Sub

    Private Sub lblBlooded_Click(sender As Object, e As EventArgs) Handles lblBlooded.Click

        rtbFeatInfo.Text = "Blind Fight" & vbCrLf & "Prerequisites: None" & vbCrLf & "Specifics: The character gains a +2 bonus on initiative and a +2 bonus on spot checks."

    End Sub

    Private Sub lblPowerAttack_Click(sender As Object, e As EventArgs) Handles lblPowerAttack.Click

        rtbFeatInfo.Text = "Power Attack" & vbCrLf & "Prerequisites: STR 13+" & vbCrLf & "Specifics: A character with this feat can make powerful but ungainly attacks. When power attack is selected, it grants a +5 bonus to the damage roll, but at the cost of -5 to the attack roll." & vbCrLf & "Required for: Cleave, Improved Power Attack, Great Cleave, Divine Might, Divine Shield"

    End Sub

    Private Sub lblCleave_Click(sender As Object, e As EventArgs) Handles lblCleave.Click

        rtbFeatInfo.Text = "Cleave" & vbCrLf & "Prerequisites: STR 13+, Power Attack" & vbCrLf & "Specifics: If the character kills an opponent, he gets a free attack against any opponent who is within melee weapon range." & vbCrLf & "Required for: Great Cleave"

    End Sub

    Private Sub chkPowerAttack_CheckedChanged(sender As Object, e As EventArgs) Handles chkPowerAttack.CheckedChanged

        If mFeats > 0 Then
            If chkPowerAttack.Checked = True Then
                chkCleave.Enabled = True
                Initial.Feats("PowerAttack") = 1
                mFeats -= 1
            ElseIf chkPowerAttack.Checked = False Then
                chkCleave.Enabled = False
                Initial.Feats("PowerAttack") = 0
                mFeats += 1
            End If

            lblFeats.Text = mFeats
        Else
            MessageBox.Show("You don't have any feats left to select!")
        End If

    End Sub

    Private Sub chkArmorL_CheckedChanged(sender As Object, e As EventArgs) Handles chkArmorL.CheckedChanged

        If mFeats > 0 Then
            If chkArmorL.Checked = True Then
                chkArmorM.Enabled = True
                Initial.Feats("ArmorL") = 1
                mFeats -= 1
            ElseIf chkArmorL.Checked = False Then
                chkArmorM.Enabled = False
                Initial.Feats("ArmorL") = 0
                mFeats += 1
            End If
        Else
            MessageBox.Show("You don't have any feats left to select!")
        End If

    End Sub

    Private Sub chkArmorM_CheckedChanged(sender As Object, e As EventArgs) Handles chkArmorM.CheckedChanged

        If mFeats > 0 Then
            If chkArmorM.Checked = True Then
                Initial.Feats("ArmorM") = 1
                chkArmorH.Enabled = True
                mFeats += 1
            ElseIf chkArmorM.Checked = False Then
                chkArmorH.Enabled = False
                Initial.Feats("ArmorM") = 0
                mFeats += 1
            End If
        Else
            MessageBox.Show("You don't have any feats left to select!")
        End If
    End Sub

    Private Sub chkArmorH_CheckedChanged(sender As Object, e As EventArgs) Handles chkArmorH.CheckedChanged

        If mFeats > 0 Then
            If chkArmorH.Checked = True Then
                Initial.Feats("ArmorH") = 1
                mFeats += 1
            ElseIf chkArmorH.Checked = False Then
                Initial.Feats("ArmorH") = 0
                mFeats += 1
            End If
        Else
            MessageBox.Show("You don't have any feats left to select!")
        End If

    End Sub
End Class