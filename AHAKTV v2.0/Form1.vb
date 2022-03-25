Imports MySql.Data.MySqlClient
Imports System.Data
Imports AxWMPLib
Imports WMPLib


Public Class AHAKTV
    Public Shared idntxtsearch As String = "Cari Berdasarkan Judul"
    Public Shared idntxtsinger As String = "Cari Berdasarkan Penyanyi"
    Public singergotfocus As Integer
    Public titlegotfocus As Integer

    Private Sub AHAKTV_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        Dim dgbtnadd As New DataGridViewButtonColumn

        Try
            Timer1.Start()
            Timer1.Interval = 1000
            singergotfocus = 0
            titlegotfocus = 0


            Module1.connectionsql()
            Module1.showdata()

            dgshow.Columns(0).Visible = False
            dgshow.DataSource = myData

            'Colum Title ------------------------------------------------------------------------------
            dgshow.Columns(1).Width = dgshow.Width / 3 - 50
            dgshow.Columns(1).DefaultCellStyle.ForeColor = Color.Maroon
            'Colum Title ------------------------------------------------------------------------------

            'Colum Judul ------------------------------------------------------------------------------
            dgshow.Columns(2).Width = dgshow.Width / 4
            dgshow.Columns(2).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgshow.Columns(2).DefaultCellStyle.ForeColor = Color.Black
            'Colum Judul ------------------------------------------------------------------------------

            'Colum Path ------------------------------------------------------------------------------
            dgshow.Columns(3).Width = dgshow.Width / 4
            dgshow.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgshow.Columns(3).DefaultCellStyle.ForeColor = Color.Black
            'Colum Path ------------------------------------------------------------------------------

            'Colum VOC ------------------------------------------------------------------------------
            dgshow.Columns(4).Width = dgshow.Width / 4
            dgshow.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            dgshow.Columns(4).DefaultCellStyle.ForeColor = Color.Black
            'Colum VOC ------------------------------------------------------------------------------

            'Colum Button ------------------------------------------------------------------------------
            Dim btn As New DataGridViewButtonColumn()
            dgshow.Columns.Add(btn)
            dgshow.Columns(5).Width = 45
            btn.HeaderText = "Click Data"
            btn.Text = "→"
            btn.Name = "rowbtn"
            btn.UseColumnTextForButtonValue = True
            'Colum Button ------------------------------------------------------------------------------


            'set textbox cari
            'end

            'hide panel keyboard
            'hide panel keyboard
            player1.uiMode = "none"

        Catch ex As Exception

        End Try




    End Sub

    Private Sub tbsearchtitlefocus(sender As Object, e As EventArgs) Handles tbsearchtitle.GotFocus
        Try
            titlegotfocus = 1
            singergotfocus = 0
            Panel1.Show()
            Panel1.BringToFront()
        Catch ex As Exception

        End Try
    End Sub



    Private Sub hidekbr_Click(sender As Object, e As EventArgs) Handles hidekbr.Click

        Try
            singergotfocus = 0
            Panel1.Hide()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub tbsearchsinger_GotFocus(sender As Object, e As EventArgs) Handles tbsearchsinger.GotFocus


        Try
            singergotfocus = 1
            titlegotfocus = 0
            Panel1.Show()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub dgshow_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgshow.CellClick

        Try
            singergotfocus = 0
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btnQ.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(btnQ.Text.ToString)
        Else
            tbsearchsinger.AppendText(btnQ.Text.ToString)

        End If
    End Sub

    Private Sub btnW_Click(sender As Object, e As EventArgs) Handles btnW.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(btnW.Text.ToString)
        Else
            tbsearchsinger.AppendText(btnW.Text.ToString)
        End If
    End Sub

    Private Sub btnE_Click(sender As Object, e As EventArgs) Handles btnE.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(btnE.Text.ToString)
        Else
            tbsearchsinger.AppendText(btnE.Text.ToString)
        End If
    End Sub

    Private Sub btnR_Click(sender As Object, e As EventArgs) Handles btnR.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(btnR.Text.ToString)
        Else
            tbsearchsinger.AppendText(btnR.Text.ToString)
        End If
    End Sub

    Private Sub btnT_Click(sender As Object, e As EventArgs) Handles btnT.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(btnT.Text.ToString)
        Else
            tbsearchsinger.AppendText(btnT.Text.ToString)
        End If
    End Sub

    Private Sub btnY_Click(sender As Object, e As EventArgs) Handles btnY.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(btnY.Text.ToString)
        Else
            tbsearchsinger.AppendText(btnY.Text.ToString)
        End If
    End Sub

    Private Sub btnU_Click(sender As Object, e As EventArgs) Handles btnU.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(btnU.Text.ToString)
        Else
            tbsearchsinger.AppendText(btnU.Text.ToString)
        End If
    End Sub

    Private Sub btnI_Click(sender As Object, e As EventArgs) Handles btnI.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(btnI.Text.ToString)
        Else
            tbsearchsinger.AppendText(btnI.Text.ToString)
        End If
    End Sub

    Private Sub btnO_Click(sender As Object, e As EventArgs) Handles btnO.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(btnO.Text.ToString)
        Else
            tbsearchsinger.AppendText(btnO.Text.ToString)
        End If
    End Sub

    Private Sub btnP_Click(sender As Object, e As EventArgs) Handles btnP.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(btnP.Text.ToString)
        Else
            tbsearchsinger.AppendText(btnP.Text.ToString)
        End If
    End Sub

    Private Sub btnA_Click(sender As Object, e As EventArgs) Handles btnA.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("A")
        Else
            tbsearchsinger.AppendText("A")
        End If
    End Sub

    Private Sub btnS_Click(sender As Object, e As EventArgs) Handles btnS.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("S")
        Else
            tbsearchsinger.AppendText("S")
        End If
    End Sub

    Private Sub btnD_Click(sender As Object, e As EventArgs) Handles btnD.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("D")
        Else
            tbsearchsinger.AppendText("D")
        End If
    End Sub

    Private Sub btnF_Click(sender As Object, e As EventArgs) Handles btnF.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("F")
        Else
            tbsearchsinger.AppendText("F")
        End If
    End Sub

    Private Sub btnG_Click(sender As Object, e As EventArgs) Handles btnG.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("G")
        Else
            tbsearchsinger.AppendText("G")
        End If
    End Sub

    Private Sub btnH_Click(sender As Object, e As EventArgs) Handles btnH.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("H")
        Else
            tbsearchsinger.AppendText("H")
        End If
    End Sub

    Private Sub btnJ_Click(sender As Object, e As EventArgs) Handles btnJ.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("J")
        Else
            tbsearchsinger.AppendText("J")
        End If
    End Sub

    Private Sub btnK_Click(sender As Object, e As EventArgs) Handles btnK.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("K")
        Else
            tbsearchsinger.AppendText("K")
        End If
    End Sub

    Private Sub btnL_Click(sender As Object, e As EventArgs) Handles btnL.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("L")
        Else
            tbsearchsinger.AppendText("L")
        End If
    End Sub

    Private Sub btnZ_Click(sender As Object, e As EventArgs) Handles btnZ.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("Z")
        Else
            tbsearchsinger.AppendText("Z")
        End If
    End Sub

    Private Sub btnX_Click(sender As Object, e As EventArgs) Handles btnX.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("X")
        Else
            tbsearchsinger.AppendText("X")
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("C")
        Else
            tbsearchsinger.AppendText("C")
        End If
    End Sub

    Private Sub btnV_Click(sender As Object, e As EventArgs) Handles btnV.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("V")
        Else
            tbsearchsinger.AppendText("V")
        End If
    End Sub

    Private Sub btnB_Click(sender As Object, e As EventArgs) Handles btnB.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("B")
        Else
            tbsearchsinger.AppendText("B")
        End If
    End Sub

    Private Sub btnN_Click(sender As Object, e As EventArgs) Handles btnN.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("N")
        Else
            tbsearchsinger.AppendText("N")
        End If
    End Sub

    Private Sub btnM_Click(sender As Object, e As EventArgs) Handles btnM.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("M")
        Else
            tbsearchsinger.AppendText("M")
        End If
    End Sub

    Private Sub btnKOMA_Click(sender As Object, e As EventArgs) Handles btnKOMA.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(",")
        Else
            tbsearchsinger.AppendText(",")
        End If
    End Sub

    Private Sub btnTITIK_Click(sender As Object, e As EventArgs) Handles btnTITIK.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(".")
        Else
            tbsearchsinger.AppendText(".")
        End If
    End Sub

    Private Sub btnGARING_Click(sender As Object, e As EventArgs) Handles btnGARING.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("/")
        Else
            tbsearchsinger.AppendText("/")
        End If
    End Sub

    Private Sub btnPETIK_Click(sender As Object, e As EventArgs) Handles btnPETIK.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText("'")
        Else
            tbsearchsinger.AppendText("'")
        End If
    End Sub

    Private Sub btnSPASI_Click(sender As Object, e As EventArgs) Handles btnSPASI.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.AppendText(" ")
        Else
            tbsearchsinger.AppendText(" ")
        End If
    End Sub

    Private Sub btnDELETE_Click(sender As Object, e As EventArgs) Handles btnDELETE.Click
        If titlegotfocus = 1 Then
            tbsearchtitle.Focus()
            System.Windows.Forms.SendKeys.Send("{BS}")
        Else
            tbsearchsinger.Focus()
            System.Windows.Forms.SendKeys.Send("{BS}")
        End If
    End Sub

    Private Sub btnSHIFT_Click(sender As Object, e As EventArgs) Handles btnSHIFT.Click


        If btnSHIFT.Text = "SHIFT" Then

            btnSHIFT.Text = "SHIFT ON"
            btnQ.Text = "1"
            btnW.Text = "2"
            btnE.Text = "3"
            btnR.Text = "4"
            btnT.Text = "5"
            btnY.Text = "6"
            btnU.Text = "7"
            btnI.Text = "8"
            btnO.Text = "9"
            btnP.Text = "0"

        Else
            btnSHIFT.Text = "SHIFT"
            btnQ.Text = "Q"
            btnW.Text = "W"
            btnE.Text = "E"
            btnR.Text = "R"
            btnT.Text = "T"
            btnY.Text = "Y"
            btnU.Text = "U"
            btnI.Text = "I"
            btnO.Text = "O"
            btnP.Text = "P"

        End If

    End Sub

    Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub VScrollBar1_Scroll(sender As Object, e As ScrollEventArgs) Handles VScrollBar1.Scroll

        Dim scrollLines As Integer = VScrollBar1.Value

        Try
            dgshow.FirstDisplayedScrollingRowIndex = scrollLines
        Catch ex As Exception

        End Try


    End Sub

    Private Sub tbsearchtitle_TextChanged(sender As Object, e As EventArgs) Handles tbsearchtitle.TextChanged
        BindingSource1.DataSource = myData
        dgshow.DataSource = myData
        BindingSource1.Filter = $"judul LIKE '{tbsearchtitle.Text}%'"
    End Sub

    Private Sub tbsearchsinger_TextChanged(sender As Object, e As EventArgs) Handles tbsearchsinger.TextChanged
        BindingSource1.DataSource = myData
        dgshow.DataSource = myData
        BindingSource1.Filter = $"artis LIKE '{tbsearchsinger.Text}%'"
    End Sub

    Private Sub btnENTER_Click(sender As Object, e As EventArgs) Handles btnENTER.Click
        ListBox1.Items.Add(selectedtb.Text.ToString)
        ListBox2.Items.Add(tbhidepath.Text.ToString)
    End Sub

    Private Sub dgshow_CellClick_1(sender As Object, e As DataGridViewCellEventArgs) Handles dgshow.CellClick

        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgshow.Rows(e.RowIndex)
            tbhidepath.Text = row.Cells(3).Value.ToString
            selectedtb.Text = row.Cells(1).Value.ToString + ",  " + row.Cells(2).Value.ToString
        End If
    End Sub

    Private Sub player1_Enter(sender As Object, e As EventArgs) Handles player1.Enter


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Sub dgshow_dblclick(sender As Object, e As DataGridViewCellEventArgs) Handles dgshow.CellDoubleClick
        Dim defaultpath As String = "C:\"
        Dim row As DataGridViewRow = dgshow.Rows(e.RowIndex)
        Dim Control3 As IWMPControls3 = player1.Ctlcontrols
        tbxvoc.Text = row.Cells(5).Value.ToString

        Try
            player1.URL = defaultpath + row.Cells(3).Value.ToString
            Control3.currentAudioLanguageIndex = row.Cells(4).Value.ToString


        Catch ex As Exception

        End Try


    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnvoc.Click
        Dim Control3 As IWMPControls3 = player1.Ctlcontrols

        Try
            btnxvoc.Show()
            btnvoc.Hide()
            Control3.currentAudioLanguageIndex = 2
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnxvoc.Click
        Dim Control3 As IWMPControls3 = player1.Ctlcontrols

        Try
            btnxvoc.Hide()
            btnvoc.Show()
            Control3.currentAudioLanguageIndex = tbxvoc.Text.ToString


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ListBox1_doubleclick(sender As Object, e As EventArgs) Handles ListBox1.MouseDoubleClick

        Dim defaultpath As String = "C:\"
        Dim Control3 As IWMPControls3 = player1.Ctlcontrols

        Try
            ListBox2.SelectedIndex = ListBox1.SelectedIndex
            Dim nextlisturl As String = ListBox2.GetItemText(ListBox2.SelectedItem)
            player1.URL = defaultpath + nextlisturl
            ListBox1.Items.Remove(ListBox1.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)



        Catch ex As Exception

        End Try


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim defaultpath As String = "C:\"
        Dim Control3 As IWMPControls3 = player1.Ctlcontrols

        Try
            If player1.playState = WMPPlayState.wmppsPlaying Then
                lbtimersong.Text = player1.Ctlcontrols.currentPositionString
                Dim g As String = player1.Ctlcontrols.currentItem.durationString
                Dim s1 As Double = TimeSpan.Parse(player1.Ctlcontrols.currentItem.durationString).TotalSeconds
                Dim s2 As Double = TimeSpan.Parse(player1.Ctlcontrols.currentPositionString).TotalSeconds
                Guna2TrackBar1.Maximum = s1
                Guna2TrackBar1.Value = s2
                player1.settings.volume = soundvolume.Value

            End If
        Catch ex As Exception

        End Try






        If player1.playState = WMPPlayState.wmppsStopped Then
            Try
                player1.URL = defaultpath + ListBox2.GetItemText(ListBox2.Items(ListBox2.TopIndex))
                ListBox1.Items.Remove(ListBox1.Items(ListBox1.TopIndex))
                ListBox2.Items.Remove(ListBox2.Items(ListBox2.TopIndex))



            Catch ex As Exception

            End Try

        End If

    End Sub

    Private Sub playbtn_Click(sender As Object, e As EventArgs) Handles playbtn.Click
        Try
            pausebtn.Show()
            playbtn.Hide()
            Dim Control3 As IWMPControls3 = player1.Ctlcontrols
            player1.Ctlcontrols.play()

        Catch ex As Exception

        End Try

    End Sub

    Private Sub stopbtn_Click(sender As Object, e As EventArgs) Handles stopbtn.Click
        Dim Control3 As IWMPControls3 = player1.Ctlcontrols
        player1.Ctlcontrols.stop()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "ENGLISH" Then
            Label1.Text = "SEARCH BY TITLE"
            Label2.Text = "SEARCH BY ARTIST"

        ElseIf ComboBox1.SelectedItem = "BAHASA INDONESIA" Then
            Label1.Text = "CARI BERDASARKAN JUDUL"
            Label2.Text = "CARI BERDASARKAN ARTIS"
        End If

    End Sub

    Private Sub pausebtn_Click(sender As Object, e As EventArgs) Handles pausebtn.Click

        Try
            pausebtn.Hide()
            playbtn.Show()
            player1.Ctlcontrols.pause()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged

        If Guna2ToggleSwitch1.Checked Then
            modeswitch.Text = "Dark Mode"

        Else
            modeswitch.Text = "Light Mode"

        End If


    End Sub

    Private Sub unmutebtn_Click(sender As Object, e As EventArgs) Handles unmutebtn.Click
        Dim Control3 As IWMPControls3 = player1.Ctlcontrols
        Try
            unmutebtn.Hide()
            mutebtn.Show()
            player1.settings.mute = False

        Catch ex As Exception

        End Try
    End Sub

    Private Sub mutebtn_Click(sender As Object, e As EventArgs) Handles mutebtn.Click
        Try
            unmutebtn.Show()
            mutebtn.Hide()
            player1.settings.mute = True
        Catch ex As Exception

        End Try
    End Sub


End Class
