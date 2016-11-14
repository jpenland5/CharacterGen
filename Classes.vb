Public Class Classes

    'Creates a value for tracking the selected class
    Public mClass As Integer

    Private Sub btnBarb_Click(sender As Object, e As EventArgs) Handles btnBarb.Click
        'Updates the class details to reflect the chosen class
        rtbClassDetail.Text = "Barbarian" & vbCrLf & "Hitdie: d12" & vbCrLf & "Alignment: Any non-Lawful" & vbCrLf & "Proficiencies: armor (light, medium), shields, weapons (martial, simple)" & vbCrLf & "Skill points: 4 + int modifier ( (4 + int modifier) * 4 at 1st level)" & vbCrLf & "Base attack bonus: +1/level" & vbCrLf & "Barbarians are the rough, uncultured fighters of the frontier. Loud, brash, and aggressive, Barbarians tend to rush headlong at their foes wielding two-handed weapons. Their lack of self-preservation is reflected in their inability to wear the heaviest armor and they rarely use shields, but their high HP helps to make up for the fact."

        'Updates the class tracker variable to reflect the chosen class
        mClass = 1
    End Sub

    Private Sub btnBard_Click(sender As Object, e As EventArgs) Handles btnBard.Click
        'Updates the class details to reflect the chosen class
        rtbClassDetail.Text = "Bard" & vbCrLf & "Hit die: d6" & vbCrLf & "Alignment: Any non-Lawful" & vbCrLf & "Proficiencies: armor (light, medium), shields, weapons (simple)" & vbCrLf & "Skill points: 4 + int modifier ( (4 + int modifier) * 4 at 1st level)" & vbCrLf & "Base attack bonus: +3/4 levels" & vbCrLf & "Spellcasting: Arcane, Wisdom - based" & vbCrLf & "Bards are the poets and minstrels of the land. They accompany adventurers as much to recite their deeds later in epic verse as they do to render assistance in the field. While not as skilled as Wizards or Sorcerers, Bards have a knack for casting a bit of arcane magic of their own as well as inspiring allies and demoralizing foes with their mystical bardsong."

        'Updates the class tracker variable to reflect the chosen class
        mClass = 2
    End Sub

    Private Sub btnCleric_Click(sender As Object, e As EventArgs) Handles btnCleric.Click
        'Updates the class details to reflect the chosen class
        rtbClassDetail.Text = "Cleric" & vbCrLf & "Hit die: d8" & vbCrLf & "Alignment: Any" & vbCrLf & "Proficiencies: armor (light, medium, heavy), shields, weapons (simple)" & vbCrLf & "Skill points: 2 + int modifier ( (2 + int modifier) * 4 at 1st level)" & vbCrLf & "Base attack bonus: +3/4 levels" & vbCrLf & "Spellcasting: Divine, Wisdom - based" & vbCrLf & "Clerics are the healers of the world. Having dedicated their lives to preserving those of their fellows, no other class is capable of performing healing magic as often or with as much potency as the Cleric. While in theory capable of healing themselves, Clerics tend to preserve their spells for aiding their allies, and are trained to use even the heaviest armor and simple weapons for self-defense."

        'Updates the class tracker variable to reflect the chosen class
        mClass = 3
    End Sub

    Private Sub btnDruid_Click(sender As Object, e As EventArgs) Handles btnDruid.Click
        'Updates the class details to reflect the chosen class
        rtbClassDetail.Text = "Druid" & vbCrLf & "Hit die: d8" & vbCrLf & "Alignment: Any Neutral" & vbCrLf & "Proficiencies: armor (light, medium), shields, weapons (druid)" & vbCrLf & "Skill points: 4 + int modifier ( (4 + int modifier) * 4 at 1st level)" & vbCrLf & "Base attack bonus: +3/4 levels" & vbCrLf & "Spellcasting: Divine, Wisdom - based" & vbCrLf & "Druids, like Clerics, are spellcasters whose powers are of divine origin. The Druid, however, has a unique attachment to nature and his abilities reflect as much. He has a unique blend of skills which focus on enhancing his allies and taking command of nature, such as summoning forth wolves and other forest creatures. Advanced druids may even call down lightning from the heavens to smite their foes. He is skilled with only a small selection of weapons, preferring to let his other skills do the talking."

        'Updates the class tracker variable to reflect the chosen class
        mClass = 4
    End Sub

    Private Sub btnFighter_Click(sender As Object, e As EventArgs) Handles btnFighter.Click
        'Updates the class details to reflect the chosen class
        rtbClassDetail.Text = "Fighter" & vbCrLf & "Hit die: d10" & vbCrLf & "Alignment: Any" & vbCrLf & "Proficiencies: armor (light, medium, heavy), shields, weapons (martial, simple)" & vbCrLf & "Skill points: 2 + int modifier ( (2 + int modifier) * 4 at 1st level)" & vbCrLf & "Base attack bonus: +1/level" & vbCrLf & "Soldier, sellsword, mercenary, champion; the Fighter goes by many names. The quintessential combat class capable of utilizing nearly any sort of weapon or armor, few are capable of besting him in direct conflict. While the Fighter possesses no spells or magical abilities and cannot match the Barbarian for pure ferocity, his martial prowess is second-to-none and affords him a bevy of extra Feats as his level increases, which greatly enhance his ability to strike down foes."

        'Updates the class tracker variable to reflect the chosen class
        mClass = 5
    End Sub

    Private Sub btnMonk_Click(sender As Object, e As EventArgs) Handles btnMonk.Click
        'Updates the class details to reflect the chosen class
        rtbClassDetail.Text = "Monk" & vbCrLf & "Hit die: d8" & vbCrLf & "Alignment: Any Lawful" & vbCrLf & "Proficiencies: armor (robes), shields, weapons (monk)" & vbCrLf & "Skill points: 4 + int modifier ( (4 + int modifier) * 4 at 1st level)" & vbCrLf & "Base attack bonus: +3/4 levels" & vbCrLf & "The Monk is a unique hand-to-hand class. Skilled in combat while wearing no armor and wielding only his fists, the Monk is nonetheless a capable fighter who can best multiple opponents at once. He possesses a set of abilities unlike any other, somewhere in the realm between magic and martial and fueled by the mystical force known as 'ki'. His unarmed blows can stun foes, freezing them in place, and potent spinning kicks can strike all nearby opponents. High-level Monks can even use their Quivering Palm technique to stop the opponent's heart with a single touch, causing instant death. In their pursuit of the perfection of self, advanced Monks gain bonus damage and attack with their fists and become immune to poison, disease, and other ailments."

        'Updates the class tracker variable to reflect the chosen class
        mClass = 6
    End Sub

    Private Sub btnPal_Click(sender As Object, e As EventArgs) Handles btnPal.Click
        'Updates the class details to reflect the chosen class
        rtbClassDetail.Text = "Paladin" & vbCrLf & "Hit die: d10" & vbCrLf & "Alignment: Lawful Good" & vbCrLf & "Proficiencies: armor (light, medium, heavy), shields, weapons (simple, martial)" & vbCrLf & "Skill points: 2 + int modifier ( (2 + int modifier) * 4 at 1st level)" & vbCrLf & "Base attack bonus: +1/level" & vbCrLf & "Spellcasting: Divine, Wisdom-based" & vbCrLf & "Paladins are the greatest force of goodness the realms have ever known. Warriors tirelessely dedicated to the destruction of evil, a Paladin is what happens when you infuse a Fighter with a Cleric's divine gift. While not as skilled martially as the Fighter nor capable of as many Godly miracles as the Cleric, the Paladin is nonetheless a force to be reckoned with. He specializes in striking down those who do harm to the good folk of the land, with the unique ability to Smite Evil and bring down divine wrath upon those he judges. Paladins can also render aid and heal others through a simple touch by Laying on Hands and casting a limited selection of spells similar to those used by the Cleric."

        'Updates the class tracker variable to reflect the chosen class
        mClass = 7
    End Sub

    Private Sub btnRanger_Click(sender As Object, e As EventArgs) Handles btnRanger.Click
        'Updates the class details to reflect the chosen class
        rtbClassDetail.Text = "Ranger" & vbCrLf & "Hit die: d10" & vbCrLf & "Alignment: Any" & vbCrLf & "Proficiencies: armor (light, medium), shields, weapons (simple, martial)" & vbCrLf & "Skill points: 4 + int modifier ( (4 + int modifier) * 4 at 1st level)" & vbCrLf & "Base attack bonus: +1/level" & vbCrLf & "Spellcasting: Divine, Wisdom-based" & vbCrLf & "Rangers stalk the shadows of the land, hiding in plain sight. But unlike the nefarious Rogue, the Ranger's forte lies among nature, for he is the hunter and tracker, the scout, and the beast-whisperer. Rangers are often the sworn protectors of villages on the edge of the wilderness, keeping their inhabitants safe from the wild things that lurk just beyond sight. Rangers tend to focus on a particular type of foe, a Favored Enemy, against whom they are especially skilled and gain bonuses. They are particularly skilled with the bow or dual-wielding two weapons, and can also cast a limited number of nature-based spells similar to those used by the Druid."

        'Updates the class tracker variable to reflect the chosen class
        mClass = 8
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        'Clears the class selection and closes the form
        mClass = Nothing
        Me.Close()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        'Updates the label on the main form to reflect the player's class choice
        If mClass = 1 Then
            Initial.lblClass.Text = "Class: Barbarian"
        ElseIf mClass = 2 Then
            Initial.lblClass.Text = "Class: Bard"
        ElseIf mClass = 3 Then
            Initial.lblClass.Text = "Class: Cleric"
        ElseIf mClass = 4 Then
            Initial.lblClass.Text = "Class: Druid"
        ElseIf mClass = 5 Then
            Initial.lblClass.Text = "Class: Fighter"
        ElseIf mClass = 6 Then
            Initial.lblClass.Text = "Class: Monk"
        ElseIf mClass = 7 Then
            Initial.lblClass.Text = "Class: Paladin"
        Else
            'Displays an error if no class is selected
            MessageBox.Show("Please select a class before continuing!")
            Exit Sub
        End If

        'Closes the form
        Me.Close()

    End Sub

End Class