Imports System.Text.RegularExpressions
Imports BuscaCep.Lib.Returns

Namespace Helpers
    Public Class HttpResponseHelper
        Public Shared Property Text() As String

        Public Sub New(ByVal responseText As String)
            Text = responseText
        End Sub

        'The service unfortunately returns an html, so I have to make this method to get the values
        Private Function GetValueByTag(tag As String) As String
            Try
                Dim value = Text

                value = value.Replace(vbCr, "").Replace(vbLf, "")
                value = value.Substring(value.IndexOf(Convert.ToString("<span class=""resposta"">") & tag))
                value = value.Substring(value.IndexOf("<span class=""respostadestaque"">") + 31)

                Dim result = value.Substring(0, value.IndexOf("</span>"))

                Return result.Trim()
            Catch generatedExceptionName As ArgumentOutOfRangeException
                Return String.Empty
            End Try
        End Function

        Public Function ToAddress() As AddressReturn
            Dim address = New AddressReturn() With {
                .Street = GetValueByTag("Logradouro").Split("-"c)(0).Trim(),
                .Neighborhood = GetValueByTag("Bairro"),
                .City = Regex.Match(GetValueByTag("Localidade"), "^(.*?)   ").Groups(1).Value,
                .StateInitials = Regex.Match(GetValueByTag("Localidade"), "([A-Z]{2})$").Groups(1).Value,
                .Cep = GetValueByTag("CEP")
            }

            Return address
        End Function
    End Class
End Namespace