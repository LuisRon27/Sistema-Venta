Public Class FrmProducto
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Dim result2 As Integer = MessageBox.Show("¿Esta seguro que desea Cerrar Sesion?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result2 = DialogResult.Yes Then

            End

        End If

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btn_maximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click

        WindowState = FormWindowState.Maximized
        btn_maximizar.Visible = False
        btnRestaurar.Visible = True

    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click

        WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btn_maximizar.Visible = True

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaProducto.CellContentClick

    End Sub

    Private Sub cmdsalir1_Click(sender As Object, e As EventArgs) Handles cmdsalir1.Click
        Close()

    End Sub
    Public Sub CargaProducto()

        If GrillaProducto.Rows.Count <> 0 Then
            GrillaProducto.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select Producto.ID, Producto.Descripcion, Producto.CodigoAlternativo, Proveedor.Nombre, Producto.Costo, Rubro.Descripcion, Estado.Descripcion, Producto.Fecha_Carga, Producto.Fecha_Actualizacion, Producto.Porcentaje_IVA, Producto.Imagen,Producto.Proveedor, Producto.Rubro,Producto.Estado, Producto.Cantidad, Producto.Precio_Venta from Rubro, Estado, Proveedor,Producto where Rubro.ID = Producto.Rubro and Estado.ID = Producto.Estado and Proveedor.ID = Producto.Proveedor order by Producto.ID"
        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaProducto.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13), lectordatos(14), lectordatos(15))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub
    Private Sub FrmProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaProducto()
    End Sub
    Public Sub busqueda(ByVal id As String, ByVal dgv As DataGridView)

        If GrillaProducto.Rows.Count <> 0 Then
            GrillaProducto.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "select Producto.ID, Producto.Descripcion, Producto.CodigoAlternativo, Proveedor.Nombre, Producto.Costo, Rubro.Descripcion, Estado.Descripcion, Producto.Fecha_Carga, Producto.Fecha_Actualizacion, Producto.Porcentaje_IVA, Producto.Imagen,Producto.Proveedor, Producto.Rubro,Producto.Estado, Producto.Cantidad, Producto.Precio_Venta from Rubro, Estado, Proveedor,Producto where Rubro.ID = Producto.Rubro and Estado.ID = Producto.Estado and Proveedor.ID = Producto.Proveedor and (Producto.ID like '" & "%" + id + "%" & "' or Producto.Descripcion like '" & "%" + id + "%" & "') "

        lectordatos = acciones.ExecuteReader
        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaProducto.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3), lectordatos(4), lectordatos(5), lectordatos(6), lectordatos(7), lectordatos(8), lectordatos(9), lectordatos(10), lectordatos(11), lectordatos(12), lectordatos(13), lectordatos(14), lectordatos(15))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub
    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbusqueda.TextChanged

        If txtbusqueda.Text.Contains("'") Then
            MsgBox("Este Caracter no es valido ")
            txtbusqueda.Clear()
        End If

        busqueda(txtbusqueda.Text, GrillaProducto)

        If txtbusqueda.Text = "" Then
            CargaProducto()

        End If

    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        FrmABMProducto.lblseñal.Text = "AGREGAR"
        FrmABMProducto.Show()

    End Sub

    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles CmdModificar.Click

        FrmABMProducto.lblseñal.Text = "MODIFICAR"
        FrmABMProducto.txtid.Text = GrillaProducto.CurrentRow.Cells(0).Value
        FrmABMProducto.txtDescripcion.Text = GrillaProducto.CurrentRow.Cells(1).Value
        FrmABMProducto.txtCodigoAlternativo.Text = GrillaProducto.CurrentRow.Cells(2).Value
        FrmABMProducto.txtproveedor.Text = GrillaProducto.CurrentRow.Cells(3).Value
        FrmABMProducto.txtcosto.Text = GrillaProducto.CurrentRow.Cells(4).Value.ToString().TrimEnd("0"c).TrimEnd(","c)
        FrmABMProducto.txtRubro.Text = GrillaProducto.CurrentRow.Cells(5).Value
        FrmABMProducto.txtEstado.Text = GrillaProducto.CurrentRow.Cells(6).Value
        FrmABMProducto.dtFechaCarga.Value = GrillaProducto.CurrentRow.Cells(7).Value
        FrmABMProducto.dtFechaActualizacion.Value = GrillaProducto.CurrentRow.Cells(8).Value
        FrmABMProducto.cbIVA.Text = GrillaProducto.CurrentRow.Cells(9).Value
        FrmABMProducto.txtImagen.Text = GrillaProducto.CurrentRow.Cells(10).Value

        FrmABMProducto.txtIdProveedor.Text = GrillaProducto.CurrentRow.Cells(11).Value
        FrmABMProducto.txtIdRubro.Text = GrillaProducto.CurrentRow.Cells(12).Value
        FrmABMProducto.txtIdEstado.Text = GrillaProducto.CurrentRow.Cells(13).Value

        FrmABMProducto.txtCantidad.Text = GrillaProducto.CurrentRow.Cells(14).Value
        FrmABMProducto.txtPrecioVenta.Text = GrillaProducto.CurrentRow.Cells(15).Value

        FrmABMProducto.Show()

    End Sub

    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Producto WHERE ID = " & Val(GrillaProducto.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga de Producto para refrescar la grilla
            CargaProducto()



        End If
    End Sub

    Private Sub txtbusqueda_MouseClick(sender As Object, e As MouseEventArgs) Handles txtbusqueda.MouseClick
        txtbusqueda.Clear()


    End Sub
End Class