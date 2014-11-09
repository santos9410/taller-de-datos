Imports System.Data.SqlClient
Public Class frmRespaldo
    Dim Comando As New SqlCommand
    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHacer_Click(sender As Object, e As EventArgs) Handles btnHacer.Click

        Dim save As New SaveFileDialog()
        save.ShowDialog()
        lblrutas.Text = save.FileName
        Dim insertar As New SqlCommand
        Dim conexion2 As New SqlConnection
        Dim cadenita As String
        Try
            conexion2.ConnectionString = "Server=.; DataBase=master; uid=sa; pwd=sistemas;"
            conexion2.Open()
            insertar.Connection = conexion2
            ' cadenita = "BACKUP DATABASE	SISTEC	to disk=archivo"
            cadenita = "BACKUP DATABASE	SISTEC	to disk='" + save.FileName + "'"
            '     MsgBox(cadenita)
            insertar.CommandText = cadenita
            insertar.ExecuteNonQuery()

            conexion2.Close()
            ' BsAlumnos.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        
    End Sub

    Private Sub frmRespaldo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class