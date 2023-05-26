Imports System.Runtime.InteropServices
Public Class FrmABMProducto

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub FrmABMProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.TabStop = True ' asegura de que la propiedad TabStop está establecida en True
        Me.BeginInvoke(Sub() txtDescripcion.Focus()) ' establece el foco en el txtDescripcion
        txtid.Enabled = False 'Desabilitar txtid 
        txtRubro.Enabled = False
        txtPrecioVenta.Enabled = False
        txtEstado.Enabled = False
        txtproveedor.Enabled = False
        txtImagen.Enabled = False


    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove

        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub


    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click

        Me.Close()

    End Sub

    Private Sub btnBuscarImagen_Click(sender As Object, e As EventArgs) Handles btnBuscarImagen.Click

        txtImagen.Clear()

        Dim openFileDialog1 As New OpenFileDialog()

        ' Fija las propiedades del cuadro de diálogo de abrir archivo
        openFileDialog1.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp|Todos los archivos|*.*"
        openFileDialog1.Title = "Selecciona una imagen"

        ' Si el usuario selecciona un archivo de imagen, muestra la ruta en el TextBox
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            txtImagen.Text = openFileDialog1.FileName
        End If

    End Sub


    Private Sub txtcosto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcosto.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtid_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtid.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click

        'Para Agregar Nuevos Datos

        If lblseñal.Text = "AGREGAR" Then

            If txtDescripcion.Text.Trim() = "" Or txtCodigoAlternativo.Text.Trim() = "" Or txtproveedor.Text.Trim() = "" Or txtcosto.Text.Trim() = "" Or cbIVA.SelectedItem Is Nothing Or txtRubro.Text.Trim() = "" Or txtEstado.Text.Trim() = "" Or txtImagen.Text.Trim() = "" Or txtCantidad.Text.Trim() = "" Or txtPrecioVenta.Text.Trim() = "" Then
                MessageBox.Show("Debe completar todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Producto(Descripcion, CodigoAlternativo,Proveedor, Costo, Rubro, Estado, Fecha_Carga, Fecha_Actualizacion,Porcentaje_IVA,Imagen, Cantidad, Precio_Venta)VALUES('" & txtDescripcion.Text & "','" & txtCodigoAlternativo.Text & "', '" & txtIdProveedor.Text & "', '" & txtcosto.Text & "','" & txtIdRubro.Text & "','" & txtIdEstado.Text & "','" & dtFechaCarga.Value & "','" & dtFechaActualizacion.Value & "','" & cbIVA.Text & "','" & txtImagen.Text & "','" & txtCantidad.Text & "','" & txtPrecioVenta.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FrmProducto.CargaProducto()
            Close()

        End If

        'Para agregar los datos modificados 

        If lblseñal.Text = "MODIFICAR" Then

            If txtDescripcion.Text.Trim() = "" Or txtCodigoAlternativo.Text.Trim() = "" Or txtproveedor.Text.Trim() = "" Or txtcosto.Text.Trim() = "" Or cbIVA.SelectedItem Is Nothing Or txtRubro.Text.Trim() = "" Or txtEstado.Text.Trim() = "" Or txtImagen.Text.Trim() = "" Or txtCantidad.Text.Trim() = "" Or txtPrecioVenta.Text.Trim() = "" Then
                MessageBox.Show("Debe completar todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Producto SET Descripcion = '" & txtDescripcion.Text & "' ,CodigoAlternativo = '" & txtCodigoAlternativo.Text & "',Proveedor = '" & txtIdProveedor.Text & "' ,Costo = '" & txtcosto.Text & "',Rubro = '" & txtIdRubro.Text & "' ,Estado = '" & txtIdEstado.Text & "' ,Fecha_Carga = '" & dtFechaCarga.Value & "' ,Fecha_Actualizacion = '" & dtFechaActualizacion.Value & "' ,Porcentaje_IVA = '" & cbIVA.Text & "' ,Imagen = '" & txtImagen.Text & "',Cantidad = '" & txtCantidad.Text & "',Precio_Venta = '" & txtPrecioVenta.Text & "'  where ID = " & txtid.Text & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            Close()

        End If

        'Para resfrescar la grilla 
        FrmProducto.CargaProducto()


    End Sub

    Private Sub btnBuscarProveedor_Click(sender As Object, e As EventArgs) Handles btnBuscarProveedor.Click
        FrmProveedor.lblseñal.Text = "BuscarProveedor"
        FrmProveedor.Show()

    End Sub

    Private Sub btnBuscarRubro_Click(sender As Object, e As EventArgs) Handles btnBuscarRubro.Click
        FrmRubro.lblSeñalBusqueda.Text = "BUSCAR"
        FrmRubro.Show()

    End Sub

    Private Sub btnBuscarEstado_Click(sender As Object, e As EventArgs) Handles btnBuscarEstado.Click
        FrmEstado.lblSeñalBusqueda.Text = "BUSCAR"
        FrmEstado.Show()
    End Sub

    Private Sub txtCantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCantidad.KeyPress

        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If

    End Sub

    Private Sub txtcosto_TextChanged(sender As Object, e As EventArgs) Handles txtcosto.TextChanged
        CalcularPrecioVenta()
    End Sub

    Private Sub cbIVA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbIVA.SelectedIndexChanged
        CalcularPrecioVenta()
    End Sub

    Private Sub CalcularPrecioVenta()

        Dim costo As Double

        If Double.TryParse(txtcosto.Text, costo) Then
            Dim porcentaje As Double = CDbl(cbIVA.SelectedItem)
            Dim precioVenta As Double = costo + (costo * (porcentaje / 100))
            txtPrecioVenta.Text = precioVenta.ToString()
        End If
    End Sub

    Private Sub PanelCabecera_Paint(sender As Object, e As PaintEventArgs) Handles PanelCabecera.Paint

    End Sub
End Class