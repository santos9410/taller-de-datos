Imports System.Data.SqlClient
Public Class frmconsulta
    ' Dim conexion As New SqlConnection
    Dim Comando As New SqlCommand
    Dim Datos As New DataSet
    Dim Adaptador As New SqlDataAdapter
    Dim BsAlumnos As New BindingSource
    Dim source1 As New BindingSource()



    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        conexion.ConnectionString = Url
        ' Dim ds As DataSet = New DataSet
        Try

            'conexion.ConnectionString = Url
            'conexion.Open()
            ''  Comando.CommandText = "select * from ALUMNOS"
            '' Comando.CommandText = "use sistec"
            'Comando.CommandText = "select * from ALUMNOS"
            'Comando.Connection = conexion
            'BsAlumnos.DataSource = Comando.ExecuteReader()
            'dgv.DataSource = BsAlumnos

            Datos = New DataSet
            Dim tables As DataTableCollection = Datos.Tables
            ' provider = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source ="
            ' dataFile = "C:\Users\Jimmy\Documents\Merchandise.accdb" ' change to access database location on your computer
            ' connString = provider & dataFile
            ' myConnection.ConnectionString = connString
            Adaptador = New SqlDataAdapter("select * from ALUMNOS", conexion)
            '  da = New OleDbDataAdapter("Select [Item Code], [Description], [Price] from items", myConnection)
            Adaptador.Fill(Datos, "ALUMNOS")
            'da.Fill(ds, "Items")
            ' replace "items" with the name of the table
            ' replace [Item Code], [Description], [Price] with the columns headers
            Dim view1 As New DataView(tables(0))

            source1.DataSource = view1
            dgv.DataSource = view1
            dgv.Refresh()
            ' DataGridView1.DataSource = view1
            ' DataGridView1.Refresh()









        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            conexion.Close()


        End Try



        Try
            conexion.ConnectionString = Url
            Dim strsql As String
            'Listar los registros
            strsql = "Select * from ALUMNOS"

            Dim daEmp As New SqlClient.SqlDataAdapter(strsql, conexion)
            Dim dtEmp As New DataTable
            daEmp.Fill(dtEmp)
            '  Adaptador.Fill(dtEmp)
            Dgv2.DataSource = dtEmp
        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            conexion.Close()

        End Try




















        rbNombre.Checked = True


    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbcontrol.CheckedChanged
        lblbuspersonal.Text = rbcontrol.Text()

    End Sub

    Private Sub txtconsulta_TextChanged(sender As Object, e As EventArgs) Handles txtconsulta.TextChanged
        dgv.DataSource = BsAlumnos
        ' Dim cadena As String
        Try
           







            If rbcontrol.Checked = True Then


                BsAlumnos.Filter = "    NOMBRE like '" & txtconsulta.Text & "%' "
                '  DataGridView1.Refresh()
                dgv.Refresh()
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

    Private Sub btnfiltrar_Click(sender As Object, e As EventArgs) Handles btnfiltrar.Click


        BsAlumnos.Filter = "    NOMBRE like '" & txtconsulta.Text & "%' "
        '  DataGridView1.Refresh()
        dgv.Refresh()


        source1.Filter = "    NOMBRE like '" & txtconsulta.Text & "%' "
        dgv.Refresh()







    End Sub
End Class