<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProducto
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.PanelCabecera = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_maximizar = New System.Windows.Forms.PictureBox()
        Me.btnRestaurar = New System.Windows.Forms.PictureBox()
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnmaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.GrillaProducto = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregar = New System.Windows.Forms.ToolStripButton()
        Me.CmdModificar = New System.Windows.Forms.ToolStripButton()
        Me.Cmdeliminar = New System.Windows.Forms.ToolStripButton()
        Me.cmdsalir1 = New System.Windows.Forms.ToolStripButton()
        Me.txtbusqueda = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ID_Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodigoAlternativo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Carga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_Actualizacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Porcentaje_IVA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Imagen = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdProveedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdRubro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdEstado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelCabecera.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btn_maximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GrillaProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelCabecera.Size = New System.Drawing.Size(1386, 40)
        Me.PanelCabecera.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Producto"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_maximizar)
        Me.Panel3.Controls.Add(Me.btnRestaurar)
        Me.Panel3.Controls.Add(Me.btnMinimizar)
        Me.Panel3.Controls.Add(Me.btnmaximizar)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1257, 0)
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
        'GrillaProducto
        '
        Me.GrillaProducto.AllowUserToAddRows = False
        Me.GrillaProducto.BackgroundColor = System.Drawing.Color.White
        Me.GrillaProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrillaProducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GrillaProducto.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaProducto.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaProducto.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_Producto, Me.Descripcion, Me.CodigoAlternativo, Me.Proveedor, Me.Costo, Me.Rubro, Me.Estado, Me.Fecha_Carga, Me.Fecha_Actualizacion, Me.Porcentaje_IVA, Me.Imagen, Me.IdProveedor, Me.IdRubro, Me.IdEstado})
        Me.GrillaProducto.EnableHeadersVisualStyles = False
        Me.GrillaProducto.GridColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GrillaProducto.Location = New System.Drawing.Point(25, 131)
        Me.GrillaProducto.Name = "GrillaProducto"
        Me.GrillaProducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaProducto.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.GrillaProducto.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GrillaProducto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GrillaProducto.Size = New System.Drawing.Size(1254, 496)
        Me.GrillaProducto.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregar, Me.CmdModificar, Me.Cmdeliminar, Me.cmdsalir1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(1300, 128)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(69, 286)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Cmdagregar
        '
        Me.Cmdagregar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdagregar.Image = Global.Negocio.My.Resources.Resources.businesspackage_additionalpackage_box_add_insert_negoci_2335__1_
        Me.Cmdagregar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdagregar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdagregar.Name = "Cmdagregar"
        Me.Cmdagregar.Size = New System.Drawing.Size(67, 68)
        Me.Cmdagregar.Text = "Agregar"
        Me.Cmdagregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'CmdModificar
        '
        Me.CmdModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdModificar.Image = Global.Negocio.My.Resources.Resources.documentediting_editdocuments_text_documentedi_2820
        Me.CmdModificar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmdModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdModificar.Name = "CmdModificar"
        Me.CmdModificar.Size = New System.Drawing.Size(67, 68)
        Me.CmdModificar.Text = "Modificar"
        Me.CmdModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'Cmdeliminar
        '
        Me.Cmdeliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Cmdeliminar.Image = Global.Negocio.My.Resources.Resources.iconfinder_trash_4341321_120557
        Me.Cmdeliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Cmdeliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Cmdeliminar.Name = "Cmdeliminar"
        Me.Cmdeliminar.Size = New System.Drawing.Size(67, 68)
        Me.Cmdeliminar.Text = "Eliminar"
        Me.Cmdeliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdsalir1
        '
        Me.cmdsalir1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalir1.Image = Global.Negocio.My.Resources.Resources.Exit_Page_icon_icons_com_53732
        Me.cmdsalir1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdsalir1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.cmdsalir1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.cmdsalir1.Name = "cmdsalir1"
        Me.cmdsalir1.Size = New System.Drawing.Size(67, 68)
        Me.cmdsalir1.Text = "Salir"
        '
        'txtbusqueda
        '
        Me.txtbusqueda.BackColor = System.Drawing.Color.White
        Me.txtbusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbusqueda.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.txtbusqueda.Location = New System.Drawing.Point(576, 68)
        Me.txtbusqueda.Name = "txtbusqueda"
        Me.txtbusqueda.Size = New System.Drawing.Size(216, 26)
        Me.txtbusqueda.TabIndex = 5
        Me.txtbusqueda.Text = "Buscar..."
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Negocio.My.Resources.Resources.find_search_document_6167
        Me.PictureBox1.Location = New System.Drawing.Point(800, 64)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 32)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'ID_Producto
        '
        Me.ID_Producto.HeaderText = "#"
        Me.ID_Producto.Name = "ID_Producto"
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'CodigoAlternativo
        '
        Me.CodigoAlternativo.HeaderText = "Codigo Alternativo"
        Me.CodigoAlternativo.Name = "CodigoAlternativo"
        '
        'Proveedor
        '
        Me.Proveedor.HeaderText = "Proveedor"
        Me.Proveedor.Name = "Proveedor"
        '
        'Costo
        '
        Me.Costo.HeaderText = "Costo"
        Me.Costo.Name = "Costo"
        '
        'Rubro
        '
        Me.Rubro.HeaderText = "Rubro"
        Me.Rubro.Name = "Rubro"
        '
        'Estado
        '
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        '
        'Fecha_Carga
        '
        Me.Fecha_Carga.HeaderText = "Fecha Carga"
        Me.Fecha_Carga.Name = "Fecha_Carga"
        '
        'Fecha_Actualizacion
        '
        Me.Fecha_Actualizacion.HeaderText = "Fecha Act."
        Me.Fecha_Actualizacion.Name = "Fecha_Actualizacion"
        '
        'Porcentaje_IVA
        '
        Me.Porcentaje_IVA.HeaderText = "% IVA"
        Me.Porcentaje_IVA.Name = "Porcentaje_IVA"
        '
        'Imagen
        '
        Me.Imagen.HeaderText = "Imagen"
        Me.Imagen.Name = "Imagen"
        Me.Imagen.Visible = False
        '
        'IdProveedor
        '
        Me.IdProveedor.HeaderText = "IdProveedor"
        Me.IdProveedor.Name = "IdProveedor"
        Me.IdProveedor.Visible = False
        '
        'IdRubro
        '
        Me.IdRubro.HeaderText = "IdRubro"
        Me.IdRubro.Name = "IdRubro"
        Me.IdRubro.Visible = False
        '
        'IdEstado
        '
        Me.IdEstado.HeaderText = "IdEstado"
        Me.IdEstado.Name = "IdEstado"
        Me.IdEstado.Visible = False
        '
        'FrmProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1386, 662)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtbusqueda)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GrillaProducto)
        Me.Controls.Add(Me.PanelCabecera)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmProducto"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btn_maximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnRestaurar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GrillaProducto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_maximizar As PictureBox
    Friend WithEvents btnRestaurar As PictureBox
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnmaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents GrillaProducto As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregar As ToolStripButton
    Friend WithEvents CmdModificar As ToolStripButton
    Friend WithEvents Cmdeliminar As ToolStripButton
    Friend WithEvents cmdsalir1 As ToolStripButton
    Friend WithEvents txtbusqueda As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ID_Producto As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents CodigoAlternativo As DataGridViewTextBoxColumn
    Friend WithEvents Proveedor As DataGridViewTextBoxColumn
    Friend WithEvents Costo As DataGridViewTextBoxColumn
    Friend WithEvents Rubro As DataGridViewTextBoxColumn
    Friend WithEvents Estado As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Carga As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Actualizacion As DataGridViewTextBoxColumn
    Friend WithEvents Porcentaje_IVA As DataGridViewTextBoxColumn
    Friend WithEvents Imagen As DataGridViewTextBoxColumn
    Friend WithEvents IdProveedor As DataGridViewTextBoxColumn
    Friend WithEvents IdRubro As DataGridViewTextBoxColumn
    Friend WithEvents IdEstado As DataGridViewTextBoxColumn
End Class
