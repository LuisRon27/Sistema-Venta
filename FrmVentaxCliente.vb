Imports System.Data.SqlClient

Public Class FrmVentaxCliente
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        borratemporal()
        Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        borratemporal()
        Close()

    End Sub

    Private Sub lblID_Click(sender As Object, e As EventArgs) Handles lblID.Click

    End Sub

    Private Sub CmdImprimir_Click(sender As Object, e As EventArgs) Handles CmdImprimir.Click
        borratemporal()
        llenatemporal()

        Dim rpt_prueba As New InfVentaxPeriodo
        CrystalReportViewer1.ReportSource = rpt_prueba
        CrystalReportViewer1.RefreshReport()
    End Sub

    Private Sub borratemporal()
        Try
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "DELETE FROM Temporalimpresion"
            acciones.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Private Sub llenatemporal()
        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")
        Dim ID_Cliente As Integer

        ' Validar y convertir el valor del ID de cliente
        If Integer.TryParse(txtidCliente.Text, ID_Cliente) Then
            Try
                ' Verificar si el cliente existe
                Dim clienteExiste As Boolean = VerificarExistenciaCliente(ID_Cliente)

                If Not clienteExiste Then
                    MsgBox("El ID de cliente proporcionado no existe.", vbOKOnly + vbExclamation, "Mensaje del Sistema")
                    Return
                End If

                ' Configurar la acción para llamar al procedimiento almacenado
                acciones.Connection = conexionSql
                acciones.CommandType = CommandType.StoredProcedure
                acciones.CommandText = "InsertarTemporalImpresionCliente"
                acciones.Parameters.Clear()
                acciones.Parameters.AddWithValue("@FechaInicio", date1)
                acciones.Parameters.AddWithValue("@FechaFin", date2)
                acciones.Parameters.AddWithValue("@IdCliente", ID_Cliente)

                ' Ejecutar el procedimiento almacenado
                Dim filasInsertadas As Integer = acciones.ExecuteNonQuery()

                If filasInsertadas = 0 Then
                    MsgBox("No se encontraron ventas para el cliente en el rango de fechas especificado.", vbOKOnly + vbInformation, "Mensaje del Sistema")
                Else
                    MsgBox("Datos insertados correctamente en Temporalimpresion", vbOKOnly + vbInformation, "Mensaje del Sistema")
                End If

            Catch ex As Exception
                MsgBox("Error al insertar datos en Temporalimpresion: " + ex.Message, vbOKOnly + vbExclamation, "Mensaje del Sistema")
            End Try
        Else
            MsgBox("Ingrese un ID de cliente válido.", vbOKOnly + vbExclamation, "Mensaje del Sistema")
        End If
    End Sub


    Private Function VerificarExistenciaCliente(clienteID As Integer) As Boolean
        ' Verificar si el cliente existe en la base de datos
        Dim existe As Boolean = False
        Try
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "SELECT COUNT(*) FROM Cliente WHERE ID_Cliente = @ClienteID"
            acciones.Parameters.Clear()
            acciones.Parameters.AddWithValue("@ClienteID", clienteID)

            Dim count As Integer = CInt(acciones.ExecuteScalar())
            If count > 0 Then
                existe = True
            End If
        Catch ex As Exception
            MsgBox("Error al verificar la existencia del cliente: " + ex.Message, vbOKOnly + vbExclamation, "Mensaje del Sistema")
        End Try

        Return existe
    End Function



    Private Sub txtidCliente_TextChanged(sender As Object, e As EventArgs) Handles txtidCliente.TextChanged

    End Sub

    Private Sub txtidCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtidCliente.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub
End Class