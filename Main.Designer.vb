<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsFileOpen = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsFileSave = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.WindowsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsWinControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsWinSettings = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsWinSoundboard = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsWinVoiceChanger = New System.Windows.Forms.ToolStripMenuItem()
        Me.LayoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLayoutCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLayoutVertical = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLayoutHorizontal = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsLayoutArrange = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.tsStatus = New System.Windows.Forms.ToolStripStatusLabel()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.WindowsToolStripMenuItem, Me.LayoutToolStripMenuItem, Me.tsAbout})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(952, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFileOpen, Me.tsFileSave, Me.ToolStripSeparator1, Me.tsFileExit})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'tsFileOpen
        '
        Me.tsFileOpen.Name = "tsFileOpen"
        Me.tsFileOpen.Size = New System.Drawing.Size(152, 22)
        Me.tsFileOpen.Text = "Open Settings"
        '
        'tsFileSave
        '
        Me.tsFileSave.Name = "tsFileSave"
        Me.tsFileSave.Size = New System.Drawing.Size(152, 22)
        Me.tsFileSave.Text = "Save Settings"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'tsFileExit
        '
        Me.tsFileExit.Name = "tsFileExit"
        Me.tsFileExit.Size = New System.Drawing.Size(152, 22)
        Me.tsFileExit.Text = "Exit"
        '
        'WindowsToolStripMenuItem
        '
        Me.WindowsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsWinControl, Me.tsWinSettings, Me.tsWinSoundboard, Me.tsWinVoiceChanger})
        Me.WindowsToolStripMenuItem.Name = "WindowsToolStripMenuItem"
        Me.WindowsToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.WindowsToolStripMenuItem.Text = "Windows"
        '
        'tsWinControl
        '
        Me.tsWinControl.Name = "tsWinControl"
        Me.tsWinControl.Size = New System.Drawing.Size(152, 22)
        Me.tsWinControl.Text = "Control"
        '
        'tsWinSettings
        '
        Me.tsWinSettings.Name = "tsWinSettings"
        Me.tsWinSettings.Size = New System.Drawing.Size(152, 22)
        Me.tsWinSettings.Text = "Settings"
        '
        'tsWinSoundboard
        '
        Me.tsWinSoundboard.Name = "tsWinSoundboard"
        Me.tsWinSoundboard.Size = New System.Drawing.Size(152, 22)
        Me.tsWinSoundboard.Text = "Soundboard"
        '
        'tsWinVoiceChanger
        '
        Me.tsWinVoiceChanger.Name = "tsWinVoiceChanger"
        Me.tsWinVoiceChanger.Size = New System.Drawing.Size(152, 22)
        Me.tsWinVoiceChanger.Text = "Voice Changer"
        '
        'LayoutToolStripMenuItem
        '
        Me.LayoutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLayoutCascade, Me.tsLayoutVertical, Me.tsLayoutHorizontal, Me.tsLayoutArrange})
        Me.LayoutToolStripMenuItem.Name = "LayoutToolStripMenuItem"
        Me.LayoutToolStripMenuItem.Size = New System.Drawing.Size(55, 20)
        Me.LayoutToolStripMenuItem.Text = "Layout"
        '
        'tsLayoutCascade
        '
        Me.tsLayoutCascade.Name = "tsLayoutCascade"
        Me.tsLayoutCascade.Size = New System.Drawing.Size(151, 22)
        Me.tsLayoutCascade.Text = "Cascade"
        '
        'tsLayoutVertical
        '
        Me.tsLayoutVertical.Name = "tsLayoutVertical"
        Me.tsLayoutVertical.Size = New System.Drawing.Size(151, 22)
        Me.tsLayoutVertical.Text = "Tile Vertical"
        '
        'tsLayoutHorizontal
        '
        Me.tsLayoutHorizontal.Name = "tsLayoutHorizontal"
        Me.tsLayoutHorizontal.Size = New System.Drawing.Size(151, 22)
        Me.tsLayoutHorizontal.Text = "Tile Horizontal"
        '
        'tsLayoutArrange
        '
        Me.tsLayoutArrange.Name = "tsLayoutArrange"
        Me.tsLayoutArrange.Size = New System.Drawing.Size(151, 22)
        Me.tsLayoutArrange.Text = "Arrange Icons"
        '
        'tsAbout
        '
        Me.tsAbout.Name = "tsAbout"
        Me.tsAbout.Size = New System.Drawing.Size(52, 20)
        Me.tsAbout.Text = "About"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsStatus})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 499)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 12, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(952, 22)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'tsStatus
        '
        Me.tsStatus.Name = "tsStatus"
        Me.tsStatus.Size = New System.Drawing.Size(60, 17)
        Me.tsStatus.Text = "Status: ---"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(952, 521)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Virtual Sound Board"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsFileOpen As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsFileSave As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsFileExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WindowsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsWinControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsWinSettings As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsWinSoundboard As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsWinVoiceChanger As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsAbout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents tsStatus As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents LayoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsLayoutCascade As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsLayoutVertical As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsLayoutHorizontal As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsLayoutArrange As System.Windows.Forms.ToolStripMenuItem

End Class
