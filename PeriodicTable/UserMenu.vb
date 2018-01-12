Public Class UserMenu
    Dim audiofile As String = "menu.wav"
    Dim sound1 As New Media.SoundPlayer(audiofile)

    Private Sub UserMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()
        Call GlobalVariables.words()
        menuLable.Text = GlobalVariables.menu
        introButton.Text = GlobalVariables.introButton
        ElmInfoButton.Text = GlobalVariables.ElmInfoButton
        DiffElemtypeButton.Text = GlobalVariables.DiffElemtypeButton
        quize.Text = GlobalVariables.quize
        MetalReatSries.Text = GlobalVariables.LblCheckelmTp
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        'MyBase.Hide()
        ' LangPage.Show()
        Application.Restart()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiffElemtypeButton.Click
        MyBase.Hide()
        CheckElmType.Show()

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElmInfoButton.Click
        MyBase.Hide()
        CheckElmInfo.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles introButton.Click
        MyBase.Hide()
        Introduct.Show()
    End Sub

   
    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles quize.Click
        MyBase.Hide()
        quiz.Show()
    End Sub

    Private Sub Button1_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MetalReatSries.Click
        MyBase.Hide()
        atomicReactivity.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sound1.Play()
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        sound1.Stop()
    End Sub

    
End Class