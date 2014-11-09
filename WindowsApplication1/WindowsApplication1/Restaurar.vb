Imports System.Data.SqlClient
Public Class frmRestaurar

    Dim Comando As New SqlCommand
    Private Sub Restaurar_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk








    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ruta As New OpenFileDialog()
        ruta.ShowDialog()
        '   lblRuta.Text = ruta.FileName
        Dim insertar As New SqlCommand
        Dim conexion2 As New SqlConnection
        Dim cadenita As String
        Try
            conexion2.ConnectionString = "Server=.; DataBase=master; uid=sa; pwd=sistemas;"
            conexion2.Open()
            insertar.Connection = conexion2
            cadenita = "RESTORE DATABASE SISTEC FROM disk='" + ruta.FileName + "' with replace"
            '     MsgBox(cadenita)
            insertar.CommandText = cadenita
            insertar.ExecuteNonQuery()

            conexion2.Close()
            ' BsAlumnos.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub
End Class