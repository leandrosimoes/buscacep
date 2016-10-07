# BuscaCep

Simple project to search Brazil postal codes using the CORREIOS (A government company that provides many services) web service.

## How this work?

``` vb.net
        '15057-220 is a sample of postal code
        Dim cep As String = "15057-220"
        
        'Instance a new BuscaCep object
        Dim buscaCep As New BuscaCep.Lib.BuscaCep()
        
        'Declare a AddressReturn object var
        Dim address As BuscaCep.Lib.AddressReturn
        
        'Return sync
        address = buscaCep.SearchSync(cep)
        
        'Return async (Remember to use Task(Of AddressReturn))
        address = Await buscaCep.SearchAsync(cep)
        
        'This is the object return
        Public Class AddressReturn
                'Postal code
                Public Property Cep As String
                Public Property Street As String
                Public Property Neighborhood As String
                Public Property City As String
                Public Property StateInitials As String 'SP = São Paulo for example
                Public Property StateName As String

                'Unique postal codes means that the code is a generic code for the whole city
                Public Property Unique As Boolean
        End Class
```
