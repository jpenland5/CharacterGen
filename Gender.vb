Public Class Gender

    Dim mGender As String

    Private Sub btnMale_Click(sender As Object, e As EventArgs) Handles btnMale.Click

        'Sets the gender label to the correct gender 
        Initial.lblGender.Text = "Gender: Male"

        'Enables the button for the next step
        Initial.btnClass.Enabled = True

        'Closes the form
        Me.Close()

    End Sub

    Private Sub btnFemale_Click(sender As Object, e As EventArgs) Handles btnFemale.Click

        'Sets the gender label to the correct gender 
        Initial.lblGender.Text = "Gender: Female"

        'Enables the button for the next step
        Initial.btnClass.Enabled = True

        'Closes the form
        Me.Close()

    End Sub
End Class