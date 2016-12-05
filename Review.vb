Public Class Review
    Private Sub Review_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Basic Stats
        lblName.Text = "Name: " & Initial.txtName.Text
        lblRace.Text = Initial.lblRace.Text
        lblGender.Text = Initial.lblGender.Text
        lblClass.Text = Initial.lblClass.Text
        lblAlign.Text = Initial.lblAlign.Text
        lblSTR.Text = "Strength: " & Initial.AbScores("STR").ToString
        lblDEX.Text = "Dexterity: " & Initial.AbScores("DEX").ToString
        lblCON.Text = "Constitution: " & Initial.AbScores("CON").ToString
        lblINT.Text = "Intelligence: " & Initial.AbScores("INT").ToString
        lblWIS.Text = "Wisdom: " & Initial.AbScores("WIS").ToString
        lblCHA.Text = "Charisma: " & Initial.AbScores("CHA").ToString

        'Skills
        lblAppraise.Text = "Appraise: " & Initial.Skills("Appraise").ToString
        lblBluff.Text = "Bluff: " & Initial.Skills("Bluff").ToString
        lblConcentration.Text = "Concentration: " & Initial.Skills("Concentration").ToString
        lblDiscipline.Text = "Discipline: " & Initial.Skills("Discipline").ToString
        lblIntimidate.Text = "Intimidate: " & Initial.Skills("Intimidate").ToString
        lblParry.Text = "Parry: " & Initial.Skills("Parry").ToString

        If Initial.Feats("Alertness") = True Then
            rtbFeats.AppendText(Environment.NewLine & "Alertness")
        End If

        If Initial.Feats("Ambidexterity") = True Then
            rtbFeats.AppendText(Environment.NewLine & "Ambidexterity")
        End If

        If Initial.Feats("ArmorH") = True Then
            rtbFeats.AppendText(Environment.NewLine & "Armor Proficiency (H)")
        End If

        If Initial.Feats("ArmorM") = True Then
            rtbFeats.AppendText(Environment.NewLine & "Armor Proficiency (M)")
        End If

        If Initial.Feats("ArmorL") = True Then
            rtbFeats.AppendText(Environment.NewLine & "Armor Proficiency (L)")
        End If

        If Initial.Feats("BlindFight") = True Then
            rtbFeats.AppendText(Environment.NewLine & "Blind Fight")
        End If

        If Initial.Feats("Blooded") = True Then
            rtbFeats.AppendText(Environment.NewLine & "Blooded")
        End If

        If Initial.Feats("PowrAttack") = True Then
            rtbFeats.AppendText(Environment.NewLine & "Power Attack")
        End If

        If Initial.Feats("Cleave") = True Then
            rtbFeats.AppendText(Environment.NewLine & "Cleave")
        End If

    End Sub

    'Private Sub btnSkills_Click(sender As Object, e As EventArgs)

    'Brings up the form for reviewing chosen skills
    ' Dim oSkillReview As SkillReview
    'oSkillReview = New SkillReview()
    ' oSkillReview.Show()

    'End Sub
End Class