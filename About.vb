﻿Public Class About
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point

    Public Sub MoveForm_MouseDown(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseDown ' Add more handles here (Example: PictureBox1.MouseDown)

        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.NoMove2D
            MoveForm_MousePosition = e.Location
        End If

    End Sub

    Public Sub MoveForm_MouseMove(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseMove ' Add more handles here (Example: PictureBox1.MouseMove)

        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If

    End Sub

    Public Sub MoveForm_MouseUp(sender As Object, e As MouseEventArgs) Handles _
    MyBase.MouseUp ' Add more handles here (Example: PictureBox1.MouseUp)

        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If

    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        ' Imposta la lingua iniziale
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If linguaSelezionata = "English" Then
            Label2.Text = "BetaCalculator™ is developed and distributed by BetaCloud Archive®.


BetaCalculator v4.4
~Don’t just stand there, look to the future and move on!~

© BetaCloud Archive 2020-2024.

BetaRIXOLINO is the BetaCalculator™ developer.

What's new:
- Rebranded name
- Added IEEE P745
- Added Language Settings"

        Else
            Label2.Text = "BetaCalculator™ è sviluppato e distribuito da BetaCloud Archive®.

BetaCalculator v4.4

~Non stare lì impalato, guarda al futuro e vai oltre!~
© BetaCloud Archive 2020-2024.

BetaRIXOLINO (Simone Risola) è lo sviluppatore di questa calcolatrice.

Novità:
- Rebrand del programma
- Aggiunto lo standard IEEE P754
- Aggiunte le impostazioni per la lingua"

        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class