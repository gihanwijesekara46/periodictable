Public Class CheckElmInfo
    Dim audiofile As String = "elementDetails.wav"
    Dim sound1 As New Media.SoundPlayer(audiofile)

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MyBase.Close()
        UserMenu.Show()
    End Sub

    Private Sub CheckElmInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MyBase.CenterToScreen()

        LabelDetailElm.Text = GlobalVariables.LabelDetailElm

        LabelElName.Text = GlobalVariables.LabelElName
        LabelShell.Text = GlobalVariables.LabelShell
        LabelIso.Text = GlobalVariables.LabelIso
        LabelAtmWgt.Text = GlobalVariables.LabelAtmWgt
        LabelOrbit.Text = GlobalVariables.LabelOrbit
        LabelMelt.Text = GlobalVariables.LabelMelt
        LabelElmnts.Text = GlobalVariables.LabelElmnts

        

    End Sub

    Private Sub Lr_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Zr.MouseClick, Zn.MouseClick, Yb.MouseClick, Y.MouseClick, Xe.MouseClick, W.MouseClick, V.MouseClick, U.MouseClick, Tm.MouseClick, Tii.MouseClick, Ti.MouseClick, Th.MouseClick, Te.MouseClick, Tc.MouseClick, Tb.MouseClick, Ta.MouseClick, Sr.MouseClick, Sn.MouseClick, Sm.MouseClick, Si.MouseClick, Se.MouseClick, Sc.MouseClick, Sb.MouseClick, S.MouseClick, Ru.MouseClick, Rn.MouseClick, Rh.MouseClick, Re.MouseClick, Rb.MouseClick, Ra.MouseClick, Pu.MouseClick, Pt.MouseClick, Pr.MouseClick, Po.MouseClick, Pm.MouseClick, Pd.MouseClick, Pb.MouseClick, Pa.MouseClick, P.MouseClick, Os.MouseClick, O.MouseClick, Np.MouseClick, No.MouseClick, Ni.MouseClick, Ne.MouseClick, Nd.MouseClick, Nb.MouseClick, Na.MouseClick, N.MouseClick, Mo.MouseClick, Mn.MouseClick, Mg.MouseClick, Md.MouseClick, Lu.MouseClick, Lr.MouseClick, Li.MouseClick, La.MouseClick, Kr.MouseClick, K.MouseClick, Ir.MouseClick, Inn.MouseClick, I.MouseClick, Ho.MouseClick, Hg.MouseClick, Hf.MouseClick, He.MouseClick, H.MouseClick, Ge.MouseClick, Gd.MouseClick, Ga.MouseClick, Fr.MouseClick, Fm.MouseClick, Fe.MouseClick, F.MouseClick, Eu.MouseClick, Es.MouseClick, Er.MouseClick, Dy.MouseClick, Cu.MouseClick, Cs.MouseClick, Cr.MouseClick, Co.MouseClick, Cm.MouseClick, Cl.MouseClick, Cf.MouseClick, Ce.MouseClick, Cd.MouseClick, Ca.MouseClick, C.MouseClick, Br.MouseClick, Bk.MouseClick, Bi.MouseClick, Be.MouseClick, Ba.MouseClick, B.MouseClick, Au.MouseClick, At.MouseClick, Ase.MouseClick, Ar.MouseClick, Am.MouseClick, Al.MouseClick, Ag.MouseClick, Ac.MouseClick

        Dim Lab As Label
        Lab = CType(sender, Label)
        Dim atom As String
        atom = Lab.Text
        OutPut.ForeColor = Color.Blue
        OutPut2.ForeColor = Color.Brown
        OutPut3.ForeColor = Color.Red
        OutPut4.ForeColor = Color.Green
        OutPut5.ForeColor = Color.Black
        OutPut6.ForeColor = Color.Orange

        If atom = "H" Then
            OutPut.Text = " Hydrogen"
            OutPut2.Text = " 1.0079"
            OutPut3.Text = " 1"
            OutPut4.Text = "1s1 "
            OutPut5.Text = " 3"
            OutPut6.Text = " -259.14 | -252.87"
            PictureBoxElmt.Image = My.Resources.H


        ElseIf atom = "He" Then
            OutPut.Text = " Helium"
            OutPut2.Text = " 4.0026"
            OutPut3.Text = " 2"
            OutPut4.Text = "1s2 "
            OutPut5.Text = " 5"
            OutPut6.Text = " -272C@26ATM | -268.6"
            PictureBoxElmt.Image = My.Resources.He

        ElseIf atom = "Li" Then
            OutPut.Text = " Lithium"
            OutPut2.Text = "6.94"
            OutPut3.Text = " 2,1"
            OutPut4.Text = "2s1 "
            OutPut5.Text = " 5"
            OutPut6.Text = " 180.54 | 1347"
            PictureBoxElmt.Image = My.Resources.Li

        ElseIf atom = "Be" Then
            OutPut.Text = " Beryllium"
            OutPut2.Text = "9.01218"
            OutPut3.Text = " 2,2"
            OutPut4.Text = "2s2 "
            OutPut5.Text = " 6"
            OutPut6.Text = " 1278 | 2970"
            PictureBoxElmt.Image = My.Resources.Be

        ElseIf atom = "B" Then
            OutPut.Text = " Boron"
            OutPut2.Text = "10.81"
            OutPut3.Text = " 2,3"
            OutPut4.Text = "2p1 "
            OutPut5.Text = " 6"
            OutPut6.Text = " 2300 | 2550"
            PictureBoxElmt.Image = My.Resources.B

        ElseIf atom = "C" Then
            OutPut.Text = " Carbon"
            OutPut2.Text = "12.011"
            OutPut3.Text = " 2,4"
            OutPut4.Text = "2p2 "
            OutPut5.Text = " 7"
            OutPut6.Text = "3500 | 4827"
            PictureBoxElmt.Image = My.Resources.C

        ElseIf atom = "N" Then
            OutPut.Text = " Nitrogen"
            OutPut2.Text = "14.0067"
            OutPut3.Text = " 2,5"
            OutPut4.Text = "2p3 "
            OutPut5.Text = " 8"
            OutPut6.Text = " -209.9 | -195.8"
            PictureBoxElmt.Image = My.Resources.N

        ElseIf atom = "O" Then
            OutPut.Text = " Oxygen"
            OutPut2.Text = "15.9994"
            OutPut6.Text = " -218.4 | -183.0"
            OutPut3.Text = " 2,6"
            OutPut5.Text = " 8"
            OutPut4.Text = "2p4 "
            PictureBoxElmt.Image = My.Resources.O

        ElseIf atom = "F" Then
            OutPut.Text = " Flourine"
            OutPut2.Text = "18.998403"
            OutPut6.Text = " -219.62 | -188.14"
            OutPut3.Text = " 2,7"
            OutPut5.Text = " 6"
            OutPut4.Text = "2p4 "
            PictureBoxElmt.Image = My.Resources.F

        ElseIf atom = "Ne" Then
            OutPut.Text = " Neon"
            OutPut2.Text = "20.17"
            OutPut6.Text = " -248.6 | -246.1"
            OutPut3.Text = " 2,8"
            OutPut5.Text = " 8"
            OutPut4.Text = "2p6 "
            PictureBoxElmt.Image = My.Resources.Ne

        ElseIf atom = "Na" Then
            OutPut.Text = " Sodium"
            OutPut2.Text = "22.98977"
            OutPut6.Text = " 97.8 | 882.9"
            OutPut3.Text = " 2,8,1"
            OutPut5.Text = " 7"
            OutPut4.Text = "3s1"
            PictureBoxElmt.Image = My.Resources.Na

        ElseIf atom = "Mg" Then
            OutPut.Text = " Magnesium"
            OutPut2.Text = "24.305"
            OutPut6.Text = " 638.8 | 1090"
            OutPut3.Text = " 2,8,2"
            OutPut5.Text = " 8"
            OutPut4.Text = "3s2"
            PictureBoxElmt.Image = My.Resources.Mg


        ElseIf atom = "Al" Then
            OutPut.Text = " Aluminum"
            OutPut2.Text = "26.98154"
            OutPut6.Text = " 660.37 | 2467"
            OutPut3.Text = " 2,8,3"
            OutPut5.Text = " 8"
            OutPut4.Text = "3d3"
            PictureBoxElmt.Image = My.Resources.Al

        ElseIf atom = "Si" Then
            OutPut.Text = " Silicon"
            OutPut2.Text = "28.0855"
            OutPut6.Text = " 1410 | 2355"
            OutPut3.Text = " 2,8,4"
            OutPut5.Text = " 8"
            OutPut4.Text = "3p2"
            PictureBoxElmt.Image = My.Resources.Si


        ElseIf atom = "P" Then
            OutPut.Text = " Phosphorous"
            OutPut2.Text = "30.97376"
            OutPut6.Text = " 44.1 | 280"
            OutPut3.Text = "2,8,5"
            OutPut5.Text = " 7"
            OutPut4.Text = "3p3"
            PictureBoxElmt.Image = My.Resources.P

        ElseIf atom = "S" Then
            OutPut.Text = " Sulfur"
            OutPut2.Text = "32.06"
            OutPut6.Text = "112.8 | 444.6"
            OutPut3.Text = "2,8,6"
            OutPut5.Text = " 10"
            OutPut4.Text = "3p4"
            PictureBoxElmt.Image = My.Resources.S

        ElseIf atom = "Cl" Then
            OutPut.Text = " Chlorine"
            OutPut2.Text = "32.06"
            OutPut6.Text = "112.8 | 444.6"
            OutPut3.Text = "2,8,6"
            OutPut5.Text = " 10"
            OutPut4.Text = "3p4"
            PictureBoxElmt.Image = My.Resources.Cl

        ElseIf atom = "Ar" Then
            OutPut.Text = " Argon"
            OutPut2.Text = "39.948"
            OutPut6.Text = "-189.3 | -186"
            OutPut3.Text = "2,8,8"
            OutPut5.Text = " 8"
            OutPut4.Text = "3p6"
            PictureBoxElmt.Image = My.Resources.Ar

        ElseIf atom = "K" Then
            OutPut.Text = " Potassium"
            OutPut2.Text = "39.0983"
            OutPut6.Text = "63.65 | 774"
            OutPut3.Text = "2,8,8,1"
            OutPut5.Text = " 10"
            OutPut4.Text = "4s1"
            PictureBoxElmt.Image = My.Resources.K

        ElseIf atom = "Ca" Then
            OutPut.Text = " Calcium"
            OutPut2.Text = "39.0983"
            OutPut6.Text = "63.65 | 774"
            OutPut3.Text = "2,8,8,1"
            OutPut5.Text = " 10"
            OutPut4.Text = "4s1"
            PictureBoxElmt.Image = My.Resources.C

        ElseIf atom = "Sc" Then
            OutPut.Text = " Scandium"
            OutPut2.Text = "44.9559"
            OutPut6.Text = "1539 | 2832"
            OutPut3.Text = "2,8,9,2"
            OutPut5.Text = " 15"
            OutPut4.Text = "3d1"
            PictureBoxElmt.Image = My.Resources.Sc

        ElseIf atom = "Ti" Then
            OutPut.Text = " Titanium"
            OutPut2.Text = "47.90"
            OutPut6.Text = "1660 | 3287"
            OutPut3.Text = "2,8,10,2"
            OutPut5.Text = " 9"
            OutPut4.Text = "3d2"
            PictureBoxElmt.Image = My.Resources.Ti

        ElseIf atom = "V" Then
            OutPut.Text = " Vanadium"
            OutPut2.Text = "50.9415"
            OutPut6.Text = "11890±10 | 3380"
            OutPut3.Text = "2,8,11,2"
            OutPut5.Text = " 9"
            OutPut4.Text = "3d3"
            PictureBoxElmt.Image = My.Resources.V

        ElseIf atom = "Cr" Then
            OutPut.Text = " Chromium"
            OutPut2.Text = "51.996"
            OutPut6.Text = "1857 | 2672"
            OutPut3.Text = "2,8,13,1"
            OutPut5.Text = " 9"
            OutPut4.Text = "3d5"
            PictureBoxElmt.Image = My.Resources.Cr

        ElseIf atom = "Mn" Then
            OutPut.Text = " Manganese"
            OutPut2.Text = "54.9380"
            OutPut6.Text = "1245 | 1962"
            OutPut3.Text = "2,8,13,2"
            OutPut5.Text = " 11"
            OutPut4.Text = "3d5"
            PictureBoxElmt.Image = My.Resources.Mn

        ElseIf atom = "Fe" Then
            OutPut.Text = " Iron"
            OutPut2.Text = "55.847"
            OutPut6.Text = "1535 | 2750"
            OutPut3.Text = "2,8,14,2"
            OutPut5.Text = " 10"
            OutPut4.Text = "3d6"
            PictureBoxElmt.Image = My.Resources.Fe

        ElseIf atom = "Co" Then
            OutPut.Text = " Cobalt"
            OutPut2.Text = "58.9332"
            OutPut6.Text = "1495 | 2870"
            OutPut3.Text = "2,8,15,2"
            OutPut5.Text = " 14"
            OutPut4.Text = "3d7"
            PictureBoxElmt.Image = My.Resources.Co

        ElseIf atom = "Ni" Then
            OutPut.Text = " Nickel"
            OutPut2.Text = "58.71"
            OutPut6.Text = "1453 | 2732"
            OutPut3.Text = "2,8,16,2"
            OutPut5.Text = " 11"
            OutPut4.Text = "3d8"
            PictureBoxElmt.Image = My.Resources.Ni

        ElseIf atom = "Cu" Then
            OutPut.Text = " Copper"
            OutPut2.Text = "63.546"
            OutPut6.Text = "1083 | 2567"
            OutPut3.Text = "2,8,18,1"
            OutPut5.Text = " 11"
            OutPut4.Text = "3d10"
            PictureBoxElmt.Image = My.Resources.Cu

        ElseIf atom = "Zn" Then
            OutPut.Text = " Zinc"
            OutPut2.Text = "65.38"
            OutPut6.Text = "419.58 | 907"
            OutPut3.Text = "2,8,18,2"
            OutPut5.Text = " 15"
            OutPut4.Text = "3d10"
            PictureBoxElmt.Image = My.Resources.Zn

        ElseIf atom = "Ga" Then
            OutPut.Text = " Gallium"
            OutPut2.Text = "69.735"
            OutPut6.Text = "29.78 | 2403"
            OutPut3.Text = "2,8,18,3"
            OutPut5.Text = " 14"
            OutPut4.Text = "4p1"
            PictureBoxElmt.Image = My.Resources.Ga

        ElseIf atom = "Ge" Then
            OutPut.Text = " Germanium"
            OutPut2.Text = "72.59"
            OutPut6.Text = "937.4 | 2830"
            OutPut3.Text = "2,8,18,4"
            OutPut5.Text = " 17"
            OutPut4.Text = "4p2"
            PictureBoxElmt.Image = My.Resources.Ge

        ElseIf atom = "As" Then
            OutPut.Text = " Arsenic"
            OutPut2.Text = "72.59"
            OutPut6.Text = "81@28ATM | Sublimes@613"
            OutPut3.Text = "2,8,18,5"
            OutPut5.Text = " 14"
            OutPut4.Text = "4p3"
            PictureBoxElmt.Image = My.Resources._As

        ElseIf atom = "Se" Then
            OutPut.Text = " Selenium"
            OutPut2.Text = "72.59"
            OutPut6.Text = "217 | 684.9"
            OutPut3.Text = "2,8,18,6"
            OutPut5.Text = " 20"
            OutPut4.Text = "4p4"
            PictureBoxElmt.Image = My.Resources.Se

        ElseIf atom = "Br" Then
            OutPut.Text = " Bromine"
            OutPut2.Text = "79.904"
            OutPut6.Text = "-7.2 | 58.78"
            OutPut3.Text = "2,8,18,7"
            OutPut5.Text = " 19"
            OutPut4.Text = "4p5"
            PictureBoxElmt.Image = My.Resources.Br

        ElseIf atom = "Kr" Then
            OutPut.Text = " Krypton"
            OutPut2.Text = "83.80"
            OutPut6.Text = "-157.2 | -153.4"
            OutPut3.Text = "2,8,18,8"
            OutPut5.Text = " 23"
            OutPut4.Text = "4p6"
            PictureBoxElmt.Image = My.Resources.Kr

        ElseIf atom = "Rb" Then
            OutPut.Text = " Rubidium"
            OutPut2.Text = "85.467"
            OutPut6.Text = "-38.89 | 688"
            OutPut3.Text = "2,8,18,8,1"
            OutPut5.Text = " 20"
            OutPut4.Text = "5s1"
            PictureBoxElmt.Image = My.Resources.Rb

        ElseIf atom = "Sr" Then
            OutPut.Text = " Strontium"
            OutPut2.Text = "87.62"
            OutPut6.Text = "769 | 1384"
            OutPut3.Text = "2,8,18,8,2"
            OutPut5.Text = " 18"
            OutPut4.Text = "5s2"
            PictureBoxElmt.Image = My.Resources.Sr

        ElseIf atom = "Y" Then
            OutPut.Text = " Yttrium"
            OutPut2.Text = "88.9059"
            OutPut6.Text = "1523 | 3337"
            OutPut3.Text = "2,8,18,9,2"
            OutPut5.Text = " 21"
            OutPut4.Text = "4d1"
            PictureBoxElmt.Image = My.Resources.Y

        ElseIf atom = "Zr" Then
            OutPut.Text = " Zirconium"
            OutPut2.Text = "91.22"
            OutPut6.Text = "1852±2 | 4377"
            OutPut3.Text = "2,8,18,10,2"
            OutPut5.Text = " 20"
            OutPut4.Text = "4d2"
            PictureBoxElmt.Image = My.Resources.Zr

        ElseIf atom = "Nb" Then
            OutPut.Text = " Niobium"
            OutPut2.Text = "92.9064"
            OutPut6.Text = "2468±10 | 4927"
            OutPut3.Text = "2,8,18,13,1"
            OutPut5.Text = " 24"
            OutPut4.Text = "4d4"
            PictureBoxElmt.Image = My.Resources.Nb

        ElseIf atom = "Mo" Then
            OutPut.Text = " Molybdenum"
            OutPut2.Text = "95.94"
            OutPut6.Text = "2617 | 4612"
            OutPut3.Text = "2,8,18,13,1"
            OutPut5.Text = " 20"
            OutPut4.Text = "4d5"
            PictureBoxElmt.Image = My.Resources.Mo

        ElseIf atom = "Tc" Then
            OutPut.Text = " Technetium"
            OutPut2.Text = "98.9062"
            OutPut6.Text = "2200±50 | 4877"
            OutPut3.Text = "2,8,18,14,1"
            OutPut5.Text = " 23"
            OutPut4.Text = "4d6"
            PictureBoxElmt.Image = My.Resources.Tc

        ElseIf atom = "Ru" Then
            OutPut.Text = " Ruthenium"
            OutPut2.Text = "101.07"
            OutPut6.Text = "2250 | 3900"
            OutPut3.Text = "2,8,18,15,1"
            OutPut5.Text = " 16"
            OutPut4.Text = "4d7"
            PictureBoxElmt.Image = My.Resources.Ru

        ElseIf atom = "Rh" Then
            OutPut.Text = " Rhodium"
            OutPut2.Text = "102.9055"
            OutPut6.Text = "2300 | 2550"
            OutPut3.Text = "2,8,18,16,1"
            OutPut5.Text = " 6"
            OutPut4.Text = "2p1"
            PictureBoxElmt.Image = My.Resources.Rh

        ElseIf atom = "Pd" Then
            OutPut.Text = " Palladium"
            OutPut2.Text = "106.4"
            OutPut6.Text = "1552 | 2927"
            OutPut3.Text = "2,8,18,18"
            OutPut5.Text = " 21"
            OutPut4.Text = "4d10"
            PictureBoxElmt.Image = My.Resources.Pd

        ElseIf atom = "Ag" Then
            OutPut.Text = " Silver"
            OutPut2.Text = "107.868"
            OutPut6.Text = "961.93 | 2212"
            OutPut3.Text = "2,8,18,18,1"
            OutPut5.Text = " 27"
            OutPut4.Text = "4d10"
            PictureBoxElmt.Image = My.Resources.Ag

        ElseIf atom = "Cd" Then
            OutPut.Text = " Cadmium"
            OutPut2.Text = "112.41"
            OutPut6.Text = "320.9 | 765"
            OutPut3.Text = "2,8,18,18,2"
            OutPut5.Text = " 22"
            OutPut4.Text = "4d10"
            PictureBoxElmt.Image = My.Resources.Cd

        ElseIf atom = "In" Then
            OutPut.Text = " Indium"
            OutPut2.Text = "114.82"
            OutPut6.Text = "156.61 | 2000±10"
            OutPut3.Text = "2,8,18,18,3"
            OutPut5.Text = " 34"
            OutPut4.Text = "5p1"
            PictureBoxElmt.Image = My.Resources._In

        ElseIf atom = "Sn" Then
            OutPut.Text = " Tin"
            OutPut2.Text = "118.69"
            OutPut6.Text = "231.9 | 2270"
            OutPut3.Text = "2,8,18,18,4"
            OutPut5.Text = " 28"
            OutPut4.Text = "5p2"
            PictureBoxElmt.Image = My.Resources.Sn

        ElseIf atom = "Sb" Then
            OutPut.Text = " Antimony"
            OutPut2.Text = "121.75"
            OutPut6.Text = "630 | 1750"
            OutPut3.Text = "2,8,18,18,5"
            OutPut5.Text = " 29"
            OutPut4.Text = "5p3"
            PictureBoxElmt.Image = My.Resources.Sb

        ElseIf atom = "Te" Then
            OutPut.Text = " Tellurium"
            OutPut2.Text = "127.60"
            OutPut6.Text = "449.5 | 989.8"
            OutPut3.Text = "2,8,18,18,6"
            OutPut5.Text = " 29"
            OutPut4.Text = "5p4"
            PictureBoxElmt.Image = My.Resources.Te

        ElseIf atom = "I" Then
            OutPut.Text = " Iodine"
            OutPut2.Text = "126.9045  "
            OutPut6.Text = "113.5 | 184@35atm"
            OutPut3.Text = "2,8,18,18,7"
            OutPut5.Text = " 24"
            OutPut4.Text = "5p5"
            PictureBoxElmt.Image = My.Resources.I

        ElseIf atom = "Xe" Then
            OutPut.Text = " Xenon"
            OutPut2.Text = "131.30"
            OutPut6.Text = "-111.9 | -108.1"
            OutPut3.Text = "2,8,18,18,8"
            OutPut5.Text = " 31"
            OutPut4.Text = "5p6"
            PictureBoxElmt.Image = My.Resources.Xe

        ElseIf atom = "Cs" Then
            OutPut.Text = " Cesium"
            OutPut2.Text = "132.9054"
            OutPut6.Text = "28.5 | 678.4"
            OutPut3.Text = "2,8,18,18,8,1"
            OutPut5.Text = " 22"
            OutPut4.Text = "6s1"
            PictureBoxElmt.Image = My.Resources.Cs

        ElseIf atom = "Ba" Then
            OutPut.Text = " Barium"
            OutPut2.Text = "137.33"
            OutPut6.Text = "725 | 1140"
            OutPut3.Text = "2,8,18,18,8,2"
            OutPut5.Text = " 25"
            OutPut4.Text = "6s2"
            PictureBoxElmt.Image = My.Resources.Ba

        ElseIf atom = "La" Then
            OutPut.Text = " Lanthanum"
            OutPut2.Text = "138.9055"
            OutPut6.Text = "920 | 3469"
            OutPut3.Text = "2,8,18,18,9,2"
            OutPut5.Text = " 19"
            OutPut4.Text = "5d1"
            PictureBoxElmt.Image = My.Resources.La

        ElseIf atom = "Hf" Then
            OutPut.Text = " Hafnium"
            OutPut2.Text = "178.49"
            OutPut6.Text = "2150 | 5400"
            OutPut3.Text = "2,8,18,32,10,2"
            OutPut5.Text = " 17"
            OutPut4.Text = "5d2"
            PictureBoxElmt.Image = My.Resources.Hf



        ElseIf atom = "Ta" Then
            OutPut.Text = " Tantalum"
            OutPut2.Text = "180.947"
            OutPut6.Text = "2996 | 5425±100"
            OutPut3.Text = "2,8,18,32,11,2"
            OutPut5.Text = " 19   "
            OutPut4.Text = "5d3"
            PictureBoxElmt.Image = My.Resources.Ta

        ElseIf atom = "W" Then
            OutPut.Text = " Tungsten"
            OutPut2.Text = "183.85"
            OutPut6.Text = "3410±20 | 5660"
            OutPut3.Text = "2,8,18,32,12,2"
            OutPut5.Text = " 22"
            OutPut4.Text = "5d4"
            PictureBoxElmt.Image = My.Resources.W


        ElseIf atom = "Re" Then
            OutPut.Text = " Rhenium"
            OutPut2.Text = "186.207"
            OutPut6.Text = "3180 | 5627"
            OutPut3.Text = "2,8,18,32,13,2"
            OutPut5.Text = " 21"
            OutPut4.Text = "5d5"
            PictureBoxElmt.Image = My.Resources.Re

        ElseIf atom = "Os" Then
            OutPut.Text = " Osmium"
            OutPut2.Text = "190.2"
            OutPut6.Text = "3045 | 5027"
            OutPut3.Text = "2,8,18,32,14,2"
            OutPut5.Text = " 19"
            OutPut4.Text = "5d6"
            PictureBoxElmt.Image = My.Resources.Os

        ElseIf atom = "Ir" Then
            OutPut.Text = " Iridium"
            OutPut2.Text = "192.22"
            OutPut6.Text = "2410 | 4527±100"
            OutPut3.Text = "2,8,18,32,15,2"
            OutPut5.Text = " 25   "
            OutPut4.Text = "5d7"
            PictureBoxElmt.Image = My.Resources.Ir

        ElseIf atom = "Pt" Then
            OutPut.Text = " Platinum"
            OutPut2.Text = "195.09"
            OutPut6.Text = "1772 | 3827"
            OutPut3.Text = "2,8,18,32,17,1"
            OutPut5.Text = " 32"
            OutPut4.Text = "5d9"
            PictureBoxElmt.Image = My.Resources.Pt

        ElseIf atom = "Au" Then
            OutPut.Text = " Gold"
            OutPut2.Text = "196.9665"
            OutPut6.Text = "1064.43 | 2807"
            OutPut3.Text = "2,8,18,32,18,1"
            OutPut5.Text = " 21"
            OutPut4.Text = "5d10"
            PictureBoxElmt.Image = My.Resources.Au

        ElseIf atom = "Hg" Then
            OutPut.Text = " Mercury"
            OutPut2.Text = "200.59"
            OutPut6.Text = "-38.87 | 356.58"
            OutPut3.Text = "2,8,18,32,18,2"
            OutPut5.Text = " 26"
            OutPut4.Text = "5d10"
            PictureBoxElmt.Image = My.Resources.Hg

        ElseIf atom = "Tl" Then
            OutPut.Text = " Thallium"
            OutPut2.Text = "204.37"
            OutPut6.Text = "-38.87 | 356.58"
            OutPut3.Text = "2,8,18,32,18,3"
            OutPut5.Text = " 28"
            OutPut4.Text = "6p1"
            PictureBoxElmt.Image = My.Resources.Tl


        ElseIf atom = "Pb" Then
            OutPut.Text = " Lead"
            OutPut2.Text = "207.2"
            OutPut6.Text = "327.5 | 1740"
            OutPut3.Text = "2,8,18,32,18,4"
            OutPut5.Text = " 29"
            OutPut4.Text = "6p2"
            PictureBoxElmt.Image = My.Resources.Pb


        ElseIf atom = "Bi" Then
            OutPut.Text = " Bismuth"
            OutPut2.Text = "208.9804"
            OutPut6.Text = "271.3 | 1560±5C"
            OutPut3.Text = "2,8,18,32,18,5"
            OutPut5.Text = " 19"
            OutPut4.Text = "6p3"
            PictureBoxElmt.Image = My.Resources.Bi


        ElseIf atom = "Po" Then
            OutPut.Text = " Polonium"
            OutPut2.Text = "209"
            OutPut6.Text = "254 | 962"
            OutPut3.Text = "2,8,18,32,18,6"
            OutPut5.Text = " 34"
            OutPut4.Text = "6p4"
            PictureBoxElmt.Image = My.Resources.Po


        ElseIf atom = "At" Then
            OutPut.Text = " Astatine"
            OutPut2.Text = "210"
            OutPut6.Text = "302 | 337"
            OutPut3.Text = "2,8,18,32,18,7"
            OutPut5.Text = " 21"
            OutPut4.Text = "6p5"
            PictureBoxElmt.Image = My.Resources.At



        ElseIf atom = "Rn" Then
            OutPut.Text = " Radon"
            OutPut2.Text = "222"
            OutPut6.Text = "-71 | -61.8"
            OutPut3.Text = "2,8,18,32,18,8"
            OutPut5.Text = " 20"
            OutPut4.Text = "6p6"
            PictureBoxElmt.Image = My.Resources.Rn


        ElseIf atom = "Fr" Then
            OutPut.Text = " Francium"
            OutPut2.Text = "223"
            OutPut6.Text = "27 | 677"
            OutPut3.Text = "2,8,18,32,18,8,1"
            OutPut5.Text = " 21"
            OutPut4.Text = "7s1"
            PictureBoxElmt.Image = My.Resources.Fr



        ElseIf atom = "Ra" Then
            OutPut.Text = " Radium"
            OutPut2.Text = "226.0254"
            OutPut6.Text = "700 | 1737"
            OutPut3.Text = "2,8,18,32,18,8,2"
            OutPut5.Text = " 15"
            OutPut4.Text = "7s2"
            PictureBoxElmt.Image = My.Resources.Ra

        ElseIf atom = "Ac" Then
            OutPut.Text = " Actinium"
            OutPut2.Text = "227"
            OutPut6.Text = "1050 | 3200±300"
            OutPut3.Text = "2,8,18,32,18,9,2"
            OutPut5.Text = " 11"
            OutPut4.Text = "6d1"
            PictureBoxElmt.Image = My.Resources.Ac

       
        ElseIf atom = "Ce" Then
            OutPut.Text = " Cerium"
            OutPut2.Text = "140.12"
            OutPut6.Text = "795 | 3257"
            OutPut3.Text = "2,8,18,20,8,2"
            OutPut5.Text = "19 "
            OutPut4.Text = "4f2"
            PictureBoxElmt.Image = My.Resources.Ce

        ElseIf atom = "Pr" Then
            OutPut.Text = " Praseodymium"
            OutPut2.Text = "140.9077"
            OutPut6.Text = "935 | 3127"
            OutPut3.Text = "2,8,18,21,8,2"
            OutPut5.Text = "18 "
            OutPut4.Text = "4f3"
            PictureBoxElmt.Image = My.Resources.Pr

        ElseIf atom = "Nd" Then
            OutPut.Text = " Neodymium"
            OutPut2.Text = "144.24"
            OutPut6.Text = "935 | 3127"
            OutPut3.Text = "2,8,18,22,8,2"
            OutPut5.Text = "16 "
            OutPut4.Text = "4f4"
            PictureBoxElmt.Image = My.Resources.Nd

        ElseIf atom = "Pm" Then
            OutPut.Text = " Promethium"
            OutPut2.Text = "145"
            OutPut6.Text = "N/A | N/A"
            OutPut3.Text = "2,8,18,23,8,2"
            OutPut5.Text = "14 "
            OutPut4.Text = "4f5"
            PictureBoxElmt.Image = My.Resources.Pm

        ElseIf atom = "Sm" Then
            OutPut.Text = " Samarium"
            OutPut2.Text = "150.4"
            OutPut6.Text = "1072 | 1900"
            OutPut3.Text = "2,8,18,24,8,2"
            OutPut5.Text = "17 "
            OutPut4.Text = "4f6"
            PictureBoxElmt.Image = My.Resources.Sm

        ElseIf atom = "Eu" Then
            OutPut.Text = " Europium"
            OutPut2.Text = "151.96"
            OutPut6.Text = "822 | 1597"
            OutPut3.Text = "2,8,18,25,8,2"
            OutPut5.Text = "21 "
            OutPut4.Text = "4f7"
            PictureBoxElmt.Image = My.Resources.Eu

        ElseIf atom = "Gd" Then
            OutPut.Text = " Gadolinium"
            OutPut2.Text = "157.25"
            OutPut6.Text = "1311 | 3233"
            OutPut3.Text = "2,8,18,25,9,2"
            OutPut5.Text = "17 "
            OutPut4.Text = "4f7"
            PictureBoxElmt.Image = My.Resources.Gd

        ElseIf atom = "Tb" Then
            OutPut.Text = " Terbium"
            OutPut2.Text = "158.9254"
            OutPut6.Text = "1360 | 3041"
            OutPut3.Text = "2,8,18,27,8,2"
            OutPut5.Text = "24 "
            OutPut4.Text = "4f9"
            PictureBoxElmt.Image = My.Resources.Tb

        ElseIf atom = "Dy" Then
            OutPut.Text = " Dysprosium"
            OutPut2.Text = "162.50"
            OutPut6.Text = "1412 | 2562"
            OutPut3.Text = "2,8,18,28,8,2"
            OutPut5.Text = "21"
            OutPut4.Text = "4f10"
            PictureBoxElmt.Image = My.Resources.Dy

        ElseIf atom = "Ho" Then
            OutPut.Text = " Holmium"
            OutPut2.Text = "164.9304"
            OutPut6.Text = "1470 | 2720"
            OutPut3.Text = "2,8,18,29,8,2"
            OutPut5.Text = "29"
            OutPut4.Text = "4f11"
            PictureBoxElmt.Image = My.Resources.Ho

        ElseIf atom = "Er" Then
            OutPut.Text = " Erbium"
            OutPut2.Text = "167.26"
            OutPut6.Text = "1522 | 2510"
            OutPut3.Text = "2,8,18,30,8,2"
            OutPut5.Text = "16"
            OutPut4.Text = "4f12"
            PictureBoxElmt.Image = My.Resources.Er

        ElseIf atom = "Tm" Then
            OutPut.Text = " Thulium"
            OutPut2.Text = "168.9342"
            OutPut6.Text = "1545 | 1727"
            OutPut3.Text = "2,8,18,31,8,2"
            OutPut5.Text = "18"
            OutPut4.Text = "4f13"
            PictureBoxElmt.Image = My.Resources.Tm

        ElseIf atom = "Yb" Then
            OutPut.Text = " Ytterbium"
            OutPut2.Text = "173.04"
            OutPut6.Text = "824 | 1466"
            OutPut3.Text = "2,8,18,32,8,2"
            OutPut5.Text = "16"
            OutPut4.Text = "4f14"
            PictureBoxElmt.Image = My.Resources.Yb

        ElseIf atom = "Lu" Then
            OutPut.Text = " Lutetium"
            OutPut2.Text = "174.96"
            OutPut6.Text = "1656 | 3315"
            OutPut3.Text = "2,8,18,32,9,2"
            OutPut5.Text = "22"
            OutPut4.Text = "4f14"
            PictureBoxElmt.Image = My.Resources.Lu

        ElseIf atom = "Th" Then
            OutPut.Text = " Thorium"
            OutPut2.Text = "232.0381"
            OutPut6.Text = "1750 | 4790"
            OutPut3.Text = "2,8,18,32,9,2"
            OutPut5.Text = "12"
            OutPut4.Text = "6d2"
            PictureBoxElmt.Image = My.Resources.Th

        ElseIf atom = "Pa" Then
            OutPut.Text = " Proactinium"
            OutPut2.Text = "231.0359"
            OutPut6.Text = "1600 | N/A"
            OutPut3.Text = "2,8,18,32,20,9,2"
            OutPut5.Text = "14"
            OutPut4.Text = "5f2"
            PictureBoxElmt.Image = My.Resources.Pa


        ElseIf atom = "U" Then
            OutPut.Text = " Uranium"
            OutPut2.Text = "238.029"
            OutPut6.Text = "1132 | 3818"
            OutPut3.Text = "2,8,18,32,21,9,2"
            OutPut5.Text = "15"
            OutPut4.Text = "5f3"
            PictureBoxElmt.Image = My.Resources.U


        ElseIf atom = "Np" Then
            OutPut.Text = " Neptunium"
            OutPut2.Text = "237.0482"
            OutPut6.Text = "640 | 3902"
            OutPut3.Text = "2,8,18,32,23,8,2"
            OutPut5.Text = "15"
            OutPut4.Text = "5f4"
            PictureBoxElmt.Image = My.Resources.Nb

        ElseIf atom = "Pu" Then
            OutPut.Text = " Plutonium"
            OutPut2.Text = "244"
            OutPut6.Text = "639.5±2 | 3235±19"
            OutPut3.Text = "2,8,18,32,24,8,2"
            OutPut5.Text = "16"
            OutPut4.Text = "5f6"
            PictureBoxElmt.Image = My.Resources.Pu

        ElseIf atom = "Am" Then
            OutPut.Text = " Americium"
            OutPut2.Text = "243"
            OutPut6.Text = "994 | 2607"
            OutPut3.Text = "2,8,18,32,25,8,2"
            OutPut5.Text = "13"
            OutPut4.Text = "5f7"
            PictureBoxElmt.Image = My.Resources.Am

        ElseIf atom = "Cm" Then
            OutPut.Text = " Curium"
            OutPut2.Text = "247"
            OutPut6.Text = "1340 | N/A"
            OutPut3.Text = "2,8,18,32,25,9,2"
            OutPut5.Text = "13"
            OutPut4.Text = "5f7"
            PictureBoxElmt.Image = My.Resources.Cm

        ElseIf atom = "Bk" Then
            OutPut.Text = " Berkelium"
            OutPut2.Text = "247"
            OutPut6.Text = "N/A | N/A"
            OutPut3.Text = "2,8,18,32,26,9,2"
            OutPut5.Text = "8"
            OutPut4.Text = "5f8"
            PictureBoxElmt.Image = My.Resources.Bk

        ElseIf atom = "Cf" Then
            OutPut.Text = " Californium"
            OutPut2.Text = "251"
            OutPut6.Text = "N/A | N/A"
            OutPut3.Text = "2,8,18,32,28,8,2"
            OutPut5.Text = "12"
            OutPut4.Text = "5f9"
            PictureBoxElmt.Image = My.Resources.Cf

        ElseIf atom = "Es" Then
            OutPut.Text = " Einsteinium"
            OutPut2.Text = "254"
            OutPut6.Text = "N/A | N/A"
            OutPut3.Text = "2,8,18,32,29,8,2"
            OutPut5.Text = "12"
            OutPut4.Text = "5f11"
            PictureBoxElmt.Image = My.Resources.Es

        ElseIf atom = "Fm" Then
            OutPut.Text = " Fermium"
            OutPut2.Text = "257"
            OutPut6.Text = "N/A | N/A"
            OutPut3.Text = "2,8,18,32,30,8,2"
            OutPut5.Text = "10"
            OutPut4.Text = "5f12"
            PictureBoxElmt.Image = My.Resources.Fm


        ElseIf atom = "Md" Then
            OutPut.Text = " Mendelevium"
            OutPut2.Text = "258"
            OutPut6.Text = "N/A | N/A"
            OutPut3.Text = "2,8,18,32,31,8,2"
            OutPut5.Text = "3"
            OutPut4.Text = "5f13"
            PictureBoxElmt.Image = My.Resources.Md


        ElseIf atom = "No" Then
            OutPut.Text = " Nobelium"
            OutPut2.Text = "259"
            OutPut6.Text = "N/A | N/A"
            OutPut3.Text = "2,8,18,32,32,8,2"
            OutPut5.Text = "7"
            OutPut4.Text = "5f14"
            PictureBoxElmt.Image = My.Resources.No


        ElseIf atom = "Lr" Then
            OutPut.Text = " Lawrencium"
            OutPut2.Text = "260"
            OutPut6.Text = "N/A | N/A"
            OutPut3.Text = "2,8,18,32,32,9,2"
            OutPut5.Text = "20"
            OutPut4.Text = "5f14"
            PictureBoxElmt.Image = My.Resources.Lr



        End If



    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        sound1.Play()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        sound1.Stop()
    End Sub

    Private Sub CheckElmInfo_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        sound1.Stop()
    End Sub
End Class