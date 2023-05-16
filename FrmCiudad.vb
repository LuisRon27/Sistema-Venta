Imports System.Runtime.InteropServices
Public Class FrmCiudad
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

    Private Sub cmdsalir1_Click(sender As Object, e As EventArgs) Handles cmdsalir1.Click
        Me.Close()

    End Sub

    Public Sub CargaCiudad()

        If GrillaCiudad.Rows.Count <> 0 Then
            GrillaCiudad.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Ciudades order by ID"

        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaCiudad.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub
    Private Sub FrmCiudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaCiudad()
    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub GrillaCiudad_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles GrillaCiudad.CellFormatting
        If Me.GrillaCiudad.Columns(e.ColumnIndex).Name = "Activo" Then
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
        If GrillaCiudad.Rows.Count <> 0 Then
            GrillaCiudad.Rows.Clear()
        End If

        If RadioButton3.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Ciudades where Activo = 'Asset' order by ID"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    GrillaCiudad.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))
                End While

            Else

            End If

            lectordatos.Close()



        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If GrillaCiudad.Rows.Count <> 0 Then
            GrillaCiudad.Rows.Clear()
        End If

        If RadioButton2.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Ciudades where Activo = 'Inactive' order by ID"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    GrillaCiudad.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))
                End While

            Else

            End If

            lectordatos.Close()



        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        FrmABMCiudad.lblseñal.Text = "AGREGAR"
        FrmABMCiudad.Show()
    End Sub

    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles CmdModificar.Click
        FrmABMCiudad.lblseñal.Text = "MODIFICAR"
        FrmABMCiudad.txtid.Text = GrillaCiudad.CurrentRow.Cells(0).Value
        FrmABMCiudad.txtDescripcion.Text = GrillaCiudad.CurrentRow.Cells(1).Value
        FrmABMCiudad.cbActivo.Text = GrillaCiudad.CurrentRow.Cells(2).Value
        FrmABMCiudad.Show()
    End Sub

    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click

        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Ciudades WHERE ID = " & Val(GrillaCiudad.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga  para refrescar la grilla
            CargaCiudad()


        End If

    End Sub

    Private Sub RadioButton1_CheckedChanged_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub GrillaCiudad_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCiudad.CellContentClick

    End Sub

    Private Sub GrillaCiudad_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaCiudad.CellDoubleClick
        If lblSeñalBusqueda.Text = "BUSCAR" Then
            FrmABMProveedor.txtIdCiudad.Text = GrillaCiudad.CurrentRow.Cells(0).Value
            FrmABMProveedor.txtCiudad.Text = GrillaCiudad.CurrentRow.Cells(1).Value

            Close()

        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged_2(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If GrillaCiudad.Rows.Count <> 0 Then
            GrillaCiudad.Rows.Clear()
        End If

        If RadioButton1.Checked = True Then
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Ciudades order by ID"
            lectordatos = acciones.ExecuteReader
            If lectordatos.HasRows Then
                While lectordatos.Read()
                    GrillaCiudad.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))
                End While
            Else
            End If

            lectordatos.Close()
        End If
    End Sub

    Private Sub PanelCabecera_Paint(sender As Object, e As PaintEventArgs) Handles PanelCabecera.Paint

    End Sub
End Class