Public Class AbScores

    Public mSTR As Integer = 8
    Public mDEX As Integer = 8
    Public mCON As Integer = 8
    Public mINT As Integer = 8
    Public mWIS As Integer = 8
    Public mCHA As Integer = 8
    Public mPoints As Integer = 25

    'Public AbilityScores As New Dictionary(Of String, Integer)

    Private Sub AbScores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RichTextBox1.SelectionAlignment = HorizontalAlignment.Center

        lblSTR.Text = "Strength: " & mSTR + Initial.RaceMod("1").ToString
        lblDEX.Text = "Dexterity: " & mDEX + Initial.RaceMod("2").ToString
        lblCON.Text = "Constitution: " & mCON + Initial.RaceMod("3").ToString
        lblINT.Text = "Intelligence: " & mINT + Initial.RaceMod("4").ToString
        lblWIS.Text = "Wisdom: " & mWIS + Initial.RaceMod("5").ToString
        lblCHA.Text = "Charisma: " & mCHA + Initial.RaceMod("6").ToString

    End Sub

    Private Sub btnSTRUp_Click(sender As Object, e As EventArgs) Handles btnSTRUp.Click
        'Determines whether player has sufficient points to modify the ability score, then modifies the value appropriately
        If mSTR < 14 And mPoints >= 1 Then
            mSTR += 1
            mPoints -= 1
            lblSTR.Text = "Strength: " & (mSTR + Initial.RaceMod("1")).ToString
            lblPoints.Text = mPoints.ToString
        ElseIf mSTR >= 14 And mSTR < 16 And mPoints >= 2 Then
            mSTR += 1
            mPoints -= 2
            lblSTR.Text = "Strength: " & (mSTR + Initial.RaceMod("1")).ToString
            lblPoints.Text = mPoints.ToString
        ElseIf mSTR >= 16 And mSTR < 18 And mPoints >= 3 Then
            mSTR += 1
            mPoints -= 3
            lblSTR.Text = "Strength: " & (mSTR + Initial.RaceMod("1")).ToString
            lblPoints.Text = mPoints.ToString
        ElseIf mSTR = 18 Then
            'Displays an error if the ability score is already at maximum and the player attempts to increase it
            MessageBox.Show("You can't increase a score past 18 at character creation!")
        Else
            'Displays an error if the player doesn't have enough buy points to increase the ability score
            MessageBox.Show("You don't have enough points left to increase this score!")
        End If
    End Sub

    Private Sub btnSTRDown_Click(sender As Object, e As EventArgs) Handles btnSTRDown.Click
            If mSTR = 8 Then
                MessageBox.Show("You can't decrease this score any further!")
            ElseIf mSTR <= 14 Then
                mSTR -= 1
                mPoints += 1
            lblSTR.Text = "Strength: " & (mSTR + Initial.RaceMod("1")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mSTR > 14 And mSTR <= 16 Then
                mSTR -= 1
                mPoints += 2
            lblSTR.Text = "Strength: " & (mSTR + Initial.RaceMod("1")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mSTR > 16 And mSTR <= 18 Then
                mSTR -= 1
                mPoints += 3
            lblSTR.Text = "Strength: " & (mSTR + Initial.RaceMod("1")).ToString
            lblPoints.Text = mPoints.ToString
            End If
        End Sub

        Private Sub btnDEXUp_Click(sender As Object, e As EventArgs) Handles btnDEXUp.Click
            If mDEX < 14 And mPoints >= 1 Then
                mDEX += 1
                mPoints -= 1
            lblDEX.Text = "Dexterity: " & (mDEX + Initial.RaceMod("2")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mDEX >= 14 And mDEX < 16 And mPoints >= 2 Then
                mDEX += 1
                mPoints -= 2
            lblDEX.Text = "Dexterity: " & (mDEX + Initial.RaceMod("2")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mDEX >= 16 And mDEX < 18 And mPoints >= 3 Then
                mDEX += 1
                mPoints -= 3
            lblDEX.Text = "Dexterity: " & (mDEX + Initial.RaceMod("2")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mDEX = 18 Then
                MessageBox.Show("You can't increase a score past 18 at character creation!")
            Else
                MessageBox.Show("You don't have enough points left to increase this score!")
            End If
        End Sub

        Private Sub btnDEXDown_Click(sender As Object, e As EventArgs) Handles btnDEXDown.Click
            If mDEX = 8 Then
                MessageBox.Show("You can't decrease this score any further!")
            ElseIf mDEX <= 14 Then
                mDEX -= 1
                mPoints += 1
            lblDEX.Text = "Dexterity: " & (mDEX + Initial.RaceMod("2")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mDEX > 14 And mDEX <= 16 Then
                mDEX -= 1
                mPoints += 2
            lblDEX.Text = "Dexterity: " & (mDEX + Initial.RaceMod("2")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mDEX > 16 And mDEX <= 18 Then
                mDEX -= 1
                mPoints += 3
            lblDEX.Text = "Dexterity: " & (mDEX + Initial.RaceMod("2")).ToString
            lblPoints.Text = mPoints.ToString
            End If
        End Sub

        Private Sub btnCONUp_Click(sender As Object, e As EventArgs) Handles btnCONUp.Click
            If mCON < 14 And mPoints >= 1 Then
                mCON += 1
                mPoints -= 1
            lblCON.Text = "Constitution: " & (mCON + Initial.RaceMod("3")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mCON >= 14 And mCON < 16 And mPoints >= 2 Then
                mCON += 1
                mPoints -= 2
            lblCON.Text = "Constitution: " & (mCON + Initial.RaceMod("3")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mCON >= 16 And mCON < 18 And mPoints >= 3 Then
                mCON += 1
                mPoints -= 3
            lblCON.Text = "Constitution: " & (mCON + Initial.RaceMod("3")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mCON = 18 Then
                MessageBox.Show("You can't increase a score past 18 at character creation!")
            Else
                MessageBox.Show("You don't have enough points left to increase this score!")
            End If
        End Sub

        Private Sub btnCONDown_Click(sender As Object, e As EventArgs) Handles btnCONDown.Click
            If mCON = 8 Then
                MessageBox.Show("You can't decrease this score any further!")
            ElseIf mCON <= 14 Then
                mCON -= 1
                mPoints += 1
            lblCON.Text = "Constitution: " & (mCON + Initial.RaceMod("3")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mCON > 14 And mCON <= 16 Then
                mCON -= 1
                mPoints += 2
            lblCON.Text = "Constitution: " & (mCON + Initial.RaceMod("3")).ToString
            lblPoints.Text = mPoints.ToString
            ElseIf mCON > 16 And mCON <= 18 Then
                mCON -= 1
                mPoints += 3
            lblCON.Text = "Constitution: " & (mCON + Initial.RaceMod("3")).ToString
            lblPoints.Text = mPoints.ToString
            End If
        End Sub

        Private Sub btnINTUp_Click(sender As Object, e As EventArgs) Handles btnINTUp.Click
            If mINT < 14 And mPoints >= 1 Then
                mINT += 1
                mPoints -= 1
                lblINT.Text = "Intelligence: " & mINT.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mINT >= 14 And mINT < 16 And mPoints >= 2 Then
                mINT += 1
                mPoints -= 2
                lblINT.Text = "Intelligence: " & mINT.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mINT >= 16 And mINT < 18 And mPoints >= 3 Then
                mINT += 1
                mPoints -= 3
                lblINT.Text = "Intelligence: " & mINT.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mINT = 18 Then
                MessageBox.Show("You can't increase a score past 18 at character creation!")
            Else
                MessageBox.Show("You don't have enough points left to increase this score!")
            End If
        End Sub

        Private Sub btnINTDown_Click(sender As Object, e As EventArgs) Handles btnINTDown.Click
            If mINT = 8 Then
                MessageBox.Show("You can't decrease this score any further!")
            ElseIf mINT <= 14 Then
                mINT -= 1
                mPoints += 1
                lblINT.Text = "Intelligence: " & mINT.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mINT > 14 And mINT <= 16 Then
                mINT -= 1
                mPoints += 2
                lblINT.Text = "Intelligence: " & mINT.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mINT > 16 And mINT <= 18 Then
                mINT -= 1
                mPoints += 3
                lblINT.Text = "Intelligence: " & mINT.ToString
                lblPoints.Text = mPoints.ToString
            End If
        End Sub

        Private Sub btnWISUp_Click(sender As Object, e As EventArgs) Handles btnWISUp.Click
            If mWIS < 14 And mPoints >= 1 Then
                mWIS += 1
                mPoints -= 1
                lblWIS.Text = "Wisdom: " & mWIS.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mWIS >= 14 And mWIS < 16 And mPoints >= 2 Then
                mWIS += 1
                mPoints -= 2
                lblWIS.Text = "Wisdom: " & mWIS.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mWIS >= 16 And mWIS < 18 And mPoints >= 3 Then
                mWIS += 1
                mPoints -= 3
                lblWIS.Text = "Wisdom: " & mWIS.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mWIS = 18 Then
                MessageBox.Show("You can't increase a score past 18 at character creation!")
            Else
                MessageBox.Show("You don't have enough points left to increase this score!")
            End If
        End Sub

        Private Sub btnWISDown_Click(sender As Object, e As EventArgs) Handles btnWISDown.Click
            If mWIS = 8 Then
                MessageBox.Show("You can't decrease this score any further!")
            ElseIf mWIS <= 14 Then
                mWIS -= 1
                mPoints += 1
                lblWIS.Text = "Wisdom: " & mWIS.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mWIS > 14 And mWIS <= 16 Then
                mWIS -= 1
                mPoints += 2
                lblWIS.Text = "Wisdom: " & mWIS.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mWIS > 16 And mWIS <= 18 Then
                mWIS -= 1
                mPoints += 3
                lblWIS.Text = "Wisdom: " & mWIS.ToString
                lblPoints.Text = mPoints.ToString
            End If
        End Sub

        Private Sub btnCHAUp_Click(sender As Object, e As EventArgs) Handles btnCHAUp.Click
            If mCHA < 14 And mPoints >= 1 Then
                mCHA += 1
                mPoints -= 1
                lblCHA.Text = "Charisma: " & mCHA.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mCHA >= 14 And mCHA < 16 And mPoints >= 2 Then
                mCHA += 1
                mPoints -= 2
                lblCHA.Text = "Charisma: " & mCHA.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mCHA >= 16 And mCHA < 18 And mPoints >= 3 Then
                mCHA += 1
                mPoints -= 3
                lblCHA.Text = "Charisma: " & mCHA.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mCHA = 18 Then
                MessageBox.Show("You can't increase a score past 18 at character creation!")
            Else
                MessageBox.Show("You don't have enough points left to increase this score!")
            End If
        End Sub

        Private Sub btnCHADown_Click(sender As Object, e As EventArgs) Handles btnCHADown.Click
            If mCHA = 8 Then
                MessageBox.Show("You can't decrease this score any further!")
            ElseIf mCHA <= 14 Then
                mCHA -= 1
                mPoints += 1
                lblCHA.Text = "Charisma: " & mCHA.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mCHA > 14 And mCHA <= 16 Then
                mCHA -= 1
                mPoints += 2
                lblCHA.Text = "Charisma: " & mCHA.ToString
                lblPoints.Text = mPoints.ToString
            ElseIf mCHA > 16 And mCHA <= 18 Then
                mCHA -= 1
                mPoints += 3
                lblCHA.Text = "Charisma: " & mCHA.ToString
                lblPoints.Text = mPoints.ToString
            End If
        End Sub

    Private Sub btnResetScores_Click(sender As Object, e As EventArgs) Handles btnResetScores.Click

        'Resets all fields to their initial values
        mPoints = 25
        mSTR = 8
        mDEX = 8
        mCON = 8
        mINT = 8
        mWIS = 8
        mCHA = 8
        lblSTR.Text = "Strength: " & mSTR.ToString
        lblDEX.Text = "Dexterity: " & mSTR.ToString
        lblCON.Text = "Constitution: " & mSTR.ToString
        lblINT.Text = "Intelligence: " & mSTR.ToString
        lblWIS.Text = "Wisdom: " & mSTR.ToString
        lblCHA.Text = "Charisma: " & mCHA.ToString
        lblPoints.Text = mPoints.ToString

    End Sub

    Private Sub btnSaveScores_Click(sender As Object, e As EventArgs) Handles btnSaveScores.Click

        'Checks that the player has spent all buy points
        If mPoints = 0 Then

            'Updates the ability scores dictionary with the appropriate values
            Initial.AbScores.Add("STR", mSTR)
            Initial.AbScores.Add("DEX", mDEX)
            Initial.AbScores.Add("CON", mCON)
            Initial.AbScores.Add("INT", mINT)
            Initial.AbScores.Add("WIS", mWIS)
            Initial.AbScores.Add("CHA", mCHA)
        Else

            'Displays abn error if the players has not spent all buy points
            MessageBox.Show("Please spend all points before proceeding!")
            Exit Sub
        End If

        'Enables the feat selection button on the main form
        Initial.btnFeats.Enabled = 1

        'Disables the button for the current step
        Initial.btnScores.Enabled = False

        'Sets the ability score labels on the main form to the appropriate values
        Initial.lblSTR.Text = "Strength: " & mSTR + Initial.RaceMod.Item(1)
        Initial.lblDEX.Text = "Dexterity: " & mDEX.ToString + Initial.RaceMod.Item(2)
        Initial.lblCON.Text = "Constitution: " & mCON.ToString + Initial.RaceMod.Item(3)
        Initial.lblINT.Text = "Intelligence: " & mINT.ToString + Initial.RaceMod.Item(4)
        Initial.lblWIS.Text = "Wisdom: " & mWIS.ToString + Initial.RaceMod.Item(5)
        Initial.lblCHA.Text = "Charisma: " & mCHA.ToString + Initial.RaceMod.Item(6)

        'Enables the button for the next step
        Initial.btnFeats.Enabled = True

        'Closes the form
        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Closes the form
        Me.Close()

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class