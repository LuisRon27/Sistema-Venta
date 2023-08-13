Public Class FrmVentaxPeriodo

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        borratemporal()
        Close()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        borratemporal()
        Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
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

        Dim tipoComprobante As String = "Todo" ' Valor predeterminado

        If radioVenta.Checked Then
            tipoComprobante = "Venta"
        ElseIf radioDevolucion.Checked Then
            tipoComprobante = "Devolución"
        End If

        Try
            ' Configurar la acción para llamar al procedimiento almacenado
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.StoredProcedure
            acciones.CommandText = "InsertarTemporalImpresion"
            acciones.Parameters.Clear()
            acciones.Parameters.AddWithValue("@FechaInicio", date1)
            acciones.Parameters.AddWithValue("@FechaFin", date2)
            acciones.Parameters.AddWithValue("@TipoComprobante", tipoComprobante)

            ' Ejecutar el procedimiento almacenado
            acciones.ExecuteNonQuery()

            MsgBox("Datos insertados correctamente en Temporalimpresion", vbOKOnly + vbInformation, "Mensaje del Sistema")

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub



    Private Sub FrmVentaxPeriodo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub radioDevolucion_CheckedChanged(sender As Object, e As EventArgs) Handles radioDevolucion.CheckedChanged

    End Sub

    Private Sub radioVenta_CheckedChanged(sender As Object, e As EventArgs) Handles radioVenta.CheckedChanged

    End Sub

    Private Sub radioTodo_CheckedChanged(sender As Object, e As EventArgs) Handles radioTodo.CheckedChanged

    End Sub

    Private Sub ToolStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class