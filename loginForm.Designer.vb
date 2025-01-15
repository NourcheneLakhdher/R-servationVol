<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginForm
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
        txtNom = New TextBox()
        cmbRole = New ComboBox()
        btnConnexion = New Button()
        Label1 = New Label()
        Label2 = New Label()
        txtMdp = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtNom
        ' 
        txtNom.Location = New Point(422, 109)
        txtNom.Name = "txtNom"
        txtNom.Size = New Size(275, 27)
        txtNom.TabIndex = 0
        ' 
        ' cmbRole
        ' 
        cmbRole.FormattingEnabled = True
        cmbRole.Items.AddRange(New Object() {"Admin", "Utilisateur"})
        cmbRole.Location = New Point(422, 265)
        cmbRole.Name = "cmbRole"
        cmbRole.Size = New Size(275, 28)
        cmbRole.TabIndex = 1
        ' 
        ' btnConnexion
        ' 
        btnConnexion.BackColor = Color.RoyalBlue
        btnConnexion.Font = New Font("Akhbar MT", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        btnConnexion.ForeColor = SystemColors.Control
        btnConnexion.Location = New Point(209, 366)
        btnConnexion.Name = "btnConnexion"
        btnConnexion.Size = New Size(409, 51)
        btnConnexion.TabIndex = 2
        btnConnexion.Text = "Se connecter"
        btnConnexion.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label1.Location = New Point(91, 109)
        Label1.Name = "Label1"
        Label1.Size = New Size(193, 45)
        Label1.TabIndex = 3
        Label1.Text = "Donnez nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label2.Location = New Point(67, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(318, 45)
        Label2.TabIndex = 4
        Label2.Text = "Donnez mot de passe"
        ' 
        ' txtMdp
        ' 
        txtMdp.Location = New Point(422, 183)
        txtMdp.Name = "txtMdp"
        txtMdp.Size = New Size(275, 27)
        txtMdp.TabIndex = 5
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Akhbar MT", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(178))
        Label3.Location = New Point(91, 255)
        Label3.Name = "Label3"
        Label3.Size = New Size(262, 45)
        Label3.TabIndex = 6
        Label3.Text = "Donnez votre rôle"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Akhbar MT", 28.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(178))
        Label4.ForeColor = Color.RoyalBlue
        Label4.Location = New Point(240, 9)
        Label4.Name = "Label4"
        Label4.Size = New Size(307, 80)
        Label4.TabIndex = 7
        Label4.Text = "Bienvenue"
        ' 
        ' loginForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ButtonHighlight
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(txtMdp)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnConnexion)
        Controls.Add(cmbRole)
        Controls.Add(txtNom)
        Name = "loginForm"
        Text = "loginForm"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtNom As TextBox
    Friend WithEvents cmbRole As ComboBox
    Friend WithEvents btnConnexion As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMdp As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
