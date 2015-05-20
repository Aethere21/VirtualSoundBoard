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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblVolADV = New System.Windows.Forms.Label()
        Me.trkVolVAD = New System.Windows.Forms.TrackBar()
        Me.trkVolMic = New System.Windows.Forms.TrackBar()
        Me.lblVolMic = New System.Windows.Forms.Label()
        Me.lblVolSpeaker = New System.Windows.Forms.Label()
        Me.trkVolSpeaker = New System.Windows.Forms.TrackBar()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.comboVAD = New System.Windows.Forms.ComboBox()
        Me.comboMic = New System.Windows.Forms.ComboBox()
        Me.comboSpeaker = New System.Windows.Forms.ComboBox()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.trkVolVAD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkVolMic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.trkVolSpeaker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Virtual Audio Device:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Microphone:"
        '
        'lblVolADV
        '
        Me.lblVolADV.AutoSize = True
        Me.lblVolADV.Location = New System.Drawing.Point(12, 92)
        Me.lblVolADV.Name = "lblVolADV"
        Me.lblVolADV.Size = New System.Drawing.Size(164, 13)
        Me.lblVolADV.TabIndex = 6
        Me.lblVolADV.Text = "Virtual Audio Device Volume: (-%)"
        '
        'trkVolVAD
        '
        Me.trkVolVAD.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trkVolVAD.LargeChange = 10
        Me.trkVolVAD.Location = New System.Drawing.Point(12, 108)
        Me.trkVolVAD.Maximum = 100
        Me.trkVolVAD.Name = "trkVolVAD"
        Me.trkVolVAD.Size = New System.Drawing.Size(304, 45)
        Me.trkVolVAD.TabIndex = 7
        Me.trkVolVAD.Value = 50
        '
        'trkVolMic
        '
        Me.trkVolMic.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trkVolMic.LargeChange = 10
        Me.trkVolMic.Location = New System.Drawing.Point(12, 156)
        Me.trkVolMic.Maximum = 100
        Me.trkVolMic.Name = "trkVolMic"
        Me.trkVolMic.Size = New System.Drawing.Size(304, 45)
        Me.trkVolMic.TabIndex = 8
        Me.trkVolMic.Value = 50
        '
        'lblVolMic
        '
        Me.lblVolMic.AutoSize = True
        Me.lblVolMic.Location = New System.Drawing.Point(12, 140)
        Me.lblVolMic.Name = "lblVolMic"
        Me.lblVolMic.Size = New System.Drawing.Size(124, 13)
        Me.lblVolMic.TabIndex = 9
        Me.lblVolMic.Text = "Microphone Volume: (-%)"
        '
        'lblVolSpeaker
        '
        Me.lblVolSpeaker.AutoSize = True
        Me.lblVolSpeaker.Location = New System.Drawing.Point(12, 188)
        Me.lblVolSpeaker.Name = "lblVolSpeaker"
        Me.lblVolSpeaker.Size = New System.Drawing.Size(108, 13)
        Me.lblVolSpeaker.TabIndex = 12
        Me.lblVolSpeaker.Text = "Speaker Volume: (-%)"
        '
        'trkVolSpeaker
        '
        Me.trkVolSpeaker.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.trkVolSpeaker.LargeChange = 10
        Me.trkVolSpeaker.Location = New System.Drawing.Point(12, 204)
        Me.trkVolSpeaker.Maximum = 100
        Me.trkVolSpeaker.Name = "trkVolSpeaker"
        Me.trkVolSpeaker.Size = New System.Drawing.Size(304, 45)
        Me.trkVolSpeaker.TabIndex = 11
        Me.trkVolSpeaker.Value = 50
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Speaker:"
        '
        'comboVAD
        '
        Me.comboVAD.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboVAD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboVAD.Location = New System.Drawing.Point(124, 6)
        Me.comboVAD.Name = "comboVAD"
        Me.comboVAD.Size = New System.Drawing.Size(192, 21)
        Me.comboVAD.TabIndex = 13
        '
        'comboMic
        '
        Me.comboMic.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboMic.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboMic.Location = New System.Drawing.Point(124, 33)
        Me.comboMic.Name = "comboMic"
        Me.comboMic.Size = New System.Drawing.Size(192, 21)
        Me.comboMic.TabIndex = 14
        '
        'comboSpeaker
        '
        Me.comboSpeaker.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.comboSpeaker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboSpeaker.Location = New System.Drawing.Point(124, 60)
        Me.comboSpeaker.Name = "comboSpeaker"
        Me.comboSpeaker.Size = New System.Drawing.Size(192, 21)
        Me.comboSpeaker.TabIndex = 15
        '
        'btnRefresh
        '
        Me.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btnRefresh.Location = New System.Drawing.Point(264, 85)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(52, 23)
        Me.btnRefresh.TabIndex = 16
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 261)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.comboSpeaker)
        Me.Controls.Add(Me.comboMic)
        Me.Controls.Add(Me.comboVAD)
        Me.Controls.Add(Me.lblVolSpeaker)
        Me.Controls.Add(Me.trkVolSpeaker)
        Me.Controls.Add(Me.lblVolMic)
        Me.Controls.Add(Me.trkVolMic)
        Me.Controls.Add(Me.trkVolVAD)
        Me.Controls.Add(Me.lblVolADV)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.DoubleBuffered = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(600, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(280, 300)
        Me.Name = "Settings"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Settings"
        CType(Me.trkVolVAD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkVolMic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.trkVolSpeaker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblVolADV As System.Windows.Forms.Label
    Friend WithEvents trkVolVAD As System.Windows.Forms.TrackBar
    Friend WithEvents trkVolMic As System.Windows.Forms.TrackBar
    Friend WithEvents lblVolMic As System.Windows.Forms.Label
    Friend WithEvents lblVolSpeaker As System.Windows.Forms.Label
    Friend WithEvents trkVolSpeaker As System.Windows.Forms.TrackBar
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents comboVAD As System.Windows.Forms.ComboBox
    Friend WithEvents comboMic As System.Windows.Forms.ComboBox
    Friend WithEvents comboSpeaker As System.Windows.Forms.ComboBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
End Class
