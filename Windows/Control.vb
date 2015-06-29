Public Class Control

    Private Sub Control_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub UpdateLabels()
        lblVAD.Text = "Virtual Audio Device: " & GlobalSettings.NameVirtualAudioDevice
        lblSpeakers.Text = "Speakers: " & GlobalSettings.NameSpeaker
        lblMic.Text = "Microphone: " & GlobalSettings.NameMicrophone
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        UpdateLabels()
    End Sub
End Class