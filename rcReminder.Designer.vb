<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class rcReminder
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rcReminder))
        Me.Label1 = New System.Windows.Forms.Label
        Me.mirror = New System.Windows.Forms.PictureBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.yesBoton = New System.Windows.Forms.Button
        Me.noBoton = New System.Windows.Forms.Button
        CType(Me.mirror, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(202, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Reality Check!"
        '
        'mirror
        '
        Me.mirror.BackColor = System.Drawing.Color.Transparent
        Me.mirror.Image = Global.Dream_Journal.My.Resources.Resources.mirror4
        Me.mirror.Location = New System.Drawing.Point(12, 66)
        Me.mirror.Name = "mirror"
        Me.mirror.Size = New System.Drawing.Size(155, 193)
        Me.mirror.TabIndex = 1
        Me.mirror.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(177, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(249, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Are you dreaming right now?"
        '
        'yesBoton
        '
        Me.yesBoton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yesBoton.Location = New System.Drawing.Point(190, 110)
        Me.yesBoton.Name = "yesBoton"
        Me.yesBoton.Size = New System.Drawing.Size(140, 91)
        Me.yesBoton.TabIndex = 3
        Me.yesBoton.Text = "YES"
        Me.yesBoton.UseVisualStyleBackColor = True
        '
        'noBoton
        '
        Me.noBoton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.noBoton.Location = New System.Drawing.Point(345, 110)
        Me.noBoton.Name = "noBoton"
        Me.noBoton.Size = New System.Drawing.Size(140, 91)
        Me.noBoton.TabIndex = 4
        Me.noBoton.Text = "NO"
        Me.noBoton.UseVisualStyleBackColor = True
        '
        'rcReminder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dream_Journal.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(546, 275)
        Me.Controls.Add(Me.noBoton)
        Me.Controls.Add(Me.yesBoton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.mirror)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "rcReminder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reality Check Reminder"
        CType(Me.mirror, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents mirror As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents yesBoton As System.Windows.Forms.Button
    Friend WithEvents noBoton As System.Windows.Forms.Button
End Class
