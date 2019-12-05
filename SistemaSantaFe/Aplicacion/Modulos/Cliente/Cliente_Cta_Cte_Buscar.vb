Imports System.IO
Imports System.Data.OleDb
Public Class Cliente_Cta_Cte_Buscar
    Dim DAcliente As New Datos.CuentaCorriente

    Dim busqueda As String = ""
    Dim busqueda_parametro As String = ""
    Dim ds_clie As DataSet

    Private Sub Cliente_Cta_Cte_Buscar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Obtener_Clientes()
    End Sub

    Public Sub Obtener_Clientes()
        ds_clie = DAcliente.CtaCte_obtenertodo_Clientes()
        If ds_clie.Tables(0).Rows.Count <> 0 Then
            Cliente_ds.Tables("Cliente_CtaCte").Rows.Clear() 'borro el contenido del dataset.datatable clientes
            Cliente_ds.Tables("Cliente_CtaCte").Merge(ds_clie.Tables(0)) '' al combinarla con el dataset "cliente" ya puedo filtrar
            'DG_clientes.DataSource = ds_clie.Tables(0)
            'DG_clientes_old.DataSource = ds_clie.Tables(0)
        End If
    End Sub

    Private Sub BO_cliente_modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If DG_clientes.Rows.Count <> 0 Then
            Dim productoselec As String = DG_clientes.SelectedCells(0).Value
            If productoselec <> "" Then
                Cliente_alta_New.Close() 'lo cierro porque uso el mismo form para dar de alta

                Cliente_alta_New.Text = "Modificar cliente"
                'Proveedor_alta.Text = "Modificar proveedor"
                Cliente_alta_New.cliente_id = CInt(productoselec)
                'Proveedor_alta.proveedor_id = CInt(productoselec)
                Cliente_alta_New.form_procedencia = "modificar"
                Cliente_alta_New.tx_Fan.Text = DG_clientes.SelectedCells(1).Value
                'Proveedor_alta.tx_nombre.Text = DataGrid_proveedor.SelectedCells(2).Value
                Me.Close()
                Cliente_alta_New.apertura = "formulario modificar" 'para q valide el boton cancelar del form alta
                Cliente_alta_New.Show()
            Else
                MsgBox("Seleccione un cliente", MsgBoxStyle.Information)
            End If
        Else
            MsgBox("Seleccione un cliente", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub TextBox1_GotFocus1(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.GotFocus
        TextBox1.SelectAll()
        TextBox1.BackColor = Color.FromArgb(255, 255, 192)
    End Sub

    Private Sub TextBox1_KeyPress1(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "CLI_Fan", TextBox1.Text) 'esto para campos strings, FUNCIONA PERFECTO
        ClienteCtaCteBindingSource.Filter = Filtro
    End Sub


    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.LostFocus
        TextBox1.BackColor = Color.White
    End Sub

End Class