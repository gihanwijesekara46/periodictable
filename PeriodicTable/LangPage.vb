

Public Class LangPage

    Dim audiofile As String = "LangPage.wav"
    Dim sound1 As New Media.SoundPlayer(audiofile)


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click


        Dim answer As MsgBoxResult
        answer = MsgBox("Do you want to quit now?", MsgBoxStyle.YesNo)
        If answer = MsgBoxResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        GlobalVariables.MyGlobalString = "en"

        MyBase.Hide()
        UserMenu.Show()
    End Sub


    Private Sub LangPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MyBase.CenterToScreen()
        
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        GlobalVariables.MyGlobalString = "lk"
        MyBase.Hide()
        UserMenu.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        GlobalVariables.MyGlobalString = "tm"
        MyBase.Hide()
        UserMenu.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        sound1.Play()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        sound1.Stop()
    End Sub
End Class