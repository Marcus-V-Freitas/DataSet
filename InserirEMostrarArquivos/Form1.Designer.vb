<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTexto = New System.Windows.Forms.TextBox()
        Me.btnLerFim = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnLerLinha = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtTexto
        '
        Me.txtTexto.Location = New System.Drawing.Point(199, 32)
        Me.txtTexto.Multiline = True
        Me.txtTexto.Name = "txtTexto"
        Me.txtTexto.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtTexto.Size = New System.Drawing.Size(406, 307)
        Me.txtTexto.TabIndex = 0
        '
        'btnLerFim
        '
        Me.btnLerFim.Location = New System.Drawing.Point(116, 390)
        Me.btnLerFim.Name = "btnLerFim"
        Me.btnLerFim.Size = New System.Drawing.Size(75, 23)
        Me.btnLerFim.TabIndex = 1
        Me.btnLerFim.Text = "Ler até o fim"
        Me.btnLerFim.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(343, 390)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnLerLinha
        '
        Me.btnLerLinha.Location = New System.Drawing.Point(584, 390)
        Me.btnLerLinha.Name = "btnLerLinha"
        Me.btnLerLinha.Size = New System.Drawing.Size(75, 23)
        Me.btnLerLinha.TabIndex = 3
        Me.btnLerLinha.Text = "Ler Linha"
        Me.btnLerLinha.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLerLinha)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnLerFim)
        Me.Controls.Add(Me.txtTexto)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTexto As TextBox
    Friend WithEvents btnLerFim As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnLerLinha As Button
End Class
