<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Login
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
        Me.Tb_Username = New System.Windows.Forms.TextBox()
        Me.Tb_Password = New System.Windows.Forms.TextBox()
        Me.Btn_Keluar = New System.Windows.Forms.Button()
        Me.Btn_Masuk = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(120, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Login Required"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 20)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Password"
        '
        'Tb_Username
        '
        Me.Tb_Username.Location = New System.Drawing.Point(125, 84)
        Me.Tb_Username.Name = "Tb_Username"
        Me.Tb_Username.Size = New System.Drawing.Size(203, 22)
        Me.Tb_Username.TabIndex = 2
        '
        'Tb_Password
        '
        Me.Tb_Password.Location = New System.Drawing.Point(125, 114)
        Me.Tb_Password.Name = "Tb_Password"
        Me.Tb_Password.Size = New System.Drawing.Size(203, 22)
        Me.Tb_Password.TabIndex = 2
        Me.Tb_Password.UseSystemPasswordChar = True
        '
        'Btn_Keluar
        '
        Me.Btn_Keluar.Location = New System.Drawing.Point(68, 170)
        Me.Btn_Keluar.Name = "Btn_Keluar"
        Me.Btn_Keluar.Size = New System.Drawing.Size(108, 33)
        Me.Btn_Keluar.TabIndex = 3
        Me.Btn_Keluar.Text = "Keluar"
        Me.Btn_Keluar.UseVisualStyleBackColor = True
        '
        'Btn_Masuk
        '
        Me.Btn_Masuk.Location = New System.Drawing.Point(220, 170)
        Me.Btn_Masuk.Name = "Btn_Masuk"
        Me.Btn_Masuk.Size = New System.Drawing.Size(108, 33)
        Me.Btn_Masuk.TabIndex = 3
        Me.Btn_Masuk.Text = "Masuk"
        Me.Btn_Masuk.UseVisualStyleBackColor = True
        '
        'Form_Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(401, 266)
        Me.Controls.Add(Me.Btn_Masuk)
        Me.Controls.Add(Me.Btn_Keluar)
        Me.Controls.Add(Me.Tb_Password)
        Me.Controls.Add(Me.Tb_Username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form_Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form_Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Tb_Username As TextBox
    Friend WithEvents Tb_Password As TextBox
    Friend WithEvents Btn_Keluar As Button
    Friend WithEvents Btn_Masuk As Button
End Class
