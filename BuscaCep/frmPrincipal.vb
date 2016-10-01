Imports System.Threading
Imports BuscaCep.Returns

Public Class frmPrincipal
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim buscaCep As New BuscaCep()
        Dim address As AddressReturn = buscaCep.Search(txtCep.Text())

        lblCep.Text = address.Cep
        lblCity.Text = address.City
        lblNeighborhood.Text = address.Neighborhood
        lblStateInitials.Text = address.StateInitials
        lblStateName.Text = address.StateName
        lblStreet.Text = address.Street
        lblUnique.Text = If(address.Unique, "Yes", "No")
    End Sub
End Class