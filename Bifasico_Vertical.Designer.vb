<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bifasico_Vertical
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Rel_EsList = New System.Windows.Forms.ListBox()
        Me.LssList = New System.Windows.Forms.ListBox()
        Me.HList = New System.Windows.Forms.ListBox()
        Me.DList = New System.Windows.Forms.ListBox()
        Me.TrList = New System.Windows.Forms.ListBox()
        Me.Rel_EsbeltLabel = New System.Windows.Forms.Label()
        Me.LssLabel = New System.Windows.Forms.Label()
        Me.HLabel = New System.Windows.Forms.Label()
        Me.TrLabel = New System.Windows.Forms.Label()
        Me.DLabel = New System.Windows.Forms.Label()
        Me.AddD = New System.Windows.Forms.Button()
        Me.DEntrada = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NombreDeSeparador = New System.Windows.Forms.Label()
        Me.DminBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LabelProcesos = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(195, 215)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Resultados"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 5
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705374!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.705374!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.86308!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.86309!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.86308!))
        Me.TableLayoutPanel1.Controls.Add(Me.Rel_EsList, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LssList, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.HList, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DList, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TrList, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Rel_EsbeltLabel, 4, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.LssLabel, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.HLabel, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TrLabel, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DLabel, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(12, 252)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 236.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(482, 267)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'Rel_EsList
        '
        Me.Rel_EsList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rel_EsList.FormattingEnabled = True
        Me.Rel_EsList.Location = New System.Drawing.Point(353, 34)
        Me.Rel_EsList.Name = "Rel_EsList"
        Me.Rel_EsList.Size = New System.Drawing.Size(126, 225)
        Me.Rel_EsList.TabIndex = 14
        '
        'LssList
        '
        Me.LssList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LssList.FormattingEnabled = True
        Me.LssList.Location = New System.Drawing.Point(224, 34)
        Me.LssList.Name = "LssList"
        Me.LssList.Size = New System.Drawing.Size(123, 225)
        Me.LssList.TabIndex = 13
        '
        'HList
        '
        Me.HList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HList.FormattingEnabled = True
        Me.HList.Location = New System.Drawing.Point(95, 34)
        Me.HList.Name = "HList"
        Me.HList.Size = New System.Drawing.Size(123, 225)
        Me.HList.TabIndex = 12
        '
        'DList
        '
        Me.DList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DList.FormattingEnabled = True
        Me.DList.Location = New System.Drawing.Point(49, 34)
        Me.DList.Name = "DList"
        Me.DList.Size = New System.Drawing.Size(40, 225)
        Me.DList.TabIndex = 11
        '
        'TrList
        '
        Me.TrList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrList.FormattingEnabled = True
        Me.TrList.Location = New System.Drawing.Point(3, 34)
        Me.TrList.Name = "TrList"
        Me.TrList.Size = New System.Drawing.Size(40, 225)
        Me.TrList.TabIndex = 10
        '
        'Rel_EsbeltLabel
        '
        Me.Rel_EsbeltLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Rel_EsbeltLabel.AutoSize = True
        Me.Rel_EsbeltLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Rel_EsbeltLabel.Location = New System.Drawing.Point(353, 8)
        Me.Rel_EsbeltLabel.Name = "Rel_EsbeltLabel"
        Me.Rel_EsbeltLabel.Size = New System.Drawing.Size(126, 15)
        Me.Rel_EsbeltLabel.TabIndex = 4
        Me.Rel_EsbeltLabel.Text = "R. Esb"
        Me.Rel_EsbeltLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LssLabel
        '
        Me.LssLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LssLabel.AutoSize = True
        Me.LssLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LssLabel.Location = New System.Drawing.Point(224, 8)
        Me.LssLabel.Name = "LssLabel"
        Me.LssLabel.Size = New System.Drawing.Size(123, 15)
        Me.LssLabel.TabIndex = 3
        Me.LssLabel.Text = "Lss"
        Me.LssLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HLabel
        '
        Me.HLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HLabel.AutoSize = True
        Me.HLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HLabel.Location = New System.Drawing.Point(95, 8)
        Me.HLabel.Name = "HLabel"
        Me.HLabel.Size = New System.Drawing.Size(123, 15)
        Me.HLabel.TabIndex = 2
        Me.HLabel.Text = "h"
        Me.HLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TrLabel
        '
        Me.TrLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TrLabel.AutoSize = True
        Me.TrLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrLabel.Location = New System.Drawing.Point(3, 8)
        Me.TrLabel.Name = "TrLabel"
        Me.TrLabel.Size = New System.Drawing.Size(40, 15)
        Me.TrLabel.TabIndex = 0
        Me.TrLabel.Text = "tr"
        Me.TrLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DLabel
        '
        Me.DLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DLabel.AutoSize = True
        Me.DLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DLabel.Location = New System.Drawing.Point(49, 8)
        Me.DLabel.Name = "DLabel"
        Me.DLabel.Size = New System.Drawing.Size(40, 15)
        Me.DLabel.TabIndex = 1
        Me.DLabel.Text = "d"
        Me.DLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AddD
        '
        Me.AddD.Location = New System.Drawing.Point(332, 173)
        Me.AddD.Name = "AddD"
        Me.AddD.Size = New System.Drawing.Size(27, 20)
        Me.AddD.TabIndex = 62
        Me.AddD.Text = ">"
        Me.AddD.UseVisualStyleBackColor = True
        '
        'DEntrada
        '
        Me.DEntrada.Location = New System.Drawing.Point(136, 172)
        Me.DEntrada.Margin = New System.Windows.Forms.Padding(2)
        Me.DEntrada.Name = "DEntrada"
        Me.DEntrada.Size = New System.Drawing.Size(191, 20)
        Me.DEntrada.TabIndex = 61
        '
        'Label6
        '
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(49, 132)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label6.Size = New System.Drawing.Size(401, 38)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Escribe diferentes ""d"" mayores a Dmin, de no ser así, estos " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "serán ignorados" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NombreDeSeparador
        '
        Me.NombreDeSeparador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NombreDeSeparador.ForeColor = System.Drawing.Color.Black
        Me.NombreDeSeparador.Location = New System.Drawing.Point(143, 47)
        Me.NombreDeSeparador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NombreDeSeparador.Name = "NombreDeSeparador"
        Me.NombreDeSeparador.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.NombreDeSeparador.Size = New System.Drawing.Size(204, 20)
        Me.NombreDeSeparador.TabIndex = 59
        Me.NombreDeSeparador.Text = "separador"
        Me.NombreDeSeparador.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DminBox
        '
        Me.DminBox.Location = New System.Drawing.Point(191, 82)
        Me.DminBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DminBox.Name = "DminBox"
        Me.DminBox.ReadOnly = True
        Me.DminBox.Size = New System.Drawing.Size(140, 20)
        Me.DminBox.TabIndex = 58
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(145, 82)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label3.Size = New System.Drawing.Size(41, 20)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "Dmin"
        '
        'LabelProcesos
        '
        Me.LabelProcesos.AutoSize = True
        Me.LabelProcesos.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProcesos.Location = New System.Drawing.Point(195, 20)
        Me.LabelProcesos.Name = "LabelProcesos"
        Me.LabelProcesos.Size = New System.Drawing.Size(104, 18)
        Me.LabelProcesos.TabIndex = 56
        Me.LabelProcesos.Text = "Procesos de"
        Me.LabelProcesos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Bifasico_Vertical
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 534)
        Me.Controls.Add(Me.AddD)
        Me.Controls.Add(Me.DEntrada)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.NombreDeSeparador)
        Me.Controls.Add(Me.DminBox)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.LabelProcesos)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Bifasico_Vertical"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form1"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Rel_EsbeltLabel As Label
    Friend WithEvents LssLabel As Label
    Friend WithEvents HLabel As Label
    Friend WithEvents DLabel As Label
    Friend WithEvents TrLabel As Label
    Friend WithEvents Rel_EsList As ListBox
    Friend WithEvents LssList As ListBox
    Friend WithEvents HList As ListBox
    Friend WithEvents DList As ListBox
    Friend WithEvents TrList As ListBox
    Friend WithEvents AddD As Button
    Friend WithEvents DEntrada As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents NombreDeSeparador As Label
    Friend WithEvents DminBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LabelProcesos As Label
End Class
