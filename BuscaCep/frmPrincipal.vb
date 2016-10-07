Imports BuscaCep.Lib.Returns

Public Class frmPrincipal
    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        DoSearchAsync()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DoSearchSync()
    End Sub

    Private Async Sub DoSearchAsync()
        Dim buscaCep As New [Lib].BuscaCep()
        Dim address As AddressReturn = Await buscaCep.SearchAsync(txtCep.Text())

        lblCep.Text = address.Cep
        lblCity.Text = address.City
        lblNeighborhood.Text = address.Neighborhood
        lblStateInitials.Text = address.StateInitials
        lblStateName.Text = address.StateName
        lblStreet.Text = address.Street
        lblUnique.Text = If(address.Unique, "Yes", "No")
    End Sub

    Private Sub DoSearchSync()
        Dim buscaCep As New [Lib].BuscaCep()
        Dim address As AddressReturn = buscaCep.SearchSync(txtCep.Text())

        lblCep.Text = address.Cep
        lblCity.Text = address.City
        lblNeighborhood.Text = address.Neighborhood
        lblStateInitials.Text = address.StateInitials
        lblStateName.Text = address.StateName
        lblStreet.Text = address.Street
        lblUnique.Text = If(address.Unique, "Yes", "No")
    End Sub
End Class