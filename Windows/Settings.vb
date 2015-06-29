Public Class Settings

    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateComboboxValues()
        GlobalSettings.VolumeVirtualAudioDevice = trkVolVAD.Value
        GlobalSettings.VolumeSpeaker = trkVolSpeaker.Value
        GlobalSettings.VolumeMicrophone = trkVolMic.Value
        UpdateLabelValues()
    End Sub

    Private Sub UpdateComboboxValues()
        comboSpeaker.Items.Clear()
        comboMic.Items.Clear()
        comboVAD.Items.Clear()
        Dim waveInDevices As Integer = NAudio.Wave.WaveIn.DeviceCount
        Dim waveOutDevices As Integer = NAudio.Wave.WaveOut.DeviceCount

        For waveOutDevice As Integer = 0 To waveOutDevices - 1
            Dim deviceInfo As NAudio.Wave.WaveOutCapabilities = NAudio.Wave.WaveOut.GetCapabilities(waveOutDevice)
            comboSpeaker.Items.Add(waveOutDevice & ". " & deviceInfo.ProductName)
            comboVAD.Items.Add(waveOutDevice & ". " & deviceInfo.ProductName)
        Next

        For waveInDevice As Integer = 0 To waveInDevices - 1
            Dim deviceInfo As NAudio.Wave.WaveInCapabilities = NAudio.Wave.WaveIn.GetCapabilities(waveInDevice)
            comboMic.Items.Add(waveInDevice & ". " & deviceInfo.ProductName)
        Next
    End Sub

    Private Sub UpdateLabelValues()
        lblVolADV.Text = "Virtual Audio Device Volume: (" & GlobalSettings.VolumeVirtualAudioDevice & "%)"
        lblVolMic.Text = "Microphone Volume: (" & GlobalSettings.VolumeMicrophone & "%)"
        lblVolSpeaker.Text = "Speaker Volume: (" & GlobalSettings.VolumeSpeaker & "%)"
    End Sub

    Private Sub trkVolVAD_ValueChanged(sender As Object, e As EventArgs) Handles trkVolVAD.ValueChanged
        GlobalSettings.VolumeVirtualAudioDevice = trkVolVAD.Value
        UpdateLabelValues()
    End Sub

    Private Sub trkVolSpeaker_ValueChanged(sender As Object, e As EventArgs) Handles trkVolSpeaker.ValueChanged
        GlobalSettings.VolumeSpeaker = trkVolSpeaker.Value
        UpdateLabelValues()
    End Sub

    Private Sub trkVolMic_ValueChanged(sender As Object, e As EventArgs) Handles trkVolMic.ValueChanged
        GlobalSettings.VolumeMicrophone = trkVolMic.Value
        UpdateLabelValues()
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        UpdateComboboxValues()
    End Sub

    'Could slightly optimize this, but eh.
    'Also, not really a good way to do this.
    Private Sub comboMic_ValueMemberChanged(sender As Object, e As EventArgs) Handles comboMic.SelectedValueChanged
        If (Not comboMic.Text = "") Then
            GlobalSettings.NameMicrophone = Split(comboMic.Text, ". ")(1)
            GlobalSettings.Microphone = Split(comboMic.Text, ". ")(0)
        End If
    End Sub

    Private Sub comboSpeaker_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboSpeaker.SelectedValueChanged
        If (Not comboSpeaker.Text = "") Then
            GlobalSettings.NameSpeaker = Split(comboSpeaker.Text, ". ")(1)
            GlobalSettings.Speaker = Split(comboSpeaker.Text, ". ")(0)
        End If
    End Sub

    Private Sub comboVAD_SelectedValueChanged(sender As Object, e As EventArgs) Handles comboVAD.SelectedValueChanged
        If (Not comboVAD.Text = "") Then
            GlobalSettings.NameVirtualAudioDevice = Split(comboVAD.Text, ". ")(1)
            GlobalSettings.VirtualAudioDevice = Split(comboVAD.Text, ". ")(0)
        End If
    End Sub
End Class