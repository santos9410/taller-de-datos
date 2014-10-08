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
        Me.Dgv2 = New System.Windows.Forms.DataGridView()
        Me.btnfiltrar = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(12, 200)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(309, 150)
        Me.dgv.TabIndex = 0
        '
        'txtconsulta
        '
        Me.txtconsulta.Location = New System.Drawing.Point(300, 155)
        Me.txtconsulta.Name = "txtconsulta"
        Me.txtconsulta.Size = New System.Drawing.Size(198, 20)
        Me.txtconsulta.TabIndex = 1
        '
        'rbcontrol
        '
        Me.rbcontrol.AutoSize = True
        Me.rbcontrol.Location = New System.Drawing.Point(91, 35)
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
        Me.rbNombre.Location = New System.Drawing.Point(91, 72)
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
        Me.rbDom.Location = New System.Drawing.Point(91, 109)
        Me.rbDom.Name = "rbDom"
        Me.rbDom.Size = New System.Drawing.Size(65, 17)
        Me.rbDom.TabIndex = 4
        Me.rbDom.TabStop = True
        Me.rbDom.Text = "domicilio"
        Me.rbDom.UseVisualStyleBackColor = True
        '
        'lblbuspersonal
        '
        Me.lblbuspersonal.AutoSize = True
        Me.lblbuspersonal.Location = New System.Drawing.Point(225, 161)
        Me.lblbuspersonal.Name = "lblbuspersonal"
        Me.lblbuspersonal.Size = New System.Drawing.Size(44, 13)
        Me.lblbuspersonal.TabIndex = 5
        Me.lblbuspersonal.Text = "Nombre"
        '
        'Dgv2
        '
        Me.Dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Dgv2.Location = New System.Drawing.Point(348, 200)
        Me.Dgv2.Name = "Dgv2"
        Me.Dgv2.Size = New System.Drawing.Size(336, 149)
        Me.Dgv2.TabIndex = 6
        '
        'btnfiltrar
        '
        Me.btnfiltrar.Location = New System.Drawing.Point(554, 109)
        Me.btnfiltrar.Name = "btnfiltrar"
        Me.btnfiltrar.Size = New System.Drawing.Size(75, 23)
        Me.btnfiltrar.TabIndex = 7
        Me.btnfiltrar.Text = "filtrar"
        Me.btnfiltrar.UseVisualStyleBackColor = True
        '
        'frmconsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 378)
        Me.Controls.Add(Me.btnfiltrar)
        Me.Controls.Add(Me.Dgv2)
        Me.Controls.Add(Me.lblbuspersonal)
        Me.Controls.Add(Me.rbDom)
        Me.Controls.Add(Me.rbNombre)
        Me.Controls.Add(Me.rbcontrol)
        Me.Controls.Add(Me.txtconsulta)
        Me.Controls.Add(Me.dgv)
        Me.Name = "frmconsulta"
        Me.Text = "consulta"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents txtconsulta As System.Windows.Forms.TextBox
    Friend WithEvents rbcontrol As System.Windows.Forms.RadioButton
    Friend WithEvents rbNombre As System.Windows.Forms.RadioButton
    Friend WithEvents rbDom As System.Windows.Forms.RadioButton
    Friend WithEvents lblbuspersonal As System.Windows.Forms.Label
    Friend WithEvents Dgv2 As System.Windows.Forms.DataGridView
    Friend WithEvents btnfiltrar As System.Windows.Forms.Button
End Class
