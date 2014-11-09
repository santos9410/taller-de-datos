Public Class frmlogin

    Dim conexion As New SqlClient.SqlConnection




    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnaceptar.Click

        Dim log As String
        Dim pass As String

        log = txtuser.Text
        pass = txtpass.Text



        '  Dim cn As New SqlClient.SqlConnection("Server=.; DataBase=taller; uid=sa; pwd=sistemas")
        '   cadena = "Server=.; DataBase=taller; uid=" & log & "; pwd=" & pass & ";"
        Url = "Server=.; DataBase=sistec; uid=" & log & "; pwd=" & pass & ";"
        ' Url = "Server=.; DataBase=sistec; uid=sa; pwd=sistemas;"
        conexion.ConnectionString = Url

        Try


            conexion.Open()

            frmmenu.Show()
            Me.Hide()



        Catch ex As Exception
            MsgBox("usuario o contraseña incorrecto")

        Finally

            conexion.Close()


        End Try


        txtuser.Text = ""

        txtpass.Text = ""



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End

    End Sub

    Private Sub frmlogin_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        End

    End Sub

    Private Sub frmlogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load




    End Sub
End Class
