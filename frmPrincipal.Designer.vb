<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPrincipal
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_maximizar = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnmaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.MenuVertical = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.btnProveedor = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnProducto = New System.Windows.Forms.Button()
        Me.btnMenu = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblhora = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ParametrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RubroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstadoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CiudadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CondicionesIVAToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tmOcultarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.tmMostrarMenu = New System.Windows.Forms.Timer(Me.components)
        Me.horafecha = New System.Windows.Forms.Timer(Me.components)
        Me.PanelCabecera.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btn_maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuVertical.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelCabecera
        '
        Me.PanelCabecera.BackColor = System.Drawing.Color.RoyalBlue
        Me.PanelCabecera.Controls.Add(Me.Label5)
        Me.PanelCabecera.Controls.Add(Me.Panel3)
        Me.PanelCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelCabecera.Location = New System.Drawing.Point(0, 0)
        Me.PanelCabecera.Name = "PanelCabecera"
        Me.PanelCabecera.Size = New System.Drawing.Size(1100, 40)
        Me.PanelCabecera.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "SISTEMA NEGOCIO"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_maximizar)
        Me.Panel3.Controls.Add(Me.btnRestaurar)
        Me.Panel3.Controls.Add(Me.btnMinimizar)
        Me.Panel3.Controls.Add(Me.btnmaximizar)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(971, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 40)
        Me.Panel3.TabIndex = 0
        '
        'btn_maximizar
        '
        Me.btn_maximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maximizar.Image = Global.Negocio.My.Resources.Resources.maxi
        Me.btn_maximizar.Location = New System.Drawing.Point(53, 8)
        Me.btn_maximizar.Name = "btn_maximizar"
        Me.btn_maximizar.Size = New System.Drawing.Size(25, 25)
        Me.btn_maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btn_maximizar.TabIndex = 9
        Me.btn_maximizar.TabStop = False
        '
        'btnRestaurar
        '
        Me.btnRestaurar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnRestaurar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRestaurar.Image = Global.Negocio.My.Resources.Resources.res
        Me.btnRestaurar.Location = New System.Drawing.Point(53, 8)
        Me.btnRestaurar.Name = "btnRestaurar"
        Me.btnRestaurar.Size = New System.Drawing.Size(25, 25)
        Me.btnRestaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnRestaurar.TabIndex = 10
        Me.btnRestaurar.TabStop = False
        Me.btnRestaurar.Visible = False
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.Negocio.My.Resources.Resources.minimazar
        Me.btnMinimizar.Location = New System.Drawing.Point(10, 8)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 8
        Me.btnMinimizar.TabStop = False
        '
        'btnmaximizar
        '
        Me.btnmaximizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnmaximizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmaximizar.Location = New System.Drawing.Point(53, 8)
        Me.btnmaximizar.Name = "btnmaximizar"
        Me.btnmaximizar.Size = New System.Drawing.Size(25, 25)
        Me.btnmaximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnmaximizar.TabIndex = 9
        Me.btnmaximizar.TabStop = False
        '
        'btnCerrar
        '
        Me.btnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCerrar.Image = Global.Negocio.My.Resources.Resources.cerrar
        Me.btnCerrar.Location = New System.Drawing.Point(93, 8)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(25, 25)
        Me.btnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnCerrar.TabIndex = 7
        Me.btnCerrar.TabStop = False
        '
        'MenuVertical
        '
        Me.MenuVertical.BackColor = System.Drawing.Color.FromArgb(CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer), CType(CType(26, Byte), Integer))
        Me.MenuVertical.Controls.Add(Me.Panel6)
        Me.MenuVertical.Controls.Add(Me.Label2)
        Me.MenuVertical.Controls.Add(Me.Label1)
        Me.MenuVertical.Controls.Add(Me.PictureBox2)
        Me.MenuVertical.Controls.Add(Me.Panel4)
        Me.MenuVertical.Controls.Add(Me.btnProveedor)
        Me.MenuVertical.Controls.Add(Me.Panel1)
        Me.MenuVertical.Controls.Add(Me.btnProducto)
        Me.MenuVertical.Controls.Add(Me.btnMenu)
        Me.MenuVertical.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuVertical.Location = New System.Drawing.Point(0, 40)
        Me.MenuVertical.Name = "MenuVertical"
        Me.MenuVertical.Size = New System.Drawing.Size(220, 540)
        Me.MenuVertical.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.PictureBox1)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.btnexit)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 414)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(220, 126)
        Me.Panel6.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(2, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(216, 18)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "__________________________"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.Negocio.My.Resources.Resources.exit_svgrepo_com
        Me.PictureBox1.Location = New System.Drawing.Point(11, 78)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 41)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel5.Location = New System.Drawing.Point(-1, 73)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(5, 50)
        Me.Panel5.TabIndex = 12
        '
        'btnexit
        '
        Me.btnexit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnexit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexit.FlatAppearance.BorderSize = 0
        Me.btnexit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexit.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnexit.Location = New System.Drawing.Point(2, 73)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(220, 50)
        Me.btnexit.TabIndex = 13
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(66, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Role: Admin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(66, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name: Luis Ron"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Negocio.My.Resources.Resources.user_person_people_6100
        Me.PictureBox2.Location = New System.Drawing.Point(2, 64)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(54, 52)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel4.Location = New System.Drawing.Point(-1, 265)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(5, 50)
        Me.Panel4.TabIndex = 1
        '
        'btnProveedor
        '
        Me.btnProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProveedor.FlatAppearance.BorderSize = 0
        Me.btnProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProveedor.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnProveedor.ForeColor = System.Drawing.Color.White
        Me.btnProveedor.Image = Global.Negocio.My.Resources.Resources.compras
        Me.btnProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProveedor.Location = New System.Drawing.Point(2, 265)
        Me.btnProveedor.Name = "btnProveedor"
        Me.btnProveedor.Size = New System.Drawing.Size(220, 50)
        Me.btnProveedor.TabIndex = 2
        Me.btnProveedor.Text = "Proveedor"
        Me.btnProveedor.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Panel1.Location = New System.Drawing.Point(0, 204)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(5, 50)
        Me.Panel1.TabIndex = 0
        '
        'btnProducto
        '
        Me.btnProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnProducto.FlatAppearance.BorderSize = 0
        Me.btnProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue
        Me.btnProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnProducto.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnProducto.ForeColor = System.Drawing.Color.White
        Me.btnProducto.Image = Global.Negocio.My.Resources.Resources.producto2
        Me.btnProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnProducto.Location = New System.Drawing.Point(3, 204)
        Me.btnProducto.Name = "btnProducto"
        Me.btnProducto.Size = New System.Drawing.Size(220, 50)
        Me.btnProducto.TabIndex = 0
        Me.btnProducto.Text = "Producto"
        Me.btnProducto.UseVisualStyleBackColor = True
        '
        'btnMenu
        '
        Me.btnMenu.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMenu.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMenu.Image = Global.Negocio.My.Resources.Resources.Mobile_Menu_Icon
        Me.btnMenu.Location = New System.Drawing.Point(166, 3)
        Me.btnMenu.Name = "btnMenu"
        Me.btnMenu.Size = New System.Drawing.Size(51, 45)
        Me.btnMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMenu.TabIndex = 0
        Me.btnMenu.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblfecha)
        Me.Panel2.Controls.Add(Me.lblhora)
        Me.Panel2.Controls.Add(Me.MenuStrip1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(220, 40)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(880, 540)
        Me.Panel2.TabIndex = 2
        '
        'lblfecha
        '
        Me.lblfecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Font = New System.Drawing.Font("Century Gothic", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfecha.Location = New System.Drawing.Point(282, 318)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(101, 32)
        Me.lblfecha.TabIndex = 4
        Me.lblfecha.Text = "Label1"
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblhora
        '
        Me.lblhora.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblhora.AutoSize = True
        Me.lblhora.Font = New System.Drawing.Font("Century Gothic", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblhora.Location = New System.Drawing.Point(264, 186)
        Me.lblhora.Name = "lblhora"
        Me.lblhora.Size = New System.Drawing.Size(353, 112)
        Me.lblhora.TabIndex = 3
        Me.lblhora.Text = "Label1"
        Me.lblhora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ParametrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(880, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ParametrosToolStripMenuItem
        '
        Me.ParametrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RubroToolStripMenuItem, Me.EstadoToolStripMenuItem, Me.CiudadesToolStripMenuItem, Me.CondicionesIVAToolStripMenuItem})
        Me.ParametrosToolStripMenuItem.Image = Global.Negocio.My.Resources.Resources._1904675_configuration_edit_gear_options_preferences_setting_settings_122525
        Me.ParametrosToolStripMenuItem.Name = "ParametrosToolStripMenuItem"
        Me.ParametrosToolStripMenuItem.Size = New System.Drawing.Size(109, 20)
        Me.ParametrosToolStripMenuItem.Text = "Parametros"
        '
        'RubroToolStripMenuItem
        '
        Me.RubroToolStripMenuItem.Name = "RubroToolStripMenuItem"
        Me.RubroToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.RubroToolStripMenuItem.Text = "Rubro"
        '
        'EstadoToolStripMenuItem
        '
        Me.EstadoToolStripMenuItem.Name = "EstadoToolStripMenuItem"
        Me.EstadoToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.EstadoToolStripMenuItem.Text = "Estado"
        '
        'CiudadesToolStripMenuItem
        '
        Me.CiudadesToolStripMenuItem.Name = "CiudadesToolStripMenuItem"
        Me.CiudadesToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CiudadesToolStripMenuItem.Text = "Ciudades"
        '
        'CondicionesIVAToolStripMenuItem
        '
        Me.CondicionesIVAToolStripMenuItem.Name = "CondicionesIVAToolStripMenuItem"
        Me.CondicionesIVAToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.CondicionesIVAToolStripMenuItem.Text = "Condiciones IVA"
        '
        'tmOcultarMenu
        '
        '
        'tmMostrarMenu
        '
        '
        'horafecha
        '
        Me.horafecha.Enabled = True
        '
        'frmPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1100, 580)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.MenuVertical)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema De Negocio"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btn_maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuVertical.ResumeLayout(False)
        Me.MenuVertical.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMenu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents MenuVertical As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnmaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents btn_maximizar As PictureBox
    Friend WithEvents btnMenu As PictureBox
    Friend WithEvents tmOcultarMenu As Timer
    Friend WithEvents tmMostrarMenu As Timer
    Friend WithEvents Label5 As Label
    Friend WithEvents btnProducto As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents btnProveedor As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents btnexit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ParametrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RubroToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EstadoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CiudadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CondicionesIVAToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents horafecha As Timer
    Friend WithEvents lblfecha As Label
    Friend WithEvents lblhora As Label
End Class
