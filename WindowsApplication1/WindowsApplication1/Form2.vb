Public Class frmmenu

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        '   Dim strSQL As String
        'Listar los registros
        '   strSQL = "Select * from registros"
        '   Dim daEmp As New SqlClient.SqlDataAdapter(strSQL, conexion)
        '   Dim dtEmp As New DataTable
        '  daEmp.Fill(dtEmp)
        '  DataGridView1.DataSource = dtEmp



    End Sub


    Private Sub FileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileToolStripMenuItem.Click

    End Sub

    Private Sub ConsultaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaToolStripMenuItem.Click

        frmconsulta.Show()


    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        frmlogin.Show()
        Me.Hide()

    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        End
    End Sub
End Class