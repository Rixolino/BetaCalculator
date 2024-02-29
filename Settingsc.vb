Imports System.Configuration

Public Class Settingsc

    Public Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        'Visualizza le impostazioni di lingua nel Panel1
        Panel1.Controls.Clear() 'Rimuovi eventuali controlli presenti nel Panel1
        Dim lblLingua As New Label()
        lblLingua.Text = "Language:"
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

    Public Sub SalvaImpostazioniLingua(sender As Object, e As EventArgs)
        'Salva le impostazioni di lingua
        Dim cbLingua As ComboBox = Panel1.Controls.OfType(Of ComboBox)().FirstOrDefault()
        If cbLingua IsNot Nothing Then
            Dim linguaSelezionata As String = cbLingua.SelectedItem.ToString()

            'Aggiorna il valore della chiave "Lingua" nel file di configurazione
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            If config.AppSettings.Settings("Lingua") IsNot Nothing Then
                config.AppSettings.Settings("Lingua").Value = linguaSelezionata
            Else
                config.AppSettings.Settings.Add("Lingua", linguaSelezionata)
            End If
            config.Save(ConfigurationSaveMode.Modified)

            'Aggiorna il valore della lingua nella form
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
        MsgBox("The program needs to be restarted to apply the language of your choice.")
        Application.Restart()
        Me.Show()
    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        ' Visualizza le impostazioni di avvio nel Panel1
        Panel1.Controls.Clear() ' Rimuovi eventuali controlli presenti nel Panel1
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
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        Dim cbLStart As ComboBox = Panel1.Controls.OfType(Of ComboBox)().FirstOrDefault()
        If cbLStart IsNot Nothing Then
            Dim choosenStartup As String = cbLStart.SelectedItem.ToString()

            'Aggiorna il valore della chiave "Lingua" nel file di configurazione
            Dim config As Configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)
            If config.AppSettings.Settings("Startup") IsNot Nothing Then
                config.AppSettings.Settings("Startup").Value = choosenStartup

            Else
                config.AppSettings.Settings.Add("Startup", choosenStartup)

            End If
            config.Save(ConfigurationSaveMode.Modified)
        End If
        MsgBox("The program needs to be restarted to apply the type of windows startup of your choice.")
        Application.Restart()
        Me.Show()
    End Sub

    Private Sub Settingsc_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Carica tutte le impostazioni salvate
        My.Settings.Reload()
        ' Imposta la lingua iniziale
        Dim linguaSelezionata As String = System.Configuration.ConfigurationManager.AppSettings("Lingua")
        If linguaSelezionata = "English" Then
            Label1.Text = "Language"
            Label2.Text = "Startup"
            Me.Text = "Settings"
        ElseIf linguaSelezionata = "Italian" Then
            Label1.Text = "Lingua"
            Label2.Text = "Avvio"
            Me.Text = "Impostazioni"
        End If
    End Sub
End Class