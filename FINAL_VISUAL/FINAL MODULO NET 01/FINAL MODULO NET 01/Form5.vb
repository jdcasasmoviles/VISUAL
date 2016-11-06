Public Class frmLogueo

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        Dim obj As New Usuario(cboUsuario.Text, txtPass.Text)
        Dim mensaje As String = obj.validar()
        MsgBox(mensaje)
        If mensaje.Equals("ACCESO") Then
            MenuPrincipal.Show()
        End If
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        For Each objcon As Object In Me.Controls
            If TypeOf objcon Is TextBox Then objcon.Text = String.Empty
        Next
        cboUsuario.Focus()
    End Sub

    Private Sub frmLogueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim arreglo As New Usuario()
        For x As Integer = 0 To arreglo.usuarios.Length - 1
            cboUsuario.Items.Add(arreglo.usuarios(x))
            Next
    End Sub
End Class