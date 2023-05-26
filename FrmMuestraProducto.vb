Public Class FrmMuestraProducto



    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub GrillaRubro_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaMuestraProducto.CellContentClick

    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()

    End Sub

    Public Sub CargaMuestraProducto()

        If GrillaMuestraProducto.Rows.Count <> 0 Then
            GrillaMuestraProducto.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "SELECT ID, Descripcion, Precio_Venta, Cantidad FROM Producto ORDER BY ID"

        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaMuestraProducto.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2), lectordatos(3))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub
    Private Sub FrmMuestraProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaMuestraProducto()

    End Sub

    Private Sub GrillaMuestraProducto_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaMuestraProducto.CellDoubleClick
        txtid.Text = GrillaMuestraProducto.CurrentRow.Cells(0).Value
        txtDescripcion.Text = GrillaMuestraProducto.CurrentRow.Cells(1).Value
        txtventa.Text = GrillaMuestraProducto.CurrentRow.Cells(2).Value
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtTotal_TextChanged(sender As Object, e As EventArgs) Handles txtTotal.TextChanged

    End Sub

    Private Sub txtTotal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotal.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtCantidad_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged

        Dim cantidadDisponible As Integer

        ' Verificar si la cantidad disponible en la grilla es válida
        If Integer.TryParse(GrillaMuestraProducto.CurrentRow.Cells(3).Value.ToString(), cantidadDisponible) Then
            Dim cantidad As Integer

            ' Verificar si la cantidad ingresada por el usuario es válida
            If Integer.TryParse(txtCantidad.Text, cantidad) Then
                ' Verificar si la cantidad ingresada es mayor que la cantidad disponible
                If cantidad > cantidadDisponible Then
                    MessageBox.Show("No hay suficiente cantidad disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtCantidad.Clear()


                Else
                    ' El usuario ingresó una cantidad válida y no excede la cantidad disponible
                    ' Realizar el cálculo y actualizar el textbox txtTotal
                    Dim precio As Decimal
                    If Decimal.TryParse(txtventa.Text, precio) Then
                        Dim total As Decimal = precio * cantidad
                        txtTotal.Text = total.ToString()
                    Else
                        ' El precio no es un número válido, borrar el contenido del txtTotal
                        txtTotal.Text = ""
                    End If
                End If
            Else
                ' La cantidad ingresada por el usuario no es un número válido
                'MessageBox.Show("Ingrese una cantidad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'txtTotal.Text = ""
            End If
        Else
            ' La cantidad disponible en la grilla no es un número válido
            MessageBox.Show("Cantidad disponible no válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtTotal.Text = ""
        End If
    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click

        If txtid.Text.Trim() = "" Or txtDescripcion.Text.Trim() = "" Or txtventa.Text.Trim() = "" Or txtCantidad.Text.Trim() = "" Or txtTotal.Text.Trim() = "" Then
            MessageBox.Show("Debe completar todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            FrmVenta.GrillaVenta.Rows.Add(txtid.Text, txtDescripcion.Text, txtCantidad.Text, txtventa.Text, txtTotal.Text)
            ' Cerrar el formulario actual
            Close()
        End If



    End Sub
End Class