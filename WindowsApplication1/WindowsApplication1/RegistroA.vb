Imports System.Data.SqlClient
Public Class frmRegistroA
    Dim insertar As New SqlCommand
    Dim conexion2 As New SqlConnection
    Dim cadenita As String



    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        Try
            insertar.Connection = conexion2
            cadenita = "insert into ALUMNOS  values('" &
                txtcontrol.Text & "'," & "'" & txtnombre.Text & "'," & "'" & txtdomicilio.Text & "'," & "'" & txtIdciudad.Text & "'," & "'" & txtsexo.Text & "'," & "'" & txtedad.Text & "'," & "'" & txtgrupo.Text & "'" & ")"

            insertar.CommandText = cadenita
            insertar.ExecuteNonQuery()

            conexion2.Close()
            '   BsAlumnos.EndEdit()


            txtcontrol.Text = ""
            txtnombre.Text = ""
            txtdomicilio.Text = ""
            txtIdciudad.Text = ""
            txtsexo.Text = ""
            txtedad.Text = ""
            txtgrupo.Text = ""



        Catch ex As Exception
            MsgBox(ex.Message)
        End Try



    End Sub

    Private Sub frmRegistroA_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        
        Try
            conexion2.ConnectionString = Url
            conexion2.Open()
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        frmmenu.Show()
        Me.Hide()



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class