Public Class GameLevelShop
    Dim dead As Boolean
    Dim facing As Integer
    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Set the Form's KeyPreview property to True
        Select Case e.KeyCode
            Case Keys.Up, Keys.W
                CharacterBox.Top = CharacterBox.Top - 9
                facing = 0
            Case Keys.Left, Keys.A
                CharacterBox.Left = CharacterBox.Left - 9
                facing = 1
            Case Keys.Right, Keys.D
                facing = 2
                CharacterBox.Left = CharacterBox.Left + 9
            Case Keys.Down, Keys.S
                facing = 3
                CharacterBox.Top = CharacterBox.Top + 9
            Case Keys.E
                inventory.Show()
                inventory.BringToFront()
            Case Keys.Space
                If inventory.currentwep = 1 Then
                    If facing = 2 Then
                        attackbat(CharacterBox.Location.X + 114, CharacterBox.Location.Y, My.Resources.batslash, True)
                    ElseIf facing = 1 Then
                        attackbat(CharacterBox.Location.X - 80, CharacterBox.Location.Y, My.Resources.slashleft, True)
                    ElseIf facing = 0 Then
                        attackbat(CharacterBox.Location.X - 60, CharacterBox.Location.Y - 80, My.Resources.slashup, False)
                    ElseIf facing = 3 Then
                        attackbat(CharacterBox.Location.X - 63, CharacterBox.Location.Y + 212, My.Resources.slashunder, False)
                    End If
                ElseIf inventory.currentwep = 0 Then
                    If facing = 2 Then
                        attackfist(CharacterBox.Location.X + 114, CharacterBox.Location.Y + 28)
                    ElseIf facing = 1 Then
                        attackfist(CharacterBox.Location.X - 37, CharacterBox.Location.Y + 35)
                    ElseIf facing = 0 Then
                        attackfist(CharacterBox.Location.X + 31, CharacterBox.Location.Y - 44)
                    ElseIf facing = 3 Then
                        attackfist(CharacterBox.Location.X + 31, CharacterBox.Location.Y + 212)
                    End If
                ElseIf inventory.currentwep = 2 Then
                    If facing = 2 Then
                        attackgun(CharacterBox.Location.X + 72, CharacterBox.Location.Y + 49, My.Resources.bulletleft, True, True)
                    ElseIf facing = 1 Then
                        attackgun(CharacterBox.Location.X - 72, CharacterBox.Location.Y + 49, My.Resources.bullet, True, False)
                    ElseIf facing = 0 Then
                        attackgun(CharacterBox.Location.X + 17, CharacterBox.Location.Y - 57, My.Resources.bulletup, False, False)
                    ElseIf facing = 3 Then
                        attackgun(CharacterBox.Location.X + 17, CharacterBox.Location.Y + 57, My.Resources.bulletdown, False, True)
                    End If
                End If
        End Select

        If ExitMat.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            GameLevel1.BringToFront()
            CharacterBox.SetBounds(208, 683, 108, 205)

        ElseIf ShopBox.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            MenuShop.Show()
        ElseIf PictureBox1.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left += 9
        ElseIf PictureBox5.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Top += 9
        ElseIf PictureBox6.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left -= 9
        ElseIf PictureBox2.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left -= 9
        ElseIf PictureBox8.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Top -= 9
        ElseIf PictureBox7.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left += 9
        ElseIf PictureBox3.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left += 9
        ElseIf PictureBox9.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Top += 9
        ElseIf PictureBox12.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left += 9
        ElseIf PictureBox17.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left += 9
        ElseIf PictureBox13.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left += 9
        ElseIf PictureBox11.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left += 9
        ElseIf PictureBox10.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left -= 9
        ElseIf PictureBox14.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left -= 9
        ElseIf PictureBox16.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left -= 9
        ElseIf PictureBox15.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left -= 9
        ElseIf PictureBox21.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Top += 9
        ElseIf PictureBox20.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Top += 9
        ElseIf PictureBox19.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Top += 9
        ElseIf PictureBox18.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Top += 9
        ElseIf PictureBox22.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Top -= 9
        ElseIf PictureBox23.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left -= 9
        ElseIf PictureBox24.Bounds.IntersectsWith(CharacterBox.Bounds) Then
            CharacterBox.Left -= 9
        End If

    End Sub


    Private Sub GameLevelShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DoubleBuffered = True
        fistbox.Hide()
        batline.Hide()
        moneybag.Hide()
        bulletbox.Hide()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If CharacterBox.Bounds.IntersectsWith(PictureBox26.Bounds) Then
            inventory.pursue(knifedude, CharacterBox)
        End If
        If CharacterBox.Bounds.IntersectsWith(moneybag.Bounds) Then
            inventory.cashamount += 15
            moneybag.SetBounds(-999, -999, 0, 0)
        End If
        If CharacterBox.Bounds.IntersectsWith(bigmoney.Bounds) Then
            inventory.cashamount += 40
            bigmoney.SetBounds(-999, -999, 0, 0)
        End If
        hitbox.SetBounds(CharacterBox.Location.X - 5, CharacterBox.Location.Y - 5, 118, 215)
        If dead = False Then
            If CharacterBox.Bounds.IntersectsWith(PictureBox23.Bounds) Then
                inventory.pursue(knifedude, CharacterBox)
            End If
        Else
            knifedude.SetBounds(-999, -999, -999, -999)
        End If
        If inventory.collision(hitbox, knifedude) = True Then
            GameLevel1.damage(10)
            inventory.wait(1)
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
        cashhud.Text = inventory.cashamount & "$"
        If inventory.currentwep = 0 Then
            wephud.BackgroundImage = My.Resources.wepfist
            CharacterBox.BackgroundImage = My.Resources.character
        ElseIf inventory.currentwep = 1 Then
            wephud.BackgroundImage = My.Resources.wepbat
            CharacterBox.BackgroundImage = My.Resources.charbat
        ElseIf inventory.currentwep = 2 Then
            wephud.BackgroundImage = My.Resources.wepgun
            CharacterBox.BackgroundImage = My.Resources.chargun
        End If
    End Sub
    Private Sub attackbat(xcoord As Object, ycoord As Object, image As Object, side As Boolean)
        If side = False Then
            batline.SetBounds(xcoord, ycoord, 187, 58)
        Else
            batline.SetBounds(xcoord, ycoord, 58, 187)
        End If
        batline.BackgroundImage = image
        batline.Show()
        If KnifeDude.Bounds.IntersectsWith(batline.Bounds) Then
            KnifeDude.Dispose()
            dead = True
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
                If KnifeDude.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    KnifeDude.Dispose()
                    dead = True
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
                If KnifeDude.Bounds.IntersectsWith(bulletbox.Bounds) Then
                    KnifeDude.Dispose()
                    dead = True
                    chance(bulletbox.Location.X, bulletbox.Location.Y)
                End If
                inventory.wait(0.0001)
            Loop
            bulletbox.Hide()
        End If
    End Sub
    Private Sub attackfist(xcoord, ycoord)
        fistbox.SetBounds(xcoord, ycoord, 31, 31)
        fistbox.Show()
        If knifedude.Bounds.IntersectsWith(fistbox.Bounds) Then
            knifedude.Dispose()
            dead = True
            chance(fistbox.Location.X, fistbox.Location.Y)
        End If
        inventory.wait(0.25)
        fistbox.Hide()
    End Sub
    Private Sub chance(x, y)
        Dim chance As Integer = 0
        chance = Int(Rnd() * 100) + 1 'Now iTheVariable is between 1 and 100
        If chance <= 50 Then
            moneybag.SetBounds(x, y, 34, 50)
            moneybag.Show()
        End If
    End Sub
End Class

