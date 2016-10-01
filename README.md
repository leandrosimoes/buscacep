# BuscaCep

Simple project to search Brazil postal codes using the CORREIOS (A government company that provides many services) web service.

## How this work?

``` vb.net
        Dim buscaCep As New BuscaCep()
        Dim address As AddressReturn = buscaCep.Search("15057-220") '15057-220 is a sample of postal code
```
