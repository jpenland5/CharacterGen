Public Class Initial

    Public mRace As Integer

    'Creates dictionary for tracking racial ability score modifiers
    Public RaceMod As New Dictionary(Of Integer, Integer)

    'Creates dictionary for tracking ability scores
    Public AbScores As New Dictionary(Of String, Integer)

    'Creates dictionary for tracking skill points
    Public Skills As New Dictionary(Of String, Integer)

    'Creates dictionary for tracking selected feats
    Public Feats As New Dictionary(Of String, Integer)

    'Creates a variable for tracking the chosen class
    Public mClass As Integer

    Public mAlignment As String

    Public mClassSkillMod As Integer = 4

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

    Private Sub Initial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
            lblSTR.Text = "Strength: "
            lblSTR.Text = "Strength: "
            lblSTR.Text = "Strength: "
            lblSTR.Text = "Strength: "
            lblSTR.Text = "Strength: "
            btnScores.Enabled = True
        ElseIf btnSkills.Enabled = True Then
            btnSkills.Enabled = False
            Feats("Alertness") = 0
            Feats("Ambidexterity") = 0
            Feats("ArmorH") = 0
            Feats("ArmorM") = 0
            Feats("ArmorL") = 0
            Feats("BlindFight") = 0
            Feats("Blooded") = 0
            Feats("PowerAttack") = 0
            Feats("Cleave") = 0
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

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Dim file As System.IO.FileStream

        If My.Computer.FileSystem.FileExists("(lblName.Text).txt") Then
            MessageBox.Show("A character by that name already exists! Please rename your character or delete the old file.")
        End If

        file = System.IO.File.Create("(lblName.Text).txt")

        Dim addInfo As New System.IO.StreamWriter("(lblName).txt")

        addInfo.WriteLine(txtName.Text)
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
        addInfo.Close()

    End Sub
End Class
