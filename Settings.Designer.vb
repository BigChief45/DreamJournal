<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.Label1 = New System.Windows.Forms.Label
        Me.leftWindow = New System.Windows.Forms.PictureBox
        Me.rightWindow = New System.Windows.Forms.PictureBox
        Me.foodRemCheck = New System.Windows.Forms.CheckBox
        Me.rcRemCheck = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.foodTimeRem = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.rcTimeRem = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.minimizeCheck = New System.Windows.Forms.CheckBox
        Me.remindersGroup = New System.Windows.Forms.GroupBox
        Me.randomEntryCheck = New System.Windows.Forms.CheckBox
        Me.enterBoton = New System.Windows.Forms.Button
        Me.validador = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.leftWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rightWindow, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.remindersGroup.SuspendLayout()
        CType(Me.validador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(195, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(154, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User Settings"
        '
        'leftWindow
        '
        Me.leftWindow.BackColor = System.Drawing.Color.Transparent
        Me.leftWindow.Image = Global.Dream_Journal.My.Resources.Resources.window3
        Me.leftWindow.Location = New System.Drawing.Point(129, 12)
        Me.leftWindow.Name = "leftWindow"
        Me.leftWindow.Size = New System.Drawing.Size(43, 58)
        Me.leftWindow.TabIndex = 1
        Me.leftWindow.TabStop = False
        '
        'rightWindow
        '
        Me.rightWindow.BackColor = System.Drawing.Color.Transparent
        Me.rightWindow.Image = Global.Dream_Journal.My.Resources.Resources.window3
        Me.rightWindow.Location = New System.Drawing.Point(375, 12)
        Me.rightWindow.Name = "rightWindow"
        Me.rightWindow.Size = New System.Drawing.Size(43, 58)
        Me.rightWindow.TabIndex = 2
        Me.rightWindow.TabStop = False
        '
        'foodRemCheck
        '
        Me.foodRemCheck.AutoSize = True
        Me.foodRemCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foodRemCheck.ForeColor = System.Drawing.Color.White
        Me.foodRemCheck.Location = New System.Drawing.Point(27, 25)
        Me.foodRemCheck.Name = "foodRemCheck"
        Me.foodRemCheck.Size = New System.Drawing.Size(217, 19)
        Me.foodRemCheck.TabIndex = 3
        Me.foodRemCheck.Text = "Show Lucid Foods Reminders"
        Me.foodRemCheck.UseVisualStyleBackColor = True
        '
        'rcRemCheck
        '
        Me.rcRemCheck.AutoSize = True
        Me.rcRemCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rcRemCheck.ForeColor = System.Drawing.Color.White
        Me.rcRemCheck.Location = New System.Drawing.Point(27, 64)
        Me.rcRemCheck.Name = "rcRemCheck"
        Me.rcRemCheck.Size = New System.Drawing.Size(233, 19)
        Me.rcRemCheck.TabIndex = 4
        Me.rcRemCheck.Text = "Show Reality Checks Reminders"
        Me.rcRemCheck.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(296, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Every"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(387, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "minutes"
        '
        'foodTimeRem
        '
        Me.foodTimeRem.Location = New System.Drawing.Point(343, 24)
        Me.foodTimeRem.MaxLength = 3
        Me.foodTimeRem.Name = "foodTimeRem"
        Me.foodTimeRem.Size = New System.Drawing.Size(38, 21)
        Me.foodTimeRem.TabIndex = 8
        Me.foodTimeRem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(296, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 15)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Every"
        '
        'rcTimeRem
        '
        Me.rcTimeRem.Location = New System.Drawing.Point(343, 62)
        Me.rcTimeRem.MaxLength = 3
        Me.rcTimeRem.Name = "rcTimeRem"
        Me.rcTimeRem.Size = New System.Drawing.Size(38, 21)
        Me.rcTimeRem.TabIndex = 10
        Me.rcTimeRem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(387, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 15)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "minutes"
        '
        'minimizeCheck
        '
        Me.minimizeCheck.AutoSize = True
        Me.minimizeCheck.BackColor = System.Drawing.Color.Transparent
        Me.minimizeCheck.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.minimizeCheck.ForeColor = System.Drawing.Color.White
        Me.minimizeCheck.Location = New System.Drawing.Point(12, 94)
        Me.minimizeCheck.Name = "minimizeCheck"
        Me.minimizeCheck.Size = New System.Drawing.Size(287, 19)
        Me.minimizeCheck.TabIndex = 12
        Me.minimizeCheck.Text = "Minimize application to tray when closed"
        Me.minimizeCheck.UseVisualStyleBackColor = False
        '
        'remindersGroup
        '
        Me.remindersGroup.BackColor = System.Drawing.Color.Transparent
        Me.remindersGroup.Controls.Add(Me.randomEntryCheck)
        Me.remindersGroup.Controls.Add(Me.rcRemCheck)
        Me.remindersGroup.Controls.Add(Me.foodRemCheck)
        Me.remindersGroup.Controls.Add(Me.Label5)
        Me.remindersGroup.Controls.Add(Me.Label2)
        Me.remindersGroup.Controls.Add(Me.rcTimeRem)
        Me.remindersGroup.Controls.Add(Me.Label3)
        Me.remindersGroup.Controls.Add(Me.Label4)
        Me.remindersGroup.Controls.Add(Me.foodTimeRem)
        Me.remindersGroup.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remindersGroup.ForeColor = System.Drawing.Color.White
        Me.remindersGroup.Location = New System.Drawing.Point(12, 130)
        Me.remindersGroup.Name = "remindersGroup"
        Me.remindersGroup.Size = New System.Drawing.Size(523, 142)
        Me.remindersGroup.TabIndex = 13
        Me.remindersGroup.TabStop = False
        Me.remindersGroup.Text = "Reminders/Alerts"
        '
        'randomEntryCheck
        '
        Me.randomEntryCheck.AutoSize = True
        Me.randomEntryCheck.ForeColor = System.Drawing.Color.White
        Me.randomEntryCheck.Location = New System.Drawing.Point(27, 103)
        Me.randomEntryCheck.Name = "randomEntryCheck"
        Me.randomEntryCheck.Size = New System.Drawing.Size(248, 19)
        Me.randomEntryCheck.TabIndex = 12
        Me.randomEntryCheck.Text = "Show Random Diary Entry at Login"
        Me.randomEntryCheck.UseVisualStyleBackColor = True
        '
        'enterBoton
        '
        Me.enterBoton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.enterBoton.Location = New System.Drawing.Point(201, 293)
        Me.enterBoton.Name = "enterBoton"
        Me.enterBoton.Size = New System.Drawing.Size(144, 23)
        Me.enterBoton.TabIndex = 14
        Me.enterBoton.Text = "Apply Settings"
        Me.enterBoton.UseVisualStyleBackColor = True
        '
        'validador
        '
        Me.validador.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.validador.ContainerControl = Me
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Dream_Journal.My.Resources.Resources.bg
        Me.ClientSize = New System.Drawing.Size(547, 328)
        Me.Controls.Add(Me.enterBoton)
        Me.Controls.Add(Me.remindersGroup)
        Me.Controls.Add(Me.minimizeCheck)
        Me.Controls.Add(Me.rightWindow)
        Me.Controls.Add(Me.leftWindow)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Settings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Settings"
        CType(Me.leftWindow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rightWindow, System.ComponentModel.ISupportInitialize).EndInit()
        Me.remindersGroup.ResumeLayout(False)
        Me.remindersGroup.PerformLayout()
        CType(Me.validador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents leftWindow As System.Windows.Forms.PictureBox
    Friend WithEvents rightWindow As System.Windows.Forms.PictureBox
    Friend WithEvents foodRemCheck As System.Windows.Forms.CheckBox
    Friend WithEvents rcRemCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents foodTimeRem As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents rcTimeRem As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents minimizeCheck As System.Windows.Forms.CheckBox
    Friend WithEvents remindersGroup As System.Windows.Forms.GroupBox
    Friend WithEvents randomEntryCheck As System.Windows.Forms.CheckBox
    Friend WithEvents enterBoton As System.Windows.Forms.Button
    Friend WithEvents validador As System.Windows.Forms.ErrorProvider
End Class
