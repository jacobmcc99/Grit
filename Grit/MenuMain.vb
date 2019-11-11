Public Class MainMenu
    Dim dead As Integer = 1
    'handles necessary actions for when the game first starts, which is when the main menu is loaded.
    Private Sub MainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'initialises the inventory.health value to 60, the max value, before difficulty is factored in. If it was left as 0, the program would think the player had died and the game would be over
        inventory.health = 60
        'this gives a fullscreen effect by removing borders, to make the menu more immersive
        Me.FormBorderStyle = FormBorderStyle.None
        'the position of the form becomes (0,0), the top-left corner of the monitor -which is where computer axes start from- to make sure no space is left unfilled
        Me.Location = New Point(0, 0)
        'the form's size equals the size of the user's monitor, so that it will work on different setups.
        Me.Size = SystemInformation.PrimaryMonitorSize
    End Sub
    'dictates what happens when the user clicks the exit button
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        'declares a local variable, response, to contain the user's response 
        Dim response As MsgBoxResult
        'this creates a pop up message box with text letting the user know what they are deciding and a yes/no answer input.
        response = MsgBox("Are you sure you want to exit?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Confirm")
        If response = MsgBoxResult.Yes Then
            'closes the game
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            'closes only the message box, leaving the game open
            Exit Sub
        End If
    End Sub

    Private Sub ButtonHowToPlay_Click(sender As Object, e As EventArgs) Handles ButtonHowToPlay.Click
        'opens the how to play form
        MenuHowToPlay.Show()
    End Sub

    Private Sub ButtonPlay_Click(sender As Object, e As EventArgs) Handles ButtonPlay.Click
        'opens gamelevel1, starting the game itself
        GameLevel1.Show()

    End Sub
    'using the timer tick event because it happens every second, so will be constantly evaluated
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'closes this form and subsequently the game if the player's health reaches 0 (or less somehow), signifying the end of the game
        If inventory.health <= 0 And dead = 1 Then
            dead = 0
            Dim response As MsgBoxResult
            response = MsgBox("Game Over", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "You have died. Game Over!")
            If response = MsgBoxResult.Ok Then
                Me.Dispose()
            End If
        End If
    End Sub
End Class
