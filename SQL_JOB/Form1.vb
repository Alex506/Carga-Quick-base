Imports System.Data.SqlClient
Public Class Form1

    Dim conexion As New Conexion

    Private Sub Ejecutar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        Try
            Dim respuesta As DialogResult
            respuesta = MessageBox.Show("¿Realizar Envío?", "Envío Softland-Quick Base", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If respuesta = vbYes Then
                'Abrimos la conexión y llamamos al stored procedure para que ejecute el job.
                conexion.ConectarBase()
                Dim cmd As New SqlCommand("Softland_Envia", conexion.ConectarBase())
                cmd.CommandType = CommandType.StoredProcedure
                cmd.ExecuteNonQuery()
                'Mensaje de que el stored procedure es ejecutado con éxito.
                MessageBox.Show("Envío Exitoso")
                conexion.CerrarConexion()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Enviar.SetToolTip(Me.btnEnviar, "Enviar")
    End Sub
End Class
