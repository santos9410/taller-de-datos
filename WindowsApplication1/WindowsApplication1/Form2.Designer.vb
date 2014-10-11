<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmmenu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.ServiceController1 = New System.ServiceProcess.ServiceController()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.RegistoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistroDeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReportesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HerramientasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistoToolStripMenuItem, Me.FileToolStripMenuItem, Me.ReportesToolStripMenuItem, Me.HerramientasToolStripMenuItem, Me.SalirToolStripMenuItem, Me.SalirToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(763, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(71, 20)
        Me.FileToolStripMenuItem.Text = "Consultas"
        '
        'NuevoToolStripMenuItem
        '
        Me.NuevoToolStripMenuItem.Name = "NuevoToolStripMenuItem"
        Me.NuevoToolStripMenuItem.Size = New System.Drawing.Size(176, 22)
        Me.NuevoToolStripMenuItem.Text = "Consultar Alumnos"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(81, 20)
        Me.SalirToolStripMenuItem.Text = "cerra sesion"
        '
        'SalirToolStripMenuItem1
        '
        Me.SalirToolStripMenuItem1.Name = "SalirToolStripMenuItem1"
        Me.SalirToolStripMenuItem1.Size = New System.Drawing.Size(40, 20)
        Me.SalirToolStripMenuItem1.Text = "salir"
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'RegistoToolStripMenuItem
        '
        Me.RegistoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrToolStripMenuItem, Me.RegistroDeToolStripMenuItem, Me.RegistroDeToolStripMenuItem1})
        Me.RegistoToolStripMenuItem.Name = "RegistoToolStripMenuItem"
        Me.RegistoToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.RegistoToolStripMenuItem.Text = "Registro"
        '
        'RegistrToolStripMenuItem
        '
        Me.RegistrToolStripMenuItem.Name = "RegistrToolStripMenuItem"
        Me.RegistrToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RegistrToolStripMenuItem.Text = "Registro de Alumnos"
        '
        'RegistroDeToolStripMenuItem
        '
        Me.RegistroDeToolStripMenuItem.Name = "RegistroDeToolStripMenuItem"
        Me.RegistroDeToolStripMenuItem.Size = New System.Drawing.Size(185, 22)
        Me.RegistroDeToolStripMenuItem.Text = "Registro de Ciudades"
        '
        'RegistroDeToolStripMenuItem1
        '
        Me.RegistroDeToolStripMenuItem1.Name = "RegistroDeToolStripMenuItem1"
        Me.RegistroDeToolStripMenuItem1.Size = New System.Drawing.Size(185, 22)
        Me.RegistroDeToolStripMenuItem1.Text = "Registro de Maestros"
        '
        'ReportesToolStripMenuItem
        '
        Me.ReportesToolStripMenuItem.Name = "ReportesToolStripMenuItem"
        Me.ReportesToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ReportesToolStripMenuItem.Text = "Reportes"
        '
        'HerramientasToolStripMenuItem
        '
        Me.HerramientasToolStripMenuItem.Name = "HerramientasToolStripMenuItem"
        Me.HerramientasToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.HerramientasToolStripMenuItem.Text = "Herramientas"
        '
        'frmmenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(763, 300)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmmenu"
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents ServiceController1 As System.ServiceProcess.ServiceController
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents SalirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistroDeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReportesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HerramientasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
