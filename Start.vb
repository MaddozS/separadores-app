Imports System.Math
Public Class Start

    Function Calc_Vt(Pl As Double, Pg As Double, Dm As Double, Cd As Double) As Double
        Dim Vt As Double
        Vt = 0.0119 * (((Pl - Pg) / Pg) * (Dm / Cd)) ^ (0.5)

        Return Vt
    End Function
    Function Calc_Re(Pg As Double, Dm As Double, Vt As Double, U As Double) As Double
        Dim Re As Double
        Re = 0.0049 * ((Pg * Dm * Vt) / U)
        Return Re
    End Function

    Function Calc_Cd(Re As Double) As Double
        Dim Cd As Double
        Cd = (24 / Re) + (3 / ((Re) ^ (1 / 2))) + 0.34
        Return Cd
    End Function
    Private Sub Verificar_Valores(sender As Object, e As EventArgs) Handles Calcular.Click
        Dim ErrorFlag As Boolean = False
        Dim _ErrorWindow As New ErrorWindow

        If String.IsNullOrEmpty(TiposDeSeparador.SelectedItem) Then
            ErrorFlag = True
            _ErrorWindow.Errors.Items.Add("No has seleccionado un separador")
        Else
            TipoDeSeparador = TiposDeSeparador.SelectedItem
        End If
        ' Verificamos los valores de entrada
        Set_Number(PlBox, ErrorFlag, _ErrorWindow.Errors, "Pl", Pl)
        Set_Number(PgBox, ErrorFlag, _ErrorWindow.Errors, "Pg", Pg)
        Set_Number(DmBox, ErrorFlag, _ErrorWindow.Errors, "Dₘ", Dm)
        Set_Number(CdUserBox, ErrorFlag, _ErrorWindow.Errors, "Cd propuesto", CdPropuesto)
        Set_Number(QgBox, ErrorFlag, _ErrorWindow.Errors, "qg", Qg)
        Set_Number(ZBox, ErrorFlag, _ErrorWindow.Errors, "Z", Z)
        Set_Number(UBox, ErrorFlag, _ErrorWindow.Errors, "µ", U)
        Set_Number(TBox, ErrorFlag, _ErrorWindow.Errors, "T", T)
        Set_Number(PBox, ErrorFlag, _ErrorWindow.Errors, "P", P)
        Set_Number(TrBox, ErrorFlag, _ErrorWindow.Errors, "Tr", Tr)
        Set_Number(QlBox, ErrorFlag, _ErrorWindow.Errors, "ql", Ql)

        ' Checamos que no tengamos ningun error para calcular correctamente
        ' Los valores de las funciones
        If ErrorFlag Then
            _ErrorWindow.ShowDialog()
        Else
            If Pg < Pl Then
                Dim Form As New Formulas_Generales
                ' Calculamos por primera vez cada valor para todas las formulas generales
                Vt = Calc_Vt(Pl, Pg, Dm, CdPropuesto)
                Re = Calc_Re(Pg, Dm, Vt, U)
                Cd = Calc_Cd(Re)
                Console.WriteLine("Vt: {0}, Re: {1}, Cd: {2}", Vt, Re, Cd)
                ' Si el Cd sigue siendo mayor o igual a 0.005, se calcularan Cd nuevos
                ' que puedan satisfacer esta condición
                While (Math.Abs(CdPropuesto - Cd) >= 0.005)
                    CdPropuesto = Cd
                    Vt = Calc_Vt(Pl, Pg, Dm, CdPropuesto)
                    Re = Calc_Re(Pg, Dm, Vt, U)
                    Cd = Calc_Cd(Re)
                    Console.WriteLine("Vt: {0}, Re: {1}, Cd: {2}", Vt, Re, Cd)
                End While
                Form.NombreDeSeparador.Text = TipoDeSeparador
                Form.ShowDialog()
                ' Abrimos la ventana con los valores de las formulas generales

            Else
                _ErrorWindow.Errors.Items.Add("Pg no puede ser mayor o igual a Pl")
                _ErrorWindow.Errors.Items.Add(Pg)
                _ErrorWindow.Errors.Items.Add(Dm)
                _ErrorWindow.ShowDialog()
            End If
        End If
    End Sub


End Class
