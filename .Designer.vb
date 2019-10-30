<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Formulas_Generales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.VtBox = New System.Windows.Forms.TextBox()
        Me.TrBox = New System.Windows.Forms.Label()
        Me.ReBox = New System.Windows.Forms.TextBox()
        Me.ReLabel = New System.Windows.Forms.Label()
        Me.CdBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NombreDeSeparador = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'VtBox
        '
        Me.VtBox.Location = New System.Drawing.Point(84, 79)
        Me.VtBox.Margin = New System.Windows.Forms.Padding(2)
        Me.VtBox.Name = "VtBox"
        Me.VtBox.ReadOnly = True
        Me.VtBox.Size = New System.Drawing.Size(151, 20)
        Me.VtBox.TabIndex = 39
        '
        'TrBox
        '
        Me.TrBox.AutoSize = True
        Me.TrBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrBox.Location = New System.Drawing.Point(57, 80)
        Me.TrBox.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TrBox.Name = "TrBox"
        Me.TrBox.Size = New System.Drawing.Size(20, 16)
        Me.TrBox.TabIndex = 38
        Me.TrBox.Text = "Vt"
        '
        'ReBox
        '
        Me.ReBox.Location = New System.Drawing.Point(84, 103)
        Me.ReBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ReBox.Name = "ReBox"
        Me.ReBox.ReadOnly = True
        Me.ReBox.Size = New System.Drawing.Size(151, 20)
        Me.ReBox.TabIndex = 43
        '
        'ReLabel
        '
        Me.ReLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ReLabel.Location = New System.Drawing.Point(54, 103)
        Me.ReLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ReLabel.Name = "ReLabel"
        Me.ReLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ReLabel.Size = New System.Drawing.Size(26, 19)
        Me.ReLabel.TabIndex = 42
        Me.ReLabel.Text = "Re"
        Me.ReLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'CdBox
        '
        Me.CdBox.Location = New System.Drawing.Point(84, 127)
        Me.CdBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CdBox.Name = "CdBox"
        Me.CdBox.ReadOnly = True
        Me.CdBox.Size = New System.Drawing.Size(151, 20)
        Me.CdBox.TabIndex = 45
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(50, 128)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(30, 20)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Cd"
        '
        'NombreDeSeparador
        '
        Me.NombreDeSeparador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreDeSeparador.ForeColor = System.Drawing.Color.Black
        Me.NombreDeSeparador.Location = New System.Drawing.Point(47, 50)
        Me.NombreDeSeparador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NombreDeSeparador.Name = "NombreDeSeparador"
        Me.NombreDeSeparador.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NombreDeSeparador.Size = New System.Drawing.Size(204, 20)
        Me.NombreDeSeparador.TabIndex = 50
        Me.NombreDeSeparador.Text = "separador"
        Me.NombreDeSeparador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(47, 29)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label7.Size = New System.Drawing.Size(201, 21)
        Me.Label7.TabIndex = 53
        Me.Label7.Text = "Fórmulas generales" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Calcular
        '
        Me.Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular.Location = New System.Drawing.Point(98, 178)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(95, 32)
        Me.Calcular.TabIndex = 57
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Formulas_Generales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(299, 237)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.NombreDeSeparador)
        Me.Controls.Add(Me.CdBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ReBox)
        Me.Controls.Add(Me.ReLabel)
        Me.Controls.Add(Me.VtBox)
        Me.Controls.Add(Me.TrBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Formulas_Generales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " Fórmulas generales"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents VtBox As TextBox
    Friend WithEvents TrBox As Label
    Friend WithEvents ReBox As TextBox
    Friend WithEvents ReLabel As Label
    Friend WithEvents CdBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents NombreDeSeparador As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Calcular As Button
End Class
