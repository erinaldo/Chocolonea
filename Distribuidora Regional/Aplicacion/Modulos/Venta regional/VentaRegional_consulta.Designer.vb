﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaRegional_consulta
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaRegional_consulta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Lb_detalle_nrofactura = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Lb_detalle_monto = New System.Windows.Forms.Label()
        Me.Lb_detalle_cliente = New System.Windows.Forms.Label()
        Me.Lb_detalle_fechafactura = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Lb_detalle_nroventa = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.DG_ventas = New System.Windows.Forms.DataGridView()
        Me.VentaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_venta_regional1 = New Aplicacion.DS_venta_regional()
        Me.DG_detalles = New System.Windows.Forms.DataGridView()
        Me.VentadetidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaidDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRODnombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioUDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PreciosubtotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.VentadetalleBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_venta_regional2 = New Aplicacion.DS_venta_regional()
        Me.Recepcion_ds = New Aplicacion.Recepcion_ds()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.bo_nrofactura = New System.Windows.Forms.Button()
        Me.TX_buscar_codigo = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.BO_producto = New System.Windows.Forms.Button()
        Me.TX_buscar_nombre = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lb_ape_modif = New System.Windows.Forms.Label()
        Me.DS_venta_regional = New Aplicacion.DS_venta_regional()
        Me.VentaidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentacodigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NrofacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentatotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentafechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FechafacturaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DG_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_venta_regional1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DG_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VentadetalleBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_venta_regional2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Recepcion_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_venta_regional, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.SplitContainer1)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 98)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1009, 455)
        Me.GroupBox1.TabIndex = 28
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Consulta de stock"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Lb_detalle_nrofactura)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Lb_detalle_monto)
        Me.GroupBox2.Controls.Add(Me.Lb_detalle_cliente)
        Me.GroupBox2.Controls.Add(Me.Lb_detalle_fechafactura)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Lb_detalle_nroventa)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(426, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(572, 75)
        Me.GroupBox2.TabIndex = 36
        Me.GroupBox2.TabStop = False
        '
        'Lb_detalle_nrofactura
        '
        Me.Lb_detalle_nrofactura.AutoSize = True
        Me.Lb_detalle_nrofactura.BackColor = System.Drawing.Color.Transparent
        Me.Lb_detalle_nrofactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_detalle_nrofactura.Location = New System.Drawing.Point(85, 32)
        Me.Lb_detalle_nrofactura.Name = "Lb_detalle_nrofactura"
        Me.Lb_detalle_nrofactura.Size = New System.Drawing.Size(39, 15)
        Me.Lb_detalle_nrofactura.TabIndex = 45
        Me.Lb_detalle_nrofactura.Text = "0000"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(5, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 15)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Nº factura:"
        '
        'Lb_detalle_monto
        '
        Me.Lb_detalle_monto.AutoSize = True
        Me.Lb_detalle_monto.BackColor = System.Drawing.Color.Transparent
        Me.Lb_detalle_monto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_detalle_monto.Location = New System.Drawing.Point(403, 55)
        Me.Lb_detalle_monto.Name = "Lb_detalle_monto"
        Me.Lb_detalle_monto.Size = New System.Drawing.Size(43, 15)
        Me.Lb_detalle_monto.TabIndex = 43
        Me.Lb_detalle_monto.Text = "00,00"
        '
        'Lb_detalle_cliente
        '
        Me.Lb_detalle_cliente.AutoSize = True
        Me.Lb_detalle_cliente.BackColor = System.Drawing.Color.Transparent
        Me.Lb_detalle_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_detalle_cliente.Location = New System.Drawing.Point(67, 55)
        Me.Lb_detalle_cliente.Name = "Lb_detalle_cliente"
        Me.Lb_detalle_cliente.Size = New System.Drawing.Size(143, 15)
        Me.Lb_detalle_cliente.TabIndex = 42
        Me.Lb_detalle_cliente.Text = ".................................."
        '
        'Lb_detalle_fechafactura
        '
        Me.Lb_detalle_fechafactura.AutoSize = True
        Me.Lb_detalle_fechafactura.BackColor = System.Drawing.Color.Transparent
        Me.Lb_detalle_fechafactura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_detalle_fechafactura.Location = New System.Drawing.Point(400, 32)
        Me.Lb_detalle_fechafactura.Name = "Lb_detalle_fechafactura"
        Me.Lb_detalle_fechafactura.Size = New System.Drawing.Size(63, 15)
        Me.Lb_detalle_fechafactura.TabIndex = 41
        Me.Lb_detalle_fechafactura.Text = "00/00/00"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(299, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 15)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "Monto total: $"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(5, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 15)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "Cliente:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(296, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Fecha factura:"
        '
        'Lb_detalle_nroventa
        '
        Me.Lb_detalle_nroventa.AutoSize = True
        Me.Lb_detalle_nroventa.BackColor = System.Drawing.Color.Transparent
        Me.Lb_detalle_nroventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_detalle_nroventa.Location = New System.Drawing.Point(176, 7)
        Me.Lb_detalle_nroventa.Name = "Lb_detalle_nroventa"
        Me.Lb_detalle_nroventa.Size = New System.Drawing.Size(39, 15)
        Me.Lb_detalle_nroventa.TabIndex = 37
        Me.Lb_detalle_nroventa.Text = "0000"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(5, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 15)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "Resumen de la venta Nº:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(9, 19)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DG_ventas)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DG_detalles)
        Me.SplitContainer1.Size = New System.Drawing.Size(1236, 416)
        Me.SplitContainer1.SplitterDistance = 410
        Me.SplitContainer1.TabIndex = 21
        '
        'DG_ventas
        '
        Me.DG_ventas.AllowUserToAddRows = False
        Me.DG_ventas.AllowUserToDeleteRows = False
        Me.DG_ventas.AllowUserToResizeRows = False
        Me.DG_ventas.AutoGenerateColumns = False
        Me.DG_ventas.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DG_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_ventas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VentaidDataGridViewTextBoxColumn, Me.VentacodigoDataGridViewTextBoxColumn, Me.NrofacturaDataGridViewTextBoxColumn, Me.VentatotalDataGridViewTextBoxColumn, Me.CLIidDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.VentafechaDataGridViewTextBoxColumn, Me.FechafacturaDataGridViewTextBoxColumn, Me.Column2})
        Me.DG_ventas.DataSource = Me.VentaBindingSource
        Me.DG_ventas.Location = New System.Drawing.Point(3, 3)
        Me.DG_ventas.Name = "DG_ventas"
        Me.DG_ventas.ReadOnly = True
        Me.DG_ventas.RowHeadersVisible = False
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_ventas.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_ventas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_ventas.Size = New System.Drawing.Size(390, 410)
        Me.DG_ventas.TabIndex = 0
        '
        'VentaBindingSource
        '
        Me.VentaBindingSource.DataMember = "Venta"
        Me.VentaBindingSource.DataSource = Me.DS_venta_regional1
        '
        'DS_venta_regional1
        '
        Me.DS_venta_regional1.DataSetName = "DS_venta_regional"
        Me.DS_venta_regional1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DG_detalles
        '
        Me.DG_detalles.AllowUserToAddRows = False
        Me.DG_detalles.AllowUserToDeleteRows = False
        Me.DG_detalles.AllowUserToResizeRows = False
        Me.DG_detalles.AutoGenerateColumns = False
        Me.DG_detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_detalles.BackgroundColor = System.Drawing.SystemColors.Menu
        Me.DG_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_detalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.VentadetidDataGridViewTextBoxColumn, Me.VentaidDataGridViewTextBoxColumn1, Me.PRODidDataGridViewTextBoxColumn, Me.PRODnombreDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioUDataGridViewTextBoxColumn, Me.PreciosubtotalDataGridViewTextBoxColumn, Me.Column1})
        Me.DG_detalles.DataSource = Me.VentadetalleBindingSource
        Me.DG_detalles.Location = New System.Drawing.Point(3, 75)
        Me.DG_detalles.Name = "DG_detalles"
        Me.DG_detalles.ReadOnly = True
        Me.DG_detalles.RowHeadersVisible = False
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_detalles.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DG_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_detalles.Size = New System.Drawing.Size(572, 336)
        Me.DG_detalles.TabIndex = 1
        '
        'VentadetidDataGridViewTextBoxColumn
        '
        Me.VentadetidDataGridViewTextBoxColumn.DataPropertyName = "Venta_det_id"
        Me.VentadetidDataGridViewTextBoxColumn.HeaderText = "Venta_det_id"
        Me.VentadetidDataGridViewTextBoxColumn.Name = "VentadetidDataGridViewTextBoxColumn"
        Me.VentadetidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentadetidDataGridViewTextBoxColumn.Visible = False
        '
        'VentaidDataGridViewTextBoxColumn1
        '
        Me.VentaidDataGridViewTextBoxColumn1.DataPropertyName = "Venta_id"
        Me.VentaidDataGridViewTextBoxColumn1.HeaderText = "Venta_id"
        Me.VentaidDataGridViewTextBoxColumn1.Name = "VentaidDataGridViewTextBoxColumn1"
        Me.VentaidDataGridViewTextBoxColumn1.ReadOnly = True
        Me.VentaidDataGridViewTextBoxColumn1.Visible = False
        '
        'PRODidDataGridViewTextBoxColumn
        '
        Me.PRODidDataGridViewTextBoxColumn.DataPropertyName = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.HeaderText = "PROD_id"
        Me.PRODidDataGridViewTextBoxColumn.Name = "PRODidDataGridViewTextBoxColumn"
        Me.PRODidDataGridViewTextBoxColumn.ReadOnly = True
        Me.PRODidDataGridViewTextBoxColumn.Visible = False
        '
        'PRODnombreDataGridViewTextBoxColumn
        '
        Me.PRODnombreDataGridViewTextBoxColumn.DataPropertyName = "PROD_nombre"
        Me.PRODnombreDataGridViewTextBoxColumn.HeaderText = "Producto"
        Me.PRODnombreDataGridViewTextBoxColumn.Name = "PRODnombreDataGridViewTextBoxColumn"
        Me.PRODnombreDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        Me.CantidadDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PrecioUDataGridViewTextBoxColumn
        '
        Me.PrecioUDataGridViewTextBoxColumn.DataPropertyName = "precio_U"
        Me.PrecioUDataGridViewTextBoxColumn.HeaderText = "Precio U."
        Me.PrecioUDataGridViewTextBoxColumn.Name = "PrecioUDataGridViewTextBoxColumn"
        Me.PrecioUDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PreciosubtotalDataGridViewTextBoxColumn
        '
        Me.PreciosubtotalDataGridViewTextBoxColumn.DataPropertyName = "precio_subtotal"
        Me.PreciosubtotalDataGridViewTextBoxColumn.HeaderText = "Precio Subtotal"
        Me.PreciosubtotalDataGridViewTextBoxColumn.Name = "PreciosubtotalDataGridViewTextBoxColumn"
        Me.PreciosubtotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Column1
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column1.HeaderText = "Ver"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Text = ". . ."
        Me.Column1.UseColumnTextForButtonValue = True
        '
        'VentadetalleBindingSource
        '
        Me.VentadetalleBindingSource.DataMember = "Venta_detalle"
        Me.VentadetalleBindingSource.DataSource = Me.DS_venta_regional2
        '
        'DS_venta_regional2
        '
        Me.DS_venta_regional2.DataSetName = "DS_venta_regional"
        Me.DS_venta_regional2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Recepcion_ds
        '
        Me.Recepcion_ds.DataSetName = "Recepcion_ds"
        Me.Recepcion_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.Recepcion_ds
        '
        'bo_nrofactura
        '
        Me.bo_nrofactura.Image = CType(resources.GetObject("bo_nrofactura.Image"), System.Drawing.Image)
        Me.bo_nrofactura.Location = New System.Drawing.Point(749, 60)
        Me.bo_nrofactura.Name = "bo_nrofactura"
        Me.bo_nrofactura.Size = New System.Drawing.Size(30, 30)
        Me.bo_nrofactura.TabIndex = 34
        Me.bo_nrofactura.UseVisualStyleBackColor = True
        '
        'TX_buscar_codigo
        '
        Me.TX_buscar_codigo.Location = New System.Drawing.Point(510, 66)
        Me.TX_buscar_codigo.Name = "TX_buscar_codigo"
        Me.TX_buscar_codigo.Size = New System.Drawing.Size(233, 20)
        Me.TX_buscar_codigo.TabIndex = 32
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(410, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 15)
        Me.Label15.TabIndex = 33
        Me.Label15.Text = "Nº de factura:"
        '
        'BO_producto
        '
        Me.BO_producto.Image = CType(resources.GetObject("BO_producto.Image"), System.Drawing.Image)
        Me.BO_producto.Location = New System.Drawing.Point(365, 60)
        Me.BO_producto.Name = "BO_producto"
        Me.BO_producto.Size = New System.Drawing.Size(30, 30)
        Me.BO_producto.TabIndex = 31
        Me.BO_producto.UseVisualStyleBackColor = True
        '
        'TX_buscar_nombre
        '
        Me.TX_buscar_nombre.Location = New System.Drawing.Point(154, 66)
        Me.TX_buscar_nombre.Name = "TX_buscar_nombre"
        Me.TX_buscar_nombre.Size = New System.Drawing.Size(205, 20)
        Me.TX_buscar_nombre.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Maroon
        Me.Label1.Location = New System.Drawing.Point(21, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(346, 29)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Consulta de Ventas registradas"
        '
        'lb_ape_modif
        '
        Me.lb_ape_modif.AutoSize = True
        Me.lb_ape_modif.BackColor = System.Drawing.Color.Transparent
        Me.lb_ape_modif.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_ape_modif.Location = New System.Drawing.Point(26, 69)
        Me.lb_ape_modif.Name = "lb_ape_modif"
        Me.lb_ape_modif.Size = New System.Drawing.Size(122, 15)
        Me.lb_ape_modif.TabIndex = 30
        Me.lb_ape_modif.Text = "Nombre producto:"
        '
        'DS_venta_regional
        '
        Me.DS_venta_regional.DataSetName = "DS_venta_regional"
        Me.DS_venta_regional.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VentaidDataGridViewTextBoxColumn
        '
        Me.VentaidDataGridViewTextBoxColumn.DataPropertyName = "Venta_id"
        Me.VentaidDataGridViewTextBoxColumn.HeaderText = "Venta_id"
        Me.VentaidDataGridViewTextBoxColumn.Name = "VentaidDataGridViewTextBoxColumn"
        Me.VentaidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaidDataGridViewTextBoxColumn.Visible = False
        Me.VentaidDataGridViewTextBoxColumn.Width = 55
        '
        'VentacodigoDataGridViewTextBoxColumn
        '
        Me.VentacodigoDataGridViewTextBoxColumn.DataPropertyName = "Venta_codigo"
        Me.VentacodigoDataGridViewTextBoxColumn.FillWeight = 103.3529!
        Me.VentacodigoDataGridViewTextBoxColumn.HeaderText = "Nº venta"
        Me.VentacodigoDataGridViewTextBoxColumn.Name = "VentacodigoDataGridViewTextBoxColumn"
        Me.VentacodigoDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentacodigoDataGridViewTextBoxColumn.Width = 69
        '
        'NrofacturaDataGridViewTextBoxColumn
        '
        Me.NrofacturaDataGridViewTextBoxColumn.DataPropertyName = "Nro_factura"
        Me.NrofacturaDataGridViewTextBoxColumn.FillWeight = 127.9073!
        Me.NrofacturaDataGridViewTextBoxColumn.HeaderText = "Nº factura"
        Me.NrofacturaDataGridViewTextBoxColumn.Name = "NrofacturaDataGridViewTextBoxColumn"
        Me.NrofacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.NrofacturaDataGridViewTextBoxColumn.Width = 74
        '
        'VentatotalDataGridViewTextBoxColumn
        '
        Me.VentatotalDataGridViewTextBoxColumn.DataPropertyName = "Venta_total"
        Me.VentatotalDataGridViewTextBoxColumn.HeaderText = "Monto total"
        Me.VentatotalDataGridViewTextBoxColumn.Name = "VentatotalDataGridViewTextBoxColumn"
        Me.VentatotalDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentatotalDataGridViewTextBoxColumn.Visible = False
        Me.VentatotalDataGridViewTextBoxColumn.Width = 85
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        Me.CLIidDataGridViewTextBoxColumn.Width = 62
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.FillWeight = 120.1623!
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "Cliente"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Width = 64
        '
        'VentafechaDataGridViewTextBoxColumn
        '
        Me.VentafechaDataGridViewTextBoxColumn.DataPropertyName = "Venta_fecha"
        Me.VentafechaDataGridViewTextBoxColumn.HeaderText = "Fecha del sistema"
        Me.VentafechaDataGridViewTextBoxColumn.Name = "VentafechaDataGridViewTextBoxColumn"
        Me.VentafechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentafechaDataGridViewTextBoxColumn.Visible = False
        Me.VentafechaDataGridViewTextBoxColumn.Width = 117
        '
        'FechafacturaDataGridViewTextBoxColumn
        '
        Me.FechafacturaDataGridViewTextBoxColumn.DataPropertyName = "Fecha_factura"
        Me.FechafacturaDataGridViewTextBoxColumn.FillWeight = 114.9857!
        Me.FechafacturaDataGridViewTextBoxColumn.HeaderText = "Fecha factura"
        Me.FechafacturaDataGridViewTextBoxColumn.Name = "FechafacturaDataGridViewTextBoxColumn"
        Me.FechafacturaDataGridViewTextBoxColumn.ReadOnly = True
        Me.FechafacturaDataGridViewTextBoxColumn.Width = 90
        '
        'Column2
        '
        Me.Column2.FillWeight = 33.59173!
        Me.Column2.HeaderText = "Ver"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Text = "Informe"
        Me.Column2.UseColumnTextForButtonValue = True
        Me.Column2.Width = 55
        '
        'VentaRegional_consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Aplicacion.My.Resources.Resources.silver_3
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1035, 569)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.bo_nrofactura)
        Me.Controls.Add(Me.TX_buscar_codigo)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.BO_producto)
        Me.Controls.Add(Me.TX_buscar_nombre)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lb_ape_modif)
        Me.Name = "VentaRegional_consulta"
        Me.Text = "Venta_consulta"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DG_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_venta_regional1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DG_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VentadetalleBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_venta_regional2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Recepcion_ds, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_venta_regional, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents DG_ventas As System.Windows.Forms.DataGridView
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Recepcion_ds As Aplicacion.Recepcion_ds
    Friend WithEvents DG_detalles As System.Windows.Forms.DataGridView
    Friend WithEvents bo_nrofactura As System.Windows.Forms.Button
    Friend WithEvents TX_buscar_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents BO_producto As System.Windows.Forms.Button
    Friend WithEvents TX_buscar_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lb_ape_modif As System.Windows.Forms.Label
    Friend WithEvents DS_venta_regional As Aplicacion.DS_venta_regional
    Friend WithEvents VentaBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_venta_regional1 As Aplicacion.DS_venta_regional
    Friend WithEvents VentadetalleBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_venta_regional2 As Aplicacion.DS_venta_regional
    Friend WithEvents VentadetidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaidDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PRODnombreDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PrecioUDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PreciosubtotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Lb_detalle_nrofactura As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Lb_detalle_monto As System.Windows.Forms.Label
    Friend WithEvents Lb_detalle_cliente As System.Windows.Forms.Label
    Friend WithEvents Lb_detalle_fechafactura As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Lb_detalle_nroventa As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents VentaidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentacodigoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NrofacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentatotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentafechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FechafacturaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewButtonColumn
End Class
