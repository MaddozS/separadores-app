Public Class Bifasico_Vertical

    Private Sub Bifasico_Vertical_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dmin = Calcular_Dmin(Qg, Z, T, P, Pg, Pl, Cd, Dm)
        DminBox.Text = Dmin

        NombreDeSeparador.Text = TipoDeSeparador
    End Sub

    Private Sub ListBox1_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles TrList.KeyDown, DList.KeyDown, HList.KeyDown, LssList.KeyDown, Rel_EsList.KeyDown
        If e.Control AndAlso e.KeyCode = Keys.C Then
            Clipboard.SetText(sender.SelectedItem)
        End If
    End Sub
    Private Function Calcular_Dmin(Qg As Double, Z As Double, T As Double, P As Double, Pg As Double, Pl As Double, Cd As Double, Dm As Double) As Double
        Dim Dmin As Double
        Dmin = (5040 * ((Qg * Z * T) / P) * (((Pg / (Pl - Pg)) * (Cd / Dm)) ^ 0.5)) ^ (1 / 2)

        Return Dmin
    End Function

    Private Function Calcular_H(Tr As Double, Ql As Double, D As Double) As Double
        Dim H As Double
        H = (Ql * (Tr / 0.12)) / (D ^ 2)
        Return H
    End Function

    Private Function Calcular_Lss(H As Double) As Double
        Dim Lss As Double
        Lss = (H + 76) / 12

        Return Lss
    End Function

    Private Function Calcular_Rel_Esbeltez(Lss As Double, D As Double) As Double
        Dim Rel_Esbeltez As Double
        Rel_Esbeltez = (Lss * 12) / D

        Return Rel_Esbeltez
    End Function

    Private Sub AddD_Click(sender As Object, e As EventArgs) Handles AddD.Click
        Add_D()
    End Sub

    Private Sub DEntrada_TextChanged(sender As Object, e As KeyEventArgs) Handles DEntrada.KeyDown
        If e.KeyCode = Keys.Enter Then
            Add_D()
        End If
    End Sub
    Private Sub Add_D()
        Dim _ErrorWindow As New ErrorWindow
        If Verificar_Entrada(DEntrada, _ErrorWindow.Errors, "D") Then
            _ErrorWindow.ShowDialog()
        Else
            D = Double.Parse(DEntrada.Text)
            H = Calcular_H(Tr, Ql, D)
            Lss = Calcular_Lss(H)
            Rel_Esbeltez = Calcular_Rel_Esbeltez(Lss, D)
            Console.WriteLine("H: {0}, Lss: {1}, Relacion de Esbeltez: {2}", H, Lss, Rel_Esbeltez)
            If Rel_Esbeltez < 4 And Rel_Esbeltez > 3 Then
                TrList.Items.Add(Tr)
                DList.Items.Add(D)
                HList.Items.Add(H)
                LssList.Items.Add(Lss)
                Rel_EsList.Items.Add(Rel_Esbeltez)
            End If
        End If
    End Sub

End Class