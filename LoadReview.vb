Imports System.IO

Public Class LoadReview
    Private Sub LoadReview_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim mAllInfo As String() = File.ReadAllLines(Initial.CharacterLoad.FileName)

        'Dim fileReader As System.IO.StreamReader
        'fileReader = My.Computer.FileSystem.OpenTextFileReader(Initial.CharacterLoad.FileName)
        'mAllInfo = fileReader.ReadToEnd

        'Basic Stats
        lblName.Text = mAllInfo(1)
        lblRace.Text = mAllInfo(2)
        lblGender.Text = mAllInfo(3)
        lblClass.Text = mAllInfo(4)
        lblAlign.Text = mAllInfo(5)
        lblSTR.Text = mAllInfo(6)
        lblDEX.Text = mAllInfo(7)
        lblCON.Text = mAllInfo(8)
        lblINT.Text = mAllInfo(9)
        lblWIS.Text = mAllInfo(10)
        lblCHA.Text = mAllInfo(11)

        'Skills
        lblAppraise.Text = mAllInfo(14)
        lblBluff.Text = mAllInfo(15)
        lblConcentration.Text = mAllInfo(16)
        lblDiscipline.Text = mAllInfo(17)
        lblIntimidate.Text = mAllInfo(18)
        lblParry.Text = mAllInfo(19)

        If mAllInfo(22) IsNot "" Then
            rtbFeats.AppendText(Environment.NewLine & mAllInfo(22))
        End If
        If mAllInfo(23) IsNot "" Then
            rtbFeats.AppendText(Environment.NewLine & mAllInfo(23))
        End If
        If mAllInfo(24) IsNot "" Then
            rtbFeats.AppendText(Environment.NewLine & mAllInfo(24))
        End If
        If mAllInfo(25) IsNot "" Then
            rtbFeats.AppendText(Environment.NewLine & mAllInfo(25))
        End If
        If mAllInfo(26) IsNot "" Then
            rtbFeats.AppendText(Environment.NewLine & mAllInfo(26))
        End If
        If mAllInfo(27) IsNot "" Then
            rtbFeats.AppendText(Environment.NewLine & mAllInfo(27))
        End If
        If mAllInfo(28) IsNot "" Then
            rtbFeats.AppendText(Environment.NewLine & mAllInfo(28))
        End If
        If mAllInfo(29) IsNot "" Then
            rtbFeats.AppendText(Environment.NewLine & mAllInfo(29))
        End If
        If mAllInfo(30) IsNot "" Then
            rtbFeats.AppendText(Environment.NewLine & mAllInfo(30))
        End If

        rtbBiography.AppendText(mAllInfo(33))

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Close()

    End Sub
End Class