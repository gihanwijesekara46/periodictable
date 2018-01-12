Public Class Introduct
    Dim audiofile As String = "introduct.wav"
    Dim sound1 As New Media.SoundPlayer(audiofile)

    Private Sub Introduct_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()

        LabelIntro.Text = GlobalVariables.introButton
        Introlab1.Text = GlobalVariables.Introlab1
        Introlab2.Text = GlobalVariables.Introlab2
        Introlab3.Text = GlobalVariables.Introlab3
        Introlab4.Text = GlobalVariables.Introlab4
        Introlab5.Text = GlobalVariables.Introlab5
        Introlab6.Text = GlobalVariables.Introlab6
        Introlab7.Text = GlobalVariables.Introlab7
        Introlab8.Text = GlobalVariables.Introlab8
        Introlab9.Text = GlobalVariables.Introlab9
        Introlab11.Text = GlobalVariables.Introlab11
        Introlab12.Text = GlobalVariables.Introlab12
        Introlab13.Text = GlobalVariables.Introlab13
        Introlab14.Text = GlobalVariables.Introlab14
        Introlab15.Text = GlobalVariables.Introlab15
        Introlab16.Text = GlobalVariables.Introlab16

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MyBase.Close()
        UserMenu.Show()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        sound1.Stop()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sound1.Play()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sound1.Stop()
    End Sub

    Private Sub Introduct_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        sound1.Stop()
    End Sub
End Class