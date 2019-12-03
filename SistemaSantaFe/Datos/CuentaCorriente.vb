Imports System.Data.OleDb
Imports System.Data.DataRow
Public Class CuentaCorriente
    Inherits Datos.Conexion

    Public Function CtaCte_obtenertodo() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("CtaCte_obtenertodo", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CtaCte")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Function CtaCte_obtenertodo_Clientes() As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try

        Dim comando As New OleDbCommand("CtaCte_obtenertodo_Clientes", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CtaCte")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub CteCte_alta(ByVal CLI_id As Integer,
                                ByVal fechaalta As DateTime,
                                ByVal total As Decimal,
                                ByVal limite_deuda As Decimal
                                )
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CteCte_alta", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CLI_id", CLI_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@fechaalta", fechaalta))
        comando.Parameters.Add(New OleDb.OleDbParameter("@total", total))
        comando.Parameters.Add(New OleDb.OleDbParameter("@limite_deuda", limite_deuda))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
    End Sub



    Public Function CtaCte_buscar_id(ByVal CtaCte_id As Integer) As DataSet
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_buscar_id", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
        Return ds_JE
    End Function

    Public Sub CtaCte_modificar(ByVal CtaCte_id As Integer,
                            ByVal CtaCte_estado As String,
                            ByVal CtaCte_limitedeuda As Decimal)
        Try
            dbconn.Open()
        Catch ex As Exception
        End Try
        Dim comando As New OleDbCommand("CtaCte_modificar", dbconn)
        comando.CommandType = CommandType.StoredProcedure
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_id", CtaCte_id))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_estado", CtaCte_estado))
        comando.Parameters.Add(New OleDb.OleDbParameter("@CtaCte_limitedeuda", CtaCte_limitedeuda))
        Dim ds_JE As New DataSet()
        Dim da_JE As New OleDbDataAdapter(comando)
        da_JE.Fill(ds_JE, "CuentaCorriente")
        dbconn.Close()
    End Sub


End Class
