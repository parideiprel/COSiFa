<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDIParent1
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
    'Non modificarla nell'editor del codice.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDIParent1))
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.FileMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizzaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistraOreXCatalogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VisualizzaSituazioneCataloghiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FatturazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneraFileFatturazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GeneraMailFatturazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UtilitàToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImportaProgrammaGalliToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ImportaSituazioneToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.MenuStrip.SuspendLayout()
        Me.ToolStrip.SuspendLayout()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip
        '
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileMenu, Me.VisualizzaToolStripMenuItem, Me.UtilitàToolStripMenuItem, Me.HelpMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(776, 24)
        Me.MenuStrip.TabIndex = 5
        Me.MenuStrip.Text = "MenuStrip"
        '
        'FileMenu
        '
        Me.FileMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder
        Me.FileMenu.Name = "FileMenu"
        Me.FileMenu.Size = New System.Drawing.Size(37, 20)
        Me.FileMenu.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(94, 22)
        Me.ExitToolStripMenuItem.Text = "E&sci"
        '
        'VisualizzaToolStripMenuItem
        '
        Me.VisualizzaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistraOreXCatalogoToolStripMenuItem, Me.VisualizzaSituazioneCataloghiToolStripMenuItem, Me.FatturazioneToolStripMenuItem})
        Me.VisualizzaToolStripMenuItem.Name = "VisualizzaToolStripMenuItem"
        Me.VisualizzaToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.VisualizzaToolStripMenuItem.Text = "&Attività"
        '
        'RegistraOreXCatalogoToolStripMenuItem
        '
        Me.RegistraOreXCatalogoToolStripMenuItem.Name = "RegistraOreXCatalogoToolStripMenuItem"
        Me.RegistraOreXCatalogoToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.RegistraOreXCatalogoToolStripMenuItem.Text = "&Registra Ore x catalogo"
        '
        'VisualizzaSituazioneCataloghiToolStripMenuItem
        '
        Me.VisualizzaSituazioneCataloghiToolStripMenuItem.Name = "VisualizzaSituazioneCataloghiToolStripMenuItem"
        Me.VisualizzaSituazioneCataloghiToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.VisualizzaSituazioneCataloghiToolStripMenuItem.Text = "Visualizza Situazione Cataloghi"
        '
        'FatturazioneToolStripMenuItem
        '
        Me.FatturazioneToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneraFileFatturazioneToolStripMenuItem, Me.GeneraMailFatturazioneToolStripMenuItem})
        Me.FatturazioneToolStripMenuItem.Name = "FatturazioneToolStripMenuItem"
        Me.FatturazioneToolStripMenuItem.Size = New System.Drawing.Size(235, 22)
        Me.FatturazioneToolStripMenuItem.Text = "Fatturazione"
        '
        'GeneraFileFatturazioneToolStripMenuItem
        '
        Me.GeneraFileFatturazioneToolStripMenuItem.Name = "GeneraFileFatturazioneToolStripMenuItem"
        Me.GeneraFileFatturazioneToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.GeneraFileFatturazioneToolStripMenuItem.Text = "Genera File Fatturazione"
        '
        'GeneraMailFatturazioneToolStripMenuItem
        '
        Me.GeneraMailFatturazioneToolStripMenuItem.Name = "GeneraMailFatturazioneToolStripMenuItem"
        Me.GeneraMailFatturazioneToolStripMenuItem.Size = New System.Drawing.Size(205, 22)
        Me.GeneraMailFatturazioneToolStripMenuItem.Text = "Genera Mail Fatturazione"
        '
        'UtilitàToolStripMenuItem
        '
        Me.UtilitàToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ImportaProgrammaGalliToolStripMenuItem, Me.ToolStripSeparator1, Me.ImportaSituazioneToolStripMenuItem})
        Me.UtilitàToolStripMenuItem.Name = "UtilitàToolStripMenuItem"
        Me.UtilitàToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.UtilitàToolStripMenuItem.Text = "&Utilità"
        '
        'ImportaProgrammaGalliToolStripMenuItem
        '
        Me.ImportaProgrammaGalliToolStripMenuItem.Name = "ImportaProgrammaGalliToolStripMenuItem"
        Me.ImportaProgrammaGalliToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ImportaProgrammaGalliToolStripMenuItem.Text = "Importa Programma Galli"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(205, 6)
        '
        'ImportaSituazioneToolStripMenuItem
        '
        Me.ImportaSituazioneToolStripMenuItem.Name = "ImportaSituazioneToolStripMenuItem"
        Me.ImportaSituazioneToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.ImportaSituazioneToolStripMenuItem.Text = "Importa Situazione"
        '
        'HelpMenu
        '
        Me.HelpMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpMenu.Name = "HelpMenu"
        Me.HelpMenu.Size = New System.Drawing.Size(24, 20)
        Me.HelpMenu.Text = "&?"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AboutToolStripMenuItem.Text = "&Informazioni su..."
        '
        'ToolStrip
        '
        Me.ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip.Name = "ToolStrip"
        Me.ToolStrip.Size = New System.Drawing.Size(776, 25)
        Me.ToolStrip.TabIndex = 6
        Me.ToolStrip.Text = "ToolStrip"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'StatusStrip
        '
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 559)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(776, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel.Text = "Stato"
        '
        'MDIParent1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 581)
        Me.Controls.Add(Me.ToolStrip)
        Me.Controls.Add(Me.MenuStrip)
        Me.Controls.Add(Me.StatusStrip)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "MDIParent1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "COSiFa - Cataloghi, Ore, Situazione e Fatturazione"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ToolStrip.ResumeLayout(False)
        Me.ToolStrip.PerformLayout()
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents HelpMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FileMenu As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuStrip As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents UtilitàToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImportaProgrammaGalliToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ImportaSituazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizzaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistraOreXCatalogoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VisualizzaSituazioneCataloghiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FatturazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneraFileFatturazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GeneraMailFatturazioneToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
