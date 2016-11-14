Public Class Gender

    Dim mGender As String

    Private Sub btnMale_Click(sender As Object, e As EventArgs) Handles btnMale.Click

        Initial.lblGender.Text = "Gender: Male"
        Me.Close()

    End Sub

    Private Sub btnFemale_Click(sender As Object, e As EventArgs) Handles btnFemale.Click

        Initial.lblGender.Text = "Gender: Female"
        Me.Close()

    End Sub
End Class