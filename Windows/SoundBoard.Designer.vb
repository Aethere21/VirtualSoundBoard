<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SoundBoard
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
        Me.ListView = New System.Windows.Forms.ListView()
        Me.KeyBind1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.KeyBind2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Play = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FileName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Browse = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'ListView
        '
        Me.ListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.KeyBind1, Me.KeyBind2, Me.Play, Me.FileName, Me.Browse})
        Me.ListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.ListView.Location = New System.Drawing.Point(266, 12)
        Me.ListView.Name = "ListView"
        Me.ListView.Size = New System.Drawing.Size(575, 287)
        Me.ListView.TabIndex = 0
        Me.ListView.UseCompatibleStateImageBehavior = False
        Me.ListView.View = System.Windows.Forms.View.Details
        '
        'KeyBind1
        '
        Me.KeyBind1.Text = "Key Bind"
        Me.KeyBind1.Width = 108
        '
        'KeyBind2
        '
        Me.KeyBind2.Text = "Key Bind"
        Me.KeyBind2.Width = 117
        '
        'Play
        '
        Me.Play.Text = "Play"
        Me.Play.Width = 41
        '
        'FileName
        '
        Me.FileName.Text = "File Name"
        Me.FileName.Width = 144
        '
        'Browse
        '
        Me.Browse.Text = "Browse"
        Me.Browse.Width = 79
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(153, 12)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 23)
        Me.btnAdd.TabIndex = 1
        Me.btnAdd.Text = "Add New Sound"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(153, 41)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(107, 23)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove Selected"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'SoundBoard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 311)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.ListView)
        Me.Name = "SoundBoard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SoundBoard"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListView As System.Windows.Forms.ListView
    Friend WithEvents KeyBind1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents KeyBind2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Play As System.Windows.Forms.ColumnHeader
    Friend WithEvents FileName As System.Windows.Forms.ColumnHeader
    Friend WithEvents Browse As System.Windows.Forms.ColumnHeader
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemove As System.Windows.Forms.Button
End Class
