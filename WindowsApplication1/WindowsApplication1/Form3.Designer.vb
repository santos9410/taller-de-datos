<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconsulta
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtconsulta = New System.Windows.Forms.TextBox()
        Me.rbcontrol = New System.Windows.Forms.RadioButton()
        Me.rbNombre = New System.Windows.Forms.RadioButton()
        Me.rbDom = New System.Windows.Forms.RadioButton()
        Me.lblbuspersonal = New System.Windows.Forms.Label()
        Me.Txtnc = New System.Windows.Forms.TextBox()
        Me.Txtnombre = New System.Windows.Forms.TextBox()
        Me.btnfirst = New System.Windows.Forms.Button()
        Me.btnlast = New System.Windows.Forms.Button()
        Me.btnnext = New System.Windows.Forms.Button()
        Me.btnprevius = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.btnBorrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 180)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(702, 192)
        Me.dgv.TabIndex = 0
        '
        'txtconsulta
        '
        Me.txtconsulta.Location = New System.Drawing.Point(61, 151)
        Me.txtconsulta.Name = "txtconsulta"
        Me.txtconsulta.Size = New System.Drawing.Size(272, 20)
        Me.txtconsulta.TabIndex = 1
        '
        'rbcontrol
        '
        Me.rbcontrol.AutoSize = True
        Me.rbcontrol.Location = New System.Drawing.Point(62, 84)
        Me.rbcontrol.Name = "rbcontrol"
        Me.rbcontrol.Size = New System.Drawing.Size(58, 17)
        Me.rbcontrol.TabIndex = 2
        Me.rbcontrol.TabStop = True
        Me.rbcontrol.Text = "Control"
        Me.rbcontrol.UseVisualStyleBackColor = True
        '
        'rbNombre
        '
        Me.rbNombre.AutoSize = True
        Me.rbNombre.Location = New System.Drawing.Point(62, 38)
        Me.rbNombre.Name = "rbNombre"
        Me.rbNombre.Size = New System.Drawing.Size(62, 17)
        Me.rbNombre.TabIndex = 3
        Me.rbNombre.TabStop = True
        Me.rbNombre.Text = "Nombre"
        Me.rbNombre.UseVisualStyleBackColor = True
        '
        'rbDom
        '
        Me.rbDom.AutoSize = True
        Me.rbDom.Location = New System.Drawing.Point(61, 61)
        Me.rbDom.Name = "rbDom"
        Me.rbDom.Size = New System.Drawing.Size(67, 17)
        Me.rbDom.TabIndex = 4
        Me.rbDom.TabStop = True
        Me.rbDom.Text = "Domicilio"
        Me.rbDom.UseVisualStyleBackColor = True
        '
        'lblbuspersonal
        '
        Me.lblbuspersonal.AutoSize = True
        Me.lblbuspersonal.Location = New System.Drawing.Point(9, 151)
        Me.lblbuspersonal.Name = "lblbuspersonal"
        Me.lblbuspersonal.Size = New System.Drawing.Size(44, 13)
        Me.lblbuspersonal.TabIndex = 5
        Me.lblbuspersonal.Text = "Nombre"
        '
        'Txtnc
        '
        Me.Txtnc.Location = New System.Drawing.Point(292, 81)
        Me.Txtnc.Name = "Txtnc"
        Me.Txtnc.Size = New System.Drawing.Size(284, 20)
        Me.Txtnc.TabIndex = 6
        '
        'Txtnombre
        '
        Me.Txtnombre.Location = New System.Drawing.Point(292, 47)
        Me.Txtnombre.Name = "Txtnombre"
        Me.Txtnombre.Size = New System.Drawing.Size(283, 20)
        Me.Txtnombre.TabIndex = 7
        '
        'btnfirst
        '
        Me.btnfirst.Location = New System.Drawing.Point(385, 151)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(75, 23)
        Me.btnfirst.TabIndex = 8
        Me.btnfirst.Text = "Primero"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.Location = New System.Drawing.Point(466, 151)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(75, 23)
        Me.btnlast.TabIndex = 9
        Me.btnlast.Text = "Último"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Location = New System.Drawing.Point(547, 151)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(75, 23)
        Me.btnnext.TabIndex = 10
        Me.btnnext.Text = "Siguiente"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnprevius
        '
        Me.btnprevius.Location = New System.Drawing.Point(628, 151)
        Me.btnprevius.Name = "btnprevius"
        Me.btnprevius.Size = New System.Drawing.Size(75, 23)
        Me.btnprevius.TabIndex = 11
        Me.btnprevius.Text = "Antes"
        Me.btnprevius.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(628, 105)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(75, 23)
        Me.btncancelar.TabIndex = 12
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(628, 12)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnnuevo.TabIndex = 13
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(628, 44)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 14
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'btnBorrar
        '
        Me.btnBorrar.Location = New System.Drawing.Point(628, 76)
        Me.btnBorrar.Name = "btnBorrar"
        Me.btnBorrar.Size = New System.Drawing.Size(75, 23)
        Me.btnBorrar.TabIndex = 15
        Me.btnBorrar.Text = "Borrar"
        Me.btnBorrar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "BUSCAR POR:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(223, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "No. Control"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(223, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Nombre:"
        '
        'frmconsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 385)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBorrar)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnprevius)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.Txtnombre)
        Me.Controls.Add(Me.Txtnc)
        Me.Controls.Add(Me.lblbuspersonal)
        Me.Controls.Add(Me.rbDom)
        Me.Controls.Add(Me.rbNombre)
        Me.Controls.Add(Me.rbcontrol)
        Me.Controls.Add(Me.txtconsulta)
        Me.Controls.Add(Me.dgv)
        Me.Name = "frmconsulta"
        Me.Text = "Consulta"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents txtconsulta As System.Windows.Forms.TextBox
    Friend WithEvents rbcontrol As System.Windows.Forms.RadioButton
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbDom As System.Windows.Forms.RadioButton
    Friend WithEvents lblbuspersonal As System.Windows.Forms.Label
    Friend WithEvents Txtnc As System.Windows.Forms.TextBox
    Friend WithEvents Txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnprevius As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnnuevo As System.Windows.Forms.Button
    Friend WithEvents btnGuardar As System.Windows.Forms.Button
    Friend WithEvents btnBorrar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
