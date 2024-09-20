﻿Public Class Form1
    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Left Or e.KeyCode = Keys.A Then
            move(avatar, -5, 0)
        End If

        If e.KeyCode = Keys.Right Or e.KeyCode = Keys.D Then
            move(avatar, 5, 0)
        End If

        If e.KeyCode = Keys.Down Or e.KeyCode = Keys.S Then
            move(avatar, 0, 5)
        End If

        If e.KeyCode = Keys.Up Or e.KeyCode = Keys.W Then
            move(avatar, 0, -5)
        End If

        If e.KeyCode = Keys.Space Then
            avatar.Image.RotateFlip(RotateFlipType.Rotate90FlipNone)
        End If
        avatar.Refresh()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        follow(enemy, avatar, 10)
        follow(enemy2, avatar, 5)
    End Sub

    Sub follow(e As PictureBox, a As PictureBox, speed As Integer)
        If e.Location.Y < a.Location.Y Then
            move(e, 0, speed)
        Else
            move(e, 0, -speed)
        End If

        If e.Location.X < a.Location.X Then
            move(e, speed, 0)
        Else
            move(e, -speed, 0)
        End If
    End Sub

    Sub move(p As PictureBox, xdir As Integer, ydir As Integer)
        p.Location += New Point(xdir, ydir)
        If p.Bounds.IntersectsWith(coin.Bounds) Then
            coin.Visible = False
        End If
    End Sub

End Class