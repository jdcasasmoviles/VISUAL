Imports System.IO
Public Class frmAdmArchivos
    Dim raiz As String

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim C As New DirectoryInfo("C:\")
        raiz = C.Root.ToString

        For Each D As DirectoryInfo In C.GetDirectories
            cboDirectorio.Items.Add(D.Name)
        Next
    End Sub

    Private Sub cboDirectorio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDirectorio.SelectedIndexChanged
        Dim D As New DirectoryInfo(raiz + cboDirectorio.Text)
        ListView1.Items.Clear()

        Try
            For Each Dr As FileInfo In D.GetFiles
                Dim it As New ListViewItem(Dr.Name)
                it.SubItems.Add(Dr.Extension)
                it.SubItems.Add(Dr.Length)
                ListView1.Items.Add(it)
            Next
        Catch ex As UnauthorizedAccessException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class