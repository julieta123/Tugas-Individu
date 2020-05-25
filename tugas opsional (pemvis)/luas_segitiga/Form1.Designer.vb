<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.talas = New System.Windows.Forms.TextBox()
        Me.ttinggi = New System.Windows.Forms.TextBox()
        Me.thasil = New System.Windows.Forms.TextBox()
        Me.bproses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.Label1.Location = New System.Drawing.Point(86, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(149, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LUAS SEGITIGA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(60, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Alas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(60, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tinggi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(60, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Hasil"
        '
        'talas
        '
        Me.talas.Location = New System.Drawing.Point(119, 80)
        Me.talas.Name = "talas"
        Me.talas.Size = New System.Drawing.Size(100, 20)
        Me.talas.TabIndex = 4
        '
        'ttinggi
        '
        Me.ttinggi.Location = New System.Drawing.Point(119, 117)
        Me.ttinggi.Name = "ttinggi"
        Me.ttinggi.Size = New System.Drawing.Size(100, 20)
        Me.ttinggi.TabIndex = 5
        '
        'thasil
        '
        Me.thasil.Location = New System.Drawing.Point(119, 192)
        Me.thasil.Multiline = True
        Me.thasil.Name = "thasil"
        Me.thasil.Size = New System.Drawing.Size(125, 62)
        Me.thasil.TabIndex = 6
        '
        'bproses
        '
        Me.bproses.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.bproses.Location = New System.Drawing.Point(119, 153)
        Me.bproses.Name = "bproses"
        Me.bproses.Size = New System.Drawing.Size(75, 26)
        Me.bproses.TabIndex = 7
        Me.bproses.Text = "Proses"
        Me.bproses.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.luas_segitiga.My.Resources.Resources._5Bwallcoo_com_5D_happynco_1024x768_5_
        Me.ClientSize = New System.Drawing.Size(283, 281)
        Me.Controls.Add(Me.bproses)
        Me.Controls.Add(Me.thasil)
        Me.Controls.Add(Me.ttinggi)
        Me.Controls.Add(Me.talas)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents talas As TextBox
    Friend WithEvents ttinggi As TextBox
    Friend WithEvents thasil As TextBox
    Friend WithEvents bproses As Button
End Class
