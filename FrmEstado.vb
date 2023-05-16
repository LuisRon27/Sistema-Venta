Imports System.Runtime.InteropServices
Public Class FrmEstado

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub
    Public Sub CargaEstado()

        If GrillaEstado.Rows.Count <> 0 Then
            GrillaEstado.Rows.Clear()
        End If


        acciones.Connection = conexionSql

        acciones.CommandType = CommandType.Text

        acciones.CommandText = "Select * from Estado order by ID"

        lectordatos = acciones.ExecuteReader

        If lectordatos.HasRows Then

            While lectordatos.Read()

                'agrego los datos a la grilla
                GrillaEstado.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))

            End While

        Else

        End If

        lectordatos.Close()
    End Sub
    Private Sub FrmEstado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargaEstado()

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

    Private Sub cmdsalir1_Click(sender As Object, e As EventArgs) Handles cmdsalir1.Click
        Me.Close()

    End Sub




    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If GrillaEstado.Rows.Count <> 0 Then
            GrillaEstado.Rows.Clear()
        End If

        If RadioButton3.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Estado where Activo = 'Asset' order by ID"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    GrillaEstado.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))
                End While

            Else

            End If

            lectordatos.Close()



        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If GrillaEstado.Rows.Count <> 0 Then
            GrillaEstado.Rows.Clear()
        End If

        If RadioButton2.Checked = True Then

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Estado where Activo = 'Inactive' order by ID"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then

                While lectordatos.Read()

                    GrillaEstado.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))
                End While

            Else

            End If

            lectordatos.Close()



        End If
    End Sub


    Private Sub Cmdagregar_Click(sender As Object, e As EventArgs) Handles Cmdagregar.Click
        FrmABMEstado.lblseñal.Text = "AGREGAR"
        FrmABMEstado.Show()

    End Sub

    Private Sub CmdModificar_Click(sender As Object, e As EventArgs) Handles CmdModificar.Click

        FrmABMEstado.lblseñal.Text = "MODIFICAR"
        FrmABMEstado.txtid.Text = GrillaEstado.CurrentRow.Cells(0).Value
        FrmABMEstado.txtDescripcion.Text = GrillaEstado.CurrentRow.Cells(1).Value
        FrmABMEstado.cbActivo.Text = GrillaEstado.CurrentRow.Cells(2).Value
        FrmABMEstado.Show()
    End Sub

    Private Sub Cmdeliminar_Click(sender As Object, e As EventArgs) Handles Cmdeliminar.Click
        Dim result As Integer = MessageBox.Show("El registro sera eliminado... ¿Desea Continuar?", "Mensaje del sistema", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then

            Try

                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.Text
                acciones.CommandText = "delete from Estado WHERE ID = " & Val(GrillaEstado.CurrentRow.Cells(0).Value) & ""
                acciones.ExecuteNonQuery()
                MsgBox(" DATOS ELIMINADOS CORRECTAMENTE")
            Catch ex As Exception

                MsgBox(ex.ToString)

            End Try

            'llama a la funcion de carga  para refrescar la grilla
            CargaEstado()



        End If
    End Sub


    Private Sub GrillaEstado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaEstado.CellDoubleClick
        If lblSeñalBusqueda.Text = "BUSCAR" Then
            FrmABMProducto.txtIdEstado.Text = GrillaEstado.CurrentRow.Cells(0).Value
            FrmABMProducto.txtEstado.Text = GrillaEstado.CurrentRow.Cells(1).Value

            Close()

        End If
    End Sub

    Private Sub GrillaEstado_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles GrillaEstado.CellFormatting

        If Me.GrillaEstado.Columns(e.ColumnIndex).Name = "Activo" Then
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



    Private Sub GrillaEstado_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GrillaEstado.CellContentClick

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If GrillaEstado.Rows.Count <> 0 Then
            GrillaEstado.Rows.Clear()
        End If

        If RadioButton1.Checked = True Then
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "Select * from Estado order by ID"
            lectordatos = acciones.ExecuteReader
            If lectordatos.HasRows Then
                While lectordatos.Read()
                    GrillaEstado.Rows.Add(lectordatos(0), lectordatos(1), lectordatos(2))
                End While
            Else
            End If

            lectordatos.Close()
        End If
    End Sub
End Class