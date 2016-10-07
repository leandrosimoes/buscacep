Imports BuscaCep.Lib.Helpers
Imports BuscaCep.Lib.Returns

Public Class BuscaCep
    Public Async Function SearchAsync(ByVal cep As String) As Task(Of AddressReturn)
        'CORREIOS is a state company and provides this service to get address by postal code and another services
        Dim url As String = "http://m.correios.com.br/movel/buscaCepConfirma.do"
        Dim dataToPost As String = "cepEntrada=" + cep + "&tipoCep=&cepTemp=&metodo=buscarCep"
        Dim method As String = "POST"
        Dim contentType As String = "application/x-www-form-urlencoded"

        Dim request As New HttpRequestHelper(url, dataToPost, method, contentType)
        Dim response As HttpResponseHelper

        Try
            response = Await request.SendAsync()
        Catch ex As Exception
            Return New AddressReturn()
        End Try

        Return response.ToAddress()
    End Function

    Public Function SearchSync(ByVal cep As String) As AddressReturn
        'CORREIOS is a state company and provides this service to get address by postal code and another services
        Dim url As String = "http://m.correios.com.br/movel/buscaCepConfirma.do"
        Dim dataToPost As String = "cepEntrada=" + cep + "&tipoCep=&cepTemp=&metodo=buscarCep"
        Dim method As String = "POST"
        Dim contentType As String = "application/x-www-form-urlencoded"

        Dim request As New HttpRequestHelper(url, dataToPost, method, contentType)
        Dim response As HttpResponseHelper

        Try
            response = request.SendSync()
        Catch ex As Exception
            Return New AddressReturn()
        End Try

        Return response.ToAddress()
    End Function
End Class
