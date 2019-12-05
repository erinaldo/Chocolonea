Public Class Remito
    Dim DAventa As New Datos.Venta
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Venta_Caja_seleccion_tipo_vta.Show()
        Venta_Caja_seleccion_tipo_vta.procedencia = "Remito nuevo"
        Me.Close()

    End Sub

    Private Sub Remito_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim ds_consultaremito As DataSet = DAventa.Remito_recuperar_todos
        DS_remito.Tables("Remito").Rows.Clear() 'borro el contenido del dataset.datatable clientes
        DS_remito.Tables("Remito").Merge(ds_consultaremito.Tables(0))
    End Sub

    Private Sub Busqueda_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Busqueda.KeyPress

        Dim unidades As Integer = RemitoBindingSource.Count

        Dim Filtro
        Filtro = String.Format("{0} LIKE '%{1}%'", "Fantasia", Busqueda.Text) 'esto para campos strings, FUNCIONA PERFECTO
        'Filtro = String.Format("CONVERT(Fantasia o Razón Social, System.String) LIKE '%{0}%'", Busqueda.Text)
        RemitoBindingSource.Filter = Filtro
        If DataGridView1.Rows.Count = 0 Then
            Filtro = String.Format("CONVERT(ctacte_id, System.String) LIKE '%{0}%'", Busqueda.Text)
            RemitoBindingSource.Filter = Filtro
            If DataGridView1.Rows.Count = 0 Then
                Filtro = String.Format("CONVERT(remito_id, System.String) LIKE '%{0}%'", Busqueda.Text)
                RemitoBindingSource.Filter = Filtro
            End If
        End If
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim celda_actual = e.ColumnIndex

        If celda_actual = 0 Then 'la 0 es la que tiene el check
            Dim fila As Integer = DataGridView1.CurrentRow.Index
            Dim i As Integer = 0
            While i < DataGridView1.Rows.Count
                If i <> fila Then
                    DataGridView1.Rows(i).Cells(0).Value = False
                End If
                i = i + 1
            End While
            DataGridView1.Rows(fila).Cells(0).Value = True
        End If
    End Sub
End Class