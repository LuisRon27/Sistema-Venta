﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmVentaxPeriodo
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
        Me.btnCerrar = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CmdImprimir = New System.Windows.Forms.ToolStripButton()
        Me.cmdsalir = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.radioTodo = New System.Windows.Forms.RadioButton()
        Me.radioVenta = New System.Windows.Forms.RadioButton()
        Me.radioDevolucion = New System.Windows.Forms.RadioButton()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.InfVentaxPeriodo1 = New Negocio.InfVentaxPeriodo()
        Me.PanelCabecera.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
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
        Me.PanelCabecera.Size = New System.Drawing.Size(1315, 40)
        Me.PanelCabecera.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Britannic Bold", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(21, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(149, 23)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Informe Perido"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnMinimizar)
        Me.Panel3.Controls.Add(Me.btnCerrar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(1186, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(129, 40)
        Me.Panel3.TabIndex = 0
        '
        'btnMinimizar
        '
        Me.btnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMinimizar.Image = Global.Negocio.My.Resources.Resources.minimazar
        Me.btnMinimizar.Location = New System.Drawing.Point(62, 8)
        Me.btnMinimizar.Name = "btnMinimizar"
        Me.btnMinimizar.Size = New System.Drawing.Size(25, 25)
        Me.btnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.btnMinimizar.TabIndex = 8
        Me.btnMinimizar.TabStop = False
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CmdImprimir, Me.cmdsalir, Me.ToolStripSeparator1})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 40)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1315, 71)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CmdImprimir
        '
        Me.CmdImprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CmdImprimir.Image = Global.Negocio.My.Resources.Resources.apps_printer_15747
        Me.CmdImprimir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CmdImprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CmdImprimir.Name = "CmdImprimir"
        Me.CmdImprimir.Size = New System.Drawing.Size(68, 68)
        Me.CmdImprimir.Text = "Imprimir"
        Me.CmdImprimir.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'cmdsalir
        '
        Me.cmdsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.cmdsalir.Image = Global.Negocio.My.Resources.Resources.Exit_Page_icon_icons_com_53732
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
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(208, 81)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker1.TabIndex = 10
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(429, 81)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(120, 20)
        Me.DateTimePicker2.TabIndex = 11
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.radioTodo)
        Me.GroupBox2.Controls.Add(Me.radioVenta)
        Me.GroupBox2.Controls.Add(Me.radioDevolucion)
        Me.GroupBox2.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(726, 54)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(427, 56)
        Me.GroupBox2.TabIndex = 107
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Tipo Comprobante"
        '
        'radioTodo
        '
        Me.radioTodo.AutoSize = True
        Me.radioTodo.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.radioTodo.ForeColor = System.Drawing.Color.Black
        Me.radioTodo.Location = New System.Drawing.Point(310, 22)
        Me.radioTodo.Name = "radioTodo"
        Me.radioTodo.Size = New System.Drawing.Size(69, 24)
        Me.radioTodo.TabIndex = 105
        Me.radioTodo.Text = "TODO"
        Me.radioTodo.UseVisualStyleBackColor = True
        '
        'radioVenta
        '
        Me.radioVenta.AutoSize = True
        Me.radioVenta.Checked = True
        Me.radioVenta.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.radioVenta.ForeColor = System.Drawing.Color.Black
        Me.radioVenta.Location = New System.Drawing.Point(199, 22)
        Me.radioVenta.Name = "radioVenta"
        Me.radioVenta.Size = New System.Drawing.Size(73, 24)
        Me.radioVenta.TabIndex = 104
        Me.radioVenta.TabStop = True
        Me.radioVenta.Text = "VENTA"
        Me.radioVenta.UseVisualStyleBackColor = True
        '
        'radioDevolucion
        '
        Me.radioDevolucion.AutoSize = True
        Me.radioDevolucion.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.radioDevolucion.ForeColor = System.Drawing.Color.Black
        Me.radioDevolucion.Location = New System.Drawing.Point(39, 22)
        Me.radioDevolucion.Name = "radioDevolucion"
        Me.radioDevolucion.Size = New System.Drawing.Size(129, 24)
        Me.radioDevolucion.TabIndex = 102
        Me.radioDevolucion.Text = "DEVOLUCION"
        Me.radioDevolucion.UseVisualStyleBackColor = True
        '
        'lblNombre
        '
        Me.lblNombre.AutoSize = True
        Me.lblNombre.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.lblNombre.ForeColor = System.Drawing.Color.Black
        Me.lblNombre.Location = New System.Drawing.Point(204, 54)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(56, 20)
        Me.lblNombre.TabIndex = 108
        Me.lblNombre.Text = "Desde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 11.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(425, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 20)
        Me.Label1.TabIndex = 109
        Me.Label1.Text = "Hasta"
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = 0
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(0, 153)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.ReportSource = Me.InfVentaxPeriodo1
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1315, 635)
        Me.CrystalReportViewer1.TabIndex = 110
        Me.CrystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None
        '
        'FrmVentaxPeriodo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1315, 788)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DateTimePicker2)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.PanelCabecera)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmVentaxPeriodo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FrmVentaxPeriodo"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.PanelCabecera.ResumeLayout(False)
        Me.PanelCabecera.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        CType(Me.btnMinimizar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnCerrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PanelCabecera As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnMinimizar As PictureBox
    Friend WithEvents btnCerrar As PictureBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CmdImprimir As ToolStripButton
    Friend WithEvents cmdsalir As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents radioVenta As RadioButton
    Friend WithEvents radioDevolucion As RadioButton
    Friend WithEvents radioTodo As RadioButton
    Friend WithEvents lblNombre As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents InfVentaxPeriodo1 As InfVentaxPeriodo
End Class
