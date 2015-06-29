Public Class Main
#Region "ToolStripMethods"

#Region "Layout"
    Private Sub tsLayoutCascade_Click(sender As Object, e As EventArgs) Handles tsLayoutCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub tsLayoutVertical_Click(sender As Object, e As EventArgs) Handles tsLayoutVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub tsLayoutHorizontal_Click(sender As Object, e As EventArgs) Handles tsLayoutHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub tsLayoutArrange_Click(sender As Object, e As EventArgs) Handles tsLayoutArrange.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub
#End Region

#Region "File"
    Private Sub tsFileExit_Click(sender As Object, e As EventArgs) Handles tsFileExit.Click
        Application.Exit()
    End Sub
#End Region

#Region "Windows"
    Private Sub tsWinSettings_Click(sender As Object, e As EventArgs) Handles tsWinSettings.Click
        Settings.MdiParent = Me
        Settings.Show()
    End Sub

    Private Sub tsWinControl_Click(sender As Object, e As EventArgs) Handles tsWinControl.Click
        Control.MdiParent = Me
        Control.Show()
    End Sub

    Private Sub tsWinSoundboard_Click(sender As Object, e As EventArgs) Handles tsWinSoundboard.Click
        SoundBoard.MdiParent = Me
        SoundBoard.Show()
    End Sub
#End Region

#End Region
End Class
