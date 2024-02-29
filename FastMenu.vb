Public Class FastMenu

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Circumference.Close()
        FloatingPoint1.Close()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Close()
        Linearequations.Close()
        LinEquationTriple.Close()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Math_Graphics.Close()
        Normal.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Circumference.Close()
        FloatingPoint1.Close()
        Math_Graphics.Close()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Show()
        Inequalities.Close()
        Linearequations.Close()
        LinEquationTriple.Close()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Circumference.Close()
        FloatingPoint1.Close()
        Math_Graphics.Close()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Close()
        Linearequations.Show()
        LinEquationTriple.Close()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Circumference.Close()
        FloatingPoint1.Close()
        Math_Graphics.Close()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Close()
        Linearequations.Close()
        LinEquationTriple.Show()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Circumference.Close()
        FloatingPoint1.Close()
        Math_Graphics.Close()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Show()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Close()
        Linearequations.Close()
        LinEquationTriple.Close()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Circumference.Close()
        FloatingPoint1.Close()
        Math_Graphics.Close()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Close()
        Linearequations.Close()
        LinEquationTriple.Close()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Show()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Circumference.Close()
        FloatingPoint1.Close()
        Math_Graphics.Close()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Show()
        Linearequations.Close()
        LinEquationTriple.Close()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Circumference.Close()
        FloatingPoint1.Close()
        Math_Graphics.Close()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Close()
        Linearequations.Close()
        LinEquationTriple.Close()
        Programmer.Show()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Circumference.Close()
        FloatingPoint1.Close()
        Math_Graphics.Close()
        BinaryOp.Show()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Close()
        Linearequations.Close()
        LinEquationTriple.Close()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub FastMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()
        ' Imposta la lingua iniziale
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If linguaSelezionata = "English" Then
            Label1.Text = "CALCULATOR TYPE"
            Label6.Text = "Always on top"
            Button2.Text = "STANDARD CALCULATOR"
            Button10.Text = "FORCE THE EXIT"
            Label3.Text = "Scientific"
            Button1.Text = "SCIENTIFIC CALCULATOR"
            Button13.Text = "GRAPHICS"
            Label7.Text = "Equations and Inequalities"
            Label9.Text = "Linear Equations"
            Button3.Text = "DUO"
            Button4.Text = "TRIPLE"
            Label8.Text = "Degreed Equations"
            Button6.Text = "FIRST"
            Button5.Text = "SECOND"
            Label4.Text = "Inequalties"
            Button7.Text = "SECOND"
            Label5.Text = "Progammer / Engineering"
            Button8.Text = "NUMBER SYSTEM"
            Button9.Text = "BINARY OP."
        ElseIf linguaSelezionata = "Italian" Then
            Label1.Text = "TIPOLOGIA DI CALCOLATORI"
            Label6.Text = "In primo piano"
            Button2.Text = "CALCOLATRICE STANDARD"
            Button10.Text = "FORZA L'USCITA"
            Label3.Text = "Scientifica"
            Button1.Text = "CALCOLATRICE SCIENTIFICA"
            Button13.Text = "GRAFICI"
            Label7.Text = "Equazioni e Disequazioni"
            Label9.Text = "Equazioni Lineari"
            Button3.Text = "DOPPIA"
            Button4.Text = "TRIPLA"
            Label8.Text = "Equazioni di grado"
            Button6.Text = "PRIMO"
            Button5.Text = "SECONDO"
            Label4.Text = "Disequazioni"
            Button7.Text = "SECONDO"
            Label5.Text = "Progammazione / Ingegneria"
            Button8.Text = "SISTEMI NUMERICI"
            Button9.Text = "OP. BINARI"
        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Application.Exit()
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Me.TopMost = True
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Me.TopMost = False
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Circumference.Close()
        FloatingPoint1.Close()
        Math_Graphics.Show()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Close()
        Linearequations.Close()
        LinEquationTriple.Close()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Circumference.Close()
        FloatingPoint1.Show()
        Math_Graphics.Close()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Close()
        Linearequations.Close()
        LinEquationTriple.Close()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click

    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Circumference.Show()
        FloatingPoint1.Close()
        Math_Graphics.Close()
        BinaryOp.Close()
        DEmore.Close()
        Formulas.Close()
        fstequ.Close()
        FunctionConverter.Close()
        Geometry.Close()
        Scientific.Close()
        Inequalities.Close()
        Linearequations.Close()
        LinEquationTriple.Close()
        Programmer.Close()
        rInequalities.Close()
        SimpleAlgebra.Close()
        sndequ.Close()
        TEmore.Close()
        Normal.Hide()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        GeometryC.Show()
    End Sub
End Class