Public Class BinaryOp
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
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
    Private Sub ProgrammerActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProgrammerActualToolStripMenuItem.Click
        Me.Close()
        Programmer.Show()
    End Sub

    Private Sub ScientificToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ScientificToolStripMenuItem.Click
        Me.Close()
        Scientific.Show()
    End Sub

    Private Sub NormalActualToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NormalActualToolStripMenuItem.Click
        Me.Close()
        Normal.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub Butt0_Click(sender As Object, e As EventArgs)
        TextBox1.Text = TextBox1.Text & "0"
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs)
        TextBox2.Text = TextBox2.Text & "0"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        TextBox2.Text = TextBox2.Text & "1"
    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ButtCalc_Click(sender As Object, e As EventArgs) Handles ButtCalc.Click
        Dim a, b As Double
        If TextBox1.Text = "" Then 'IF INPUT (TEXTBOXs) ARE "" THEN CONVERT IN 0 OTHERWHISE YOU'LL GET ERRORS
            TextBox1.Text = 0
        End If
        If TextBox2.Text = "" Then
            TextBox2.Text = 0
        End If
        If (op.Text = "+") Then
            a = Val(TextBox1.Text)
            b = Val(TextBox2.Text)
            TextBox3.Text = a + b
            Label7.Text = "+"
        End If
        If (op.Text = "-") Then
            a = Val(TextBox1.Text)
            b = Val(TextBox2.Text)
            TextBox3.Text = a - b
            Label7.Text = "-"
        End If
        If (op.Text = "*") Then
            a = Val(TextBox1.Text)
            b = Val(TextBox2.Text)
            TextBox3.Text = a * b
            Label7.Text = "*"
        End If
        If (op.Text = "/") Then
            a = Val(TextBox1.Text)
            b = Val(TextBox2.Text)
            TextBox3.Text = a / b
            Label7.Text = "/"
        End If
        'BINARY OUTPUTS ARE EQUAL TO VB.NET's from Decimal to Binary converter
        TextBox1BIN.Text = Convert.ToString(Convert.ToInt32(TextBox1.Text, 10), 2)
        TextBox2BIN.Text = Convert.ToString(Convert.ToInt32(TextBox2.Text, 10), 2)
        TextBox3BIN.Text = Convert.ToString(Convert.ToInt32(TextBox3.Text, 10), 2)
    End Sub

    Private Sub BinaryAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If linguaSelezionata = "English" Then
            Label1.Text = "Binary numbers operations (input by decimal number)"
            CalculatorToolStripMenuItem.Text = "Calculator"
            If FastMenu.Visible = True Then
                FastMenuToolStripMenuItem.Text = "Fast Menu (Close)"
            Else
                FastMenuToolStripMenuItem.Text = "Fast Menu"
            End If
            AboutToolStripMenuItem.Text = "About"
            SettingsToolStripMenuItem.Text = "Settings"
        ElseIf linguaSelezionata = "Italian" Then
            Label1.Text = "Operazioni con numeri binari (input numero decimale)"
            CalculatorToolStripMenuItem.Text = "Calcolatrici"
            FastMenuToolStripMenuItem.Text = "Menu Veloce"
            AboutToolStripMenuItem.Text = "Informazioni su"
            SettingsToolStripMenuItem.Text = "Impostazioni"
        End If
        Dim choosenStartup As String = System.Configuration.ConfigurationManager.AppSettings("Startup")
        If choosenStartup = "Normal" Then
            Me.WindowState = FormWindowState.Normal
        ElseIf choosenStartup = "Maximized" Then
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub ButtonBackspace_Click(sender As Object, e As EventArgs)
        If TextBox1.Text < " " Then
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1 + 1)
        Else
            TextBox1.Text = Mid(TextBox1.Text, 1, Len(TextBox1.Text) - 1)
        End If
    End Sub

    Private Sub Resetr_Click(sender As Object, e As EventArgs) Handles Resetr.Click
        Label7.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox1BIN.Text = ""
        TextBox2BIN.Text = ""
        TextBox3BIN.Text = ""
    End Sub

    Private Sub copies_Click(sender As Object, e As EventArgs) Handles copies.Click
        My.Computer.Clipboard.SetText("(" & TextBox1BIN.Text & ")2" & "+" & "(" & TextBox2BIN.Text & ")2 = " & TextBox3BIN.Text)
        MsgBox("Copied with success!")
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

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settingsc.Show()
    End Sub
End Class