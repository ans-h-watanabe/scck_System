Imports System.Windows.Forms
Imports System.Drawing
Imports GrapeCity.Win.Bars
Imports utl_Com.utl_Com
Imports utl_Rpt.utl_Rpt
Imports utl_Rdb.utl_Rdb
Imports cns_Com.cns_Com
'機能概要*****************************************************************************************************
'*
'*  処理概要：部ﾏｽﾀ出力
'*
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*
'*
'*
'*
'*  更新日　：
'*  更新者　：
'*  更新内容：
'*
#Region " 旧履歴 "

'*  作成日　：2005/09/13
'*  作成者　：ANS佐藤太希
'*
'*  更新日　：2006/04/06
'*  更新者　：ANS和泉慶子
'*  更新内容：機能別ユーザー権限制御処置
'*
'*  更新日　：2006/04/27
'*  更新者　：ANS和泉慶子
'*  更新内容：Form位置調整処理　追加
'*
'*  更新日　：2007/08/6
'*  更新者　：ANS和泉慶子
'*  更新内容：中断処理追加
'*
'*  更新者　：軽部
'*  更新日　：2007/08/30
'*  更新内容：Windows Vista上でF10が効かない現象の対応

#End Region
'*
'*************************************************************************************************************
Public Class frm_M003_rpt

#Region "■ItemCode■"

    '*********************************************************************************************************
    '*  ﾒﾝﾊﾞ変数
    '*********************************************************************************************************
    Private D_SQL As String
    Private D_TBL As New DataTable
    Private D_ERR As New utl_Err.utl_ERR
    Private D_RPT As New rpt_M003
    Private D_TRD As Threading.Thread
    Private D_OWN_FRM As Form
    Private D_Main As Form

    '*********************************************************************************************************
    '*  公開ﾒﾝﾊﾞ変数
    '*********************************************************************************************************
    Public P_USR As New UserInfo()

#End Region

#Region "■ProcessingCode■"

    '*********************************************************************************************************
    '*
    '*  処理概要：ｺﾝｽﾄﾗｸﾀ
    '*
    '*  引数　　：1.参照ｲﾝﾃﾞｯｸｽ
    '*            2.ｽﾄｱﾄﾞﾌﾟﾛｼｰｼﾞｬ
    '*            3.ｵｰﾄ検索(true.ｵｰﾄ、false.通常)
    '*            4.業務分類区分
    '*            5.削除区分
    '*            5.事業所コード
    '*
    '*********************************************************************************************************
    Public Sub New(ByVal P1 As Form, P2 As String, P3 As Form)
        MyBase.New()
        '
        InitializeComponent()
        '
        Try
            D_OWN_FRM = P1
            '
            Me.Text = P2
            '
            D_Main = P3
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾌﾟﾛｸﾞﾗﾑ初期化
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_PRG_INT()
        '
        Try
            Call FNC_WINI_INT() : CType(D_OWN_FRM, Object).FNC_KEY.Enabled = False
            '
            '運用ﾚﾍﾞﾙ取得/ﾁｪｯｸ
            '
            'FNC_GET_UES_LVL(Me) →子ﾌｫｰﾑからCloseするとｴﾗｰになるので親ﾌｫｰﾑでの制御に移動
            '
            If IsNothing(P_USE_LVL) Then GoTo EXIT_FUNCTION
            '
            LBL_出力先情報.Text = FNC_RPT_LBL()
            '
            FNC_SET_ICO(Me)
            FNC_FRM_CLR(Me)
            FNC_USR_SET(P_USR)
            FNC_SET_IFO(P_USR, CTL_USR_IFO1)
            FNC_SET_MOD("R", CTL_USR_IFO1)
            '
            FNC_SCR_INT()
            FNC_LOD_PRM(Me, 2, D_OWN_FRM.Name & "_" & Name)
            FNC_LOD_HIS(Me, TAB_Message, D_OWN_FRM.Name & "_" & Name)
            '
            '強制初期化
            '
            TXT_名称.Text = ""
            '
            If TXT_帳票コード.Text.Trim.Equals("") Then
                FNC_DSP_IFO_DEF(Me, D_RPT)
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾌﾟﾛｸﾞﾗﾑ初期化
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Sub FNC_WINI_INT()
        '
        Try
            '画面最大化
            '
            Me.FormBorderStyle = FormBorderStyle.FixedToolWindow
            Me.WindowState = FormWindowState.Maximized
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：画面初期化
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_SCR_INT()

        Try
            'メッセージ通達の初期化
            '
            STT_Msg.Visible = False
            STT_Msg.Text = ""
            '
            TXT_帳票コード.Text = ""
            '
            'DSP_帳票名.Text = ""
            '
            FNC_DSP_IFO_DEF(Me, D_RPT)
            FNC_TXT_CLR(Me)
            '
            TXT_部コード_FROM.Text = "0"
            TXT_部コード_TO.Text = "99"
            TXT_名称.Text = ""
            '
            TXT_出力先.Text = "2"
            'TXT_実行モード.Text = "1"
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：画面入力値検査
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：Ture.正常、False.異常
    '*
    '*********************************************************************************************************
    Private Function FNC_SCR_CHK() As Boolean
        '
        Dim D_RTN As Boolean = True
        '
        Try
            STT_Msg.Visible = False : D_ERR.FNC_FID_INT()
            '
            '運用ﾚﾍﾞﾙﾁｪｯｸ
            '
            If Not FNC_CHK_RPT_LVL(TXT_出力先.Value) Then
                STT_Msg.Text = "" : D_RTN = False : GoTo EXIT_FUNCTION
            End If
            '
            If TXT_部コード_FROM.Text.Equals("0") OrElse TXT_部コード_FROM.Text.Equals("") Then
                TXT_部コード_FROM.Text = "0"
            End If
            If TXT_部コード_TO.Text.Equals("0") OrElse TXT_部コード_TO.Text.Equals("") Then
                TXT_部コード_TO.Text = "99"
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_SCR_CHK = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：実行
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：True.正常 , False.異常
    '*
    '*********************************************************************************************************
    Private Sub FNC_CMD_EXC()

        Dim I As Integer = 0
        '
        Try
            TAB_Message.SelectedIndex = 0
            '
            FNC_ADD_LOG(C_BAC_LIN_SRT & vbCrLf)
            FNC_ADD_LOG("条件ﾁｪｯｸ中暫くお待ち下さい", True)
            '
            If Not FNC_SCR_CHK() Then
                STT_Msg.Visible = True : D_ERR.FNC_SHW_ERR(Me, C_MSG_ERR_TTL) : GoTo EXIT_FUNCTION
            End If
            '
            D_SQL = "SPC_M003_RPT1 " & C_COM_COD & "," & C_COM_COD & "," & FNC_SQL_VAL(TXT_部コード_FROM) & "," & FNC_SQL_VAL(TXT_部コード_TO) & "," & FNC_SQL_VAL(TXT_名称)
            '
            FNC_ADD_LOG(C_MSG_OUT_DAT, True)
            '
            System.Diagnostics.Debug.WriteLine(D_SQL)

            D_TBL = FNC_GET_TBL(D_SQL)
            '
            '▽ｽﾚｯﾄﾞ実行
            '
            'D_TRD = New System.Threading.Thread(New System.Threading.ThreadStart(AddressOf SUB_TRD_EXC))
            'D_TRD.IsBackground = True
            'D_TRD.Start()
            '
            'Application.DoEvents()
            '
            Call SUB_TRD_EXC()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：出力処理
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub SUB_TRD_EXC()
        '
        Try
            If D_TBL.Rows.Count <> 0 Then
                TXT_部コード_FROM.Focus()
                FNC_KEY.KeySets(0).Item(3).Enabled = False
                FNC_KEY.KeySets(0).Item(4).Enabled = False
                FNC_KEY.KeySets(0).Item(7).Enabled = True
                FNC_KEY.KeySets(0).Item(8).Enabled = False
                FNC_KEY.KeySets(0).Item(11).Enabled = False
                '
                Application.DoEvents() : SynchronizingObject = Me
                '
                If Me.TXT_出力先.Text.Equals("4") Then
                    FNC_ADD_LOG(C_MSG_OUT_CSV, True)
                    FNC_SAV_CSV(D_TBL, FNC_CNV_FIL_NAM(Me.Text), , , True)
                    '
                ElseIf Me.TXT_出力先.Text.Equals("3") Then
                    FNC_ADD_LOG(C_MSG_OUT_PDF, True)
                    FNC_SAV_PDF(True, D_TBL, TXT_帳票コード.Text, D_RPT, FNC_CNV_FIL_NAM(Me.Text), , , , True)
                Else
                    Select Case TXT_出力先.Text
                        Case 1 : FNC_ADD_LOG(C_MSG_OUT_RPT, True)
                        Case 2 : FNC_ADD_LOG(C_MSG_OUT_PRV, True)
                        Case 3 : FNC_ADD_LOG(C_MSG_OUT_PDF, True)
                    End Select
                    '
                    FNC_RPT_EXC(TXT_出力先.Text, True, D_TBL, TXT_帳票コード.Text, D_RPT, , True)
                End If
                '
                '正常終了メッセージの表示
                '
                STT_Msg.Text = C_MSG_END_OUT : FNC_ADD_LOG("◎" & C_MSG_END_OUT, True)
            Else
                '対象データ無し
                STT_Msg.Text = "" : FNC_ADD_LOG("×対象データが存在しない為、キャンセルされました", True)
            End If
        Catch ex As Threading.ThreadAbortException
            FNC_ADD_LOG("△処理が中断されました", True)
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            SynchronizingObject = Nothing : D_TBL.Clear()
            '
            TXT_部コード_FROM.Focus()
            '
            FNC_ADD_LOG(C_BAC_LIN_END)
            '
            TXT_LOG.Text = LBL_ステータス.Text & vbCrLf & TXT_LOG.Text
            '
            LBL_ステータス.Text = ""
            LBL_ステータス.ForeColor = Color.Black
            LBL_ステータス.TextAlign = ContentAlignment.MiddleCenter
            LBL_ステータス.Visible = False
            '
            FNC_KEY.KeySets(0).Item(3).Enabled = True
            FNC_KEY.KeySets(0).Item(4).Enabled = True
            FNC_KEY.KeySets(0).Item(7).Enabled = False
            FNC_KEY.KeySets(0).Item(8).Enabled = True
            FNC_KEY.KeySets(0).Item(11).Enabled = True
            Application.DoEvents()
        End Try
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：中断
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_CMD_CCL()
        '
        Try
            If Not D_TRD Is Nothing AndAlso D_TRD.IsAlive Then
                FNC_ADD_LOG("処理中断中暫くお待ち下さい", True)
                D_TRD.Abort()
                D_TRD.Join()
                '
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ｽﾃｰﾀｽ追記
    '*
    '*  引数　　：1.ｽﾃｰﾀｽ
    '*
    '*  戻り値　：
    '*
    '*********************************************************************************************************
    Private Sub FNC_ADD_LOG(ByVal P1 As String, Optional ByVal OP1 As Boolean = False)
        '
        Try
            If Not LBL_ステータス.Visible Then LBL_ステータス.Visible = True
            '
            If Not LBL_ステータス.Text.Equals("") Then
                TXT_LOG.Text = LBL_ステータス.Text & vbCrLf & TXT_LOG.Text
            Else
                LBL_ステータス.ForeColor = Color.Blue
                LBL_ステータス.TextAlign = ContentAlignment.MiddleLeft
            End If
            '
            LBL_ステータス.Text = IIf(OP1, "＞" & Format(Now, "yy/MM/dd HH:mm:ss") & "：", "") & P1
            LBL_ステータス.Refresh()
            '
            TXT_LOG.Refresh()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：項目ﾘｽﾄ
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_DSP_LST()
        '
        Dim D_FRM As Form
        '
        Try
            Select Case ActiveControl.Name
                Case "TXT_帳票コード"
                    D_SQL = "SPC_SYS_RPT_LST1"
                    '
                    D_FRM = New utl_Rpt.frm_List(1, Me, D_SQL, ActiveControl.Name, "帳票情報一覧")
                Case Else
                    STT_Msg.Text = C_MSG_NOT_LST : GoTo EXIT_FUNCTION
            End Select
            '
            If Not IsNothing(D_FRM) Then
                D_FRM.ShowDialog(Me)
                D_FRM = Nothing
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：項目ﾘｽﾄ結果取得
    '*
    '*  引数　　：1.参照ｲﾝﾃﾞｯｸｽ
    '*            2.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            3.ｶﾚﾝﾄ行ｲﾝﾃﾞｯｸｽ
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Sub FNC_RCV_LST(ByVal P1 As Integer, ByVal P2 As DataTable, ByVal P3 As Integer)
        '
        Try
            If IsNothing(P2) Then GoTo EXIT_FUNCTION
            '
            Select Case P1
                Case 1
                    'ﾃﾞｰﾀ取得処理
                    '
                    FNC_DSP_IFO(Me, P2, P3)
            End Select
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            P2.Clear()
        End Try
        '
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：項目参照(対象項目名：帳票)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_REF_RPT()
        '
        Try
            If Not D_TRD Is Nothing AndAlso D_TRD.IsAlive Then
                Exit Sub
            End If
            '
            D_SQL = "SPC_SYS_RPT_INQ1 " & FNC_SQL_VAL(TXT_帳票コード)
            D_TBL = FNC_GET_TBL(D_SQL)

            If D_TBL.Rows.Count > 0 Then
                FNC_DSP_IFO(Me, D_TBL, 0)
            Else
                FNC_DSP_IFO_DEF(Me, D_RPT)
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            If D_TRD Is Nothing OrElse Not D_TRD.IsAlive Then
                D_TBL.Clear()
            End If
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾌﾟﾛｸﾞﾗﾑ終了
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_PRG_END()
        '
        Try
            D_ERR.FNC_ERR_INT()
            '
            FNC_SAV_PRM(Me, 2, D_OWN_FRM.Name & "_" & Name)
            FNC_SAV_HIS(Me, TAB_Message, D_OWN_FRM.Name & "_" & Name)
            '
            FNC_DPS_TBL(D_TBL)
            '
            If Not IsNothing(D_RPT) Then D_RPT = Nothing
            '
            Me.Dispose()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

#End Region

#Region "■FunctionKeyCode■"

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F1)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F01()
        '   
        Try
            If CON_Heading.IsExpanded Then
                CON_Heading.IsExpanded = False
            Else
                CON_Heading.IsExpanded = True
                '
                TXT_部コード_FROM.Focus()
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F2)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F02()
        '   
        Try
            If CON_出力設定.IsExpanded Then
                CON_出力設定.IsExpanded = False
            Else
                CON_出力設定.IsExpanded = True
                '
                TXT_出力先.Focus()
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F3)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F03()
        '   
        Try
            FNC_SCR_INT()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F4)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F04()
        '   
        Try
            FNC_DSP_LST()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F5)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F05()
        '   
        Try
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F6)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F06()
        '   
        Try
            '   
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F7)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F07()
        '   
        Try
            '   
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F8)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F08()
        '   
        Try
            FNC_CMD_CCL()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F9)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F09()
        '   
        Try
            FNC_CMD_EXC()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F10)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F10()
        '   
        Try
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F11)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F11()
        '   
        Try
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：FunctionKey処理(F12)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_F12()
        '   
        Try
            Call FNC_PRG_END()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

#End Region

#Region "■EventCode■"

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        Try
            ImeMode = ImeMode.Off 'IMEﾓｰﾄﾞ初期化
            '
            FNC_PRG_INT()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub Frm_Closed(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Closed
        '
        Try
            If Not D_TRD Is Nothing AndAlso D_TRD.IsAlive Then
                FNC_CMD_CCL()
            End If
            '
            FNC_PRG_END()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    Private Sub frm_M003_rpt_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        '
        Try
            If Not D_OWN_FRM Is Nothing Then
                CType(D_OWN_FRM, Object).FNC_KEY.Enabled = True : D_OWN_FRM.Show()
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    Private Sub frm_M003_rpt_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        '
        Try
            If e.KeyCode = Keys.F10 AndAlso Not FNC_KEY.KeySets(0).Item(9).Enabled Then
                'Keys.F10 AndAlso Not FNC_KEY.KeySets(0).Item(9).Enabled Then
                e.Handled = True
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub FNC_KEY_FunctionKeyPress(sender As Object, e As FunctionKeyPressEventArgs) Handles FNC_KEY.FunctionKeyPress
        '
        Try
            Select Case e.Key
                Case ButtonKeys.F1 : e.Handled = True : FNC_F01()
                Case ButtonKeys.F2 : e.Handled = True : FNC_F02()
                Case ButtonKeys.F3 : e.Handled = True : FNC_F03()
                Case ButtonKeys.F4 : e.Handled = True : FNC_F04()
                Case ButtonKeys.F5 : e.Handled = True : FNC_F05()
                Case ButtonKeys.F6 : e.Handled = True : FNC_F06()
                Case ButtonKeys.F7 : e.Handled = True : FNC_F07()
                Case ButtonKeys.F8 : e.Handled = True : FNC_F08()
                Case ButtonKeys.F9 : e.Handled = True : FNC_F09()
                Case ButtonKeys.F10 : e.Handled = True : FNC_F10()
                Case ButtonKeys.F11 : e.Handled = True : FNC_F11()
                Case ButtonKeys.F12 : e.Handled = True : FNC_F12()
                    '
                Case Else : GoTo EXIT_SUB
            End Select
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub STT_Msg_Click(sender As Object, e As EventArgs) Handles STT_Msg.Click
        '
        Try
            If STT_Msg.Visible Then
                D_ERR.FNC_SHW_ERR(Me, C_MSG_ERR_TTL)
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub TXT_帳票コード_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_帳票コード.Leave
        Try
            FNC_REF_RPT()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
    End Sub

#Region "■不要なため削除■"

    'Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '    '
    '    Try
    '        '座標設定
    '        '
    '        If Not Me.Location.Equals(P_FRM_LCN) Then Me.Location = P_FRM_LCN
    '    Catch ex As Exception
    '        FNC_ERR_RTN(ex)
    '    End Try
    'End Sub

    'Private Sub Frm_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LocationChanged
    '    '
    '    Try
    '        '座標格納
    '        '
    '        If Not IsNothing(Me.ActiveControl) Then P_FRM_LCN = Me.Location()
    '    Catch ex As Exception
    '        FNC_ERR_RTN(ex)
    '    End Try
    'End Sub

    'Protected Overrides Function ProcessKeyPreview(ByRef m As System.Windows.Forms.Message) As Boolean
    '    '
    '    Dim D_OPS As System.OperatingSystem = System.Environment.OSVersion
    '    '
    '    Try
    '        If D_OPS.Platform >= PlatformID.Win32NT AndAlso
    '            D_OPS.Version.Major >= 6 AndAlso
    '            D_OPS.Version.Minor >= 0 AndAlso
    '            m.LParam.ToInt32 = 4456449 AndAlso
    '            CType(m.WParam.ToString, Keys) = Keys.F10 Then
    '            '
    '            'F10が押下された時の処理
    '            '
    '            If FNC_KEY.KeySets(0).Item(9).Enabled Then FNC_F10()
    '            Return True
    '        Else
    '            MyBase.ProcessKeyPreview(m)
    '        End If
    '    Catch ex As Exception
    '        FNC_ERR_RTN(ex)
    '    End Try
    'End Function

#End Region

#End Region

#Region "■公開メソッド■"

    '*********************************************************************************************************
    '*
    '*  処理概要：事業所変更
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Sub FNC_CHG_JCD()
        '   
        Try
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：画面サイズ変更
    '*
    '*  引数　　：1.縮小率(上限:100%)
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Sub FNC_CHG_SIZ(P1 As Integer)
        '   
        Try
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：キーマクロ
    '*
    '*  引数　　：1.マクロコード
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Sub FNC_KEY_MCR(P1 As String)
        '   
        Try
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

#End Region

End Class