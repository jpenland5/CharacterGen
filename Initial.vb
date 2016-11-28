Public Class Initial

    'Creates dictionary for tracking racial ability score modifiers
    Public RaceMod As New Dictionary(Of Integer, Integer)

    'Creates dictionary for tracking ability scores
    Public AbScores As New Dictionary(Of String, Integer)

    'Creates dictionary for tracking skill points
    Public Skills As New Dictionary(Of String, Integer)

    'Creates a variable for tracking the chosen class
    Public mClass As Integer

    Public mAlignment As String

    Public mClassSkillMod As Integer = 4

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click

        'Removes any current ability scores stored in the dictionary
        AbScores.Remove("STR")
        AbScores.Remove("DEX")
        AbScores.Remove("CON")
        AbScores.Remove("INT")
        AbScores.Remove("WIS")
        AbScores.Remove("CHA")

        'Resets all ability scores to default values
        lblSTR.Text = "Strength: 8"
        lblDEX.Text = "Dexterity: 8"
        lblCON.Text = "Constitution: 8"
        lblINT.Text = "Intelligence: 8"
        lblWIS.Text = "Wisdom: 8"
        lblCHA.Text = "Charisma: 8"

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

        'Resets all ability scores to default values
        lblSTR.Text = "Strength: 8"
        lblDEX.Text = "Dexterity: 8"
        lblCON.Text = "Constitution: 8"
        lblINT.Text = "Intelligence: 8"
        lblWIS.Text = "Wisdom: 8"
        lblCHA.Text = "Charisma: 8"

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

End Class
