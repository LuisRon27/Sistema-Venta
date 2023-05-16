<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCondicionIVA
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
        Me.btnMinimizar = New System.Windows.Forms.PictureBox()
        Me.btnmaximizar = New System.Windows.Forms.PictureBox()
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.lblSeñalBusqueda = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Cmdagregar = New System.Windows.Forms.ToolStripButton()
        Me.CmdModificar = New System.Windows.Forms.ToolStripButton()
        Me.Cmdeliminar = New System.Windows.Forms.ToolStripButton()
        Me.cmdsalir1 = New System.Windows.Forms.ToolStripButton()
        Me.GrillaCondicionIVA = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Descripcion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Activo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.PanelCabecera.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.GrillaCondicionIVA, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.PanelCabecera.Size = New System.Drawing.Size(696, 40)
        Me.PanelCabecera.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(137, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Condicion IVA"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnMinimizar)
        Me.Panel3.Controls.Add(Me.btnmaximizar)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(567, 0)
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
        'lblSeñalBusqueda
        '
        Me.lblSeñalBusqueda.AutoSize = True
        Me.lblSeñalBusqueda.Location = New System.Drawing.Point(36, 85)
        Me.lblSeñalBusqueda.Name = "lblSeñalBusqueda"
        Me.lblSeñalBusqueda.Size = New System.Drawing.Size(39, 13)
        Me.lblSeñalBusqueda.TabIndex = 113
        Me.lblSeñalBusqueda.Text = "Label1"
        Me.lblSeñalBusqueda.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton3)
        Me.GroupBox1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(352, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(319, 56)
        Me.GroupBox1.TabIndex = 112
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "State"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(122, 22)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(95, 24)
        Me.RadioButton2.TabIndex = 103
        Me.RadioButton2.Text = "INACTIVE"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.RadioButton3.ForeColor = System.Drawing.Color.Black
        Me.RadioButton3.Location = New System.Drawing.Point(39, 22)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(65, 24)
        Me.RadioButton3.TabIndex = 102
        Me.RadioButton3.Text = "ASSET"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.BackColor = System.Drawing.Color.Transparent
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Cmdagregar, Me.CmdModificar, Me.Cmdeliminar, Me.cmdsalir1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(602, 129)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(69, 286)
        Me.ToolStrip1.TabIndex = 111
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
        'GrillaCondicionIVA
        '
        Me.GrillaCondicionIVA.AllowUserToAddRows = False
        Me.GrillaCondicionIVA.BackgroundColor = System.Drawing.Color.White
        Me.GrillaCondicionIVA.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GrillaCondicionIVA.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal
        Me.GrillaCondicionIVA.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaCondicionIVA.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.GrillaCondicionIVA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GrillaCondicionIVA.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.Descripcion, Me.Activo})
        Me.GrillaCondicionIVA.EnableHeadersVisualStyles = False
        Me.GrillaCondicionIVA.GridColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GrillaCondicionIVA.Location = New System.Drawing.Point(25, 129)
        Me.GrillaCondicionIVA.Name = "GrillaCondicionIVA"
        Me.GrillaCondicionIVA.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.GrillaCondicionIVA.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(207, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.GrillaCondicionIVA.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.GrillaCondicionIVA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GrillaCondicionIVA.Size = New System.Drawing.Size(554, 494)
        Me.GrillaCondicionIVA.TabIndex = 110
        '
        'ID
        '
        Me.ID.HeaderText = "#"
        Me.ID.Name = "ID"
        '
        'Descripcion
        '
        Me.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Descripcion.HeaderText = "Descripcion"
        Me.Descripcion.Name = "Descripcion"
        '
        'Activo
        '
        Me.Activo.HeaderText = "Activo"
        Me.Activo.Name = "Activo"
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Checked = True
        Me.RadioButton1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(238, 22)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(52, 24)
        Me.RadioButton1.TabIndex = 104
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "ALL"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'FrmCondicionIVA
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(696, 678)
        Me.Controls.Add(Me.lblSeñalBusqueda)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GrillaCondicionIVA)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmCondicionIVA"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmCondicionIVA"
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnmaximizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.GrillaCondicionIVA, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnmaximizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents lblSeñalBusqueda As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Cmdagregar As ToolStripButton
    Friend WithEvents CmdModificar As ToolStripButton
    Friend WithEvents Cmdeliminar As ToolStripButton
    Friend WithEvents cmdsalir1 As ToolStripButton
    Friend WithEvents GrillaCondicionIVA As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents Descripcion As DataGridViewTextBoxColumn
    Friend WithEvents Activo As DataGridViewTextBoxColumn
    Friend WithEvents RadioButton1 As RadioButton
End Class
