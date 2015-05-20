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

    Private Sub comboMic_Click(sender As Object, e As EventArgs) Handles comboMic.Click
        comboMic.Items.Clear()
        Dim waveInDevices As Integer = NAudio.Wave.WaveIn.DeviceCount
        For waveInDevice As Integer = 0 To waveInDevices - 1
            Dim deviceInfo As NAudio.Wave.WaveInCapabilities = NAudio.Wave.WaveIn.GetCapabilities(waveInDevice)
            comboMic.Items.Add(waveInDevice & ". " & deviceInfo.ProductName)
        Next
    End Sub

    Private Sub comboSpeaker_Click(sender As Object, e As EventArgs) Handles comboSpeaker.Click
        comboSpeaker.Items.Clear()
        Dim waveOutDevices As Integer = NAudio.Wave.WaveOut.DeviceCount
        For waveOutDevice As Integer = 0 To waveOutDevices - 1
            Dim deviceInfo As NAudio.Wave.WaveOutCapabilities = NAudio.Wave.WaveOut.GetCapabilities(waveOutDevice)
            comboSpeaker.Items.Add(waveOutDevice & ". " & deviceInfo.ProductName)
        Next
    End Sub

    Private Sub comboVAD_Click(sender As Object, e As EventArgs) Handles comboVAD.Click
        comboVAD.Items.Clear()
        Dim waveOutDevices As Integer = NAudio.Wave.WaveOut.DeviceCount
        For waveOutDevice As Integer = 0 To waveOutDevices - 1
            Dim deviceInfo As NAudio.Wave.WaveOutCapabilities = NAudio.Wave.WaveOut.GetCapabilities(waveOutDevice)
            comboVAD.Items.Add(waveOutDevice & ". " & deviceInfo.ProductName)
        Next
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        UpdateComboboxValues()
    End Sub
End Class