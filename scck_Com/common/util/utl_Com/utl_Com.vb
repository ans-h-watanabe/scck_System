Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing
Imports cns_Com.cns_Com

'機能概要*****************************************************************************************************
'*
'*  処理概要：共通関数
'*
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*
'*  更新日　：
'*  更新者　：
'*  更新内容：
'*
'*           <残>
'*                FNC_TXT_VIS -> ElTabelle対応
'*                FNC_ERR_LOG -> WEBｻｰﾋﾞｽのｴﾗｰ処理
'*                FNC_WEB_URL -> WEBｻｰﾋﾞｽのTimeout参照
'*
#Region " 旧履歴 "

'*  作成日　：2005/04/20
'*  作成者　：Ans赤沢(博)
'*
'*  更新日　：2007/04/10
'*  更新者　：ANS落合 新規関数 FNC_IMG_DSP, FNC_IMG_CLR, FNC_IMG_REF, FNC_IMG_DLDを追記
'*  更新日　：2007/06/08
'*  更新者　：ANS永瀬 Dateタイプの値の対応で修正 FNC_SAV_PRM,FNC_SQL_VAL
'*
'*  更新日　：2007/08/17
'*  更新者　：軽部
'*  更新内容：ThreadAbortExceptionを呼出元へThrowするように変更
'*
'*  更新日　：2007/11/06
'*  更新者　：ANS　永瀬
'*  更新内容：SAV_PRMで日付値がNOTHINGの時の処理を追加
'*
'*  更新日　：2008/05/01
'*  更新者　：ANS野木
'*  更新内容：LOD_PRMで読み込んだ日付値と入れる先のフォーマットが違う場合のエラーを回避する処理を追加
'*            StreamのcloseとnothingをFinallyで行うように修正
'*
'*  更新日　：2008/05/02
'*  更新者　：ANS高木
'*  更新内容：SAV_PRMで日付に入力途中の値が残っていた場合の処理を追加
'*
'*  更新日　：2008/05/13
'*  更新者　：ANS　永瀬
'*  更新内容：LOD_PRMの日付値変換の不具合修正
'*
'*  更新日　：2008/05/13
'*  更新者　：軽部
'*  更新内容：FNC_FNB_FILのStreamの扱い方を訂正
'*
'*  更新日　：2009/01/15
'*  更新者　：村上
'*  更新内容：印鑑ファイル関連作成[C_PCT_FIL(5), FNC_PCT_INT]
'*
'*  更新日　：2009/03/17
'*  更新者　：赤澤
'*  更新内容：XID調整(3000件対応)  FNC_FCS_XID_BIG 追加
'*
'*  更新日　：2009/04/28
'*  更新者　：村上
'*  更新内容：FNC_TXT_CLRのLabelに"&(半角＆)"が表示されない点を修正
'*
'*  更新日　：2009/06/04
'*  更新者　：村上
'*  更新内容：FNC_SQL_VALでTEXTBOXの【‐[全]ハイフン】を【－[全]マイナス】に置き換える
'*
'*  更新日　：2009/06/05
'*  更新者　：村上
'*  更新内容：FNC_BYT_DATで【‐[全]ハイフン】を【－[全]マイナス】に置き換える
'*
'*  更新日　：2009/07/28
'*  更新者　：村上
'*  更新内容：印鑑ファイル設定にﾄﾗｽﾄ分を追加[FNC_PCT_INT]
'*
'*  更新日　：2009/07/29
'*  更新者　：村上
'*  更新内容：ﾄﾗｽﾄ用を追加[FNC_ICO_INT,FNC_FRM_CLR,FNC_FNB_FIL]
'*
'*  更新者　：村上
'*  更新日　：2010/01/22
'*  更新内容：事業所コード変更対応[FNC_FRM_CLR,FNC_FNB_FIL]
'*
'*  更新者　：村上
'*  更新日　：2010/05/11
'*  更新内容：FNC_IMG_DSPでD_FIL_STM.Writeを修正
'*
'*  更新者　：ANS野木
'*  更新日　：2010/06/03
'*  更新内容：FNC_GET_UES_LVLに例外処理を追加
'*
'*  更新者　：村上
'*  更新日　：2010/08/17
'*  更新内容：FNC_GET_UES_LVLに例外処理を追加
'*
'*  更新者　：村上
'*  更新日　：2017/09/01
'*  更新内容：FNC_SAV_PRMでTextboxの改行を削除するように修正
'*
'*  更新者　：渡辺
'*  更新日　：2017/11/06
'*  更新内容：ﾒﾝﾃｯｸ､ｱｸｱ用の画面背景色を追加

#End Region
'*
'*************************************************************************************************************
Public Class utl_Com
    '*********************************************************************************************************
    '*  ﾒﾝﾊﾞ変数
    '*********************************************************************************************************
    Public Shared P_MNU As Form
    Public Shared P_FRM_LCN As System.Drawing.Point
    Public Shared P_EXC_TBL As New DataTable
    Public Shared P_EXC_DAT As New DataSet
    Public Shared P_MNU_TBL As New DataTable     'ﾒﾆｭｰ情報
    Public Shared P_LVL_TBL As New DataTable     '機能別運用権限情報
    Public Shared P_USE_LVL(7) As Integer
    Public Shared C_HST_NAM As String            'ﾎｽﾄ名
    Public Shared C_USR_PMN As Boolean = False   '認証許可
    '
    '[処理事業所情報]
    '
    Public Shared C_COM_COD As Integer           '事業所コード
    Public Shared C_COM_NAM As String            '事業所名
    Public Shared C_COM_NAM_SRT As String        '事業所名略称
    '
    '[ﾕｰｻﾞｰ情報]
    '
    Public Shared C_USR_IDS As Long              'ユーザーID
    Public Shared C_USR_NAM As String            'ユーザー名
    Public Shared C_USR_NAM_SRT As String        'ユーザー名略称
    Public Shared C_PRT_COD As Integer           '部コード
    Public Shared C_PRT_NAM As String            '部名    
    Public Shared C_BNC_COD As Integer           '支社コード(ユーザー所属)
    Public Shared C_BNC_NAM As String            '支社名(ユーザー所属)
    Public Shared C_BNC_NAM_SRT As String        '支社名略称(ユーザー所属)
    Public Shared C_USR_DIV As Integer           'ユーザー区分
    Public Shared C_USR_DIV_NAM As String        'ユーザー区分名
    Public Shared C_USE_PRT_COD As Integer       '運用部署区分
    Public Shared C_USE_PRT_NAM As String        '運用部署名
    Public Shared C_ACC_POD As Integer           '決算期
    '
    'Public Shared C_EMP_COD As Long             '社員コード
    'Public Shared C_EMP_NAM As String           '社員名
    '
    '端末情報
    Public Shared C_TMA_IPS As String            '端末IPｱﾄﾞﾚｽ
    Public Shared C_TMA_NAM As String            '端末名
    Public Shared C_ICO_FIL(6) As String         'ｱｲｺﾝﾌｧｲﾙ名
    Public Shared C_PCT_FIL(6) As String         '印鑑ﾌｧｲﾙ名
    Public Shared P_FRM_WIT As New frm_Wait("")
    '
    '[検索ﾃﾞｰﾀﾌﾟｰﾙ処理]
    '
    Public Shared P_FND_TBL As New DataTable
    Public Shared P_FND_IDX As Integer           'ｶﾚﾝﾄINDEX
    Public Shared C_FND_CNT_1 As Integer = 300
    Public Shared C_FND_CNT_BIG As Integer = 3000
    Public Shared C_FND_CNT_2 As Integer = 30
    Public Shared P_XID_FROM As Long = 0
    Public Shared P_XID_TO As Long = 0

    '*********************************************************************************************************
    '*
    '*  処理概要：ｺﾝｽﾄﾗｸﾀ
    '*
    '*  引数　　：
    '*
    '*********************************************************************************************************
    Public Sub New()
        Try
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub
    '*********************************************************************************************************
    '*
    '*  処理概要：ﾎｽﾄ名取得
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_SET_HST()
        '
        Dim D_RDR As System.IO.StreamReader
        '
        Try
            If Not System.IO.File.Exists(Application.StartupPath & "\" & C_FIL_HST_NAM) Then
                C_HST_NAM = ""
                GoTo EXIT_FUNCTION
            End If
            '
            D_RDR = New System.IO.StreamReader(Application.StartupPath & "\" & C_FIL_HST_NAM)
            If D_RDR.Peek <> -1 Then
                C_HST_NAM = D_RDR.ReadLine
            End If
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            If Not (D_RDR Is Nothing) Then
                D_RDR.Close()
                D_RDR = Nothing
            End If
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：Null値置換
    '*
    '*  引数　　：1.対象値
    '*            2.変換値
    '*
    '*  戻り値　：変換値
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_CNV_NUL(ByVal P1 As Object, ByVal P2 As Object) As Object
        '
        Dim D_RTN As Object
        '
        Try
            If IsDBNull(P1) OrElse IsNothing(P1) Then
                D_RTN = P2
            Else
                D_RTN = P1
            End If
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_CNV_NUL = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：値置換
    '*
    '*  引数　　：1.値
    '*            2.対象値
    '*            3.変換値
    '*
    '*  戻り値　：変換値
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_CNV_VAL(ByVal P1 As Object, ByVal P2 As Object, ByVal P3 As Object) As Object
        '
        Dim D_RTN As Object
        '
        Try
            P1 = FNC_CNV_NUL(P1, P2)
            If CStr(P1).Equals(P2) Then
                D_RTN = P3
            Else
                D_RTN = P1
            End If
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_CNV_VAL = D_RTN
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：SQLﾊﾟﾗﾒｰﾀ値作成
    '*
    '*  引数　　：1.対象ｺﾝﾎﾟｰﾈﾝﾄ
    '*
    '*            ｵﾌﾟｼｮﾝ1.日付値 False.範囲指定ﾊﾟﾗｰﾒｰﾀ(00→1900 / 99→9999) ※ﾃﾞﾌｫﾙﾄ
    '*                           True .実日指定       (00→2000 / 99→1999)
    '*
    '*  戻り値　：値
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SQL_VAL(ByVal P1 As Object, Optional ByVal OP1 As Boolean = False) As String
        '
        Dim D_RTN As String = ""
        '
        Try
            Select Case TypeName(P1)
                Case "Edit", "Mask", "TextBox"
                    'D_RTN = "'" & CStr(FNC_CNV_NUL(P1.Text, "")).Replace("'", "''") & "'"
                    D_RTN = CStr(FNC_CNV_NUL(P1.Text, "")).Replace("‐", "－")
                    D_RTN = "'" & CStr(FNC_CNV_NUL(D_RTN, "")).Replace("'", "''") & "'"
                Case "Date"
                    If IsNothing(P1.Value) Then
                        D_RTN = "Null"
                    Else
                        If Not OP1 Then
                            If P1.Text.Equals("00/01/01") Then
                                P1.Value = P1.MinDate
                            ElseIf P1.Text.Equals("99/12/31") Then
                                P1.Value = P1.MaxDate
                            End If
                        End If
                        '
                        'エラー回避（MinDate以下の日付値の場合は強制的にMinに書き換え）
                        '
                        If CDate(P1.Value.ToString()) < CDate(P1.MinDate.ToString()) Then P1.value = P1.MinDate
                        '
                        D_RTN = "'" & P1.Value.ToString() & "'"
                    End If
                Case "Combo"
                    If P1.DropDownStyle = ComboBoxStyle.DropDownList Then
                        D_RTN = FNC_CNV_NUL(P1.SelectedIndex, 0)
                    ElseIf P1.DropDownStyle = ComboBoxStyle.DropDown Then
                        D_RTN = "'" & CStr(FNC_CNV_NUL(P1.Text, "")).Trim.Replace("'", "''") & "'"
                    End If
                Case Else
                    D_RTN = FNC_CNV_NUL(P1.Value, 0)
            End Select
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_SQL_VAL = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：端末IPｱﾄﾞﾚｽ取得
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：IPｱﾄﾞﾚｽ
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_GET_IPS() As String
        '
        Dim D_RTN As String = ""
        '
        Try
            Dim D_HST As String = System.Net.Dns.GetHostName()
            Dim D_IPS As System.Net.IPAddress() = System.Net.Dns.GetHostAddresses(D_HST)
            '
            For Each address As System.Net.IPAddress In D_IPS
                If IsNumeric(address.ToString().Replace(".", "")) Then
                    D_RTN = address.ToString()
                    '
                    Exit For
                End If
            Next
            '
            '▼旧コード
            '
            'Dim D_IPS As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName())
            '
            'D_RTN = D_IPS.AddressList(0).ToString()
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_GET_IPS = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：端末名取得
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：端末名
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_GET_NAM() As String
        '
        Dim D_RTN As String = ""
        '
        Try
            D_RTN = System.Net.Dns.GetHostName()
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_GET_NAM = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：更新ﾕｰｻﾞｰ情報生成
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：ﾕｰｻﾞｰ情報
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_UPD_USR() As String
        '
        Dim D_RTN As String = ""
        '
        Try
            D_RTN = "'" & utl_Com.C_USR_IDS & "','" & FNC_GET_IPS() & "'"
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_UPD_USR = D_RTN
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ｽﾃｰﾀｽﾊﾞｰﾕｰｻﾞｰ情報ｾｯﾄ
    '*
    '*  引数　　：1.ｽﾃｰﾀｽﾊﾞｰ
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_SET_STT(ByRef P1 As StatusBar)
        '
        Try
            'P1.Panels(1).Text = 
            'P1.Panels(3).Text = 
            'P1.Panels(4).Text = 
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾌｫｰﾑ内ﾃｷｽﾄｺﾝﾄﾛｰﾙ値ｸﾘｱ
    '*
    '*  引数　　：1.ﾌｫｰﾑ
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_TXT_CLR(ByRef P1 As Object)
        '
        Try
            For Each P1 In P1.Controls
                Select Case TypeName(P1)
                    Case "Number", "Edit", "Mask", "TextBox", "Date"
                        P1.Text = ""
                        P1.Tag = ""
                    Case "Combo"
                        P1.Text = ""
                        P1.SelectedIndex = 0
                    Case "MultiRowSheet"
                        P1.Clear()
                    Case "CheckBox"
                        P1.Checked = False
                    Case "Label"
                        If Mid(P1.Name, 1, 4).Equals("DSP_") Then
                            P1.Text = ""
                            P1.BackColor = SystemColors.Info
                        End If
                        P1.UseMnemonic = False
                    Case "Button"
                        P1.BackColor = SystemColors.Control
                    Case Else
                End Select
            Next
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾌｫｰﾑ内入力ｺﾝﾄﾛｰﾙ入力可否設定
    '*
    '*  引数　　：1.ﾌｫｰﾑ
    '*            2.True.可、False.不可
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_TXT_VIS(ByRef P1 As Object, ByVal P2 As Boolean)
        '
        Try
            For Each P1 In P1.Controls
                Select Case TypeName(P1)
                    Case "Number", "Edit", "Mask", "TextBox", "Date", "Combo", "CheckBox"
                        P1.Enabled = P2
                    Case "MultiRowSheet"
                        If P2 Then
                            'P1.EditType = GrapeCity.Win.ElTabelle.EditType.AlwaysEdit
                        Else
                            'P1.EditType = GrapeCity.Win.ElTabelle.EditType.ReadOnly
                        End If
                    Case Else
                End Select
            Next
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾘｽﾄﾋﾞｭｰ設定
    '*
    '*  引数　　：1.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*          　2.ﾘｽﾄﾋﾞｭｰ
    '*            ｵﾌﾟｼｮﾝ1.整数ﾌｫｰﾏｯﾄ
    '*            ｵﾌﾟｼｮﾝ2.実数ﾌｫｰﾏｯﾄ
    '*            ｵﾌﾟｼｮﾝ3.日付ﾌｫｰﾏｯﾄ
    '*            ｵﾌﾟｼｮﾝ4.ﾌｫｰｶｽ設定
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_CNF_LST(ByRef P1 As DataTable, ByRef P2 As ListView,
                                  Optional ByVal FMT_NUM As String = "",
                                  Optional ByVal FMT_FLT As String = "",
                                  Optional ByVal FMT_DTE As String = "",
                                  Optional ByVal FCS_SET As Boolean = True)
        '
        Dim I As Integer = 0
        Dim X As Integer = 0
        Dim D_CLM(P1.Columns.Count - 1) As ColumnHeader
        Dim D_ITM(P1.Rows.Count - 1) As ListViewItem
        Dim D_DAT(P1.Columns.Count - 1) As String
        Dim D_FMT As String = ""
        Dim D_NUL As Object
        '
        Try
            P2.Clear()
            For I = 0 To P1.Rows.Count - 1 Step 1
                For X = 0 To P1.Columns.Count - 1 Step 1
                    If I = 0 Then
                        D_CLM(X) = New ColumnHeader
                        '※事業所臨時処置
                        D_CLM(X).Text = P1.Columns(X).ColumnName
                        D_CLM(X).Width = 100
                        Select Case P1.Columns(X).DataType.Name
                            Case "Byte", "Int16", "Int32", "Int64", "SByte", "UInt16", "UInt32", "UInt64"
                                D_CLM(X).TextAlign = HorizontalAlignment.Right
                            Case "Decimal", "Double", "Single"
                                D_CLM(X).TextAlign = HorizontalAlignment.Right
                            Case "String", "Char", "Boolean"
                                D_CLM(X).TextAlign = HorizontalAlignment.Left
                            Case "DateTime", "TimeSpan"
                                D_CLM(X).TextAlign = HorizontalAlignment.Center
                        End Select
                    End If
                    '
                    Select Case P1.Columns(X).DataType.Name
                        Case "Byte", "Int16", "Int32", "Int64", "SByte", "UInt16", "UInt32", "UInt64"
                            D_FMT = FMT_NUM
                            D_NUL = 0
                        Case "Decimal", "Double", "Single"
                            D_FMT = FMT_FLT
                            D_NUL = 0
                        Case "DateTime", "TimeSpan"
                            D_FMT = FMT_DTE
                            D_NUL = Nothing
                        Case Else
                            D_FMT = ""
                            D_NUL = ""
                    End Select
                    '
                    D_DAT(X) = IIf(D_FMT = "", FNC_CNV_NUL(P1.Rows(I).Item(X), D_NUL), Format(FNC_CNV_NUL(P1.Rows(I).Item(X), D_NUL), D_FMT))
                Next
                X = 0
                D_ITM(I) = New ListViewItem(D_DAT)
                D_ITM(I).BackColor = IIf(I Mod 2 = 1, Color.White, Color.Lavender)
            Next
            P2.Columns.AddRange(D_CLM)
            P2.Items.AddRange(D_ITM)
            '
            P2.Items(0).Selected = True
            P2.Items(0).Focused = True
            If FCS_SET Then P2.Focus()
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            Erase D_CLM, D_ITM, D_DAT
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾘｽﾄﾋﾞｭｰ項目幅読込
    '*
    '*  引数　　：1.ﾘｽﾄﾋﾞｭｰ
    '*            2.ﾌｧｲﾙ名
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_LOD_LST(ByRef P1 As ListView, ByVal P2 As String) As Boolean
        '
        Dim D_RTN As Boolean = False
        Dim I As Integer = 0
        Dim D_DAT As String = ""
        Dim D_NAM As String = ""
        Dim D_WID As String = ""
        Dim D_POS As Integer = 0
        Dim D_STM_RDR As StreamReader
        '
        Try
            'XID幅0[固定]
            If P1.Columns(0).Text.Equals("TTL") Then
                P1.Columns(0).Width = 0
            End If
            '
            If IsNothing(P1) OrElse P1.Columns.Count <= 0 OrElse P2.Equals("") OrElse
               Not File.Exists(Application.StartupPath & "\" & C_DIR_LST & "\" & C_COM_COD & "_" & C_USR_IDS & "\" & P2 & ".ini") Then
                GoTo EXIT_FUNTION
            End If
            '
            D_STM_RDR = New StreamReader(Application.StartupPath & "\" & C_DIR_LST & "\" & C_COM_COD & "_" & C_USR_IDS & "\" & P2 & C_FIL_PRM_EXN, System.Text.Encoding.Default)
            For I = 0 To P1.Columns.Count - 1 Step 1
                If D_STM_RDR.Peek <> -1 Then
                    D_DAT = D_STM_RDR.ReadLine()
                    D_POS = D_DAT.IndexOf(",")
                    D_NAM = Mid(D_DAT, 1, D_POS)
                    D_WID = Mid(D_DAT, D_POS + 2, D_DAT.Length - 1)
                    '
                    If P1.Columns(I).Text.Equals(D_NAM) Then
                        P1.Columns(I).Width = CInt(D_WID)
                    End If
                End If
            Next
            '
            D_RTN = True
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            If Not (D_STM_RDR Is Nothing) Then
                D_STM_RDR.Close()
                D_STM_RDR = Nothing
            End If
        End Try
EXIT_FUNTION:
        FNC_LOD_LST = D_RTN
        '

        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾘｽﾄﾋﾞｭｰ項目幅保存
    '*
    '*  引数　　：1.ﾘｽﾄﾋﾞｭｰ
    '*            2.ﾌｧｲﾙ名
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_LST(ByRef P1 As ListView, ByVal P2 As String) As Boolean
        '
        Dim I As Integer = 0
        Dim D_RTN As Boolean = False
        Dim D_STM_WIT As StreamWriter
        '
        Try
            If IsNothing(P1) OrElse P1.Columns.Count <= 0 OrElse P2.Equals("") Then
                GoTo EXIT_FUNTION
            End If
            '
            If Not Directory.Exists(Application.StartupPath & "\" & C_DIR_LST & "\" & C_COM_COD & "_" & C_USR_IDS) Then
                Directory.CreateDirectory(Application.StartupPath & "\" & C_DIR_LST & "\" & C_COM_COD & "_" & C_USR_IDS)
            End If
            '
            D_STM_WIT = New StreamWriter(Application.StartupPath & "\" & C_DIR_LST & "\" & C_COM_COD & "_" & C_USR_IDS & "\" & P2 & C_FIL_PRM_EXN, False, System.Text.Encoding.Default)
            For I = 0 To P1.Columns.Count - 1 Step 1
                D_STM_WIT.WriteLine(P1.Columns(I).Text & "," & P1.Columns(I).Width.ToString)
            Next
            '
            D_RTN = True
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            If Not (D_STM_WIT Is Nothing) Then
                D_STM_WIT.Flush()
                D_STM_WIT.Close()
                '
                D_STM_WIT = Nothing
            End If
        End Try
EXIT_FUNTION:
        FNC_SAV_LST = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾊﾟﾗﾒｰﾀ保存
    '*
    '*  引数　　：1.ﾌｫｰﾑ
    '*            2.ﾀｲﾌﾟ(1.検索、2.出力、3.入力)
    '*            3.ﾌｧｲﾙ名
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_SAV_PRM(ByRef P1 As Object, ByVal P2 As Integer, ByVal P3 As String)
        '
        Dim D_DIR As String = ""
        Dim D_STM_WIT As StreamWriter
        '
        Try
            Select Case P2
                Case 1 : D_DIR = C_DIR_FND
                Case 2 : D_DIR = C_DIR_RPT
                Case 3 : D_DIR = C_DIR_INP
                Case Else : GoTo EXIT_FUNCTION
            End Select
            '
            If Not Directory.Exists(Application.StartupPath & "\" & D_DIR & "\" & C_COM_COD & "_" & C_USR_IDS) Then
                Directory.CreateDirectory(Application.StartupPath & "\" & D_DIR & "\" & C_COM_COD & "_" & C_USR_IDS)
            End If
            '
            D_STM_WIT = New StreamWriter(Application.StartupPath & "\" & D_DIR & "\" & C_COM_COD & "_" & C_USR_IDS & "\" & P3 & C_FIL_PRM_EXN, False, System.Text.Encoding.Default)
            '
            For Each P1 In P1.Controls
                Select Case TypeName(P1)
                    Case "TextBox", "Edit", "Mask"
                        If Not P1.Name.Equals("TXT_LOG") Then
                            '20170901
                            'D_STM_WIT.WriteLine(P1.Name & "," & P1.Text)
                            D_STM_WIT.WriteLine(P1.Name & "," & P1.Text.Replace(Chr(13), "").Replace(Chr(10), ""))
                        End If
                    Case "Number"
                        If (P1.MaxValue < P1.Value) Or (P1.MinValue > P1.Value) Then
                            D_STM_WIT.WriteLine(P1.Name & "," & P1.MinValue.ToString)
                        Else
                            D_STM_WIT.WriteLine(P1.Name & "," & P1.Text)
                        End If
                    Case "Date"
                        'D_STM_WIT.WriteLine(P1.Name & "," & (IIf(IsDate(P1.Text), P1.Text, P1.Value)))
                        'Add 2007/06/08　改定   2007/11/06↓ 改定 2008/05/01
                        'エラー回避（MinDate以下の日付値の場合は強制的にMinに書き換え）
                        If Not P1.VALUE Is Nothing Then
                            If CDate(P1.Value.ToString()) < CDate(P1.MINDATE.ToString()) Then P1.value = P1.mindate
                        Else
                            P1.text = ""
                        End If
                        '
                        'Add 2007/06/08　↑ 2007/11/06 ↑ 2008/05/01
                        D_STM_WIT.WriteLine(P1.Name & "," & P1.Text)
                    Case "Label"
                        If Mid(P1.NAME, 1, 4).Equals("DSP_") Then
                            D_STM_WIT.WriteLine(P1.Name & "," & P1.Text)
                        End If
                    Case "Combo"
                        If P1.DropDownStyle = ComboBoxStyle.DropDownList Then
                            D_STM_WIT.WriteLine(P1.Name & "," & CStr(P1.SelectedIndex))
                        ElseIf P1.DropDownStyle = ComboBoxStyle.DropDown Then
                            D_STM_WIT.WriteLine(P1.Name & "," & P1.Text)
                        End If
                    Case "CheckBox"
                        D_STM_WIT.WriteLine(P1.Name & "," & P1.Checked)
                    Case Else
                End Select
            Next
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            If Not (D_STM_WIT Is Nothing) Then
                D_STM_WIT.Flush()
                D_STM_WIT.Close()
                '
                D_STM_WIT = Nothing
            End If
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾊﾟﾗﾒｰﾀ読込
    '*
    '*  引数　　：1.ﾌｫｰﾑ
    '*            2.ﾀｲﾌﾟ(1.検索、2.出力、3.入力)
    '*            3.ﾌｧｲﾙ名
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_LOD_PRM(ByRef P1 As Object, ByVal P2 As Integer, ByVal P3 As String)
        '
        Dim I As Integer = 0
        Dim D_DAT As String = ""
        Dim D_NAM As String = ""
        Dim D_VAL As String = ""
        Dim D_POS As Integer = 0
        Dim D_DIR As String = ""
        Dim D_STM_RDR As StreamReader
        '
        Try
            Select Case P2
                Case 1 : D_DIR = C_DIR_FND
                Case 2 : D_DIR = C_DIR_RPT
                Case 3 : D_DIR = C_DIR_INP
                Case Else : GoTo EXIT_FUNCTION
            End Select
            '
            If Not File.Exists(Application.StartupPath & "\" & D_DIR & "\" & C_COM_COD & "_" & C_USR_IDS & "\" & P3 & ".ini") Then
                GoTo EXIT_FUNCTION
            End If
            '
            D_STM_RDR = New StreamReader(Application.StartupPath & "\" & D_DIR & "\" & C_COM_COD & "_" & C_USR_IDS & "\" & P3 & C_FIL_PRM_EXN, System.Text.Encoding.Default)
            '
            For Each P1 In P1.Controls
                Select Case TypeName(P1)
                    Case "TextBox", "Edit", "Mask", "Number", "Date"
                        If Not P1.Name.Equals("TXT_LOG") Then
                            If D_STM_RDR.Peek <> -1 Then
                                D_DAT = D_STM_RDR.ReadLine()
                                D_POS = D_DAT.IndexOf(",")
                                D_NAM = Mid(D_DAT, 1, D_POS)
                                D_VAL = Mid(D_DAT, D_POS + 2, D_DAT.Length - 1)
                                '
                                '↓ ADD 2008/05/01
                                If TypeName(P1).Equals("Date") Then
                                    If IsDate(D_VAL) Then
                                        If P1.FORMAT.PATTERN.Equals("yy/MM") Then
                                            D_VAL = D_VAL + "/01"
                                        End If
                                        D_VAL = Format(CDate(D_VAL), P1.Format.Pattern)
                                    End If
                                End If
                                '↑ ADD 2008/05/01
                                '
                                If P1.NAME.Equals(D_NAM) Then
                                    P1.TEXT = D_VAL
                                End If
                            End If
                        End If
                    Case "Label"
                        If Mid(P1.NAME, 1, 4).Equals("DSP_") Then
                            If D_STM_RDR.Peek <> -1 Then
                                D_DAT = D_STM_RDR.ReadLine()
                                D_POS = D_DAT.IndexOf(",")
                                D_NAM = Mid(D_DAT, 1, D_POS)
                                D_VAL = Mid(D_DAT, D_POS + 2, D_DAT.Length - 1)
                                '
                                If P1.NAME.Equals(D_NAM) Then
                                    P1.TEXT = D_VAL
                                End If
                            End If
                        End If
                    Case "Combo"
                        If D_STM_RDR.Peek <> -1 Then
                            D_DAT = D_STM_RDR.ReadLine()
                            D_POS = D_DAT.IndexOf(",")
                            D_NAM = Mid(D_DAT, 1, D_POS)
                            D_VAL = Mid(D_DAT, D_POS + 2, D_DAT.Length - 1)
                            '
                            If P1.NAME.Equals(D_NAM) Then
                                If P1.DropDownStyle = ComboBoxStyle.DropDownList Then
                                    P1.SelectedIndex = D_VAL
                                ElseIf P1.DropDownStyle = ComboBoxStyle.DropDown Then
                                    P1.TEXT = D_VAL
                                End If
                            End If
                        End If
                    Case "CheckBox"
                        If D_STM_RDR.Peek <> -1 Then
                            D_DAT = D_STM_RDR.ReadLine()
                            D_POS = D_DAT.IndexOf(",")
                            D_NAM = Mid(D_DAT, 1, D_POS)
                            D_VAL = Mid(D_DAT, D_POS + 2, D_DAT.Length - 1)
                            '
                            If P1.NAME.Equals(D_NAM) Then
                                P1.Checked = D_VAL
                            End If
                        End If
                    Case Else
                End Select
            Next
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            If Not (D_STM_RDR Is Nothing) Then
                D_STM_RDR.Close()
                '
                D_STM_RDR = Nothing
            End If
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾛｸﾞｲﾝID読込
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：事業所コード , ユーザーID
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_LOD_IDS() As String()
        '
        Dim D_RTN(2) As String
        Dim D_STM_RDR As StreamReader
        '
        Try
            D_RTN(0) = ""
            D_RTN(1) = ""
            '
            If Not File.Exists(Application.StartupPath & "\ID.ini") Then
                GoTo EXIT_FUNCTION
            End If
            '
            D_STM_RDR = New StreamReader(Application.StartupPath & "\ID.ini", System.Text.Encoding.Default)
            If D_STM_RDR.Peek <> -1 Then D_RTN(0) = D_STM_RDR.ReadLine()
            If D_STM_RDR.Peek <> -1 Then D_RTN(1) = D_STM_RDR.ReadLine()
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            If Not (D_STM_RDR Is Nothing) Then
                D_STM_RDR.Close()
                D_STM_RDR = Nothing
            End If
        End Try
EXIT_FUNCTION:
        FNC_LOD_IDS = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾛｸﾞｲﾝID保存
    '*
    '*  引数　　：1.事業所コード
    '*            2.ユーザーID
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_SAV_IDS(ByVal P1 As String, ByVal P2 As String)
        '
        Dim D_STM_WIT As StreamWriter
        '
        Try
            D_STM_WIT = New StreamWriter(Application.StartupPath & "\ID.ini", False, System.Text.Encoding.Default)
            D_STM_WIT.WriteLine(P1)
            D_STM_WIT.WriteLine(P2)
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            If Not (D_STM_WIT Is Nothing) Then
                D_STM_WIT.Flush()
                D_STM_WIT.Close()
                '
                D_STM_WIT = Nothing
            End If
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '**************************************************************************************************************
    '*
    '*  処理概要：ｴﾗｰ詳細を画面表示
    '*
    '*  引数　　：1.Exception
    '*
    '*            ｵﾌﾟｼｮﾝ1.SQLｺﾏﾝﾄﾞ
    '*            ｵﾌﾟｼｮﾝ2.ﾒｯｾｰｼﾞ表示有無
    '*
    '*  戻り値　：なし
    '*
    '**************************************************************************************************************
    Public Shared Sub FNC_ERR_RTN(ByRef P1 As Exception, Optional ByVal OP1 As String = "", Optional ByVal OP2 As Boolean = False)
        '
        Try
            Select Case P1.GetType.Name
                Case "ThreadAbortException"
                    Throw P1
                Case Else
                    If Not OP2 Then
                        MsgBox("【エラー内容 】" _
                                & Microsoft.VisualBasic.ControlChars.CrLf _
                                & P1.Message _
                                & Microsoft.VisualBasic.ControlChars.CrLf _
                                & Microsoft.VisualBasic.ControlChars.CrLf _
                                & IIf(OP1.Equals(""), "", "【ＳＱＬコマンド 】") _
                                & IIf(OP1.Equals(""), "", Microsoft.VisualBasic.ControlChars.CrLf) _
                                & IIf(OP1.Equals(""), "", OP1) _
                                & IIf(OP1.Equals(""), "", Microsoft.VisualBasic.ControlChars.CrLf) _
                                & IIf(OP1.Equals(""), "", Microsoft.VisualBasic.ControlChars.CrLf) _
                                & "【 発生場所 】" _
                                & Microsoft.VisualBasic.ControlChars.CrLf _
                                & P1.StackTrace _
                                & Microsoft.VisualBasic.ControlChars.CrLf _
                                & Microsoft.VisualBasic.ControlChars.CrLf _
                                & "【 発生日時 】" _
                                & Microsoft.VisualBasic.ControlChars.CrLf _
                                & Format(Now(), "yyyy/MM/dd HH:mm:ss"),
                                MsgBoxStyle.Critical,
                                "ｴﾗｰ")
                    End If
                    '
                    Call FNC_ERR_LOG(P1, OP1)
            End Select
            '
        Catch ex As Threading.ThreadAbortException
            Throw ex
        Catch ex As Exception
            MsgBox("ｴﾗｰﾀﾞｲﾛｸﾞの表示に失敗しました!!:" & ex.Message, MsgBoxStyle.Critical)
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

    '**************************************************************************************************************
    '*
    '*  処理概要：ｴﾗｰ詳細を画面表示
    '*
    '*  引数　　：1.Exception
    '*            2.SQLｺﾏﾝﾄﾞ
    '*
    '*  戻り値　：なし
    '*
    '**************************************************************************************************************
    Public Shared Sub FNC_ERR_LOG(ByRef P1 As Exception, ByVal P2 As String)
        '
        'Dim D_WEB As New Web_ERR.Web_ERR
        '
        Try
            'Call FNC_WEB_URL(D_WEB)
            ''
            'Call D_WEB.FNC_ERR_LOG(utl_Com.FNC_GET_IPS,
            '                       P1.Message(),
            '                       P2,
            '                       P1.StackTrace(),
            '                       Format(Now(), "yyyy/MM/dd HH:mm:ss"))
            'D_WEB.Dispose()
        Catch ex As Exception
            MsgBox("ｴﾗｰﾛｸﾞの生成に失敗しました!!:" & ex.Message, MsgBoxStyle.Critical)
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

    '**************************************************************************************************************
    '*
    '*  処理概要：WebService URL調整
    '*
    '*  引数　　：1.SoapHttpClientProtocol
    '*
    '*  戻り値　：なし
    '*
    '**************************************************************************************************************
    Public Shared Sub FNC_WEB_URL(ByRef P1 As Web.Services.Protocols.SoapHttpClientProtocol)
        '
        Try
            'P1.Timeout = cns_Com.C_WEB_TIM_OUT
            ''
            'If C_HST_NAM.Equals("") Then
            '    'ﾉﾝﾀｯﾁﾃﾞﾌﾟﾛｲﾒﾝﾄ駆動
            '    Dim D_URI As New Uri(System.AppDomain.CurrentDomain.BaseDirectory)
            '    If (Not D_URI.Host.Equals("")) Then
            '        Dim D_OLD_URI As New Uri(P1.Url)
            '        P1.Url = P1.Url.Replace(D_OLD_URI.Host, D_URI.Host)
            '    End If
            'Else
            '    '配布ﾌﾟﾛｾｽ駆動
            '    Dim D_OLD_URI As New Uri(P1.Url)
            '    P1.Url = P1.Url.Replace(D_OLD_URI.Host, C_HST_NAM)
            'End If
        Catch ex As Exception
            MsgBox("WebｻｰﾋﾞｽのURL変更に失敗しました!!" & ex.Message, MsgBoxStyle.Critical)
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

    '**************************************************************************************************************
    '*
    '*  処理概要：ｺﾝﾎﾞﾎﾞｯｸｽ設定
    '*
    '*  引数　　：1.ｺﾝﾎﾞﾎﾞｯｸｽ
    '*            2.SQLｺﾏﾝﾄﾞ
    '*            3.既定選択ｲﾝﾃﾞｯｸｽ
    '*
    '*  戻り値　：なし
    '*
    '**************************************************************************************************************
    Public Shared Sub FNC_SET_CMB(ByRef P1 As GrapeCity.Win.Editors.GcComboBox, ByVal P2 As String, ByVal P3 As Integer)
        '
        Dim I As Integer
        Dim D_TBL As New DataTable
        '
        Try
            D_TBL = utl_Rdb.utl_Rdb.FNC_GET_TBL(P2)
            '
            If D_TBL.Rows.Count > 0 Then
                P1.Items.Clear()
                For I = 0 To D_TBL.Rows.Count - 1
                    P1.Items.Add(New GrapeCity.Win.Editors.ListItem(utl_Com.FNC_CNV_NUL(D_TBL.Rows(I).Item("名称"), "")))
                Next
                P1.SelectedIndex = P3
            End If
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            D_TBL.Clear()
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

    '**************************************************************************************************************
    '*
    '*  処理概要：ｺﾝﾎﾞﾎﾞｯｸｽ設定
    '*
    '*  引数　　：1.ｺﾝﾎﾞﾎﾞｯｸｽ
    '*            2.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            3.既定選択ｲﾝﾃﾞｯｸｽ
    '*
    '*  戻り値　：なし
    '*
    '**************************************************************************************************************
    Public Shared Sub FNC_SET_CMB(ByRef P1 As GrapeCity.Win.Editors.GcComboBox, ByRef P2 As DataTable, ByVal P3 As Integer)
        '
        Dim I As Integer
        '
        Try
            If P2.Rows.Count > 0 Then
                P1.Items.Clear()
                For I = 0 To P2.Rows.Count - 1
                    P1.Items.Add(New GrapeCity.Win.Editors.ListItem(utl_Com.FNC_CNV_NUL(P2.Rows(I).Item("名称"), "")))
                Next
                P1.SelectedIndex = P3
            End If
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            '
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

    '**************************************************************************************************************
    '*
    '*  処理概要：日付ｺﾝﾄﾛｰﾙ値ｾｯﾄ
    '*
    '*  引数　　：1.日付ｺﾝﾄﾛｰﾙ
    '*            2.値
    '*
    '*  戻り値　：なし
    '*
    '**************************************************************************************************************
    Public Shared Sub FNC_SET_DTE(ByRef P1 As GrapeCity.Win.Editors.GcDate, ByRef P2 As Object)
        '
        Dim D_FMT As String = ""
        '
        Try
            If TryCast(P1.DisplayFields(0), GrapeCity.Win.Editors.Fields.DateYearDisplayField).YearDigit = GrapeCity.Win.Editors.YearDigitType.TwoDigitYear Then
                D_FMT = "yy"
            Else
                D_FMT = "yyyy"
            End If
            D_FMT &= "/MM/dd"
            '
            'P1.Text = Format(FNC_CNV_NUL(P2, Nothing), P1.Format.Pattern)
            '
            P1.Text = Format(FNC_CNV_NUL(P2, Nothing), D_FMT)
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            '
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

    '**************************************************************************************************************
    '*
    '*  処理概要：ｺﾝﾎﾞﾎﾞｯｸｽ入力桁数制御
    '*
    '*  引数　　：1.ｺﾝﾎﾞｺﾝﾄﾛｰﾙ
    '*            2.桁数
    '*
    '*  戻り値　：ｺﾝﾎﾞｺﾝﾄﾛｰﾙ
    '*
    '**************************************************************************************************************
    Public Shared Function FNC_CHK_CMB_TXT(ByRef P1 As GrapeCity.Win.Editors.GcComboBox, ByVal P2 As Integer) As GrapeCity.Win.Editors.GcComboBox
        '
        Try
            If P1.DropDownStyle = ComboBoxStyle.DropDownList Then
                '選択ｺﾝﾎﾞ対象外
                GoTo SUB_EXIT
            End If
            '
            Dim D_LEN As Integer = System.Text.Encoding.GetEncoding(932).GetByteCount(P1.Text)
            '
            If D_LEN > P2 Then
                Dim D_BYT As Byte() = System.Text.Encoding.GetEncoding(932).GetBytes(P1.Text)
                P1.Text = System.Text.Encoding.GetEncoding(932).GetString(D_BYT, 0, P2).Replace(ControlChars.NullChar, "")
                P1.SelectionStart = P2
            End If
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            '
        End Try
SUB_EXIT:
        FNC_CHK_CMB_TXT = P1
        Exit Function
    End Function

    '**************************************************************************************************************
    '*
    '*  処理概要：ﾌｧｲﾙ名編集(ﾌｧｲﾙ名 + 日時)
    '*
    '*  引数　　：1.ﾌｧｲﾙ名
    '*
    '*  戻り値　：ﾌｧｲﾙ名
    '*
    '**************************************************************************************************************
    Public Shared Function FNC_CNV_FIL_NAM(ByVal P1 As String) As String
        '
        Dim D_RTN As String = ""
        '
        Try
            D_RTN = P1 & "_" & Format(Now(), "yyMMdd_HHmmss")
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            '
        End Try
SUB_EXIT:
        FNC_CNV_FIL_NAM = D_RTN
        Exit Function
    End Function

    '**************************************************************************************************************
    '*
    '*  処理概要：多重起動検査
    '*
    '*  引数　　：1.ﾌｧｲﾙ名
    '*
    '*  戻り値　：True.多重起動、False.一意起動
    '*
    '**************************************************************************************************************
    Public Shared Function FNC_PRV_INS() As Boolean
        Dim D_RTN As Boolean = False
        Try
            If UBound(Diagnostics.Process.GetProcessesByName(Diagnostics.Process.GetCurrentProcess.ProcessName)) > 0 Then
                D_RTN = True
            End If
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            '
        End Try
SUB_EXIT:
        FNC_PRV_INS = D_RTN
        Exit Function
    End Function

    '**************************************************************************************************************
    '*
    '*  処理概要：固定ﾊﾞｲﾄ数文字列生成
    '*
    '*  引数　　：1.対象値
    '*            2.詰文字
    '*            3.固定ﾊﾞｲﾄ数
    '*            4.処理ﾀｲﾌﾟ(1:前詰　2:後詰)
    '*
    '*  戻り値　：固定長文字列
    '*
    '**************************************************************************************************************
    Public Shared Function FNC_BYT_DAT(ByVal P1 As Object, ByVal P2 As String, ByVal P3 As Integer, ByVal P4 As Byte) As String
        Dim D_RTN As String
        Dim I As Integer
        Dim D_STR As String
        Dim D_CHR As String
        Dim D_LEN As Integer = 1
        Try
            D_STR = CStr(utl_Com.FNC_CNV_NUL(P1, ""))
            '
            D_STR = CStr(FNC_CNV_NUL(D_STR, "")).Replace("‐", "－")
            '
            For I = 1 To P3 Step 1
                '
                D_CHR = Mid(D_STR, I, 1)
                '
                Select Case D_CHR
                    Case "", vbCr, vbLf, vbCrLf
                        If P4 = 1 Then
                            D_RTN = D_RTN & P2
                        Else
                            D_RTN = P2 & D_RTN
                        End If
                    Case Else
                        D_RTN = D_RTN & D_CHR
                        If System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(D_CHR) = 2 Then
                            '全角
                            D_LEN = (D_LEN + 1)
                        End If
                End Select
                '
                If D_LEN = P3 Then
                    Exit For
                ElseIf D_LEN > P3 Then
                    '末尾全角
                    If P4 = 1 Then
                        D_RTN = Mid(D_RTN, 1, D_RTN.Length - 1) & P2
                    Else
                        D_RTN = P2 & Mid(D_RTN, 1, D_RTN.Length - 1)
                    End If
                    Exit For
                End If
                D_LEN = (D_LEN + 1)
            Next
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            '
        End Try
SUB_EXIT:
        FNC_BYT_DAT = D_RTN
        Exit Function
    End Function

    '**************************************************************************************************************
    '*
    '*  処理概要：１行目文字列抽出
    '*
    '*  引数　　：1.対象文字列
    '*   		  2.抽出桁数(ﾊﾞｲﾄ指定)
    '*
    '*  戻り値　：変換値
    '*
    '**************************************************************************************************************
    Public Shared Function FNC_GET_1ST_STR(ByVal P1 As String, ByVal P2 As Integer) As String
        Dim D_RTN As String
        Dim D_IDX As Integer = 0
        Try
            D_IDX = P1.IndexOf(vbCrLf)
            '
            If D_IDX <> -1 Then
                D_RTN = Mid(P1, 1, D_IDX)
            Else
                D_RTN = P1
            End If
            D_RTN = FNC_BYT_DAT(D_RTN, "", P2, 1)
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            '
        End Try
SUB_EXIT:
        FNC_GET_1ST_STR = D_RTN
        Exit Function
    End Function

    '**************************************************************************************************************
    '*
    '*  処理概要：複数行文字列正規化
    '*
    '*  引数　　：1.対象文字列
    '*   		  2.最大行数
    '*            3.最大桁数
    '*
    '*  戻り値　：変換値
    '*
    '**************************************************************************************************************
    Public Shared Function FNC_CNV_STR(ByVal P1 As String, ByVal P2 As Integer, ByVal P3 As Integer) As String
        Dim D_RTN As String = ""
        Dim I As Integer = 0
        '
        Dim D_LIN As Integer = 1 '行数
        Dim D_BEM As Integer = 0 '桁数
        Dim D_BFR_CR As Boolean = False '前回改行
        Dim D_BEM_MAX_CR As Boolean = False '
        Dim D_CHR As String = "" '処理文字
        Dim D_DAT As String = ""
        Try
            If (IsDBNull(P1) OrElse IsNothing(P1) OrElse (P1.Equals(""))) Then
                GoTo SUB_EXIT
            End If
            '
            For I = 1 To Len(P1)
                D_CHR = Mid(P1, I, 1)
                If Not ((D_CHR.Equals(Chr(10))) OrElse (D_CHR.Equals(Chr(13)))) Then
                    '
                    D_DAT = D_DAT & D_CHR
                    D_BEM_MAX_CR = False
                    D_BFR_CR = False
                    '
                    If System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(D_CHR) = 2 Then
                        '全角
                        D_BEM = D_BEM + 1
                    End If
                    D_BEM = D_BEM + 1
                    If (D_BEM >= P3) Then       '一行決定
                        If (D_BEM <> P3) Then
                            D_RTN = D_RTN & Left(D_DAT, Len(D_DAT) - 1) & Chr(13) & Chr(10)
                        Else
                            D_RTN = D_RTN & D_DAT & Chr(13) & Chr(10)
                        End If
                        D_LIN = D_LIN + 1
                        If (D_BEM = P3) Then
                            D_DAT = ""
                            D_BEM = 0
                            D_BEM_MAX_CR = True
                        Else
                            D_DAT = D_CHR
                            D_BEM = 2
                        End If
                    End If
                Else
                    If D_BFR_CR Then
                        D_BFR_CR = False
                    Else                                '一行決定
                        D_BFR_CR = True
                        If Not D_BEM_MAX_CR Then
                            D_RTN = D_RTN & D_DAT & Chr(13) & Chr(10)
                            D_LIN = D_LIN + 1
                            D_DAT = ""
                            D_BEM = 0
                        End If
                        D_BEM_MAX_CR = False
                    End If
                End If
                If (D_LIN > P2) Then
                    Exit For
                End If
            Next
            If Not D_DAT.Equals("") Then
                D_RTN = D_RTN & D_DAT & Chr(13) & Chr(10)
            End If
            D_RTN = Left(D_RTN, Len(D_RTN) - 2)
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            '
        End Try
SUB_EXIT:
        FNC_CNV_STR = D_RTN
        Exit Function
    End Function

    '**************************************************************************************************************
    '*
    '*  処理概要：指定行抽出
    '*
    '*  引数　　：1.対象文字列
    '*   		  2.指定行NO
    '*            3.指定桁数
    '*
    '*  戻り値　：指定１行
    '*
    '**************************************************************************************************************
    Public Shared Function FNC_GET_LIN(ByVal P1 As String, ByVal P2 As Integer, ByVal P3 As Integer) As String
        Dim D_RTN As String = ""
        Dim I As Integer = 0
        '
        Dim D_LIN As Integer = 1
        Dim D_BEM As Integer = 0
        Dim D_FND As Boolean = False
        Dim D_BFR_CR As Boolean = False
        Dim D_CHR As String = ""
        Dim D_DAT As String = ""
        Try
            If IsDBNull(P1) OrElse IsNothing(P1) Then
                GoTo SUB_EXIT
            End If
            '
            For I = 1 To Len(P1)
                D_CHR = Mid(P1, I, 1)
                If Not (D_CHR.Equals(Chr(10)) OrElse D_CHR.Equals(Chr(13))) Then
                    D_DAT = D_DAT & D_CHR
                    '全角
                    If System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(D_CHR) = 2 Then
                        D_BEM = D_BEM + 1
                    End If
                    D_BEM = D_BEM + 1
                    If (D_BEM >= P3) Then       '一行決定
                        If (D_BEM <> P3) Then
                            D_DAT = Left(D_DAT, Len(D_DAT) - 1)
                        End If
                        If (D_LIN = P2) Then    '取得したい行
                            D_FND = True
                            Exit For
                        End If
                        D_LIN = D_LIN + 1
                        If (D_BEM = P3) Then
                            D_DAT = ""
                            D_BEM = 0
                        Else
                            D_DAT = D_CHR
                            D_BEM = 2
                        End If
                    End If
                    D_BFR_CR = False
                Else
                    If D_BFR_CR Then
                        D_BFR_CR = False
                    Else                                '一行決定
                        D_BFR_CR = True
                        If (D_LIN = P2) Then        '取得したい行
                            D_FND = True
                            Exit For
                        End If
                        D_LIN = D_LIN + 1
                        D_DAT = ""
                        D_BEM = 0
                    End If
                End If
            Next
            If (Not D_FND) AndAlso (D_LIN <> P2) Then
                GoTo SUB_EXIT
            End If
            '
            D_RTN = D_DAT
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            '
        End Try
SUB_EXIT:
        FNC_GET_LIN = D_RTN
        Exit Function
    End Function

    '**************************************************************************************************************
    '*
    '*  処理概要：数値 四捨五入 関数
    '*
    '*  引数　　：1.対象数値
    '*   		  2.処理対象小数点以下桁
    '*
    '*  戻り値　：変換後数値
    '*
    '**************************************************************************************************************
    Public Shared Function FNC_CNF_NUM(ByVal P1 As Decimal, ByVal P2 As Integer) As Decimal
        Try
            Dim t As Decimal
            t = 10 ^ Math.Abs(P2)
            If P2 > 0 Then
                FNC_CNF_NUM = Int(P1 * t + 0.5) / t
            Else
                FNC_CNF_NUM = Int(P1 / t + 0.5) * t
            End If
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Function
    End Function

    '**************************************************************************************************************
    '*
    '*  処理概要：事業所別ﾌｫｰﾑ背景色変更
    '*
    '*  引数　　：
    '*
    '*  戻り値　：
    '*
    '**************************************************************************************************************
    Public Shared Function FNC_FRM_CLR(ByRef P1 As Object)
        Try
            Select Case C_COM_COD
                Case 1 : P1.BackColor = C_COM_CLR_001
                Case 2 : P1.BackColor = C_COM_CLR_002
                    'Case 2 : P1.BackColor = Cns_COM.C_COM_CLR_002
                    'Case 3 : P1.BackColor = Cns_COM.C_COM_CLR_003
                Case 4 : P1.BackColor = C_COM_CLR_004
                Case 5 : P1.BackColor = C_COM_CLR_005
                    '
                    '▼2017.11.06
                Case 6 : P1.BackColor = C_COM_CLR_006
                Case 7 : P1.BackColor = C_COM_CLR_007
            End Select
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Function
    End Function

    '**************************************************************************************************************
    '*
    '*  処理概要：ｱｲｺﾝ初期設定
    '*
    '*  引数　　：
    '*
    '*  戻り値　：
    '*
    '**************************************************************************************************************
    Public Shared Sub FNC_ICO_INT()
        Try
            C_ICO_FIL(0) = System.Configuration.ConfigurationManager.AppSettings("ICO_FIL01")
            C_ICO_FIL(1) = System.Configuration.ConfigurationManager.AppSettings("ICO_FIL02")
            C_ICO_FIL(2) = System.Configuration.ConfigurationManager.AppSettings("ICO_FIL03")
            C_ICO_FIL(3) = System.Configuration.ConfigurationManager.AppSettings("ICO_FIL04")
            C_ICO_FIL(4) = System.Configuration.ConfigurationManager.AppSettings("ICO_FIL05")
            C_ICO_FIL(5) = System.Configuration.ConfigurationManager.AppSettings("ICO_FIL06")
            C_ICO_FIL(6) = System.Configuration.ConfigurationManager.AppSettings("ICO_FIL06")
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

    '**************************************************************************************************************
    '*
    '*  処理概要：ｱｲｺﾝ設定
    '*
    '*  引数　　：
    '*
    '*  戻り値　：
    '*
    '**************************************************************************************************************
    Public Shared Sub FNC_SET_ICO(ByRef P1 As Object)
        '
        Dim D_ICO As System.Drawing.Icon = Nothing
        '
        Try
            If utl_Com.C_COM_COD = 0 Then GoTo EXIT_FUNTION
            If C_ICO_FIL(utl_Com.C_COM_COD - 1).Equals("") Then GoTo EXIT_FUNTION
            '
            CType(P1, System.Windows.Forms.Form).Icon = New System.Drawing.Icon(Application.StartupPath & "\" & C_ICO_FIL(utl_Com.C_COM_COD - 1))
            '
            'ﾊﾞｰｼﾞｮﾝ情報追加
            P1.Text &= "／" & C_APP_VER & C_APP_UPD
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub
    '
    '*********************************************************************************************************
    '*
    '*  処理概要：FB総合振込ﾌｧｲﾙ作成
    '*
    '*  引数　　：1.ﾃﾞｰﾀｾｯﾄ
    '*            2.種別(支払/交通費/支社送金)
    '* 
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_FNB_FIL(ByRef P1 As DataSet, ByVal P2 As String) As Boolean
        '
        Dim D_RTN As Boolean = False
        Dim I_HDR As Integer = 0
        Dim I_DTL As Integer = 0
        Dim D_DAT As String = ""
        Dim D_仕向銀行コード As String = ""
        Dim D_仕向銀行支店コード As String = ""
        Dim D_COM_SIN As String = ""
        Dim D_FB_DIR As String = System.Configuration.ConfigurationManager.AppSettings("FB_PTH01")
        Dim D_FB_FIL As String = System.Configuration.ConfigurationManager.AppSettings("FB_FIL01")
        Dim D_STM As Stream
        Dim D_STM_WIT As StreamWriter
        '
        'Dim D_FB_BAK_DIR As String = System.Configuration.ConfigurationSettings.AppSettings("FB_BAK_PTH01")
        '
        Try
            Select Case utl_Com.C_COM_COD
                Case 1 : D_COM_SIN = "STK"
                Case 2 : D_COM_SIN = "STT"
                Case 4 : D_COM_SIN = "KST"
                Case 5 : D_COM_SIN = "STS"
                Case Else : D_COM_SIN = "XXX"
            End Select
            '
            utl_Com.P_FRM_WIT.FNC_SET_MSG(P2 & "ＦＢ総合振込ﾃﾞｰﾀ作成中")
            '
            '保存先作成
            If Not Directory.Exists(D_FB_DIR) Then Directory.CreateDirectory(D_FB_DIR)
            '
            If P1.Tables.Count <> 0 Then
                If P1.Tables(0).Rows.Count > 0 Then
                    For I_HDR = 0 To P1.Tables(0).Rows.Count - 1 Step 1
                        '
                        D_仕向銀行コード = CStr(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("銀行コード"), ""))
                        D_仕向銀行支店コード = CStr(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("支店コード"), ""))
                        '
                        D_STM = File.Open(D_FB_DIR & "\" & D_FB_FIL & P2 & "_" & D_COM_SIN & "_" & Format(CInt(D_仕向銀行コード), "0000") & "_" & Format(CInt(D_仕向銀行支店コード), "000") & "_" & Format(Now(), "yyMMdd_HHmmss") & C_FIL_FNB_EXN,
                                          FileMode.Create, FileAccess.ReadWrite, FileShare.None)
                        D_STM_WIT = New StreamWriter(D_STM, System.Text.Encoding.Default)
                        '
                        '■ﾍｯﾀﾞﾚｺｰﾄﾞ作成
                        D_DAT = "1" 'データ区分(1)
                        D_DAT = D_DAT & "21" '種別コード(2)
                        D_DAT = D_DAT & "0" 'コード区分(1)
                        D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("振込依頼人コード"), "0"), "0", 10, 2) '振込依頼人コード(10)
                        D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("振込依頼人名"), ""), Space(1), 40, 1) '振込依頼人名(40)
                        D_DAT = D_DAT & Format(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("振込日"), ""), "MMdd") '振込日(4)
                        D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("銀行コード"), "0"), "0", 4, 2) '銀行コード(4)
                        D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("銀行名"), ""), Space(1), 15, 1) '銀行名(15)
                        D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("支店コード"), "0"), "0", 3, 2) '支店コード(3)
                        D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("支店名"), ""), Space(1), 15, 1) '支店名(15)
                        D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("科目"), "0"), "0", 1, 2) '科目(1)
                        D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(0).Rows(I_HDR).Item("口座番号"), "0"), "0", 7, 2) '口座番号(7)
                        D_DAT = D_DAT & Space(17) 'ダミー(7)
                        '
                        D_STM_WIT.WriteLine(D_DAT)
                        D_DAT = ""
                        '
                        '■ﾃﾞｰﾀﾚｺｰﾄﾞ作成
                        While D_仕向銀行コード.Equals(CStr(utl_Com.FNC_CNV_NUL(P1.Tables(1).Rows(I_DTL).Item("仕向銀行コード"), ""))) AndAlso
                              D_仕向銀行支店コード.Equals(CStr(utl_Com.FNC_CNV_NUL(P1.Tables(1).Rows(I_DTL).Item("仕向銀行支店コード"), "")))
                            D_DAT = "2" 'データ区分(1)
                            D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(1).Rows(I_DTL).Item("銀行コード"), "0"), "0", 4, 2) '銀行コード(4)
                            D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(1).Rows(I_DTL).Item("銀行名"), ""), Space(1), 15, 1) '銀行名(15)
                            D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(1).Rows(I_DTL).Item("支店コード"), "0"), "0", 3, 2) '支店コード(3)
                            D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(1).Rows(I_DTL).Item("支店名"), ""), Space(1), 15, 1) '支店名(15)
                            D_DAT = D_DAT & Space(4) '手形交換所番号(4)
                            D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(1).Rows(I_DTL).Item("科目"), "0"), "0", 1, 2) '科目(1)
                            D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(1).Rows(I_DTL).Item("口座番号"), "0"), "0", 7, 2) '口座番号(7)
                            D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(1).Rows(I_DTL).Item("受取人名"), ""), Space(1), 30, 1) '受取人名(30)
                            D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(Format(utl_Com.FNC_CNV_NUL(P1.Tables(1).Rows(I_DTL).Item("振込金額"), "0"), "0000000000"), "0", 10, 2) '振込金額(10)
                            D_DAT = D_DAT & "1" '新規コード(1)
                            D_DAT = D_DAT & Space(10) '顧客コード1(10)
                            D_DAT = D_DAT & Space(10) '顧客コード2(10)
                            D_DAT = D_DAT & "7" '振込指定区分(1)
                            D_DAT = D_DAT & Space(1) '識別コード(1)
                            D_DAT = D_DAT & Space(7) 'ダミー(7)
                            '
                            D_STM_WIT.WriteLine(D_DAT)
                            D_DAT = ""
                            '
                            I_DTL = (I_DTL + 1)
                            '
                            If I_DTL = P1.Tables(1).Rows.Count Then Exit While
                        End While
                        '
                        '■ﾄﾚｰﾗｰﾚｺｰﾄﾞ作成
                        D_DAT = "8" 'データ区分(1)
                        D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(utl_Com.FNC_CNV_NUL(P1.Tables(2).Rows(I_HDR).Item("合計件数"), "0"), "0", 6, 2) '合計件数(6)
                        D_DAT = D_DAT & utl_Com.FNC_BYT_DAT(Format(utl_Com.FNC_CNV_NUL(P1.Tables(2).Rows(I_HDR).Item("合計金額"), "0"), "000000000000"), "0", 12, 2) '合計金額(12)
                        D_DAT = D_DAT & Space(101) 'ダミー(101)
                        '
                        D_STM_WIT.WriteLine(D_DAT)
                        D_DAT = ""
                        '
                        '■ｴﾝﾄﾞﾚｺｰﾄﾞ作成
                        D_DAT = "9" 'データ区分(1)
                        D_DAT = D_DAT & Space(119) 'ダミー(119)
                        '
                        D_STM_WIT.WriteLine(D_DAT)
                        D_DAT = ""
                        '
                        D_STM_WIT.Flush()
                        D_STM_WIT.Close()
                        '
                        D_STM = Nothing
                        D_STM_WIT = Nothing
                    Next
                Else
                    '対象ﾃﾞｰﾀ無し
                    GoTo EXIT_FUNCTION
                End If
            Else
                'ﾃﾞｰﾀﾃｰﾌﾞﾙ無し
                GoTo EXIT_FUNCTION
            End If
            '
            D_RTN = True
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            utl_Com.P_FRM_WIT.Hide()
            '
            P1.Tables.Clear()
            P1 = Nothing
            '
            If Not (D_STM_WIT Is Nothing) Then
                D_STM_WIT.Flush()
                D_STM_WIT.Close()
                '
                D_STM_WIT = Nothing
            End If
            If Not (D_STM Is Nothing) Then
                D_STM = Nothing
            End If
        End Try
        '
EXIT_FUNCTION:
        FNC_FNB_FIL = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：機能別運用ﾚﾍﾞﾙ取得
    '*
    '*  引数　　：ﾌｫｰﾑ
    '* 
    '*  戻り値　：運用ﾚﾍﾞﾙ配列
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_GET_UES_LVL(ByRef P1 As Form)
        '
        Dim I As Integer = 0
        Dim D_RTN(7) As Integer
        Dim D_GET As Boolean = False
        Dim D_IDS As String = ""
        Dim D_STT_OPT As Integer
        Dim D_END_OPT As Integer
        '
        Try
            If IsNothing(P_LVL_TBL) Then GoTo EXIT_FUNCTION
            If P_LVL_TBL.Rows.Count <= 0 Then GoTo EXIT_FUNCTION
            'ID取得
            '例外判定
            If P1.Name.Equals("Frm_ER305_EX") OrElse
               P1.Name.Equals("Frm_SU003_OLD") OrElse
               P1.Name.Equals("Frm_CR700_OLD") Then
                D_STT_OPT = (P1.Name.IndexOf("_") + 1)
                D_END_OPT = P1.Name.Length
            Else
                D_STT_OPT = (P1.Name.IndexOf("_") + 1)
                D_END_OPT = P1.Name.IndexOf("_", D_STT_OPT)
            End If
            If D_END_OPT = -1 Then
                D_END_OPT = P1.Name.Length
            End If
            D_IDS = P1.Name.Substring(D_STT_OPT, (D_END_OPT - D_STT_OPT))
            '初期化
            For I = 0 To 6 Step 1
                D_RTN(I) = 0
            Next
            '
            '機能ID検索
            For I = 0 To P_LVL_TBL.Rows.Count - 1 Step 1
                If CStr(utl_Com.FNC_CNV_NUL(P_LVL_TBL.Rows(I).Item("機能ID"), "")).Equals(D_IDS) Then
                    D_GET = True
                    '機能権限属性出力
                    D_RTN(0) = utl_Com.FNC_CNV_NUL(P_LVL_TBL.Rows(I).Item("機能稼動区分"), 0)
                    D_RTN(1) = utl_Com.FNC_CNV_NUL(P_LVL_TBL.Rows(I).Item("新規処理区分"), 0)
                    D_RTN(2) = utl_Com.FNC_CNV_NUL(P_LVL_TBL.Rows(I).Item("修正処理区分"), 0)
                    D_RTN(3) = utl_Com.FNC_CNV_NUL(P_LVL_TBL.Rows(I).Item("削除処理区分"), 0)
                    D_RTN(4) = utl_Com.FNC_CNV_NUL(P_LVL_TBL.Rows(I).Item("検索処理区分"), 0)
                    D_RTN(5) = utl_Com.FNC_CNV_NUL(P_LVL_TBL.Rows(I).Item("出力処理区分"), 0)
                    D_RTN(6) = utl_Com.FNC_CNV_NUL(P_LVL_TBL.Rows(I).Item("更新処理区分"), 0)
                    '
                    '画面ﾀｲﾄﾙ設定
                    P1.Text = utl_Com.FNC_CNV_NUL(P_LVL_TBL.Rows(I).Item("機能名称"), "") & "／" & D_IDS
                    GoTo EXIT_FUNCTION
                End If
            Next
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        Finally
            '
        End Try
        '
EXIT_FUNCTION:
        If Not D_GET Then
            MsgBox("ID：" & D_IDS & "：" & P1.Text & vbCrLf & vbCrLf &
                   "該当する機能制御情報が存在しませんでした", MsgBoxStyle.Exclamation, "運用権限確認")
            D_RTN = Nothing
            P1.Close()
        End If
        '
        P_USE_LVL = D_RTN
        '
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：運用ﾚﾍﾞﾙﾁｪｯｸ(新規/修正/削除)
    '*
    '*  引数　　：処理ﾓｰﾄﾞ(A.新規、U.修正、D.削除)
    '*
    '*  戻り値　：True.許可、Fales.不許可
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_CHK_AUD_LVL(ByVal P1 As String) As Boolean
        '
        Dim D_RTN As Boolean = False
        Dim D_MSG As String = ""
        Dim D_IDS As Integer
        Try
            Select Case P1
                Case "A" : D_IDS = 1
                Case "U" : D_IDS = 2
                Case "D" : D_IDS = 3
            End Select
            If P_USE_LVL(D_IDS) = 1 Then
                D_RTN = True
            Else
                Select Case D_IDS
                    Case 1 : D_MSG = "新規 登録"
                    Case 2 : D_MSG = "修正 登録"
                    Case 3 : D_MSG = "削除 実行"
                End Select
                MsgBox(D_MSG & "処理は出来ません", MsgBoxStyle.Exclamation, "運用権限確認")
            End If
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_CHK_AUD_LVL = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：運用ﾚﾍﾞﾙﾁｪｯｸ(出力)
    '*
    '*  引数　　：1.出力先(1.プリンター、2.プレビュー(画面)、3.ＰＤＦ、4.ＣＳＶ)
    '*
    '*  戻り値　：True.許可、Fales.不許可
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_CHK_RPT_LVL(ByVal P1 As Integer) As Boolean
        '
        Dim D_RTN As Boolean = False
        Dim D_MSG As String = "出力先区分が間違っています"
        Dim D_IDS As Integer = 5 '出力
        '
        Try
            Select Case P1
                Case 1, 2, 3, 4
                    Select Case P_USE_LVL(D_IDS)
                        Case 1 : D_RTN = True
                        Case 2 : D_MSG = "出力処理は実行出来ません"
                        Case 3 : If Not (P1 = 3 OrElse P1 = 4) Then D_RTN = True
                        Case 4 : If Not (P1 = 4) Then D_RTN = True
                    End Select
            End Select
            '
            If Not D_RTN Then
                MsgBox(D_MSG, MsgBoxStyle.Exclamation, "運用権限確認")
            End If
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_CHK_RPT_LVL = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：出力先表記内容取得(運用ﾚﾍﾞﾙ制御)
    '*
    '*  引数　　：
    '*
    '*  戻り値　：出力先表記内容
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_RPT_LBL() As String
        '
        Dim D_RTN As String = "※出力処理が許可されていません"
        Dim D_IDS As Integer = 5 '出力
        '
        Try
            If P_USE_LVL(D_IDS) = 1 Then
                D_RTN = "1.プリンター、2.プレビュー、3.ＰＤＦ、4.ＣＳＶ"
                'ElseIf P_USE_LVL(D_IDS) = 2 Then
            ElseIf P_USE_LVL(D_IDS) = 3 Then
                D_RTN = "1.プリンター、2.プレビュー"
            ElseIf P_USE_LVL(D_IDS) = 4 Then
                D_RTN = "1.プリンター、2.プレビュー、3.ＰＤＦ"
            End If
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_RPT_LBL = D_RTN
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：運用ﾚﾍﾞﾙﾁｪｯｸ(更新)
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：True.許可、Fales.不許可
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_CHK_UPD_LVL() As Boolean
        '
        Dim D_RTN As Boolean = False
        Dim D_MSG As String = ""
        Dim D_IDS As Integer = 6 '更新
        '
        Try
            If P_USE_LVL(D_IDS) = 1 Then
                D_RTN = True
            End If
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_CHK_UPD_LVL = D_RTN
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：KEYｺｰﾄﾞ取得
    '*
    '*  引数　　：1.MOVEﾓｰﾄﾞ、2.LST_VIW.FocusedItem.Index、3.IDX増減FLG、4.KEY項目名
    '*
    '*  戻り値　：keyｺｰﾄﾞ
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_FND_XID(ByVal P1 As String, ByVal P2 As Integer, ByVal P3 As Integer, Optional ByVal P4 As String = "") As String
        '
        Dim D_RTN As String = ""
        '
        Try
            If utl_Com.P_FND_TBL.Rows.Count <> 0 Then
                '検索画面[戻るﾎﾞﾀﾝ]押下時、-1を返すため
                If P2 >= -1 Then
                    '
                    If P1 = "F" Then '【先頭】
                        D_RTN = utl_Com.P_FND_TBL.Rows(0).Item(P4)
                        utl_Com.P_FND_IDX = 0
                        '
                    ElseIf P1 = "P" Then '【前】
                        If P2 = 0 Then
                            D_RTN = utl_Com.P_FND_TBL.Rows(P2).Item(P4)
                        ElseIf P2 = -1 Then
                            D_RTN = utl_Com.P_FND_TBL.Rows(P2 + 1).Item(P4)
                        Else
                            D_RTN = utl_Com.P_FND_TBL.Rows(P2 - 1).Item(P4)
                            'IDX増減
                            If P3 = 1 Then
                                utl_Com.P_FND_IDX = (utl_Com.P_FND_IDX - 1)
                            End If
                        End If
                        '
                    ElseIf P1 = "N" Then '【次】
                        If P2 = (utl_Com.P_FND_TBL.Rows.Count - 1) Then
                            D_RTN = utl_Com.P_FND_TBL.Rows(P2).Item(P4)
                        Else
                            D_RTN = utl_Com.P_FND_TBL.Rows(P2 + 1).Item(P4)
                            'IDX増減
                            If P3 = 1 Then
                                utl_Com.P_FND_IDX = (utl_Com.P_FND_IDX + 1)
                            End If
                        End If
                        '
                    ElseIf P1 = "L" Then '【末尾】
                        D_RTN = utl_Com.P_FND_TBL.Rows(utl_Com.P_FND_TBL.Rows.Count - 1).Item(P4)
                        utl_Com.P_FND_IDX = utl_Com.P_FND_TBL.Rows.Count - 1
                    End If
                Else
                    D_RTN = ""
                End If
            Else
                D_RTN = ""
            End If
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_FND_XID = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾊﾟﾗﾒｰﾀ削除
    '*
    '*  引数　　：1.ﾌｧｲﾙ名
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_DLT_PRM(ByVal P1 As Integer, ByVal P2 As String)
        '
        Dim D_DIR As String = ""
        '
        Try
            Select Case P1
                Case 1 : D_DIR = C_DIR_FND
                Case 2 : D_DIR = C_DIR_RPT
                Case 3 : D_DIR = C_DIR_INP
                Case Else : GoTo EXIT_FUNCTION
            End Select
            '
            If File.Exists(Application.StartupPath & "\" & D_DIR & "\" & C_USR_IDS & "\" & P2 & ".ini") Then
                File.Delete(Application.StartupPath & "\" & D_DIR & "\" & C_USR_IDS & "\" & P2 & ".ini")
            Else
                GoTo EXIT_FUNCTION
            End If
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：XID調整
    '*
    '*  引数　　：1.ListView
    '*            2.DataTable
    '*            3.ｶﾝﾚﾝﾄｲﾝﾃﾞｯｸｽ
    '*
    '*  戻り値　：検索結果ﾒｯｾｰｼﾞ
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_FCS_XID(ByRef P1 As System.Windows.Forms.ListView, ByRef P2 As DataTable, ByRef P3 As Integer) As String
        '
        Dim D_RTN As String = ""
        '
        Try
            If P1.Columns(1).Text.Equals("XID") Then
                If P2.Rows.Count >= utl_Com.C_FND_CNT_1 Then
                    utl_Com.P_XID_FROM = utl_Com.FNC_CNV_NUL(P2.Rows(P2.Rows.Count - utl_Com.C_FND_CNT_1).Item("XID"), 0)
                    utl_Com.P_XID_TO = utl_Com.FNC_CNV_NUL(P2.Rows(P2.Rows.Count - 1).Item("XID"), 0)
                Else
                    utl_Com.P_XID_FROM = P2.Rows(0).Item("XID")
                    utl_Com.P_XID_TO = P2.Rows(0).Item("XID") - 1
                End If
                '
                '検索結果ﾒｯｾｰｼﾞ格納
                If P2.Rows(0).Item("TTL") > utl_Com.C_FND_CNT_1 Then
                    D_RTN = C_MSG_SRC_RST & CStr(utl_Com.P_XID_FROM) & "-" & CStr(P2.Rows(P2.Rows.Count - 1).Item("XID")) & "/" & P2.Rows(0).Item("TTL")
                Else
                    D_RTN = C_MSG_SRC_RST & CStr(P2.Rows.Count)
                End If
                '
                'ListView設定
                If P3 >= 0 Then
                    'ｽｸﾛｰﾙﾊﾞｰ先頭に表示
                    P1.EnsureVisible(P1.Items.Count - 1)
                    P1.EnsureVisible(P3)
                    'ListView選択/ﾌｫｰｶｽ
                    P1.Select()
                    P1.Items(P3).Selected = True
                    P1.Items(P3).Focused = True
                Else
                    'ListView選択/ﾌｫｰｶｽ
                    P1.Select()
                    P1.Items(0).Selected = True
                    P1.Items(0).Focused = True
                End If
            End If
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_FCS_XID = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：XID調整(3000件対応)
    '*
    '*  引数　　：1.ListView
    '*            2.DataTable
    '*            3.ｶﾝﾚﾝﾄｲﾝﾃﾞｯｸｽ
    '*
    '*  戻り値　：検索結果ﾒｯｾｰｼﾞ
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_FCS_XID_BIG(ByRef P1 As System.Windows.Forms.ListView, ByRef P2 As DataTable, ByRef P3 As Integer) As String
        '
        Dim D_RTN As String = ""
        '
        Try
            If P1.Columns(1).Text.Equals("XID") Then
                If P2.Rows.Count >= utl_Com.C_FND_CNT_BIG Then
                    utl_Com.P_XID_FROM = utl_Com.FNC_CNV_NUL(P2.Rows(P2.Rows.Count - utl_Com.C_FND_CNT_BIG).Item("XID"), 0)
                    utl_Com.P_XID_TO = utl_Com.FNC_CNV_NUL(P2.Rows(P2.Rows.Count - 1).Item("XID"), 0)
                Else
                    utl_Com.P_XID_FROM = P2.Rows(0).Item("XID")
                    utl_Com.P_XID_TO = P2.Rows(0).Item("XID") - 1
                End If
                '
                '検索結果ﾒｯｾｰｼﾞ格納
                If P2.Rows(0).Item("TTL") > utl_Com.C_FND_CNT_BIG Then
                    D_RTN = C_MSG_SRC_RST & CStr(utl_Com.P_XID_FROM) & "-" & CStr(P2.Rows(P2.Rows.Count - 1).Item("XID")) & "/" & P2.Rows(0).Item("TTL")
                Else
                    D_RTN = C_MSG_SRC_RST & CStr(P2.Rows.Count)
                End If
                '
                'ListView設定
                If P3 >= 0 Then
                    'ｽｸﾛｰﾙﾊﾞｰ先頭に表示
                    P1.EnsureVisible(P1.Items.Count - 1)
                    P1.EnsureVisible(P3)
                    'ListView選択/ﾌｫｰｶｽ
                    P1.Select()
                    P1.Items(P3).Selected = True
                    P1.Items(P3).Focused = True
                Else
                    'ListView選択/ﾌｫｰｶｽ
                    P1.Select()
                    P1.Items(0).Selected = True
                    P1.Items(0).Focused = True
                End If
            End If
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_FCS_XID_BIG = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾘｽﾄｾｯﾄ(前30/次30表示調整)
    '*
    '*  引数　　：1.MOVEﾓｰﾄﾞ
    '*            2.ListView
    '*            3.DataTable
    '*            4.ｶﾝﾚﾝﾄｲﾝﾃﾞｯｸｽ
    '*            5.ﾌｫｰｶｽｵﾌﾞｼﾞｪｸﾄ
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_STP_XID(ByVal P1 As String, ByRef P2 As System.Windows.Forms.ListView, ByRef P3 As DataTable, ByRef P4 As Integer, ByRef P5 As Object)
        '
        Try
            If (P3.Rows.Count <> 0) Then
                '
                '[XID]が存在する場合↓
                If P2.Columns(1).Text.Equals("XID") Then
                    If P3.Rows.Count > utl_Com.C_FND_CNT_2 Then
                        If P1.Equals("P") Then '【前】
                            If 0 < (P4 - utl_Com.C_FND_CNT_2) Then
                                'ｽｸﾛｰﾙﾊﾞｰ先頭に表示
                                P2.EnsureVisible(P2.Items.Count - 1)
                                P2.EnsureVisible(P4 - utl_Com.C_FND_CNT_2)
                                'ListView選択/ﾌｫｰｶｽ
                                P2.Select()
                                P2.Items(P4 - utl_Com.C_FND_CNT_2).Selected = True
                                P2.Items(P4 - utl_Com.C_FND_CNT_2).Focused = True
                                '
                                P4 = P4 - utl_Com.C_FND_CNT_2
                            Else
                                'ｽｸﾛｰﾙﾊﾞｰ先頭に表示
                                P2.EnsureVisible(P2.Items.Count - 1)
                                P2.EnsureVisible(0)
                                'ListView選択/ﾌｫｰｶｽ
                                P2.Select()
                                P2.Items(0).Selected = True
                                P2.Items(0).Focused = True
                                '
                                P4 = 0
                            End If
                        ElseIf P1.Equals("N") Then '【次】
                            If P3.Rows.Count <= (P4 + utl_Com.C_FND_CNT_2) Then
                                'ｽｸﾛｰﾙﾊﾞｰ先頭に表示
                                P2.EnsureVisible(P2.Items.Count - 1)
                                P2.EnsureVisible(P3.Rows.Count - 1)
                                'ListView選択/ﾌｫｰｶｽ
                                P2.Select()
                                P2.Items(P3.Rows.Count - 1).Selected = True
                                P2.Items(P3.Rows.Count - 1).Focused = True
                                '
                                P4 = P3.Rows.Count - 1
                            Else
                                'ｽｸﾛｰﾙﾊﾞｰ先頭に表示
                                P2.EnsureVisible(P2.Items.Count - 1)
                                P2.EnsureVisible(P4 + utl_Com.C_FND_CNT_2)
                                'ListView選択/ﾌｫｰｶｽ
                                P2.Select()
                                P2.Items(P4 + utl_Com.C_FND_CNT_2).Selected = True
                                P2.Items(P4 + utl_Com.C_FND_CNT_2).Focused = True
                                '
                                P4 = P4 + utl_Com.C_FND_CNT_2
                            End If
                        End If
                    End If
                End If
            Else
                P5.Focus()
            End If
            '
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：画像ﾃﾞｰﾀ表示
    '*
    '*  引数　　：1.復元ﾌｧｲﾙ名
    '*            2.画像ﾃﾞｰﾀ (Byte配列)
    '*            3.PictureBox
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_IMG_DSP(ByVal P1 As String, ByVal P2 As Byte(), ByRef P3 As System.Windows.Forms.PictureBox)
        '
        Try
            If Not Directory.Exists(Application.StartupPath & "\" & C_DIR_IMG) Then
                Directory.CreateDirectory(Application.StartupPath & "\" & C_DIR_IMG)
            End If
            '
            Dim D_FIL_STM As New FileStream(Application.StartupPath & "\" & C_DIR_IMG & "\" & P1, FileMode.OpenOrCreate, FileAccess.Write)
            '
            'D_FIL_STM.Write(P2, 0, UBound(P2))
            D_FIL_STM.Write(P2, 0, P2.Length)
            D_FIL_STM.Close()
            '
            Dim D_IMG_STM As New System.IO.FileStream(Application.StartupPath & "\" & C_DIR_IMG & "\" & P1, System.IO.FileMode.Open)
            '
            P3.Image = System.Drawing.Image.FromStream(D_IMG_STM)
            D_IMG_STM.Close()
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：画像ﾃﾞｰﾀ表示用ﾜｰｸﾌｫﾙﾀﾞｸﾘｱ
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_IMG_CLR()
        '
        Try
            If Not Directory.Exists(Application.StartupPath & "\" & C_DIR_IMG) Then GoTo EXIT_FUNCTION
            '
            Dim D_FIL As String() = System.IO.Directory.GetFiles(Application.StartupPath & "\" & C_DIR_IMG, "*.*")
            Dim D_ALT As New ArrayList
            '
            D_ALT.AddRange(D_FIL)
            '
            '処理対象ﾌｧｲﾙ無し
            If D_ALT.Count <> 0 Then
                Kill(Application.StartupPath & "\" & C_DIR_IMG & "\*.*")
            End If
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：画像IMG参照
    '*
    '*  引数　　：1.画像ファイル名
    '*            2.画像保存場所
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_IMG_REF(ByRef P1 As String, ByRef P2 As String, ByRef P3 As System.Windows.Forms.PictureBox)
        '
        Dim I As Integer = 0
        '
        Try
            Dim OpenFileDialog1 As New OpenFileDialog
            '
            OpenFileDialog1.Title = "画像IMG参照"
            OpenFileDialog1.InitialDirectory = IIf(P2.Equals(""), System.Configuration.ConfigurationManager.AppSettings("IMG_PTH") & "\POT_FAC", P2)
            OpenFileDialog1.Filter = "すべてのイメージファイル(*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico;*.emf;*.wmf)|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico;*.emf;*.wmf|ビットマップ ファイル(*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico)|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico|メタファイル(*.emf;*.wmf)|*.emf;*.wmf"
            OpenFileDialog1.ShowReadOnly = True
            '
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                P2 = OpenFileDialog1.FileName.Substring(0, OpenFileDialog1.FileName.LastIndexOf("\"))
                P1 = OpenFileDialog1.FileName.Substring(OpenFileDialog1.FileName.LastIndexOf("\") + 1)
                P3.Image = Image.FromFile(P2 & "\" & P1)
            End If
            '
            ' 破棄
            OpenFileDialog1.Dispose()
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：画像IMGﾀﾞｳﾝﾛｰﾄﾞ
    '*
    '*  引数　　：1.画像ファイル名
    '*            2.画像保存場所
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_IMG_DLD(ByVal P1 As String, ByVal P2 As String)
        '
        Try
            Dim SaveFileDialog1 As New SaveFileDialog
            '
            SaveFileDialog1.Title = "画像IMG保存"
            SaveFileDialog1.InitialDirectory = IIf(P2.Equals(""), System.Configuration.ConfigurationManager.AppSettings("IMG_PTH") & "\POT_FAC", P2)
            SaveFileDialog1.FileName = P1
            SaveFileDialog1.Filter = "すべてのイメージファイル(*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico;*.emf;*.wmf)|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico;*.emf;*.wmf|ビットマップ ファイル(*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico)|*.bmp;*.gif;*.jpg;*.jpeg;*.png;*.ico|メタファイル(*.emf;*.wmf)|*.emf;*.wmf"
            '
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                File.Copy(Application.StartupPath & "\" & C_DIR_IMG & "\" & P1, SaveFileDialog1.FileName, True)
            End If
            '
            ' 破棄
            SaveFileDialog1.Dispose()
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '**************************************************************************************************************
    '*
    '*  処理概要：社印初期設定
    '*
    '*  引数　　：
    '*
    '*  戻り値　：
    '*
    '**************************************************************************************************************
    Public Shared Sub FNC_PCT_INT()
        '
        Try
            C_PCT_FIL(0) = System.Configuration.ConfigurationManager.AppSettings("PCT_FIL01")
            C_PCT_FIL(1) = System.Configuration.ConfigurationManager.AppSettings("PCT_FIL02")
            C_PCT_FIL(2) = System.Configuration.ConfigurationManager.AppSettings("PCT_FIL03")
            C_PCT_FIL(3) = System.Configuration.ConfigurationManager.AppSettings("PCT_FIL04")
            C_PCT_FIL(4) = System.Configuration.ConfigurationManager.AppSettings("PCT_FIL05")
            C_PCT_FIL(5) = System.Configuration.ConfigurationManager.AppSettings("PCT_FIL06")
            C_PCT_FIL(6) = System.Configuration.ConfigurationManager.AppSettings("PCT_FIL06")
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

    '**************************************************************************************************************
    '*
    '*  処理概要：社印設定
    '*
    '*  引数　　：
    '*
    '*  戻り値　：
    '*
    '**************************************************************************************************************
    Public Shared Sub FNC_SET_PCT(ByRef P1 As Object)
        '
        Dim D_PCT As New GrapeCity.ActiveReports.SectionReportModel.Picture
        '
        Try
            If utl_Com.C_COM_COD = 0 Then GoTo EXIT_FUNTION
            If C_PCT_FIL(C_COM_COD - 1).Equals("") Then GoTo EXIT_FUNTION
            '
            CType(P1, GrapeCity.ActiveReports.SectionReportModel.Picture).Image = New System.Drawing.Bitmap(Application.StartupPath & "\" & C_PCT_FIL(utl_Com.C_COM_COD - 1))
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

End Class
