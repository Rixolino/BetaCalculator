Public Class fstequ
    Dim ca, ba
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

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a.Text = ""
        b.Text = ""
        c.Text = ""
        TextBox2.Text = ""
        a1.Text = ""
        a2.Text = ""
    End Sub

    Private Sub NormalActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalActualToolStripMenuItem.Click
        Me.Close()
        Normal.Show()
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Close()
        Scientific.Show()
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
    Private Sub fstequ_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyMenuColors(MenuStrip1)
        title.ForeColor = My.Settings.TextColor
        Me.ForeColor = My.Settings.TextColor
        Me.BackColor = My.Settings.BackgroundColor
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        If FastMenu.Visible = True Then
            FastMenuToolStripMenuItem.Text = "Fast Menu (Close)"
        Else
            FastMenuToolStripMenuItem.Text = "Fast Menu"
        End If
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        Programmer.Show()
        Me.Close()
    End Sub

    Private Sub FastMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastMenuToolStripMenuItem.Click
        If FastMenu.Visible Then
            FastMenu.Hide()
            FastMenuToolStripMenuItem.Text = "Fast Menu"
        Else
            FastMenu.Show()
            FastMenuToolStripMenuItem.Text = "Fast Menu (Close)"
        End If
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = (c.Text - b.Text) / a.Text
        a1.Text = (c.Text - b.Text)
        a2.Text = a.Text
    End Sub
End Class