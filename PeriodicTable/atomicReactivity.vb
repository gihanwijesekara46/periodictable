Public Class atomicReactivity

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyBase.Close()
        UserMenu.Show()
    End Sub

    Private Sub LblCu_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles LblZn.MouseDown, LblSn.MouseDown, LblSb.MouseDown, LblPt.MouseDown, LblPb.MouseDown, LblNi.MouseDown, LBlNa.MouseDown, lblMn.MouseDown, LblMg.MouseDown, LblK.MouseDown, LblHg.MouseDown, LblH.MouseDown, LblFe.MouseDown, LblCu.MouseDown, LblCo.MouseDown, LblCd.MouseDown, LblCa.MouseDown, LblBi.MouseDown, LblBa.MouseDown, LblAu.MouseDown, LblAs.MouseDown, LblAl.MouseDown, LblAg.MouseDown
        Dim Lab As Label
        Lab = CType(sender, Label)
        Lab.DoDragDrop(Lab, DragDropEffects.Copy)
    End Sub




    Private Sub K_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles K.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "K" Then
            e.Effect = DragDropEffects.Copy
            K.Text = "K"
            LblK.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns

        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns

        End If
    End Sub


    Private Sub Ba_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Ba.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Ba" Then
            e.Effect = DragDropEffects.Copy
            Ba.Text = "Ba"
            LblBa.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns

        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Ca_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Ca.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Ca" Then
            e.Effect = DragDropEffects.Copy
            Ca.Text = "Ca"
            LblCa.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns

        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub


    Private Sub Na_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Na.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Na" Then
            e.Effect = DragDropEffects.Copy
            Na.Text = "Na"
            LBlNa.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns

        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Mg_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Mg.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Mg" Then
            e.Effect = DragDropEffects.Copy
            Mg.Text = "Mg"
            LblMg.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Al_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Al.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Al" Then
            e.Effect = DragDropEffects.Copy
            Al.Text = "Al"
            LblAl.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Mn_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Mn.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Mn" Then
            e.Effect = DragDropEffects.Copy
            Mn.Text = "Mn"
            lblMn.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Zn_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Zn.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Zn" Then
            e.Effect = DragDropEffects.Copy
            Zn.Text = "Zn"
            LblZn.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Co_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Co.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Co" Then
            e.Effect = DragDropEffects.Copy
            Co.Text = "Co"
            LblCo.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Fe_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Fe.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Fe" Then
            e.Effect = DragDropEffects.Copy
            Fe.Text = "Fe"
            LblFe.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Cd_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Cd.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Cd" Then
            e.Effect = DragDropEffects.Copy
            Cd.Text = "Cd"
            LblCd.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Ni_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Ni.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Ni" Then
            e.Effect = DragDropEffects.Copy
            Ni.Text = "Ni"
            LblNi.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Sn_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Sn.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Sn" Then
            e.Effect = DragDropEffects.Copy
            Sn.Text = "Sn"
            LblSn.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Pb_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Pb.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Pb" Then
            e.Effect = DragDropEffects.Copy
            Pb.Text = "Pb"
            LblPb.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub H_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles H.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "H" Then
            e.Effect = DragDropEffects.Copy
            H.Text = "H"
            LblH.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Cu_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Cu.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Cu" Then
            e.Effect = DragDropEffects.Copy
            Cu.Text = "Cu"
            LblCu.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub As_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Ase.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "As" Then
            e.Effect = DragDropEffects.Copy
            Ase.Text = "As"
            LblAs.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Sb_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Sb.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Sb" Then
            e.Effect = DragDropEffects.Copy
            Sb.Text = "Sb"
            LblSb.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Bi_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Bi.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Bi" Then
            e.Effect = DragDropEffects.Copy
            Bi.Text = "Bi"
            LblBi.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Hg_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Hg.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Hg" Then
            e.Effect = DragDropEffects.Copy
            Hg.Text = "Hg"
            LblHg.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Ag_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Ag.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Ag" Then
            e.Effect = DragDropEffects.Copy
            Ag.Text = "Ag"
            LblAg.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Pt_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Pt.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Pt" Then
            e.Effect = DragDropEffects.Copy
            Pt.Text = "Pt"
            LblPt.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub Au_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Au.DragEnter

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))

        If Lab.Text = "Au" Then
            e.Effect = DragDropEffects.Copy
            Au.Text = "Au"
            LblAu.Text = ""
            lblAns.Text = GlobalVariables.CorrectAns
        Else
            e.Effect = DragDropEffects.None
            lblAns.Text = GlobalVariables.IncorrectAns
        End If
    End Sub

    Private Sub atomicReactivity_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()
        LblReacDecrs.Text = GlobalVariables.LblReacDecrs
        LblReacDecrs2.Text = GlobalVariables.LblReacDecrs
        LblCheckelmTp.Text = GlobalVariables.LblCheckelmTp
        LabArngElm.Text = GlobalVariables.LabArngElm

    End Sub
End Class