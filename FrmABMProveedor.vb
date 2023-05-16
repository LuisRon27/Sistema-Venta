Public Class FrmABMProveedor
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click

        Me.Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click

        WindowState = FormWindowState.Minimized

    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Close()

    End Sub

    Private Sub FrmABMProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.TabStop = True ' asegura de que la propiedad TabStop está establecida en True
        Me.BeginInvoke(Sub() txtNombre.Focus()) ' establece el foco en el txtDescripcion
        txtid.Enabled = False 'Desabilitar txtid 
        txtCiudad.Enabled = False
        txtCondicionIva.Enabled = False

    End Sub



    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        'Para Agregar Nuevos Datos

        If lblseñal.Text = "AGREGAR" Then

            If txtNombre.Text.Trim() = "" Or txtApellido.Text.Trim() = "" Or txtCuit.Text.Trim() = "" Or txtDireccion.Text.Trim() = "" Or txtTelefono.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or txtCiudad.Text.Trim() = "" Or cbProvincia.SelectedItem Is Nothing Or txtCondicionIva.Text.Trim() = "" Or txtContacto.Text.Trim() = "" Or cbActivo.SelectedItem Is Nothing Or txtObservaciones.Text.Trim() = "" Then
                MessageBox.Show("Debe completar todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Proveedor(Nombre,Apellido,Cuit,Direccion,Telefono,Email,Ciudad,Provincia,Contacto,Condicion_IVA,Observaciones, Activo)VALUES('" & txtNombre.Text & "','" & txtApellido.Text & "', '" & txtCuit.Text & "', '" & txtDireccion.Text & "','" & txtTelefono.Text & "','" & txtEmail.Text & "','" & txtIdCiudad.Text & "','" & cbProvincia.Text & "','" & txtContacto.Text & "','" & txtIdCondicionIva.Text & "','" & txtObservaciones.Text & "','" & cbActivo.Text & "')"
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            FrmProveedor.CargaProveedor()
            Close()

        End If
        'Para agregar los datos modificados 

        If lblseñal.Text = "MODIFICAR" Then

            If txtNombre.Text.Trim() = "" Or txtApellido.Text.Trim() = "" Or txtCuit.Text.Trim() = "" Or txtDireccion.Text.Trim() = "" Or txtTelefono.Text.Trim() = "" Or txtEmail.Text.Trim() = "" Or txtCiudad.Text.Trim() = "" Or cbProvincia.SelectedItem Is Nothing Or txtCondicionIva.Text.Trim() = "" Or txtContacto.Text.Trim() = "" Or cbActivo.SelectedItem Is Nothing Or txtObservaciones.Text.Trim() = "" Then
                MessageBox.Show("Debe completar todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If


            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Proveedor SET Nombre = '" & txtNombre.Text & "' ,Apellido = '" & txtApellido.Text & "',Cuit = '" & txtCuit.Text & "' ,Direccion = '" & txtDireccion.Text & "',Telefono = '" & txtTelefono.Text & "' ,Email = '" & txtEmail.Text & "' ,Ciudad = '" & txtIdCiudad.Text & "' ,Provincia = '" & cbProvincia.Text & "' ,Contacto = '" & txtContacto.Text & "' ,Condicion_IVA = '" & txtIdCondicionIva.Text & "',Observaciones = '" & txtObservaciones.Text & "',Activo = '" & cbActivo.Text & "'  where ID = " & txtid.Text & ""
                acciones.ExecuteNonQuery()

                'conexion.close

                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)


            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try


            Close()

        End If

        'Para resfrescar la grilla 
        FrmProveedor.CargaProveedor()




    End Sub

    Private Sub btnBuscarCiudad_Click(sender As Object, e As EventArgs) Handles btnBuscarCiudad.Click
        FrmCiudad.lblSeñalBusqueda.Text = "BUSCAR"
        FrmCiudad.Show()
    End Sub

    Private Sub btnBuscarCondicionIva_Click(sender As Object, e As EventArgs) Handles btnBuscarCondicionIva.Click
        FrmCondicionIVA.lblSeñalBusqueda.Text = "BUSCAR"
        FrmCondicionIVA.Show()
    End Sub
End Class