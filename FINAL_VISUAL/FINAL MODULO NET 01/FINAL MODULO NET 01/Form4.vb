Public Class frmRegistroNotas
    Dim objeto As New Alumno

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        For Each obj As Object In Me.Controls
            If TypeOf obj Is TextBox Then obj.Text = String.Empty
        Next
        cboCurso.SelectedIndex = 0
        lblMsg.Text = String.Empty
        txtAlumno.Focus()
        btnLimpiar.Enabled = True
        btnProceso.Enabled = True
    End Sub

    Private Sub btnProceso_Click(sender As Object, e As EventArgs) Handles btnProceso.Click
        objeto.RegistraDatos(Single.Parse(txtN1.Text), Single.Parse(txtN2.Text), Single.Parse(txtN3.Text))

        txtCodigo.Text = objeto.Codigo
        txtPromedio.Text = objeto.Promedio.ToString("n2")
        lblMsg.Text = objeto.Mensaje
        btnProceso.Enabled = False
        btnLimpiar.Enabled = True
    End Sub
End Class