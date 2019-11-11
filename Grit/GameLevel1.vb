Public Class GameLevel1
    'this boolean will be used to determine if enemy2 is still alive, defined as a global variable because it will need to be accessed by a variety of procedures
    Dim dead2 As Boolean
    'this boolean will be used to determine if knifedude is still alive, defined as a global variable because it will need to be accessed by a variety of procedures
    Dim dead As Boolean
    'facing will be used to define the position the character is facing, which will be necesarry for combat mechanics so is defined as a global 
    Dim facing As Integer
    'this subprocedure will be activated when a key is pressed, eg for movement or attacking
    Private Sub gamelevel1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'allows me to assign code to certain keycodes' keydown events, so for when certain keys are pressed
        Select Case e.KeyCode
            'pressing 'w' or the up arrow
            Case Keys.Up, Keys.W
                'moves the character up by 7, although have to use -7 becasue computer axes start at top left
                Characterbox.Top = Characterbox.Top - 7
                'sets facing to 0 so I know that the player is facing upwards
                facing = 0
            'pressing 'a' or the left arrow
            Case Keys.Left, Keys.A
                'changes character's x coordinate to itself - 7, moving left
                Characterbox.Left = Characterbox.Left - 7
                'sets facing to 1 so I know character is facing left
                facing = 1
            'pressing 'd' or the right arrow
            Case Keys.Right, Keys.D
                'changes character's x coordinate to itself + 7, moving right
                Characterbox.Left = Characterbox.Left + 7
                'sets facing to 2 so I know character is facing right
                facing = 2
            'pressing 's' or the down arrow
            Case Keys.Down, Keys.S
                'changes character's y coordinate to itself + 7, moving down
                Characterbox.Top = Characterbox.Top + 7
                'sets facing to 2 so I know character is facing right
                facing = 3
            'pressing 'e'
            Case Keys.E
                'brings up the inventory screen
                inventory.Show()
                'pushes inventory to front so it is visible over other forms
                inventory.BringToFront()
            'pressing the spacebar
            Case Keys.Space
                'this if statement will act accordingly to which weapon the player currently has equipped
                'currentwep = 1 is for the bat
                If inventory.currentwep = 1 Then
                    'this if statement acts according to which direction the player is facing, it calls the attackbat() function with different parameters dependingly
                    'for facing right
                    If facing = 2 Then
                        'the parameter xcoord here is Characterbox.Location.X + 60, because the batline will need to be to the right of the character if they are facing that way
                        'the parameter image is the standard 'batslash', as the slash line will not need to be inverted or rotated if the player is facing right, just a simple slash curving
                        'the parameter side is true because the attack is to the side of the player, not above or below so the size of batline will remain standard.
                        attackbat(Characterbox.Location.X + 60, Characterbox.Location.Y, My.Resources.batslash, True)
                        'for facing left
                    ElseIf facing = 1 Then
                        'the parameter xcoord here is Characterbox.Location.X - 60, because the batline will need to be to the left of the character if they are facing that way
                        'the parameter image is slashleft, which is similar to the original except has been flipped so that the slash line curves correctly on this side of the player
                        'the parameter side is true because the attack is to the side of the player, not above or below so the size of batline will remain standard.
                        attackbat(Characterbox.Location.X - 60, Characterbox.Location.Y, My.Resources.slashleft, True)
                        'for facing up
                    ElseIf facing = 0 Then
                        'the parameter xcoord here is Characterbox.Location.X - 60, because the top left corner of batline will be left of the player's top left corner, as it is a wide slash
                        'the parameter ycoord here is Characterbox.Location.Y - 44, because the top left corner of batline will be above the player's top left corner, since they are slashing upwards
                        'the parameter image is slashup, another modified batlslash to look correct for slashes above the player
                        'the parameter side is false because the attack is not to either side of the player so the shape of batline will have to be made wide instead of tall
                        attackbat(Characterbox.Location.X - 60, Characterbox.Location.Y - 44, My.Resources.slashup, False)
                        'forfacing down
                    ElseIf facing = 3 Then
                        'the parameter xcoord here is Characterbox.Location.X - 60, because the top left corner of batline will be left of the player's top left corner, as it is a wide slash
                        'the parameter ycoord here is Characterbox.Location.Y  + 118, because the top left corner of batline will be far below the player's top left corner, since they are slashing downwards
                        'the parameter image is slashunder 
                        'the parameter side is false because the attack is not to either side of the player so the shape of batline will have to be made wide instead of tall
                        attackbat(Characterbox.Location.X - 60, Characterbox.Location.Y + 118, My.Resources.slashunder, False)
                    End If
                    'For when the currentwep is 0, which represents fists 
                ElseIf inventory.currentwep = 0 Then
                    'attackfist is called with appropriate co ordinate modifiers for the direction. No image parameter is needed for the fist, as it is a top-down picture which has no front or back and so does not need to change orientation for each direction. Similarly, because it is a box shape it does not need a parameter to tell if it is being executed sideways, because its dimensions would stay the same anyway
                    If facing = 2 Then
                        attackfist(Characterbox.Location.X + 64, Characterbox.Location.Y + 28)
                        'for facing left
                    ElseIf facing = 1 Then
                        attackfist(Characterbox.Location.X - 37, Characterbox.Location.Y + 35)
                        'for facing up
                    ElseIf facing = 0 Then
                        attackfist(Characterbox.Location.X + 13, Characterbox.Location.Y - 37)
                        'for facing down
                    ElseIf facing = 3 Then
                        attackfist(Characterbox.Location.X + 17, Characterbox.Location.Y + 138)
                    End If
                    'now for currentwep = 2, which is the gun
                ElseIf inventory.currentwep = 2 Then
                    'for facing right
                    If facing = 2 Then
                        'attackgun has similar parameters to attackbat, however with attackgun there is an extra parameter at the end which determines whether the direction the bullet needs to move is positive, coordinate wise (down or right) or negative (up or left)
                        attackgun(Characterbox.Location.X + 72, Characterbox.Location.Y + 49, My.Resources.bulletleft, True, True)
                        'for facing left
                    ElseIf facing = 1 Then
                        attackgun(Characterbox.Location.X - 72, Characterbox.Location.Y + 49, My.Resources.bullet, True, False)
                        'for facing up, the 4th parameter is false because it is not a sideways (left or right) attack and the 5th parameter is false which means negative (in terms of computer coordinates) movement, so from this the attack gun procedure can work out that it is going to need to move the bullet upwards. 
                    ElseIf facing = 0 Then
                        attackgun(Characterbox.Location.X + 17, Characterbox.Location.Y - 57, My.Resources.bulletup, False, False)
                        'for facing down
                    ElseIf facing = 3 Then
                        attackgun(Characterbox.Location.X + 17, Characterbox.Location.Y + 57, My.Resources.bulletdown, False, True)
                    End If
                End If

        End Select
        'This if statement handles the intersection of the characterbox with certian things, namely the collision boxes and rebuffs the character by moving them back on themself to make it look as though they have stayed still
        If PictureBox1.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top += 7
        ElseIf PictureBox3.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Left += 7
        ElseIf PictureBox4.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Left -= 7
        ElseIf PictureBox5.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top += 7
        ElseIf PictureBox6.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top -= 7
        ElseIf PictureBox7.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Left -= 7
        ElseIf PictureBox8.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top += 7
        ElseIf PictureBox22.Bounds.IntersectsWith(Characterbox.Bounds) And Characterbox.Bounds.IntersectsWith(PictureBox11.Bounds) = True Then
            Characterbox.Top += 7
        ElseIf PictureBox9.Bounds.IntersectsWith(Characterbox.Bounds) And Characterbox.Bounds.IntersectsWith(PictureBox11.Bounds) = False Then
            Characterbox.Top -= 7
        ElseIf PictureBox10.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top += 7
        ElseIf PictureBox12.Bounds.IntersectsWith(Characterbox.Bounds) And Characterbox.Bounds.IntersectsWith(PictureBox11.Bounds) Then
            Characterbox.Top += 7
        ElseIf PictureBox13.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top += 7
        ElseIf PictureBox14.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top -= 7
        ElseIf PictureBox15.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Left -= 7
        ElseIf PictureBox17.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top += 7
        ElseIf PictureBox20.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top -= 7
        ElseIf PictureBox21.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top += 7
        ElseIf PictureBox29.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Left += 7
        ElseIf PictureBox28.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Top -= 7
        ElseIf PictureBox27.Bounds.IntersectsWith(Characterbox.Bounds) Then
            Characterbox.Left -= 7
            ' this part handles the collision with exit boxes such as the welcome mat to the shop
        ElseIf WelcomeMat.Bounds.IntersectsWith(Characterbox.Bounds) Then
            'the shop level is shown
            GameLevelShop.Show()
            'it is also brought to the front in case it is already open in the background
            GameLevelShop.BringToFront()
            'the character's bounds are changed to keep them away from the welcome mat when they step outside 
            Characterbox.SetBounds(933, 125, 60, 132)
        ElseIf Characterbox.Bounds.IntersectsWith(PictureBox24.Bounds) Then
            'gamelevel2 is shown
            GameLevel2.Show()
            'it is brought to the front in case it was already open somewhere else
            GameLevel2.BringToFront()
        End If
    End Sub



    Public Sub GameLevel1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The attacks are hidden, as they only need to be visible briefly when the player attacks with their relevant weapon
        batline.Hide()
        fistbox.Hide()
        bulletbox.Hide()
        'moneybag is also hidden, as this is what will appear if the player gets lucky on the 50% chance when an enemy is defeated.
        moneybag.Hide()
        'the following if statement gives the player items depending on the difficulty selected in the how to play screen
        'For difficulty = 0, easy
        If MenuHowToPlay.difficulty = 0 Then
            'The player is given two colas and ten dollars to make the game easier
            inventory.colaamount += 2
            inventory.cashamount += 10
            'for difficulty = 1, which represents medium difficulty
        ElseIf MenuHowToPlay.difficulty = 1 Then
            'The player only gets one cola
            inventory.colaamount += 1
            'the if statement ends without a line for difficulty = 2, the hard setting, because the hard difficulty does not get any items to begin with.
        End If
    End Sub
    'This procedure will damage the player the amount specified in the parameter- dmg.
    Public Sub damage(dmg As Integer)
        'Removes dmg amount from the player’s health
        inventory.health -= dmg
        'Creates an array of hearts similar to the cola drink procedure
        Dim hearts(5)
        'assigns the heart game objects to places in the array
        hearts(0) = heart1
        hearts(1) = heart2
        hearts(2) = heart3
        hearts(3) = heart4
        hearts(4) = heart5
        hearts(5) = heart6
        'i is used as a counter to iterate through the array
        For i = 1 To 6
            'Determines if the new health is low enough for the current heart to be hidden, eg for heart1 (i=1) health must be under(6-1) x 10 which is 50
            If inventory.health <= (6 - i) * 10 Then
                'Hides the specified heart
                hearts(i - 1).hide()
            End If
        Next i
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'The Boolean dead determines if the enemy is dead
        'For if the enemy is still alive 
        If dead = False Then
            'Checks if the character is within the enemy’s range boundaries
            If Characterbox.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                'Calls on pursue, passing the specific enemy and the character as parameters
                inventory.pursue(KnifeDude, Characterbox)
            End If
            'For if dead is true and the enemy is defeated
        Else
            'Sets the enemy to somewhere off the grid to make sure that it does not touch the player and damage them
            KnifeDude.SetBounds(-999, -999, -999, -999)
        End If
        'For if the enemy is still alive
        If dead2 = False Then
            'Checks if the character is within the enemy’s range boundaries
            If Characterbox.Bounds.IntersectsWith(PictureBox26.Bounds) Then
                'Calls on pursue, passing the specific enemy and the character as parameters
                inventory.pursue(enemy2, Characterbox)
            End If
            'For if dead is true and the enemy is defeated
        Else
            'Sets the enemy to somewhere off the grid to make sure that it does not touch the player and damage them
            enemy2.SetBounds(-999, -999, -999, -999)
        End If
        'checks to see what the current weapon is and changes the weapon icon in the HUD to reflect this
        'when the currentwep is 0 (fists)
        If inventory.currentwep = 0 Then
            'sets the hud image to the fist icon
            weaponhud.BackgroundImage = My.Resources.wepfist
            'sets the player's image to unarmed
            Characterbox.BackgroundImage = My.Resources.character
            'when the currentwep is 1 (bat)
        ElseIf inventory.currentwep = 1 Then
            'sets the hud image to the bat icon
            weaponhud.BackgroundImage = My.Resources.wepbat
            'sets the player's image to holding a bat
            Characterbox.BackgroundImage = My.Resources.charbat
            'when the currentwep is 3 (gun) 
        ElseIf inventory.currentwep = 2 Then
            'sets the hud image to the gun icon
            weaponhud.BackgroundImage = My.Resources.wepgun
            'sets the player's image to holding a gun
            Characterbox.BackgroundImage = My.Resources.chargun
        End If
        'sets the cash indicator in the HUD to the proper amount from the inventory class
        cashhud.Text = inventory.cashamount & "$"
        'This moves the character’s hitbox (a small rectangle around the edge of the character which will determine how close an enemy has to get before the character is damaged) to be aligned with the character. The first two parameters are the xcoordindate and ycoordinate of the hitbox, which are modifications of the player’s coordinates except slightly up and to the left, in order to get the hitbox to encircle the player.
        hitbox.SetBounds(Characterbox.Location.X - 5, Characterbox.Location.Y - 5, 70, 142)
        'checks for intersection of the character and the moneybag
        If Characterbox.Bounds.IntersectsWith(moneybag.Bounds) Then
            'Adds contents of the moneybag, 15 dollars, to the inventory
            inventory.cashamount += 15
            'moves the moneybag far away so that the player won’t be able to keep intersecting with it and getting more money!
            moneybag.SetBounds(-999, -999, 0, 0)
        End If
        'For if the character’s hitbox intersects an enemy’s bounds, calls upon the collision function which will determine this
        If inventory.collision(hitbox, KnifeDude) = True Then
            'Calls on the damage procedure with the parameter 10, which lowers the player’s health by 10 and updates the HUD. This will continue until the player either kills or moves away from the enemy
            damage(10)
        End If
        'For if the character’s hitbox intersects an enemy’s bounds, calls upon the collision function which will determine this
        If inventory.collision(hitbox, enemy2) = True Then
            'Calls on the damage procedure with the parameter 10, which lowers the player’s health by 10 and updates the HUD. This will continue until the player either kills or moves away from the enemy
            damage(10)

        End If
    End Sub
    'Procedure for the fist attack, uses parameters to know where to move the fist icon to
    Private Sub attackfist(xcoord, ycoord)
        'Sets the icon’s location and its size to the correct values which were passed. Size always remains the same
        fistbox.SetBounds(xcoord, ycoord, 31, 31)
        'makes the icon visible
        fistbox.Show()
        'checks for intersection of enemy and fist icon
        If KnifeDude.Bounds.IntersectsWith(fistbox.Bounds) Then
            'Releases the enemy from memory locations, as it’s no longer needed
            KnifeDude.Dispose()
            'sets dead to true, which is used by other procedures to handle the enemy
            dead = True
            'calls chance to see if the player has gotten lucky enough to spawn some loot, providing co ordinates of where it should appear if so.
            chance(fistbox.Location.X, fistbox.Location.Y)
        ElseIf enemy2.Bounds.IntersectsWith(fistbox.Bounds) Then
            'Releases the enemy from memory locations, as it’s no longer needed
            enemy2.Dispose()
            'sets dead to true, which is used by other procedures to handle the enemy
            dead2 = True
            'calls chance to see if the player has gotten lucky enough to spawn some loot, providing co ordinates of where it should appear if so.
            chance(fistbox.Location.X, fistbox.Location.Y)
        End If
        'Calls the wait procedure to keep the fist visible for 250 ms before it disappears, otherwise the player wouldn’t even see it
        inventory.wait(0.25)
        'hides the fistbox again
        fistbox.Hide()
    End Sub
    'This is a similar procedure for the bat, although this has more parameters. The image parameter is for which image the bat slash will need to display, as for each direction the slash will be aimed a different way so will look different. ‘Side’ determines whether the attack is being done sideways (left or right) or not, because the slash picturebox will have different dimensions depending on this. The sideways slashes will look like this | and the up/down ones will be more like this _, basically have the same dimensions except length and width are swapped.
    Private Sub attackbat(xcoord As Object, ycoord As Object, image As Object, side As Boolean)
        'This if statement sets the dimensions of the bat slash depending on the side parameter
        'For up/down slashes
        If side = False Then
            'Slash is moved into place and given the right dimensions 
            batline.SetBounds(xcoord, ycoord, 187, 58)
            'for sideways (left/ right) slashes
        Else
            'Slash is moved into place and given the right dimensions
            batline.SetBounds(xcoord, ycoord, 58, 187)
        End If
        'The image of the slash is set to the one provided as a parameter
        batline.BackgroundImage = image
        'the slash is displayed
        batline.Show()
        'checks for intersection of enemy and slash
        If KnifeDude.Bounds.IntersectsWith(batline.Bounds) Then
            'Releases enemy from memory locations
            KnifeDude.Dispose()
            'sets dead to true
            dead = True
            'calls chance for loot
            chance(batline.Location.X, batline.Location.Y)
            'checks for intersection of enemy and slash
        ElseIf enemy2.Bounds.IntersectsWith(batline.Bounds) Then
            enemy2.Dispose()
            'sets dead2 to true
            dead2 = True
            'calls chance for loot
            chance(batline.Location.X, batline.Location.Y)
        End If
        'Waits before hiding the slash by calling on wait
        inventory.wait(0.25)
        'hides the slash
        batline.Hide()
    End Sub
    'Another attack procedure, this time its for the gun. This has the side parameter, but also another Boolean –‘way- which determines if the movement of the bullet needs to be positive (down or right) or negative (up or left). Positive and negative refer to axes on computers, where (0,0) is the top left corner of the screen.
    Private Sub attackgun(xcoord As Object, ycoord As Object, image As Object, side As Boolean, way As Boolean)
        'For when the attack is not left or right
        If side = False Then
            'The bullet is placed in the specified parameters and given correct dimensions for its side facing shape
            bulletbox.SetBounds(xcoord, ycoord, 25, 51)
            'sets the background image of bulletbox to the given image in the parameter
            bulletbox.BackgroundImage = image
            'makes the bullletbox visible
            bulletbox.Show()
            'this do until statement runs until the bullet has travelled 570 units away from its original y or x coordinates, which is the maximum range of the bullet
            Do Until bulletbox.Location.Y = ycoord + 570 Or bulletbox.Location.Y = ycoord - 570
                'For if the movement needed is positive (downwards in the case that it is not going left or right)
                If way = True Then
                    'moves the bullet down by 5 units 
                    bulletbox.Top += 5
                Else
                    'Moves the bullet up 5 units
                    bulletbox.Top -= 5
                End If
                'Checks for intersection of enemy with bulletbox, to see if the enemy should be killed
                If KnifeDude.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    'Frees the enemy from memory locations
                    KnifeDude.Dispose()
                    'Sets the enemy’s dead Boolean to true
                    dead = True
                    'calls chance for loot drop to be triggered
                    chance(bulletbox.Location.X, bulletbox.Location.Y)
                ElseIf enemy2.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    ''Frees the enemy from memory locations
                    enemy2.Dispose()
                    'Sets the enemy’s dead Boolean to true
                    dead2 = True
                    'calls chance for loot drop to be triggered
                    chance(bulletbox.Location.X, bulletbox.Location.Y)

                End If
                'Calls on the wait procedure to make the bullet wait before moving again, this is done to prevent the bullet immediately flying to its destination
                inventory.wait(0.0001)
                'loop marks the end of the do until
            Loop
            'The bullet is made invisible once it has reached its maximum range
            bulletbox.Hide()
            'for if the bullet is travelling sideways (either left or right)
        Else
            'The bullet is still set to where it is required by the x and y coord parameters, but the length and width are flipped from where side = false so that it is now horizontal rather than vertical
            bulletbox.SetBounds(xcoord, ycoord, 51, 25)
            'sets image to parameter
            bulletbox.BackgroundImage = image
            'displays the bullet
            bulletbox.Show()
            'this do until statement runs until the bullet has travelled 570 units away from its original y or x coordinates, which is the maximum range of the bullet
            Do Until bulletbox.Location.X = xcoord + 570 Or bulletbox.Location.X = xcoord - 570
                'For when positive movement is needed (going right)
                If way = True Then
                    'Moves the bullet 
                    bulletbox.Left += 5
                    'for when negative movement needed (going left)
                Else
                    'Moves the bullet 
                    bulletbox.Left -= 5
                End If
                'Checks for intersection of enemy with bulletbox, to see if the enemy should be killed
                If KnifeDude.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    'Frees the enemy from memory locations
                    KnifeDude.Dispose()
                    'Sets the enemy’s dead Boolean to true
                    dead = True
                    'calls chance for loot drop to be triggered
                    chance(bulletbox.Location.X, bulletbox.Location.Y)
                ElseIf enemy2.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    ' 'Frees the enemy from memory locations
                    enemy2.Dispose()
                    'Sets the enemy’s dead Boolean to true
                    dead2 = True
                    'calls chance for loot drop to be triggered
                    chance(bulletbox.Location.X, bulletbox.Location.Y)
                End If
                'Calls on the wait procedure to make the bullet wait before moving again, this is done to prevent the bullet immediately flying to its destination
                inventory.wait(0.0001)
                'loop marks the end of the do until
            Loop
            'The bullet is made invisible once it has reached its maximum range
            bulletbox.Hide()
        End If
    End Sub
    Public Sub boxcollide(chara As Object, box As Object, amount As Integer)
        If facing = 2 Then
            chara.Left -= amount
        ElseIf facing = 1 Then
            chara.left += amount
        ElseIf facing = 3 Then
            chara.top -= amount
        ElseIf facing = 0 Then
            chara.top += amount
        End If
    End Sub
    'This procedure is for when the attack procedures need to determine whether loot should be spawned by the defeated enemy. The parameters x and y are the coordinates where the enemy was defeated and are where the loot needs to be spawned
    Private Sub chance(x, y)
        'Defines chance and initialises it
        Dim chance As Integer = 0
        'chcne is set to a random integer between 0 and 100
        chance = Int(Rnd() * 100) + 1
        'for if chance is under or equal to 50 (success!)
        If chance <= 50 Then
            'Moves the money bag to where specified, 34 and 50 are just its dimensions
            moneybag.SetBounds(x, y, 34, 50)
            'makes the money bag visible
            moneybag.Show()
        End If
    End Sub

End Class
