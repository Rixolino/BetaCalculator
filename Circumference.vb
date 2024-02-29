Public Class Circumference
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Public Sub Perf(ByRef f As Size)

    End Sub
    Public Sub New()
        InitializeComponent()

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
    Private Sub ConvertEquationToCanonicalForm(ByVal a As Double, ByVal b As Double, ByVal r As Double)
        Dim c As Double = a ^ 2 + b ^ 2 - r ^ 2
        Dim canonicalForm As String = ""

        If c > 0 Then
            canonicalForm = String.Format("(x - {0:F2})^2 + (y - {1:F2})^2 = {2:F2}^2 + {3:F2}^2", a, b, r, Math.Sqrt(c))
        ElseIf c < 0 Then
            canonicalForm = String.Format("(x - {0:F2})^2 + (y - {1:F2})^2 = {2:F2}^2 - {3:F2}^2", a, b, r, Math.Sqrt(Math.Abs(c)))
        Else
            canonicalForm = String.Format("(x - {0:F2})^2 + (y - {1:F2})^2 = {2:F2}^2", a, b, r)
        End If

        'Visualizza la forma canonica nell'interfaccia grafica

    End Sub

    Private Sub Circumference_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        Dim choosenStartup As String = System.Configuration.ConfigurationManager.AppSettings("Startup")
        If choosenStartup = "Normal" Then
            Me.WindowState = FormWindowState.Normal
        ElseIf choosenStartup = "Maximized" Then
            Me.WindowState = FormWindowState.Maximized
        End If
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If linguaSelezionata = "English" Then
            Label1.Text = "Circumference"
            CalculatorToolStripMenuItem.Text = "Calculator"
            If FastMenu.Visible = True Then
                FastMenuToolStripMenuItem.Text = "Fast Menu (Close)"
            Else
                FastMenuToolStripMenuItem.Text = "Fast Menu"
            End If
            AboutToolStripMenuItem.Text = "About"
            SettingsToolStripMenuItem.Text = "Settings"

        ElseIf linguaSelezionata = "Italian" Then
            Label1.Text = "Circoferenza"
            CalculatorToolStripMenuItem.Text = "Calcolatrici"
            FastMenuToolStripMenuItem.Text = "Menu Veloce"
            AboutToolStripMenuItem.Text = "Informazioni su"
            SettingsToolStripMenuItem.Text = "Impostazioni"
        End If
    End Sub


    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settingsc.Show()
    End Sub
End Class