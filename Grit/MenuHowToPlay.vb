Public Class MenuHowToPlay
    'defines difficulty as shared integer so it can be accessed elsewhere to make changes depending on its value. Different values will represent different difficulties
    Public Shared difficulty As Integer = 0
    'handles user clicking the exit button
    Private Sub ButtonExit_Click(sender As Object, e As EventArgs) Handles ButtonExit.Click
        'closes this form, putting user back to the main menu
        Me.Dispose()
    End Sub

    Private Sub MenuHowToPlay_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Location = New Point(0, 0)
        Me.Size = SystemInformation.PrimaryMonitorSize
    End Sub
    'For when the player clicks on the medium difficulty
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles medbutton.Click
        'Sets difficulty to 1, representing medium
        difficulty = 1
    End Sub
    'for when the player clicks on easy 
    Private Sub easybutton_Click(sender As Object, e As EventArgs) Handles easybutton.Click
        'Sets difficulty to zero, representing easy
        difficulty = 0
    End Sub
    'For when the player clicks on hard difficulty
    Private Sub hardbutton_Click(sender As Object, e As EventArgs) Handles hardbutton.Click
        'Sets difficulty to 2, representing hard
        difficulty = 2
    End Sub
End Class