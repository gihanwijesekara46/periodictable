<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserMenu))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DiffElemtypeButton = New System.Windows.Forms.Button()
        Me.ElmInfoButton = New System.Windows.Forms.Button()
        Me.introButton = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.menuLable = New System.Windows.Forms.Label()
        Me.quize = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.MetalReatSries = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.PeriodicTable.My.Resources.Resources.Back
        resources.ApplyResources(Me.Button4, "Button4")
        Me.Button4.Name = "Button4"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DiffElemtypeButton
        '
        resources.ApplyResources(Me.DiffElemtypeButton, "DiffElemtypeButton")
        Me.DiffElemtypeButton.Name = "DiffElemtypeButton"
        Me.DiffElemtypeButton.UseVisualStyleBackColor = True
        '
        'ElmInfoButton
        '
        resources.ApplyResources(Me.ElmInfoButton, "ElmInfoButton")
        Me.ElmInfoButton.Name = "ElmInfoButton"
        Me.ElmInfoButton.UseVisualStyleBackColor = True
        '
        'introButton
        '
        resources.ApplyResources(Me.introButton, "introButton")
        Me.introButton.Name = "introButton"
        Me.introButton.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkSlateGray
        Me.Panel1.Controls.Add(Me.menuLable)
        Me.Panel1.Controls.Add(Me.Button4)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'menuLable
        '
        resources.ApplyResources(Me.menuLable, "menuLable")
        Me.menuLable.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.menuLable.Name = "menuLable"
        '
        'quize
        '
        resources.ApplyResources(Me.quize, "quize")
        Me.quize.Name = "quize"
        Me.quize.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.PeriodicTable.My.Resources.Resources.SoundOff
        resources.ApplyResources(Me.Button6, "Button6")
        Me.Button6.Name = "Button6"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.PeriodicTable.My.Resources.Resources.SoundOn1
        resources.ApplyResources(Me.Button5, "Button5")
        Me.Button5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button5.Name = "Button5"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MetalReatSries
        '
        resources.ApplyResources(Me.MetalReatSries, "MetalReatSries")
        Me.MetalReatSries.Name = "MetalReatSries"
        Me.MetalReatSries.UseVisualStyleBackColor = True
        '
        'UserMenu
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.BackgroundImage = Global.PeriodicTable.My.Resources.Resources.theme3
        Me.ControlBox = False
        Me.Controls.Add(Me.MetalReatSries)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.quize)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.introButton)
        Me.Controls.Add(Me.ElmInfoButton)
        Me.Controls.Add(Me.DiffElemtypeButton)
        Me.Name = "UserMenu"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents DiffElemtypeButton As System.Windows.Forms.Button
    Friend WithEvents ElmInfoButton As System.Windows.Forms.Button
    Friend WithEvents introButton As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents menuLable As System.Windows.Forms.Label
    Friend WithEvents quize As System.Windows.Forms.Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents MetalReatSries As System.Windows.Forms.Button
End Class
