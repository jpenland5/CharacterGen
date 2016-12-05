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
        lblAppraise.Text = mAllInfo(21)
        lblBluff.Text = mAllInfo(22)
        lblConcentration.Text = mAllInfo(23)
        lblDiscipline.Text = mAllInfo(24)
        lblIntimidate.Text = mAllInfo(25)
        lblParry.Text = mAllInfo(26)

    End Sub
End Class