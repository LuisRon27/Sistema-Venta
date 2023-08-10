Public Class FrmVentaxPeriodo
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub cmdsalir_Click(sender As Object, e As EventArgs) Handles cmdsalir.Click
        Close()

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Close()

    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub
    Private Sub borratemporal()

        Try
            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "delete  from Temporalimpresion"
            acciones.ExecuteNonQuery()


        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub llenatemporal()

        Dim date1 As String = DateTimePicker1.Value.ToString("yyyy-MM-dd")
        Dim date2 As String = DateTimePicker2.Value.ToString("yyyy-MM-dd")

        Try

            acciones.Connection = conexionSql
            acciones.CommandType = CommandType.Text
            acciones.CommandText = "SELECT FechaCarga, Nombre, Apellido, Tipo_Comprobante, Nro_Comprobante, Total_Venta FROM Venta WHERE FechaCarga between '" & date1 & "' and '" & date2 & "'"
            lectordatos = acciones.ExecuteReader

            If lectordatos.HasRows Then
                While lectordatos.Read()
                    Try
                        acciones2.Connection = conexionSql
                        acciones2.CommandType = CommandType.Text
                        acciones2.CommandText = "INSERT INTO Temporalimpresion (Campo6,Campo7,Campo8,Campo9,Campo10, Campo11)VALUES(" & lectordatos(0) & ",'" & lectordatos(1) & "','" & lectordatos(2) & "','" & lectordatos(3) & "','" & lectordatos(4) & "','" & lectordatos(5) & "')"
                        acciones2.ExecuteNonQuery()
                    Catch ex As Exception
                        MsgBox(ex.ToString)

                    End Try


                End While


            Else


                MsgBox("No existen datos para esta Consulta", vbOKOnly + vbInformation, "Mensaje del Sistema")


            End If


            lectordatos.Close()

        Catch ex As Exception

        End Try

    End Sub
    Private Sub CmdImprimir_Click(sender As Object, e As EventArgs) Handles CmdImprimir.Click
        borratemporal()
        llenatemporal()

    End Sub
End Class