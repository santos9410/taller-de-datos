<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRegistroA
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
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcontrol = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtdomicilio = New System.Windows.Forms.TextBox()
        Me.txtIdciudad = New System.Windows.Forms.TextBox()
        Me.txtsexo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txtgrupo = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnguardar
        '
        Me.btnguardar.BackColor = System.Drawing.Color.Blue
        Me.btnguardar.ForeColor = System.Drawing.Color.White
        Me.btnguardar.Location = New System.Drawing.Point(33, 324)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(117, 24)
        Me.btnguardar.TabIndex = 1
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(365, 324)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 24)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Cancelar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "No. control"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(29, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 24)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(87, 24)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Domicilio"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Id ciudad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 179)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 24)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Sexo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 258)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 24)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Grupo"
        '
        'txtcontrol
        '
        Me.txtcontrol.Location = New System.Drawing.Point(169, 13)
        Me.txtcontrol.Name = "txtcontrol"
        Me.txtcontrol.Size = New System.Drawing.Size(316, 20)
        Me.txtcontrol.TabIndex = 9
        '
        'txtnombre
        '
        Me.txtnombre.Location = New System.Drawing.Point(169, 57)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(316, 20)
        Me.txtnombre.TabIndex = 10
        '
        'txtdomicilio
        '
        Me.txtdomicilio.Location = New System.Drawing.Point(169, 99)
        Me.txtdomicilio.Name = "txtdomicilio"
        Me.txtdomicilio.Size = New System.Drawing.Size(316, 20)
        Me.txtdomicilio.TabIndex = 11
        '
        'txtIdciudad
        '
        Me.txtIdciudad.Location = New System.Drawing.Point(169, 141)
        Me.txtIdciudad.Name = "txtIdciudad"
        Me.txtIdciudad.Size = New System.Drawing.Size(316, 20)
        Me.txtIdciudad.TabIndex = 12
        '
        'txtsexo
        '
        Me.txtsexo.Location = New System.Drawing.Point(169, 183)
        Me.txtsexo.Name = "txtsexo"
        Me.txtsexo.Size = New System.Drawing.Size(316, 20)
        Me.txtsexo.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 219)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 24)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Edad"
        '
        'txtedad
        '
        Me.txtedad.Location = New System.Drawing.Point(169, 224)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(316, 20)
        Me.txtedad.TabIndex = 15
        '
        'txtgrupo
        '
        Me.txtgrupo.Location = New System.Drawing.Point(169, 263)
        Me.txtgrupo.Name = "txtgrupo"
        Me.txtgrupo.Size = New System.Drawing.Size(316, 20)
        Me.txtgrupo.TabIndex = 16
        '
        'frmRegistroA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(511, 376)
        Me.Controls.Add(Me.txtgrupo)
        Me.Controls.Add(Me.txtedad)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtsexo)
        Me.Controls.Add(Me.txtIdciudad)
        Me.Controls.Add(Me.txtdomicilio)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.txtcontrol)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnguardar)
        Me.Name = "frmRegistroA"
        Me.Text = "RegistroA"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnguardar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtcontrol As System.Windows.Forms.TextBox
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents txtdomicilio As System.Windows.Forms.TextBox
    Friend WithEvents txtIdciudad As System.Windows.Forms.TextBox
    Friend WithEvents txtsexo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtedad As System.Windows.Forms.TextBox
    Friend WithEvents txtgrupo As System.Windows.Forms.TextBox
End Class
