<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entryView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(entryView))
        Me.titleLabel = New System.Windows.Forms.Label
        Me.dateLabel = New System.Windows.Forms.Label
        Me.typeLabel = New System.Windows.Forms.Label
        Me.techLabel = New System.Windows.Forms.Label
        Me.dreamText = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'titleLabel
        '
        Me.titleLabel.AutoSize = True
        Me.titleLabel.BackColor = System.Drawing.Color.Transparent
        Me.titleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleLabel.ForeColor = System.Drawing.Color.White
        Me.titleLabel.Location = New System.Drawing.Point(200, 9)
        Me.titleLabel.Name = "titleLabel"
        Me.titleLabel.Size = New System.Drawing.Size(150, 29)
        Me.titleLabel.TabIndex = 0
        Me.titleLabel.Text = "Dream Title"
        '
        'dateLabel
        '
        Me.dateLabel.AutoSize = True
        Me.dateLabel.BackColor = System.Drawing.Color.Transparent
        Me.dateLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dateLabel.ForeColor = System.Drawing.Color.White
        Me.dateLabel.Location = New System.Drawing.Point(262, 63)
        Me.dateLabel.Name = "dateLabel"
        Me.dateLabel.Size = New System.Drawing.Size(88, 15)
        Me.dateLabel.TabIndex = 1
        Me.dateLabel.Text = "Dream Date:"
        '
        'typeLabel
        '
        Me.typeLabel.AutoSize = True
        Me.typeLabel.BackColor = System.Drawing.Color.Transparent
        Me.typeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.typeLabel.ForeColor = System.Drawing.Color.White
        Me.typeLabel.Location = New System.Drawing.Point(12, 63)
        Me.typeLabel.Name = "typeLabel"
        Me.typeLabel.Size = New System.Drawing.Size(88, 15)
        Me.typeLabel.TabIndex = 2
        Me.typeLabel.Text = "Dream Type:"
        '
        'techLabel
        '
        Me.techLabel.AutoSize = True
        Me.techLabel.BackColor = System.Drawing.Color.Transparent
        Me.techLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.techLabel.ForeColor = System.Drawing.Color.White
        Me.techLabel.Location = New System.Drawing.Point(12, 94)
        Me.techLabel.Name = "techLabel"
        Me.techLabel.Size = New System.Drawing.Size(115, 15)
        Me.techLabel.TabIndex = 3
        Me.techLabel.Text = "Technique Used:"
        '
        'dreamText
        '
        Me.dreamText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dreamText.Location = New System.Drawing.Point(12, 142)
        Me.dreamText.Multiline = True
        Me.dreamText.Name = "dreamText"
        Me.dreamText.ReadOnly = True
        Me.dreamText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.dreamText.Size = New System.Drawing.Size(527, 149)
        Me.dreamText.TabIndex = 5
        '
        'entryView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dream_Journal.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(551, 303)
        Me.Controls.Add(Me.dreamText)
        Me.Controls.Add(Me.techLabel)
        Me.Controls.Add(Me.typeLabel)
        Me.Controls.Add(Me.dateLabel)
        Me.Controls.Add(Me.titleLabel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "entryView"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents titleLabel As System.Windows.Forms.Label
    Friend WithEvents dateLabel As System.Windows.Forms.Label
    Friend WithEvents typeLabel As System.Windows.Forms.Label
    Friend WithEvents techLabel As System.Windows.Forms.Label
    Friend WithEvents dreamText As System.Windows.Forms.TextBox
End Class
