Public Class CheckElmType

    Dim audiofile As String = "elementType.wav"
    Dim sound1 As New Media.SoundPlayer(audiofile)

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyBase.Close()
        UserMenu.Show()
    End Sub

    Private Sub CheckElmType_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()

        LabelCheckelmTp.Text = GlobalVariables.LabelCheckelmTp
        LabelSolid.Text = GlobalVariables.LabelSolid
        LabelLiquid.Text = GlobalVariables.LabelLiquid
        Labelgas.Text = GlobalVariables.Labelgas


    End Sub

    Private Sub Element_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Zr.MouseDown, Zn.MouseDown, Yb.MouseDown, Y.MouseDown, Xe.MouseDown, W.MouseDown, V.MouseDown, U.MouseDown, Tm.MouseDown, Tii.MouseDown, Ti.MouseDown, Th.MouseDown, Te.MouseDown, Tc.MouseDown, Tb.MouseDown, Ta.MouseDown, Sr.MouseDown, Sn.MouseDown, Sm.MouseDown, Si.MouseDown, Se.MouseDown, Sc.MouseDown, Sb.MouseDown, S.MouseDown, Ru.MouseDown, Rn.MouseDown, Rh.MouseDown, Re.MouseDown, Rb.MouseDown, Ra.MouseDown, Pu.MouseDown, Pt.MouseDown, Pr.MouseDown, Po.MouseDown, Pm.MouseDown, Pd.MouseDown, Pb.MouseDown, Pa.MouseDown, P.MouseDown, Os.MouseDown, O.MouseDown, Np.MouseDown, No.MouseDown, Ni.MouseDown, Ne.MouseDown, Nd.MouseDown, Nb.MouseDown, Na.MouseDown, N.MouseDown, Mo.MouseDown, Mn.MouseDown, Mg.MouseDown, Md.MouseDown, Lu.MouseDown, Lr.MouseDown, Li.MouseDown, La.MouseDown, Kr.MouseDown, K.MouseDown, Ir.MouseDown, Inn.MouseDown, I.MouseDown, Ho.MouseDown, Hg.MouseDown, Hf.MouseDown, He.MouseDown, H.MouseDown, Ge.MouseDown, Gd.MouseDown, Ga.MouseDown, Fr.MouseDown, Fm.MouseDown, Fe.MouseDown, F.MouseDown, Eu.MouseDown, Es.MouseDown, Er.MouseDown, Dy.MouseDown, Cu.MouseDown, Cs.MouseDown, Cr.MouseDown, Co.MouseDown, Cm.MouseDown, Cl.MouseDown, Cf.MouseDown, Ce.MouseDown, Cd.MouseDown, Ca.MouseDown, C.MouseDown, Br.MouseDown, Bk.MouseDown, Bi.MouseDown, Be.MouseDown, Ba.MouseDown, B.MouseDown, Au.MouseDown, At.MouseDown, Ase.MouseDown, Ar.MouseDown, Am.MouseDown, Al.MouseDown, Ag.MouseDown, Ac.MouseDown

        Dim Lab As Label
        Lab = CType(sender, Label)
        Lab.DoDragDrop(Lab, DragDropEffects.Copy)
    End Sub

    Private Sub SolidView_DragEnter_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles SolidView.DragEnter
        e.Effect = DragDropEffects.Copy
        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))
        Dim checkval As String = Lab.Text


        If checkelm(SolidView, checkval) = True Then
            OutPut.Text = ""
            OutPut.ForeColor = Color.Red
            OutPut.Text = "( " + Lab.Text + " ) " + GlobalVariables.ExitsSolid + ""

        ElseIf Lab.Text <> "H" And Lab.Text <> "He" And Lab.Text <> "N" And Lab.Text <> "O" And Lab.Text <> "F" And Lab.Text <> "Ne" And Lab.Text <> "Cl" And Lab.Text <> "Ar" And Lab.Text <> "Kr" And Lab.Text <> "Xe" And Lab.Text <> "Rn" And Lab.Text <> "Br" And Lab.Text <> "Hg" And Lab.Text <> "Tc" And Lab.Text <> "Rf" And Lab.Text <> "Db" And Lab.Text <> "Sg" And Lab.Text <> "Bh" And Lab.Text <> "Hs" And Lab.Text <> "Mt" And Lab.Text <> "Uun" And Lab.Text <> "Uuu" And Lab.Text <> "Uub" And Lab.Text <> "Uut" And Lab.Text <> "Uuq" And Lab.Text <> "Np" And Lab.Text <> "Pu" And Lab.Text <> "Am" And Lab.Text <> "Cm" And Lab.Text <> "Bk" And Lab.Text <> "Cf" And Lab.Text <> "Es" And Lab.Text <> "Fm" And Lab.Text <> "Md" And Lab.Text <> "No" And Lab.Text <> "Lr" Then
            OutPut.Text = ""
            OutPut.ForeColor = Color.Brown
            SolidView.Items.Add(Lab.Text)

            OutPut.Text = "( " + Lab.Text + " ) " + GlobalVariables.Solid + ""


        Else
            OutPut.Text = "( " + Lab.Text + " ) " + GlobalVariables.NtSolid + ""

        End If


    End Sub


    Private Sub LiquidView_DragEnter_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles LiquidView.DragEnter
        e.Effect = DragDropEffects.Copy

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))
        Dim checkval As String = Lab.Text

        If checkelm(LiquidView, checkval) = True Then
            OutPut.ForeColor = Color.Red
            OutPut.Text = "( " + Lab.Text + " ) " + GlobalVariables.ExitsLiquid + ""

        ElseIf Lab.Text = "Br" Or Lab.Text = "Hg" Then
            OutPut.ForeColor = Color.Brown
            LiquidView.Items.Add(Lab.Text)
            OutPut.Text = "( " + Lab.Text + " ) " + GlobalVariables.Liquid + ""

        Else
            OutPut.Text = "( " + Lab.Text + " ) " + GlobalVariables.NtLiquid + ""

        End If

    End Sub




    Private Sub gasView_DragEnter_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles gasView.DragEnter
        e.Effect = DragDropEffects.Copy

        Dim Lab As Label
        Lab = e.Data.GetData(GetType(Label))
        Dim checkval As String = Lab.Text

        If checkelm(gasView, checkval) = True Then
            OutPut.ForeColor = Color.Red
            OutPut.Text = "( " + Lab.Text + " ) " + GlobalVariables.ExitGas + ""

        ElseIf Lab.Text = "H" Or Lab.Text = "He" Or Lab.Text = "N" Or Lab.Text = "O" Or Lab.Text = "F" Or Lab.Text = "Ne" Or Lab.Text = "Cl" Or Lab.Text = "Ar" Or Lab.Text = "Kr" Or Lab.Text = "Xe" Or Lab.Text = "Rn" Then
            OutPut.ForeColor = Color.Brown
            gasView.Items.Add(Lab.Text)
            OutPut.Text = "( " + Lab.Text + " ) " + GlobalVariables.Gas + ""

        Else
            OutPut.Text = "( " + Lab.Text + " ) " + GlobalVariables.NtGas + ""

        End If

    End Sub



    Function checkelm(ByVal lv As ListView, ByVal SearchString As String)

        Dim _itm As ListViewItem
        Dim found As Boolean
        found = False
        For Each _itm In lv.Items
            If (_itm.SubItems(0).Text).ToString.Equals(SearchString) Then
                found = True
                Exit For
            End If
        Next
        Return found

    End Function

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sound1.Play()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sound1.Stop()
    End Sub

    Private Sub CheckElmType_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        sound1.Stop()
    End Sub
End Class