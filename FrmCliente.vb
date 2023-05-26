Public Class FrmCliente
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim result2 As Integer = MessageBox.Show("¿Esta seguro que desea Cerrar Sesion?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result2 = DialogResult.Yes Then

            End

        End If
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cmdsalir1_Click(sender As Object, e As EventArgs) Handles cmdsalir1.Click
        Close()

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btn_maximizar.Visible = True
    End Sub

    Private Sub btn_maximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click
        WindowState = FormWindowState.Maximized
        btn_maximizar.Visible = False
        btnRestaurar.Visible = True
    End Sub

    Public Sub CargaCliente()

        If GrillaCliente.Rows.Count <> 0 Then
            GrillaCliente.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select * from Cliente order by ID_Cliente"

        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaCliente.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub
    Private Sub FrmCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCliente()

    End Sub

    Public Sub busquedaCliente(ByVal id As String, ByVal dgv As DataGridView)

        If GrillaCliente.Rows.Count <> 0 Then
            GrillaCliente.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select * from Cliente  where ID_Cliente like '" & "%" + id + "%" & "' or Nombre like '" & "%" + id + "%" & "' "

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaCliente.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub
    Private Sub txtbusqueda_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged
        If txtbusqueda.Text.Contains("'") Then
            MsgBox("Este Caracter no es valido ")
            txtbusqueda.Clear()
        End If

        busquedaCliente(txtbusqueda.Text, GrillaCliente)

        If txtbusqueda.Text = "" Then
            CargaCliente()



        End If
    End Sub

    Private Sub txtbusqueda_Click(sender As Object, e As EventArgs) Handles txtbusqueda.Click
        txtbusqueda.Clear()

    End Sub

    Private Sub GrillaCliente_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCliente.CellContentClick

    End Sub

    Private Sub GrillaCliente_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles GrillaCliente.CellFormatting
        If Me.GrillaCliente.Columns(e.ColumnIndex).Name = "Activo" Then
            If e.Value IsNot Nothing Then
                If e.Value.[GetType]() <> GetType(System.DBNull) Then
                    If e.Value.ToString() = "Asset" Then
                        e.CellStyle.BackColor = Color.FromArgb(207, 244, 252)
                    End If
                    If e.Value.ToString() = "Inactive" Then
                        e.CellStyle.BackColor = Color.FromArgb(248, 215, 218)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If GrillaCliente.Rows.Count <> 0 Then
            GrillaCliente.Rows.Clear()
        End If

        If RadioButton3.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Cliente where Activo = 'Asset' order by ID_Cliente"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    'agrego los datos a la grilla
                    GrillaCliente.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7))

                End While

            Else

            End If

            lectordatos.Close()



        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If GrillaCliente.Rows.Count <> 0 Then
            GrillaCliente.Rows.Clear()
        End If

        If RadioButton2.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Cliente where Activo = 'Inactive' order by ID_Cliente"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    'agrego los datos a la grilla
                    GrillaCliente.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7))

                End While

            Else

            End If

            lectordatos.Close()



        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If GrillaCliente.Rows.Count <> 0 Then
            GrillaCliente.Rows.Clear()
        End If

        If RadioButton1.Checked = True Then
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Cliente order by ID_Cliente"
            lectordatos = acciones.ExecuteReader
            If lectordatos.HasRows Then
                While lectordatos.Read()

                    'agrego los datos a la grilla
                    GrillaCliente.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7))

                End While
            Else
            End If

            lectordatos.Close()
        End If
    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        FrmABMCliente.lblseñal.Text = "AGREGAR"
        FrmABMCliente.Show()

    End Sub

    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles CmdModificar.Click
        FrmABMCliente.lblseñal.Text = "MODIFICAR"
        FrmABMCliente.txtid.Text = GrillaCliente.CurrentRow.Cells(0).Value
        FrmABMCliente.txtNombre.Text = GrillaCliente.CurrentRow.Cells(1).Value
        FrmABMCliente.txtApellido.Text = GrillaCliente.CurrentRow.Cells(2).Value
        FrmABMCliente.txtDireccion.Text = GrillaCliente.CurrentRow.Cells(3).Value
        FrmABMCliente.txtTelefono.Text = GrillaCliente.CurrentRow.Cells(4).Value
        FrmABMCliente.txtEmail.Text = GrillaCliente.CurrentRow.Cells(5).Value
        FrmABMCliente.cbTipoCliente.Text = GrillaCliente.CurrentRow.Cells(6).Value
        FrmABMCliente.cbActivo.Text = GrillaCliente.CurrentRow.Cells(7).Value
        FrmABMCliente.Show()
    End Sub

    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click

        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Cliente WHERE ID_Cliente = " & Val(GrillaCliente.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga  para refrescar la grilla
            CargaCliente()


        End If

    End Sub
End Class