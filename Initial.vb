Public Class Initial

    Public RaceMod As New Dictionary(Of Integer, Integer)

    Private Sub Initial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
        lblSTR.Text = "Strength: 8"
        lblDEX.Text = "Dexterity: 8"
        lblCON.Text = "Constitution: 8"
        lblINT.Text = "Intelligence: 8"
        lblWIS.Text = "Wisdom: 8"
        lblCHA.Text = "Charisma: 8"
        Dim oPointBuy As AbScores
        oPointBuy = New AbScores()
        oPointBuy.Show()
    End Sub

    Private Sub btnFeats_Click(sender As Object, e As EventArgs) Handles btnFeats.Click
        Dim oFeats As Feats
        oFeats = New Feats()
        oFeats.Show()
    End Sub

    Private Sub btnSkills_Click(sender As Object, e As EventArgs) Handles btnSkills.Click
        Dim oSkills As Skills
        oSkills = New Skills()
        oSkills.Show()
    End Sub

    Private Sub btnRace_Click(sender As Object, e As EventArgs) Handles btnRace.Click
        lblSTR.Text = "Strength: 8"
        lblDEX.Text = "Dexterity: 8"
        lblCON.Text = "Constitution: 8"
        lblINT.Text = "Intelligence: 8"
        lblWIS.Text = "Wisdom: 8"
        lblCHA.Text = "Charisma: 8"
        Dim oRace As Race
        oRace = New Race()
        oRace.Show()
    End Sub

    Private Sub btnClass_Click(sender As Object, e As EventArgs) Handles btnClass.Click
        Dim oClass As Classes
        oClass = New Classes()
        oClass.Show()
    End Sub
End Class
