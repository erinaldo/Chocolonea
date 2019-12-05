Public Class Remito

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Venta_Caja_seleccion_tipo_vta.Show()
        Venta_Caja_seleccion_tipo_vta.procedencia = "Remito nuevo"
        Me.Close()

    End Sub
End Class