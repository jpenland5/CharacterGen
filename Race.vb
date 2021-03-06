﻿Public Class Race

    'Public mRace As Integer

    Private Sub Race_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Initializes the contents of the race mod dictionary to default values
        Initial.RaceMod.Add(1, 0)
        Initial.RaceMod.Add(2, 0)
        Initial.RaceMod.Add(3, 0)
        Initial.RaceMod.Add(4, 0)
        Initial.RaceMod.Add(5, 0)
        Initial.RaceMod.Add(6, 0)

    End Sub

    Private Sub btnHuman_Click(sender As Object, e As EventArgs) Handles btnHuman.Click
        statusLabel.Text = ""
        'Updates the race details to display the selected race
        rtbRaceDetail.Text = "Human" & vbCrLf & "Bonus: 1 extra feat, 1 extra Skill Point per level" & vbCrLf & "Humans are the jacks-of-all trades, capable of performing any role but excelling in none. Human flexibility means that they have no real perferred profession."

        'Sets the race tracker to the value representing the selected race
        Initial.mRace = 1

        'Updates the ability score modifiers as relevant to the selected race
        Initial.RaceMod("1") = 0
        Initial.RaceMod("2") = 0
        Initial.RaceMod("3") = 0
        Initial.RaceMod("4") = 0
        Initial.RaceMod("5") = 0
        Initial.RaceMod("6") = 0
    End Sub

    Private Sub btnDwarf_Click(sender As Object, e As EventArgs) Handles btnDwarf.Click
        statusLabel.Text = ""
        'Updates the race details to display the selected race
        rtbRaceDetail.Text = "Dwarf" & vbCrLf & "Bonus: +2 CON, -2 CHA, Darkvision, +1 Attack versus Orcs, +4 Attack versus Giants, +2 Lore, +2 Search while underground" & vbCrLf & "Dwarves are one of the stereotypical fantasy races: short, stout, with a fondness for alcohol and living primarily underground with a natural knack for stoneworking and smithing. Their hardiness lends them an advantage at classes which engage in hand-to-hand combat, but they are also often found working as Clerics."

        'Sets the race tracker to the value representing the selected race
        Initial.mRace = 2

        'Updates the ability score modifiers as relevant to the selected race
        Initial.RaceMod("1") = 0
        Initial.RaceMod("2") = 0
        Initial.RaceMod("3") = 2
        Initial.RaceMod("4") = 0
        Initial.RaceMod("5") = 0
        Initial.RaceMod("6") = -2

    End Sub

    Private Sub btnElf_Click(sender As Object, e As EventArgs) Handles btnElf.Click
        statusLabel.Text = ""
        'Updates the race details to display the selected race
        rtbRaceDetail.Text = "Elf" & vbCrLf & "Bonus: +2 DEX, -2 CON, Low-Light Vision, Immunity to Sleep, Weapon Proficiency: Elf, +2 Listen, +2 Search, +2 Spot" & vbCrLf & "The other 'standard' fantasy race behind dwarves, elvenkind are depicted as lithe and graceful, and their skill with the bow is matched only by their haughtiness. Living to much greater ages than most, elves are often dismissive of their younger peers for their percieved lack of experience. They make excellent Rangers, though many also become Wizards. Despite their natural agility, most are too high-strung to stoop to becoming Rogues."

        'Sets the race tracker to the value representing the selected race
        Initial.mRace = 3

        'Updates the ability score modifiers as relevant to the selected race
        Initial.RaceMod("1") = 0
        Initial.RaceMod("2") = 2
        Initial.RaceMod("3") = -2
        Initial.RaceMod("4") = 0
        Initial.RaceMod("5") = 0
        Initial.RaceMod("6") = 0

    End Sub

    Private Sub btnGnome_Click(sender As Object, e As EventArgs) Handles btnGnome.Click
        statusLabel.Text = ""
        'Updates the race details to display the selected race
        rtbRaceDetail.Text = "Gnome" & vbCrLf & "Bonus: +2 CON, -2 STR, Low-Light Vision, Small Stature (Gnome), +2 Concentration, +6 Listen, +4 Spot" & vbCrLf & "Gnomes are the true little people of the world, being even smaller than Halflings. Despite their stature they prove to be almost as hardy as the dwarves, though their size means they often lack in physical ability otherwise. Gnomes are naturally skilled with the magical arts, especially illusions, and often become Wizards. While not as dexterious as Halflings, their ability to squeeze into tight spots and hide in the shadows still makes them potent Rogues. Low strength makes it difficult for Gnomes to exploit their hardiness as combat classes."

        'Sets the race tracker to the value representing the selected race
        Initial.mRace = 4

        'Updates the ability score modifiers as relevant to the selected race
        Initial.RaceMod("1") = -2
        Initial.RaceMod("2") = 0
        Initial.RaceMod("3") = 2
        Initial.RaceMod("4") = 0
        Initial.RaceMod("5") = 0
        Initial.RaceMod("6") = 0
    End Sub

    Private Sub btnOrc_Click(sender As Object, e As EventArgs) Handles btnOrc.Click
        statusLabel.Text = ""
        'Updates the race details to display the selected race
        rtbRaceDetail.Text = "Half-Orc" & vbCrLf & "Bonus: +2 STR, -2 INT, -2 CHA, Darkvision" & vbCrLf & "The offspring of orc and human parentage, half-orcs are often shunned and maligned by society due to their odd looks and explosive tempers. They make undeniably potent fighters, standing head and shoulders above most other common races with the power to match. Many half-orcs are Barbarians, descended from wild tribes, or Fighters trained to hone their natural militant prowess. Being somewhat simple-minded, orcs make poor Wizards but can be excellent Clerics."

        'Sets the race tracker to the value representing the selected race
        Initial.mRace = 5

        'Updates the ability score modifiers as relevant to the selected race
        Initial.RaceMod("1") = 2
        Initial.RaceMod("2") = 0
        Initial.RaceMod("3") = 0
        Initial.RaceMod("4") = -2
        Initial.RaceMod("5") = 0
        Initial.RaceMod("6") = -2
    End Sub

    Private Sub btnHalf_Click(sender As Object, e As EventArgs) Handles btnHalf.Click
        statusLabel.Text = ""
        'Updates the race details to display the selected race
        rtbRaceDetail.Text = "Halfling" & vbCrLf & "Bonus: +2 DEX, -2 STR, Small Stature (Halfling), +1 Attack with throwing weapons" & vbCrLf & "Halflings are a race of small folk residing somewhere between humans and gnomes in size. Visually, they appear to simply be miniature humans, though some exhibit traits similar to elves such as slightly pointed ears; their true origins are a mystery. Halflings are renouned as the best Rogues in the land, with quick and nimble fingers are a well-earned reputation for being skilled pickpockets. If you need something stolen, hire a Halfling. They are also naturally skilled with sling and stone, capable of felling much larger foes with a well-aimed rock, and almost as dangerous with any other thrown weapon."

        'Sets the race tracker to the value representing the selected race
        Initial.mRace = 6

        'Updates the ability score modifiers as relevant to the selected race
        Initial.RaceMod("1") = -2
        Initial.RaceMod("2") = 2
        Initial.RaceMod("3") = 0
        Initial.RaceMod("4") = 0
        Initial.RaceMod("5") = 0
        Initial.RaceMod("6") = 0
    End Sub

    Private Sub btnElf2_Click(sender As Object, e As EventArgs) Handles btnElf2.Click
        statusLabel.Text = ""
        'Updates the race details to display the selected race
        rtbRaceDetail.Text = "Half-Elf" & vbCrLf & "Bonus: Low-Light Vision, Immunity to Sleep, +1 Listen, +1 Search, +1 Spot" & vbCrLf & "Half-Elves are an odd sort, born to a mixture of human and elven parents. Appearing mostly human with elven traits, half-elves are not reviled like their half-orcish cousins. They lack the unearthly beauty and grace of their elven heritage, but also the unending adaptability of a human; half-elves are destined to forever be the middlemen. Still, they do inheret some useful skills from their elven parent such as sharper senses and an immunity to sleep magic."

        'Sets the race tracker to the value representing the selected race
        Initial.mRace = 7

        'Updates the ability score modifiers as relevant to the selected race
        Initial.RaceMod("1") = 0
        Initial.RaceMod("2") = 0
        Initial.RaceMod("3") = 0
        Initial.RaceMod("4") = 0
        Initial.RaceMod("5") = 0
        Initial.RaceMod("6") = 0
    End Sub

    Private Sub btnSaveRace_Click(sender As Object, e As EventArgs) Handles btnSaveRace.Click
        statusLabel.Text = ""
        'Updates the Race label on the main form to reflect the player's selection
        If Initial.mRace = 1 Then
            Initial.lblRace.Text = "Race: Human"
        ElseIf Initial.mRace = 2 Then
            Initial.lblRace.Text = "Race: Dwarf"
        ElseIf Initial.mRace = 3 Then
            Initial.lblRace.Text = "Race: Elf"
        ElseIf Initial.mRace = 4 Then
            Initial.lblRace.Text = "Race: Gnome"
        ElseIf Initial.mRace = 5 Then
            Initial.lblRace.Text = "Race: Half-Orc"
        ElseIf Initial.mRace = 6 Then
            Initial.lblRace.Text = "Race: Halfling"
        ElseIf Initial.mRace = 7 Then
            Initial.lblRace.Text = "Race: Half-Elf"
        Else
            'Displays an error if no race has been selected
            statusLabel.Text = "Please select a race before continuing!"
            Exit Sub
        End If

        'Modifies the default ability score values based on the selected race
        Initial.lblSTR.Text = "Strength: " & 8 + Initial.RaceMod.Item(1)
        Initial.lblDEX.Text = "Dexterity: " & 8 + Initial.RaceMod.Item(2)
        Initial.lblCON.Text = "Constitution: " & 8 + Initial.RaceMod.Item(3)
        Initial.lblINT.Text = "Intelligence: " & 8 + Initial.RaceMod.Item(4)
        Initial.lblWIS.Text = "Wisdom: " & 8 + Initial.RaceMod.Item(5)
        Initial.lblCHA.Text = "Charisma: " & 8 + Initial.RaceMod.Item(6)

        'Enables the button for the next step
        Initial.btnGender.Enabled = True

        'Disables the button for the current step
        Initial.btnRace.Enabled = False

        'Enables the Back button on the main form
        Initial.btnBack.Enabled = True

        'Closes the form
        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Initial.mRace = Nothing
        'Closes the form
        Me.Close()
    End Sub
End Class