Public Class MenuShop
    'for when the mouse enters the bat icon in the shop
    Private Sub batbutton_mouseenter(ByVal sender As Object, ByVal e As System.EventArgs) Handles batbutton.MouseEnter
        'displays the name and price
        BatText.Show()
    End Sub
    'for when the mouse leaves the bat icon in the shop
    Private Sub batbutton_mouseleave(ByVal sender As Object, ByVal e As System.EventArgs) Handles batbutton.MouseLeave
        'hides the name and price
        BatText.Hide()
    End Sub
    'for when the mouse enters the gun icon in the shop
    Private Sub gunbutton_mouseenter(ByVal sender As Object, ByVal e As System.EventArgs) Handles gunbutton.MouseEnter
        'displays the name and price
        GunText.Show()
    End Sub
    'for when the mouse leaves the gun icon in the shop
    Private Sub gunbutton_mouseleave(ByVal sender As Object, ByVal e As System.EventArgs) Handles gunbutton.MouseLeave
        'hides the name and price
        GunText.Hide()
    End Sub
    'for when the shop meny is loaded
    Private Sub MenuShop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hides the names and prices of goods, these will only be displayed when the player mouses over them
        colatext.Hide()
        BatText.Hide()
        GunText.Hide()
        'sets the label showing the player's money within the shop menu to the current value in inventory.cashamount
        LabelCashShop.Text = "CASH: " & inventory.cashamount & "$"
    End Sub
    'for when the mouse enters the cola icon in the shop
    Private Sub colabutton_mouseenteer(ByVal sender As Object, ByVal e As System.EventArgs) Handles colabutton.MouseEnter
        'displays the name and price
        colatext.Show()
    End Sub
    'for when the mouse leaves the cola icon in the shop
    Private Sub colabutton_mouseleave(ByVal sender As Object, ByVal e As System.EventArgs) Handles colabutton.MouseLeave
        'hides the name and price
        colatext.Hide()
    End Sub
    'when the player clicks the cola icon, attempting to buy a can of cola
    Private Sub colabutton_Click(sender As Object, e As EventArgs) Handles colabutton.Click
        'checks for the case that the player cannot afford the cola (having under 5 dollars)
        If inventory.cashamount < 5 Then
            'spawns error message to tell the player why they can't buy the cola
            Dim response As MsgBoxResult
            response = MsgBox("Not enough money", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "error")
            'checks for the case that the player already has ten cans of cola, which is the maximum allowed
        ElseIf inventory.colaamount >= 10 Then
            'spawns error message with reason
            Dim response As MsgBoxResult
            response = MsgBox("You can't carry any more cola!", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "error")
            'if the player can afford and has room for the cola
        Else
            'removes 5 dollars from the player
            inventory.cashamount = inventory.cashamount - 5
            'updates the cash label to reflect player's new money amount
            LabelCashShop.Text = "CASH:  " & inventory.cashamount & "$"
            'adds a cola to the player's inventory
            inventory.colaamount = inventory.colaamount + 1
        End If
    End Sub
    'when the player clicks the bat icon to attempt to buy a bat
    Private Sub batbutton_Click(sender As Object, e As EventArgs) Handles batbutton.Click
        'checks for if the player does not have the 20$ required
        If inventory.cashamount < 20 Then
            'spawns error message with reason
            Dim response As MsgBoxResult
            response = MsgBox("Not enough money", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "error")
            'checks for if the player already owns a bat and has no need for another
        ElseIf inventory.hasbat = True Then
            'spawns error box with reason why
            Dim response As MsgBoxResult
            response = MsgBox("You already own this", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "error")
            'if the player passes the checks
        Else
            'removes 20$ from player
            inventory.cashamount = inventory.cashamount - 20
            'updates cash label to reflect new amount of money
            LabelCashShop.Text = "CASH: " & inventory.cashamount & "$"
            'sets inventory.hasbat to true to add the bat to the player's inventory
            inventory.hasbat = True
        End If
    End Sub
    'when the player clicks the gun icon to attempt to buy a gun
    Private Sub gunbutton_Click(sender As Object, e As EventArgs) Handles gunbutton.Click
        'checks for if the player does not have the 50$ required
        If inventory.cashamount < 50 Then
            'spawns error message with reason
            Dim response As MsgBoxResult
            response = MsgBox("Not enough money", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "error")
            'checks for if the player already owns a gun and has no need for another
        ElseIf inventory.hasgun = True Then
            'spawns error message with reason
            Dim response As MsgBoxResult
            response = MsgBox("You already own this", MsgBoxStyle.Exclamation = MsgBoxStyle.OkOnly, "error")
        Else
            'removes 50$ from player
            inventory.cashamount = inventory.cashamount - 50
            'updates cash label
            LabelCashShop.Text = "CASH: " & inventory.cashamount & "$"
            'sets inventory.hasgun to true to add gun to player's inventory
            inventory.hasgun = True
        End If
    End Sub
End Class