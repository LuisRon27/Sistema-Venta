Imports System.Runtime.InteropServices
Public Class frmPrincipal

    <DllImport("user32.DLL", EntryPoint:="ReleaseCapture")>
    Private Shared Sub ReleaseCapture()
    End Sub
    <DllImport("user32.DLL", EntryPoint:="SendMessage")>
    Private Shared Sub SendMessage(ByVal hWnd As System.IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer)
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Dim result2 As Integer = MessageBox.Show("¿Esta seguro que desea Cerrar Sesion?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result2 = DialogResult.Yes Then

            End

        End If
    End Sub

    Private Sub btn_maximizar_Click(sender As Object, e As EventArgs) Handles btn_maximizar.Click
        WindowState = FormWindowState.Maximized
        btn_maximizar.Visible = False
        btnRestaurar.Visible = True
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnRestaurar_Click(sender As Object, e As EventArgs) Handles btnRestaurar.Click
        WindowState = FormWindowState.Normal
        btnRestaurar.Visible = False
        btn_maximizar.Visible = True
    End Sub

    Private Sub PanelCabecera_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelCabecera.MouseMove
        ReleaseCapture()
        SendMessage(Me.Handle, &H112&, &HF012&, 0)
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles tmMostrarMenu.Tick
        If MenuVertical.Width >= 220 Then
            Me.tmMostrarMenu.Enabled = False
        Else
            Me.MenuVertical.Width = MenuVertical.Width + 20
        End If
    End Sub

    Private Sub tmOcultarMenu_Tick(sender As Object, e As EventArgs) Handles tmOcultarMenu.Tick
        If MenuVertical.Width <= 60 Then
            Me.tmOcultarMenu.Enabled = False
        Else
            Me.MenuVertical.Width = MenuVertical.Width - 20
        End If
    End Sub

    Private Sub btnMenu_Click(sender As Object, e As EventArgs) Handles btnMenu.Click
        If MenuVertical.Width = 220 Then
            tmOcultarMenu.Enabled = True
        ElseIf MenuVertical.Width = 60 Then
            tmMostrarMenu.Enabled = True
        End If
    End Sub


    Private Sub btnexit_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        End

    End Sub

    Private Sub btnexit_Click_1(sender As Object, e As EventArgs) Handles btnexit.Click
        Dim result2 As Integer = MessageBox.Show("¿Esta seguro que desea Cerrar Sesion?", "Mensaje del sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If result2 = DialogResult.Yes Then

            End

        End If
    End Sub

    Private Sub horafecha_Tick(sender As Object, e As EventArgs) Handles horafecha.Tick
        lblhora.Text = DateTime.Now.ToLongTimeString
        lblfecha.Text = DateTime.Now.ToLongDateString
    End Sub

    Private Sub btnProducto_Click(sender As Object, e As EventArgs) Handles btnProducto.Click
        FrmProducto.Show()

    End Sub

    Private Sub PanelCabecera_Paint(sender As Object, e As PaintEventArgs) Handles PanelCabecera.Paint

    End Sub

    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Abro la cadena de conexion para poder llegar a la base de datos

        Try
            conexionSql.ConnectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Negocio;Data Source=LAPTOP-68VR45A9\SQLEXPRESS"

            conexionSql.Open()

        Catch ex As Exception

            MsgBox(ex.ToString)

        End Try

    End Sub

    Private Sub btnProveedor_Click(sender As Object, e As EventArgs) Handles btnProveedor.Click
        FrmProveedor.Show()

    End Sub

    Private Sub RubroToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RubroToolStripMenuItem.Click
        FrmRubro.Show()

    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub EstadoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EstadoToolStripMenuItem.Click
        FrmEstado.Show()

    End Sub

    Private Sub CiudadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CiudadesToolStripMenuItem.Click
        FrmCiudad.Show()

    End Sub

    Private Sub CondicionesIVAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CondicionesIVAToolStripMenuItem.Click
        FrmCondicionIVA.Show()

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub
End Class
