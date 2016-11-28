Public Class Review
    Private Sub Review_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    End Sub
End Class