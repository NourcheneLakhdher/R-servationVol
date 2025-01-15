<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class adminForm
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
        txtNumVol = New TextBox()
        dtp = New DateTimePicker()
        nudPlaceDisp = New NumericUpDown()
        dgvVols = New DataGridView()
        Numero = New DataGridViewTextBoxColumn()
        Destination = New DataGridViewTextBoxColumn()
        DateHeure = New DataGridViewTextBoxColumn()
        PlaceDispo = New DataGridViewTextBoxColumn()
        Prix = New DataGridViewTextBoxColumn()
        btnAjouter = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtDest = New TextBox()
        Label3 = New Label()
        label = New Label()
        nudPrix = New NumericUpDown()
        btnModifier = New Button()
        btnSupprimer = New Button()
        btnConnexion = New Button()
        Label4 = New Label()
        Label5 = New Label()
        CType(nudPlaceDisp, ComponentModel.ISupportInitialize).BeginInit()
        CType(dgvVols, ComponentModel.ISupportInitialize).BeginInit()
        CType(nudPrix, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtNumVol
        ' 
        txtNumVol.Location = New Point(219, 74)
        txtNumVol.Name = "txtNumVol"
        txtNumVol.Size = New Size(125, 27)
        txtNumVol.TabIndex = 0
        ' 
        ' dtp
        ' 
        dtp.Location = New Point(297, 226)
        dtp.Name = "dtp"
        dtp.Size = New Size(247, 27)
        dtp.TabIndex = 1
        ' 
        ' nudPlaceDisp
        ' 
        nudPlaceDisp.Location = New Point(303, 148)
        nudPlaceDisp.Name = "nudPlaceDisp"
        nudPlaceDisp.Size = New Size(150, 27)
        nudPlaceDisp.TabIndex = 2
        ' 
        ' dgvVols
        ' 
        dgvVols.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvVols.Columns.AddRange(New DataGridViewColumn() {Numero, Destination, DateHeure, PlaceDispo, Prix})
        dgvVols.GridColor = SystemColors.ScrollBar
        dgvVols.Location = New Point(61, 284)
        dgvVols.Name = "dgvVols"
        dgvVols.RowHeadersWidth = 51
        dgvVols.Size = New Size(670, 142)
        dgvVols.TabIndex = 3
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
        Destination.HeaderText = "Destination"
        Destination.MinimumWidth = 6
        Destination.Name = "Destination"
        Destination.Width = 125
        ' 
        ' DateHeure
        ' 
        DateHeure.HeaderText = "Date et heure"
        DateHeure.MinimumWidth = 6
        DateHeure.Name = "DateHeure"
        DateHeure.Width = 125
        ' 
        ' PlaceDispo
        ' 
        PlaceDispo.HeaderText = "Places disponibles"
        PlaceDispo.MinimumWidth = 6
        PlaceDispo.Name = "PlaceDispo"
        PlaceDispo.Width = 125
        ' 
        ' Prix
        ' 
        Prix.HeaderText = "Prix"
        Prix.MinimumWidth = 6
        Prix.Name = "Prix"
        Prix.Width = 125
        ' 
        ' btnAjouter
        ' 
        btnAjouter.BackColor = Color.RoyalBlue
        btnAjouter.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnAjouter.ForeColor = SystemColors.Control
        btnAjouter.Location = New Point(45, 472)
        btnAjouter.Name = "btnAjouter"
        btnAjouter.Size = New Size(209, 47)
        btnAjouter.TabIndex = 4
        btnAjouter.Text = "Ajouter Vol"
        btnAjouter.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label1.Location = New Point(23, 64)
        Label1.Name = "Label1"
        Label1.Size = New Size(188, 45)
        Label1.TabIndex = 5
        Label1.Text = "Vol numéro:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label2.Location = New Point(392, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(187, 45)
        Label2.TabIndex = 6
        Label2.Text = "Destination:"
        ' 
        ' txtDest
        ' 
        txtDest.Location = New Point(590, 74)
        txtDest.Name = "txtDest"
        txtDest.Size = New Size(125, 27)
        txtDest.TabIndex = 7
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label3.Location = New Point(12, 137)
        Label3.Name = "Label3"
        Label3.Size = New Size(289, 45)
        Label3.TabIndex = 8
        Label3.Text = "Places disponibles:"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        label.Location = New Point(474, 137)
        label.Name = "label"
        label.Size = New Size(85, 45)
        label.TabIndex = 9
        label.Text = "Prix:"
        ' 
        ' nudPrix
        ' 
        nudPrix.Location = New Point(581, 148)
        nudPrix.Name = "nudPrix"
        nudPrix.Size = New Size(150, 27)
        nudPrix.TabIndex = 10
        ' 
        ' btnModifier
        ' 
        btnModifier.BackColor = Color.RoyalBlue
        btnModifier.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnModifier.ForeColor = SystemColors.Control
        btnModifier.Location = New Point(45, 556)
        btnModifier.Name = "btnModifier"
        btnModifier.Size = New Size(209, 47)
        btnModifier.TabIndex = 11
        btnModifier.Text = "Modifier Vol"
        btnModifier.UseVisualStyleBackColor = False
        ' 
        ' btnSupprimer
        ' 
        btnSupprimer.BackColor = Color.RoyalBlue
        btnSupprimer.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnSupprimer.ForeColor = SystemColors.Control
        btnSupprimer.Location = New Point(48, 632)
        btnSupprimer.Name = "btnSupprimer"
        btnSupprimer.Size = New Size(206, 47)
        btnSupprimer.TabIndex = 12
        btnSupprimer.Text = "Supprimer Vol"
        btnSupprimer.UseVisualStyleBackColor = False
        ' 
        ' btnConnexion
        ' 
        btnConnexion.BackColor = Color.White
        btnConnexion.Font = New Font("Akhbar MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(178))
        btnConnexion.ForeColor = Color.RoyalBlue
        btnConnexion.Location = New Point(303, 538)
        btnConnexion.Name = "btnConnexion"
        btnConnexion.Size = New Size(412, 65)
        btnConnexion.TabIndex = 13
        btnConnexion.Text = "Quitter"
        btnConnexion.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Akhbar MT", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(178))
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(297, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 55)
        Label4.TabIndex = 14
        Label4.Text = "Admin"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label5.Location = New Point(45, 218)
        Label5.Name = "Label5"
        Label5.Size = New Size(217, 45)
        Label5.TabIndex = 15
        Label5.Text = "Date et heure:"
        ' 
        ' adminForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(794, 737)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(btnConnexion)
        Controls.Add(btnSupprimer)
        Controls.Add(btnModifier)
        Controls.Add(nudPrix)
        Controls.Add(label)
        Controls.Add(Label3)
        Controls.Add(txtDest)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnAjouter)
        Controls.Add(dgvVols)
        Controls.Add(nudPlaceDisp)
        Controls.Add(dtp)
        Controls.Add(txtNumVol)
        Name = "adminForm"
        Text = "adminForm"
        CType(nudPlaceDisp, ComponentModel.ISupportInitialize).EndInit()
        CType(dgvVols, ComponentModel.ISupportInitialize).EndInit()
        CType(nudPrix, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNumVol As TextBox
    Friend WithEvents dtp As DateTimePicker
    Friend WithEvents nudPlaceDisp As NumericUpDown
    Friend WithEvents dgvVols As DataGridView
    Friend WithEvents btnAjouter As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDest As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents label As Label
    Friend WithEvents nudPrix As NumericUpDown
    Friend WithEvents btnModifier As Button
    Friend WithEvents btnSupprimer As Button
    Friend WithEvents btnConnexion As Button
    Friend WithEvents Numero As DataGridViewTextBoxColumn
    Friend WithEvents Destination As DataGridViewTextBoxColumn
    Friend WithEvents DateHeure As DataGridViewTextBoxColumn
    Friend WithEvents PlaceDispo As DataGridViewTextBoxColumn
    Friend WithEvents Prix As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
