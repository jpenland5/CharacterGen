Public Class Feats

    Dim mFeats As Integer

    Private Sub Feats_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mFeats = 1

        Initial.Feats.Add("Alertness", False)
        Initial.Feats.Add("Ambidexterity", False)
        Initial.Feats.Add("ArmorH", False)
        Initial.Feats.Add("ArmorM", False)
        Initial.Feats.Add("ArmorL", False)
        Initial.Feats.Add("BlindFight", False)
        Initial.Feats.Add("Blooded", False)
        Initial.Feats.Add("PowerAttack", False)
        Initial.Feats.Add("Cleave", False)

        If Initial.AbScores("STR") >= 13 Then
            chkPowerAttack.Enabled = True
        End If

        If Initial.mRace = 1 Then
            mFeats += 1
        End If

        If Initial.mClass = 1 Then
            mFeats += 2
            Initial.Feats("ArmorL") = 1
            chkArmorL.Checked = True
            chkArmorL.Enabled = False
            Initial.Feats("ArmorM") = 1
            chkArmorM.Checked = True
            chkArmorM.Enabled = False
            chkArmorH.Enabled = True
        End If

        If Initial.mClass = 2 Then
            mFeats += 2
            Initial.Feats("ArmorL") = 1
            chkArmorL.Checked = True
            chkArmorL.Enabled = False
            Initial.Feats("ArmorM") = 1
            chkArmorM.Checked = True
            chkArmorM.Enabled = False
            chkArmorH.Enabled = True
        End If

        If Initial.mClass = 3 Then
            mFeats += 3
            Initial.Feats("ArmorL") = 1
            chkArmorL.Checked = True
            chkArmorL.Enabled = False
            Initial.Feats("ArmorM") = 1
            chkArmorM.Checked = True
            chkArmorM.Enabled = False
            Initial.Feats("ArmorH") = 1
            chkArmorH.Checked = True
            chkArmorH.Enabled = False
        End If

        If Initial.mClass = 4 Then
            mFeats += 2
            Initial.Feats("ArmorL") = 1
            chkArmorL.Checked = True
            chkArmorL.Enabled = False
            Initial.Feats("ArmorM") = 1
            chkArmorM.Checked = True
            chkArmorM.Enabled = False
            chkArmorH.Enabled = True
        End If


        If Initial.mClass = 5 Then
            mFeats += 4
            Initial.Feats("ArmorL") = 1
            chkArmorL.Checked = True
            chkArmorL.Enabled = False
            Initial.Feats("ArmorM") = 1
            chkArmorM.Checked = True
            chkArmorM.Enabled = False
            Initial.Feats("ArmorH") = 1
            chkArmorH.Checked = True
            chkArmorH.Enabled = False

        End If

        If Initial.mClass = 6 Then

        End If

        If Initial.mClass = 7 Then
            mFeats += 3
            Initial.Feats("ArmorL") = 1
            chkArmorL.Checked = True
            chkArmorL.Enabled = False
            Initial.Feats("ArmorM") = 1
            chkArmorM.Checked = True
            chkArmorM.Enabled = False
            Initial.Feats("ArmorH") = 1
            chkArmorH.Checked = True
            chkArmorH.Enabled = False

        End If

        If Initial.mClass = 8 Then
            mFeats += 3
            Initial.Feats("ArmorL") = 1
            chkArmorL.Checked = True
            chkArmorL.Enabled = False
            Initial.Feats("ArmorM") = 1
            chkArmorM.Checked = True
            chkArmorM.Enabled = False
            chkArmorH.Enabled = True
            Initial.Feats("Ambidexterity") = 1
            chkAmbidex.Checked = True
            chkAmbidex.Enabled = False

        End If

        If Initial.mClass = 9 Then
            mFeats += 1
            Initial.Feats("ArmorL") = 1
            chkArmorL.Checked = True
            chkArmorL.Enabled = False

            chkArmorM.Enabled = True
        End If

        If Initial.mClass = 9 Then

        End If

        If Initial.mClass = 9 Then

        End If

        lblFeats.Text = mFeats

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If mFeats > 0 Then

            statusLabel.Text = "Please select all feats before continuing!"
            Exit Sub

        Else

            'Enables the button for the next step
            Initial.btnSkills.Enabled = True

            'Disables the button for the current step
            Initial.btnFeats.Enabled = False

            'Closes the form
            Me.Close()

        End If

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

        If chkPowerAttack.Checked = True Then
            If mFeats = 0 Then
                statusLabel.Text = "You don't have any feats left to select!"
                mFeats -= 1
                chkPowerAttack.Checked = False
                Exit Sub
            Else
                chkCleave.Enabled = True
                Initial.Feats("PowerAttack") = 1
                mFeats -= 1
                lblFeats.Text = mFeats
            End If
        ElseIf chkPowerAttack.Checked = False Then
            chkCleave.Checked = False
            If chkCleave.Checked = True Then
                mFeats += 1
            End If
            chkCleave.Enabled = False
            Initial.Feats("PowerAttack") = 0
            mFeats += 1
            lblFeats.Text = mFeats
        End If

    End Sub

    Private Sub chkArmorL_CheckedChanged(sender As Object, e As EventArgs) Handles chkArmorL.CheckedChanged


        If chkArmorL.Checked = True Then
            If mFeats = 0 Then
                statusLabel.Text = "You don't have any feats left to select!"
                mFeats -= 1
                chkArmorL.Checked = False
                Exit Sub
            Else
                chkArmorM.Enabled = True
                Initial.Feats("ArmorL") = 1
                mFeats -= 1
                lblFeats.Text = mFeats
            End If
        ElseIf chkArmorL.Checked = False Then
            chkArmorM.Enabled = False
            Initial.Feats("ArmorL") = 0
            mFeats += 1
            lblFeats.Text = mFeats
            End If

    End Sub

    Private Sub chkArmorM_CheckedChanged(sender As Object, e As EventArgs) Handles chkArmorM.CheckedChanged

        If chkArmorM.Checked = True Then
            If mFeats = 0 Then
                statusLabel.Text = "You don't have any feats left to select!"
                mFeats -= 1
                chkArmorM.Checked = False
                Exit Sub
            Else
                Initial.Feats("ArmorM") = 1
                chkArmorH.Enabled = True
                mFeats -= 1
                lblFeats.Text = mFeats
            End If
        ElseIf chkArmorM.Checked = False Then
            chkArmorH.Enabled = False
            Initial.Feats("ArmorM") = 0
            mFeats += 1
            lblFeats.Text = mFeats
        End If
    End Sub

    Private Sub chkArmorH_CheckedChanged(sender As Object, e As EventArgs) Handles chkArmorH.CheckedChanged

        If chkArmorH.Checked = True Then
            If mFeats = 0 Then
                statusLabel.Text = "You don't have any feats left to select!"
                mFeats -= 1
                chkArmorH.Checked = False
                Exit Sub
            Else
                Initial.Feats("ArmorH") = 1
                mFeats -= 1
                lblFeats.Text = mFeats
            End If

        ElseIf chkArmorH.Checked = False Then
            Initial.Feats("ArmorH") = 0
            mFeats += 1
            lblFeats.Text = mFeats
        End If

    End Sub

    Private Sub chkAlertness_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkAlertness.CheckedChanged

        If chkAlertness.Checked = True Then
            If mFeats = 0 Then
                statusLabel.Text = "You don't have any feats left to select!"
                mFeats -= 1
                chkAlertness.Checked = False
                Exit Sub
            Else
                Initial.Feats("Alertness") = 1
                mFeats -= 1
                lblFeats.Text = mFeats
            End If
        ElseIf chkAlertness.Checked = False Then
            Initial.Feats("Alertness") = 0
            mFeats += 1
            lblFeats.Text = mFeats
        End If

    End Sub

    Private Sub chkAmbidex_CheckedChanged(sender As Object, e As EventArgs) Handles chkAmbidex.CheckedChanged

        If chkAmbidex.Checked = True Then
            If mFeats = 0 Then
                statusLabel.Text = "You don't have any feats left to select!"
                mFeats -= 1
                chkAmbidex.Checked = False
                Exit Sub
            Else
                Initial.Feats("Ambidexterity") = 1
                mFeats -= 1
                lblFeats.Text = mFeats
            End If
        ElseIf chkAmbidex.Checked = False Then
                Initial.Feats("Ambidexterity") = 0
            mFeats += 1
            lblFeats.Text = mFeats
        End If

    End Sub

    Private Sub chkBlindFight_CheckedChanged(sender As Object, e As EventArgs) Handles chkBlindFight.CheckedChanged

        If chkBlindFight.Checked = True Then
            If mFeats = 0 Then
                statusLabel.Text = "You don't have any feats left to select!"
                mFeats -= 1
                chkBlindFight.Checked = False
                Exit Sub
            Else
                Initial.Feats("BlindFight") = 1
                mFeats -= 1
                lblFeats.Text = mFeats
            End If
        ElseIf chkBlindFight.Checked = False Then
            Initial.Feats("BlindFight") = 0
            mFeats += 1
            lblFeats.Text = mFeats
        End If

    End Sub

    Private Sub chkBlooded_CheckedChanged(sender As Object, e As EventArgs) Handles chkBlooded.CheckedChanged

        If chkBlooded.Checked = True Then
            If mFeats = 0 Then
                statusLabel.Text = "You don't have any feats left to select!"
                mFeats -= 1
                chkBlooded.Checked = False
                Exit Sub
            Else
                Initial.Feats("Blooded") = 1
                mFeats -= 1
                lblFeats.Text = mFeats
            End If
        ElseIf chkBlooded.Checked = False Then
            Initial.Feats("Blooded") = 0
            mFeats += 1
            lblFeats.Text = mFeats
        End If

    End Sub

    Private Sub chkCleave_CheckedChanged(sender As Object, e As EventArgs) Handles chkCleave.CheckedChanged

        If chkCleave.Checked = True Then
            If mFeats = 0 Then
                statusLabel.Text = "You don't have any feats left to select!"
                mFeats -= 1
                chkCleave.Checked = False
                Exit Sub
            Else
                Initial.Feats("Cleave") = 1
                mFeats -= 1
                lblFeats.Text = mFeats
            End If
        ElseIf chkCleave.Checked = False Then
            Initial.Feats("Cleave") = 0
            mFeats += 1
            lblFeats.Text = mFeats
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Clears the selected feats from the dictionary and closes the form
        Initial.Feats.Remove("Alertness")
        Initial.Feats.Remove("Ambidexterity")
        Initial.Feats.Remove("ArmorH")
        Initial.Feats.Remove("ArmorM")
        Initial.Feats.Remove("ArmorL")
        Initial.Feats.Remove("BlindFight")
        Initial.Feats.Remove("Blooded")
        Initial.Feats.Remove("PowerAttack")
        Initial.Feats.Remove("Cleave")

        mFeats = 1

        Me.Close()

    End Sub


End Class