Imports System.Windows.Forms
Imports GrapeCity.Win.Bars
Imports cns_Com.cns_Com
Imports utl_Com.utl_Com
Imports utl_Rdb.utl_Rdb
'機能概要*****************************************************************************************************
'*
'*  処理概要：業務分類ﾏｽﾀ検索
'*
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*
'*  更新日　：
'*  更新者　：
'*  更新内容：
'*
#Region " 旧履歴 "

'*
'*  作成日　：2005/09/13
'*  作成者　：ANS佐藤太希
'*
'*  更新者　：ANS和泉慶子
'*  更新内容：2006/04/27 Form位置調整処理追加
'*            2006/05/15 削除区分追加
'*            2006/09/15 ﾘｽﾄﾋﾞｭｰ幅保存を検索時追加
'*            2006/10/08 機能大幅追加
'*
'*  更新者　：軽部
'*  更新日　：2007/08/30
'*  更新内容：Windows Vista上でF10が効かない現象の対応
'*
'*  更新者　：軽部
'*  更新日　：2008/05/21
'*  更新内容：検索条件に登録/更新情報を追加
'*
'*  更新者　：ANS 永瀬
'*  更新日　：2008/07/14
'*  更新内容：ファンクションキー表示調整
'*
'*  更新者　：山田
'*  更新日　：2008/08/08
'*  更新内容：事業部コード⇒業務分類区分に変更

#End Region
'*
'*************************************************************************************************************
Public Class frm_M002_fnd

#Region "■ItemCode■"

    '*********************************************************************************************************
    '*  ﾒﾝﾊﾞ変数
    '*********************************************************************************************************
    Private D_SQL As String
    Private D_IDX As Integer
    Private D_SPC As String
    Private D_XID As Long = 0
    Private D_AUT As Boolean = False
    Private D_OBJ As Boolean = False
    Private D_ERR As New utl_Err.utl_ERR
    Private D_LST_TBL As New DataTable
    Private D_FND_IDX As Integer
    Private D_OWN_FRM As Form
    '
    Private D_事業所コード As String = ""
    Private D_業務分類区分 As String = ""
    Private D_削除区分 As String = ""

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
    Public Sub New(ByVal P1 As Integer, ByVal P2 As String, ByVal P3 As Boolean, Optional ByVal P4 As String = "", Optional ByVal P5 As String = "", Optional ByVal P6 As String = "", Optional ByVal P7 As UserInfo = Nothing, Optional ByVal P8 As Form = Nothing)
        MyBase.New()
        '
        InitializeComponent()
        '
        Try
            D_IDX = P1
            D_SPC = P2
            D_AUT = P3
            '
            D_業務分類区分 = P4
            D_削除区分 = P5
            D_事業所コード = P6
            '
            P_USR = P7
            D_OWN_FRM = P8
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
            FNC_SET_ICO(Me)
            FNC_FRM_CLR(Me)
            FNC_USR_SET(P_USR)
            FNC_SET_IFO(P_USR, CTL_USR_IFO1)
            '
            FNC_SCR_INT()
            FNC_LOD_PRM(Me, 1, D_OWN_FRM.Name & "_" & Name)
            '
            '登録/更新情報初期化
            TXT_登録ユーザーID_FROM.Text = "0"
            TXT_登録ユーザーID_TO.Text = "9999999"
            TXT_登録日_FROM.Value = Nothing
            TXT_登録日_TO.Value = Nothing
            '
            TXT_更新ユーザーID_FROM.Text = "0"
            TXT_更新ユーザーID_TO.Text = "9999999"
            TXT_更新日_FROM.Value = Nothing
            TXT_更新日_TO.Value = Nothing
            '
            '呼出元ﾌｫｰﾑ検査
            If D_OWN_FRM.Name.Equals("frm_M002_ins") Then
                D_OBJ = True
                If (Not IsNothing(P_FND_TBL) AndAlso P_FND_TBL.Rows.Count <> 0) Then
                    D_LST_TBL = P_FND_TBL
                    D_FND_IDX = P_FND_IDX
                End If
            End If
            '
            If (IsNothing(D_LST_TBL) OrElse D_LST_TBL.Rows.Count = 0) Then
                'ｵｰﾄ検索
                If D_AUT Then FNC_CMD_EXC("")
            Else
                FNC_LST_SET()
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
            'メッセージ通達の初期化
            '
            STT_Msg.Visible = False : STT_Msg.Text = ""
            '
            FNC_TXT_CLR(Me)
            '
            TXT_業務分類区分_FROM.Text = "0"
            TXT_業務分類区分_TO.Text = "99"
            TXT_名称.Text = ""
            '
            '登録/更新情報初期化
            '
            TXT_登録ユーザーID_FROM.Text = "0"
            TXT_登録ユーザーID_TO.Text = "9999999"
            TXT_登録日_FROM.Value = Nothing
            TXT_登録日_TO.Value = Nothing
            '
            TXT_更新ユーザーID_FROM.Text = "0"
            TXT_更新ユーザーID_TO.Text = "9999999"
            TXT_更新日_FROM.Value = Nothing
            TXT_更新日_TO.Value = Nothing
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：画面初期化(XID関連)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_SCR_XID()
        '
        Try
            If D_OBJ Then
                D_XID = 0
                P_FND_TBL.Clear()
                P_FND_IDX = 0
                P_XID_FROM = 0
                P_XID_TO = 0
                '
                D_LST_TBL.Clear()
                '
                D_FND_IDX = 0
            End If
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
            STT_Msg.Visible = False
            '
            D_ERR.FNC_FID_INT()
            '
            If TXT_業務分類区分_FROM.Text.Equals("") Then
                TXT_業務分類区分_FROM.Text = "0"
            End If
            If TXT_業務分類区分_TO.Text.Equals("") Then
                TXT_業務分類区分_TO.Text = "99"
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_SCR_CHK = D_RTN
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：実行
    '*
    '*  引数　　：1.MOVEモード
    '*
    '*  戻り値　：True.正常 , False.異常
    '*
    '*********************************************************************************************************
    Private Function FNC_CMD_EXC(ByVal P1 As String) As Boolean
        '
        Dim I As Integer = 0
        Dim D_RTN As Boolean = False
        '
        Try
            FNC_SCR_CHK()
            '
            LBL_LST_MSG.ForeColor = C_LST_GET_CLR
            LBL_LST_MSG.Text = C_MSG_SRC_WIT
            '
            P_FRM_WIT.FNC_SET_MSG(C_MSG_FND_DAT)
            P_FRM_WIT.show()
            '
            'XID参照
            '
            Select Case P1
                Case "F" : D_XID = P_XID_FROM '【前】
                Case "L" : D_XID = P_XID_TO   '【次】
                Case Else : D_XID = 0
            End Select
            '
            D_SQL = D_SPC & "'" &
                    P1 & "'," &
                    D_XID & "," &
                    IIf(D_事業所コード.Equals(""), C_COM_COD, D_事業所コード) & "," &
                    IIf(D_事業所コード.Equals(""), C_COM_COD, D_事業所コード) & "," &
                    FNC_SQL_VAL(TXT_業務分類区分_FROM) & "," &
                    FNC_SQL_VAL(TXT_業務分類区分_TO) & "," &
                    FNC_SQL_VAL(TXT_名称)
            '
            If Not D_削除区分.Equals("") Then
                D_SQL = D_SQL & "," & D_削除区分
            Else
                D_SQL = D_SQL & ",9"
            End If
            '
            D_SQL = D_SQL & "," &
                    FNC_SQL_VAL(TXT_登録ユーザーID_FROM) & "," &
                    FNC_SQL_VAL(TXT_登録ユーザーID_TO) & "," &
                    FNC_SQL_VAL(TXT_登録日_FROM) & "," &
                    FNC_SQL_VAL(TXT_登録日_TO) & "," &
                    FNC_SQL_VAL(TXT_更新ユーザーID_FROM) & "," &
                    FNC_SQL_VAL(TXT_更新ユーザーID_TO) & "," &
                    FNC_SQL_VAL(TXT_更新日_FROM) & "," &
                    FNC_SQL_VAL(TXT_更新日_TO)
            '
            If D_OBJ Then
                'INDEX初期化
                '
                D_FND_IDX = 0
                '
                P_FND_TBL = FNC_GET_TBL(D_SQL)
                D_LST_TBL = P_FND_TBL
            Else
                'INDEX初期化
                '
                D_FND_IDX = 0
                '
                D_LST_TBL = FNC_GET_TBL(D_SQL)
            End If
            '
            If D_LST_TBL.Rows.Count <> 0 Then
                FNC_SAV_LST(LST_Viw, D_OWN_FRM.Name & "_" & Name)
                FNC_LST_SET()
            Else
                FNC_LST_NOT()
                TXT_業務分類区分_FROM.Focus()
            End If

        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            P_FRM_WIT.Hide()
        End Try
EXIT_FUNCTION:
        FNC_CMD_EXC = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾘｽﾄｾｯﾄ
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_LST_SET()
        '
        Try
            '表示設定
            '
            FNC_KEY.KeySets(0).Item(8).Enabled = True
            '
            LBL_LST_MSG.ForeColor = C_LST_GET_CLR
            '
            'ﾘｽﾄ設定
            '
            FNC_CNF_LST(D_LST_TBL, LST_Viw, "###0", "#,##0", "yyyy/MM/dd")
            FNC_LOD_LST(LST_Viw, D_OWN_FRM.Name & "_" & Name)
            '
            LBL_LST_MSG.Text = FNC_FCS_XID(LST_Viw, D_LST_TBL, D_FND_IDX)
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾘｽﾄｸﾘｱ
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_LST_CLR()
        '
        Try
            '表示設定
            '
            FNC_KEY.KeySets(0).Item(8).Enabled = False
            '
            LBL_LST_MSG.ForeColor = C_LST_NTL_CLR
            LBL_LST_MSG.Text = C_MSG_SRC_NUT
            '
            'ﾘｽﾄ設定
            FNC_SAV_LST(LST_Viw, D_OWN_FRM.Name & "_" & Name)
            '
            'LST_Viw.Rows.Clear()
            LST_Viw.DataSource = Nothing
            '
            'XID関連ｸﾘｱ
            FNC_SCR_XID()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾘｽﾄなし
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_LST_NOT()
        Try
            '表示設定
            '
            FNC_KEY.KeySets(0).Item(8).Enabled = False
            '
            LBL_LST_MSG.ForeColor = C_LST_NOT_CLR
            LBL_LST_MSG.Text = C_MSG_SRC_NOT
            '
            'ﾘｽﾄ設定
            '
            LST_Viw.Rows.Clear()
            '
            D_LST_TBL.Clear()
            '
            'XID関連ｸﾘｱ
            '
            FNC_SCR_XID()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾘｽﾄ送信
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_LST_RTN()
        '
        Try
            If Not IsNothing(LST_Viw.SelectedRows) Then
                If LST_Viw.CurrentCell Is Nothing Then LST_Viw.CurrentCell = LST_Viw.FirstDisplayedCell
                '
                If D_OBJ Then
                    P_FND_IDX = LST_Viw.CurrentCell.RowIndex
                    D_FND_IDX = P_FND_IDX
                Else
                    D_FND_IDX = LST_Viw.CurrentCell.RowIndex
                End If
                '
                CType(D_OWN_FRM, Object).FNC_RCV_LST(D_IDX, D_LST_TBL, D_FND_IDX)
                '
                Call FNC_PRG_END()
            End If
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
            FNC_SAV_LST(LST_Viw, D_OWN_FRM.Name & "_" & Name)
            FNC_SAV_PRM(Me, 1, D_OWN_FRM.Name & "_" & Name)
            '
            D_ERR.FNC_ERR_INT()
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
                TXT_業務分類区分_FROM.Focus()
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
            '
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
            FNC_LST_CLR()
            '
            'XID関連ｸﾘｱ
            '
            FNC_SCR_XID()
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
            '
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
            FNC_CMD_EXC("F")
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
            FNC_STP_XID("P", LST_Viw, D_LST_TBL, D_FND_IDX, TXT_業務分類区分_FROM)
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
            FNC_STP_XID("N", LST_Viw, D_LST_TBL, D_FND_IDX, TXT_業務分類区分_FROM)
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
        Try
            FNC_CMD_EXC("L")
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
            FNC_LST_RTN()
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
            'XID関連ｸﾘｱ
            '
            FNC_SCR_XID()
            '
            FNC_CMD_EXC("")
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
        Try
            If D_OBJ Then
                P_FND_IDX = -1
            End If
            '
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

    Private Sub frm_M002_fnd_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
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

    Private Sub frm_M003_fnd_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
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
            '
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

    Private Sub LST_VIW_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LST_Viw.KeyDown
        '
        Try
            If e.KeyCode = Keys.Enter Then
                FNC_LST_RTN()
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub LST_VIW_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles LST_Viw.DoubleClick
        '
        Try
            FNC_LST_RTN()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

#Region "■不要なため削除■"

    'Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
    '    '
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