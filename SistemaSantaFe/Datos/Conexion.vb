Imports System.Configuration

Public Class Conexion

    'Conexion HAMERSERVER
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=192.168.1.4\HAMERSERVER")

    'Conexion CHOCO-RYZEN
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=sa;Initial Catalog=SantaFe;Data Source=DESKTOP-IPJ62B9\SQLEXPRESS")

    'Conexion local NoteMariano
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=SantaFe;Data Source=(local)")

    'Conexion Servidor la Delfina(Local)
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=choco2304;Persist Security Info=True;User ID=sa;Initial Catalog=HamerBD;Data Source=LADELFINA-\SQLEXPRESS")

    'Conexion Servidor la Delfina(remota)
    'Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=choco2304;Persist Security Info=True;User ID=sa;Initial Catalog=HamerBD;Data Source=25.48.241.89\LADELFINA-\SQLEXPRESS")

    'Conexion Mariano Notebook chocolalskjdasda 
    Public dbconn As New OleDb.OleDbConnection("Provider=SQLOLEDB.1;Password=123choco;Persist Security Info=True;User ID=choco;Initial Catalog=SantaFe;Data Source=HAMER")

End Class
