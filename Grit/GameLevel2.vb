Public Class GameLevel2
    Dim facing As Integer
    Dim dead As Boolean
    Dim dead3 As Boolean
    Dim dead2 As Boolean
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        'Set the Form's KeyPreview property to True
        Select Case e.KeyCode
            Case Keys.Up, Keys.W
                characterbox.Top = characterbox.Top - 7
                facing = 0
            Case Keys.Left, Keys.A
                characterbox.Left = characterbox.Left - 7
                facing = 1
            Case Keys.Right, Keys.D
                characterbox.Left = characterbox.Left + 7
                facing = 2
            Case Keys.Down, Keys.S
                characterbox.Top = characterbox.Top + 7
                facing = 3
            Case Keys.E
                inventory.Show()
                inventory.BringToFront()
            Case Keys.Space
                If inventory.currentwep = 1 Then
                    If facing = 2 Then
                        attackbat(characterbox.Location.X + 114, characterbox.Location.Y, My.Resources.batslash, True)
                    ElseIf facing = 1 Then
                        attackbat(characterbox.Location.X - 80, characterbox.Location.Y, My.Resources.slashleft, True)
                    ElseIf facing = 0 Then
                        attackbat(characterbox.Location.X - 60, characterbox.Location.Y - 80, My.Resources.slashup, False)
                    ElseIf facing = 3 Then
                        attackbat(characterbox.Location.X - 63, characterbox.Location.Y + 212, My.Resources.slashunder, False)
                    End If
                ElseIf inventory.currentwep = 0 Then
                    If facing = 2 Then
                        attackfist(characterbox.Location.X + 114, characterbox.Location.Y + 28)
                    ElseIf facing = 1 Then
                        attackfist(characterbox.Location.X - 37, characterbox.Location.Y + 35)
                    ElseIf facing = 0 Then
                        attackfist(characterbox.Location.X + 31, characterbox.Location.Y - 44)
                    ElseIf facing = 3 Then
                        attackfist(characterbox.Location.X + 31, characterbox.Location.Y + 212)
                    End If
                ElseIf inventory.currentwep = 2 Then
                    If facing = 2 Then
                        attackgun(characterbox.Location.X + 72, characterbox.Location.Y + 49, My.Resources.bulletleft, True, True)
                    ElseIf facing = 1 Then
                        attackgun(characterbox.Location.X - 72, characterbox.Location.Y + 49, My.Resources.bullet, True, False)
                    ElseIf facing = 0 Then
                        attackgun(characterbox.Location.X + 17, characterbox.Location.Y - 57, My.Resources.bulletup, False, False)
                    ElseIf facing = 3 Then
                        attackgun(characterbox.Location.X + 17, characterbox.Location.Y + 57, My.Resources.bulletdown, False, True)
                    End If
                End If
        End Select

        If characterbox.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            characterbox.Left += 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox16.Bounds) Then
            characterbox.Left += 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            characterbox.Top += 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox18.Bounds) Then
            characterbox.Top += 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox13.Bounds) Then
            characterbox.Top += 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            characterbox.Top += 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox15.Bounds) Then
            characterbox.Top -= 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            characterbox.Left -= 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox14.Bounds) Then
            characterbox.Left -= 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox19.Bounds) Then
            characterbox.Left -= 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox8.Bounds) And characterbox.Bounds.IntersectsWith(PictureBox7.Bounds) Then
            characterbox.Top += 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox6.Bounds) And characterbox.Bounds.IntersectsWith(PictureBox7.Bounds) = False Then
            characterbox.Top -= 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox9.Bounds) Or characterbox.Bounds.IntersectsWith(PictureBox10.Bounds) And characterbox.Bounds.IntersectsWith(PictureBox11.Bounds) = False Then
            characterbox.Top -= 7
        ElseIf characterbox.Bounds.IntersectsWith(PictureBox9.Bounds) Or characterbox.Bounds.IntersectsWith(PictureBox10.Bounds) And characterbox.Bounds.IntersectsWith(PictureBox12.Bounds) Then
            characterbox.Top += 7
        ElseIf characterbox.Bounds.IntersectsWith(exitbox.Bounds) Then
            GameLevel1.Show()
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If dead = False Then
            If characterbox.Bounds.IntersectsWith(picturebox29.Bounds) Then
                inventory.pursue(knifedude, characterbox)
            End If
        Else
            knifedude.SetBounds(-999, -999, -999, -999)
        End If
        If dead2 = False Then
            If characterbox.Bounds.IntersectsWith(PictureBox17.Bounds) Then
                inventory.pursue(enemy2, characterbox)
            End If
        Else
            enemy2.SetBounds(-999, -999, -999, -999)
        End If
        If dead3 = False Then
            If characterbox.Bounds.IntersectsWith(PictureBox20.Bounds) Then
                inventory.pursue(enemy3, characterbox)
            End If
        Else
            enemy3.SetBounds(-999, -999, -999, -999)
        End If
        If inventory.currentwep = 0 Then
            weaponhud.BackgroundImage = My.Resources.wepfist
            characterbox.BackgroundImage = My.Resources.character
        ElseIf inventory.currentwep = 1 Then
            weaponhud.BackgroundImage = My.Resources.wepbat
            characterbox.BackgroundImage = My.Resources.charbat
        ElseIf inventory.currentwep = 2 Then
            weaponhud.BackgroundImage = My.Resources.wepgun
            characterbox.BackgroundImage = My.Resources.chargun
        End If
        cashhud.Text = inventory.cashamount & "$"
        hitbox.SetBounds(characterbox.Location.X - 5, characterbox.Location.Y - 5, 70, 142)
        If characterbox.Bounds.IntersectsWith(moneybag.Bounds) Then
            inventory.cashamount += 15
            moneybag.SetBounds(-999, -999, 0, 0)
        End If
        If inventory.health <= 50 Then
            heart1.Hide()
        Else
            heart1.Show()
        End If
        If inventory.health <= 40 Then
            heart2.Hide()
        Else
            heart2.Show()
        End If
        If inventory.health <= 30 Then
            heart3.Hide()
        Else
            heart3.Show()
        End If
        If inventory.health <= 20 Then
            heart4.Hide()
        Else
            heart4.Show()

        End If
        If inventory.health <= 10 Then
            heart5.Hide()
        Else
            heart5.Show()
        End If
        If inventory.health <= 0 Then
            heart6.Hide()
        Else
            heart6.Show()
        End If
        If inventory.collision(hitbox, knifedude) = True Then
            GameLevel1.damage(10)
            inventory.wait(1)
        End If
        If inventory.collision(hitbox, enemy2) = True Then
            GameLevel1.damage(10)
            inventory.wait(1)
        End If
        If inventory.collision(hitbox, enemy3) = True Then
            GameLevel1.damage(10)
            inventory.wait(1)
        End If
    End Sub
    Private Sub attackfist(xcoord, ycoord)
        fistbox.SetBounds(xcoord, ycoord, 31, 31)
        fistbox.Show()
        If knifedude.Bounds.IntersectsWith(fistbox.Bounds) Then
            knifedude.Dispose()
            dead = True
            chance(fistbox.Location.X, fistbox.Location.Y)
        ElseIf enemy2.Bounds.IntersectsWith(fistbox.Bounds) Then
            enemy2.Dispose()
            dead2 = True
            chance(fistbox.Location.X, fistbox.Location.Y)
        ElseIf enemy3.Bounds.IntersectsWith(fistbox.Bounds) Then
            enemy3.Dispose()
            dead3 = True
            chance(fistbox.Location.X, fistbox.Location.Y)
        End If
        inventory.wait(0.25)
        fistbox.Hide()
    End Sub
    Private Sub attackbat(xcoord As Object, ycoord As Object, image As Object, side As Boolean)
        If side = False Then
            batline.SetBounds(xcoord, ycoord, 187, 58)
        Else
            batline.SetBounds(xcoord, ycoord, 58, 187)
        End If
        batline.BackgroundImage = image
        batline.Show()
        If knifedude.Bounds.IntersectsWith(batline.Bounds) Then
            knifedude.Dispose()
            dead = True
            chance(batline.Location.X, batline.Location.Y)
        ElseIf enemy2.Bounds.IntersectsWith(batline.Bounds) Then
            enemy2.Dispose()
            dead2 = True
            chance(batline.Location.X, batline.Location.Y)
        ElseIf enemy3.Bounds.IntersectsWith(batline.Bounds) Then
            enemy3.Dispose()
            dead3 = True
            chance(batline.Location.X, batline.Location.Y)
        End If
        inventory.wait(0.25)
        batline.Hide()
    End Sub
    Private Sub attackgun(xcoord As Object, ycoord As Object, image As Object, side As Boolean, way As Boolean)
        If side = False Then
            bulletbox.SetBounds(xcoord, ycoord, 25, 51)
            bulletbox.BackgroundImage = image
            bulletbox.Show()
            Do Until bulletbox.Location.Y = ycoord + 570 Or bulletbox.Location.Y = ycoord - 570
                If way = True Then
                    bulletbox.Top += 5
                Else
                    bulletbox.Top -= 5
                End If
                If knifedude.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    knifedude.Dispose()
                    dead = True
                    chance(bulletbox.Location.X, bulletbox.Location.Y)
                ElseIf enemy2.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    enemy2.Dispose()
                    dead2 = True
                    chance(bulletbox.Location.X, bulletbox.Location.Y)
                ElseIf enemy3.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    enemy3.Dispose()
                    dead3 = True
                    chance(bulletbox.Location.X, bulletbox.Location.Y)
                End If

                inventory.wait(0.0001)
            Loop
            bulletbox.Hide()
        Else
            bulletbox.SetBounds(xcoord, ycoord, 51, 25)
            bulletbox.BackgroundImage = image
            bulletbox.Show()
            Do Until bulletbox.Location.X = xcoord + 570 Or bulletbox.Location.X = xcoord - 570
                If way = True Then
                    bulletbox.Left += 5
                Else
                    bulletbox.Left -= 5
                End If
                If knifedude.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    knifedude.Dispose()
                    dead = True
                    chance(bulletbox.Location.X, bulletbox.Location.Y)
                ElseIf enemy2.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    enemy2.Dispose()
                    dead2 = True
                    chance(bulletbox.Location.X, bulletbox.Location.Y)
                ElseIf enemy3.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    enemy3.Dispose()
                    dead3 = True
                    chance(bulletbox.Location.X, bulletbox.Location.Y)
                End If
                inventory.wait(0.0001)
            Loop
            bulletbox.Hide()
        End If


    End Sub
    Private Sub chance(x, y)
        Dim chance As Integer = 0
        chance = Int(Rnd() * 100) + 1 'Now iTheVariable is between 1 and 100
        If chance <= 50 Then
            moneybag.SetBounds(x, y, 34, 50)
            moneybag.Show()
        End If
    End Sub

    Private Sub GameLevel2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fistbox.Hide()
        batline.Hide()
        moneybag.Hide()
        bulletbox.Hide()
    End Sub

    Private Sub PictureBox20_Click(sender As Object, e As EventArgs) Handles PictureBox20.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class