<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class newEntry
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(newEntry))
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.titleText = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.dreamDate = New System.Windows.Forms.DateTimePicker
        Me.Label4 = New System.Windows.Forms.Label
        Me.dreamType = New System.Windows.Forms.ComboBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.techUsed = New System.Windows.Forms.ComboBox
        Me.validador = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.descText = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.enterBoton = New System.Windows.Forms.Button
        Me.leftWindow = New System.Windows.Forms.PictureBox
        Me.rightWindow = New System.Windows.Forms.PictureBox
        CType(Me.validador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.leftWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(225, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(199, 29)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "New Diary Entry"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dream Title:"
        '
        'titleText
        '
        Me.titleText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.titleText.Location = New System.Drawing.Point(116, 86)
        Me.titleText.Name = "titleText"
        Me.titleText.Size = New System.Drawing.Size(213, 20)
        Me.titleText.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(12, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Dream Date:"
        '
        'dreamDate
        '
        Me.dreamDate.Location = New System.Drawing.Point(116, 128)
        Me.dreamDate.Name = "dreamDate"
        Me.dreamDate.Size = New System.Drawing.Size(213, 20)
        Me.dreamDate.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(360, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Dream Type:"
        '
        'dreamType
        '
        Me.dreamType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dreamType.FormattingEnabled = True
        Me.dreamType.Items.AddRange(New Object() {"Normal Dream", "Nightmare", "Lucid Dream", "OOBE", "Astral Projection"})
        Me.dreamType.Location = New System.Drawing.Point(454, 86)
        Me.dreamType.Name = "dreamType"
        Me.dreamType.Size = New System.Drawing.Size(164, 21)
        Me.dreamType.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(360, 132)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Technique Used:"
        '
        'techUsed
        '
        Me.techUsed.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.techUsed.FormattingEnabled = True
        Me.techUsed.Items.AddRange(New Object() {"MILD", "WILD", "WBTB", "Reality Check", "None"})
        Me.techUsed.Location = New System.Drawing.Point(481, 126)
        Me.techUsed.Name = "techUsed"
        Me.techUsed.Size = New System.Drawing.Size(137, 21)
        Me.techUsed.TabIndex = 4
        '
        'validador
        '
        Me.validador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.validador.ContainerControl = Me
        '
        'descText
        '
        Me.descText.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.descText.Location = New System.Drawing.Point(12, 198)
        Me.descText.Multiline = True
        Me.descText.Name = "descText"
        Me.descText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.descText.Size = New System.Drawing.Size(606, 149)
        Me.descText.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(12, 182)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 15)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dream Description:"
        '
        'enterBoton
        '
        Me.enterBoton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterBoton.Location = New System.Drawing.Point(247, 353)
        Me.enterBoton.Name = "enterBoton"
        Me.enterBoton.Size = New System.Drawing.Size(161, 23)
        Me.enterBoton.TabIndex = 6
        Me.enterBoton.Text = "Submitt Entry"
        Me.enterBoton.UseVisualStyleBackColor = True
        '
        'leftWindow
        '
        Me.leftWindow.BackColor = System.Drawing.Color.Transparent
        Me.leftWindow.Image = Global.Dream_Journal.My.Resources.Resources.window4
        Me.leftWindow.Location = New System.Drawing.Point(160, 12)
        Me.leftWindow.Name = "leftWindow"
        Me.leftWindow.Size = New System.Drawing.Size(43, 56)
        Me.leftWindow.TabIndex = 12
        Me.leftWindow.TabStop = False
        '
        'rightWindow
        '
        Me.rightWindow.BackColor = System.Drawing.Color.Transparent
        Me.rightWindow.Image = Global.Dream_Journal.My.Resources.Resources.window4
        Me.rightWindow.Location = New System.Drawing.Point(452, 12)
        Me.rightWindow.Name = "rightWindow"
        Me.rightWindow.Size = New System.Drawing.Size(43, 56)
        Me.rightWindow.TabIndex = 13
        Me.rightWindow.TabStop = False
        '
        'newEntry
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dream_Journal.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(655, 391)
        Me.Controls.Add(Me.rightWindow)
        Me.Controls.Add(Me.leftWindow)
        Me.Controls.Add(Me.enterBoton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.descText)
        Me.Controls.Add(Me.techUsed)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dreamType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dreamDate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.titleText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "newEntry"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "New Diary Entry"
        CType(Me.validador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.leftWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents titleText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dreamDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dreamType As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents techUsed As System.Windows.Forms.ComboBox
    Friend WithEvents validador As System.Windows.Forms.ErrorProvider
    Friend WithEvents enterBoton As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents descText As System.Windows.Forms.TextBox
    Friend WithEvents leftWindow As System.Windows.Forms.PictureBox
    Friend WithEvents rightWindow As System.Windows.Forms.PictureBox
End Class
