<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Remito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Remito))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RemitoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DS_remito = New Aplicacion.DS_remito()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.BO_cliente_modificar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Busqueda = New System.Windows.Forms.TextBox()
        Me.ColumnaEditar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RemitoidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemitoestadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VentaprodidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CLIidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fantasia = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CtaCteidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ventaprod_total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RemitofechaDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RemitoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DS_remito, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Aplicacion.My.Resources.Resources.mas30x30
        Me.Button1.Location = New System.Drawing.Point(13, 13)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(105, 49)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Nuevo"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(14, 147)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(934, 271)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Remitos generados:"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ColumnaEditar, Me.RemitoidDataGridViewTextBoxColumn, Me.RemitoestadoDataGridViewTextBoxColumn, Me.VentaprodidDataGridViewTextBoxColumn, Me.CLIidDataGridViewTextBoxColumn, Me.Fantasia, Me.CtaCteidDataGridViewTextBoxColumn, Me.ventaprod_total, Me.RemitofechaDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.RemitoBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(16, 22)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(893, 239)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 11
        '
        'RemitoBindingSource
        '
        Me.RemitoBindingSource.DataMember = "Remito"
        Me.RemitoBindingSource.DataSource = Me.DS_remito
        '
        'DS_remito
        '
        Me.DS_remito.DataSetName = "DS_remito"
        Me.DS_remito.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.Location = New System.Drawing.Point(126, 13)
        Me.Button3.Margin = New System.Windows.Forms.Padding(4)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(53, 49)
        Me.Button3.TabIndex = 240
        Me.Button3.TabStop = False
        Me.Button3.UseVisualStyleBackColor = True
        '
        'BO_cliente_modificar
        '
        Me.BO_cliente_modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BO_cliente_modificar.Image = Global.Aplicacion.My.Resources.Resources.Pasar
        Me.BO_cliente_modificar.Location = New System.Drawing.Point(187, 13)
        Me.BO_cliente_modificar.Margin = New System.Windows.Forms.Padding(4)
        Me.BO_cliente_modificar.Name = "BO_cliente_modificar"
        Me.BO_cliente_modificar.Size = New System.Drawing.Size(105, 49)
        Me.BO_cliente_modificar.TabIndex = 248
        Me.BO_cliente_modificar.Text = "Editar"
        Me.BO_cliente_modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BO_cliente_modificar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Busqueda)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(934, 72)
        Me.GroupBox2.TabIndex = 249
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar por Nº remito / Nº Cta.Cte. / Razon Social:"
        '
        'Busqueda
        '
        Me.Busqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Busqueda.Location = New System.Drawing.Point(16, 26)
        Me.Busqueda.Margin = New System.Windows.Forms.Padding(4)
        Me.Busqueda.Name = "Busqueda"
        Me.Busqueda.Size = New System.Drawing.Size(893, 30)
        Me.Busqueda.TabIndex = 241
        '
        'ColumnaEditar
        '
        Me.ColumnaEditar.HeaderText = "Editar"
        Me.ColumnaEditar.Name = "ColumnaEditar"
        Me.ColumnaEditar.ReadOnly = True
        Me.ColumnaEditar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ColumnaEditar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.ColumnaEditar.Width = 50
        '
        'RemitoidDataGridViewTextBoxColumn
        '
        Me.RemitoidDataGridViewTextBoxColumn.DataPropertyName = "remito_id"
        Me.RemitoidDataGridViewTextBoxColumn.HeaderText = "Nº Remito"
        Me.RemitoidDataGridViewTextBoxColumn.Name = "RemitoidDataGridViewTextBoxColumn"
        Me.RemitoidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RemitoestadoDataGridViewTextBoxColumn
        '
        Me.RemitoestadoDataGridViewTextBoxColumn.DataPropertyName = "remito_estado"
        Me.RemitoestadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.RemitoestadoDataGridViewTextBoxColumn.Name = "RemitoestadoDataGridViewTextBoxColumn"
        Me.RemitoestadoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'VentaprodidDataGridViewTextBoxColumn
        '
        Me.VentaprodidDataGridViewTextBoxColumn.DataPropertyName = "ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.HeaderText = "ventaprod_id"
        Me.VentaprodidDataGridViewTextBoxColumn.Name = "VentaprodidDataGridViewTextBoxColumn"
        Me.VentaprodidDataGridViewTextBoxColumn.ReadOnly = True
        Me.VentaprodidDataGridViewTextBoxColumn.Visible = False
        '
        'CLIidDataGridViewTextBoxColumn
        '
        Me.CLIidDataGridViewTextBoxColumn.DataPropertyName = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.HeaderText = "CLI_id"
        Me.CLIidDataGridViewTextBoxColumn.Name = "CLIidDataGridViewTextBoxColumn"
        Me.CLIidDataGridViewTextBoxColumn.ReadOnly = True
        Me.CLIidDataGridViewTextBoxColumn.Visible = False
        '
        'Fantasia
        '
        Me.Fantasia.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Fantasia.DataPropertyName = "Fantasia"
        Me.Fantasia.HeaderText = "Fantasia o Razón Social"
        Me.Fantasia.Name = "Fantasia"
        Me.Fantasia.ReadOnly = True
        '
        'CtaCteidDataGridViewTextBoxColumn
        '
        Me.CtaCteidDataGridViewTextBoxColumn.DataPropertyName = "CtaCte_id"
        Me.CtaCteidDataGridViewTextBoxColumn.HeaderText = "Nº Cta.Cte."
        Me.CtaCteidDataGridViewTextBoxColumn.Name = "CtaCteidDataGridViewTextBoxColumn"
        Me.CtaCteidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ventaprod_total
        '
        Me.ventaprod_total.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.ventaprod_total.DataPropertyName = "ventaprod_total"
        Me.ventaprod_total.HeaderText = "Total($)"
        Me.ventaprod_total.Name = "ventaprod_total"
        Me.ventaprod_total.ReadOnly = True
        '
        'RemitofechaDataGridViewTextBoxColumn
        '
        Me.RemitofechaDataGridViewTextBoxColumn.DataPropertyName = "remito_fecha"
        Me.RemitofechaDataGridViewTextBoxColumn.HeaderText = "Fecha"
        Me.RemitofechaDataGridViewTextBoxColumn.Name = "RemitofechaDataGridViewTextBoxColumn"
        Me.RemitofechaDataGridViewTextBoxColumn.ReadOnly = True
        Me.RemitofechaDataGridViewTextBoxColumn.Width = 130
        '
        'Remito
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.ClientSize = New System.Drawing.Size(965, 519)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BO_cliente_modificar)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MinimizeBox = False
        Me.Name = "Remito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Remito"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RemitoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DS_remito, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents BO_cliente_modificar As System.Windows.Forms.Button
    Friend WithEvents RemitoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DS_remito As Aplicacion.DS_remito
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Busqueda As System.Windows.Forms.TextBox
    Friend WithEvents ColumnaEditar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RemitoidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemitoestadoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents VentaprodidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CLIidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fantasia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CtaCteidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ventaprod_total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RemitofechaDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
