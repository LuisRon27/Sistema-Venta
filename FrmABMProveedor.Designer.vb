<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMProveedor
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnmaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregar = New System.Windows.Forms.ToolStripButton()
        Me.cmdsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.lblseñal = New System.Windows.Forms.Label()
        Me.lblCodigoAlternativo = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtApellido = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCuit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtTelefono = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCiudad = New System.Windows.Forms.TextBox()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.cbProvincia = New System.Windows.Forms.ComboBox()
        Me.btnBuscarCiudad = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtContacto = New System.Windows.Forms.TextBox()
        Me.btnBuscarCondicionIva = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCondicionIva = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbActivo = New System.Windows.Forms.ComboBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtIdCiudad = New System.Windows.Forms.TextBox()
        Me.txtIdCondicionIva = New System.Windows.Forms.TextBox()
        Me.PanelCabecera.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.btnBuscarCiudad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscarCondicionIva, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelCabecera.Size = New System.Drawing.Size(859, 40)
        Me.PanelCabecera.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(159, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ABM - Proveedor"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnMinimizar)
        Me.Panel3.Controls.Add(Me.btnmaximizar)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(730, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 40)
        Me.Panel3.TabIndex = 0
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.Negocio.My.Resources.Resources.minimazar
        Me.btnMinimizar.Location = New System.Drawing.Point(53, 8)
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
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregar, Me.cmdsalir, Me.ToolStripSeparator1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 40)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(859, 71)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Cmdagregar
        '
        Me.Cmdagregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdagregar.Image = Global.Negocio.My.Resources.Resources.Aceptar
        Me.Cmdagregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdagregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdagregar.Name = "Cmdagregar"
        Me.Cmdagregar.Size = New System.Drawing.Size(68, 68)
        Me.Cmdagregar.Text = "Agregar"
        Me.Cmdagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdsalir
        '
        Me.cmdsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalir.Image = Global.Negocio.My.Resources.Resources.Cancelar
        Me.cmdsalir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalir.Name = "cmdsalir"
        Me.cmdsalir.Size = New System.Drawing.Size(68, 68)
        Me.cmdsalir.Text = "Salir"
        Me.cmdsalir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 23)
        '
        'lblseñal
        '
        Me.lblseñal.AutoSize = True
        Me.lblseñal.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblseñal.ForeColor = System.Drawing.Color.Black
        Me.lblseñal.Location = New System.Drawing.Point(743, 82)
        Me.lblseñal.Name = "lblseñal"
        Me.lblseñal.Size = New System.Drawing.Size(65, 18)
        Me.lblseñal.TabIndex = 45
        Me.lblseñal.Text = "Label10"
        '
        'lblCodigoAlternativo
        '
        Me.lblCodigoAlternativo.AutoSize = True
        Me.lblCodigoAlternativo.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblCodigoAlternativo.ForeColor = System.Drawing.Color.Black
        Me.lblCodigoAlternativo.Location = New System.Drawing.Point(56, 156)
        Me.lblCodigoAlternativo.Name = "lblCodigoAlternativo"
        Me.lblCodigoAlternativo.Size = New System.Drawing.Size(68, 20)
        Me.lblCodigoAlternativo.TabIndex = 60
        Me.lblCodigoAlternativo.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.Color.Azure
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtNombre.Location = New System.Drawing.Point(60, 179)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(267, 26)
        Me.txtNombre.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(528, 156)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 20)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Apellido"
        '
        'txtApellido
        '
        Me.txtApellido.BackColor = System.Drawing.Color.Azure
        Me.txtApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtApellido.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtApellido.Location = New System.Drawing.Point(532, 179)
        Me.txtApellido.Name = "txtApellido"
        Me.txtApellido.Size = New System.Drawing.Size(267, 26)
        Me.txtApellido.TabIndex = 61
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(330, 126)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(36, 20)
        Me.lblID.TabIndex = 64
        Me.lblID.Text = "#ID"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.Azure
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtid.Location = New System.Drawing.Point(373, 124)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(123, 26)
        Me.txtid.TabIndex = 63
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(56, 238)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 20)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "Cuit"
        '
        'txtCuit
        '
        Me.txtCuit.BackColor = System.Drawing.Color.Azure
        Me.txtCuit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCuit.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtCuit.Location = New System.Drawing.Point(60, 261)
        Me.txtCuit.Name = "txtCuit"
        Me.txtCuit.Size = New System.Drawing.Size(267, 26)
        Me.txtCuit.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(528, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 20)
        Me.Label3.TabIndex = 68
        Me.Label3.Text = "Direccion"
        '
        'txtDireccion
        '
        Me.txtDireccion.BackColor = System.Drawing.Color.Azure
        Me.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDireccion.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtDireccion.Location = New System.Drawing.Point(532, 261)
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.Size = New System.Drawing.Size(267, 26)
        Me.txtDireccion.TabIndex = 67
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(56, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Telefono"
        '
        'txtTelefono
        '
        Me.txtTelefono.BackColor = System.Drawing.Color.Azure
        Me.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTelefono.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtTelefono.Location = New System.Drawing.Point(60, 349)
        Me.txtTelefono.Name = "txtTelefono"
        Me.txtTelefono.Size = New System.Drawing.Size(267, 26)
        Me.txtTelefono.TabIndex = 69
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(528, 326)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 20)
        Me.Label6.TabIndex = 72
        Me.Label6.Text = "Email"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.Azure
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtEmail.Location = New System.Drawing.Point(532, 349)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(267, 26)
        Me.txtEmail.TabIndex = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(56, 420)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 20)
        Me.Label7.TabIndex = 74
        Me.Label7.Text = "Ciudad"
        '
        'txtCiudad
        '
        Me.txtCiudad.BackColor = System.Drawing.Color.Azure
        Me.txtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCiudad.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtCiudad.Location = New System.Drawing.Point(60, 443)
        Me.txtCiudad.Name = "txtCiudad"
        Me.txtCiudad.Size = New System.Drawing.Size(267, 26)
        Me.txtCiudad.TabIndex = 73
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblIVA.ForeColor = System.Drawing.Color.Black
        Me.lblIVA.Location = New System.Drawing.Point(528, 420)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(78, 20)
        Me.lblIVA.TabIndex = 84
        Me.lblIVA.Text = "Provincia"
        '
        'cbProvincia
        '
        Me.cbProvincia.BackColor = System.Drawing.Color.Azure
        Me.cbProvincia.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbProvincia.FormattingEnabled = True
        Me.cbProvincia.Items.AddRange(New Object() {"Buenos Aires", "Catamarca", "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos", "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza", "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan", "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tierra del Fuego, Antártida e Isla del Atlántico Sur", "Tucumán"})
        Me.cbProvincia.Location = New System.Drawing.Point(532, 443)
        Me.cbProvincia.Name = "cbProvincia"
        Me.cbProvincia.Size = New System.Drawing.Size(267, 28)
        Me.cbProvincia.TabIndex = 83
        '
        'btnBuscarCiudad
        '
        Me.btnBuscarCiudad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarCiudad.Image = Global.Negocio.My.Resources.Resources.find_search_document_6167
        Me.btnBuscarCiudad.Location = New System.Drawing.Point(342, 437)
        Me.btnBuscarCiudad.Name = "btnBuscarCiudad"
        Me.btnBuscarCiudad.Size = New System.Drawing.Size(32, 32)
        Me.btnBuscarCiudad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnBuscarCiudad.TabIndex = 85
        Me.btnBuscarCiudad.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(528, 511)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 20)
        Me.Label8.TabIndex = 87
        Me.Label8.Text = "Contacto"
        '
        'txtContacto
        '
        Me.txtContacto.BackColor = System.Drawing.Color.Azure
        Me.txtContacto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContacto.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtContacto.Location = New System.Drawing.Point(532, 534)
        Me.txtContacto.Name = "txtContacto"
        Me.txtContacto.Size = New System.Drawing.Size(267, 26)
        Me.txtContacto.TabIndex = 86
        '
        'btnBuscarCondicionIva
        '
        Me.btnBuscarCondicionIva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarCondicionIva.Image = Global.Negocio.My.Resources.Resources.find_search_document_6167
        Me.btnBuscarCondicionIva.Location = New System.Drawing.Point(342, 528)
        Me.btnBuscarCondicionIva.Name = "btnBuscarCondicionIva"
        Me.btnBuscarCondicionIva.Size = New System.Drawing.Size(32, 32)
        Me.btnBuscarCondicionIva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnBuscarCondicionIva.TabIndex = 90
        Me.btnBuscarCondicionIva.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(56, 511)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 20)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Condicion IVA"
        '
        'txtCondicionIva
        '
        Me.txtCondicionIva.BackColor = System.Drawing.Color.Azure
        Me.txtCondicionIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCondicionIva.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtCondicionIva.Location = New System.Drawing.Point(60, 534)
        Me.txtCondicionIva.Name = "txtCondicionIva"
        Me.txtCondicionIva.Size = New System.Drawing.Size(267, 26)
        Me.txtCondicionIva.TabIndex = 88
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(401, 598)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(58, 20)
        Me.Label10.TabIndex = 92
        Me.Label10.Text = "Activo"
        '
        'cbActivo
        '
        Me.cbActivo.BackColor = System.Drawing.Color.Azure
        Me.cbActivo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbActivo.FormattingEnabled = True
        Me.cbActivo.Items.AddRange(New Object() {"Asset", "Inactive"})
        Me.cbActivo.Location = New System.Drawing.Point(373, 621)
        Me.cbActivo.Name = "cbActivo"
        Me.cbActivo.Size = New System.Drawing.Size(123, 28)
        Me.cbActivo.TabIndex = 91
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.Location = New System.Drawing.Point(56, 656)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(121, 20)
        Me.lblDescripcion.TabIndex = 94
        Me.lblDescripcion.Text = "Observaciones"
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.Color.Azure
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtObservaciones.Location = New System.Drawing.Point(60, 679)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(739, 55)
        Me.txtObservaciones.TabIndex = 93
        '
        'txtIdCiudad
        '
        Me.txtIdCiudad.BackColor = System.Drawing.Color.Azure
        Me.txtIdCiudad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCiudad.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtIdCiudad.Location = New System.Drawing.Point(380, 443)
        Me.txtIdCiudad.Name = "txtIdCiudad"
        Me.txtIdCiudad.Size = New System.Drawing.Size(102, 26)
        Me.txtIdCiudad.TabIndex = 95
        Me.txtIdCiudad.Visible = False
        '
        'txtIdCondicionIva
        '
        Me.txtIdCondicionIva.BackColor = System.Drawing.Color.Azure
        Me.txtIdCondicionIva.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdCondicionIva.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtIdCondicionIva.Location = New System.Drawing.Point(380, 534)
        Me.txtIdCondicionIva.Name = "txtIdCondicionIva"
        Me.txtIdCondicionIva.Size = New System.Drawing.Size(102, 26)
        Me.txtIdCondicionIva.TabIndex = 96
        Me.txtIdCondicionIva.Visible = False
        '
        'FrmABMProveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(859, 778)
        Me.Controls.Add(Me.txtIdCondicionIva)
        Me.Controls.Add(Me.txtIdCiudad)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cbActivo)
        Me.Controls.Add(Me.btnBuscarCondicionIva)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCondicionIva)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtContacto)
        Me.Controls.Add(Me.btnBuscarCiudad)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.cbProvincia)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtCiudad)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtTelefono)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDireccion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtCuit)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtApellido)
        Me.Controls.Add(Me.lblCodigoAlternativo)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblseñal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmABMProveedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmABMProveedor"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.btnBuscarCiudad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscarCondicionIva, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnmaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregar As ToolStripButton
    Friend WithEvents cmdsalir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents lblseñal As Label
    Friend WithEvents lblCodigoAlternativo As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtApellido As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents txtid As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCuit As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCiudad As TextBox
    Friend WithEvents lblIVA As Label
    Friend WithEvents cbProvincia As ComboBox
    Friend WithEvents btnBuscarCiudad As PictureBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txtContacto As TextBox
    Friend WithEvents btnBuscarCondicionIva As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCondicionIva As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents cbActivo As ComboBox
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtObservaciones As TextBox
    Friend WithEvents txtIdCiudad As TextBox
    Friend WithEvents txtIdCondicionIva As TextBox
End Class
