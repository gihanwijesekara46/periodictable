Public Class quiz

    Dim questions As New List(Of Q_A)
    Public mark As Integer
    Dim audiofile As String = "mcqQuest.wav"
    Dim sound1 As New Media.SoundPlayer(audiofile)

    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged

        Dim q As Q_A = DirectCast(ListBox1.SelectedItem, Q_A)
        RadioButton1.Text = q.answerA
        RadioButton1.Checked = False
        RadioButton2.Text = q.answerB
        RadioButton2.Checked = False
        RadioButton3.Text = q.answerC
        RadioButton3.Checked = False
        RadioButton4.Text = q.answerD
        RadioButton4.Checked = False
        OutPut.Text = ""
        NextAns.Text = ""
        checkAns.Enabled = True
        checkAns.ForeColor = Color.Brown

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles checkAns.Click
        
        Dim rb As RadioButton = Me.Controls.OfType(Of RadioButton).FirstOrDefault(Function(rBtn) rBtn.Checked)
        Dim q As Q_A = DirectCast(ListBox1.SelectedItem, Q_A)

        If rb IsNot Nothing Then

            If rb.Text = q.getAnswer Then
                OutPut.ForeColor = Color.Brown
                OutPut.Text = GlobalVariables.CorrectAns
                mark = mark + 1
                lableMark.Text = mark.ToString
                NextAns.Text = GlobalVariables.NextAns
                checkAns.Enabled = False

            Else
                OutPut.ForeColor = Color.Red
                OutPut.Text = GlobalVariables.IncorrectAns
                mark = mark - 1
                lableMark.Text = mark.ToString

            End If

        Else
            OutPut.ForeColor = Color.Blue
            OutPut.Text = GlobalVariables.emptyAns

        End If

    End Sub

    Private Sub quiz_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        mark = 0
        MyBase.CenterToScreen()
        checkAns.Text = GlobalVariables.checkAns

        questions.Add(New Q_A(GlobalVariables.Q1, "Be", "B", "Bi", "Bh", Q_A.answers.B))
        questions.Add(New Q_A(GlobalVariables.Q2, "La", "Lh", "Li", "L", Q_A.answers.C))
        questions.Add(New Q_A(GlobalVariables.Q3, "Holmium", "Hendrox", "Hydrogen", "Helium", Q_A.answers.D))
        questions.Add(New Q_A(GlobalVariables.Q4, "Boron", "Beryllium", "Bismuth", "Barium", Q_A.answers.B))
        questions.Add(New Q_A(GlobalVariables.Q5, "Ar", "A", "Ag", "Uuu", Q_A.answers.A))
        questions.Add(New Q_A(GlobalVariables.Q6, "Mm", "M", "Ma", "Mg", Q_A.answers.D))
        questions.Add(New Q_A(GlobalVariables.Q7, "C", "Ch", "Cl", "Ca", Q_A.answers.C))


        ListBox1.DataSource = questions
        ListBox1.DisplayMember = "question"
        checkAns.ForeColor = Color.Brown

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton3.CheckedChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyBase.Close()
        UserMenu.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sound1.Play()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sound1.Stop()
    End Sub

    Private Sub quiz_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        sound1.Stop()
    End Sub
End Class
