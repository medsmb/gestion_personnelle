<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceuil
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.AjouterSalariésToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttestationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttestationDeTraivailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NouvelleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttestationDeSalaireToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttestationDeDomiciliationIrrevocableToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CertificatDeTravailToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AttestationDeStageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StagiairesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NouveauToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RechercherToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StatistiquesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.CandidatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RechercheCandidatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MiseAjoursCandidatureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AjouterSalaréToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RechercheSalariéToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterSalariésToolStripMenuItem, Me.AttestationToolStripMenuItem, Me.StagiairesToolStripMenuItem, Me.StatistiquesToolStripMenuItem, Me.ToolStripMenuItem1, Me.ToolStripMenuItem2, Me.CandidatureToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(885, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AjouterSalariésToolStripMenuItem
        '
        Me.AjouterSalariésToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AjouterSalaréToolStripMenuItem, Me.RechercheSalariéToolStripMenuItem})
        Me.AjouterSalariésToolStripMenuItem.Name = "AjouterSalariésToolStripMenuItem"
        Me.AjouterSalariésToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.AjouterSalariésToolStripMenuItem.Text = " salariés"
        '
        'AttestationToolStripMenuItem
        '
        Me.AttestationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttestationDeTraivailToolStripMenuItem, Me.AttestationDeSalaireToolStripMenuItem, Me.AttestationDeDomiciliationIrrevocableToolStripMenuItem, Me.CertificatDeTravailToolStripMenuItem, Me.AttestationDeStageToolStripMenuItem})
        Me.AttestationToolStripMenuItem.Name = "AttestationToolStripMenuItem"
        Me.AttestationToolStripMenuItem.Size = New System.Drawing.Size(77, 20)
        Me.AttestationToolStripMenuItem.Text = "Attestation"
        '
        'AttestationDeTraivailToolStripMenuItem
        '
        Me.AttestationDeTraivailToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleToolStripMenuItem})
        Me.AttestationDeTraivailToolStripMenuItem.Name = "AttestationDeTraivailToolStripMenuItem"
        Me.AttestationDeTraivailToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.AttestationDeTraivailToolStripMenuItem.Text = "Attestation de travail"
        '
        'NouvelleToolStripMenuItem
        '
        Me.NouvelleToolStripMenuItem.Name = "NouvelleToolStripMenuItem"
        Me.NouvelleToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NouvelleToolStripMenuItem.Text = "Nouvelle"
        '
        'AttestationDeSalaireToolStripMenuItem
        '
        Me.AttestationDeSalaireToolStripMenuItem.Name = "AttestationDeSalaireToolStripMenuItem"
        Me.AttestationDeSalaireToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.AttestationDeSalaireToolStripMenuItem.Text = "Attestation de salaire"
        '
        'AttestationDeDomiciliationIrrevocableToolStripMenuItem
        '
        Me.AttestationDeDomiciliationIrrevocableToolStripMenuItem.Name = "AttestationDeDomiciliationIrrevocableToolStripMenuItem"
        Me.AttestationDeDomiciliationIrrevocableToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.AttestationDeDomiciliationIrrevocableToolStripMenuItem.Text = "attestation de domiciliation irrevocable"
        '
        'CertificatDeTravailToolStripMenuItem
        '
        Me.CertificatDeTravailToolStripMenuItem.Name = "CertificatDeTravailToolStripMenuItem"
        Me.CertificatDeTravailToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.CertificatDeTravailToolStripMenuItem.Text = "Certificat de travail"
        '
        'AttestationDeStageToolStripMenuItem
        '
        Me.AttestationDeStageToolStripMenuItem.Name = "AttestationDeStageToolStripMenuItem"
        Me.AttestationDeStageToolStripMenuItem.Size = New System.Drawing.Size(280, 22)
        Me.AttestationDeStageToolStripMenuItem.Text = "Attestation de Stage"
        '
        'StagiairesToolStripMenuItem
        '
        Me.StagiairesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouveauToolStripMenuItem, Me.RechercherToolStripMenuItem})
        Me.StagiairesToolStripMenuItem.Name = "StagiairesToolStripMenuItem"
        Me.StagiairesToolStripMenuItem.Size = New System.Drawing.Size(69, 20)
        Me.StagiairesToolStripMenuItem.Text = "Stagiaires"
        '
        'NouveauToolStripMenuItem
        '
        Me.NouveauToolStripMenuItem.Name = "NouveauToolStripMenuItem"
        Me.NouveauToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NouveauToolStripMenuItem.Text = "Nouveau"
        '
        'RechercherToolStripMenuItem
        '
        Me.RechercherToolStripMenuItem.Name = "RechercherToolStripMenuItem"
        Me.RechercherToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.RechercherToolStripMenuItem.Text = "Rechercher"
        '
        'StatistiquesToolStripMenuItem
        '
        Me.StatistiquesToolStripMenuItem.Name = "StatistiquesToolStripMenuItem"
        Me.StatistiquesToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.StatistiquesToolStripMenuItem.Text = "Statistiques"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(110, 20)
        Me.ToolStripMenuItem1.Text = "Infos de saisie VG"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(12, 20)
        '
        'CandidatureToolStripMenuItem
        '
        Me.CandidatureToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RechercheCandidatureToolStripMenuItem, Me.MiseAjoursCandidatureToolStripMenuItem})
        Me.CandidatureToolStripMenuItem.Name = "CandidatureToolStripMenuItem"
        Me.CandidatureToolStripMenuItem.Size = New System.Drawing.Size(82, 20)
        Me.CandidatureToolStripMenuItem.Text = "candidature"
        '
        'RechercheCandidatureToolStripMenuItem
        '
        Me.RechercheCandidatureToolStripMenuItem.Name = "RechercheCandidatureToolStripMenuItem"
        Me.RechercheCandidatureToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.RechercheCandidatureToolStripMenuItem.Text = "recherche candidature"
        '
        'MiseAjoursCandidatureToolStripMenuItem
        '
        Me.MiseAjoursCandidatureToolStripMenuItem.Name = "MiseAjoursCandidatureToolStripMenuItem"
        Me.MiseAjoursCandidatureToolStripMenuItem.Size = New System.Drawing.Size(200, 22)
        Me.MiseAjoursCandidatureToolStripMenuItem.Text = "mise ajours candidature"
        '
        'AjouterSalaréToolStripMenuItem
        '
        Me.AjouterSalaréToolStripMenuItem.Name = "AjouterSalaréToolStripMenuItem"
        Me.AjouterSalaréToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AjouterSalaréToolStripMenuItem.Text = "ajouter salarié"
        '
        'RechercheSalariéToolStripMenuItem
        '
        Me.RechercheSalariéToolStripMenuItem.Name = "RechercheSalariéToolStripMenuItem"
        Me.RechercheSalariéToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.RechercheSalariéToolStripMenuItem.Text = "recherche salarié"
        '
        'Acceuil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(885, 419)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Acceuil"
        Me.Text = "Acceuil"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AjouterSalariésToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttestationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StagiairesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatistiquesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttestationDeTraivailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouvelleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NouveauToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercherToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttestationDeSalaireToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttestationDeDomiciliationIrrevocableToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CertificatDeTravailToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AttestationDeStageToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CandidatureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercheCandidatureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MiseAjoursCandidatureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AjouterSalaréToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RechercheSalariéToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
