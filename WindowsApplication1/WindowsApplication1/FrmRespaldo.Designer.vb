<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRespaldo
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
        Me.btnHacer = New System.Windows.Forms.Button()
        Me.lblrutas = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnHacer
        '
        Me.btnHacer.Location = New System.Drawing.Point(128, 83)
        Me.btnHacer.Name = "btnHacer"
        Me.btnHacer.Size = New System.Drawing.Size(190, 37)
        Me.btnHacer.TabIndex = 0
        Me.btnHacer.Text = "Hacer respaldo"
        Me.btnHacer.UseVisualStyleBackColor = True
        '
        'lblrutas
        '
        Me.lblrutas.AutoSize = True
        Me.lblrutas.Location = New System.Drawing.Point(206, 160)
        Me.lblrutas.Name = "lblrutas"
        Me.lblrutas.Size = New System.Drawing.Size(39, 13)
        Me.lblrutas.TabIndex = 1
        Me.lblrutas.Text = "Label1"
        '
        'frmRespaldo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 221)
        Me.Controls.Add(Me.lblrutas)
        Me.Controls.Add(Me.btnHacer)
        Me.Name = "frmRespaldo"
        Me.Text = "Respaldo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHacer As System.Windows.Forms.Button
    Friend WithEvents lblrutas As System.Windows.Forms.Label
End Class
