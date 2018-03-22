Imports System.Windows.Forms
Imports utl_Com.utl_Com
Imports utl_Rdb.utl_Rdb
Imports cns_Com.cns_Com
'機能概要*****************************************************************************************************
'*
'*  処理概要：共通参照
'*
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*
'*           <残>
'*
'*
'*  更新日　：
'*  更新者　：
'*  更新内容：
'*
#Region " 旧履歴 "

'*  処理概要：共通参照
'*
'*  作成日　：2005/04/25
'*  作成者　：Ans赤沢(博)
'*
'*  更新日　：
'*  更新者　：

#End Region
'*
'*
'*************************************************************************************************************
Public Class frm_List

#Region "■ItemCode■"

    '*********************************************************************************************************
    '*  ﾒﾝﾊﾞ変数
    '*********************************************************************************************************
    Private D_SQL As String
    Private D_TBL As New DataTable
    Private D_ONR As Object
    Private D_IDX As Integer
    Private D_CLT_NAM As String

#End Region

#Region "■ProcessingCode■"

    '*********************************************************************************************************
    '*
    '*  処理概要：ｺﾝｽﾄﾗｸﾀ
    '*
    '*  引数　　：1.参照ｲﾝﾃﾞｯｸｽ
    '*            2.呼出ﾌｫｰﾑ
    '*            3.ｸｴﾘ
    '*            4.対象ｺﾝﾄﾛｰﾙ名
    '*
    '*            ｵﾌﾟｼｮﾝ1.参照名
    '*            ｵﾌﾟｼｮﾝ2.横幅増ﾋﾟｸｾﾙ数
    '*            ｵﾌﾟｼｮﾝ3.縦幅増ﾋﾟｸｾﾙ数
    '*
    '*********************************************************************************************************
    Public Sub New(ByVal P1 As Integer, ByRef P2 As System.Windows.Forms.Form, ByVal P3 As String, ByVal P4 As String,
                   Optional ByVal OP1 As String = "一覧",
                   Optional ByVal OP2 As Integer = 0,
                   Optional ByVal OP3 As Integer = 0)
        MyBase.New()

        ' この呼び出しは Windows フォーム デザイナで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後に初期化を追加します。
        Try
            D_IDX = P1
            D_ONR = P2
            D_SQL = P3
            D_CLT_NAM = P4
            Text = OP1
            '
            'ｻｲｽﾞ拡張ｵﾌﾟｼｮﾝ設定
            If OP2 <> 0 OrElse OP3 <> 0 Then
                Size = New System.Drawing.Size((Size.Width + OP2), (Size.Height + OP3))
                LST_VIW.Size = New System.Drawing.Size((LST_VIW.Size.Width + OP2), (LST_VIW.Size.Height + OP3))
                LBL_LST_MSG.Size = New System.Drawing.Size((LBL_LST_MSG.Size.Width + OP2), LBL_LST_MSG.Size.Height)
                LBL_END.Location = New System.Drawing.Point((LBL_END.Location.X + OP2), (LBL_END.Location.Y + OP3))
            End If

        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
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

        Try
            FNC_FRM_CLR(Me)
            '
            FNC_SCR_INT()
            FNC_CMD_EXC()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
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
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

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
        Dim D_RTN As Boolean = False
        '
        Try
            LBL_LST_MSG.ForeColor = C_LST_GET_CLR
            LBL_LST_MSG.Text = C_MSG_SRC_WIT
            '
            'Application.DoEvents()
            '
            D_TBL = FNC_GET_TBL(D_SQL)
            '
            If D_TBL.Rows.Count <> 0 Then
                FNC_LST_SET()
            Else
                FNC_LST_NOT()
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
        '
EXIT_FUNTION:
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
            LBL_LST_MSG.ForeColor = C_LST_GET_CLR
            LBL_LST_MSG.Text = C_MSG_SRC_RST & CStr(D_TBL.Rows.Count)
            '
            FNC_CNF_LST(D_TBL, LST_VIW, "###0", "#,##0", "yyyy/MM/dd")
            FNC_LOD_LST(LST_VIW, Name & "_" & D_ONR.Name & "_" & D_CLT_NAM)
            '
            'XID幅0[固定]
            If LST_VIW.Columns(1).Text.Equals("XID") Then
                LST_VIW.Columns(1).Width = 0
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾘｽﾄなし
    '*
    '*  引数　　：1.ﾒｯｾｰｼﾞ
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_LST_NOT()
        '
        Try
            LBL_LST_MSG.ForeColor = C_LST_NOT_CLR
            LBL_LST_MSG.Text = C_MSG_SRC_NOT
            '
            D_TBL.Clear()
            LST_VIW.Clear()
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾘｽﾄ選択
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_LST_RTN()
        '
        Try
            If Not IsNothing(LST_VIW.FocusedItem) Then
                D_ONR.FNC_RCV_LST(D_IDX, D_TBL, LST_VIW.FocusedItem.Index)
                Me.Close()
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
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
            FNC_DPS_TBL(D_TBL)
            FNC_SAV_LST(LST_VIW, Name & "_" & D_ONR.Name & "_" & D_CLT_NAM)
            '
            Me.Dispose()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

#End Region

#Region "■EventCode■"

    Private Sub Frm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        Try
            FNC_PRG_INT()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub Frm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        '
        Try
            FNC_PRG_END()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

    Private Sub Frm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        '
        Try
            Select Case e.KeyCode
                Case Keys.F12, Keys.Escape
                    Me.Close()
            End Select
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub LST_VIW_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
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

    Private Sub LST_VIW_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            FNC_LST_RTN()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

#End Region

End Class