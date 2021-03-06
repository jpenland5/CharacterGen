﻿Public Class Initial

    Public mRace As Integer

    'Creates dictionary for tracking racial ability score modifiers
    Public RaceMod As New Dictionary(Of Integer, Integer)

    'Creates dictionary for tracking ability scores
    Public AbScores As New Dictionary(Of String, Integer)

    'Creates dictionary for tracking skill points
    Public Skills As New Dictionary(Of String, Integer)

    'Creates dictionary for tracking selected feats
    Public Feats As New Dictionary(Of String, Boolean)

    'Creates a variable for tracking the chosen class
    Public mClass As Integer

    'Creates a variable for tracking the chosen alignment
    Public mAlignment As String

    'Creates a variable for tracking a class-based modifier, and initializes to the default value used by most classes
    Public mClassSkillMod As Integer = 4

    'Dim mAllInfo As String

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click

        'Removes any current ability scores stored in the dictionary
        'AbScores.Remove("STR")
        'AbScores.Remove("DEX")
        'AbScores.Remove("CON")
        'AbScores.Remove("INT")
        'AbScores.Remove("WIS")
        'AbScores.Remove("CHA")

        ''Resets all ability scores to default values
        'lblSTR.Text = "Strength: "
        'lblDEX.Text = "Dexterity: "
        'lblCON.Text = "Constitution: "
        'lblINT.Text = "Intelligence: "
        'lblWIS.Text = "Wisdom: "
        'lblCHA.Text = "Charisma: "

        'Brings up the form for choosing new scores
        Dim oPointBuy As AbScores
        oPointBuy = New AbScores()
        oPointBuy.Show()

    End Sub

    Private Sub btnFeats_Click(sender As Object, e As EventArgs) Handles btnFeats.Click

        'Brings up the form for selecting the desired feats
        Dim oFeats As Feats
        oFeats = New Feats()
        oFeats.Show()

    End Sub

    Private Sub btnSkills_Click(sender As Object, e As EventArgs) Handles btnSkills.Click

        'Brings up the form for selecting the desired skills
        Dim oSkills As Skills
        oSkills = New Skills()
        oSkills.Show()

    End Sub

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click

        'Brings up the form for choosing a new player race
        Dim oRace As Race
        oRace = New Race()
        oRace.Show()


    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click

        'Brings up the form for selecting the character's Class
        Dim oClass As Classes
        oClass = New Classes()
        oClass.Show()

    End Sub

    Private Sub btnGender_Click(sender As Object, e As EventArgs) Handles btnGender.Click

        'Brings up the form for selecting the character's gender
        Dim oGender As Gender
        oGender = New Gender()
        oGender.Show()

    End Sub

    Private Sub btnAlign_Click(sender As Object, e As EventArgs) Handles btnAlign.Click

        'Brings up the form for selecting the character's alignment
        Dim oAlign As Alignment
        oAlign = New Alignment()
        oAlign.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Disables the Gender button and reverts effects of race selection
        If btnGender.Enabled = True Then
            btnGender.Enabled = False
            mRace = Nothing
            RaceMod.Remove("1")
            RaceMod.Remove("2")
            RaceMod.Remove("3")
            RaceMod.Remove("4")
            RaceMod.Remove("5")
            RaceMod.Remove("6")
            lblRace.Text = "Race: "
            btnRace.Enabled = True
        ElseIf btnClass.Enabled = True Then
            btnClass.Enabled = False
            lblGender.Text = "Gender: "
            btnGender.Enabled = True
        ElseIf btnAlign.Enabled = True Then
            btnAlign.Enabled = False
            mClass = Nothing
            lblClass.Text = "Class: "
            btnClass.Enabled = True
        ElseIf btnScores.Enabled = True Then
            btnScores.Enabled = False
            lblAlign.Text = "Alignment: "
            mAlignment = Nothing
            btnAlign.Enabled = True
        ElseIf btnFeats.Enabled = True Then
            btnFeats.Enabled = False
            AbScores.Remove("STR")
            AbScores.Remove("DEX")
            AbScores.Remove("CON")
            AbScores.Remove("INT")
            AbScores.Remove("WIS")
            AbScores.Remove("CHA")
            lblSTR.Text = "Strength: "
            lblDEX.Text = "Dexterity: "
            lblCON.Text = "Constitution: "
            lblINT.Text = "Intelligence: "
            lblWIS.Text = "Wisdom: "
            lblCHA.Text = "Charisma: "
            btnScores.Enabled = True
        ElseIf btnSkills.Enabled = True Then
            btnSkills.Enabled = False
            Feats.Remove("Alertness")
            Feats.Remove("Ambidexterity")
            Feats.Remove("ArmorH")
            Feats.Remove("ArmorM")
            Feats.Remove("ArmorL")
            Feats.Remove("BlindFight")
            Feats.Remove("Blooded")
            Feats.Remove("PowerAttack")
            Feats.Remove("Cleave")
            btnFeats.Enabled = True
        ElseIf btnReview.Enabled = True Then
            btnReview.Enabled = False
            btnSave.Enabled = False
            Skills.Remove("Appraise")
            Skills.Remove("Bluff")
            Skills.Remove("Concentration")
            Skills.Remove("Discipline")
            Skills.Remove("Intimidate")
            Skills.Remove("Parry")
            btnSkills.Enabled = True
        End If

    End Sub

    Private Sub btnReview_Click(sender As Object, e As EventArgs) Handles btnReview.Click

        'Brings up the form for reviewing all character stats
        Dim oReview As Review
        oReview = New Review()
        oReview.Show()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click, SaveCharacterToolStripMenuItem.Click

        'Dim file As System.IO.FileStream

        If txtName.Text Is "" Then

            statusLabel.Text = "Please enter a character name!"

        Else

            If My.Computer.FileSystem.FileExists(txtName.Text & ".txt") Then

                Dim choice = MsgBox("A character by that name already exists! Do you wish to replace the existing file?", MsgBoxStyle.OkCancel, "Character Exists!")
                If choice = DialogResult.Cancel Then

                    Exit Sub

                ElseIf choice = DialogResult.OK Then

                    'file = System.IO.File.Create(txtName.Text & ".txt")
                    Dim addInfo As New System.IO.StreamWriter(txtName.Text & ".txt")

                    addInfo.WriteLine("--PRIMARY STATS--")
                    addInfo.WriteLine("Name: " & txtName.Text)
                    addInfo.WriteLine(lblRace.Text)
                    addInfo.WriteLine(lblGender.Text)
                    addInfo.WriteLine(lblClass.Text)
                    addInfo.WriteLine(lblAlign.Text)
                    addInfo.WriteLine(lblSTR.Text)
                    addInfo.WriteLine(lblDEX.Text)
                    addInfo.WriteLine(lblCON.Text)
                    addInfo.WriteLine(lblINT.Text)
                    addInfo.WriteLine(lblWIS.Text)
                    addInfo.WriteLine(lblCHA.Text)

                    addInfo.WriteLine("")
                    addInfo.WriteLine("--SKILLS--")
                    addInfo.WriteLine("Appraise: " & Skills("Appraise"))
                    addInfo.WriteLine("Bluff: " & Skills("Bluff"))
                    addInfo.WriteLine("Concentration: " & Skills("Concentration"))
                    addInfo.WriteLine("Discipline: " & Skills("Discipline"))
                    addInfo.WriteLine("Intimidate: " & Skills("Intimidate"))
                    addInfo.WriteLine("Parry: " & Skills("Parry"))

                    addInfo.WriteLine("")
                    addInfo.WriteLine("--FEATS--")

                    If Feats("Alertness") = True Then
                        addInfo.WriteLine("Alertness")
                    Else
                        addInfo.WriteLine("")
                    End If

                    If Feats("Ambidexterity") = True Then
                        addInfo.WriteLine("Ambidexterity")
                    Else
                        addInfo.WriteLine("")
                    End If

                    If Feats("ArmorH") = True Then
                        addInfo.WriteLine("Armor Proficiency (H)")
                    Else
                        addInfo.WriteLine("")
                    End If

                    If Feats("ArmorM") = True Then
                        addInfo.WriteLine("Armor Proficiency (M)")
                    Else
                        addInfo.WriteLine("")
                    End If

                    If Feats("ArmorL") = True Then
                        addInfo.WriteLine("Armor Proficiency (L)")
                    Else
                        addInfo.WriteLine("")
                    End If

                    If Feats("BlindFight") = True Then
                        addInfo.WriteLine("Blind Fight")
                    Else
                        addInfo.WriteLine("")
                    End If

                    If Feats("Blooded") = True Then
                        addInfo.WriteLine("Blooded")
                    Else
                        addInfo.WriteLine("")
                    End If

                    If Feats("PowerAttack") = True Then
                        addInfo.WriteLine("Power Attack")
                    Else
                        addInfo.WriteLine("")
                    End If

                    If Feats("Cleave") = True Then
                        addInfo.WriteLine("Cleave")
                    Else
                        addInfo.WriteLine("")
                    End If

                    addInfo.WriteLine("")
                    addInfo.WriteLine("--BIOGRAPHY--")
                    addInfo.WriteLine(rtbBiography.Text)

                    addInfo.Close()

                End If
            Else
                Dim addInfo As New System.IO.StreamWriter(txtName.Text & ".txt")

                addInfo.WriteLine("--PRIMARY STATS--")
                addInfo.WriteLine("Name: " & txtName.Text)
                addInfo.WriteLine(lblRace.Text)
                addInfo.WriteLine(lblGender.Text)
                addInfo.WriteLine(lblClass.Text)
                addInfo.WriteLine(lblAlign.Text)
                addInfo.WriteLine(lblSTR.Text)
                addInfo.WriteLine(lblDEX.Text)
                addInfo.WriteLine(lblCON.Text)
                addInfo.WriteLine(lblINT.Text)
                addInfo.WriteLine(lblWIS.Text)
                addInfo.WriteLine(lblCHA.Text)

                addInfo.WriteLine("")
                addInfo.WriteLine("--SKILLS--")
                addInfo.WriteLine("Appraise: " & Skills("Appraise"))
                addInfo.WriteLine("Bluff: " & Skills("Bluff"))
                addInfo.WriteLine("Concentration: " & Skills("Concentration"))
                addInfo.WriteLine("Discipline: " & Skills("Discipline"))
                addInfo.WriteLine("Intimidate: " & Skills("Intimidate"))
                addInfo.WriteLine("Parry: " & Skills("Parry"))

                addInfo.WriteLine("")
                addInfo.WriteLine("--FEATS--")

                If Feats("Alertness") = True Then
                    addInfo.WriteLine("Alertness")
                Else
                    addInfo.WriteLine("")
                End If

                If Feats("Ambidexterity") = True Then
                    addInfo.WriteLine("Ambidexterity")
                Else
                    addInfo.WriteLine("")
                End If

                If Feats("ArmorH") = True Then
                    addInfo.WriteLine("Armor Proficiency (H)")
                Else
                    addInfo.WriteLine("")
                End If

                If Feats("ArmorM") = True Then
                    addInfo.WriteLine("Armor Proficiency (M)")
                Else
                    addInfo.WriteLine("")
                End If

                If Feats("ArmorL") = True Then
                    addInfo.WriteLine("Armor Proficiency (L)")
                Else
                    addInfo.WriteLine("")
                End If

                If Feats("BlindFight") = True Then
                    addInfo.WriteLine("Blind Fight")
                Else
                    addInfo.WriteLine("")
                End If

                If Feats("Blooded") = True Then
                    addInfo.WriteLine("Blooded")
                Else
                    addInfo.WriteLine("")
                End If

                If Feats("PowerAttack") = True Then
                    addInfo.WriteLine("Power Attack")
                Else
                    addInfo.WriteLine("")
                End If

                If Feats("Cleave") = True Then
                    addInfo.WriteLine("Cleave")
                Else
                    addInfo.WriteLine("")
                End If

                addInfo.WriteLine("")
                addInfo.WriteLine("--BIOGRAPHY--")
                addInfo.WriteLine(rtbBiography.Text)

                addInfo.Close()

            End If
        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click

        Dim reset = MsgBox("Are you sure you want to start over? The current character will be lost!", MsgBoxStyle.OkCancel, "Start Over?")

        If reset = DialogResult.Cancel Then

            Exit Sub

        ElseIf reset = DialogResult.OK Then

            'Resets the application
            Application.Restart()

        End If

    End Sub

    Private Sub LoadCharacterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoadCharacterToolStripMenuItem.Click

        If CharacterLoad.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            'Dim mAllInfo As String

            'Dim fileReader As System.IO.StreamReader
            'fileReader = My.Computer.FileSystem.OpenTextFileReader(CharacterLoad.FileName)
            'mAllInfo = fileReader.ReadToEnd

            'Brings up the form for viewing an existing character
            Dim oLoadReview As LoadReview
            oLoadReview = New LoadReview()
            oLoadReview.Show()

        End If

    End Sub

    Private Sub rtbBiography_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles rtbBiography.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click

        Me.Close()

    End Sub
End Class
