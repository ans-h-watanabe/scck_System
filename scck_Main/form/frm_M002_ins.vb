Imports System.Windows.Forms
Imports GrapeCity.Win.Bars
Imports cns_Com.cns_Com
Imports utl_Com.utl_Com
Imports utl_Rdb.utl_Rdb
Imports utl_History.utl_History
'機能概要*****************************************************************************************************
'*
'*  処理概要：業務分類ﾏｽﾀｰﾒﾝﾃﾅﾝｽ
'*
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*
'*                <残>
'*                    frm_M002_fnd→呼び出し
'*                    Frm_Activated→動作確認 →Mainフォームに格納するので不要
'*                    Frm_LocationChanged→動作確認 →Mainフォームに格納するので不要
'*                    Function ProcessKeyPreview→動作確認 →現行バージョンの不具合なので、動作確認後に問題なければ不要とする
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
'*  更新日　：2006/03/03
'*  更新者　：ANS和泉慶子
'*  更新内容：2006/03/03 新規登録時、keyをｸﾘｱ
'*            2006/04/06 機能別ユーザー権限制御処置
'*            2006/04/07 削除処理
'*            2006/04/27 Form位置調整処理　追加
'*            2006/07/12 F4参照部分  修正
'*
'*  更新者　：軽部
'*  更新日　：2007/08/30
'*  更新内容：Windows Vista上でF10が効かない現象の対応
'*
'*  更新者　：山田
'*  更新日　：2008/08/08
'*  更新内容：事業部コード⇒業務分類区分に変更

#End Region
'*
'*************************************************************************************************************
Public Class frm_M002_ins

    Public Sub New()
        InitializeComponent()
    End Sub

    Public Sub New(P1 As String)
        InitializeComponent()
        '
        Me.Text = P1
    End Sub

    Public Sub New(P1 As String, P2 As frm_Main)
        InitializeComponent()
        '
        Me.Text = P1
        '
        D_Main = P2
    End Sub

#Region "■ItemCode■"

    '*********************************************************************************************************
    '*  ﾒﾝﾊﾞ変数
    '*********************************************************************************************************
    Private D_SQL As String
    Private D_MOD As String
    Private D_TBL As New DataTable
    Private D_ERR As New utl_Err.utl_ERR
    Private D_KEY(1) As String
    Private D_Main As frm_Main

    '*********************************************************************************************************
    '*  公開ﾒﾝﾊﾞ変数
    '*********************************************************************************************************
    Public P_USR As New UserInfo()

#End Region

#Region "■ProcessingCode■"

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
            Call FNC_WINI_INT()
            '
            '運用レベル取得/チェック
            '
            'FNC_GET_UES_LVL(Me) →子ﾌｫｰﾑからCloseするとｴﾗｰになるので親ﾌｫｰﾑでの制御に移動
            '
            If IsNothing(P_USE_LVL) Then GoTo EXIT_FUNCTION
            '
            FNC_SET_ICO(Me)
            FNC_FRM_CLR(Me)
            FNC_USR_SET(P_USR)
            FNC_SET_IFO(P_USR, CTL_USR_IFO1)
            '
            FNC_SET_MOD("A")
            '
            D_KEY(0) = TXT_業務分類区分.Text
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
        '
        Try
            FNC_TXT_CLR(CTL_Main)
            '
            '登録更新情報初期化
            '
            FNC_CLR_IFO(CTL_UPD)
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：処理ﾓｰﾄﾞｾｯﾄ
    '*
    '*  引数　　：1.ﾓｰﾄﾞ
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_SET_MOD(ByVal P1 As String)
        '
        Try
            D_MOD = P1
            '
            'ｴﾗｰｵﾌﾞｼﾞｪｸﾄ初期化
            '
            D_ERR.FNC_FID_INT()
            '
            STT_Msg.Visible = False
            '
            utl_Com.utl_Com.FNC_SET_MOD(P1, CTL_USR_IFO1)
            '
            'ﾓｰﾄﾞ別処理
            '
            Select Case P1
                Case "A"
                    FNC_SCR_INT()
                    '
                    FNC_KEY.KeySets(0).Item(0).Enabled = False
                    FNC_KEY.KeySets(0).Item(1).Enabled = True
                    FNC_KEY.KeySets(0).Item(2).Enabled = True
                    FNC_KEY.KeySets(0).Item(8).Text = C_BTN_MSG_REG
                    '
                Case "U"
                    FNC_KEY.KeySets(0).Item(0).Enabled = True
                    FNC_KEY.KeySets(0).Item(1).Enabled = False
                    FNC_KEY.KeySets(0).Item(2).Enabled = True
                    FNC_KEY.KeySets(0).Item(8).Text = C_BTN_MSG_REG
                    '
                Case "D"
                    FNC_KEY.KeySets(0).Item(0).Enabled = True
                    FNC_KEY.KeySets(0).Item(1).Enabled = True
                    FNC_KEY.KeySets(0).Item(2).Enabled = False
                    FNC_KEY.KeySets(0).Item(8).Text = C_BTN_MSG_EXC
                    '
                Case Else : GoTo EXIT_FUNCTION
            End Select
            '
            TXT_業務分類区分.Focus()
            '
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
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Function FNC_SCR_CHK() As Boolean
        '
        Dim D_RTN As Boolean = True
        '
        Try
            STT_Msg.Visible = False : D_ERR.FNC_FID_INT()
            '
            '運用レベルチェック
            '
            If Not FNC_CHK_AUD_LVL(D_MOD) Then
                STT_Msg.Text = "" : D_RTN = False : GoTo EXIT_FUNCTION
            End If
            '
            If TXT_業務分類区分.Text.Equals("") OrElse TXT_業務分類区分.Text.Equals("0") Then
                D_ERR.FNC_ERR_ADD(TXT_業務分類区分, C_MSG_MST_INP, GcStylePlus1)
                '
                STT_Msg.Text = "" : D_RTN = False
            End If
            '
            'KEY項目チェック
            If Not D_MOD.Equals("A") AndAlso Not (D_KEY(0).Equals(TXT_業務分類区分.Text)) Then
                MsgBox(C_MSG_KEY_DEF, MsgBoxStyle.Exclamation, "キー値確認")
                '
                STT_Msg.Text = "" : D_RTN = False
                '
                GoTo EXIT_FUNCTION
            End If
            '
            If Not D_MOD.Equals("D") Then
                If TXT_名称.Text.Equals("") Then
                    D_ERR.FNC_ERR_ADD(TXT_名称, C_MSG_MST_INP, GcStylePlus1)
                    '
                    STT_Msg.Text = "" : D_RTN = False
                End If
                If TXT_略称.Text.Equals("") Then
                    D_ERR.FNC_ERR_ADD(TXT_略称, C_MSG_MST_INP, GcStylePlus1)
                    '
                    STT_Msg.Text = "" : D_RTN = False
                End If
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
    Private Function FNC_CMD_EXC() As Boolean
        '
        Dim I As Integer = 0
        Dim D_RTN As Boolean = False
        '
        Try
            If Not FNC_SCR_CHK() Then
                STT_Msg.Visible = True : D_ERR.FNC_SHW_ERR(Me, C_MSG_ERR_TTL) : GoTo EXIT_FUNCTION
            End If
            '
            If D_MOD.Equals("D") Then
                If MsgBoxResult.No = MsgBox(C_MSG_DEL_APT, MsgBoxStyle.Question + MsgBoxStyle.YesNo + MsgBoxStyle.DefaultButton2, "確認") Then
                    GoTo EXIT_FUNCTION
                End If
            End If
            '
            D_SQL = "SPC_M002_ACT1 " & "'" & D_MOD & "'," & FNC_UPD_USR() & "," & C_COM_COD & "," & FNC_SQL_VAL(TXT_業務分類区分) & "," & FNC_SQL_VAL(TXT_名称) & "," & FNC_SQL_VAL(TXT_略称)
            '
            P_EXC_TBL = FNC_GET_TBL(D_SQL)

            If P_EXC_TBL.Rows.Count <> 0 Then
                D_ERR.FNC_FID_INT()
                '
                For I = 0 To P_EXC_TBL.Rows.Count - 1 Step 1
                    Select Case P_EXC_TBL.Rows(I).Item("ERR_ID")
                        Case "9999" : D_ERR.FNC_ERR_ADD(TXT_業務分類区分, P_EXC_TBL.Rows(I).Item("内容"), GcStylePlus1)
                        Case "1" : D_ERR.FNC_ERR_ADD(TXT_業務分類区分, P_EXC_TBL.Rows(I).Item("内容"), GcStylePlus1)
                        Case "2" : D_ERR.FNC_ERR_ADD(TXT_業務分類区分, P_EXC_TBL.Rows(I).Item("内容"), GcStylePlus1)
                        Case "1001" : D_ERR.FNC_ERR_ADD(TXT_業務分類区分, P_EXC_TBL.Rows(I).Item("内容"), GcStylePlus1)
                    End Select
                Next
                '
                STT_Msg.Visible = True : D_ERR.FNC_SHW_ERR(Me, C_MSG_ERR_TTL) : GoTo EXIT_FUNCTION
            Else
                '正常終了
                If D_MOD.Equals("A") Then
                    FNC_SCR_INT() : D_KEY(0) = ""
                    '
                ElseIf D_MOD.Equals("U") Then
                    FNC_DSP_DEL(1, STT_Status, CTL_UPD)
                    '
                ElseIf D_MOD.Equals("D") Then
                    FNC_DSP_DEL(2, STT_Status, CTL_UPD)
                    FNC_DEL_IFO(CTL_UPD)
                End If
                '
                MsgBox(C_MSG_CMD_CPT, MsgBoxStyle.Information, "確認")
                '
                STT_Msg.Text = C_MSG_CMD_CPT : TXT_業務分類区分.Focus() : D_RTN = True
            End If

        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            P_EXC_TBL.Clear()
        End Try
EXIT_FUNCTION:
        FNC_CMD_EXC = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：出力
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_DSP_RPT()
        '
        Dim D_RTN As String = ""
        '
        Try
            If FNC_GET_UES_LVL(Me, D_RTN) Then
                Dim NewMDIChild As New frm_M002_rpt(Me, D_RTN, D_Main)
                '
                NewMDIChild.MdiParent = D_Main
                NewMDIChild.Show()
                NewMDIChild = Nothing
            End If
            '
            'Dim D_FRM As frm_M002_rpt = New frm_M002_rpt
            ''
            'D_FRM.ShowDialog(Me)
            'D_FRM = Nothing
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：検索
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_DSP_FND()
        '
        Try
            D_SQL = "SPC_M002_FND1 1,"
            '
            Dim NewMDIChild As New frm_M002_fnd(0, D_SQL, True, "", "", "", P_USR, Me)
            '
            'Me.Hide()
            '
            NewMDIChild.MdiParent = D_Main
            NewMDIChild.Show()
            NewMDIChild = Nothing
            '
            ''
            'Dim f As New frm_M002_fnd(0, D_SQL, True, "", "", "", P_USR, Me)
            ''
            ''TopLevelをFalseにする
            ''
            'f.TopLevel = False
            'f.FormBorderStyle = FormBorderStyle.None
            ''フォームのコントロールに追加する
            'Me.Controls.Add(f)
            ''フォームを表示する
            'f.Show()
            ''最前面へ移動
            'f.BringToFront()
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
                Case "TXT_業務分類区分"
                    FNC_DSP_FND() : GoTo EXIT_FUNCTION
                    '
                Case Else
                    STT_Msg.Text = C_MSG_NOT_LST : If Not STT_Msg.Visible Then STT_Msg.Visible = True
                    '
                    GoTo EXIT_FUNCTION
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
                Case 0
                    TXT_業務分類区分.Text = FNC_CNV_NUL(P2.Rows(P3).Item("業務分類区分"), 0)
                    TXT_XID.Text = FNC_CNV_NUL(P2.Rows(P3).Item("XID"), 0)
                    '
                    D_KEY(0) = ""
                    FNC_KEY_REF()
            End Select
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾃﾞｰﾀｾｯﾄ
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_SET_DAT(ByRef P1 As DataTable, ByVal P2 As Integer)
        '
        Dim D_STR As String = ""
        '
        Try
            If IsNothing(P1) Then GoTo EXIT_FUNCTION
            '
            If P1.Rows.Count <> 0 Then
                TXT_業務分類区分.Text = FNC_CNV_NUL(P1.Rows(P2).Item("業務分類区分"), 0)
                TXT_名称.Text = FNC_CNV_NUL(P1.Rows(P2).Item("名称"), "")
                TXT_略称.Text = FNC_CNV_NUL(P1.Rows(P2).Item("略称"), "")
                '
                FNC_SET_IFO(CTL_UPD, P1, P2)
                FNC_DSP_DEL(CInt(FNC_CNV_NUL(P1.Rows(P2).Item("削除区分"), 0)), STT_Status, CTL_UPD)
                '
                P1.Clear()
                '
                '参照値取得
                '
                D_KEY(0) = TXT_業務分類区分.Text
            Else
                D_KEY(0) = TXT_業務分類区分.Text
                '
                FNC_SCR_INT()
                '
                TXT_業務分類区分.Text = D_KEY(0)
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            '
        End Try
        '
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：Key参照
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_KEY_REF()
        '
        Try
            If Not (D_KEY(0).Equals(TXT_業務分類区分.Text)) Then
                D_KEY(0) = TXT_業務分類区分.Text

                D_SQL = "SPC_M002_INQ1 1," & C_COM_COD & "," & FNC_SQL_VAL(TXT_業務分類区分)
                '
                D_TBL = FNC_GET_TBL(D_SQL)
                '
                FNC_SET_DAT(D_TBL, 0)
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            If Not D_TBL Is Nothing Then D_TBL.Clear()
        End Try
        '
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：Move参照
    '*
    '*  引数　　：1.方向(F.先頭 , P.前 , N.次 , L.末尾)
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_MOV_REF(ByVal P1 As String)
        '
        Try
            If IsNothing(P_FND_TBL) OrElse P_FND_TBL.Rows.Count = 0 Then
                D_SQL = "SPC_M002_MOV1 " & "'" & P1 & "'," & C_COM_COD & "," & FNC_SQL_VAL(TXT_業務分類区分)
                '
                D_TBL = FNC_GET_TBL(D_SQL)
                '
                FNC_SET_DAT(D_TBL, 0)
                '
                'XID表示
                '
                TXT_XID.Text = 0
            Else
                TXT_業務分類区分.Text = FNC_CNV_NUL(CLng(FNC_FND_XID(P1, P_FND_IDX, 1, "業務分類区分")), 0)
                '
                'XID表示
                TXT_XID.Text = FNC_CNV_NUL(P_XID_FROM + P_FND_IDX, 0)
                '
                FNC_KEY_REF()
            End If
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
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
            D_ERR.FNC_ERR_INT() : FNC_DPS_TBL(D_TBL)
            '
            'XID関連
            '
            FNC_DPS_TBL(P_FND_TBL)
            '
            P_FND_IDX = 0
            '
            FNC_DLT_PRM(1, Me.Name & "_frm_M002_fnd")
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
            FNC_SET_MOD("A")
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
            FNC_SET_MOD("U")
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
            FNC_SET_MOD("D")
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
    '
    Private Sub FNC_F05()
        '
        Try
            FNC_MOV_REF("F")
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
            FNC_MOV_REF("P")
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
            FNC_MOV_REF("N")
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
            FNC_MOV_REF("L")
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
            FNC_DSP_RPT()
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
            FNC_DSP_FND()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '
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
            Me.Dispose()
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
            '
            FNC_History(Me, P_USR, System.Reflection.MethodBase.GetCurrentMethod().ToString, "", "")
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub frm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        '
        Try
            FNC_History(Me, P_USR, System.Reflection.MethodBase.GetCurrentMethod().ToString, "", "")
            '
            FNC_PRG_END()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub FNC_KEY_FunctionKeyPress(sender As Object, e As FunctionKeyPressEventArgs) Handles FNC_KEY.FunctionKeyPress
        '
        Try
            'ﾎﾞﾀﾝを押し続けている間の繰り返し処理
            '
            Select Case e.Key
                Case ButtonKeys.F6, ButtonKeys.F7
                    FNC_KEY.KeyRepeat = True
                Case Else
                    FNC_KEY.KeyRepeat = False
            End Select
            '
            Select Case e.Key
                Case ButtonKeys.F1 : FNC_F01()
                Case ButtonKeys.F2 : FNC_F02()
                Case ButtonKeys.F3 : FNC_F03()
                Case ButtonKeys.F4 : FNC_F04()
                Case ButtonKeys.F5 : FNC_F05()
                Case ButtonKeys.F6 : FNC_F06()
                Case ButtonKeys.F7 : FNC_F07()
                Case ButtonKeys.F8 : FNC_F08()
                Case ButtonKeys.F9 : FNC_F09()
                Case ButtonKeys.F10 : FNC_F10()
                Case ButtonKeys.F11 : FNC_F11()
                Case ButtonKeys.F12 : FNC_F12()
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
                D_ERR.FNC_SHW_ERR(Me, "下記項目の入力値を見直してください")
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub TXT_業務分類区分_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TXT_業務分類区分.Leave
        '
        Try
            If Not (D_KEY(0).Equals(TXT_業務分類区分.Text)) Then
                '
                'XID関連
                '
                FNC_DPS_TBL(P_FND_TBL)
                '
                P_FND_IDX = 0 : TXT_XID.Text = 0
            End If
            '
            FNC_KEY_REF()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
    End Sub

#Region "■不要なため削除■"

    'Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '    Try
    '        '座標設定
    '        If Not Me.Location.Equals(utl_Com.P_FRM_LCN) Then Me.Location = utl_Com.P_FRM_LCN
    '    Catch ex As Exception
    '        FNC_ERR_RTN(ex)
    '    End Try
    'End Sub

    'Private Sub Frm_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LocationChanged
    '    Try
    '        '座標格納
    '        If Not IsNothing(Me.ActiveControl) Then utl_Com.P_FRM_LCN = Me.Location()
    '    Catch ex As Exception
    '        FNC_ERR_RTN(ex)
    '    End Try
    'End Sub

    'Protected Overrides Function ProcessKeyPreview(ByRef m As System.Windows.Forms.Message) As Boolean
    '    Try
    '        Dim D_OPS As System.OperatingSystem = System.Environment.OSVersion

    '        If D_OPS.Platform >= PlatformID.Win32NT AndAlso
    '            D_OPS.Version.Major >= 6 AndAlso
    '            D_OPS.Version.Minor >= 0 AndAlso
    '            m.LParam.ToInt32 = 4456449 AndAlso
    '            CType(m.WParam.ToString, Keys) = Keys.F10 Then
    '            '
    '            'F10が押下された時の処理
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