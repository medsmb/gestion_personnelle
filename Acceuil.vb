Public Class Acceuil

   

    Private Sub AjouterSalariésToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterSalariésToolStripMenuItem.Click
        ' Mise_à_jour_salariés.MdiParent = Me
        'Mise_à_jour_salariés.Show()

    End Sub

    Private Sub RechercherSalariésToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' ' Rechercher_Salarié.MdiParent = Me
        'Rechercher_Salarié.Show()
    End Sub

    Private Sub AccordTraivailleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Accord_travail.MdiParent = Me
        ' Accord_travail.Show()
    End Sub

    Private Sub AffecterTravailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ' Affecter_travail.MdiParent = Me
        ' Affecter_travail.Show()
    End Sub

    Private Sub AttestationDeTraivailToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AttestationDeTraivailToolStripMenuItem.Click
        ' Attestation_travail.MdiParent = Me
        ' Attestation_travail.Show()

    End Sub

    Private Sub RechercherToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercherToolStripMenuItem.Click
        recherche_stagiaire.Show()
    End Sub

    Private Sub NouveauToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NouveauToolStripMenuItem.Click
        ' Mise_à_jour_stagiaire.MdiParent = Me
        mise_ajours_stagiaire.Show()
    End Sub

    Private Sub Acceuil_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CandidatureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CandidatureToolStripMenuItem.Click
        'candidature1.Show()
    End Sub

    Private Sub RechercheCandidatureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheCandidatureToolStripMenuItem.Click
        'Type_de_recherche_Candidature.Show()
        recherche_candidat.Show()
    End Sub

    Private Sub MiseAjoursCandidatureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MiseAjoursCandidatureToolStripMenuItem.Click
        candidature.Show()
    End Sub

    Private Sub AjouterSalaréToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AjouterSalaréToolStripMenuItem.Click
        Mise_à_jour_salariés.Show()
    End Sub

    Private Sub RechercheSalariéToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheSalariéToolStripMenuItem.Click
        Rechercher_Salarié.Show()
    End Sub
End Class