﻿Imports System.Configuration

Public Class Conexion

    'Conexion Victor
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SantaFe;Data Source=USUARIO-PC\SQLEXPRESS")


    'Conexion CHOCO

    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=choco;Password=123choco; Initial Catalog=SantaFe;Data Source=CHOCOLON-C08D44\SQLEXPRESS")


    'Conexion HAMERSERVER

    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=choco;Password=123choco; Initial Catalog=BD_DistribuidoraRegional;Data Source=25.17.246.216\HAMERSERVER")


    'Conexion CON EL SERVER
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_DistribuidoraRegional;Data Source=PC-PC\SQLEXPRESS")



    'Si no estoy en la casa de choco usar esta CONEXION!!!!!!!!!!!!!!!!
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Persist Security Info=False;User ID=choco;Password=123choco; Initial Catalog=SantaFe;Data Source=25.253.96.51\SQLEXPRESS")

    'Conexion Nico

    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SantaFe;Data Source=NICO_PC")

    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LaSantaFe_BD;Data Source=NICO_PC")

    'Conexion HamerServer
    ' Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SantaFe;Data Source=25.17.246.216\HAMERSERVER")

    'Conexion Casa Mariano
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SantaFe;Data Source=10.0.0.3\HAMERSERVER")

    'Conexion local NoteMariano
    Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=BD_DistribuidoraRegional;Data Source=(local)")




End Class
