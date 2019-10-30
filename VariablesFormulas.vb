Public Module VariablesFormulas
    Public Pl As Double
    Public Pg As Double
    Public Dm As Double
    Public CdPropuesto As Double
    Public Cd As Double
    Public Qg As Double
    Public Z As Double
    Public T As Double
    Public U As Double
    Public P As Double
    Public Re As Double
    Public Vt As Double
    Public TipoDeSeparador As String
    Public Dmin As Double
    Public H As Double
    Public Lss As Double
    Public Ql As Double
    Public Tr As Double
    Public Rel_Esbeltez As Double
    Public D As Double

    ''' <summary>
    ''' Funcion que verifica que el numero cumpla con las condiciones
    ''' que deba tener, de no ser así, cambia la bandera de error a 
    ''' y asigna el valor de la entrada a la propiedad que se le pasa
    ''' </summary>
    Public Sub Set_Number(Numero As TextBox, ByRef Flag As Boolean, ErrorList As ListBox, VarName As String, ByRef VarNum As Double)
        If Verificar_Entrada(Numero, ErrorList, VarName) Then
            Flag = True
        Else
            VarNum = Double.Parse(Numero.Text)
        End If
    End Sub

    ''' <summary>
    ''' Funcion que recibe completamente el TextBox a evaluar, si está
    ''' vacio o es igual a 0, retorna True, sino, retorna False
    ''' </summary>
    Public Function Verificar_Entrada(Numero As TextBox, ErrorList As ListBox, VarName As String) As Boolean
        Dim r As Boolean
        If String.IsNullOrEmpty(Numero.Text) Then
            r = True
            ErrorList.Items.Add(VarName + " está vacio")
        Else
            Try
                If Double.Parse(Numero.Text) <= 0 Then
                    r = True
                    ErrorList.Items.Add(VarName + " no puede ser menor o igual a 0")
                End If
            Catch ex As System.FormatException
                r = True
                ErrorList.Items.Add(VarName + " no tiene un formato correcto")
            End Try

        End If

        Return r
    End Function
End Module
