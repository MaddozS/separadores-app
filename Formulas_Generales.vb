Public Class Formulas_Generales
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NombreDeSeparador.Text = TipoDeSeparador
        VtBox.Text = Vt
        CdBox.Text = Cd
        ReBox.Text = Re
    End Sub

    Private Sub Calcular_Click(sender As Object, e As EventArgs) Handles Calcular.Click
        If TipoDeSeparador = "Bifásico vertical" Then
            Dim Form As New Bifasico_Vertical
            Form.ShowDialog()
        End If
    End Sub
End Class