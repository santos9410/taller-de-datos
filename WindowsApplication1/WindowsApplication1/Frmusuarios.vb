Imports System.Data.SqlClient

Public Class Frmusuarios
    Dim conexion As New SqlConnection
    Dim comando As New SqlCommand
    Dim DS As New DataSet
    Dim Adaptador As New SqlDataAdapter






    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Try

            Adaptador.SelectCommand.CommandText = "Create login " & txtUser.Text & " with password='" & txtPass.Text & "'"
            Adaptador.Fill(DS, "login")

            Adaptador.SelectCommand.CommandText = "Create user " & txtUser.Text
            Adaptador.Fill(DS, "user")

            If CkSeleccionar.Checked Then
                Adaptador.SelectCommand.CommandText = "grant select object::ALUMNOS to" & txtUser.Text
                Adaptador.Fill(DS, "select")
            End If

            If ckInsertar.Checked Then
                Adaptador.SelectCommand.CommandText = "grant insert object::ALUMNOS to" & txtUser.Text
                Adaptador.Fill(DS, "insert")
            End If

            If ckActualizar.Checked Then
                Adaptador.SelectCommand.CommandText = "grant update object::ALUMNOS to" & txtUser.Text
                Adaptador.Fill(DS, "update")
            End If

            If ckBorrar.Checked Then
                Adaptador.SelectCommand.CommandText = "grant delete object::ALUMNOS to" & txtUser.Text
                Adaptador.Fill(DS, "delete")
            End If




        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        conexion.Close()


    End Sub

    Private Sub Frmusuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = Url
            conexion.Open()
            comando.Connection = conexion
            Adaptador.SelectCommand = comando




        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        frmmenu.Show()
        Me.Hide()
        Me.Dispose()

    End Sub
End Class