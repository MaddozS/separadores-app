Imports Microsoft.VisualBasic

Public Class Variables
    Dim CdUser As Double
    Dim Pg As Double
    Dim Pl As Double
    Dim Dm As Double
    Dim Qg As Double

    Public Sub createVt()
        Dim Vt As Double = 0.0119 * (((Pl - Pg) / Pg) * (Dm / CdUser))
        Return Vt
    End Sub

End Class
