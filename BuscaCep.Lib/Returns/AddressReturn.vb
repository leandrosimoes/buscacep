Imports BuscaCep.Lib.Enums

Namespace Returns
    Public Class AddressReturn
        'Dictionary to get name of Brazil states by you initials
        Private Shared StatesList As IDictionary(Of String, String) = New Dictionary(Of String, String)() From {
            {States.AC.ToString(), "Ácre"},
            {States.AL.ToString(), "Alagoas"},
            {States.AM.ToString(), "Amapá"},
            {States.AP.ToString(), "Amazonas"},
            {States.BA.ToString(), "Bahia"},
            {States.CE.ToString(), "Ceará"},
            {States.DF.ToString(), "Distrito Federal"},
            {States.ES.ToString(), "Espírito Santo"},
            {States.GO.ToString(), "Goiás"},
            {States.MA.ToString(), "Maranhão"},
            {States.MG.ToString(), "Minas Gerais"},
            {States.MT.ToString(), "Mato Grosso"},
            {States.MS.ToString(), "Mato Grosso do Sul"},
            {States.PA.ToString(), "Pará"},
            {States.PB.ToString(), "Paraíba"},
            {States.PE.ToString(), "Pernambuco"},
            {States.PI.ToString(), "Piauí"},
            {States.PR.ToString(), "Paraná"},
            {States.RJ.ToString(), "Rio de Janeiro"},
            {States.RN.ToString(), "Rio Grande do Norte"},
            {States.RO.ToString(), "Rondônia"},
            {States.RR.ToString(), "Roraima"},
            {States.RS.ToString(), "Rio Grande do Sul"},
            {States.SC.ToString(), "Santa Catarina"},
            {States.SE.ToString(), "Sergipe"},
            {States.SP.ToString(), "São Paulo"},
            {States.TO.ToString(), "Tocantins"}
        }

        'Postal code
        Public Property Cep As String

        Public Property Street As String
        Public Property Neighborhood As String
        Public Property City As String
        Public Property StateInitials As String
        Public Property StateName As String
            Get
                Dim returnText As String = ""

                Try
                    returnText = StatesList(StateInitials.ToUpper())
                Catch ex As Exception
                    returnText = ""
                End Try

                Return returnText
            End Get
            Set(value As String)
            End Set
        End Property

        'Unique postal codes means that the code is a generic code for the whole city
        Public Property Unique As Boolean
            Get
                Return String.IsNullOrEmpty(Street) AndAlso Not String.IsNullOrEmpty(Cep)
            End Get
            Set(value As Boolean)
            End Set
        End Property
    End Class
End Namespace