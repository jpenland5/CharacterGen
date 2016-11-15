Public Class Alignment
    Private Sub btnLawG_Click(sender As Object, e As EventArgs) Handles btnLawG.Click

        'Updates the alignment details to reflect the selected alignment
        rtbAlignInfo.Text = "Lawful Good" & vbCrLf & "A lawful good character has the commitment and discipline to oppose and fight evil relentlessly. She tells the truth, keeps her word, and speaks out against injustice. A lawful good character hates to see the guilty go unpunished. A paladin who fights evil without mercy and who protects the innocent without hesitation is lawful good. Lawful good emphasizes honor and compassion."
        Initial.mAlignment = "Lawful Good"
    End Sub

    Private Sub btnNeuG_Click(sender As Object, e As EventArgs) Handles btnNeuG.Click
        rtbAlignInfo.Text = "Neutral Good" & vbCrLf & "A neutral good character does the best that a good person can do. He is devoted to helping others. He works with kings and magistrates but does not feel beholden to them. A cleric who helps others according to their needs is neutral good. Neutral good means doing what is good without bias toward or against order."
        Initial.mAlignment = "Neutral Good"
    End Sub

    Private Sub btnChaG_Click(sender As Object, e As EventArgs) Handles btnChaG.Click
        rtbAlignInfo.Text = "Chaotic Good" & vbCrLf & "A chaotic good character acts as his conscience directs him with little regard for what others expect. He believes in goodness and right, but has little use for laws and regulations. He follows his own moral compass, which, although good, may not agree with that of society. A ranger who waylays the evil baron's tax collectors is chaotic good. Chaotic good combines a good heart with a free spirit."
        Initial.mAlignment = "Chaotic Good"
    End Sub


    Private Sub btnLawN_Click(sender As Object, e As EventArgs) Handles btnLawN.Click
        rtbAlignInfo.Text = "Lawful Neutral" & vbCrLf & "A lawful neutral character acts as law, tradition, or a personal code direct her. She may believe in personal order and live by a code or standard, or she may believe in order for all and favor a strong, organized government. A monk who follows her discipline without being swayed by the demands of those in need nor by the temptations of evil is lawful neutral. Lawful neutral means that you are reliable and honorable without being a zealot."
        Initial.mAlignment = "Lawful Neutral"
    End Sub

    Private Sub btnTruN_Click(sender As Object, e As EventArgs) Handles btnTruN.Click
        rtbAlignInfo.Text = "True Neutral" & vbCrLf & "A true neutral character does not feel strongly one way or the other about good vs. evil or law vs. chaos. She thinks good is better than evil — after all, she would rather have good neighbors and rulers than evil ones — but she is not personally committed to upholding good in any abstract or universal way. A wizard who devotes herself to her art and is bored by the semantics of moral debate is true neutral. Some true neutral characters, however, commit themselves philosophically to neutrality. They see good, evil, law, and chaos as dangerous extremes. They advocate neutrality as the most balanced road in the long run. Neutral means you act naturally, without prejudice or compulsion."
        Initial.mAlignment = "True Neutral"
    End Sub

    Private Sub btnChaN_Click(sender As Object, e As EventArgs) Handles btnChaN.Click
        rtbAlignInfo.Text = "Chaotic Neutral" & vbCrLf & "A chaotic neutral character is an individualist, resents restrictions, and challenges tradition. He does not intentionally promote anarchy, however, as that would require he be motivated either by good (and a desire to liberate others) or evil (and a desire to make others suffer). A bard who wanders the land living by his wits is chaotic neutral. Chaotic neutral represents freedom both from society's restrictions and from a do-gooder's zeal, though a character of this alignment is not totally random in his actions. He is not as likely to jump off a bridge as to cross it."
        Initial.mAlignment = "Chaotic Neutral"
    End Sub

    Private Sub btnLawE_Click(sender As Object, e As EventArgs) Handles btnLawE.Click
        rtbAlignInfo.Text = "Lawful Evil" & vbCrLf & "A lawful evil villain methodically takes what he wants within the limits of his code of conduct. He cares about tradition, loyalty, and order, but not about freedom, dignity, or life. He is loath to break laws or promises, partly because he depends on order to protect himself. Some lawful evil villains have particular taboos, such as not killing in cold blood, and imagine that these compunctions put them above unprincipled thugs. The scheming baron who exploits his people is lawful evil. Lawful evil represents methodical, intentional evil."
        Initial.mAlignment = "Lawful Evil"
    End Sub

    Private Sub btnNeuE_Click(sender As Object, e As EventArgs) Handles btnNeuE.Click
        rtbAlignInfo.Text = "Neutral Evil" & vbCrLf & "A neutral evil villain does whatever she can get away with, shedding no tears for those she harms. She has no love of order and holds no illusion that following laws, traditions, or codes would make her any more noble. However, she doesn't have the restless nature or love of conflict that a chaotic evil villain has. The criminal who robs and murders to get what she wants is neutral evil. Neutral evil represents evil without honor and without variation."
        Initial.mAlignment = "Neutral Evil"
    End Sub

    Private Sub btnChaE_Click(sender As Object, e As EventArgs) Handles btnChaE.Click
        rtbAlignInfo.Text = "Chaotic Evil" & vbCrLf & "A chaotic evil character does whatever his greed, hatred, and lust for destruction drive him to do. He is hot-tempered, vicious, and unpredictable. Thankfully, his plans are haphazard, and any groups he joins or forms are poorly organized. Typically, chaotic evil people can only be made to work together by force, and their leader lasts only as long as he can thwart attempts to topple or assassinate him. The demented sorcerer pursuing mad schemes of vengeance and havoc is chaotic evil. Chaotic evil represents the destruction not only of beauty and life but of the order on which beauty and life depend."
        Initial.mAlignment = "Chaotic Evil"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Initial.mAlignment IsNot Nothing Then
            'Updates the label on the main form to reflect the player's alignment choice
            Initial.lblAlign.Text = "Alignment: " & Initial.mAlignment

            'Enables the button for the next step
            Initial.btnScores.Enabled = True

            Me.Close()
        Else
            MessageBox.Show("Please select an alignment before continuing!")
        End If


    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Clears the alignment choice and closes the form
        Initial.mAlignment = Nothing
        Me.Close()

    End Sub

    Private Sub Alignment_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Initial.mClass = 1 Or Initial.mClass = 2 Then

            btnLawG.Enabled = False
            btnLawN.Enabled = False
            btnLawE.Enabled = False
        ElseIf Initial.mClass = 4 Then
            btnLawG.Enabled = False
            btnChaG.Enabled = False
            btnLawE.Enabled = False
            btnChaE.Enabled = False
        ElseIf Initial.mclass = 6 Then
            btnNeuG.Enabled = False
            btnChaG.Enabled = False
            btnTruN.Enabled = False
            btnChaN.Enabled = False
            btnNeuE.Enabled = False
            btnChaE.Enabled = False
        ElseIf Initial.mClass = 7 Then
            btnNeuG.Enabled = False
            btnChaG.Enabled = False
            btnLawN.Enabled = False
            btnTruN.Enabled = False
            btnChaN.Enabled = False
            btnLawE.Enabled = False
            btnNeuE.Enabled = False
            btnChaE.Enabled = False
        End If

    End Sub
End Class