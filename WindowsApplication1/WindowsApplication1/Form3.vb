Imports System.Data.SqlClient
Public Class frmconsulta
    ' Dim conexion As New SqlConnection
    Dim Comando As New SqlCommand
    Dim conexion As New SqlConnection
    Dim Datos As New DataSet
    Dim Adaptador As New SqlDataAdapter
    Dim BsAlumnos As New BindingSource

    Private Sub frmconsulta_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Me.Dispose()



    End Sub




    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = Url
        Try
            conexion.Open()
            Comando.CommandText = "select * from ALUMNOS"
            Comando.Connection = conexion

            Adaptador.SelectCommand = Comando
            Adaptador.Fill(Datos, "ALUMNOS")

            'Adaptador.SelectCommand.CommandText = "select*from ciudades"
            'Adaptador.Fill(Datos, "otro")


            BsAlumnos.DataSource = Datos
            BsAlumnos.DataMember = "ALUMNOS"
            dgv.DataSource = BsAlumnos


            Txtnc.DataBindings.Add("text", BsAlumnos, "CONTROL")
            Txtnombre.DataBindings.Add("text", BsAlumnos, "NOMBRE")


            conexion.Close()
        Catch ex As Exception
            MsgBox(ex.Message)

        End Try




       




















        rbNombre.Checked = True


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbcontrol.CheckedChanged
        lblbuspersonal.Text = rbcontrol.Text()

    End Sub

    Private Sub txtconsulta_TextChanged(sender As Object, e As EventArgs) Handles txtconsulta.TextChanged
        '   dgv.DataSource = BsAlumnos
        ' Dim cadena As String
        Try
           

            If rbcontrol.Checked = True Then


                BsAlumnos.Filter = "CONTROL like '" & txtconsulta.Text & "%' "

            ElseIf rbNombre.Checked Then
                BsAlumnos.Filter = "NOMBRE like '" & txtconsulta.Text & "%'"

            Else
                BsAlumnos.Filter = "DOMICILIO like '" & txtconsulta.Text & "%'"
            End If



        Catch ex As Exception

        End Try




    End Sub

    Private Sub rbNombre_CheckedChanged(sender As Object, e As EventArgs) Handles rbNombre.CheckedChanged
        lblbuspersonal.Text = rbNombre.Text()

    End Sub

    Private Sub rbDom_CheckedChanged(sender As Object, e As EventArgs) Handles rbDom.CheckedChanged
        lblbuspersonal.Text = rbDom.Text()
    End Sub

    
    Private Sub Txtnc_TextChanged(sender As Object, e As EventArgs) Handles Txtnc.TextChanged

    End Sub

    Private Sub btnfirst_Click(sender As Object, e As EventArgs) Handles btnfirst.Click
        BsAlumnos.MoveFirst()

    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        BsAlumnos.MoveNext()
    End Sub

    Private Sub btnlast_Click(sender As Object, e As EventArgs) Handles btnlast.Click
        BsAlumnos.MoveLast()
    End Sub

    Private Sub btnprevius_Click(sender As Object, e As EventArgs) Handles btnprevius.Click
        BsAlumnos.MovePrevious()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        BsAlumnos.AddNew()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Try
            BsAlumnos.CancelEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim insertar As New SqlCommand
        Dim conexion2 As New SqlConnection
        Dim cadenita As String
        Try
            conexion2.ConnectionString = Url
            conexion2.Open()
            insertar.Connection = conexion2
            cadenita = "insert into ALUMNOS (CONTROL,NOMBRE) values('" &
                Txtnc.Text & "'" & ",'" & Txtnombre.Text & "')"
            MsgBox(cadenita)
            insertar.CommandText = cadenita
            insertar.ExecuteNonQuery()

            conexion2.Close()
            BsAlumnos.EndEdit()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click

    End Sub
End Class