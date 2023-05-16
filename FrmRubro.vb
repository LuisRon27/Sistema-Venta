Imports System.Runtime.InteropServices
Public Class FrmRubro

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

    Private Sub GrillaProducto_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaRubro.CellContentClick

    End Sub

    Private Sub cmdsalir1_Click(sender As Object, e As EventArgs) Handles cmdsalir1.Click
        Me.Close()

    End Sub
    Public Sub CargaRubro()

        If GrillaRubro.Rows.Count <> 0 Then
            GrillaRubro.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Rubro order by ID"

        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaRubro.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub
    Private Sub FrmRubro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaRubro()
    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If GrillaRubro.Rows.Count <> 0 Then
            GrillaRubro.Rows.Clear()
        End If

        If RadioButton3.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Rubro where Activo = 'Asset' order by ID"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    GrillaRubro.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))
                End While

            Else

            End If

            lectordatos.Close()



        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If GrillaRubro.Rows.Count <> 0 Then
            GrillaRubro.Rows.Clear()
        End If

        If RadioButton2.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Rubro where Activo = 'Inactive' order by ID"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    GrillaRubro.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))
                End While

            Else

            End If

            lectordatos.Close()



        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If GrillaRubro.Rows.Count <> 0 Then
            GrillaRubro.Rows.Clear()
        End If

        If RadioButton1.Checked = True Then
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Rubro order by ID"
            lectordatos = acciones.ExecuteReader
            If lectordatos.HasRows Then
                While lectordatos.Read()
                    GrillaRubro.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))
                End While
            Else
            End If

            lectordatos.Close()
        End If
    End Sub

    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        FrmABMRubro.lblseñal.Text = "AGREGAR"
        FrmABMRubro.Show()

    End Sub

    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles CmdModificar.Click

        FrmABMRubro.lblseñal.Text = "MODIFICAR"
        FrmABMRubro.txtid.Text = GrillaRubro.CurrentRow.Cells(0).Value
        FrmABMRubro.txtDescripcion.Text = GrillaRubro.CurrentRow.Cells(1).Value
        FrmABMRubro.cbActivo.Text = GrillaRubro.CurrentRow.Cells(2).Value
        FrmABMRubro.Show()

    End Sub

    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Rubro WHERE ID = " & Val(GrillaRubro.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga  para refrescar la grilla
            CargaRubro()





        End If
    End Sub

    Private Sub GrillaRubro_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaRubro.CellDoubleClick
        If lblSeñalBusqueda.Text = "BUSCAR" Then
            FrmABMProducto.txtIdRubro.Text = GrillaRubro.CurrentRow.Cells(0).Value
            FrmABMProducto.txtRubro.Text = GrillaRubro.CurrentRow.Cells(1).Value

            Close()

        End If
    End Sub

    Private Sub GrillaRubro_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles GrillaRubro.CellFormatting
        If Me.GrillaRubro.Columns(e.ColumnIndex).Name = "Activo" Then
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
End Class