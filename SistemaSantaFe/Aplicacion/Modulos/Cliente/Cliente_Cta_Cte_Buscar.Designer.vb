<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente_Cta_Cte_Buscar
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BO_cliente_modificar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DG_clientes = New System.Windows.Forms.DataGridView()
        Me.CtaCteidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIFanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIapeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLInomDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIdniDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DireccionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIfnacDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLItelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLImailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIobservacionesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCteestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCtetotalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ClienteCtaCteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Cliente_ds = New Aplicacion.Cliente_ds()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DG_Detalle = New System.Windows.Forms.DataGridView()
        Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DebeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HaberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DetalleCtaCteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbl_limite = New System.Windows.Forms.Label()
        Me.limite = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClienteCtaCteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DG_Detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetalleCtaCteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BO_cliente_modificar
        '
        Me.BO_cliente_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_cliente_modificar.Location = New System.Drawing.Point(975, 507)
        Me.BO_cliente_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_modificar.Name = "BO_cliente_modificar"
        Me.BO_cliente_modificar.Size = New System.Drawing.Size(124, 43)
        Me.BO_cliente_modificar.TabIndex = 249
        Me.BO_cliente_modificar.Text = "Ver"
        Me.BO_cliente_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_modificar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DG_clientes)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.GroupBox1.Location = New System.Drawing.Point(7, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1076, 435)
        Me.GroupBox1.TabIndex = 248
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar cliente por nombre (Fantasía o Razón Social): "
        '
        'DG_clientes
        '
        Me.DG_clientes.AllowUserToAddRows = False
        Me.DG_clientes.AllowUserToDeleteRows = False
        Me.DG_clientes.AllowUserToResizeRows = False
        Me.DG_clientes.AutoGenerateColumns = False
        Me.DG_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_clientes.BackgroundColor = System.Drawing.Color.White
        Me.DG_clientes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CtaCteidDataGridViewTextBoxColumn, Me.CLIFanDataGridViewTextBoxColumn, Me.CLIidDataGridViewTextBoxColumn, Me.CLIapeDataGridViewTextBoxColumn, Me.CLInomDataGridViewTextBoxColumn, Me.CLIdniDataGridViewTextBoxColumn, Me.DireccionDataGridViewTextBoxColumn, Me.CLIfnacDataGridViewTextBoxColumn, Me.CLItelDataGridViewTextBoxColumn, Me.CLImailDataGridViewTextBoxColumn, Me.CLIobservacionesDataGridViewTextBoxColumn, Me.CtaCteestadoDataGridViewTextBoxColumn, Me.CtaCtefechaaltaDataGridViewTextBoxColumn, Me.CtaCtelimitedeudaDataGridViewTextBoxColumn, Me.CtaCtetotalDataGridViewTextBoxColumn})
        Me.DG_clientes.DataSource = Me.ClienteCtaCteBindingSource
        Me.DG_clientes.Location = New System.Drawing.Point(12, 49)
        Me.DG_clientes.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_clientes.MultiSelect = False
        Me.DG_clientes.Name = "DG_clientes"
        Me.DG_clientes.ReadOnly = True
        Me.DG_clientes.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_clientes.RowHeadersVisible = False
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_clientes.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DG_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_clientes.Size = New System.Drawing.Size(1052, 376)
        Me.DG_clientes.StandardTab = True
        Me.DG_clientes.TabIndex = 241
        '
        'CtaCteidDataGridViewTextBoxColumn
        '
        Me.CtaCteidDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_id"
        Me.CtaCteidDataGridViewTextBoxColumn.HeaderText = "NRO. CUENTA"
        Me.CtaCteidDataGridViewTextBoxColumn.Name = "CtaCteidDataGridViewTextBoxColumn"
        Me.CtaCteidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIFanDataGridViewTextBoxColumn
        '
        Me.CLIFanDataGridViewTextBoxColumn.DataPropertyName = "CLI_Fan"
        Me.CLIFanDataGridViewTextBoxColumn.HeaderText = "FANTASIA / RAZON SOCIAL"
        Me.CLIFanDataGridViewTextBoxColumn.Name = "CLIFanDataGridViewTextBoxColumn"
        Me.CLIFanDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'CLIapeDataGridViewTextBoxColumn
        '
        Me.CLIapeDataGridViewTextBoxColumn.DataPropertyName = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.HeaderText = "CLI_ape"
        Me.CLIapeDataGridViewTextBoxColumn.Name = "CLIapeDataGridViewTextBoxColumn"
        Me.CLIapeDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIapeDataGridViewTextBoxColumn.Visible = False
        '
        'CLInomDataGridViewTextBoxColumn
        '
        Me.CLInomDataGridViewTextBoxColumn.DataPropertyName = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.HeaderText = "CLI_nom"
        Me.CLInomDataGridViewTextBoxColumn.Name = "CLInomDataGridViewTextBoxColumn"
        Me.CLInomDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLInomDataGridViewTextBoxColumn.Visible = False
        '
        'CLIdniDataGridViewTextBoxColumn
        '
        Me.CLIdniDataGridViewTextBoxColumn.DataPropertyName = "CLI_dni"
        Me.CLIdniDataGridViewTextBoxColumn.HeaderText = "DNI / CUIT"
        Me.CLIdniDataGridViewTextBoxColumn.Name = "CLIdniDataGridViewTextBoxColumn"
        Me.CLIdniDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DireccionDataGridViewTextBoxColumn
        '
        Me.DireccionDataGridViewTextBoxColumn.DataPropertyName = "direccion"
        Me.DireccionDataGridViewTextBoxColumn.HeaderText = "DIRECCION"
        Me.DireccionDataGridViewTextBoxColumn.Name = "DireccionDataGridViewTextBoxColumn"
        Me.DireccionDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIfnacDataGridViewTextBoxColumn
        '
        Me.CLIfnacDataGridViewTextBoxColumn.DataPropertyName = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.HeaderText = "CLI_fnac"
        Me.CLIfnacDataGridViewTextBoxColumn.Name = "CLIfnacDataGridViewTextBoxColumn"
        Me.CLIfnacDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIfnacDataGridViewTextBoxColumn.Visible = False
        '
        'CLItelDataGridViewTextBoxColumn
        '
        Me.CLItelDataGridViewTextBoxColumn.DataPropertyName = "CLI_tel"
        Me.CLItelDataGridViewTextBoxColumn.HeaderText = "TELEFONO"
        Me.CLItelDataGridViewTextBoxColumn.Name = "CLItelDataGridViewTextBoxColumn"
        Me.CLItelDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLImailDataGridViewTextBoxColumn
        '
        Me.CLImailDataGridViewTextBoxColumn.DataPropertyName = "CLI_mail"
        Me.CLImailDataGridViewTextBoxColumn.HeaderText = "MAIL"
        Me.CLImailDataGridViewTextBoxColumn.Name = "CLImailDataGridViewTextBoxColumn"
        Me.CLImailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CLIobservacionesDataGridViewTextBoxColumn
        '
        Me.CLIobservacionesDataGridViewTextBoxColumn.DataPropertyName = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.HeaderText = "CLI_observaciones"
        Me.CLIobservacionesDataGridViewTextBoxColumn.Name = "CLIobservacionesDataGridViewTextBoxColumn"
        Me.CLIobservacionesDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIobservacionesDataGridViewTextBoxColumn.Visible = False
        '
        'CtaCteestadoDataGridViewTextBoxColumn
        '
        Me.CtaCteestadoDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_estado"
        Me.CtaCteestadoDataGridViewTextBoxColumn.HeaderText = "CtaCte_estado"
        Me.CtaCteestadoDataGridViewTextBoxColumn.Name = "CtaCteestadoDataGridViewTextBoxColumn"
        Me.CtaCteestadoDataGridViewTextBoxColumn.ReadOnly = True
        Me.CtaCteestadoDataGridViewTextBoxColumn.Visible = False
        '
        'CtaCtefechaaltaDataGridViewTextBoxColumn
        '
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_fechaalta"
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn.HeaderText = "CtaCte_fechaalta"
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn.Name = "CtaCtefechaaltaDataGridViewTextBoxColumn"
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn.ReadOnly = True
        Me.CtaCtefechaaltaDataGridViewTextBoxColumn.Visible = False
        '
        'CtaCtelimitedeudaDataGridViewTextBoxColumn
        '
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_limitedeuda"
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn.HeaderText = "LIMITE"
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn.Name = "CtaCtelimitedeudaDataGridViewTextBoxColumn"
        Me.CtaCtelimitedeudaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CtaCtetotalDataGridViewTextBoxColumn
        '
        Me.CtaCtetotalDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_total"
        Me.CtaCtetotalDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.CtaCtetotalDataGridViewTextBoxColumn.Name = "CtaCtetotalDataGridViewTextBoxColumn"
        Me.CtaCtetotalDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ClienteCtaCteBindingSource
        '
        Me.ClienteCtaCteBindingSource.DataMember = "Cliente_CtaCte"
        Me.ClienteCtaCteBindingSource.DataSource = Me.Cliente_ds
        '
        'Cliente_ds
        '
        Me.Cliente_ds.DataSetName = "Cliente_ds"
        Me.Cliente_ds.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(1052, 22)
        Me.TextBox1.TabIndex = 240
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1102, 476)
        Me.TabControl1.TabIndex = 250
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1094, 450)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.DG_Detalle)
        Me.TabPage2.Controls.Add(Me.lbl_limite)
        Me.TabPage2.Controls.Add(Me.limite)
        Me.TabPage2.Controls.Add(Me.lbl_total)
        Me.TabPage2.Controls.Add(Me.Label1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1094, 450)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'DG_Detalle
        '
        Me.DG_Detalle.AllowUserToAddRows = False
        Me.DG_Detalle.AllowUserToDeleteRows = False
        Me.DG_Detalle.AllowUserToResizeRows = False
        Me.DG_Detalle.AutoGenerateColumns = False
        Me.DG_Detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DG_Detalle.BackgroundColor = System.Drawing.Color.White
        Me.DG_Detalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DG_Detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DG_Detalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn, Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn, Me.DebeDataGridViewTextBoxColumn, Me.HaberDataGridViewTextBoxColumn, Me.SaldoDataGridViewTextBoxColumn})
        Me.DG_Detalle.DataSource = Me.DetalleCtaCteBindingSource
        Me.DG_Detalle.Location = New System.Drawing.Point(7, 94)
        Me.DG_Detalle.Margin = New System.Windows.Forms.Padding(4)
        Me.DG_Detalle.MultiSelect = False
        Me.DG_Detalle.Name = "DG_Detalle"
        Me.DG_Detalle.ReadOnly = True
        Me.DG_Detalle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.DG_Detalle.RowHeadersVisible = False
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black
        Me.DG_Detalle.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DG_Detalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DG_Detalle.Size = New System.Drawing.Size(919, 257)
        Me.DG_Detalle.StandardTab = True
        Me.DG_Detalle.TabIndex = 242
        '
        'MovimientosCtaCtefechaDataGridViewTextBoxColumn
        '
        Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn.DataPropertyName = "MovimientosCtaCte_fecha"
        Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn.HeaderText = "FECHA"
        Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn.Name = "MovimientosCtaCtefechaDataGridViewTextBoxColumn"
        Me.MovimientosCtaCtefechaDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MovimientosCtaCteconceptoDataGridViewTextBoxColumn
        '
        Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn.DataPropertyName = "MovimientosCtaCte_concepto"
        Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn.HeaderText = "CONCEPTO"
        Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn.Name = "MovimientosCtaCteconceptoDataGridViewTextBoxColumn"
        Me.MovimientosCtaCteconceptoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DebeDataGridViewTextBoxColumn
        '
        Me.DebeDataGridViewTextBoxColumn.DataPropertyName = "Debe"
        Me.DebeDataGridViewTextBoxColumn.HeaderText = "DEBE"
        Me.DebeDataGridViewTextBoxColumn.Name = "DebeDataGridViewTextBoxColumn"
        Me.DebeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HaberDataGridViewTextBoxColumn
        '
        Me.HaberDataGridViewTextBoxColumn.DataPropertyName = "Haber"
        Me.HaberDataGridViewTextBoxColumn.HeaderText = "HABER"
        Me.HaberDataGridViewTextBoxColumn.Name = "HaberDataGridViewTextBoxColumn"
        Me.HaberDataGridViewTextBoxColumn.ReadOnly = True
        '
        'SaldoDataGridViewTextBoxColumn
        '
        Me.SaldoDataGridViewTextBoxColumn.DataPropertyName = "Saldo"
        Me.SaldoDataGridViewTextBoxColumn.HeaderText = "SALDO"
        Me.SaldoDataGridViewTextBoxColumn.Name = "SaldoDataGridViewTextBoxColumn"
        Me.SaldoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DetalleCtaCteBindingSource
        '
        Me.DetalleCtaCteBindingSource.DataMember = "Detalle_CtaCte"
        Me.DetalleCtaCteBindingSource.DataSource = Me.Cliente_ds
        '
        'lbl_limite
        '
        Me.lbl_limite.AutoSize = True
        Me.lbl_limite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_limite.ForeColor = System.Drawing.Color.Red
        Me.lbl_limite.Location = New System.Drawing.Point(311, 52)
        Me.lbl_limite.Name = "lbl_limite"
        Me.lbl_limite.Size = New System.Drawing.Size(54, 20)
        Me.lbl_limite.TabIndex = 4
        Me.lbl_limite.Text = "Total:"
        '
        'limite
        '
        Me.limite.AutoSize = True
        Me.limite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limite.Location = New System.Drawing.Point(251, 52)
        Me.limite.Name = "limite"
        Me.limite.Size = New System.Drawing.Size(62, 20)
        Me.limite.TabIndex = 3
        Me.limite.Text = "Limite:"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.ForeColor = System.Drawing.Color.Red
        Me.lbl_total.Location = New System.Drawing.Point(80, 52)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(54, 20)
        Me.lbl_total.TabIndex = 2
        Me.lbl_total.Text = "Total:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Total:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(324, 507)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(301, 43)
        Me.Button1.TabIndex = 251
        Me.Button1.Text = "Nose que haces!!!!!!!!!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Cliente_Cta_Cte_Buscar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1126, 563)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BO_cliente_modificar)
        Me.Name = "Cliente_Cta_Cte_Buscar"
        Me.Text = "Cuentas Corrientes"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DG_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClienteCtaCteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Cliente_ds, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DG_Detalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetalleCtaCteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BO_cliente_modificar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DG_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents CtaCteidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIFanDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIapeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLInomDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIdniDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DireccionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIfnacDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLItelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLImailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIobservacionesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCteestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCtefechaaltaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCtelimitedeudaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCtetotalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ClienteCtaCteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Cliente_ds As Aplicacion.Cliente_ds
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents lbl_limite As System.Windows.Forms.Label
    Friend WithEvents limite As System.Windows.Forms.Label
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DG_Detalle As System.Windows.Forms.DataGridView
    Friend WithEvents MovimientosCtaCtefechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MovimientosCtaCteconceptoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DebeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HaberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SaldoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DetalleCtaCteBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
