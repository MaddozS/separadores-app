<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start
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
        Me.TiposDeSeparador = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Calcular = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CdUserBox = New System.Windows.Forms.TextBox()
        Me.PgBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DmBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.UBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PlBox = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.QgBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.PBox = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.TBox = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ZBox = New System.Windows.Forms.TextBox()
        Me.TrLabel = New System.Windows.Forms.Label()
        Me.TrBox = New System.Windows.Forms.TextBox()
        Me.QlBox = New System.Windows.Forms.TextBox()
        Me.QlLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TiposDeSeparador
        '
        Me.TiposDeSeparador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TiposDeSeparador.FormattingEnabled = True
        Me.TiposDeSeparador.Items.AddRange(New Object() {"Bifásico vertical", "Bifásico horizontal", "Trifásico horizontal", "Trifásico vertical"})
        Me.TiposDeSeparador.Location = New System.Drawing.Point(52, 30)
        Me.TiposDeSeparador.Name = "TiposDeSeparador"
        Me.TiposDeSeparador.Size = New System.Drawing.Size(252, 21)
        Me.TiposDeSeparador.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(83, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Selecciona un separador"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Calcular
        '
        Me.Calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calcular.Location = New System.Drawing.Point(129, 433)
        Me.Calcular.Margin = New System.Windows.Forms.Padding(2)
        Me.Calcular.Name = "Calcular"
        Me.Calcular.Size = New System.Drawing.Size(95, 30)
        Me.Calcular.TabIndex = 13
        Me.Calcular.Text = "Calcular"
        Me.Calcular.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cd propuesto"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CdUserBox
        '
        Me.CdUserBox.Location = New System.Drawing.Point(142, 116)
        Me.CdUserBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CdUserBox.Name = "CdUserBox"
        Me.CdUserBox.Size = New System.Drawing.Size(68, 20)
        Me.CdUserBox.TabIndex = 2
        Me.CdUserBox.Tag = ""
        '
        'PgBox
        '
        Me.PgBox.Location = New System.Drawing.Point(41, 171)
        Me.PgBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PgBox.Name = "PgBox"
        Me.PgBox.Size = New System.Drawing.Size(50, 20)
        Me.PgBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(86, 85)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 172)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Pg"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 199)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(20, 16)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Pl"
        '
        'DmBox
        '
        Me.DmBox.Location = New System.Drawing.Point(41, 221)
        Me.DmBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DmBox.Name = "DmBox"
        Me.DmBox.Size = New System.Drawing.Size(50, 20)
        Me.DmBox.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 224)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Dₘ"
        '
        'UBox
        '
        Me.UBox.Location = New System.Drawing.Point(41, 245)
        Me.UBox.Margin = New System.Windows.Forms.Padding(2)
        Me.UBox.Name = "UBox"
        Me.UBox.Size = New System.Drawing.Size(50, 20)
        Me.UBox.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 248)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = " µ"
        '
        'PlBox
        '
        Me.PlBox.Location = New System.Drawing.Point(41, 197)
        Me.PlBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PlBox.Name = "PlBox"
        Me.PlBox.Size = New System.Drawing.Size(50, 20)
        Me.PlBox.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(112, 70)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(137, 18)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Datos de entrada"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(12, 272)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(24, 16)
        Me.Label14.TabIndex = 22
        Me.Label14.Text = "qg"
        '
        'QgBox
        '
        Me.QgBox.Location = New System.Drawing.Point(41, 269)
        Me.QgBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QgBox.Name = "QgBox"
        Me.QgBox.Size = New System.Drawing.Size(50, 20)
        Me.QgBox.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(12, 296)
        Me.Label19.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 16)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "P"
        '
        'PBox
        '
        Me.PBox.Location = New System.Drawing.Point(41, 293)
        Me.PBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PBox.Name = "PBox"
        Me.PBox.Size = New System.Drawing.Size(50, 20)
        Me.PBox.TabIndex = 8
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(12, 320)
        Me.Label21.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(17, 16)
        Me.Label21.TabIndex = 33
        Me.Label21.Text = "T"
        '
        'TBox
        '
        Me.TBox.Location = New System.Drawing.Point(41, 317)
        Me.TBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TBox.Name = "TBox"
        Me.TBox.Size = New System.Drawing.Size(50, 20)
        Me.TBox.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 344)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(16, 16)
        Me.Label9.TabIndex = 35
        Me.Label9.Text = "Z"
        '
        'ZBox
        '
        Me.ZBox.Location = New System.Drawing.Point(41, 341)
        Me.ZBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ZBox.Name = "ZBox"
        Me.ZBox.Size = New System.Drawing.Size(50, 20)
        Me.ZBox.TabIndex = 10
        '
        'TrLabel
        '
        Me.TrLabel.AutoSize = True
        Me.TrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrLabel.Location = New System.Drawing.Point(106, 172)
        Me.TrLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.TrLabel.Name = "TrLabel"
        Me.TrLabel.Size = New System.Drawing.Size(21, 16)
        Me.TrLabel.TabIndex = 36
        Me.TrLabel.Text = "Tr"
        '
        'TrBox
        '
        Me.TrBox.Location = New System.Drawing.Point(130, 171)
        Me.TrBox.Margin = New System.Windows.Forms.Padding(2)
        Me.TrBox.Name = "TrBox"
        Me.TrBox.Size = New System.Drawing.Size(50, 20)
        Me.TrBox.TabIndex = 11
        '
        'QlBox
        '
        Me.QlBox.Location = New System.Drawing.Point(130, 198)
        Me.QlBox.Margin = New System.Windows.Forms.Padding(2)
        Me.QlBox.Name = "QlBox"
        Me.QlBox.Size = New System.Drawing.Size(50, 20)
        Me.QlBox.TabIndex = 12
        '
        'QlLabel
        '
        Me.QlLabel.AutoSize = True
        Me.QlLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QlLabel.Location = New System.Drawing.Point(106, 199)
        Me.QlLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.QlLabel.Name = "QlLabel"
        Me.QlLabel.Size = New System.Drawing.Size(19, 16)
        Me.QlLabel.TabIndex = 38
        Me.QlLabel.Text = "ql"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 474)
        Me.Controls.Add(Me.QlBox)
        Me.Controls.Add(Me.TrBox)
        Me.Controls.Add(Me.ZBox)
        Me.Controls.Add(Me.TBox)
        Me.Controls.Add(Me.PBox)
        Me.Controls.Add(Me.QgBox)
        Me.Controls.Add(Me.UBox)
        Me.Controls.Add(Me.DmBox)
        Me.Controls.Add(Me.PlBox)
        Me.Controls.Add(Me.PgBox)
        Me.Controls.Add(Me.CdUserBox)
        Me.Controls.Add(Me.TiposDeSeparador)
        Me.Controls.Add(Me.QlLabel)
        Me.Controls.Add(Me.TrLabel)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Calcular)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Start"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Calculadora de separadores"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TiposDeSeparador As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Calcular As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents CdUserBox As TextBox
    Friend WithEvents PgBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DmBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents UBox As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents PlBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents QgBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents PBox As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents TBox As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ZBox As TextBox
    Friend WithEvents TrLabel As Label
    Friend WithEvents TrBox As TextBox
    Friend WithEvents QlBox As TextBox
    Friend WithEvents QlLabel As Label
End Class
