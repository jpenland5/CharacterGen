Public Class Initial
    Private Sub Initial_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnScores_Click(sender As Object, e As EventArgs) Handles btnScores.Click
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
End Class
