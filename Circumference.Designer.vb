<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Circumference
    Inherits System.Windows.Forms.Form

    'Form esegue l'override del metodo Dispose per pulire l'elenco dei componenti.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Minimizea = New System.Windows.Forms.Label()
        Me.Closea = New System.Windows.Forms.Label()
        Me.ERRProvider = New System.Windows.Forms.Label()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NormalToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ScientificActualToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnitOfMeasureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BinaryAdditionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FastMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(65, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 22)
        Me.Label1.TabIndex = 346
        Me.Label1.Text = "Circumference"
        '
        'Minimizea
        '
        Me.Minimizea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Minimizea.AutoSize = True
        Me.Minimizea.Font = New System.Drawing.Font("Microsoft YaHei UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Minimizea.Location = New System.Drawing.Point(1286, -5)
        Me.Minimizea.Name = "Minimizea"
        Me.Minimizea.Size = New System.Drawing.Size(30, 40)
        Me.Minimizea.TabIndex = 345
        Me.Minimizea.Text = "-"
        '
        'Closea
        '
        Me.Closea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Closea.AutoSize = True
        Me.Closea.Font = New System.Drawing.Font("Microsoft YaHei UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Closea.Location = New System.Drawing.Point(1317, -2)
        Me.Closea.Name = "Closea"
        Me.Closea.Size = New System.Drawing.Size(37, 37)
        Me.Closea.TabIndex = 344
        Me.Closea.Text = "X"
        '
        'ERRProvider
        '
        Me.ERRProvider.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.ERRProvider.AutoSize = True
        Me.ERRProvider.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ERRProvider.Location = New System.Drawing.Point(965, 30)
        Me.ERRProvider.Name = "ERRProvider"
        Me.ERRProvider.Size = New System.Drawing.Size(0, 22)
        Me.ERRProvider.TabIndex = 341
        '
        'MenuStrip2
        '
        Me.MenuStrip2.BackColor = System.Drawing.SystemColors.ControlText
        Me.MenuStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatorToolStripMenuItem, Me.FastMenuToolStripMenuItem, Me.AboutToolStripMenuItem, Me.SettingsToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(25, 38)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(477, 28)
        Me.MenuStrip2.TabIndex = 308
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NormalToolStripMenuItem, Me.ScientificActualToolStripMenuItem, Me.UnitOfMeasureToolStripMenuItem})
        Me.CalculatorToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(90, 24)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'NormalToolStripMenuItem
        '
        Me.NormalToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.NormalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.NormalToolStripMenuItem.Name = "NormalToolStripMenuItem"
        Me.NormalToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.NormalToolStripMenuItem.Text = "Standard"
        '
        'ScientificActualToolStripMenuItem
        '
        Me.ScientificActualToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.ScientificActualToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.ScientificActualToolStripMenuItem.Name = "ScientificActualToolStripMenuItem"
        Me.ScientificActualToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.ScientificActualToolStripMenuItem.Text = "Scientific (Actual)"
        '
        'UnitOfMeasureToolStripMenuItem
        '
        Me.UnitOfMeasureToolStripMenuItem.BackColor = System.Drawing.SystemColors.ControlText
        Me.UnitOfMeasureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BinaryAdditionToolStripMenuItem})
        Me.UnitOfMeasureToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control
        Me.UnitOfMeasureToolStripMenuItem.Name = "UnitOfMeasureToolStripMenuItem"
        Me.UnitOfMeasureToolStripMenuItem.Size = New System.Drawing.Size(208, 26)
        Me.UnitOfMeasureToolStripMenuItem.Text = "Programmer"
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
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.BetaCalculator.My.Resources.Resources.betacloud_removebg_preview1
        Me.PictureBox1.Location = New System.Drawing.Point(25, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 33)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 350
        Me.PictureBox1.TabStop = False
        '
        'Circumference
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(1356, 910)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Minimizea)
        Me.Controls.Add(Me.Closea)
        Me.Controls.Add(Me.ERRProvider)
        Me.Controls.Add(Me.MenuStrip2)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Circumference"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Circumference"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Minimizea As Label
    Friend WithEvents Closea As Label
    Friend WithEvents ERRProvider As Label
    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents CalculatorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NormalToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ScientificActualToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnitOfMeasureToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BinaryAdditionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FastMenuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
End Class
