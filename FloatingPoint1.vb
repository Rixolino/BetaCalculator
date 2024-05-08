Imports System.Text

Public Class FloatingPoint1

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click

        Dim decimalNumber As Double = Double.Parse(txtDecimal.Text.Replace(".", ","))

        Dim binary32 As String = DecimalToBinary32(decimalNumber)
        Dim binary64 As String = DecimalToBinary64(decimalNumber)

        Dim binary32Formatted As String = FormatBinary32(binary32)

        txtBinary32.Text = binary32Formatted
        txtBinary64.Text = binary64
        txtDecimal.Text = txtDecimal.Text.Replace(".", ",")

        Dim hex32 As String = BinaryToHex(binary32)
        txtHex32.Text = hex32
    End Sub

    Private Function DecimalToBinary32(decimalNumber As Double) As String
        Dim sign As Integer = If(decimalNumber >= 0, 0, 1)
        Dim absoluteValue As Double = Math.Abs(decimalNumber)

        Dim exponent As Integer = 0
        Dim fraction As Double = 0

        If absoluteValue > 0 Then
            exponent = Math.Floor(Math.Log(absoluteValue, 2)) + 127
            fraction = absoluteValue / Math.Pow(2, exponent - 127) - 1
        End If

        Dim exponentBinary As String = Convert.ToString(exponent, 2).PadLeft(8, "0"c)
        Dim fractionBinary As String = ConvertFractionToBinary(fraction, 23)

        Return sign & exponentBinary & fractionBinary
    End Function

    Private Function BinaryToHex(binary As String) As String
        Dim hex As String = ""

        For i As Integer = 0 To binary.Length - 1 Step 4
            Dim nibble As String = binary.Substring(i, 4)
            hex &= Convert.ToInt32(nibble, 2).ToString("X"c)
        Next

        Return hex
    End Function

    Private Function DecimalToBinary64(decimalNumber As Double) As String
        Dim sign As Integer = If(decimalNumber >= 0, 0, 1)
        Dim absoluteValue As Double = Math.Abs(decimalNumber)

        Dim exponent As Integer = 0
        Dim fraction As Double = 0

        If absoluteValue > 0 Then
            exponent = Math.Floor(Math.Log(absoluteValue, 2)) + 1023
            fraction = absoluteValue / Math.Pow(2, exponent - 1023) - 1
        End If

        Dim exponentBinary As String = Convert.ToString(exponent, 2).PadLeft(11, "0"c)
        Dim fractionBinary As String = ConvertFractionToBinary(fraction, 52)

        Return sign & " " & exponentBinary & " " & fractionBinary
    End Function

    Private Function ConvertFractionToBinary(fraction As Double, bits As Integer) As String
        Dim result As New StringBuilder()

        For i As Integer = 1 To bits
            fraction *= 2

            If fraction >= 1 Then
                result.Append("1"c)
                fraction -= 1
            Else
                result.Append("0"c)
            End If
        Next

        Return result.ToString()
    End Function

    Private Function FormatBinary32(binary32 As String) As String
        Dim sign As String = binary32(0)
        Dim exponent As String = binary32.Substring(1, 8)
        Dim mantissa As String = binary32.Substring(9)

        Return sign & " " & exponent & " " & mantissa
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        txtBinary32.Text = ""
        txtBinary64.Text = ""
        txtDecimal.Text = ""
        txtHex32.Text = ""
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

    Private Sub FloatingPoint1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Settings.Reload()

        ApplyMenuColors(MenuStrip1)

        Me.ForeColor = My.Settings.TextColor
        Me.BackColor = My.Settings.BackgroundColor
        ' Imposta la lingua iniziale
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If linguaSelezionata = "English" Then
            Label1.Text = "Decimal"
            Label3.Text = "Hexadecimal (32 bit)"
            CalculatorToolStripMenuItem.Text = "Calculator"
            If FastMenu.Visible = True Then
                FastMenuToolStripMenuItem.Text = "Fast Menu (Close)"
            Else
                FastMenuToolStripMenuItem.Text = "Fast Menu"
            End If
            AboutToolStripMenuItem.Text = "About"
            SettingsToolStripMenuItem.Text = "Settings"
        ElseIf linguaSelezionata = "Italian" Then
            Label1.Text = "Decimale"
            Label3.Text = "Esadecimale (32 bit)"
            CalculatorToolStripMenuItem.Text = "Calcolatrici"
            FastMenuToolStripMenuItem.Text = "Menu Veloce"
            AboutToolStripMenuItem.Text = "Informazioni su"
            SettingsToolStripMenuItem.Text = "Impostazioni"
        End If
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

    Private Sub FastMenuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FastMenuToolStripMenuItem.Click
        FastMenu.Show()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Settingsc.Show()
    End Sub
End Class

