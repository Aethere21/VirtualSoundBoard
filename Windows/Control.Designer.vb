<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Control
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblVAD = New System.Windows.Forms.Label()
        Me.lblMic = New System.Windows.Forms.Label()
        Me.lblSpeakers = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.ProgressBar3 = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 50
        '
        'lblVAD
        '
        Me.lblVAD.AutoSize = True
        Me.lblVAD.Location = New System.Drawing.Point(9, 9)
        Me.lblVAD.Name = "lblVAD"
        Me.lblVAD.Size = New System.Drawing.Size(106, 13)
        Me.lblVAD.TabIndex = 0
        Me.lblVAD.Text = "Virtual Audio Device:"
        '
        'lblMic
        '
        Me.lblMic.AutoSize = True
        Me.lblMic.Location = New System.Drawing.Point(9, 38)
        Me.lblMic.Name = "lblMic"
        Me.lblMic.Size = New System.Drawing.Size(66, 13)
        Me.lblMic.TabIndex = 1
        Me.lblMic.Text = "Microphone:"
        '
        'lblSpeakers
        '
        Me.lblSpeakers.AutoSize = True
        Me.lblSpeakers.Location = New System.Drawing.Point(9, 67)
        Me.lblSpeakers.Name = "lblSpeakers"
        Me.lblSpeakers.Size = New System.Drawing.Size(55, 13)
        Me.lblSpeakers.TabIndex = 2
        Me.lblSpeakers.Text = "Speakers:"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 25)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(251, 10)
        Me.ProgressBar1.TabIndex = 3
        '
        'ProgressBar2
        '
        Me.ProgressBar2.Location = New System.Drawing.Point(12, 54)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(251, 10)
        Me.ProgressBar2.TabIndex = 4
        '
        'ProgressBar3
        '
        Me.ProgressBar3.Location = New System.Drawing.Point(12, 83)
        Me.ProgressBar3.Name = "ProgressBar3"
        Me.ProgressBar3.Size = New System.Drawing.Size(251, 10)
        Me.ProgressBar3.TabIndex = 5
        '
        'Control
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(275, 105)
        Me.Controls.Add(Me.ProgressBar3)
        Me.Controls.Add(Me.ProgressBar2)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.lblSpeakers)
        Me.Controls.Add(Me.lblMic)
        Me.Controls.Add(Me.lblVAD)
        Me.Name = "Control"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Control"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents lblVAD As System.Windows.Forms.Label
    Friend WithEvents lblMic As System.Windows.Forms.Label
    Friend WithEvents lblSpeakers As System.Windows.Forms.Label
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar2 As System.Windows.Forms.ProgressBar
    Friend WithEvents ProgressBar3 As System.Windows.Forms.ProgressBar
End Class
