Imports BetaCalculator.My

Public Class LinEquationTriple
    Dim fract
    Dim Dxs
    Dim Dys
    Dim Dzs
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Dim m
    Public Sub New()
        InitializeComponent()
        Me.FormBorderStyle = FormBorderStyle.None
        Me.DoubleBuffered = True
        Me.SetStyle(ControlStyles.ResizeRedraw, True)

    End Sub

    Private Const cGrip As Integer = 16
    Private Const cCaption As Integer = 32

    Protected Overrides Sub OnPaint(ByVal e As PaintEventArgs)

    End Sub

    Protected Overrides Sub WndProc(ByRef m As Message)
        If m.Msg = &H84 Then
            Dim pos As Point = New Point(m.LParam.ToInt32())
            pos = Me.PointToClient(pos)

            If pos.Y < cCaption Then
                m.Result = CType(2, IntPtr)
                Return
            End If

            If pos.X >= Me.ClientSize.Width - cGrip AndAlso pos.Y >= Me.ClientSize.Height - cGrip Then
                m.Result = CType(17, IntPtr)
                Return
            End If
        End If



        MyBase.WndProc(m)
    End Sub

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
    Private Sub NormalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem.Click
        Normal.Show()
        Me.Close()
    End Sub

    Private Sub ScientificActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificActualToolStripMenuItem.Click
        Scientific.Show()
        Me.Close()
    End Sub

    Private Sub UnitOfMeasureToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FunctionConverter.Show()
        Me.Close()
    End Sub

    Private Sub NormalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NormalToolStripMenuItem1.Click
        Linearequations.Show()
        Me.Close()
    End Sub

    Private Sub FormulasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormulasToolStripMenuItem.Click
        Formulas.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a1.Text = ""
        a2.Text = ""
        a3.Text = ""
        b1.Text = ""
        b2.Text = ""
        b3.Text = ""
        c1.Text = ""
        c2.Text = ""
        c3.Text = ""
        d1.Text = ""
        d2.Text = ""
        d3.Text = ""
        Resultx.Text = ""
        Resulty.Text = ""
        Resultz.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button3.Click
        fract = (a1.Text * b2.Text * c3.Text) + (b1.Text * c2.Text * a3.Text) + (c1.Text * a2.Text * b3.Text) - (c1.Text * b2.Text * a3.Text) - (b1.Text * a2.Text * c3.Text) - (a1.Text * c2.Text * b3.Text)
        Dxs = (d1.Text * b2.Text * c3.Text) + (b1.Text * c2.Text * d3.Text) + (c1.Text * d2.Text * b3.Text) - (c1.Text * b2.Text * d3.Text) - (b1.Text * d2.Text * c3.Text) - (d1.Text * c2.Text * b3.Text)
        Dys = (a1.Text * d2.Text * c3.Text) + (d1.Text * c2.Text * a3.Text) + (c1.Text * a2.Text * d3.Text) - (c1.Text * d2.Text * a3.Text) - (d1.Text * a2.Text * c3.Text) - (a1.Text * c2.Text * d3.Text)
        Dzs = (a1.Text * b2.Text * d3.Text) + (b1.Text * d2.Text * a3.Text) + (d1.Text * a2.Text * b3.Text) - (d1.Text * b2.Text * a3.Text) - (b1.Text * a2.Text * d3.Text) - (a1.Text * d2.Text * b3.Text)
        Resultx.Text = Dxs / fract
        Resulty.Text = Dys / fract
        Resultz.Text = Dzs / fract

        If Resultx.Text = "NaN" Then
            Resultx.Text = "Indeterminate"
        End If

        If Resulty.Text = "NaN" Then
            Resulty.Text = "Indeterminate"
        End If

        If Resultz.Text = "NaN" Then
            Resultz.Text = "Indeterminate"
        End If

        If Resultx.Text = "∞" Then
            Resultx.Text = "Infinite solution"
        End If

        If Resulty.Text = "∞" Then
            Resulty.Text = "Infinite solution"
        End If

        If Resultz.Text = "∞" Then
            Resultz.Text = "Infinite solution"
        End If

        If Resultx.Text = "-∞" Then
            Resultx.Text = "Infinite solution"
        End If

        If Resulty.Text = "-∞" Then
            Resulty.Text = "Infinite solution"
        End If

        If Resultz.Text = "-∞" Then
            Resultz.Text = "Infinite solution"
        End If

    End Sub

    Private Sub Resulty_TextChanged(sender As Object, e As EventArgs) Handles Resulty.TextChanged

    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TEmore.Show()
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

    Private Sub LinEquationTriple_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ApplyMenuColors(MenuStrip2)
        plus1.ForeColor = My.Settings.TextColor
        plus2.ForeColor = My.Settings.TextColor
        plus3.ForeColor = My.Settings.TextColor
        plus4.ForeColor = My.Settings.TextColor
        plus5.ForeColor = My.Settings.TextColor
        plus6.ForeColor = My.Settings.TextColor
        same1.ForeColor = My.Settings.TextColor
        same2.ForeColor = My.Settings.TextColor
        same3.ForeColor = My.Settings.TextColor
        Closea.ForeColor = My.Settings.TextColor
        Minimizea.ForeColor = My.Settings.TextColor
        Label9.ForeColor = My.Settings.TextColor
        Label10.ForeColor = My.Settings.TextColor
        Label6.ForeColor = My.Settings.TextColor
        Label22.ForeColor = My.Settings.TextColor
        x1.ForeColor = My.Settings.TextColor
        y1.ForeColor = My.Settings.TextColor
        z1.ForeColor = My.Settings.TextColor
        x2.ForeColor = My.Settings.TextColor
        y2.ForeColor = My.Settings.TextColor
        z2.ForeColor = My.Settings.TextColor
        x3.ForeColor = My.Settings.TextColor
        y3.ForeColor = My.Settings.TextColor
        z3.ForeColor = My.Settings.TextColor
        Label11.ForeColor = My.Settings.TextColor
        Me.ForeColor = My.Settings.TextColor
        Me.BackColor = My.Settings.BackgroundColor
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Dim choosenStartup As String = System.Configuration.ConfigurationManager.AppSettings("Startup")
        If choosenStartup = "Normal" Then
            Me.WindowState = FormWindowState.Normal
        ElseIf choosenStartup = "Maximized" Then
            Me.WindowState = FormWindowState.Maximized
        End If
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If linguaSelezionata = "English" Then
            Label11.Text = "Linear Equations with three unknowns"
            CalculatorToolStripMenuItem.Text = "Calculator"
            If FastMenu.Visible = True Then
                FastMenuToolStripMenuItem.Text = "Fast Menu (Close)"
            Else
                FastMenuToolStripMenuItem.Text = "Fast Menu"
            End If
            AboutToolStripMenuItem.Text = "About"
            SettingsToolStripMenuItem.Text = "Settings"
            EquationsToolStripMenuItem.Text = "Equations"
            FormulasToolStripMenuItem.Text = "Formulas"
            Button1.Text = "CALCULATE"
            Button2.Text = "CLEAR"
            Button4.Text = "MORE DETAILS"
        ElseIf linguaSelezionata = "Italian" Then
            Label11.Text = "Equazioni lineari con tre incognite"
            CalculatorToolStripMenuItem.Text = "Calcolatrici"
            FastMenuToolStripMenuItem.Text = "Menu Veloce"
            AboutToolStripMenuItem.Text = "Informazioni su"
            SettingsToolStripMenuItem.Text = "Impostazioni"
            EquationsToolStripMenuItem.Text = "Equazioni"
            FormulasToolStripMenuItem.Text = "Formule"
            Button1.Text = "CALCOLA"
            Button2.Text = "PULISCI"
            Button4.Text = "ULT. RISULT."
        End If
    End Sub

    Private Sub ProgrammerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerToolStripMenuItem.Click
        Me.Close()
        Programmer.Show()
    End Sub

    Private Sub FastMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastMenuToolStripMenuItem.Click
        FastMenu.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settingsc.Show()
    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Environment.Exit(0)
    End Sub
End Class