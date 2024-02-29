Imports System.Windows.Controls

Public Class GeometryC
    Public MoveForm As Boolean
    Public MoveForm_MousePosition As Point
    Dim m, f
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MaximumSize = Screen.FromRectangle(Me.Bounds).WorkingArea.Size
        ComboBox1.Items.AddRange({"Quadrato", "Rettangolo", "Triangolo", "Cerchio"})
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'Mostra i controlli necessari per l'input a seconda dell'area selezionata
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Rettangolo"
                Label3.Text = "Base:"
                Label2.Text = "Altezza:"
                TextBox2.Visible = True
                Exit Select
            Case "Quadrato"
                Label2.Text = "Lato:"
                TextBox2.Visible = True
                Exit Select
            Case "Triangolo"
                Label2.Text = "Altezza:"
                Label3.Text = "Base:"
                TextBox2.Visible = True
                Exit Select
            Case "Cerchio"
                Label2.Text = "Raggio:"
                TextBox2.Visible = False
                Exit Select
        End Select
        TextBox1.Clear()
        TextBox2.Clear()
        Label3.Text = ""
    End Sub

    Private Sub Closea_Click(sender As Object, e As EventArgs) Handles Closea.Click
        Application.Exit()
    End Sub

    Private Sub Minimizea_Click(sender As Object, e As EventArgs) Handles Minimizea.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Calcola l'area in base all'input e alla figura geometrica selezionata
        Dim area As Double
        Select Case ComboBox1.SelectedItem.ToString()
            Case "Quadrato"
                Dim lato As Double = Double.Parse(TextBox1.Text)
                area = lato * lato
                Exit Select
            Case "Rettangolo"
                Dim base As Double = Double.Parse(TextBox1.Text)
                Dim altezza As Double = Double.Parse(TextBox2.Text)
                area = base * altezza
                Exit Select
            Case "Triangolo"
                Dim base As Double = Double.Parse(TextBox1.Text)
                Dim altezza As Double = Double.Parse(TextBox2.Text)
                area = (base * altezza) / 2
                Exit Select
            Case "Cerchio"
                Dim raggio As Double = Double.Parse(TextBox1.Text)
                area = Math.PI * raggio * raggio
                Exit Select
        End Select
        Label3.Text = "Area: " & area.ToString()
    End Sub

End Class
