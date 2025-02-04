<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Adherent
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.TxtFiltrer = New System.Windows.Forms.TextBox
        Me.TxtType = New System.Windows.Forms.TextBox
        Me.TxtCode = New System.Windows.Forms.TextBox
        Me.TxtNom = New System.Windows.Forms.TextBox
        Me.TxtAdresse = New System.Windows.Forms.TextBox
        Me.TxtTel = New System.Windows.Forms.TextBox
        Me.TxtCin = New System.Windows.Forms.TextBox
        Me.TxtDate = New System.Windows.Forms.TextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.RdNom = New System.Windows.Forms.RadioButton
        Me.BtnPremier = New System.Windows.Forms.Button
        Me.RdTout = New System.Windows.Forms.RadioButton
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.BtnDernier = New System.Windows.Forms.Button
        Me.BtnPrecedent = New System.Windows.Forms.Button
        Me.BtnSuivant = New System.Windows.Forms.Button
        Me.BtnAjouter = New System.Windows.Forms.Button
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 122)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code Adherent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                        Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(247, 33)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FICHE ADHERENT"
        '
        'TxtFiltrer
        '
        Me.TxtFiltrer.Location = New System.Drawing.Point(269, 25)
        Me.TxtFiltrer.Name = "TxtFiltrer"
        Me.TxtFiltrer.Size = New System.Drawing.Size(100, 25)
        Me.TxtFiltrer.TabIndex = 2
        '
        'TxtType
        '
        Me.TxtType.Location = New System.Drawing.Point(184, 278)
        Me.TxtType.Name = "TxtType"
        Me.TxtType.Size = New System.Drawing.Size(100, 20)
        Me.TxtType.TabIndex = 4
        '
        'TxtCode
        '
        Me.TxtCode.Location = New System.Drawing.Point(184, 122)
        Me.TxtCode.Name = "TxtCode"
        Me.TxtCode.Size = New System.Drawing.Size(100, 20)
        Me.TxtCode.TabIndex = 5
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(184, 148)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(100, 20)
        Me.TxtNom.TabIndex = 6
        '
        'TxtAdresse
        '
        Me.TxtAdresse.Location = New System.Drawing.Point(184, 174)
        Me.TxtAdresse.Name = "TxtAdresse"
        Me.TxtAdresse.Size = New System.Drawing.Size(100, 20)
        Me.TxtAdresse.TabIndex = 7
        '
        'TxtTel
        '
        Me.TxtTel.Location = New System.Drawing.Point(184, 200)
        Me.TxtTel.Name = "TxtTel"
        Me.TxtTel.Size = New System.Drawing.Size(100, 20)
        Me.TxtTel.TabIndex = 8
        '
        'TxtCin
        '
        Me.TxtCin.Location = New System.Drawing.Point(184, 226)
        Me.TxtCin.Name = "TxtCin"
        Me.TxtCin.Size = New System.Drawing.Size(100, 20)
        Me.TxtCin.TabIndex = 9
        '
        'TxtDate
        '
        Me.TxtDate.Location = New System.Drawing.Point(184, 252)
        Me.TxtDate.Name = "TxtDate"
        Me.TxtDate.Size = New System.Drawing.Size(100, 20)
        Me.TxtDate.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RdTout)
        Me.GroupBox1.Controls.Add(Me.RdNom)
        Me.GroupBox1.Controls.Add(Me.TxtFiltrer)
        Me.GroupBox1.Font = New System.Drawing.Font("Monotype Corsiva", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(301, 122)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(405, 100)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtre D'affichage des Adherent"
        '
        'RdNom
        '
        Me.RdNom.AutoSize = True
        Me.RdNom.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdNom.Location = New System.Drawing.Point(6, 54)
        Me.RdNom.Name = "RdNom"
        Me.RdNom.Size = New System.Drawing.Size(213, 26)
        Me.RdNom.TabIndex = 1
        Me.RdNom.TabStop = True
        Me.RdNom.Text = "Le Nom Commance Par:"
        Me.RdNom.UseVisualStyleBackColor = True
        '
        'BtnPremier
        '
        Me.BtnPremier.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPremier.Location = New System.Drawing.Point(301, 228)
        Me.BtnPremier.Name = "BtnPremier"
        Me.BtnPremier.Size = New System.Drawing.Size(90, 35)
        Me.BtnPremier.TabIndex = 2
        Me.BtnPremier.Text = "Premier"
        Me.BtnPremier.UseVisualStyleBackColor = True
        '
        'RdTout
        '
        Me.RdTout.AutoSize = True
        Me.RdTout.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RdTout.Location = New System.Drawing.Point(6, 19)
        Me.RdTout.Name = "RdTout"
        Me.RdTout.Size = New System.Drawing.Size(65, 26)
        Me.RdTout.TabIndex = 3
        Me.RdTout.TabStop = True
        Me.RdTout.Text = "Tout"
        Me.RdTout.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 146)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 22)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nom Adherent"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(145, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Adresse Adherent"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 200)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 22)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Tel Adherent"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 22)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "CIN Adherent"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 22)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Date Naissance"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 276)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(123, 22)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Type Adherent"
        '
        'BtnDernier
        '
        Me.BtnDernier.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDernier.Location = New System.Drawing.Point(495, 228)
        Me.BtnDernier.Name = "BtnDernier"
        Me.BtnDernier.Size = New System.Drawing.Size(94, 35)
        Me.BtnDernier.TabIndex = 18
        Me.BtnDernier.Text = "Dernier"
        Me.BtnDernier.UseVisualStyleBackColor = True
        '
        'BtnPrecedent
        '
        Me.BtnPrecedent.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnPrecedent.Location = New System.Drawing.Point(595, 228)
        Me.BtnPrecedent.Name = "BtnPrecedent"
        Me.BtnPrecedent.Size = New System.Drawing.Size(110, 35)
        Me.BtnPrecedent.TabIndex = 19
        Me.BtnPrecedent.Text = "Precedent"
        Me.BtnPrecedent.UseVisualStyleBackColor = True
        '
        'BtnSuivant
        '
        Me.BtnSuivant.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSuivant.Location = New System.Drawing.Point(397, 228)
        Me.BtnSuivant.Name = "BtnSuivant"
        Me.BtnSuivant.Size = New System.Drawing.Size(92, 35)
        Me.BtnSuivant.TabIndex = 20
        Me.BtnSuivant.Text = "Suivant"
        Me.BtnSuivant.UseVisualStyleBackColor = True
        '
        'BtnAjouter
        '
        Me.BtnAjouter.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAjouter.Location = New System.Drawing.Point(436, 270)
        Me.BtnAjouter.Name = "BtnAjouter"
        Me.BtnAjouter.Size = New System.Drawing.Size(110, 35)
        Me.BtnAjouter.TabIndex = 21
        Me.BtnAjouter.Text = "Ajouter"
        Me.BtnAjouter.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 323)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(694, 194)
        Me.DataGridView1.TabIndex = 23
        '
        'Adherent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(718, 538)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BtnAjouter)
        Me.Controls.Add(Me.BtnSuivant)
        Me.Controls.Add(Me.BtnPrecedent)
        Me.Controls.Add(Me.BtnDernier)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BtnPremier)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtDate)
        Me.Controls.Add(Me.TxtCin)
        Me.Controls.Add(Me.TxtTel)
        Me.Controls.Add(Me.TxtAdresse)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.TxtCode)
        Me.Controls.Add(Me.TxtType)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Adherent"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TxtFiltrer As System.Windows.Forms.TextBox
    Friend WithEvents TxtType As System.Windows.Forms.TextBox
    Friend WithEvents TxtCode As System.Windows.Forms.TextBox
    Friend WithEvents TxtNom As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdresse As System.Windows.Forms.TextBox
    Friend WithEvents TxtTel As System.Windows.Forms.TextBox
    Friend WithEvents TxtCin As System.Windows.Forms.TextBox
    Friend WithEvents TxtDate As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RdNom As System.Windows.Forms.RadioButton
    Friend WithEvents BtnPremier As System.Windows.Forms.Button
    Friend WithEvents RdTout As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents BtnDernier As System.Windows.Forms.Button
    Friend WithEvents BtnPrecedent As System.Windows.Forms.Button
    Friend WithEvents BtnSuivant As System.Windows.Forms.Button
    Friend WithEvents BtnAjouter As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView

End Class
