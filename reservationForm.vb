Public Class reservationForm

    Private Sub btnRechercher_Click(sender As Object, e As EventArgs) Handles btnRechercher.Click
        Dim destination = txtRechercheDest.Text
        Dim RechercheDate = dtpRechercheDate.Value
        If DonneesVols.Vols Is Nothing OrElse DonneesVols.Vols.Count = 0 Then
            MessageBox.Show("La liste des vols n'est pas initialisée ou vide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(destination) Then
            MessageBox.Show("Veuillez entrer une destination.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        ' Recherche des vols
        Dim volT = DonneesVols.Vols.Where(Function(v) v.Destination.Contains(destination, StringComparison.OrdinalIgnoreCase) AndAlso v.DateHeure.Date = RechercheDate.Date).ToList()

        ' Mise à jour du DataGridView
        dgvResult.Rows.Clear()

        For Each vol In volT
            dgvResult.Rows.Add(vol.Numero, vol.Destination, vol.DateHeure, vol.PlacesDisponibles, vol.Prix)
        Next

        ' Affichage d'un message si aucun vol n'a été trouvé
        If volT.Count = 0 Then
            MessageBox.Show("Aucun vol trouvé.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnReserver_Click(sender As Object, e As EventArgs) Handles btnReserver.Click

        If dgvResult.SelectedRows.Count = 0 Then
            MessageBox.Show("Veuillez sélectionner un vol.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim ligneSelectionnee = dgvResult.SelectedRows(0)
        Dim numeroVol = ligneSelectionnee.Cells("Numero").Value.ToString()
        Dim volSelectionne = Vols.FirstOrDefault(Function(v) v.Numero = numeroVol)
        If volSelectionne Is Nothing Then
            MessageBox.Show("Le vol sélectionné est introuvable.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If volSelectionne.PlacesDisponibles <= 0 Then
            MessageBox.Show("Aucune place disponible pour ce vol.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        If String.IsNullOrWhiteSpace(txtNom.Text) OrElse String.IsNullOrWhiteSpace(txtPrenom.Text) OrElse String.IsNullOrWhiteSpace(txtTel.Text) Then
            MessageBox.Show("Veuillez remplir toutes les informations du client.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        volSelectionne.PlacesDisponibles -= 1
        ''ActualiserResultats()
        Dim recu = $"Reçu :{Environment.NewLine}" &
                   $"Vol : {volSelectionne.Numero}{Environment.NewLine}" &
                   $"Destination : {volSelectionne.Destination}{Environment.NewLine}" &
                   $"Date et heure : {volSelectionne.DateHeure}{Environment.NewLine}" &
                   $"Client : {txtNom.Text} {txtPrenom.Text}{Environment.NewLine}" &
                   $"Téléphone : {txtTel.Text}{Environment.NewLine}"
        MessageBox.Show(recu, "Reçu de Réservation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        MessageBox.Show("Réservation terminée ", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
    Private Sub btnDeconnexion_Click(sender As Object, e As EventArgs) Handles btnDeconnexion.Click
        Dim loginForm As New loginForm()
        loginForm.Show()
        Me.Close()
    End Sub


End Class