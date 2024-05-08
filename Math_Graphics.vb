Imports System.Windows.Forms
Imports System.Drawing
Imports MathNet.Symbolics
Imports MathNet.Numerics.LinearAlgebra
Imports NCalc
Imports Expression = NCalc.Expression
Imports System.Web.ModelBinding

Public Class Math_Graphics
    Private zoom As Double = 1.0
    Private offsetX As Double = 0.0
    Private offsetY As Double = 0.0
    Private step1 As Integer = 50 ' Passo iniziale
    Private scaleFactor As Single = 1

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)
        MyBase.OnPaint(e)
        Dim g As Graphics = e.Graphics
        Dim width As Integer = Me.ClientSize.Width
        Dim height As Integer = Me.ClientSize.Height


    End Sub

    Private Sub DrawGraph(ByVal g As Graphics)

        ' Calcola il range degli assi x e y
        Dim xMin As Double = -10.0 * zoom + offsetX
        Dim xMax As Double = 10.0 * zoom + offsetX
        Dim yMin As Double = -10.0 * zoom + offsetY
        Dim yMax As Double = 10.0 * zoom + offsetY

        ' Calcola la larghezza e l'altezza della finestra di disegno
        Dim width As Integer = Me.ClientSize.Width
        Dim height As Integer = Me.ClientSize.Height

        ' Disegna gli assi x e y
        Dim xAxis As Point() = {New Point(0, height / 2), New Point(width, height / 2)}
        Dim yAxis As Point() = {New Point(width / 2, 0), New Point(width / 2, height)}
        ' Converti il colore delle impostazioni in un oggetto Pen
        Dim textColorPen As New Pen(My.Settings.TextColor)

        ' Disegna le linee utilizzando il colore definito nelle impostazioni del testo
        g.DrawLines(textColorPen, xAxis)
        g.DrawLines(textColorPen, yAxis)


        ' Itera su ogni punto sull'asse x
        For x As Double = xMin To xMax Step 0.01
            If Not String.IsNullOrEmpty(TextBox1.Text) Then
                Dim expr As New Expression(TextBox1.Text)
                expr.Parameters("x") = x
                If TextBox1.Text.Contains("y") Then
                    For y As Double = yMin To yMax Step 0.01
                        expr.Parameters("y") = y
                        Dim result As Double = expr.Evaluate()
                        ' Calcola il corrispondente punto sull'asse x e y
                        Dim screenX As Integer = (x - xMin) / (xMax - xMin) * (width - 1)
                        Dim screenY As Integer = (yMax - y) / (yMax - yMin) * (height - 1)
                        ' Disegna il punto
                        g.DrawRectangle(textColorPen, screenX, screenY, 1, 1)
                    Next
                Else
                    ' Calcola il corrispondente punto sull'asse y
                    Dim y As Double = expr.Evaluate()
                    Dim screenX As Integer = (x - xMin) / (xMax - xMin) * (width - 1)
                    Dim screenY As Integer = (yMax - y) / (yMax - yMin) * (height - 1)
                    ' Disegna il punto
                    g.DrawRectangle(textColorPen, screenX, screenY, 1, 1)
                End If
            End If

        Next
    End Sub

    Private Sub Form1_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        DrawGraph(e.Graphics)
    End Sub


    Private Sub ApplyMenuColors(menu As MenuStrip)
        ' Applica i colori di sfondo e del testo del menu
        menu.BackColor = My.Settings.BackgroundColor
        menu.ForeColor = My.Settings.TextColor

        ' Itera attraverso tutti gli elementi del menu
        For Each item As ToolStripItem In menu.Items
            ' Controlla se l'elemento è un ToolStripMenuItem
            If TypeOf item Is ToolStripMenuItem Then
                ' Applica i colori di sfondo e del testo al ToolStripMenuItem
                Dim menuItem As ToolStripMenuItem = CType(item, ToolStripMenuItem)
                menuItem.BackColor = My.Settings.BackgroundColor
                menuItem.ForeColor = My.Settings.TextColor

                ' Applica ricorsivamente i colori agli elementi figlio del ToolStripMenuItem
                ApplyMenuColorsToItems(menuItem)
            ElseIf TypeOf item Is ToolStripTextBox Then
                ' Se l'elemento è un ToolStripTextBox, applica i colori appropriati
                Dim toolStripTextBox As ToolStripTextBox = CType(item, ToolStripTextBox)
                toolStripTextBox.BackColor = My.Settings.BackgroundColor
                toolStripTextBox.ForeColor = My.Settings.TextColor
            End If
        Next
    End Sub

    Private Sub ApplyMenuColorsToItems(menuItem As ToolStripMenuItem)
        ' Itera attraverso gli elementi figlio del ToolStripMenuItem
        For Each subItem As ToolStripItem In menuItem.DropDownItems
            ' Controlla se l'elemento figlio è un ToolStripMenuItem
            If TypeOf subItem Is ToolStripMenuItem Then
                ' Applica i colori di sfondo e del testo al ToolStripMenuItem figlio
                Dim subMenuItem As ToolStripMenuItem = CType(subItem, ToolStripMenuItem)
                subMenuItem.BackColor = My.Settings.BackgroundColor
                subMenuItem.ForeColor = My.Settings.TextColor

                ' Applica ricorsivamente i colori agli elementi figlio del ToolStripMenuItem figlio
                ApplyMenuColorsToItems(subMenuItem)
            ElseIf TypeOf subItem Is ToolStripTextBox Then
                ' Se l'elemento figlio è un ToolStripTextBox, applica i colori appropriati
                Dim toolStripTextBox As ToolStripTextBox = CType(subItem, ToolStripTextBox)
                toolStripTextBox.BackColor = My.Settings.BackgroundColor
                toolStripTextBox.ForeColor = My.Settings.TextColor
            End If
        Next
    End Sub

    Private Sub Math_Graphics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        ApplyMenuColors(MenuStrip1)
        Me.ForeColor = My.Settings.TextColor
        Me.BackColor = My.Settings.BackgroundColor
        ' Imposta la lingua iniziale
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If linguaSelezionata = "English" Then
            Button1.Text = "Clear"
            CalculatorToolStripMenuItem.Text = "Calculator"
            If FastMenu.Visible = True Then
                FastMenuToolStripMenuItem.Text = "Fast Menu (Close)"
            Else
                FastMenuToolStripMenuItem.Text = "Fast Menu"
            End If
            AboutToolStripMenuItem.Text = "About"
            SettingsToolStripMenuItem.Text = "Settings"
            Button1.Text = "REFRESH"
            Button2.Text = "CLEAR"
            btnZoomIn.Text = "ZOOM IN"
            btnZoomOut.Text = "ZOOM OUT"
            btnMoveUp.Text = "MOVE UP"
            btnMoveDown.Text = "MOVE DOWN"
            btnMoveLeft.Text = "MOVE LEFT"
            btnMoveRight.Text = "MOVE RIGHT"
        ElseIf linguaSelezionata = "Italian" Then
            Button1.Text = "C"
            CalculatorToolStripMenuItem.Text = "Calcolatrici"
            FastMenuToolStripMenuItem.Text = "Menu Veloce"
            AboutToolStripMenuItem.Text = "Informazioni su"
            SettingsToolStripMenuItem.Text = "Impostazioni"
            Button1.Text = "AGGIORNA"
            Button2.Text = "PULISCI"
            btnZoomIn.Text = "INGRADISCI"
            btnZoomOut.Text = "RIMPICIOLISCI"
            btnMoveUp.Text = "SU"
            btnMoveDown.Text = "GIÙ"
            btnMoveLeft.Text = "SINISTRA"
            btnMoveRight.Text = "DESTRA"
        End If
    End Sub

    Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) Handles btnZoomOut.Click
        scaleFactor *= 1.5
        zoom *= 1.25
        Me.Invalidate()
    End Sub

    Private Sub btnZoomIn_Click(sender As Object, e As EventArgs) Handles btnZoomIn.Click
        scaleFactor /= 1.5
        zoom /= 1.25
        Me.Invalidate()
    End Sub

    Private Sub btnMoveLeft_Click(sender As Object, e As EventArgs) Handles btnMoveLeft.Click
        offsetX -= 50
        offsetX -= 10.0 * zoom
        Me.Invalidate()
    End Sub

    Private Sub btnMoveRight_Click(sender As Object, e As EventArgs) Handles btnMoveRight.Click
        offsetX += 50
        offsetX += 10.0 * zoom
        Me.Invalidate()
    End Sub

    Private Sub btnMoveUp_Click(sender As Object, e As EventArgs) Handles btnMoveDown.Click
        offsetY -= 10.0 * zoom
        Me.Invalidate()
    End Sub

    Private Sub btnMoveDown_Click(sender As Object, e As EventArgs) Handles btnMoveUp.Click
        offsetY += 10.0 * zoom
        Me.Invalidate()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Invalidate()
        TextBox1.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.WindowState = FormWindowState.Normal
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub FastMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastMenuToolStripMenuItem.Click
        FastMenu.Show()
    End Sub

    Private Sub NormalActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalActualToolStripMenuItem.Click
        Me.Close()
        Normal.Show()
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Close()
        Scientific.Show()
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        Me.Close()
        Programmer.Show()
    End Sub

    Private Sub BinaryAdditionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BinaryAdditionToolStripMenuItem.Click
        Me.Close()
        BinaryOp.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settingsc.Show()
    End Sub
End Class
