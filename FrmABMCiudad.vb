Imports System.Runtime.InteropServices
Public Class FrmABMCiudad

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Me.Close()

    End Sub


    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click

        ' Para agregar nuevos datos
        If lblseñal.Text = "AGREGAR" Then
            If txtDescripcion.Text.Trim() = "" Or cbActivo.SelectedItem Is Nothing Then
                MessageBox.Show("Debe completar todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "INSERT INTO Ciudades(Descripcion, Activo)VALUES('" & txtDescripcion.Text & "','" & cbActivo.Text & "')"
                acciones.ExecuteNonQuery()
                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            FrmCiudad.CargaCiudad()
            Close()
        End If

        ' Para modificar los datos existentes
        If lblseñal.Text = "MODIFICAR" Then

            If txtDescripcion.Text.Trim() = "" Or cbActivo.SelectedItem Is Nothing Then
                MessageBox.Show("Debe completar todos los campos antes de continuar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "UPDATE Ciudades SET Descripcion = '" & txtDescripcion.Text & "' ,Activo = '" & cbActivo.Text & "'  where ID = " & txtid.Text & ""
                acciones.ExecuteNonQuery()
                MsgBox("DATOS GUARDADOS", vbOKOnly + vbInformation)
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
            Close()
        End If

        ' Para refrescar la grilla
        FrmCiudad.CargaCiudad()

    End Sub


    Private Sub FrmABMCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtid.TabStop = True ' asegura de que la propiedad TabStop está establecida en True
        Me.BeginInvoke(Sub() txtDescripcion.Focus()) ' establece el foco en el txtDescripcion
        txtid.Enabled = False 'Desabilitar txtid 
    End Sub
End Class