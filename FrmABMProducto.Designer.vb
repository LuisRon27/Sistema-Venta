<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmABMProducto
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
        Me.txtid = New System.Windows.Forms.TextBox()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblcosto = New System.Windows.Forms.Label()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.lblCodigoAlternativo = New System.Windows.Forms.Label()
        Me.txtCodigoAlternativo = New System.Windows.Forms.TextBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.txtRubro = New System.Windows.Forms.TextBox()
        Me.lblRubro = New System.Windows.Forms.Label()
        Me.txtEstado = New System.Windows.Forms.TextBox()
        Me.lblestado = New System.Windows.Forms.Label()
        Me.dtFechaCarga = New System.Windows.Forms.DateTimePicker()
        Me.lblFechaCarga = New System.Windows.Forms.Label()
        Me.lblFechaActualizacion = New System.Windows.Forms.Label()
        Me.dtFechaActualizacion = New System.Windows.Forms.DateTimePicker()
        Me.cbIVA = New System.Windows.Forms.ComboBox()
        Me.lblIVA = New System.Windows.Forms.Label()
        Me.txtImagen = New System.Windows.Forms.TextBox()
        Me.lblImagen = New System.Windows.Forms.Label()
        Me.btnBuscarImagen = New System.Windows.Forms.PictureBox()
        Me.btnBuscarEstado = New System.Windows.Forms.PictureBox()
        Me.btnBuscarRubro = New System.Windows.Forms.PictureBox()
        Me.btnBuscarProveedor = New System.Windows.Forms.PictureBox()
        Me.txtIdProveedor = New System.Windows.Forms.TextBox()
        Me.txtIdRubro = New System.Windows.Forms.TextBox()
        Me.txtIdEstado = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtPrecioVenta = New System.Windows.Forms.TextBox()
        Me.PanelCabecera.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.btnBuscarImagen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscarEstado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscarRubro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnBuscarProveedor, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelCabecera.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(150, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "ABM - Producto"
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
        Me.ToolStrip1.TabIndex = 5
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
        Me.lblseñal.Location = New System.Drawing.Point(753, 82)
        Me.lblseñal.Name = "lblseñal"
        Me.lblseñal.Size = New System.Drawing.Size(65, 18)
        Me.lblseñal.TabIndex = 44
        Me.lblseñal.Text = "Label10"
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.Azure
        Me.txtid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtid.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtid.Location = New System.Drawing.Point(369, 114)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(123, 26)
        Me.txtid.TabIndex = 45
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblID.ForeColor = System.Drawing.Color.Black
        Me.lblID.Location = New System.Drawing.Point(326, 116)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(36, 20)
        Me.lblID.TabIndex = 46
        Me.lblID.Text = "#ID"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblDescripcion.ForeColor = System.Drawing.Color.Black
        Me.lblDescripcion.Location = New System.Drawing.Point(66, 168)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 20)
        Me.lblDescripcion.TabIndex = 48
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.Color.Azure
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtDescripcion.Location = New System.Drawing.Point(70, 191)
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(718, 55)
        Me.txtDescripcion.TabIndex = 47
        '
        'lblProveedor
        '
        Me.lblProveedor.AutoSize = True
        Me.lblProveedor.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblProveedor.ForeColor = System.Drawing.Color.Black
        Me.lblProveedor.Location = New System.Drawing.Point(479, 273)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(88, 20)
        Me.lblProveedor.TabIndex = 50
        Me.lblProveedor.Text = "Proveedor"
        '
        'lblcosto
        '
        Me.lblcosto.AutoSize = True
        Me.lblcosto.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblcosto.ForeColor = System.Drawing.Color.Black
        Me.lblcosto.Location = New System.Drawing.Point(66, 364)
        Me.lblcosto.Name = "lblcosto"
        Me.lblcosto.Size = New System.Drawing.Size(52, 20)
        Me.lblcosto.TabIndex = 54
        Me.lblcosto.Text = "Costo"
        '
        'txtcosto
        '
        Me.txtcosto.BackColor = System.Drawing.Color.Azure
        Me.txtcosto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcosto.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtcosto.Location = New System.Drawing.Point(70, 387)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(267, 26)
        Me.txtcosto.TabIndex = 53
        '
        'lblCodigoAlternativo
        '
        Me.lblCodigoAlternativo.AutoSize = True
        Me.lblCodigoAlternativo.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblCodigoAlternativo.ForeColor = System.Drawing.Color.Black
        Me.lblCodigoAlternativo.Location = New System.Drawing.Point(66, 273)
        Me.lblCodigoAlternativo.Name = "lblCodigoAlternativo"
        Me.lblCodigoAlternativo.Size = New System.Drawing.Size(121, 20)
        Me.lblCodigoAlternativo.TabIndex = 58
        Me.lblCodigoAlternativo.Text = "#ID Alternatico"
        '
        'txtCodigoAlternativo
        '
        Me.txtCodigoAlternativo.BackColor = System.Drawing.Color.Azure
        Me.txtCodigoAlternativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoAlternativo.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtCodigoAlternativo.Location = New System.Drawing.Point(70, 296)
        Me.txtCodigoAlternativo.Name = "txtCodigoAlternativo"
        Me.txtCodigoAlternativo.Size = New System.Drawing.Size(267, 26)
        Me.txtCodigoAlternativo.TabIndex = 57
        '
        'txtproveedor
        '
        Me.txtproveedor.BackColor = System.Drawing.Color.Azure
        Me.txtproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtproveedor.Location = New System.Drawing.Point(483, 296)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(267, 26)
        Me.txtproveedor.TabIndex = 69
        '
        'txtRubro
        '
        Me.txtRubro.BackColor = System.Drawing.Color.Azure
        Me.txtRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRubro.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtRubro.Location = New System.Drawing.Point(70, 552)
        Me.txtRubro.Name = "txtRubro"
        Me.txtRubro.Size = New System.Drawing.Size(267, 26)
        Me.txtRubro.TabIndex = 72
        '
        'lblRubro
        '
        Me.lblRubro.AutoSize = True
        Me.lblRubro.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblRubro.ForeColor = System.Drawing.Color.Black
        Me.lblRubro.Location = New System.Drawing.Point(66, 529)
        Me.lblRubro.Name = "lblRubro"
        Me.lblRubro.Size = New System.Drawing.Size(52, 20)
        Me.lblRubro.TabIndex = 71
        Me.lblRubro.Text = "Rubro"
        '
        'txtEstado
        '
        Me.txtEstado.BackColor = System.Drawing.Color.Azure
        Me.txtEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEstado.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtEstado.Location = New System.Drawing.Point(483, 552)
        Me.txtEstado.Name = "txtEstado"
        Me.txtEstado.Size = New System.Drawing.Size(267, 26)
        Me.txtEstado.TabIndex = 75
        '
        'lblestado
        '
        Me.lblestado.AutoSize = True
        Me.lblestado.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblestado.ForeColor = System.Drawing.Color.Black
        Me.lblestado.Location = New System.Drawing.Point(479, 529)
        Me.lblestado.Name = "lblestado"
        Me.lblestado.Size = New System.Drawing.Size(58, 20)
        Me.lblestado.TabIndex = 74
        Me.lblestado.Text = "Estado"
        '
        'dtFechaCarga
        '
        Me.dtFechaCarga.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.dtFechaCarga.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.dtFechaCarga.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaCarga.Location = New System.Drawing.Point(70, 648)
        Me.dtFechaCarga.Name = "dtFechaCarga"
        Me.dtFechaCarga.Size = New System.Drawing.Size(267, 26)
        Me.dtFechaCarga.TabIndex = 77
        '
        'lblFechaCarga
        '
        Me.lblFechaCarga.AutoSize = True
        Me.lblFechaCarga.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblFechaCarga.ForeColor = System.Drawing.Color.Black
        Me.lblFechaCarga.Location = New System.Drawing.Point(66, 619)
        Me.lblFechaCarga.Name = "lblFechaCarga"
        Me.lblFechaCarga.Size = New System.Drawing.Size(106, 20)
        Me.lblFechaCarga.TabIndex = 78
        Me.lblFechaCarga.Text = "Fecha Carga"
        '
        'lblFechaActualizacion
        '
        Me.lblFechaActualizacion.AutoSize = True
        Me.lblFechaActualizacion.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblFechaActualizacion.ForeColor = System.Drawing.Color.Black
        Me.lblFechaActualizacion.Location = New System.Drawing.Point(479, 619)
        Me.lblFechaActualizacion.Name = "lblFechaActualizacion"
        Me.lblFechaActualizacion.Size = New System.Drawing.Size(158, 20)
        Me.lblFechaActualizacion.TabIndex = 80
        Me.lblFechaActualizacion.Text = "Fecha Actualizacion"
        '
        'dtFechaActualizacion
        '
        Me.dtFechaActualizacion.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(94, Byte), Integer), CType(CType(129, Byte), Integer))
        Me.dtFechaActualizacion.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.dtFechaActualizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtFechaActualizacion.Location = New System.Drawing.Point(483, 648)
        Me.dtFechaActualizacion.Name = "dtFechaActualizacion"
        Me.dtFechaActualizacion.Size = New System.Drawing.Size(267, 26)
        Me.dtFechaActualizacion.TabIndex = 79
        '
        'cbIVA
        '
        Me.cbIVA.BackColor = System.Drawing.Color.Azure
        Me.cbIVA.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.cbIVA.FormattingEnabled = True
        Me.cbIVA.Items.AddRange(New Object() {"10", "15", "16", "20"})
        Me.cbIVA.Location = New System.Drawing.Point(483, 387)
        Me.cbIVA.Name = "cbIVA"
        Me.cbIVA.Size = New System.Drawing.Size(267, 28)
        Me.cbIVA.TabIndex = 81
        '
        'lblIVA
        '
        Me.lblIVA.AutoSize = True
        Me.lblIVA.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblIVA.ForeColor = System.Drawing.Color.Black
        Me.lblIVA.Location = New System.Drawing.Point(479, 364)
        Me.lblIVA.Name = "lblIVA"
        Me.lblIVA.Size = New System.Drawing.Size(52, 20)
        Me.lblIVA.TabIndex = 82
        Me.lblIVA.Text = "% IVA"
        '
        'txtImagen
        '
        Me.txtImagen.BackColor = System.Drawing.Color.Azure
        Me.txtImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtImagen.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtImagen.Location = New System.Drawing.Point(269, 734)
        Me.txtImagen.Name = "txtImagen"
        Me.txtImagen.Size = New System.Drawing.Size(267, 26)
        Me.txtImagen.TabIndex = 84
        '
        'lblImagen
        '
        Me.lblImagen.AutoSize = True
        Me.lblImagen.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblImagen.ForeColor = System.Drawing.Color.Black
        Me.lblImagen.Location = New System.Drawing.Point(265, 711)
        Me.lblImagen.Name = "lblImagen"
        Me.lblImagen.Size = New System.Drawing.Size(66, 20)
        Me.lblImagen.TabIndex = 83
        Me.lblImagen.Text = "Imagen"
        '
        'btnBuscarImagen
        '
        Me.btnBuscarImagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarImagen.Image = Global.Negocio.My.Resources.Resources.imageup_imagen_12892
        Me.btnBuscarImagen.Location = New System.Drawing.Point(542, 729)
        Me.btnBuscarImagen.Name = "btnBuscarImagen"
        Me.btnBuscarImagen.Size = New System.Drawing.Size(32, 32)
        Me.btnBuscarImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnBuscarImagen.TabIndex = 85
        Me.btnBuscarImagen.TabStop = False
        '
        'btnBuscarEstado
        '
        Me.btnBuscarEstado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarEstado.Image = Global.Negocio.My.Resources.Resources.find_search_document_6167
        Me.btnBuscarEstado.Location = New System.Drawing.Point(757, 546)
        Me.btnBuscarEstado.Name = "btnBuscarEstado"
        Me.btnBuscarEstado.Size = New System.Drawing.Size(32, 32)
        Me.btnBuscarEstado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnBuscarEstado.TabIndex = 76
        Me.btnBuscarEstado.TabStop = False
        '
        'btnBuscarRubro
        '
        Me.btnBuscarRubro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarRubro.Image = Global.Negocio.My.Resources.Resources.find_search_document_6167
        Me.btnBuscarRubro.Location = New System.Drawing.Point(344, 546)
        Me.btnBuscarRubro.Name = "btnBuscarRubro"
        Me.btnBuscarRubro.Size = New System.Drawing.Size(32, 32)
        Me.btnBuscarRubro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnBuscarRubro.TabIndex = 73
        Me.btnBuscarRubro.TabStop = False
        '
        'btnBuscarProveedor
        '
        Me.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBuscarProveedor.Image = Global.Negocio.My.Resources.Resources.find_search_document_6167
        Me.btnBuscarProveedor.Location = New System.Drawing.Point(757, 290)
        Me.btnBuscarProveedor.Name = "btnBuscarProveedor"
        Me.btnBuscarProveedor.Size = New System.Drawing.Size(32, 32)
        Me.btnBuscarProveedor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.btnBuscarProveedor.TabIndex = 70
        Me.btnBuscarProveedor.TabStop = False
        '
        'txtIdProveedor
        '
        Me.txtIdProveedor.BackColor = System.Drawing.Color.Azure
        Me.txtIdProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdProveedor.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtIdProveedor.Location = New System.Drawing.Point(411, 296)
        Me.txtIdProveedor.Name = "txtIdProveedor"
        Me.txtIdProveedor.Size = New System.Drawing.Size(66, 26)
        Me.txtIdProveedor.TabIndex = 86
        Me.txtIdProveedor.Visible = False
        '
        'txtIdRubro
        '
        Me.txtIdRubro.BackColor = System.Drawing.Color.Azure
        Me.txtIdRubro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdRubro.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtIdRubro.Location = New System.Drawing.Point(382, 552)
        Me.txtIdRubro.Name = "txtIdRubro"
        Me.txtIdRubro.Size = New System.Drawing.Size(66, 26)
        Me.txtIdRubro.TabIndex = 87
        Me.txtIdRubro.Visible = False
        '
        'txtIdEstado
        '
        Me.txtIdEstado.BackColor = System.Drawing.Color.Azure
        Me.txtIdEstado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtIdEstado.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtIdEstado.Location = New System.Drawing.Point(792, 551)
        Me.txtIdEstado.Name = "txtIdEstado"
        Me.txtIdEstado.Size = New System.Drawing.Size(66, 26)
        Me.txtIdEstado.TabIndex = 88
        Me.txtIdEstado.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(479, 440)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.Color.Azure
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtCantidad.Location = New System.Drawing.Point(483, 463)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(267, 26)
        Me.txtCantidad.TabIndex = 89
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(66, 440)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 20)
        Me.Label2.TabIndex = 92
        Me.Label2.Text = "Precio Venta"
        '
        'txtPrecioVenta
        '
        Me.txtPrecioVenta.BackColor = System.Drawing.Color.Azure
        Me.txtPrecioVenta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPrecioVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtPrecioVenta.Location = New System.Drawing.Point(70, 463)
        Me.txtPrecioVenta.Name = "txtPrecioVenta"
        Me.txtPrecioVenta.Size = New System.Drawing.Size(267, 26)
        Me.txtPrecioVenta.TabIndex = 91
        '
        'FrmABMProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(859, 788)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPrecioVenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.txtIdEstado)
        Me.Controls.Add(Me.txtIdRubro)
        Me.Controls.Add(Me.txtIdProveedor)
        Me.Controls.Add(Me.btnBuscarImagen)
        Me.Controls.Add(Me.txtImagen)
        Me.Controls.Add(Me.lblImagen)
        Me.Controls.Add(Me.lblIVA)
        Me.Controls.Add(Me.cbIVA)
        Me.Controls.Add(Me.lblFechaActualizacion)
        Me.Controls.Add(Me.dtFechaActualizacion)
        Me.Controls.Add(Me.lblFechaCarga)
        Me.Controls.Add(Me.dtFechaCarga)
        Me.Controls.Add(Me.btnBuscarEstado)
        Me.Controls.Add(Me.txtEstado)
        Me.Controls.Add(Me.lblestado)
        Me.Controls.Add(Me.btnBuscarRubro)
        Me.Controls.Add(Me.txtRubro)
        Me.Controls.Add(Me.lblRubro)
        Me.Controls.Add(Me.btnBuscarProveedor)
        Me.Controls.Add(Me.txtproveedor)
        Me.Controls.Add(Me.lblCodigoAlternativo)
        Me.Controls.Add(Me.txtCodigoAlternativo)
        Me.Controls.Add(Me.lblcosto)
        Me.Controls.Add(Me.txtcosto)
        Me.Controls.Add(Me.lblProveedor)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblID)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.lblseñal)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmABMProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmABMProducto"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.btnBuscarImagen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscarEstado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscarRubro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnBuscarProveedor, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents txtid As TextBox
    Friend WithEvents lblID As Label
    Friend WithEvents lblDescripcion As Label
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents lblProveedor As Label
    Friend WithEvents lblcosto As Label
    Friend WithEvents txtcosto As TextBox
    Friend WithEvents lblCodigoAlternativo As Label
    Friend WithEvents txtCodigoAlternativo As TextBox
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents btnBuscarProveedor As PictureBox
    Friend WithEvents btnBuscarRubro As PictureBox
    Friend WithEvents txtRubro As TextBox
    Friend WithEvents lblRubro As Label
    Friend WithEvents btnBuscarEstado As PictureBox
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents lblestado As Label
    Friend WithEvents dtFechaCarga As DateTimePicker
    Friend WithEvents lblFechaCarga As Label
    Friend WithEvents lblFechaActualizacion As Label
    Friend WithEvents dtFechaActualizacion As DateTimePicker
    Friend WithEvents cbIVA As ComboBox
    Friend WithEvents lblIVA As Label
    Friend WithEvents btnBuscarImagen As PictureBox
    Friend WithEvents txtImagen As TextBox
    Friend WithEvents lblImagen As Label
    Friend WithEvents txtIdProveedor As TextBox
    Friend WithEvents txtIdRubro As TextBox
    Friend WithEvents txtIdEstado As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtPrecioVenta As TextBox
End Class
