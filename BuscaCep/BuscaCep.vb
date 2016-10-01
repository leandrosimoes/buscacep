Imports BuscaCep.Helpers
Imports BuscaCep.Returns

Public Class BuscaCep
    Public Function Search(ByVal cep As String) As AddressReturn
        'CORREIOS is a state company and provides this service to get address by postal code and another services
        Dim url As String = "http://m.correios.com.br/movel/buscaCepConfirma.do"
        Dim dataToPost As String = "cepEntrada=" + cep + "&tipoCep=&cepTemp=&metodo=buscarCep"
        Dim method As String = "POST"
        Dim contentType As String = "application/x-www-form-urlencoded"

        Dim request As New HttpRequestHelper(url, dataToPost, method, contentType)
        Dim response As HttpResponseHelper

        Try
            response = request.Send()
        Catch ex As Exception
            Return New AddressReturn()
        End Try

        Return response.ToAddress()
    End Function
End Class
