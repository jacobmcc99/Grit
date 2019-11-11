Public Class inventory
    'Defines the shared variables which will need to be accessed by other forms
    Public Shared cashamount As Integer
    Public Shared colaamount As Integer
    Public Shared hasgun As Boolean
    Public Shared hasbat As Boolean
    Public Shared health As Integer
    Public Shared currentwep As Integer

    'keydown form for when the user presses a key
    Private Sub inventory_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        'Set the Form's KeyPreview property to True
        Select Case e.KeyCode
            'specifies the key 'e' to be used to trigger the next line
            Case Keys.E
                'closes the inventory
                Me.Hide()
                'this is the only keydown event needed, so I can end the select 
        End Select
    End Sub
    'for when the user clicks the cola icon
    Public Sub coladrinklabel_Click(sender As Object, e As EventArgs) Handles coladrinklabel.Click
        'handles the event that the user has no cola left to drink
        If colaamount <= 0 Then
            'error message with reason
            MsgBox("No Cola to Drink!")
            'in the case that the user's health is 50 or over, since the max is 60 it is ideal to prevent the user exceeding max health
        ElseIf inventory.health >= 50 And inventory.health <> 60 Then
            'health is set to 60, the max allowed
            inventory.health = 60
            'removes the drunk cola
            colaamount -= 1
            'updates cola label to reflect removal
            colalabel.Text = "X " & colaamount
            'for when the user already has max health of 60, so they have no need to drink cola
        ElseIf inventory.health = 60 Then
            'error message with reason
            MsgBox("Already at max health!")
            'for when the user's health is below 50
        Else
            'removes drunk cola
            colaamount -= 1
            'updates cola label to reflect removal
            colalabel.Text = "X " & colaamount
            'heals the player by 10
            health += 10
        End If
        'for updating the HUD to reflect new health
        'an array is created with 6 spaces to hold the six half heart icons in the HUD
        Dim hearts(5)
        'sets the memory locations within the hearts() array to contain the gameobjects in the proper order, with heart6 being the final half heart before death, or 10 health
        hearts(0) = GameLevel1.heart1
        hearts(1) = GameLevel1.heart2
        hearts(2) = GameLevel1.heart3
        hearts(3) = GameLevel1.heart4
        hearts(4) = GameLevel1.heart5
        hearts(5) = GameLevel1.heart6
        'for loop to iterate through the array and find which hearts to show reflecting the change in health
        For i = 1 To 6
            'performs a check to see if the user's health is greater than 10 x (6-i), to determine if the heart which requires this amount of health should be shown.
            If inventory.health > (6 - i) * 10 Then
                'displays the heart if the player's health is greather than the required amount to show it, as checked in the previous line. EG for max health (60) when i is 1, 60 is greater than (6-1)x10 so hearts(1-1[0]) is made visible, which is the gameobject heart1 and the first half heart the player loses.
                hearts(i - 1).show()
            End If
            'increases i by one and restarts the for loop, which will check if the next heart should be shown, hearts(1) or gamelevel1.heart2
        Next i
    End Sub
    'This procedure will make two game object chase each other, by ref is used because the values (locations of the objects) will need to be changed by the procedure
    Public Sub pursue(ByRef chaser As Object, ByRef chased As Object)
        'Determines if the chaser is to the right of the chased
        If chaser.left + chaser.width >= chased.left Then
            'If so, moves the chaser to the left
            chaser.left -= 10
        End If
        'Determines if the chaser is to the left of the chased
        If chaser.left + chaser.width <= chased.left Then
            'If so, moves the chaser to the right
            chaser.left += 10
        End If
        'Determines if the chaser is underneath the chased
        If chaser.top + chaser.height >= chased.top Then
            'If so, moves the chaser upwards
            chaser.top -= 10
        End If
        'Determines if the chaser is above the chased
        If chaser.top + chaser.height <= chased.top Then
            'If so, moves the chaser downwards
            chaser.top += 10
        End If
    End Sub
    'handles the player clicking the bat icon to equip the bat
    Private Sub labelbateqp_Click(sender As Object, e As EventArgs) Handles labelbateqp.Click
        'checks that the player actually owns the bat
        If hasbat = True Then
            'currentwep represents the weapon using numbers, 0 for fists 1 for bat and 2 for gun, so it is set to 1
            currentwep = 1
        End If
    End Sub
    'handles the player clicking the gun icon to equip the gun
    Private Sub labelguneqp_Click(sender As Object, e As EventArgs) Handles labelguneqp.Click
        'validates that the player owns the gun
        If hasgun = True Then
            'currentwep represents the weapon using numbers, 0 for fists 1 for bat and 2 for gun, so it is set to 2
            currentwep = 2
        End If
    End Sub
    'This procedure is used in some others, and its purpose is to cause a delay in the process since there is no wait command in vb.
    'Seconds is the parameter, which determines how many seconds the wait is. It’s a double as I may want to use fractions of a second like 0.5
    Public Sub wait(ByVal seconds As Double)
        'For loop which works out how many times the thread sleep must be executed	
        For i As Double = 0 To seconds * 100
            'The thread.sleep command suspends the current thread for the specified number of milliseconds
            System.Threading.Thread.Sleep(10)
            Application.DoEvents()
        Next
    End Sub
    'handles events happening every 100 milliseconds for things which need to be constantly updated
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'sets the colalabel (amount of cola displayed in inventory) to the correct value
        colalabel.Text = "X " & colaamount
        'sets the cashlabel (amount of cash displayed in inventory) to the correct value
        CashLabel.Text = "X" & cashamount
        'checks if the player owns bat
        If hasbat = True Then
            'hides the question mark over the bat icon
            BatQMark.Hide()
        End If
        'checks if player owns the gun
        If hasgun = True Then
            'hides question mark over gun icon
            GunQMark.Hide()
        End If
    End Sub
    'for when the player clicks on the fist icon
    Private Sub labelfisteqp_Click(sender As Object, e As EventArgs) Handles labelfisteqp.Click
        'sets currentwep to 0 - which represents the fists
        currentwep = 0
    End Sub
    'This function works out if two objects collide, taking the parameters by value as they do not need to be directly edited.
    Public Function collision(ByVal object1, ByVal object2)
        'Defines collided as a Boolean, this is what will be returned by the function. If it’s true, a collision has occurred between the objects. If false, there is no collision. Boolean because it only needs two outcomes and is a truth statement
        Dim collided As Boolean = False
        'The following lines calculate if object 1 and two are intersecting
        If object1.top + object1.height >= object2.top And
                object2.top + object2.height >= object1.top And
                object1.left + object1.width >= object2.left And
                object2.left + object2.width >= object1.left Then
            'if the statements are all true, then collided is set to true to be returned
            collided = True
        End If
        'Collided is returned by the function
        Return collided
    End Function
End Class