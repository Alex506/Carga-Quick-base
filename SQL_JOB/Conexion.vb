Imports System.Data.SqlClient
Imports System.Data
Imports System.Windows.Forms

Public Class Conexion
    Dim Conexion As SqlConnection
    Public Function ConectarBase()
        'Se establece la conexión con la base de datos y se le asignan los parámetros correpondientes. 
        Try
            Conexion = New SqlConnection("Data Source = 192.168.75.251; Initial catalog = msdb; Persist Security Info = True; Password=bd78952tr; User ID=sa;")
            Conexion.Open()
        Catch ex As Exception
            'En caso de que no se establezca la conexión se muestra un mensaje de error.
            MessageBox.Show(ex.Message)
        End Try
        Return Conexion
    End Function
    'Método que se encarga de cerrar la conexión.
    Public Sub CerrarConexion()
        Conexion.Close()
    End Sub
End Class
