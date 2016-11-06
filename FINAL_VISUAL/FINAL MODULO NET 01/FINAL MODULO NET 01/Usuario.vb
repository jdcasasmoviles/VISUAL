Public Class Usuario
    Public usuarios() As String = {"WALTER", "JUAN", "CARLOS"}
    Dim contraseñas() As String = {"INVITADO", "USER", "ADMIN"}
    Private _usuario As String
    Public Property Usuario() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property

    Private _pass As String
    Public Property Pass() As String
        Get
            Return _pass
        End Get
        Set(ByVal value As String)
            _pass = value
        End Set
    End Property

    Public Sub New()
    End Sub

    Public Sub New(User As String, Contraseña As String)
        Me.Usuario = User
        Me.Pass = Contraseña
    End Sub

    Public Function validar() As String
        Dim texto As String = ""
        If Usuario = "" Or Pass = "" Then
            texto = "Debe poner usuario y contraseña"
            Return texto
        Else
            Dim contador = 0
            For x As Integer = 0 To usuarios.Length - 1
                If Usuario = usuarios(x) And Pass = contraseñas(x) Then
                    texto = "ACCESO"
                Else
                    contador += 1
                    If contador = usuarios.Length Then
                        texto = "Error en usuario o en contraseña"
                    End If
                End If
            Next
        End If

        Return texto
    End Function

End Class
