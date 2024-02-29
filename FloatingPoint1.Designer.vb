<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FloatingPoint1
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Richiesto da Progettazione Windows Form
    Private components As System.ComponentModel.IContainer

    'NOTA: la procedura che segue è richiesta da Progettazione Windows Form
    'Può essere modificata in Progettazione Windows Form.  
    'Non modificarla mediante l'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FloatingPoint1))
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.txtDecimal = New System.Windows.Forms.TextBox()
        Me.txtBinary32 = New System.Windows.Forms.TextBox()
        Me.txtBinary64 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtHex32 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProgrammerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinaryAdditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConvert
        '
        Me.btnConvert.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btnConvert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnConvert.Location = New System.Drawing.Point(269, 229)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(106, 31)
        Me.btnConvert.TabIndex = 0
        Me.btnConvert.Text = "Calculate"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'txtDecimal
        '
        Me.txtDecimal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtDecimal.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtDecimal.ForeColor = System.Drawing.SystemColors.Control
        Me.txtDecimal.Location = New System.Drawing.Point(79, 68)
        Me.txtDecimal.Name = "txtDecimal"
        Me.txtDecimal.Size = New System.Drawing.Size(588, 22)
        Me.txtDecimal.TabIndex = 1
        '
        'txtBinary32
        '
        Me.txtBinary32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBinary32.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtBinary32.ForeColor = System.Drawing.SystemColors.Control
        Me.txtBinary32.Location = New System.Drawing.Point(79, 107)
        Me.txtBinary32.Name = "txtBinary32"
        Me.txtBinary32.Size = New System.Drawing.Size(588, 22)
        Me.txtBinary32.TabIndex = 2
        '
        'txtBinary64
        '
        Me.txtBinary64.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtBinary64.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtBinary64.ForeColor = System.Drawing.SystemColors.Control
        Me.txtBinary64.Location = New System.Drawing.Point(79, 186)
        Me.txtBinary64.Name = "txtBinary64"
        Me.txtBinary64.Size = New System.Drawing.Size(588, 22)
        Me.txtBinary64.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(695, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Decimal"
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(695, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Mantissa (32 bit)"
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(695, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Mantissa (64 bit)"
        '
        'txtHex32
        '
        Me.txtHex32.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtHex32.BackColor = System.Drawing.SystemColors.ControlText
        Me.txtHex32.ForeColor = System.Drawing.SystemColors.Control
        Me.txtHex32.Location = New System.Drawing.Point(79, 144)
        Me.txtHex32.Name = "txtHex32"
        Me.txtHex32.Size = New System.Drawing.Size(588, 22)
        Me.txtHex32.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(695, 144)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 16)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Hexadecimal (32 bit)"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(416, 229)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(106, 31)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Clear"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.ControlText
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.FastMenuToolStripMenuItem, Me.AboutToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(9, 9)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(477, 28)
        Me.MenuStrip1.TabIndex = 21
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalActualToolStripMenuItem, Me.ScientificToolStripMenuItem, Me.ProgrammerToolStripMenuItem})
        Me.CalculatorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NormalActualToolStripMenuItem
        '
        Me.NormalActualToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.NormalActualToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.NormalActualToolStripMenuItem.Name = "NormalActualToolStripMenuItem"
        Me.NormalActualToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.NormalActualToolStripMenuItem.Text = "Standard"
        '
        'ScientificToolStripMenuItem
        '
        Me.ScientificToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ScientificToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ScientificToolStripMenuItem.Name = "ScientificToolStripMenuItem"
        Me.ScientificToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.ScientificToolStripMenuItem.Text = "Scientific"
        '
        'ProgrammerToolStripMenuItem
        '
        Me.ProgrammerToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ProgrammerToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BinaryAdditionToolStripMenuItem})
        Me.ProgrammerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ProgrammerToolStripMenuItem.Name = "ProgrammerToolStripMenuItem"
        Me.ProgrammerToolStripMenuItem.Size = New System.Drawing.Size(175, 26)
        Me.ProgrammerToolStripMenuItem.Text = "Programmer"
        '
        'BinaryAdditionToolStripMenuItem
        '
        Me.BinaryAdditionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.BinaryAdditionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.BinaryAdditionToolStripMenuItem.Name = "BinaryAdditionToolStripMenuItem"
        Me.BinaryAdditionToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.BinaryAdditionToolStripMenuItem.Text = "Binary Addition"
        '
        'FastMenuToolStripMenuItem
        '
        Me.FastMenuToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.FastMenuToolStripMenuItem.Name = "FastMenuToolStripMenuItem"
        Me.FastMenuToolStripMenuItem.Size = New System.Drawing.Size(89, 24)
        Me.FastMenuToolStripMenuItem.Text = "Fast Menu"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(64, 24)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'FloatingPoint1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(829, 433)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtHex32)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBinary64)
        Me.Controls.Add(Me.txtBinary32)
        Me.Controls.Add(Me.txtDecimal)
        Me.Controls.Add(Me.btnConvert)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FloatingPoint1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BetaCloud Calculator (IEEE P754)"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConvert As Button
    Friend WithEvents txtDecimal As TextBox
    Friend WithEvents txtBinary32 As TextBox
    Friend WithEvents txtBinary64 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtHex32 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProgrammerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BinaryAdditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
End Class
