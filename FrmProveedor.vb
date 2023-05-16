Public Class FrmProveedor
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim result2 As Integer = MessageBox.Show("¿Esta seguro que desea Cerrar Sesion?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result2 = DialogResult.Yes Then

            End

        End If
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btn_maximizar.Visible = True
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btn_maximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click
        WindowState = FormWindowState.Maximized
        btn_maximizar.Visible = False
        btnRestaurar.Visible = True
    End Sub

    Private Sub cmdsalir1_Click(sender As Object, e As EventArgs) Handles cmdsalir1.Click
        Me.Close()

    End Sub
    Public Sub CargaProveedor()

        If GrillaProveedor.Rows.Count <> 0 Then
            GrillaProveedor.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select Proveedor.ID, Proveedor.Nombre, Proveedor.Apellido, Proveedor.Cuit, Proveedor.Direccion, Proveedor.Telefono, Proveedor.Email, Ciudades.Descripcion, Proveedor.Provincia, Proveedor.Contacto, Condicion_IVA.Descripcion, Proveedor.Observaciones, Proveedor.Activo, Proveedor.Ciudad, Proveedor.Condicion_IVA from Ciudades, Proveedor, Condicion_IVA where  Ciudades.ID = Proveedor.Ciudad and Condicion_IVA.ID = Proveedor.Condicion_IVA  order by ID"

        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaProveedor.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13), lectordatos(14))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub
    Private Sub FrmProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaProveedor()

    End Sub
    Public Sub busquedaProveedor(ByVal id As String, ByVal dgv As DataGridView)

        If GrillaProveedor.Rows.Count <> 0 Then
            GrillaProveedor.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select Proveedor.ID, Proveedor.Nombre, Proveedor.Apellido, Proveedor.Cuit, Proveedor.Direccion, Proveedor.Telefono, Proveedor.Email, Ciudades.Descripcion, Proveedor.Provincia, Proveedor.Contacto, Condicion_IVA.Descripcion, Proveedor.Observaciones, Proveedor.Activo, Proveedor.Ciudad, Proveedor.Condicion_IVA from Ciudades, Proveedor, Condicion_IVA where  Ciudades.ID = Proveedor.Ciudad and Condicion_IVA.ID = Proveedor.Condicion_IVA and (Proveedor.ID like '" & "%" + id + "%" & "' or Proveedor.Nombre like '" & "%" + id + "%" & "') "

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaProveedor.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13), lectordatos(14))

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

        busquedaProveedor(txtbusqueda.Text, GrillaProveedor)

        If txtbusqueda.Text = "" Then
            CargaProveedor()


        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If GrillaProveedor.Rows.Count <> 0 Then
            GrillaProveedor.Rows.Clear()
        End If

        If RadioButton3.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "select Proveedor.ID, Proveedor.Nombre, Proveedor.Apellido, Proveedor.Cuit, Proveedor.Direccion, Proveedor.Telefono, Proveedor.Email, Ciudades.Descripcion, Proveedor.Provincia, Proveedor.Contacto, Condicion_IVA.Descripcion, Proveedor.Observaciones, Proveedor.Activo, Proveedor.Ciudad, Proveedor.Condicion_IVA from Ciudades, Proveedor, Condicion_IVA where  Ciudades.ID = Proveedor.Ciudad and Condicion_IVA.ID = Proveedor.Condicion_IVA and Proveedor.Activo = 'Asset' order by ID"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    GrillaProveedor.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13), lectordatos(14))
                End While

            Else

            End If

            lectordatos.Close()



        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If GrillaProveedor.Rows.Count <> 0 Then
            GrillaProveedor.Rows.Clear()
        End If

        If RadioButton2.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "select Proveedor.ID, Proveedor.Nombre, Proveedor.Apellido, Proveedor.Cuit, Proveedor.Direccion, Proveedor.Telefono, Proveedor.Email, Ciudades.Descripcion, Proveedor.Provincia, Proveedor.Contacto, Condicion_IVA.Descripcion, Proveedor.Observaciones, Proveedor.Activo, Proveedor.Ciudad, Proveedor.Condicion_IVA from Ciudades, Proveedor, Condicion_IVA where  Ciudades.ID = Proveedor.Ciudad and Condicion_IVA.ID = Proveedor.Condicion_IVA and Proveedor.Activo = 'Inactive' order by ID"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    GrillaProveedor.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13), lectordatos(14))
                End While

            Else

            End If

            lectordatos.Close()



        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If GrillaProveedor.Rows.Count <> 0 Then
            GrillaProveedor.Rows.Clear()
        End If

        If RadioButton1.Checked = True Then
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "select Proveedor.ID, Proveedor.Nombre, Proveedor.Apellido, Proveedor.Cuit, Proveedor.Direccion, Proveedor.Telefono, Proveedor.Email, Ciudades.Descripcion, Proveedor.Provincia, Proveedor.Contacto, Condicion_IVA.Descripcion, Proveedor.Observaciones, Proveedor.Activo,  Proveedor.Ciudad, Proveedor.Condicion_IVA from Ciudades, Proveedor, Condicion_IVA where  Ciudades.ID = Proveedor.Ciudad and Condicion_IVA.ID = Proveedor.Condicion_IVA  order by ID"
            lectordatos = acciones.ExecuteReader
            If lectordatos.HasRows Then
                While lectordatos.Read()
                    GrillaProveedor.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13), lectordatos(14))
                End While
            Else
            End If

            lectordatos.Close()
        End If
    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        FrmABMProveedor.lblseñal.Text = "AGREGAR"

        FrmABMProveedor.Show()

    End Sub

    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles CmdModificar.Click
        FrmABMProveedor.lblseñal.Text = "MODIFICAR"



        FrmABMProveedor.txtid.Text = GrillaProveedor.CurrentRow.Cells(0).Value
        FrmABMProveedor.txtNombre.Text = GrillaProveedor.CurrentRow.Cells(1).Value
        FrmABMProveedor.txtApellido.Text = GrillaProveedor.CurrentRow.Cells(2).Value
        FrmABMProveedor.txtCuit.Text = GrillaProveedor.CurrentRow.Cells(3).Value
        FrmABMProveedor.txtDireccion.Text = GrillaProveedor.CurrentRow.Cells(4).Value
        FrmABMProveedor.txtTelefono.Text = GrillaProveedor.CurrentRow.Cells(5).Value
        FrmABMProveedor.txtEmail.Text = GrillaProveedor.CurrentRow.Cells(6).Value
        FrmABMProveedor.txtCiudad.Text = GrillaProveedor.CurrentRow.Cells(7).Value
        FrmABMProveedor.cbProvincia.Text = GrillaProveedor.CurrentRow.Cells(8).Value
        FrmABMProveedor.txtContacto.Text = GrillaProveedor.CurrentRow.Cells(9).Value
        FrmABMProveedor.txtCondicionIva.Text = GrillaProveedor.CurrentRow.Cells(10).Value
        FrmABMProveedor.txtObservaciones.Text = GrillaProveedor.CurrentRow.Cells(11).Value
        FrmABMProveedor.cbActivo.Text = GrillaProveedor.CurrentRow.Cells(12).Value

        FrmABMProveedor.txtIdCiudad.Text = GrillaProveedor.CurrentRow.Cells(13).Value
        FrmABMProveedor.txtIdCondicionIva.Text = GrillaProveedor.CurrentRow.Cells(14).Value

        FrmABMProveedor.Show()
    End Sub

    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Proveedor WHERE ID = " & Val(GrillaProveedor.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga  para refrescar la grilla
            CargaProveedor()




        End If
    End Sub

    Private Sub GrillaProveedor_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProveedor.CellContentClick

    End Sub

    Private Sub GrillaProveedor_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProveedor.CellDoubleClick
        If lblseñal.Text = "BuscarProveedor" Then
            FrmABMProducto.txtIdProveedor.Text = GrillaProveedor.CurrentRow.Cells(0).Value
            FrmABMProducto.txtproveedor.Text = GrillaProveedor.CurrentRow.Cells(1).Value

            Close()

        End If
    End Sub

    Private Sub txtbusqueda_MouseClick(sender As Object, e As MouseEventArgs) Handles txtbusqueda.MouseClick
        txtbusqueda.Clear()

    End Sub
End Class