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

    Private Sub cmdCancelar_Click(sender As Object, e As EventArgs) Handles cmdCancelar.Click

        Dim result2 As Integer = MessageBox.Show("¿Esta seguro que desea Cancelar la Venta?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result2 = DialogResult.Yes Then

            txtcomprobante.Clear()
            txtidCliente.Clear()
            txtNombre.Clear()
            txtApellido.Clear()
            txtTotalVenta.Clear()
            RadioButton2.Checked = True
            RadioButton1.Checked = True
            GrillaVenta.Rows.Clear()


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
End Class