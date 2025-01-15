Public Class loginForm
    Private Utilisateurs As New List(Of Utilisateur) From {
        New Utilisateur With {.Nom = "admin", .MotDePasse = "admin", .Role = "Admin"},
        New Utilisateur With {.Nom = "utilisateur", .MotDePasse = "utilisateur", .Role = "Utilisateur"}
    }
    Private Class Utilisateur
        Public Property Nom As String
        Public Property MotDePasse As String
        Public Property Role As String
    End Class

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click
        Dim nom = txtNom.Text.Trim
        Dim mdp = txtMdp.Text.Trim
        Dim role = cmbRole.SelectedItem?.ToString.Trim
        If String.IsNullOrWhiteSpace(nom) OrElse String.IsNullOrWhiteSpace(mdp) OrElse role Is Nothing Then
            MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim utilisateur = Utilisateurs.FirstOrDefault(Function(u) u.Nom = nom AndAlso u.MotDePasse = mdp AndAlso u.Role = role)

        If utilisateur Is Nothing Then
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            If role = "Admin" Then
                Dim adminForm As New adminForm()
                adminForm.Show()
            Else
                Dim reservationForm As New reservationForm()
                reservationForm.Show()
            End If
            Me.Hide()
        End If
    End Sub


End Class