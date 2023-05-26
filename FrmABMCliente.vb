Imports System.Runtime.InteropServices
Public Class FrmABMCliente

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()

    End Sub

    Private Sub PanelCabecera_Paint(sender As Object, e As PaintEventArgs) Handles PanelCabecera.Paint

    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()

    End Sub

    Private Sub cbIVA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipoCliente.SelectedIndexChanged

    End Sub

    Private Sub cbActivo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbActivo.SelectedIndexChanged

    End Sub

    Private Sub FrmABMCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.TabStop = True ' asegura de que la propiedad TabStop está establecida en True
        Me.BeginInvoke(Sub() txtNombre.Focus()) ' establece el foco en el txtDescripcion
        txtid.Enabled = False 'Desabilitar txtid 
    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        'Para Agregar Nuevos Datos

        If lblseñal.Text = "AGREGAR" Then

            If txtNombre.Text.Trim() = "" Or txtApellido.Text.Trim() = "" Or txtDireccion.Text.Trim() = "" Or txtTelefono.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or cbTipoCliente.SelectedItem Is Nothing Or cbActivo.SelectedItem Is Nothing Then
                MessageBox.Show("Debe completar todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Cliente(Nombre, Apellido, Direccion, Telefono, Email, Tipo_cliente, Activo)VALUES('" & txtNombre.Text & "', '" & txtApellido.Text & "', '" & txtDireccion.Text & "', '" & txtTelefono.Text & "', '" & txtEmail.Text & "','" & cbTipoCliente.Text & "', '" & cbActivo.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FrmCliente.CargaCliente()

            Close()

        End If


        If lblseñal.Text = "MODIFICAR" Then

            If txtNombre.Text.Trim() = "" Or txtApellido.Text.Trim() = "" Or txtDireccion.Text.Trim() = "" Or txtTelefono.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or cbTipoCliente.SelectedItem Is Nothing Or cbActivo.SelectedItem Is Nothing Then
                MessageBox.Show("Debe completar todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Cliente SET Nombre = '" & txtNombre.Text & "' ,Apellido = '" & txtApellido.Text & "' ,Direccion = '" & txtDireccion.Text & "' ,Telefono = '" & txtTelefono.Text & "' ,Email = '" & txtEmail.Text & "' ,Tipo_cliente = '" & cbTipoCliente.Text & "' ,Activo = '" & cbActivo.Text & "'   where ID_Cliente = " & txtid.Text & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            Close()

        End If

        'Para resfrescar la grilla 
        FrmCliente.CargaCliente()


    End Sub
End Class