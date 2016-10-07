Imports System.IO
Imports System.Net
Imports System.Text

Namespace Helpers
    Public Class HttpRequestHelper
        Public Shared Property Url As String
        Public Shared Property DataToSend As String
        Public Shared Property Method As String
        Public Shared Property ContentType As String

        Public Sub New(ByVal sUrl As String, ByVal sDataToSend As String, ByVal sMethod As String, ByVal sContentType As String)
            Url = sUrl
            DataToSend = sDataToSend
            Method = sMethod
            ContentType = sContentType
        End Sub

        Public Async Function SendAsync() As Task(Of HttpResponseHelper)
            Dim request As HttpWebRequest = WebRequest.Create(Url)
            request.Method = Method
            request.ContentType = ContentType
            Dim postBytes As Byte() = Encoding.ASCII.GetBytes(DataToSend)

            Using requestStream As Stream = request.GetRequestStream()
                Await requestStream.WriteAsync(postBytes, 0, postBytes.Length)

                Using response As WebResponse = Await request.GetResponseAsync()
                    Using stream As Stream = response.GetResponseStream()
                        Using responseText As New StreamReader(stream, Encoding.GetEncoding("ISO-8859-1"))
                            Return New HttpResponseHelper(Await responseText.ReadToEndAsync())
                        End Using
                    End Using
                End Using
            End Using
        End Function

        Public Function SendSync() As HttpResponseHelper
            Dim request As HttpWebRequest = WebRequest.Create(Url)
            request.Method = Method
            request.ContentType = ContentType
            Dim postBytes As Byte() = Encoding.ASCII.GetBytes(DataToSend)

            Using requestStream As Stream = request.GetRequestStream()
                requestStream.Write(postBytes, 0, postBytes.Length)

                Using response As Stream = request.GetResponse().GetResponseStream()
                    Using responseText As New StreamReader(response, Encoding.GetEncoding("ISO-8859-1"))
                        Return New HttpResponseHelper(responseText.ReadToEnd())
                    End Using
                End Using
            End Using
        End Function
    End Class
End Namespace