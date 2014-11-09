<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frmusuarios
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUser = New System.Windows.Forms.TextBox()
        Me.txtPass = New System.Windows.Forms.TextBox()
        Me.txtConfPass = New System.Windows.Forms.TextBox()
        Me.CkSeleccionar = New System.Windows.Forms.CheckBox()
        Me.ckInsertar = New System.Windows.Forms.CheckBox()
        Me.ckActualizar = New System.Windows.Forms.CheckBox()
        Me.ckBorrar = New System.Windows.Forms.CheckBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "contraseña"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(106, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "confirmar contraseña"
        '
        'txtUser
        '
        Me.txtUser.Location = New System.Drawing.Point(159, 36)
        Me.txtUser.Name = "txtUser"
        Me.txtUser.Size = New System.Drawing.Size(199, 20)
        Me.txtUser.TabIndex = 3
        '
        'txtPass
        '
        Me.txtPass.Location = New System.Drawing.Point(159, 100)
        Me.txtPass.Name = "txtPass"
        Me.txtPass.Size = New System.Drawing.Size(199, 20)
        Me.txtPass.TabIndex = 4
        '
        'txtConfPass
        '
        Me.txtConfPass.Location = New System.Drawing.Point(159, 156)
        Me.txtConfPass.Name = "txtConfPass"
        Me.txtConfPass.Size = New System.Drawing.Size(199, 20)
        Me.txtConfPass.TabIndex = 5
        '
        'CkSeleccionar
        '
        Me.CkSeleccionar.AutoSize = True
        Me.CkSeleccionar.Location = New System.Drawing.Point(399, 51)
        Me.CkSeleccionar.Name = "CkSeleccionar"
        Me.CkSeleccionar.Size = New System.Drawing.Size(82, 17)
        Me.CkSeleccionar.TabIndex = 6
        Me.CkSeleccionar.Text = "Seleccionar"
        Me.CkSeleccionar.UseVisualStyleBackColor = True
        '
        'ckInsertar
        '
        Me.ckInsertar.AutoSize = True
        Me.ckInsertar.Location = New System.Drawing.Point(399, 97)
        Me.ckInsertar.Name = "ckInsertar"
        Me.ckInsertar.Size = New System.Drawing.Size(61, 17)
        Me.ckInsertar.TabIndex = 7
        Me.ckInsertar.Text = "Insertar"
        Me.ckInsertar.UseVisualStyleBackColor = True
        '
        'ckActualizar
        '
        Me.ckActualizar.AutoSize = True
        Me.ckActualizar.Location = New System.Drawing.Point(399, 143)
        Me.ckActualizar.Name = "ckActualizar"
        Me.ckActualizar.Size = New System.Drawing.Size(72, 17)
        Me.ckActualizar.TabIndex = 8
        Me.ckActualizar.Text = "Actualizar"
        Me.ckActualizar.UseVisualStyleBackColor = True
        '
        'ckBorrar
        '
        Me.ckBorrar.AutoSize = True
        Me.ckBorrar.Location = New System.Drawing.Point(399, 190)
        Me.ckBorrar.Name = "ckBorrar"
        Me.ckBorrar.Size = New System.Drawing.Size(54, 17)
        Me.ckBorrar.TabIndex = 9
        Me.ckBorrar.Text = "Borrar"
        Me.ckBorrar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(44, 238)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(132, 27)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(331, 239)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(94, 26)
        Me.btnCancelar.TabIndex = 11
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Frmusuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(579, 312)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.ckBorrar)
        Me.Controls.Add(Me.ckActualizar)
        Me.Controls.Add(Me.ckInsertar)
        Me.Controls.Add(Me.CkSeleccionar)
        Me.Controls.Add(Me.txtConfPass)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Frmusuarios"
        Me.Text = "Frmusuarios"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtUser As System.Windows.Forms.TextBox
    Friend WithEvents txtPass As System.Windows.Forms.TextBox
    Friend WithEvents txtConfPass As System.Windows.Forms.TextBox
    Friend WithEvents CkSeleccionar As System.Windows.Forms.CheckBox
    Friend WithEvents ckInsertar As System.Windows.Forms.CheckBox
    Friend WithEvents ckActualizar As System.Windows.Forms.CheckBox
    Friend WithEvents ckBorrar As System.Windows.Forms.CheckBox
    Friend WithEvents btnAceptar As System.Windows.Forms.Button
    Friend WithEvents btnCancelar As System.Windows.Forms.Button
End Class
