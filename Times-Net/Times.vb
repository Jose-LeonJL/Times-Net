Namespace Times
    Public Class Times
        'Variables
        Private _Dia As Long
        Private _Hora As Integer
        Private _Minuto As Integer
        Private _Segundo As Integer
        'Propiedades

        'Constructores
        Public Sub New()
            Me._Dia = 86400000
            Me._Hora = 24
            Me._Minuto = 60
            Me._Segundo = 60
        End Sub
        'Procesos y funciones
        ''' <summary>
        ''' Obtiene la fecha actual del sistema y la convierte en formato Unix
        ''' </summary>
        ''' <returns>Fecha Actual - Unix</returns>
        Public Function Now() As Long
            Dim Resultado As Long = 0
            Try
                Resultado = DateTimeOffset.Now.ToUnixTimeSeconds
            Catch ex As Exception
                Throw ex
            End Try
            Return Resultado
        End Function

        ''' <summary>
        ''' Obtiene la fecha actual del sistema sin horas y la convierte en formato Unix
        ''' </summary>
        ''' <returns>Fecha Actual</returns>
        Public Function Now_Sin_Horas() As Long
            Dim resultado As Long
            Try
                Dim Fecha = New DateTimeOffset(DateTime.Now.ToShortDateString)
                resultado = Fecha.ToUnixTimeSeconds
            Catch ex As Exception
                Throw ex
            End Try
            Return resultado
        End Function

        ''' <summary>
        ''' Obtiene la fecha en la cantidad de dias pasados sin horas
        ''' </summary>
        ''' <returns>Fechas pasadas</returns>
        Public Function Dias_Pasados_SinHoras(ByVal Dias As Integer) As Long
            Dim resultado As Long
            Try
                resultado = ((Me.Now_Sin_Horas * 1000) - (Dias * Me._Dia)) / 1000
            Catch ex As Exception
                Throw ex
            End Try
            Return resultado
        End Function

        ''' <summary>
        ''' Obtiene la fecha en la cantidad de dias pasados completos
        ''' </summary>
        ''' <returns>Fechas pasadas</returns>
        Public Function Dias_Pasados(ByVal Dias As Integer) As Long
            Dim resultado As Long
            Try
                resultado = ((Me.Now * 1000) - (Dias * Me._Dia)) / 1000
            Catch ex As Exception
                Throw ex
            End Try
            Return resultado
        End Function
    End Class
End Namespace
