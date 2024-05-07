Imports System.Configuration
Imports System.Drawing

Public Class Settingsc
    Private BackgroundColor As Color
    Private TextColor As Color

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        DisplayLanguageSettings()
    End Sub

    Private Sub DisplayLanguageSettings()
        Panel1.Controls.Clear() ' Rimuove i controlli esistenti da Panel1
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        ' Aggiunge i controlli per la selezione della lingua
        Dim lblLingua As New Label()
        If linguaSelezionata = "English" Then
            lblLingua.Text = "Language:"
        ElseIf linguaSelezionata = "Italian" Then
            lblLingua.Text = "Lingua:"
        End If

        lblLingua.Top = 10
        lblLingua.Left = 10
        Panel1.Controls.Add(lblLingua)

        Dim cbLingua As New ComboBox()
        cbLingua.Items.Add("Italian")
        cbLingua.Items.Add("English")
        cbLingua.Top = 10
        cbLingua.Left = lblLingua.Right + 10
        Panel1.Controls.Add(cbLingua)

        Dim btnSalva As New Button()
        btnSalva.Text = "Apply"
        btnSalva.Top = cbLingua.Bottom + 10
        btnSalva.Left = 10
        AddHandler btnSalva.Click, AddressOf SalvaImpostazioniLingua
        Panel1.Controls.Add(btnSalva)
    End Sub

    Private Sub SalvaImpostazioniLingua(sender As Object, e As EventArgs)
        Dim cbLingua As ComboBox = Panel1.Controls.OfType(Of ComboBox)().FirstOrDefault()
        If cbLingua IsNot Nothing Then
            Dim linguaSelezionata As String = cbLingua.SelectedItem.ToString()

            ' Salva le impostazioni della lingua
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            If config.AppSettings.Settings("Lingua") IsNot Nothing Then
                config.AppSettings.Settings("Lingua").Value = linguaSelezionata
            Else
                config.AppSettings.Settings.Add("Lingua", linguaSelezionata)
            End If
            config.Save(ConfigurationSaveMode.Modified)

            ' Applica le impostazioni della lingua al form
            If linguaSelezionata = "Italian" Then
                Label1.Text = "Lingua"
                Label2.Text = "Avvio"
                Me.Text = "Impostazioni"
            ElseIf linguaSelezionata = "English" Then
                Label1.Text = "Language"
                Label2.Text = "Startup"
                Me.Text = "Settings"
            End If
        End If
        MsgBox("Il programma deve essere riavviato per applicare la lingua scelta.")
        Application.Restart()
        Me.Show()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        DisplayStartupSettings()
    End Sub

    Private Sub DisplayStartupSettings()
        Panel1.Controls.Clear() ' Rimuove i controlli esistenti da Panel1

        ' Aggiunge i controlli per le impostazioni di avvio
        Dim lblAvvio As New Label()
        lblAvvio.Text = "Startup:"
        lblAvvio.Top = 10
        lblAvvio.Left = 10
        Panel1.Controls.Add(lblAvvio)

        Dim cbAvvio As New ComboBox()
        cbAvvio.Items.Add("Normal")
        cbAvvio.Items.Add("Maximized")
        cbAvvio.Top = 10
        cbAvvio.Left = lblAvvio.Right + 10
        Panel1.Controls.Add(cbAvvio)

        Dim btnSalva As New Button()
        btnSalva.Text = "Apply"
        btnSalva.Top = cbAvvio.Bottom + 10
        btnSalva.Left = 10
        AddHandler btnSalva.Click, AddressOf SalvaImpostazioniAvvio
        Panel1.Controls.Add(btnSalva)
    End Sub

    Private Sub SalvaImpostazioniAvvio(sender As Object, e As EventArgs)
        Dim cbLStart As ComboBox = Panel1.Controls.OfType(Of ComboBox)().FirstOrDefault()
        If cbLStart IsNot Nothing Then
            Dim choosenStartup As String = cbLStart.SelectedItem.ToString()

            ' Salva le impostazioni di avvio
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            If config.AppSettings.Settings("Startup") IsNot Nothing Then
                config.AppSettings.Settings("Startup").Value = choosenStartup
            Else
                config.AppSettings.Settings.Add("Startup", choosenStartup)
            End If
            config.Save(ConfigurationSaveMode.Modified)
        End If
        MsgBox("Il programma deve essere riavviato per applicare il tipo di avvio di Windows scelto.")
        Application.Restart()
        Me.Show()
    End Sub

    Private picBackColorIndicator As PictureBox ' PictureBox per il colore di sfondo
    Private picTextColorIndicator As PictureBox ' PictureBox per il colore del testo

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Panel1.Controls.Clear()

        ' Aggiunge il pulsante per selezionare il colore di sfondo
        Dim btnSelectBackColor As New Button()
        btnSelectBackColor.Text = "Background Color"
        btnSelectBackColor.Top = 10
        btnSelectBackColor.Left = 10
        btnSelectBackColor.Width = 150
        AddHandler btnSelectBackColor.Click, AddressOf SelectBackgroundColor
        Panel1.Controls.Add(btnSelectBackColor)

        ' Aggiunge il quadratino per visualizzare il colore di sfondo selezionato
        picBackColorIndicator = New PictureBox()
        picBackColorIndicator.Top = 10
        picBackColorIndicator.Left = btnSelectBackColor.Right + 10
        picBackColorIndicator.Width = 20
        picBackColorIndicator.Height = 20
        picBackColorIndicator.BorderStyle = BorderStyle.FixedSingle
        picBackColorIndicator.BackColor = My.Settings.BackgroundColor ' Imposta il colore salvato
        Panel1.Controls.Add(picBackColorIndicator)

        ' Aggiunge il pulsante per selezionare il colore del testo
        Dim btnSelectTextColor As New Button()
        btnSelectTextColor.Text = "Text Color"
        btnSelectTextColor.Top = btnSelectBackColor.Bottom + 10
        btnSelectTextColor.Left = 10
        btnSelectTextColor.Width = 150
        AddHandler btnSelectTextColor.Click, AddressOf SelectTextColor
        Panel1.Controls.Add(btnSelectTextColor)

        ' Aggiunge il quadratino per visualizzare il colore del testo selezionato
        picTextColorIndicator = New PictureBox()
        picTextColorIndicator.Top = btnSelectTextColor.Top
        picTextColorIndicator.Left = btnSelectTextColor.Right + 10
        picTextColorIndicator.Width = 20
        picTextColorIndicator.Height = 20
        picTextColorIndicator.BorderStyle = BorderStyle.FixedSingle
        picTextColorIndicator.BackColor = My.Settings.TextColor ' Imposta il colore salvato
        Panel1.Controls.Add(picTextColorIndicator)

        ' Aggiunge il pulsante per applicare il tema
        Dim btnApplyTheme As New Button()
        btnApplyTheme.Text = "Apply Theme"
        btnApplyTheme.Top = btnSelectTextColor.Bottom + 10
        btnApplyTheme.Left = 10
        btnApplyTheme.Width = 150
        AddHandler btnApplyTheme.Click, AddressOf ApplySettingsToAllForms
        Panel1.Controls.Add(btnApplyTheme)

        ' Aggiunge il pulsante per ripristinare il tema predefinito
        Dim btnResetTheme As New Button()
        btnResetTheme.Text = "Reset Default Theme"
        btnResetTheme.Top = btnApplyTheme.Bottom + 10
        btnResetTheme.Left = 10
        btnResetTheme.Width = 150
        AddHandler btnResetTheme.Click, AddressOf ResetDefaultTheme
        Panel1.Controls.Add(btnResetTheme)
    End Sub

    Private Sub SelectBackgroundColor(sender As Object, e As EventArgs)
        Dim colorDialog As New ColorDialog()
        If colorDialog.ShowDialog() = DialogResult.OK Then
            BackgroundColor = colorDialog.Color
            picBackColorIndicator.BackColor = BackgroundColor ' Aggiorna il colore del quadratino
            My.Settings.BackgroundColor = BackgroundColor
            My.Settings.Save()
        End If
    End Sub

    Private Sub SelectTextColor(sender As Object, e As EventArgs)
        Dim colorDialog As New ColorDialog()
        If colorDialog.ShowDialog() = DialogResult.OK Then
            TextColor = colorDialog.Color
            picTextColorIndicator.BackColor = TextColor ' Aggiorna il colore del quadratino
            My.Settings.TextColor = TextColor
            My.Settings.Save()
        End If
    End Sub

    Private Sub ApplySettingsToAllForms()
        ' Ottiene il percorso del file di configurazione dell'applicazione
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If BackgroundColor = TextColor Then
            If linguaSelezionata = "English" Then
                MsgBox("Background color and text color cannot be the same.")
            ElseIf linguaSelezionata = "Italian" Then
                MsgBox("Il colore di sfondo e il colore del testo non possono essere uguali.")
            End If
            Return
        End If

        Dim configFile As String = AppDomain.CurrentDomain.SetupInformation.ConfigurationFile

        ' Crea una nuova istanza di Configuration
        Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(configFile)

        ' Salva i colori di sfondo e di testo come impostazioni nel file di configurazione
        If config.AppSettings.Settings("BackgroundColor") IsNot Nothing Then
            config.AppSettings.Settings("BackgroundColor").Value = BackgroundColor.ToArgb().ToString()
        Else
            config.AppSettings.Settings.Add("BackgroundColor", BackgroundColor.ToArgb().ToString())
        End If

        If config.AppSettings.Settings("TextColor") IsNot Nothing Then
            config.AppSettings.Settings("TextColor").Value = TextColor.ToArgb().ToString()
        Else
            config.AppSettings.Settings.Add("TextColor", TextColor.ToArgb().ToString())
        End If

        ' Salva le modifiche apportate al file di configurazione
        config.Save(ConfigurationSaveMode.Modified)

        ' Applica le impostazioni del tema a tutti i form aperti
        For Each form As Form In Application.OpenForms
            If TypeOf form Is Settingsc Then ' Ignora il form delle impostazioni stesse
                Continue For
            End If

            ' Applica i colori di sfondo e del testo
            form.BackColor = BackgroundColor
            form.ForeColor = TextColor
        Next

        If linguaSelezionata = "English" Then
            MsgBox("Theme settings are saved with success.")
        ElseIf linguaSelezionata = "Italian" Then
            MsgBox("L'impostazione del tema è stato salvato con successo.")
        End If
        Application.Restart()
    End Sub

    Private Sub ResetDefaultTheme(sender As Object, e As EventArgs)
        ' Imposta il colore di sfondo predefinito (nero) e il colore del testo predefinito (bianco)
        BackgroundColor = Color.Black
        TextColor = Color.White

        ' Salva i colori predefiniti nelle impostazioni
        My.Settings.BackgroundColor = BackgroundColor
        My.Settings.TextColor = TextColor
        My.Settings.Save()

        ' Applica il tema a tutti i form aperti
        For Each form As Form In Application.OpenForms
            If TypeOf form Is Settingsc Then ' Ignora il form delle impostazioni stesse
                Continue For
            End If

            ' Applica i colori di sfondo e del testo predefiniti
            form.BackColor = BackgroundColor
            form.ForeColor = TextColor
        Next

        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If linguaSelezionata = "English" Then
            MsgBox("Default theme has been reset.")
        ElseIf linguaSelezionata = "Italian" Then
            MsgBox("Il tema predefinito è stato ripristinato.")
        End If
        Application.Restart()
    End Sub

    Private Sub Settingsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carica le impostazioni salvate quando il form viene caricato
        My.Settings.Reload()

        ' Applica le impostazioni della lingua
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If linguaSelezionata = "English" Then
            Label1.Text = "Language"
            Label2.Text = "Startup"
            Label3.Text = "Themes"
            Me.Text = "Settings"
        ElseIf linguaSelezionata = "Italian" Then
            Label1.Text = "Lingua"
            Label2.Text = "Avvio"
            Label3.Text = "Tema"
            Me.Text = "Impostazioni"
        End If
    End Sub

End Class
