Imports System.Windows.Forms
Imports utl_Com.utl_Com
Imports utl_Rdb.utl_Rdb

Public Class frm_Main
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        '
        Dim D_RTN As String = ""
        '
        Try
            Dim NewMDIChild As New frm_M003.frm_M003_ins(D_RTN, Me)

            If FNC_GET_UES_LVL(NewMDIChild, D_RTN) Then
                '
                NewMDIChild.MdiParent = Me

                NewMDIChild.Show()
                NewMDIChild = Nothing
                '
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FNC_WIN_SIZ()
        '
        C_COM_COD = 1     '事業所コード
        C_USR_IDS = 888   'ユーザID
        '
        Call FNC_RDB_CON()
        Call SUB_SET_USR()
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ウィンドウ一覧表示への追加
    '*
    '*  引数　　：1.オーナーフォーム
    '*　　　　　　2.メインフォーム
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Sub FNC_WIN_ADD(ByRef P1 As Form, ByRef P2 As Form)
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
    '*  処理概要：ウィンドウ一覧表示からの除去
    '*
    '*  引数　　：1.オーナーフォーム
    '*　　　　　　2.メインフォーム
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Sub FNC_WIN_DEL(ByRef P1 As Form, ByRef P2 As Form)
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
    '*  処理概要：認証結果/ﾕｰｻﾞｰ情報取得
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：True.許可 , False.不可
    '*
    '*********************************************************************************************************
    Public Shared Sub SUB_SET_USR()
        '
        Dim D_SQL As String
        '
        Try
            '認証処理
            D_SQL = "SPC_SYS_USR_CHK " & C_COM_COD & "," & C_USR_IDS & ",'" & "ans1977kst" & "'"
            '
            Call FNC_SET_USR(FNC_GET_DAT(D_SQL))
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
        '
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：認証結果/ﾕｰｻﾞｰ情報取得
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：True.許可 , False.不可
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SET_USR(ByVal P1 As DataSet) As Boolean
        '
        Dim D_RTN As Boolean = False
        '
        Try
            If P1.Tables.Count > 0 Then
                If P1.Tables(0).Rows.Count = 0 Then
                    MsgBox("認証に失敗しました", MsgBoxStyle.Critical)
                    GoTo EXIT_FUNCTION
                Else
                    D_RTN = True
                    C_USR_PMN = True
                    '
                    '処理事業所情報取得
                    C_COM_COD = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("事業所コード"), 0)
                    C_COM_NAM = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("事業所名"), "")
                    C_COM_NAM_SRT = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("事業所名略称"), "")
                    C_ACC_POD = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("決算期"), 0)
                    'ﾕｰｻﾞｰ属性取得
                    C_USR_IDS = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("ユーザーID"), 0)
                    C_USR_NAM = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("ユーザー名"), "")
                    C_USR_NAM_SRT = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("ユーザー名略称"), "")
                    C_PRT_COD = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("部コード"), 0)
                    C_PRT_NAM = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("部名"), "")
                    C_BNC_COD = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("支社コード"), 0)
                    C_BNC_NAM = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("支社名"), "")
                    C_BNC_NAM_SRT = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("支社名略称"), "")
                    'C_EMP_COD = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("社員コード"), 0)
                    'C_EMP_NAM = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("社員名"), "")
                    C_USR_DIV = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("ユーザー区分"), 0)
                    C_USR_DIV_NAM = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("ユーザー区分名"), "")
                    C_USE_PRT_COD = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("運用部署区分"), 0)
                    C_USE_PRT_NAM = FNC_CNV_NUL(P1.Tables(0).Rows(0).Item("運用部署区分名"), "")
                    '端末属性取得
                    C_TMA_IPS = FNC_GET_IPS()
                    C_TMA_NAM = FNC_GET_NAM()
                    '
                    'ﾒﾆｭｰ情報取得
                    If P1.Tables.Count > 1 Then
                        If P1.Tables(1).Rows.Count > 0 Then
                            P_MNU_TBL = P1.Tables(1)
                        End If
                    End If
                    '機能別ﾕｰｻﾞｰ権限情報取得
                    If P1.Tables.Count > 2 Then
                        If P1.Tables(2).Rows.Count > 0 Then
                            P_LVL_TBL = P1.Tables(2)
                        End If
                    End If
                End If
            Else
            End If
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            P1.Tables.Clear()
            P1 = Nothing
        End Try
        '
EXIT_FUNCTION:
        FNC_SET_USR = D_RTN
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：画面最大化
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Sub FNC_WIN_SIZ()
        '
        Try
            Me.StartPosition = FormStartPosition.Manual
            Me.Size = New Size(1700, 980)
            Me.WindowState = FormWindowState.Normal
        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub
End Class
