Public Class FrmVenta


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

    Private Sub Cmdvolver_Click(sender As Object, e As EventArgs) Handles Cmdvolver.Click
        Close()

    End Sub

    Private Sub btnBuscarCliente_Click(sender As Object, e As EventArgs) Handles btnBuscarCliente.Click
        FrmCliente.lblSeñalBusqueda.Text = "BUSCAR"
        FrmCliente.Show()
    End Sub

    Public Sub Clear()

        txtidCliente.Clear()
        txtNombre.Clear()
        txtApellido.Clear()
        txtTotalVenta.Clear()
        RadioButton2.Checked = True
        RadioButton1.Checked = True
        GrillaVenta.Rows.Clear()
    End Sub


    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click

        Dim result2 As Integer = MessageBox.Show("¿Esta seguro que desea Cancelar la Venta?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result2 = DialogResult.Yes Then


            Clear()

        End If


    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        FrmMuestraProducto.Show()

    End Sub

    Private Sub ActualizarTotalVenta(sender As Object, e As EventArgs)
        Dim total As Decimal = 0

        For Each fila As DataGridViewRow In GrillaVenta.Rows
            Dim valorTotal As Decimal = 0

            If Decimal.TryParse(fila.Cells("Total").Value.ToString(), valorTotal) Then
                total += valorTotal
            End If
        Next

        txtTotalVenta.Text = total.ToString()
    End Sub

    Private Sub FrmVenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler GrillaVenta.RowsAdded, AddressOf ActualizarTotalVenta
        AddHandler GrillaVenta.RowsRemoved, AddressOf ActualizarTotalVenta
        ActualizarTotalVenta(Nothing, Nothing)

        Auto_GenerateComprobante()
    End Sub

    Sub Auto_GenerateComprobante()

        Try

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "SELECT * FROM Detalle_Venta Order By ID_Detalle_Venta desc"
            lectordatos = acciones.ExecuteReader
            lectordatos.Read()

            If lectordatos.HasRows Then
                lblComprobante.Text = lectordatos.Item("Nro_Comprobante").ToString + 1
            Else
                lblComprobante.Text = Date.Now.ToString("yyyyMM") & "001"


            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        lectordatos.Close()

    End Sub

    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click

        ' Verificar si hay una fila seleccionada
        If GrillaVenta.SelectedRows.Count > 0 Then
            ' Obtener la fila seleccionada
            Dim filaSeleccionada As DataGridViewRow = GrillaVenta.SelectedRows(0)

            ' Eliminar la fila de la grilla
            GrillaVenta.Rows.Remove(filaSeleccionada)
        End If


    End Sub

    Public Sub Validar()

        If txtidCliente.Text.Trim() = "" Or txtNombre.Text.Trim() = "" Or txtApellido.Text.Trim() = "" Or txtTotalVenta.Text.Trim() = "" Then
            MessageBox.Show("Debe completar todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        ElseIf txtTotalVenta.Text.Trim() = 0 Then

            MessageBox.Show("El Precio Total No puede ser $0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If

    End Sub

    Public Sub Update_Product()
        Try
            ' Iterar a través de las filas de la DataGridView
            For Each fila As DataGridViewRow In GrillaVenta.Rows
                Dim codigo As String = fila.Cells("ID_Producto").Value.ToString()
                Dim cantidadVendida As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)


                ' Crear la consulta parametrizada
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Producto SET Cantidad = Cantidad - @CantidadVendida WHERE ID = @IDProducto"

                acciones.Parameters.Clear()

                ' Asignar los valores de los parámetros
                acciones.Parameters.AddWithValue("@IDProducto", codigo)
                acciones.Parameters.AddWithValue("@CantidadVendida", cantidadVendida)

                ' Ejecutar el comando para guardar los datos
                acciones.ExecuteNonQuery()
            Next

            MsgBox("Datos actualizados correctamente", vbOKOnly + vbInformation)

        Catch ex As Exception
            MsgBox("Error al Actualizar la tabla Producto: " & ex.ToString())
        End Try
    End Sub

    Public Sub InsertarDetallesVenta()

        Dim fechaFormateada As String = dtFechaCarga.Value.ToString("yyyy-MM-dd")

        'TABLA DETALLE VENTA
        Try

            ' Iterar a través de las filas de la DataGridView
            For Each fila As DataGridViewRow In GrillaVenta.Rows
                Dim codigo As String = fila.Cells("ID_Producto").Value.ToString()
                Dim descripcion As String = fila.Cells("Descripcion").Value.ToString()
                Dim cantidad As Integer = Convert.ToInt32(fila.Cells("Cantidad").Value)
                Dim precioUnitario As Decimal = Convert.ToDecimal(fila.Cells("Precio_Unitario").Value)
                Dim total As Decimal = Convert.ToDecimal(fila.Cells("Total").Value)

                ' Crear la consulta parametrizada
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Detalle_Venta(Nro_Comprobante, ID_Producto, Descripcion, Cantidad, Precio_Unitario, Precio_Total, FechaCarga)" &
                          "VALUES (@Nro_Comprobante, @ID_Producto, @Descripcion, @Cantidad, @Precio_Unitario, @Precio_Total, @FechaCarga)"

                acciones.Parameters.Clear()

                ' Asignar los valores de los parámetros
                acciones.Parameters.AddWithValue("@Nro_Comprobante", lblComprobante.Text)
                acciones.Parameters.AddWithValue("@ID_Producto", codigo)
                acciones.Parameters.AddWithValue("@Descripcion", descripcion)
                acciones.Parameters.AddWithValue("@Cantidad", cantidad)
                acciones.Parameters.AddWithValue("@Precio_Unitario", precioUnitario)
                acciones.Parameters.AddWithValue("@Precio_Total", total)
                acciones.Parameters.AddWithValue("@FechaCarga", fechaFormateada)


                ' Ejecutar el comando para guardar los datos
                acciones.ExecuteNonQuery()


            Next

            MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)



        Catch ex As Exception
            MsgBox("Error al Insertar Datos en la tabla Detalle_Venta: " & ex.ToString())
        End Try
    End Sub
    Private Sub cmdGrabar_Click(sender As Object, e As EventArgs) Handles cmdGrabar.Click

        'TODO: Separa la lógica de guardar los datos en la base de datos en funciones independientes para cada tipo de venta (corriente y contado).
        Dim fechaFormateada As String = dtFechaCarga.Value.ToString("yyyy-MM-dd")

        'SI es Venta Corriente... 
        If RadioButton1.Checked = True Then

            'Verificar si los campos no estan vacios 
            Validar()

            'TABLA Cuenta Corriente
            Try

                'Verificar RadioButton 
                Dim tipoVenta As String = ""

                If RadioButton1.Checked Then
                    tipoVenta = "Corriente"
                ElseIf RadioButton3.Checked Then
                    tipoVenta = "Contado"
                End If

                Dim tipoComprobante As String = ""


                If RadioButton2.Checked Then
                    tipoComprobante = "Venta"
                ElseIf RadioButton4.Checked Then
                    tipoComprobante = "Devolucion"
                End If

                ' Crear la consulta parametrizada
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Cuenta_Corriente(ID_Cliente, Nombre, Apellido, Tipo_Venta, Tipo_Comprobante, Total_Venta, Nro_Comprobante,FechaCarga)VALUES(@IDCliente, @Nombre, @Apellido, @TipoVenta, @TipoComprobante, @TotalVenta, @NroComprobante, @FechaCarga)"

                acciones.Parameters.Clear()

                ' Asignar los valores de los parámetros
                acciones.Parameters.AddWithValue("@IDCliente", txtidCliente.Text)
                acciones.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                acciones.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                acciones.Parameters.AddWithValue("@TipoVenta", tipoVenta)
                acciones.Parameters.AddWithValue("@TipoComprobante", tipoComprobante)
                acciones.Parameters.AddWithValue("@TotalVenta", txtTotalVenta.Text)
                acciones.Parameters.AddWithValue("@NroComprobante", lblComprobante.Text)
                acciones.Parameters.AddWithValue("@FechaCarga", fechaFormateada)

                ' Ejecutar el comando para guardar los datos
                acciones.ExecuteNonQuery()

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)



            Catch ex As Exception
                MsgBox("Error al Insertar Datos en la tabla Cuenta_Corriente: " & ex.ToString())
            End Try

            'Insertar Datos en la TABLA DETALLE VENTA
            InsertarDetallesVenta()

            'Actualizar Tabla Producto
            Update_Product()

            'Limpiar formulario
            Clear()

            'Actualiza el numero de comprobante
            Auto_GenerateComprobante()


            'Si es venta al Contado...
        ElseIf RadioButton3.Checked = True Then


            'Verificar si los campos no estan vacios 
            Validar()


            'TABLA Venta (al CONTADO)
            Try


                'Verificar RadioButton 
                Dim tipoVenta As String = ""

                If RadioButton1.Checked Then
                    tipoVenta = "Corriente"
                ElseIf RadioButton3.Checked Then
                    tipoVenta = "Contado"
                End If

                Dim tipoComprobante As String = ""


                If RadioButton2.Checked Then
                    tipoComprobante = "Venta"
                ElseIf RadioButton4.Checked Then
                    tipoComprobante = "Devolucion"
                End If

                ' Crear la consulta parametrizada
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Venta(ID_Cliente, Nombre, Apellido, Tipo_Venta, Tipo_Comprobante, Total_Venta, Nro_Comprobante, FechaCarga)VALUES(@IDCliente, @Nombre, @Apellido, @TipoVenta, @TipoComprobante, @TotalVenta, @NroComprobante, @FechaCarga)"

                acciones.Parameters.Clear()

                ' Asignar los valores de los parámetros
                acciones.Parameters.AddWithValue("@IDCliente", txtidCliente.Text)
                acciones.Parameters.AddWithValue("@Nombre", txtNombre.Text)
                acciones.Parameters.AddWithValue("@Apellido", txtApellido.Text)
                acciones.Parameters.AddWithValue("@TipoVenta", tipoVenta)
                acciones.Parameters.AddWithValue("@TipoComprobante", tipoComprobante)
                acciones.Parameters.AddWithValue("@TotalVenta", txtTotalVenta.Text)
                acciones.Parameters.AddWithValue("@NroComprobante", lblComprobante.Text)
                acciones.Parameters.AddWithValue("@FechaCarga", fechaFormateada)

                ' Ejecutar el comando para guardar los datos
                acciones.ExecuteNonQuery()

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)



            Catch ex As Exception
                MsgBox("Error al Insertar Datos en la tabla Venta (AL CONTADO): " & ex.ToString())
            End Try


            'Insertar Datos en la TABLA DETALLE VENTA
            InsertarDetallesVenta()

            'Actualizar Tabla Producto
            Update_Product()

            'Limpiar formulario
            Clear()

            'Actualiza el numero de comprobante
            Auto_GenerateComprobante()

        End If

    End Sub

    Private Sub ventaxPeriodoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ventaxPeriodoToolStripMenuItem.Click
        FrmVentaxPeriodo.Show()

    End Sub

    Private Sub ventasxclientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ventasxclientesToolStripMenuItem.Click
        FrmVentaxCliente.Show()

    End Sub

    Private Sub txtTotalVenta_TextChanged(sender As Object, e As EventArgs) Handles txtTotalVenta.TextChanged

    End Sub
End Class