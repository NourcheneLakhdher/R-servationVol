<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reservationForm
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtRechercheDest = New TextBox()
        dtpRechercheDate = New DateTimePicker()
        dgvResult = New DataGridView()
        Numero = New DataGridViewTextBoxColumn()
        Destination = New DataGridViewTextBoxColumn()
        DateHeure = New DataGridViewTextBoxColumn()
        PlaceDispo = New DataGridViewTextBoxColumn()
        Prix = New DataGridViewTextBoxColumn()
        btnRechercher = New Button()
        label = New Label()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        txtTel = New TextBox()
        txtPrenom = New TextBox()
        txtNom = New TextBox()
        btnDeconnexion = New Button()
        btnReserver = New Button()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        CType(dgvResult, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtRechercheDest
        ' 
        txtRechercheDest.Location = New Point(240, 97)
        txtRechercheDest.Name = "txtRechercheDest"
        txtRechercheDest.Size = New Size(125, 27)
        txtRechercheDest.TabIndex = 0
        ' 
        ' dtpRechercheDate
        ' 
        dtpRechercheDate.Location = New Point(551, 97)
        dtpRechercheDate.Name = "dtpRechercheDate"
        dtpRechercheDate.Size = New Size(250, 27)
        dtpRechercheDate.TabIndex = 1
        ' 
        ' dgvResult
        ' 
        dgvResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvResult.Columns.AddRange(New DataGridViewColumn() {Numero, Destination, DateHeure, PlaceDispo, Prix})
        dgvResult.Location = New Point(70, 312)
        dgvResult.Name = "dgvResult"
        dgvResult.RowHeadersWidth = 51
        dgvResult.Size = New Size(680, 131)
        dgvResult.TabIndex = 2
        ' 
        ' Numero
        ' 
        Numero.HeaderText = "Numéro de vol"
        Numero.MinimumWidth = 6
        Numero.Name = "Numero"
        Numero.Width = 125
        ' 
        ' Destination
        ' 
        Destination.HeaderText = "Destination de vol"
        Destination.MinimumWidth = 6
        Destination.Name = "Destination"
        Destination.Width = 125
        ' 
        ' DateHeure
        ' 
        DateHeure.HeaderText = "Date et heure du vol"
        DateHeure.MinimumWidth = 6
        DateHeure.Name = "DateHeure"
        DateHeure.Width = 125
        ' 
        ' PlaceDispo
        ' 
        PlaceDispo.HeaderText = "Nombre de places disponibles"
        PlaceDispo.MinimumWidth = 6
        PlaceDispo.Name = "PlaceDispo"
        PlaceDispo.Width = 125
        ' 
        ' Prix
        ' 
        Prix.HeaderText = "Prix du vol"
        Prix.MinimumWidth = 6
        Prix.Name = "Prix"
        Prix.Width = 125
        ' 
        ' btnRechercher
        ' 
        btnRechercher.BackColor = Color.RoyalBlue
        btnRechercher.Font = New Font("Akhbar MT", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnRechercher.ForeColor = SystemColors.Control
        btnRechercher.Location = New Point(227, 155)
        btnRechercher.Name = "btnRechercher"
        btnRechercher.Size = New Size(383, 83)
        btnRechercher.TabIndex = 3
        btnRechercher.Text = "Voir vols disponibles"
        btnRechercher.UseVisualStyleBackColor = False
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        label.Location = New Point(23, 87)
        label.Name = "label"
        label.Size = New Size(187, 45)
        label.TabIndex = 4
        label.Text = "Destination:"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label1.Location = New Point(408, 530)
        Label1.Name = "Label1"
        Label1.Size = New Size(127, 45)
        Label1.TabIndex = 5
        Label1.Text = "Prénom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label2.Location = New Point(423, 470)
        Label2.Name = "Label2"
        Label2.Size = New Size(84, 45)
        Label2.TabIndex = 6
        Label2.Text = "Nom"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label3.Location = New Point(264, 592)
        Label3.Name = "Label3"
        Label3.Size = New Size(313, 45)
        Label3.TabIndex = 7
        Label3.Text = "Numéro de téléphone"
        ' 
        ' txtTel
        ' 
        txtTel.Location = New Point(604, 602)
        txtTel.Name = "txtTel"
        txtTel.Size = New Size(125, 27)
        txtTel.TabIndex = 10
        ' 
        ' txtPrenom
        ' 
        txtPrenom.Location = New Point(604, 530)
        txtPrenom.Name = "txtPrenom"
        txtPrenom.Size = New Size(125, 27)
        txtPrenom.TabIndex = 11
        ' 
        ' txtNom
        ' 
        txtNom.Location = New Point(604, 470)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(125, 27)
        txtNom.TabIndex = 12
        ' 
        ' btnDeconnexion
        ' 
        btnDeconnexion.BackColor = Color.RoyalBlue
        btnDeconnexion.Font = New Font("Akhbar MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(178))
        btnDeconnexion.ForeColor = Color.WhiteSmoke
        btnDeconnexion.Location = New Point(34, 663)
        btnDeconnexion.Name = "btnDeconnexion"
        btnDeconnexion.Size = New Size(361, 62)
        btnDeconnexion.TabIndex = 13
        btnDeconnexion.Text = "Quitter"
        btnDeconnexion.UseVisualStyleBackColor = False
        ' 
        ' btnReserver
        ' 
        btnReserver.BackColor = Color.RoyalBlue
        btnReserver.Font = New Font("Akhbar MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(178))
        btnReserver.ForeColor = SystemColors.Control
        btnReserver.Location = New Point(423, 663)
        btnReserver.Name = "btnReserver"
        btnReserver.Size = New Size(365, 62)
        btnReserver.TabIndex = 14
        btnReserver.Text = "Réserver"
        btnReserver.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Akhbar MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(178))
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(290, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(206, 55)
        Label4.TabIndex = 15
        Label4.Text = "Utilisateur"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label5.Location = New Point(435, 87)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 45)
        Label5.TabIndex = 16
        Label5.Text = "Date:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Akhbar MT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(178))
        Label6.Location = New Point(23, 257)
        Label6.Name = "Label6"
        Label6.Size = New Size(294, 50)
        Label6.TabIndex = 17
        Label6.Text = "Vols disponibles:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Akhbar MT", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(178))
        Label7.Location = New Point(23, 470)
        Label7.Name = "Label7"
        Label7.Size = New Size(344, 50)
        Label7.TabIndex = 18
        Label7.Text = "Entrez vos données:"
        ' 
        ' reservationForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 737)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnReserver)
        Controls.Add(btnDeconnexion)
        Controls.Add(txtNom)
        Controls.Add(txtPrenom)
        Controls.Add(txtTel)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(label)
        Controls.Add(btnRechercher)
        Controls.Add(dgvResult)
        Controls.Add(dtpRechercheDate)
        Controls.Add(txtRechercheDest)
        Name = "reservationForm"
        Text = "reservationForm"
        CType(dgvResult, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtRechercheDest As TextBox
    Friend WithEvents dtpRechercheDate As DateTimePicker
    Friend WithEvents dgvResult As DataGridView
    Friend WithEvents btnRechercher As Button
    Friend WithEvents label As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtTel As TextBox
    Friend WithEvents txtPrenom As TextBox
    Friend WithEvents txtNom As TextBox
    Friend WithEvents btnDeconnexion As Button
    Friend WithEvents btnReserver As Button
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Destination As DataGridViewTextBoxColumn
    Friend WithEvents DateHeure As DataGridViewTextBoxColumn
    Friend WithEvents PlaceDispo As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
