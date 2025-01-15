Imports System.Threading

Public Class adminForm
    Public Class Vol
        Public Property Numero As String
        Public Property Destination As String
        Public Property DateHeure As DateTime
        Public Property PlacesDisponibles As Integer
        Public Property Prix As Decimal
    End Class

    Private Sub adminForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvVols.Columns.Add("Numero", "Numéro de vol")
        dgvVols.Columns.Add("Destination", "Destination")
        dgvVols.Columns.Add("DateHeure", "Date et heure")
        dgvVols.Columns.Add("PlacesDispp", "Places disponibles")
        dgvVols.Columns.Add("Prix", "Prix")
    End Sub
    Private Sub btnAjouter_Click(sender As Object, e As EventArgs) Handles btnAjouter.Click
        Try
            Dim numero = txtNumVol.Text
            Dim destination = txtDest.Text
            Dim dateHeure = dtp.Value
            Dim placesDisponibles = CInt(nudPlaceDisp.Value)
            Dim prix = nudPrix.Value

            If String.IsNullOrWhiteSpace(numero) OrElse String.IsNullOrWhiteSpace(destination) Then
                Throw New Exception("Tous les champs sont obligatoires.")
            End If

            Dim nouveauVol = New Vol With {
                .Numero = numero,
                .Destination = destination,
                .DateHeure = dateHeure,
                .PlacesDisponibles = placesDisponibles,
                .Prix = prix
            }

            DonneesVols.Vols.Add(nouveauVol)
            ActualiserDataGridView()
            MessageBox.Show("Vol ajouté .", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub ActualiserDataGridView()
        dgvVols.Rows.Clear()
        For Each Vol In DonneesVols.Vols
            dgvVols.Rows.Add(Vol.Numero, Vol.Destination, Vol.DateHeure, Vol.PlacesDisponibles, Vol.Prix)
        Next
    End Sub


    Private Sub btnSupprimer_Click(sender As Object, e As EventArgs) Handles btnSupprimer.Click
        If dgvVols.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol à supprimer SVP.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim numeroVol = dgvVols.SelectedRows(0).Cells("Numero").Value.ToString()
        Dim volSelectionne = Vols.FirstOrDefault(Function(v) v.Numero = numeroVol)
        If volSelectionne Is Nothing Then
            MessageBox.Show("Le vol sélectionné est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Vols.Remove(volSelectionne)
        ActualiserDataGridView()

        MessageBox.Show("Vol supprimé .", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btnModifier_Click(sender As Object, e As EventArgs) Handles btnModifier.Click
        If dgvVols.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol à modifier SVP.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim numeroVol = dgvVols.SelectedRows(0).Cells("Numero").Value.ToString()
        Dim volSelectionne = Vols.FirstOrDefault(Function(v) v.Numero = numeroVol)
        If volSelectionne Is Nothing Then
            MessageBox.Show("Le vol sélectionné est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        Dim result = MessageBox.Show("enregistrer les modifications", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.Yes Then
            volSelectionne.Numero = txtNumVol.Text
            volSelectionne.Destination = txtDest.Text
            volSelectionne.DateHeure = dtp.Value
            volSelectionne.PlacesDisponibles = CInt(nudPlaceDisp.Value)
            volSelectionne.Prix = nudPrix.Value
            ActualiserDataGridView()


            MessageBox.Show("Vol modifié .", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Dim loginForm As New loginForm()
        loginForm.Show()
        Me.Close()
    End Sub

End Class