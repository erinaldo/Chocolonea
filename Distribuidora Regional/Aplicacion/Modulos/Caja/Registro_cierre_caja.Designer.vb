﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registro_cierre_caja
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registro_cierre_caja))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tx_neto = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tx_total = New System.Windows.Forms.TextBox()
        Me.BO_Eliminar = New System.Windows.Forms.Button()
        Me.BO_guardar = New System.Windows.Forms.Button()
        Me.tx_parcial = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LB_fecha = New System.Windows.Forms.Label()
        Me.LB_nombre_usu = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tx_neto)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.tx_total)
        Me.GroupBox1.Controls.Add(Me.tx_parcial)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.LB_fecha)
        Me.GroupBox1.Controls.Add(Me.LB_nombre_usu)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(420, 169)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'tx_neto
        '
        Me.tx_neto.Enabled = False
        Me.tx_neto.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_neto.Location = New System.Drawing.Point(238, 126)
        Me.tx_neto.Name = "tx_neto"
        Me.tx_neto.Size = New System.Drawing.Size(170, 30)
        Me.tx_neto.TabIndex = 36
        Me.tx_neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Green
        Me.Label6.Location = New System.Drawing.Point(6, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(149, 25)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "MONTO NETO"
        '
        'tx_total
        '
        Me.tx_total.Enabled = False
        Me.tx_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_total.Location = New System.Drawing.Point(238, 88)
        Me.tx_total.Name = "tx_total"
        Me.tx_total.Size = New System.Drawing.Size(170, 30)
        Me.tx_total.TabIndex = 32
        Me.tx_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BO_Eliminar
        '
        Me.BO_Eliminar.Image = CType(resources.GetObject("BO_Eliminar.Image"), System.Drawing.Image)
        Me.BO_Eliminar.Location = New System.Drawing.Point(457, 129)
        Me.BO_Eliminar.Name = "BO_Eliminar"
        Me.BO_Eliminar.Size = New System.Drawing.Size(40, 40)
        Me.BO_Eliminar.TabIndex = 31
        Me.ToolTip1.SetToolTip(Me.BO_Eliminar, "Volver")
        Me.BO_Eliminar.UseVisualStyleBackColor = True
        '
        'BO_guardar
        '
        Me.BO_guardar.Image = CType(resources.GetObject("BO_guardar.Image"), System.Drawing.Image)
        Me.BO_guardar.Location = New System.Drawing.Point(456, 172)
        Me.BO_guardar.Name = "BO_guardar"
        Me.BO_guardar.Size = New System.Drawing.Size(41, 40)
        Me.BO_guardar.TabIndex = 30
        Me.ToolTip1.SetToolTip(Me.BO_guardar, "Aceptar")
        Me.BO_guardar.UseVisualStyleBackColor = True
        '
        'tx_parcial
        '
        Me.tx_parcial.Enabled = False
        Me.tx_parcial.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tx_parcial.Location = New System.Drawing.Point(238, 51)
        Me.tx_parcial.Name = "tx_parcial"
        Me.tx_parcial.Size = New System.Drawing.Size(170, 30)
        Me.tx_parcial.TabIndex = 29
        Me.tx_parcial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(6, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(229, 25)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "MONTO DE INGRESOS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label5.Location = New System.Drawing.Point(6, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 25)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "MONTO INICIAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label4.Location = New System.Drawing.Point(6, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Usuario:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.Label3.Location = New System.Drawing.Point(281, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fecha:"
        '
        'LB_fecha
        '
        Me.LB_fecha.AutoSize = True
        Me.LB_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_fecha.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_fecha.Location = New System.Drawing.Point(333, 23)
        Me.LB_fecha.Name = "LB_fecha"
        Me.LB_fecha.Size = New System.Drawing.Size(69, 15)
        Me.LB_fecha.TabIndex = 1
        Me.LB_fecha.Text = "00/00/2014"
        '
        'LB_nombre_usu
        '
        Me.LB_nombre_usu.AutoSize = True
        Me.LB_nombre_usu.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_nombre_usu.ForeColor = System.Drawing.Color.DarkSlateGray
        Me.LB_nombre_usu.Location = New System.Drawing.Point(66, 23)
        Me.LB_nombre_usu.Name = "LB_nombre_usu"
        Me.LB_nombre_usu.Size = New System.Drawing.Size(96, 15)
        Me.LB_nombre_usu.TabIndex = 0
        Me.LB_nombre_usu.Text = "Nombre usuario"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 210)
        Me.TabControl1.TabIndex = 32
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(434, 184)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Caja: Registro de Cierre"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Registro_cierre_caja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(508, 232)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.BO_guardar)
        Me.Controls.Add(Me.BO_Eliminar)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(524, 270)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(524, 270)
        Me.Name = "Registro_cierre_caja"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro de cierre de caja"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tx_total As System.Windows.Forms.TextBox
    Friend WithEvents BO_Eliminar As System.Windows.Forms.Button
    Friend WithEvents BO_guardar As System.Windows.Forms.Button
    Friend WithEvents tx_parcial As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LB_fecha As System.Windows.Forms.Label
    Friend WithEvents LB_nombre_usu As System.Windows.Forms.Label
    Friend WithEvents tx_neto As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
End Class
