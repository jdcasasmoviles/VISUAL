Imports System.IO
Public Class frmRegistroProductos
    Dim Almacen As New ArrayList
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim articulo As New Productos

        articulo.Codigo = txtCodigo.Text
        articulo.Nombre = txtNombre.Text
        articulo.Tipo = cboTipo.Text
        articulo.Marca = txtMarca.Text
        Almacen.Add(articulo)
        MessageBox.Show("Producto registrado satisfactoriamente.....", "AVISO")
    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        ListView1.Items.Clear()
        For Each articulo As Productos In Almacen
            Dim it As New ListViewItem(articulo.Codigo)
            'agregar subitems a it
            it.SubItems.Add(articulo.Nombre)
            it.SubItems.Add(articulo.Tipo)
            it.SubItems.Add(articulo.Marca)
            ListView1.Items.Add(it)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim filepath As String = "test.txt"
        Using file As New IO.StreamWriter(filepath, False)
            Dim line As String = ""
            For Each item As ListViewItem In Me.ListView1.Items
                line = ""
                For Each subitem As ListViewItem.ListViewSubItem In item.SubItems
                    line += subitem.Text + vbTab
                Next
                file.WriteLine(line)
            Next
            file.Close()
        End Using
        Process.Start(filepath)
    End Sub
End Class