Imports System.IO
Imports System.Windows.Forms
Imports System.Drawing
Imports Microsoft.Office.Interop
Imports GrapeCity.ActiveReports
Imports utl_Com.utl_Com
Imports utl_Rdb.utl_Rdb
Imports cns_Com.cns_Com
'機能概要*****************************************************************************************************
'*
'*  処理概要：出力処理
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

'*  作成日　：2005/04/20
'*  作成者　：Ans赤沢(博)
'*
'*  更新日　：2007/04/09
'*  更新者　：ANS落合 FNC_SAV_CSVにCASE "Byte[]"を追記(画像ﾃﾞｰﾀを直接DBに格納管理する為)
'*
'*  更新日　：2007/07/09
'*  更新者　：軽部
'*　更新内容：ﾒﾓﾘﾘｿｰｽ不足の予防
'*
'*  更新日　：2007/08/17
'*  更新者　：軽部
'*  更新内容：ｽﾚｯﾄﾞで呼び出された際のﾒｯｾｰｼﾞﾎﾞｯｸｽ表示を呼出元へ委譲するように変更
'*
'*  更新日　：2007/11/19
'*  更新者　：軽部
'*  更新内容：ｽﾚｯﾄﾞで呼び出された際のﾀﾞｲｱﾛｸﾞﾎﾞｯｸｽ表示を呼出元へ委譲するように変更
'*
'*  更新日　：2008/01/17
'*  更新者　：ANS 永瀬
'*  更新内容：帳票直接印刷時もプリントダイアログを表示させるように変更
'*
'*  更新日　：2008/03/04
'*  更新者　：ANS 高木
'*  更新内容：表紙をマージして出力(PDF作成)する関数を追加
'*
'*　更新日　：2008/08/28
'*　更新者　：軽部
'*　更新内容：印刷、ﾌﾟﾚﾋﾞｭｰ時のCacheToDisk使用の引数を消去
'*
'*　更新日　：2009/02/04
'*　更新者　：西村
'*　更新内容：CR851-請求書出力用の帳票出力処理を追加
'*
'*　更新日　：2009/02/21
'*　更新者　：西村
'*　更新内容：CR851-請求書出力用のPDF出力処理を追加
'*
'*　更新日　：2009/03/02
'*　更新者　：ANS 永瀬
'*　更新内容：CR861-契約先一覧出力用のPDF出力処理を追加
'*
'*　更新日　：2009/04/06
'*　更新者　：ANS野木
'*　更新内容：JR001.準社員給与明細用の帳票・PDF出力処理を追加
'*
'*　更新日　：2009/10/21
'*　更新者　：ANS野木
'*　更新内容：CSV出力時、データに","が含まれていると正常に出力されないのを修正
'*
'*　更新日　：2010/06/21
'*　更新者　：村上
'*　更新内容：EXCELﾌｧｲﾙ作成/保存(HTML版)処理の追加
'*
'*　更新日　：2010/07/15
'*　更新者　：村上
'*　更新内容：PDFﾌｧｲﾙの自動保存対応
'*
'*　更新日　：2010/08/03
'*　更新者　：村上
'*　更新内容：EXCELﾌｧｲﾙ作成/保存(HTML版)処理で罫線なしに変更
'*
'*　更新日　：2010/08/25
'*　更新者　：村上
'*　更新内容：PDFﾌｧｲﾙの自動保存対応
'*　          EXCELﾌｧｲﾙ作成/保存処理の追加
'*
'*　更新日　：2010/12/07
'*　更新者　：村上
'*　更新内容：EXCEL2007(.xlsx)対応
'*
'*　更新日　：2012/11/09
'*　更新者　：村上
'*　更新内容：FNC_SAV_PDF　ｵﾌﾟｼｮﾝ追加(社員ｺｰﾄﾞ付加、結果ﾀﾞｲｱﾛｸﾞ)
'*　          FNC_SAV_CSV　ｵﾌﾟｼｮﾝ追加(保存ﾀﾞｲｱﾛｸﾞ、結果ﾀﾞｲｱﾛｸﾞ)
'*
'*　更新日　：2013/10/24
'*　更新者　：ANS野木
'*　更新内容：FNC_RPT_INT とじしろ、余白反転、両面印刷を追加
'*
'*　更新日　：2014/12/11
'*　更新者　：ANS宮川
'*　更新内容：PDFﾌｧｲﾙ作成/分割保存でエラーになるのを修正
'*
'*　更新日　：2017/09/20
'*　更新者　：村上
'*　更新内容：FNC_SAV_PDF_SR002(売掛金管理一覧表)追加
'*
'*　更新日　：2018/01/24
'*　更新者　：大場
'*　更新内容：FNC_SAV_CSV_JU002　前払CSVファイル用を追加

#End Region
'*
'*************************************************************************************************************
Public Class utl_Rpt

#Region " 宣言 "

    Private Shared _SynchronizingObject As System.ComponentModel.ISynchronizeInvoke

    Public Shared Property SynchronizingObject() As System.ComponentModel.ISynchronizeInvoke
        Get
            Return _SynchronizingObject
        End Get
        Set(ByVal P1 As System.ComponentModel.ISynchronizeInvoke)
            _SynchronizingObject = P1
        End Set
    End Property

    Delegate Function MsgBoxDelegate(
                                ByVal Prompt As Object,
                                ByVal Buttons As MsgBoxStyle,
                                ByVal Title As Object
                                ) As MsgBoxResult

    Delegate Function ShowDialogDelegate(
                                ) As System.Windows.Forms.DialogResult

#End Region

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾌﾟﾘﾝﾀｰ登録確認
    '*
    '*  引数　　：1.ﾌﾟﾘﾝﾀｰ名
    '*
    '*  戻り値　：True.存在、False.不在
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_PRT_CHK(ByVal P1 As String) As Boolean
        '
        Dim D_RTN As Boolean = False
        Dim I As Integer
        '
        Try
            For I = 0 To Printing.PrinterSettings.InstalledPrinters.Count - 1 Step 1
                If Printing.PrinterSettings.InstalledPrinters.Item(I).Equals(P1) Then
                    D_RTN = True
                    Exit For
                End If
            Next
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_PRT_CHK = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：帳票出力処理実行
    '*
    '*  引数　　：1.出力先(1.ﾌﾟﾘﾝﾀｰ,2.ﾌﾟﾚﾋﾞｭｰ)
    '*            2.実行モード(True.同期 , False.非同期)
    '*            3.ﾃｰﾀﾃｰﾌﾞﾙ
    '*            4.帳票コード
    '*            5.帳票ﾌｫｰﾑ
    '*
    '*            1.[ｵﾌﾟｼｮﾝ] 部数
    '*            2.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            3.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_RPT_EXC(ByVal P1 As Integer, ByVal P2 As Boolean, ByRef P3 As DataTable, ByVal P4 As String, ByRef P5 As GrapeCity.ActiveReports.SectionReport,
                                       Optional ByVal OP1 As Integer = 1,
                                       Optional ByVal OP2 As Boolean = False,
                                       Optional ByVal OP3 As Boolean = True) As Boolean
        '
        Dim D_RTN As Boolean = False
        '
        Try
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_RPT)
            ElseIf P1 = 2 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PRV)
            ElseIf P1 = 3 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
            End If
            '
            '帳票設定
            '
            FNC_RPT_INT(P4, P5, OP1, OP3)
            '
            P5.DataSource = P3
            P5.DataMember = P3.TableName
            P5.Run(P2)
            '
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_EXC)
                '
                'プリンターへ直接印刷(プリントダイアログを出す)
                '
                P5.Document.Print(True, False)
                '
                If OP2 Then P_FRM_WIT.Hide()
            ElseIf P1 = 2 Then
                'プレビュー
                Dim D_PRV As New Frm_Viewer
                '
                D_PRV.Viewer.Document = P5.Document
                '
                If OP2 Then P_FRM_WIT.Hide()
                '
                D_PRV.ShowDialog()
                D_PRV = Nothing
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_RPT_EXC = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：帳票出力処理実行(とじしろ準備)
    '*
    '*  引数　　：1.出力先(1.ﾌﾟﾘﾝﾀｰ,2.ﾌﾟﾚﾋﾞｭｰ)
    '*            2.実行モード(True.同期 , False.非同期)
    '*            3.ﾃｰﾀﾃｰﾌﾞﾙ
    '*            4.帳票コード
    '*            5.帳票ﾌｫｰﾑ
    '*
    '*            1.[ｵﾌﾟｼｮﾝ] 部数
    '*            2.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            3.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_RPT_EXC_PRE(ByVal P1 As Integer,
                                           ByVal P2 As Boolean,
                                           ByRef P3 As DataTable,
                                           ByVal P4 As String,
                                           ByRef P5 As GrapeCity.ActiveReports.SectionReport,
                                           Optional ByVal OP1 As Integer = 1,
                                           Optional ByVal OP2 As Boolean = False,
                                           Optional ByVal OP3 As Boolean = True) As Boolean
        '
        Dim D_RTN As Boolean = False
        '
        Try
            '帳票設定
            '
            FNC_RPT_INT(P4, P5, OP1, OP3)
            '
            P5.DataSource = P3
            P5.DataMember = P3.TableName
            P5.Run(P2)
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_RPT_EXC_PRE = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：PDFﾌｧｲﾙ作成/保存
    '*
    '*  引数　　：1.実行モード(True.同期 , False.非同期)
    '*            2.ﾃｰﾀﾃｰﾌﾞﾙ
    '*            3.帳票コード
    '*            4.帳票ﾌｫｰﾑ
    '*            5.ﾌｧｲﾙ名
    '* 
    '*            1.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ
    '*            2.[ｵﾌﾟｼｮﾝ] 既定ﾊﾟｽ
    '*            3.[ｵﾌﾟｼｮﾝ] 部数
    '*            4.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            5.[ｵﾌﾟｼｮﾝ] ﾚﾎﾟｰﾄ生成時のﾚﾎﾟｰﾄﾍﾟｰｼﾞの格納場所(0.ﾒﾓﾘ、1.ﾊｰﾄﾞﾃﾞｨｽｸ)
    '*            6.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*            7.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞ表示(True.表示、False.非表示[ﾃﾞｽｸﾄｯﾌﾟ(ｼﾝｸﾗｲｱﾝﾄはﾏｲﾄﾞｷｭﾒﾝﾄ)に自動保存])
    '*            8.[ｵﾌﾟｼｮﾝ] ﾌｧｲﾙ名に社員ｺｰﾄﾞ付加(True.あり、False.なし)
    '*            9.[ｵﾌﾟｼｮﾝ] 結果画面(True.表示、False.非表示)
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_PDF(ByVal P1 As Boolean,
                                       ByRef P2 As DataTable,
                                       ByVal P3 As String,
                                       ByRef P4 As GrapeCity.ActiveReports.SectionReport,
                                       ByVal P5 As String,
                                       Optional ByVal OP1 As String = "",
                                       Optional ByVal OP2 As String = "",
                                       Optional ByVal OP3 As Integer = 1,
                                       Optional ByVal OP4 As Boolean = False,
                                       Optional ByVal OP5 As Byte = 0,
                                       Optional ByVal OP6 As Boolean = True,
                                       Optional ByVal OP7 As Boolean = False,
                                       Optional ByVal OP8 As Boolean = True,
                                       Optional ByVal OP9 As Boolean = True) As Boolean
        Dim D_RTN As Boolean = False
        Dim D_RES As DialogResult
        Dim D_GET_IPS As String
        Dim D_SAV_DLG As New SaveFileDialog
        Dim D_PDF_EXP As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
        Dim strMyPath As String     'マイドキュメントのパス
        Dim strDskPath As String    'デスクトップのパス
        '
        Try
            '保存先取得
            '
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            D_SAV_DLG.FileName = P5.Replace("／" & C_APP_VER & C_APP_UPD, "")
            D_SAV_DLG.Filter = "PDF Files (*" & C_FIL_PDF_EXN & ")|*" & C_FIL_PDF_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            '
            '保存場所＆ファイル名取得
            If D_SAV_DLG.InitialDirectory.ToString.Equals("") Then
                '
                'マイドキュメントのパス
                '
                strMyPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
                '
                'デスクトップのパス
                '
                strDskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                '
                D_GET_IPS = FNC_GET_IPS()
                '
                '起動チェック
                If Not (D_GET_IPS.Equals("192.168.2.18") OrElse
                        D_GET_IPS.Equals("192.168.2.19") OrElse
                        D_GET_IPS.Equals("192.168.2.20") OrElse
                        D_GET_IPS.Equals("192.168.2.21") OrElse
                        D_GET_IPS.Equals("192.168.2.22") OrElse
                        D_GET_IPS.Equals("192.168.2.23") OrElse
                        D_GET_IPS.Equals("192.168.2.75") OrElse
                        D_GET_IPS.Equals("192.168.2.76") OrElse
                        D_GET_IPS.Equals("192.168.2.77") OrElse
                        D_GET_IPS.Equals("192.168.2.78") OrElse
                        D_GET_IPS.Equals("192.168.2.79")
                       ) OrElse D_GET_IPS.IndexOf("192.168.38.") > -1 Then   'ans環境用
                    '
                    'PC
                    '
                    D_SAV_DLG.FileName = strDskPath & "\" & IIf(OP8 = True, C_USR_IDS & "_", "") & P5.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_PDF_EXN
                Else
                    'シンクライアント
                    '
                    D_SAV_DLG.FileName = "\\stk-srv-12\MyDoc$\" & C_USR_IDS & "\マイ ドキュメント\" & IIf(OP8 = True, C_USR_IDS & "_", "") & P5.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_PDF_EXN
                End If
            End If
            '
            If OP7 = True Then
                If Not _SynchronizingObject Is Nothing Then
                    D_RES = _SynchronizingObject.Invoke(New ShowDialogDelegate(AddressOf D_SAV_DLG.ShowDialog), Nothing)
                Else
                    D_RES = D_SAV_DLG.ShowDialog()
                End If
            Else
                '保存ダイアログ非表示
                'Debug.WriteLine("★★★規定パスに保存★★★")
            End If
            '
            If D_RES = DialogResult.OK OrElse OP7 = False Then
                If OP4 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
                '
                '帳票設定
                FNC_RPT_INT(P3, P4, OP3, OP6)
                '
                P4.DataSource = P2
                P4.DataMember = P2.TableName
                '
                'ﾒﾓﾘﾘｿｰｽ不足を防止
                '
                If OP5 = 1 Then
                    P4.Document.CacheToDisk = True
                End If
                P4.Run(P1)
                '
                D_PDF_EXP.Export(P4.Document, D_SAV_DLG.FileName)
                OP2 = D_SAV_DLG.FileName.Trim
                '
                '結果ダイアログ
                If OP9 = True Then
                    If Not _SynchronizingObject Is Nothing Then
                        _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
                    Else
                        MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
                    End If
                End If
            End If
            '
            D_RTN = True
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            D_SAV_DLG = Nothing
            D_PDF_EXP = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_PDF = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：PDFﾌｧｲﾙ作成/分割保存
    '*
    '*  引数　　：1.実行モード(True.同期 , False.非同期)
    '*            2.ﾃｰﾀｾｯﾄ
    '*            3.帳票コード
    '*            4.帳票ﾌｫｰﾑ
    '*            5.ﾌｧｲﾙ名
    '*            6.コード項目名称
    '*            7.名称項目名称
    '* 
    '*            1.[ｵﾌﾟｼｮﾝ] 既定ﾊﾟｽ
    '*            2.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 部数
    '*            4.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            5.[ｵﾌﾟｼｮﾝ] 既定ﾌｧｲﾙ名
    '*            6.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_PDF_EXT(ByVal P1 As Boolean,
                                           ByRef P2 As DataSet,
                                           ByVal P3 As String,
                                           ByRef P4 As GrapeCity.ActiveReports.SectionReport,
                                           ByVal P5 As String,
                                           ByVal P6 As String,
                                           ByVal P7 As String,
                                           Optional ByVal OP1 As String = "",
                                           Optional ByVal OP2 As String = "",
                                           Optional ByVal OP3 As Integer = 1,
                                           Optional ByVal OP4 As Boolean = False,
                                           Optional ByVal OP5 As String = "",
                                           Optional ByVal OP6 As Boolean = True,
                                           Optional ByVal OP8 As Boolean = True) As Boolean
        Dim D_RTN As Boolean = False
        Dim I As Integer
        Dim D_RES As DialogResult
        Dim D_GET_IPS As String
        Dim D_FIL_NAM As String
        Dim D_SAV_DLG As New SaveFileDialog
        Dim D_PDF_EXP As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
        Dim strMyPath As String     'マイドキュメントのパス
        Dim strDskPath As String    'デスクトップのパス
        '
        Try
            '保存場所＆ファイル名取得
            '
            If D_SAV_DLG.InitialDirectory.ToString.Equals("") Then
                'マイドキュメントのパス
                '
                strMyPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
                '
                'デスクトップのパス
                '
                strDskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                '
                D_GET_IPS = FNC_GET_IPS()
                '
                '起動チェック
                If Not (D_GET_IPS.Equals("192.168.2.18") OrElse
                        D_GET_IPS.Equals("192.168.2.19") OrElse
                        D_GET_IPS.Equals("192.168.2.20") OrElse
                        D_GET_IPS.Equals("192.168.2.21") OrElse
                        D_GET_IPS.Equals("192.168.2.22") OrElse
                        D_GET_IPS.Equals("192.168.2.23") OrElse
                        D_GET_IPS.Equals("192.168.2.75") OrElse
                        D_GET_IPS.Equals("192.168.2.76") OrElse
                        D_GET_IPS.Equals("192.168.2.77") OrElse
                        D_GET_IPS.Equals("192.168.2.78") OrElse
                        D_GET_IPS.Equals("192.168.2.79")
                       ) OrElse D_GET_IPS.IndexOf("192.168.38.") > -1 Then   'ans環境用
                    'PC
                    D_SAV_DLG.FileName = strDskPath & "\" & IIf(OP8 = True, C_USR_IDS & "_", "") & P5.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_PDF_EXN
                Else
                    'シンクライアント
                    D_SAV_DLG.FileName = "\\stk-srv-12\MyDoc$\" & C_USR_IDS & "\マイ ドキュメント\" & IIf(OP8 = True, C_USR_IDS & "_", "") & P5.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_PDF_EXN
                End If
            End If
            '
            '保存先取得
            '
            If Not _SynchronizingObject Is Nothing Then
                D_RES = _SynchronizingObject.Invoke(New ShowDialogDelegate(AddressOf D_SAV_DLG.ShowDialog), Nothing)
            Else
                D_RES = D_SAV_DLG.ShowDialog()
            End If
            '
            If D_RES = DialogResult.OK Then
                If OP4 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF_EXT)
                '
                '帳票設定
                '
                FNC_RPT_INT(P3, P4, OP3, OP6)
                '
                For I = 0 To P2.Tables.Count - 1 Step 1
                    If P2.Tables(I).Rows.Count > 0 Then
                        P4.DataSource = P2.Tables(I)
                        P4.DataMember = P2.Tables(I).TableName
                        '
                        P4.Run(P1)
                        '
                        D_FIL_NAM = FNC_CNV_FIL_NAM(P5.Replace("／" & C_APP_VER & C_APP_UPD, "") & "_" & FNC_CNV_NUL(P2.Tables(I).Rows(0).Item(P6), "") & "_" & FNC_CNV_NUL(P2.Tables(I).Rows(0).Item(P7), ""))
                        D_PDF_EXP.Export(P4.Document, D_FIL_NAM & C_FIL_PDF_EXN)
                    End If
                Next
                OP2 = D_SAV_DLG.FileName.Trim
                '
                If Not _SynchronizingObject Is Nothing Then
                    _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
                Else
                    MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
                End If
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            D_SAV_DLG = Nothing
            D_PDF_EXP = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_PDF_EXT = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：帳票初期化
    '*
    '*  引数　　：1.帳票コード
    '*            2.帳票ﾌｫｰﾑ
    '*            
    '*            1.[ｵﾌﾟｼｮﾝ] 部数
    '*            2.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_RPT_INT(ByVal P1 As String,
                                       ByRef P2 As GrapeCity.ActiveReports.SectionReport,
                                       Optional ByVal OP1 As Integer = 1,
                                       Optional ByVal OP2 As Boolean = True) As Boolean
        Dim D_RTN As Boolean = False
        Dim D_SQL As String = ""
        Dim D_TBL As New DataTable
        Dim D_RDB As New utl_Rdb.utl_Rdb
        '
        Try
            If Not P1.Equals("") Then
                D_SQL = "SPC_SYS_RPT_INQ2 '" & P1 & "'"
                '
                D_TBL = FNC_GET_TBL(D_SQL)
            End If
            '
            'ｵﾌﾟｼｮﾝ部数設定
            '
            P2.Document.Printer.PrinterSettings.Copies = OP1
            '
            If D_TBL.Rows.Count > 0 Then
                '
                P2.Document.Name = FNC_CNV_NUL(D_TBL.Rows(0).Item("論理名称"), "")
                '
                'ﾌﾟﾘﾝﾀｰ存在確認
                If FNC_PRT_CHK(FNC_CNV_NUL(D_TBL.Rows(0).Item("デバイス名"), "")) Then
                    P2.Document.Printer.PrinterName = FNC_CNV_NUL(D_TBL.Rows(0).Item("デバイス名"), "")
                    P2.PageSettings.PaperKind = FNC_CNV_NUL(D_TBL.Rows(0).Item("用紙サイズ"), 0)
                    P2.PageSettings.Orientation = FNC_CNV_NUL(D_TBL.Rows(0).Item("用紙方向"), 0)
                    P2.PageSettings.PaperSource = FNC_CNV_NUL(D_TBL.Rows(0).Item("給紙方法"), 0)
                    P2.PageSettings.PaperWidth = FNC_CNV_NUL(D_TBL.Rows(0).Item("横幅"), 0)
                    P2.PageSettings.PaperHeight = FNC_CNV_NUL(D_TBL.Rows(0).Item("縦幅"), 0)
                    P2.PageSettings.Margins.Top = FNC_CNV_NUL(D_TBL.Rows(0).Item("余白上"), 0)
                    P2.PageSettings.Margins.Bottom = FNC_CNV_NUL(D_TBL.Rows(0).Item("余白下"), 0)
                    P2.PageSettings.Margins.Left = FNC_CNV_NUL(D_TBL.Rows(0).Item("余白左"), 0)
                    P2.PageSettings.Margins.Right = FNC_CNV_NUL(D_TBL.Rows(0).Item("余白右"), 0)
                    '
                    P2.PageSettings.MirrorMargins = IIf(FNC_CNV_NUL(D_TBL.Rows(0).Item("余白反転区分"), 0) = 1, True, False)
                    P2.PageSettings.Duplex = FNC_CNV_NUL(D_TBL.Rows(0).Item("両面印刷区分"), 0)
                    P2.PageSettings.Gutter = FNC_CNV_NUL(D_TBL.Rows(0).Item("とじしろ"), 0)
                Else
                    If OP2 Then FNC_SET_MGN(P2)
                End If
            Else
                If OP2 Then FNC_SET_MGN(P2)
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            D_TBL.Clear()
            D_TBL = Nothing
        End Try
EXIT_FUNCTION:
        FNC_RPT_INT = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：余白既定値設定
    '*
    '*  引数　　：1.帳票ﾌｫｰﾑ
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_SET_MGN(ByRef P1 As GrapeCity.ActiveReports.SectionReport)
        '
        Try
            P1.PageSettings.Margins.Top = IIf(P1.PageSettings.Margins.Top = 0, C_RPT_MGN_TOP, P1.PageSettings.Margins.Top)
            P1.PageSettings.Margins.Bottom = IIf(P1.PageSettings.Margins.Bottom = 0, C_RPT_MGN_BTM, P1.PageSettings.Margins.Bottom)
            P1.PageSettings.Margins.Left = IIf(P1.PageSettings.Margins.Left = 0, C_RPT_MGN_LFT, P1.PageSettings.Margins.Left)
            P1.PageSettings.Margins.Right = IIf(P1.PageSettings.Margins.Right = 0, C_RPT_MGN_RIT, P1.PageSettings.Margins.Right)
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            '
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：CSVﾌｧｲﾙ作成/保存
    '*
    '*  引数　　：1.ﾃﾞｰﾀﾃﾌﾞﾙ
    '*            2.ﾌｧｲﾙ名
    '* 
    '*            1.[ｵﾌﾟｼｮﾝ] 既定ﾊﾟｽ
    '*            2.[ｵﾌﾟﾘｮﾝ] ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            4.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞ表示(True.表示、False.非表示[ﾃﾞｽｸﾄｯﾌﾟ(ｼﾝｸﾗｲｱﾝﾄはﾏｲﾄﾞｷｭﾒﾝﾄ)に自動保存])
    '*            5.[ｵﾌﾟｼｮﾝ] 結果画面(True.表示、False.非表示)
    '*            6.[ｵﾌﾟｼｮﾝ] 保存場所指定(True.指定、False.指定なし)
    '*            7.[ｵﾌﾟｼｮﾝ] 保存場所ﾊﾟｽ
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_CSV_JU002(ByRef P1 As DataTable,
                                             ByVal P2 As String,
                                             Optional ByVal OP1 As String = "",
                                             Optional ByVal OP2 As String = "",
                                             Optional ByVal OP3 As Boolean = False,
                                             Optional ByVal OP4 As Boolean = True,
                                             Optional ByVal OP5 As Boolean = True,
                                             Optional ByVal OP6 As Boolean = True,
                                             Optional ByVal OP7 As String = "") As Boolean
        '
        Dim I As Integer
        Dim X As Integer
        Dim D_RTN As Boolean = False
        Dim D_RES As DialogResult
        Dim D_GET_IPS As String
        Dim D_DAT_HED As String = ""
        Dim D_DAT_DTL As String = ""
        Dim D_SAV_DLG As New SaveFileDialog
        Dim strMyPath As String     'マイドキュメントのパス
        Dim strDskPath As String    'デスクトップのパス
        '
        Try
            'ﾌｧｲﾙ保存
            '
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            D_SAV_DLG.FileName = P2.Replace("／" & C_APP_VER & C_APP_UPD, "")
            D_SAV_DLG.Filter = "CSV Files (*" & C_FIL_CSV_EXN & ")|*" & C_FIL_CSV_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            '
            '保存場所＆ファイル名取得
            If D_SAV_DLG.InitialDirectory.ToString.Equals("") Then
                'マイドキュメントのパス
                strMyPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
                'デスクトップのパス
                strDskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                '
                D_GET_IPS = FNC_GET_IPS()
                '
                '起動チェック
                If Not (D_GET_IPS.Equals("192.168.2.18") OrElse
                        D_GET_IPS.Equals("192.168.2.19") OrElse
                        D_GET_IPS.Equals("192.168.2.20") OrElse
                        D_GET_IPS.Equals("192.168.2.21") OrElse
                        D_GET_IPS.Equals("192.168.2.22") OrElse
                        D_GET_IPS.Equals("192.168.2.23") OrElse
                        D_GET_IPS.Equals("192.168.2.75") OrElse
                        D_GET_IPS.Equals("192.168.2.76") OrElse
                        D_GET_IPS.Equals("192.168.2.77") OrElse
                        D_GET_IPS.Equals("192.168.2.78") OrElse
                        D_GET_IPS.Equals("192.168.2.79")
                       ) OrElse D_GET_IPS.IndexOf("192.168.38.") > -1 Then   'ans環境用
                    'PC
                    '
                    D_SAV_DLG.FileName = strDskPath & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_CSV_EXN

                    If OP6 = True Then
                        D_SAV_DLG.FileName = OP7 & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_CSV_EXN
                    End If
                Else
                    '
                    'シンクライアント
                    '
                    D_SAV_DLG.FileName = "\\stk-srv-12\MyDoc$\" & C_USR_IDS & "\マイ ドキュメント\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_CSV_EXN
                End If
            End If
            '
            '保存ダイアログ
            If OP4 = True Then
                If Not _SynchronizingObject Is Nothing Then
                    D_RES = _SynchronizingObject.Invoke(New ShowDialogDelegate(AddressOf D_SAV_DLG.ShowDialog), Nothing)
                Else
                    D_RES = D_SAV_DLG.ShowDialog()
                End If
            Else
                '保存ダイアログ非表示
                'Debug.WriteLine("★★★指定パスに保存　ＣＳＶ★★★")
            End If
            '
            If D_RES = DialogResult.OK OrElse OP4 = False Then
                If OP3 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_CSV)
                '
                'ﾌｧｲﾙ作成
                '
                If Not Directory.Exists(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_CSV) Then
                    Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_CSV)
                End If
                '
                Dim D_STM As Stream = File.Open(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_CSV & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), FileMode.Create, FileAccess.ReadWrite, FileShare.None)
                Dim D_STM_WIT As New StreamWriter(D_STM, System.Text.Encoding.Default)
                For I = 0 To P1.Columns.Count - 1 Step 1
                    '["]はつけない
                    D_DAT_HED = D_DAT_HED & "" & P1.Columns(I).Caption & ","
                Next
                '
                D_STM_WIT.WriteLine(Mid(D_DAT_HED, 1, D_DAT_HED.Length - 1))
                I = 0
                For I = 0 To P1.Rows.Count - 1 Step 1
                    For X = 0 To P1.Columns.Count - 1 Step 1
                        Select Case P1.Columns(X).DataType.Name
                            '["]はつけない
                            '
                            Case "Byte", "Int16", "Int32", "Int64", "SByte", "UInt16", "UInt32", "UInt64", "Decimal", "Double", "Single"
                                D_DAT_DTL = D_DAT_DTL & FNC_CNV_NUL(P1.Rows(I).Item(X), "0") & ","
                            '
                            Case "DateTime", "TimeSpan"
                                D_DAT_DTL = D_DAT_DTL & "" & Format(FNC_CNV_NUL(P1.Rows(I).Item(X), Nothing), "yyyy/MM/dd hh:mm:ss") & ","
                            '
                            Case "Byte[]"
                                '
                                '空で出力
                                '
                                D_DAT_DTL = D_DAT_DTL & "" & ","
                                '
                            Case Else
                                D_DAT_DTL = D_DAT_DTL & "" & FNC_CNV_NUL(P1.Rows(I).Item(X), "") & ","
                        End Select
                    Next
                    D_STM_WIT.WriteLine(Mid(D_DAT_DTL, 1, D_DAT_DTL.Length - 1))
                    D_DAT_DTL = ""
                Next
                D_STM_WIT.Flush()
                D_STM_WIT.Close()
                '
                D_STM = Nothing
                D_STM_WIT = Nothing
                '
                FileCopy(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_CSV & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), D_SAV_DLG.FileName)
                OP2 = D_SAV_DLG.FileName.Trim
                '
                Kill(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_CSV & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""))
                '
                '結果ダイアログ
                If OP5 = True Then
                    If Not _SynchronizingObject Is Nothing Then
                        _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
                    Else
                        MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
                    End If
                End If
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            If OP3 Then P_FRM_WIT.Hide()
            '
            D_SAV_DLG = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_CSV_JU002 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：CSVﾌｧｲﾙ作成/保存
    '*
    '*  引数　　：1.ﾃﾞｰﾀﾃﾌﾞﾙ
    '*            2.ﾌｧｲﾙ名
    '* 
    '*            1.[ｵﾌﾟｼｮﾝ] 既定ﾊﾟｽ
    '*            2.[ｵﾌﾟﾘｮﾝ] ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            4.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞ表示(True.表示、False.非表示[ﾃﾞｽｸﾄｯﾌﾟ(ｼﾝｸﾗｲｱﾝﾄはﾏｲﾄﾞｷｭﾒﾝﾄ)に自動保存])
    '*            5.[ｵﾌﾟｼｮﾝ] 結果画面(True.表示、False.非表示)
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_CSV(ByRef P1 As DataTable,
                                       ByVal P2 As String,
                                       Optional ByVal OP1 As String = "",
                                       Optional ByVal OP2 As String = "",
                                       Optional ByVal OP3 As Boolean = False,
                                       Optional ByVal OP4 As Boolean = True,
                                       Optional ByVal OP5 As Boolean = True) As Boolean
        Dim I As Integer
        Dim X As Integer
        Dim D_RTN As Boolean = False
        Dim D_RES As DialogResult
        Dim D_GET_IPS As String
        Dim D_DAT_HED As String = ""
        Dim D_DAT_DTL As String = ""
        Dim D_SAV_DLG As New SaveFileDialog
        Dim strMyPath As String     'マイドキュメントのパス
        Dim strDskPath As String    'デスクトップのパス
        '
        Try
            'ﾌｧｲﾙ保存
            '
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            D_SAV_DLG.FileName = P2.Replace("／" & C_APP_VER & C_APP_UPD, "")
            D_SAV_DLG.Filter = "CSV Files (*" & C_FIL_CSV_EXN & ")|*" & C_FIL_CSV_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            '
            '保存場所＆ファイル名取得
            '
            If D_SAV_DLG.InitialDirectory.ToString.Equals("") Then
                'マイドキュメントのパス
                '
                strMyPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
                '
                'デスクトップのパス
                '
                strDskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                '
                D_GET_IPS = FNC_GET_IPS()
                '
                '起動チェック
                '
                If Not (D_GET_IPS.Equals("192.168.2.18") OrElse
                        D_GET_IPS.Equals("192.168.2.19") OrElse
                        D_GET_IPS.Equals("192.168.2.20") OrElse
                        D_GET_IPS.Equals("192.168.2.21") OrElse
                        D_GET_IPS.Equals("192.168.2.22") OrElse
                        D_GET_IPS.Equals("192.168.2.23") OrElse
                        D_GET_IPS.Equals("192.168.2.75") OrElse
                        D_GET_IPS.Equals("192.168.2.76") OrElse
                        D_GET_IPS.Equals("192.168.2.77") OrElse
                        D_GET_IPS.Equals("192.168.2.78") OrElse
                        D_GET_IPS.Equals("192.168.2.79")
                       ) OrElse D_GET_IPS.IndexOf("192.168.38.") > -1 Then   'ans環境用
                    'PC
                    '
                    D_SAV_DLG.FileName = strDskPath & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_CSV_EXN
                Else
                    '
                    'シンクライアント
                    '
                    D_SAV_DLG.FileName = "\\stk-srv-12\MyDoc$\" & C_USR_IDS & "\マイ ドキュメント\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_CSV_EXN
                End If
            End If
            '
            '保存ダイアログ
            If OP4 = True Then
                If Not _SynchronizingObject Is Nothing Then
                    D_RES = _SynchronizingObject.Invoke(New ShowDialogDelegate(AddressOf D_SAV_DLG.ShowDialog), Nothing)
                Else
                    D_RES = D_SAV_DLG.ShowDialog()
                End If
            Else
                '保存ダイアログ非表示
                'Debug.WriteLine("★★★規定パスに保存　ＣＳＶ★★★")
            End If
            '
            If D_RES = DialogResult.OK OrElse OP4 = False Then
                '
                If OP3 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_CSV)
                '
                'ﾌｧｲﾙ作成
                '
                If Not Directory.Exists(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_CSV) Then
                    Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_CSV)
                End If
                '
                Dim D_STM As Stream = File.Open(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_CSV & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), FileMode.Create, FileAccess.ReadWrite, FileShare.None)
                Dim D_STM_WIT As New StreamWriter(D_STM, System.Text.Encoding.Default)
                '
                For I = 0 To P1.Columns.Count - 1 Step 1
                    D_DAT_HED = D_DAT_HED & """" & P1.Columns(I).Caption & ""","
                Next
                '
                D_STM_WIT.WriteLine(Mid(D_DAT_HED, 1, D_DAT_HED.Length - 1))
                I = 0
                For I = 0 To P1.Rows.Count - 1 Step 1
                    For X = 0 To P1.Columns.Count - 1 Step 1
                        Select Case P1.Columns(X).DataType.Name
                            Case "Byte", "Int16", "Int32", "Int64", "SByte", "UInt16", "UInt32", "UInt64", "Decimal", "Double", "Single"
                                D_DAT_DTL = D_DAT_DTL & FNC_CNV_NUL(P1.Rows(I).Item(X), "0") & ","
                                '
                            Case "DateTime", "TimeSpan"
                                D_DAT_DTL = D_DAT_DTL & """" & Format(FNC_CNV_NUL(P1.Rows(I).Item(X), Nothing), "yyyy/MM/dd hh:mm:ss") & ""","
                                '
                            Case "Byte[]"
                                '
                                '空で出力
                                '
                                D_DAT_DTL = D_DAT_DTL & """" & ""","
                                '
                            Case Else
                                D_DAT_DTL = D_DAT_DTL & """" & FNC_CNV_NUL(P1.Rows(I).Item(X), "").Replace("""", """""") & ""","
                                '
                        End Select
                    Next
                    D_STM_WIT.WriteLine(Mid(D_DAT_DTL, 1, D_DAT_DTL.Length - 1))
                    D_DAT_DTL = ""
                Next
                D_STM_WIT.Flush()
                D_STM_WIT.Close()
                '
                D_STM = Nothing
                D_STM_WIT = Nothing
                '
                FileCopy(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_CSV & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), D_SAV_DLG.FileName)
                OP2 = D_SAV_DLG.FileName.Trim
                '
                Kill(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_CSV & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""))
                '
                '結果ダイアログ
                If OP5 = True Then
                    If Not _SynchronizingObject Is Nothing Then
                        _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
                    Else
                        MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
                    End If
                End If
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            If OP3 Then P_FRM_WIT.Hide()
            '
            D_SAV_DLG = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_CSV = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：帳票情報表示(既定)
    '*
    '*  引数　　：1.ﾌｫｰﾑ
    '*            2.帳票ﾌｫｰﾑ
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_DSP_IFO_DEF(ByRef P1 As Object, ByRef P2 As GrapeCity.ActiveReports.SectionReport)
        '
        Try
            P1.TXT_帳票コード.Text = ""
            P1.DSP_帳票名.Text = P2.Document.Name
            P1.DSP_プリンター名.Text = "【通常使うﾌﾟﾘﾝﾀｰ】" & P2.Document.Printer.PrinterName
            P1.DSP_IPアドレス.Text = ""
            P1.DSP_設置支社.Text = C_COM_NAM_SRT & ":" &
                                   C_BNC_NAM_SRT
            P1.DSP_用紙属性.Text = "不明 / " &
                                   P2.PageSettings.PaperKind.ToString & " / " &
                                   IIf(P2.PageSettings.Orientation = 1, "縦", "横") & " / " &
                                   IIf(P2.PageSettings.DefaultPaperSource, "既定", P2.PageSettings.PaperSource.ToString)
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：帳票情報読込
    '*
    '*  引数　　：1.ﾌｫｰﾑ
    '*            2.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            3.ｲﾝﾃﾞｯｸｽ
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_DSP_IFO(ByRef P1 As Object, ByRef P2 As DataTable, ByVal P3 As Integer)
        '
        Try
            P1.TXT_帳票コード.Text = FNC_CNV_NUL(P2.Rows(P3).Item("プリンターコード"), "")
            P1.DSP_帳票名.Text = FNC_CNV_NUL(P2.Rows(P3).Item("論理名称"), "")
            P1.DSP_プリンター名.Text = FNC_CNV_NUL(P2.Rows(P3).Item("デバイス名"), "")
            P1.DSP_IPアドレス.Text = FNC_CNV_NUL(P2.Rows(P3).Item("IPアドレス"), "")
            P1.DSP_設置支社.Text = FNC_CNV_NUL(P2.Rows(P3).Item("支社名"), "")
            P1.DSP_用紙属性.Text = FNC_CNV_NUL(P2.Rows(P3).Item("プリンター区分名"), "") & " / " &
                                   FNC_CNV_NUL(P2.Rows(P3).Item("用紙サイズ_内容"), "") & " / " &
                                   FNC_CNV_NUL(P2.Rows(P3).Item("用紙方向_内容"), "") & " / " &
                                   FNC_CNV_NUL(P2.Rows(P3).Item("給紙方法_内容"), "")
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾌﾟﾘﾝﾀｰ設定値取得
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：設定値配列
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_GET_PRT() As Object
        '
        Dim D_RTN(13) As Object
        Dim D_PRT_DLG As New PageSetupDialog
        '
        Try
            If Printing.PrinterSettings.InstalledPrinters.Count <= 0 Then
                MsgBox("1台もﾌﾟﾘﾝﾀｰが登録されていません。", MsgBoxStyle.Exclamation, "ﾌﾟﾘﾝﾀｰ未登録")
                GoTo EXIT_FUNCTION
            End If
            '
            D_PRT_DLG.PageSettings = New Printing.PageSettings
            D_PRT_DLG.PrinterSettings = New Printing.PrinterSettings
            '
            If D_PRT_DLG.ShowDialog() = DialogResult.OK Then
                D_RTN(0) = D_PRT_DLG.PrinterSettings.PrinterName
                D_RTN(1) = D_PRT_DLG.PageSettings.PaperSize.Kind
                D_RTN(2) = D_PRT_DLG.PageSettings.PaperSize.PaperName
                D_RTN(3) = IIf(D_PRT_DLG.PageSettings.Landscape, 2, 1)
                D_RTN(4) = IIf(D_RTN(3) = 1, "縦", "横")
                D_RTN(5) = D_PRT_DLG.PageSettings.PaperSource.Kind
                D_RTN(6) = D_PRT_DLG.PageSettings.PaperSource.SourceName
                D_RTN(7) = D_PRT_DLG.PageSettings.PaperSize.Width / 100
                D_RTN(8) = D_PRT_DLG.PageSettings.PaperSize.Height / 100
                D_RTN(9) = D_PRT_DLG.PageSettings.Margins.Top / 100
                D_RTN(10) = D_PRT_DLG.PageSettings.Margins.Bottom / 100
                D_RTN(11) = D_PRT_DLG.PageSettings.Margins.Left / 100
                D_RTN(12) = D_PRT_DLG.PageSettings.Margins.Right / 100
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            D_PRT_DLG.Dispose()
            D_PRT_DLG = Nothing
        End Try
EXIT_FUNCTION:
        FNC_GET_PRT = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：被扶養者異動届出力
    '*
    '*  引数　　：1.出力先(1.ﾌﾟﾘﾝﾀｰ,2.ﾌﾟﾚﾋﾞｭｰ,3.PDF形式保存)
    '*            2.実行モード(True.同期 , False.非同期)
    '*            3.ﾃｰﾀﾃｰﾌﾞﾙ（A帳票）
    '*            4.帳票コード
    '*            5.帳票ﾌｫｰﾑ
    '*            6.ﾃﾞｰﾀﾃｰﾌﾞﾙ(B帳票)
    '*            7.帳票ﾌｫｰﾑ(出庫指示書CASE明細9行以上)
    '*            8.ﾃﾞｰﾀﾃｰﾌﾞﾙ(条件テーブル)
    '*
    '*            1.[ｵﾌﾟｼｮﾝ] 部数
    '*            2.[ｵﾌﾟｼｮﾝ] 待機画面
    '*            3.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_RPT_EXC_ER602(ByVal P1 As Integer,
                                             ByVal P2 As Boolean,
                                             ByRef P3 As DataTable,
                                             ByVal P4 As String,
                                             ByRef P5 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P6 As DataTable,
                                             ByRef P7 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P8 As DataTable,
                                             Optional ByVal OP1 As Integer = 1,
                                             Optional ByVal OP2 As Boolean = False,
                                             Optional ByVal OP3 As Boolean = True) As Boolean
        Dim I As Integer = 0
        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim D_RTN As Boolean = False
        Dim D_TYP As String = ""
        Dim D_STR As String = ""
        Dim D_STR_OLD As String = ""
        '
        Try
            '帳票設定
            '
            FNC_RPT_INT(P4, P5, OP1, OP3)
            '
            P5.DataSource = P3
            P5.DataMember = P3.TableName
            '
            P5.Run(P2)
            '
            If P3.Rows.Count > 0 Then D_TYP = StrDup(P3.Rows.Count, "A")
            '
            If Not P6 Is Nothing Then
                If P6.Rows.Count > 0 Then
                    '
                    '※AB帳票判断
                    '
                    FNC_RPT_INT(P4, P7, OP1, OP3)
                    P7.DataSource = P6
                    P7.DataMember = P6.TableName
                    '
                    P7.Run(P2)
                    '
                    'いらないページを削除
                    '
                    For I = 0 To P3.Rows.Count - 1
                        If (FNC_CNV_NUL(P3.Rows(I).Item("社員コード"), 0) = FNC_CNV_NUL(P8.Rows(I).Item("社員コード"), 0)) AndAlso
                           (FNC_CNV_NUL(P8.Rows(I).Item("配偶者フラグ"), 0) = 0) Then
                            P5.Document.Pages.Remove(P5.Document.Pages(I - X))
                            D_TYP = D_TYP.Remove(CInt((I - X)), 1)
                            X = X + 1
                        End If
                        If P5.Document.Pages.Count = I + 1 - X Then Exit For
                    Next
                    '
                    'いるページを挿入
                    '
                    X = 0
                    For I = 0 To P3.Rows.Count - 1
                        If (FNC_CNV_NUL(P3.Rows(I).Item("社員コード"), 0) = FNC_CNV_NUL(P6.Rows(X).Item("社員コード"), 0)) Then
                            If P5.Document.Pages.Count > I + X + 1 Then
                                P5.Document.Pages.Insert(I + X + 1, P7.Document.Pages(X))
                                If D_TYP.Length > I + X + 1 Then
                                    D_TYP = D_TYP.Insert(I + X + 1, "B")
                                Else
                                    MsgBox("プリンタのページサイズが正しくありません", MsgBoxStyle.Critical, "ペーパーサイズ不整合")
                                    D_RTN = False
                                    GoTo EXIT_FUNCTION
                                End If
                            Else
                                P5.Document.Pages.Add(P7.Document.Pages(X))
                                D_TYP = D_TYP & "B"
                            End If
                            X = X + 1
                        End If
                        If P7.Document.Pages.Count = X Then Exit For
                    Next
                End If
            End If
            '
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_EXC)
                '
                For I = 0 To P5.Document.Pages.Count - 1
                    D_STR = D_TYP.Substring(I, 1)
                    '
                    'タイプが違ったらメッセージボックスを出す
                    '
                    If Not D_STR.Equals(D_STR_OLD) Then
                        MsgBox("タイプ" & D_STR & "の用紙をセットしてください", MsgBoxStyle.OkOnly & MsgBoxStyle.Information, "用紙セット")
                    End If
                    D_STR_OLD = D_STR
                    '
                    P5.Document.Printer.PrinterSettings.PrintRange = Printing.PrintRange.SomePages
                    P5.Document.Printer.PrinterSettings.FromPage = I + 1
                    P5.Document.Printer.PrinterSettings.ToPage = I + 1
                    '
                    Dim D_PRV As New Frm_Viewer
                    D_PRV.Viewer.Document = P5.Document
                    D_PRV.Viewer.Document.Print(True, False)
                    '
                    '描画速度調整
                    '
                    System.Threading.Thread.Sleep(500)
                    D_PRV = Nothing
                    If OP2 Then P_FRM_WIT.Hide()
                Next
                '
            ElseIf P1 = 2 Then
                '
                'プレビュー
                '
                Dim D_PRV As New Frm_Viewer
                '
                D_PRV.Viewer.Document = P5.Document
                D_PRV.ShowDialog()
                D_PRV = Nothing
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_RPT_EXC_ER602 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：PDFﾌｧｲﾙ作成/保存
    '*
    '*  引数　　：1.実行モード(True.同期 , False.非同期)
    '*            2.ﾃｰﾀﾃｰﾌﾞﾙ
    '*            3.帳票コード(A)
    '*            4.帳票ﾌｫｰﾑ(A)
    '*            5.ﾃﾞｰﾀﾃｰﾌﾞﾙ(B帳票)
    '*            6.帳票ﾌｫｰﾑ(B)
    '*            7.ﾃﾞｰﾀﾃｰﾌﾞﾙ(条件テーブル)
    '*            8.ﾌｧｲﾙ名
    '* 
    '*            1.[ｵﾌﾟｼｮﾝ] 既定ﾊﾟｽ
    '*            2.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 部数
    '*            4.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            5.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_PDF_ER602(ByVal P1 As Boolean,
                                       ByRef P2 As DataTable,
                                       ByVal P3 As String,
                                       ByRef P4 As GrapeCity.ActiveReports.SectionReport,
                                       ByRef P5 As DataTable,
                                       ByRef P6 As GrapeCity.ActiveReports.SectionReport,
                                       ByRef P7 As DataTable,
                                       ByVal P8 As String,
                                       Optional ByVal OP1 As String = "",
                                       Optional ByVal OP2 As String = "",
                                       Optional ByVal OP3 As Integer = 1,
                                       Optional ByVal OP4 As Boolean = False,
                                       Optional ByVal OP5 As Boolean = True) As Boolean
        Dim I As Integer = 0
        Dim X As Integer = 0
        Dim Y As Integer = 0
        Dim D_RTN As Boolean = False
        Dim D_SAV_DLG As New SaveFileDialog
        Dim D_PDF_EXP As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
        '
        Try
            '保存先取得
            '
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            D_SAV_DLG.FileName = P8.Replace("／" & C_APP_VER & C_APP_UPD, "")
            D_SAV_DLG.Filter = "PDF Files (*" & C_FIL_PDF_EXN & ")|*" & C_FIL_PDF_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            '
            If D_SAV_DLG.ShowDialog = DialogResult.OK Then
                If OP4 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
                '
                '帳票設定
                '
                FNC_RPT_INT(P3, P4, OP3, OP5)
                '
                P4.DataSource = P2
                P4.DataMember = P2.TableName
                P4.Run(P1)
                '
                If P5.Rows.Count > 0 Then
                    '※AB帳票判断
                    '
                    FNC_RPT_INT(P3, P6, OP3, OP5)
                    P6.DataSource = P5
                    P6.DataMember = P5.TableName
                    '
                    P6.Run(P1)
                    '
                    'いらないページを削除
                    '
                    For I = 0 To P2.Rows.Count - 1
                        If (FNC_CNV_NUL(P2.Rows(I).Item("社員コード"), 0) = FNC_CNV_NUL(P7.Rows(I).Item("社員コード"), 0)) AndAlso
                           (FNC_CNV_NUL(P7.Rows(I).Item("配偶者フラグ"), 0) = 0) Then
                            P4.Document.Pages.Remove(P4.Document.Pages(I - X))
                            X = X + 1
                        End If
                        If P6.Document.Pages.Count = I + 1 - X Then Exit For
                    Next
                    '
                    'いるページを挿入
                    '
                    X = 0
                    For I = 0 To P2.Rows.Count - 1
                        If (FNC_CNV_NUL(P2.Rows(I).Item("社員コード"), 0) = FNC_CNV_NUL(P5.Rows(X).Item("社員コード"), 0)) Then
                            If P4.Document.Pages.Count > I + X + 1 Then
                                P4.Document.Pages.Insert(I + X + 1, P6.Document.Pages(X))
                            Else
                                P4.Document.Pages.Add(P6.Document.Pages(X))
                            End If
                            X = X + 1
                        End If
                        If P6.Document.Pages.Count = X Then Exit For
                    Next
                End If
                '
                D_PDF_EXP.Export(P4.Document, D_SAV_DLG.FileName)
                OP2 = D_SAV_DLG.FileName.Trim
                '
                If Not _SynchronizingObject Is Nothing Then
                    _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
                Else
                    MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
                End If
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            D_SAV_DLG = Nothing
            D_PDF_EXP = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_PDF_ER602 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：休日出勤時間外手当一覧表出力(表紙追加)
    '*
    '*  引数　　：1.出力先(1.ﾌﾟﾘﾝﾀｰ,2.ﾌﾟﾚﾋﾞｭｰ)
    '*            2.実行モード(True.同期 , False.非同期)
    '*            3.ﾃｰﾀﾃｰﾌﾞﾙ(表紙)
    '*            4.帳票コード(表紙)
    '*            5.帳票ﾌｫｰﾑ(表紙)
    '*            6.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            7.帳票ｺｰﾄﾞ
    '*            8.帳票ﾌｫｰﾑ
    '*
    '*            1.[ｵﾌﾟｼｮﾝ] 部数
    '*            2.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            3.[ｵﾌﾟｼｮﾝ] ﾚﾎﾟｰﾄ生成時のﾚﾎﾟｰﾄﾍﾟｰｼﾞの格納場所(0.ﾒﾓﾘ、1.ﾊｰﾄﾞﾃﾞｨｽｸ)
    '*            4.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_RPT_EXC_ER005(ByVal P1 As Integer,
                                             ByVal P2 As Boolean,
                                             ByRef P3 As DataTable,
                                             ByVal P4 As String,
                                             ByRef P5 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P6 As DataTable,
                                             ByVal P7 As String,
                                             ByRef P8 As GrapeCity.ActiveReports.SectionReport,
                                             Optional ByVal OP1 As Integer = 1,
                                             Optional ByVal OP2 As Boolean = False,
                                             Optional ByVal OP3 As Byte = 0,
                                             Optional ByVal OP4 As Boolean = True) As Boolean
        Dim D_RTN As Boolean = False
        '
        Try
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_RPT)
            ElseIf P1 = 2 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PRV)
            ElseIf P1 = 3 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
            End If
            '
            '帳票設定
            '
            utl_Rpt.FNC_RPT_INT(P4, P5, OP1, OP4)
            '
            P5.DataSource = P3
            P5.DataMember = P3.TableName
            '
            'ﾒﾓﾘﾘｿｰｽ不足を防止
            '
            If OP3 = 1 Then
                P5.Document.CacheToDisk = True
            End If
            P5.Run(P2)
            '
            '帳票設定()
            '
            utl_Rpt.FNC_RPT_INT(P7, P8, OP1, OP4)
            '
            P8.DataSource = P6
            P8.DataMember = P6.TableName
            '
            'ﾒﾓﾘﾘｿｰｽ不足を防止
            '
            If OP3 = 1 Then
                P8.Document.CacheToDisk = True
            End If
            P8.Run(P2)
            '
            P8.Document.Pages.Insert(0, P5.Document.Pages(0))
            '
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_EXC)
                '
                'プリンターへ直接印刷
                '
                P8.Document.Print(False, False)
                If OP2 Then P_FRM_WIT.Hide()
            ElseIf P1 = 2 Then
                '
                'プレビュー
                '
                Dim D_PRV As New Frm_Viewer
                '
                D_PRV.Viewer.Document = P8.Document
                If OP2 Then P_FRM_WIT.Hide()
                D_PRV.ShowDialog()
                D_PRV = Nothing
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_RPT_EXC_ER005 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：PDFﾌｧｲﾙ作成/保存
    '*
    '*  引数　　：1.実行モード(True.同期 , False.非同期)
    '*            2.ﾃｰﾀﾃｰﾌﾞﾙ(表紙)
    '*            3.帳票コード(表紙)
    '*            4.帳票ﾌｫｰﾑ(表紙)
    '*            5.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            6.帳票ｺｰﾄﾞ
    '*            7.帳票ﾌｫｰﾑ
    '*            8.ﾌｧｲﾙ名
    '* 
    '*            1.[ｵﾌﾟｼｮﾝ] 既定ﾊﾟｽ
    '*            2.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 部数
    '*            4.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            5.[ｵﾌﾟｼｮﾝ] ﾚﾎﾟｰﾄ生成時のﾚﾎﾟｰﾄﾍﾟｰｼﾞの格納場所(0.ﾒﾓﾘ、1.ﾊｰﾄﾞﾃﾞｨｽｸ)
    '*            6.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_PDF_ER005(ByVal P1 As Boolean,
                                             ByRef P2 As DataTable,
                                             ByVal P3 As String,
                                             ByRef P4 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P5 As DataTable,
                                             ByVal P6 As String,
                                             ByRef P7 As GrapeCity.ActiveReports.SectionReport,
                                             ByVal P8 As String,
                                             Optional ByVal OP1 As String = "",
                                             Optional ByVal OP2 As String = "",
                                             Optional ByVal OP3 As Integer = 1,
                                             Optional ByVal OP4 As Boolean = False,
                                             Optional ByVal OP5 As Byte = 0,
                                             Optional ByVal OP6 As Boolean = True) As Boolean
        Dim D_RTN As Boolean = False
        Dim D_RES As DialogResult
        Dim D_SAV_DLG As New SaveFileDialog
        Dim D_PDF_EXP As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
        '
        Try
            '保存先取得
            '
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            D_SAV_DLG.FileName = P8.Replace("／" & C_APP_VER & C_APP_UPD, "")
            D_SAV_DLG.Filter = "PDF Files (*" & C_FIL_PDF_EXN & ")|*" & C_FIL_PDF_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            '
            If Not _SynchronizingObject Is Nothing Then
                D_RES = _SynchronizingObject.Invoke(New ShowDialogDelegate(AddressOf D_SAV_DLG.ShowDialog), Nothing)
            Else
                D_RES = D_SAV_DLG.ShowDialog()
            End If
            '
            If D_RES = DialogResult.OK Then
                If OP4 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
                '
                '帳票設定
                '
                FNC_RPT_INT(P3, P4, OP3, OP6)
                '
                P4.DataSource = P2
                P4.DataMember = P2.TableName
                '
                'ﾒﾓﾘﾘｿｰｽ不足を防止
                '
                If OP5 = 1 Then
                    P4.Document.CacheToDisk = True
                End If
                P4.Run(P1)
                '
                '帳票設定
                '
                FNC_RPT_INT(P6, P7, OP3, OP6)
                '
                P7.DataSource = P5
                P7.DataMember = P5.TableName
                '
                'ﾒﾓﾘﾘｿｰｽ不足を防止
                If OP5 = 1 Then
                    P7.Document.CacheToDisk = True
                End If
                P7.Run(P1)
                '
                P7.Document.Pages.Insert(0, P4.Document.Pages(0))
                '
                D_PDF_EXP.Export(P7.Document, D_SAV_DLG.FileName)
                OP2 = D_SAV_DLG.FileName.Trim
                '
                If Not _SynchronizingObject Is Nothing Then
                    _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
                Else
                    MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
                End If
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            D_SAV_DLG = Nothing
            D_PDF_EXP = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_PDF_ER005 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：休日出勤時間外手当一覧表出力(表紙追加)
    '*
    '*  引数　　：1.出力先(1.ﾌﾟﾘﾝﾀｰ,2.ﾌﾟﾚﾋﾞｭｰ)
    '*            2.実行モード(True.同期 , False.非同期)
    '*            3.ﾃｰﾀﾃｰﾌﾞﾙ(表紙)
    '*            4.帳票コード(表紙)
    '*            5.帳票ﾌｫｰﾑ(表紙)
    '*            6.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            7.帳票ｺｰﾄﾞ
    '*            8.帳票ﾌｫｰﾑ
    '*            9.ﾃﾞｰﾀﾃｰﾌﾞﾙ（統括）
    '*           10.帳票ｺｰﾄﾞ
    '*           11.帳票ﾌｫｰﾑ
    '*           12.明細ページ数保持テーブル
    '*
    '*            1.[ｵﾌﾟｼｮﾝ] 部数
    '*            2.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            3.[ｵﾌﾟｼｮﾝ] ﾚﾎﾟｰﾄ生成時のﾚﾎﾟｰﾄﾍﾟｰｼﾞの格納場所(0.ﾒﾓﾘ、1.ﾊｰﾄﾞﾃﾞｨｽｸ)
    '*            4.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_RPT_EXC_CR862(ByVal P1 As Integer, ByVal P2 As Boolean,
                                             ByRef P3 As DataTable, ByVal P4 As String,
                                             ByRef P5 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P6 As DataTable,
                                             ByVal P7 As String,
                                             ByRef P8 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P9 As DataTable,
                                             ByVal P10 As String,
                                             ByRef P11 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P12 As DataTable,
                                             Optional ByVal OP1 As Integer = 1,
                                             Optional ByVal OP2 As Boolean = False,
                                             Optional ByVal OP3 As Byte = 0,
                                             Optional ByVal OP4 As Boolean = True) As Boolean
        Dim I As Integer = 0
        Dim D_RTN As Boolean = False
        '
        Try
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_RPT)
            ElseIf P1 = 2 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PRV)
            ElseIf P1 = 3 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
            End If
            '
            '帳票設定
            '
            utl_Rpt.FNC_RPT_INT(P4, P5, OP1, OP4)
            '
            P5.DataSource = P3
            P5.DataMember = P3.TableName
            '
            'ﾒﾓﾘﾘｿｰｽ不足を防止
            '
            If OP3 = 1 Then
                P5.Document.CacheToDisk = True
            End If
            P5.Run(P2)
            '
            '帳票設定()
            '
            utl_Rpt.FNC_RPT_INT(P7, P8, OP1, OP4)
            '
            P8.DataSource = P6
            P8.DataMember = P6.TableName
            '
            'ﾒﾓﾘﾘｿｰｽ不足を防止
            '
            If OP3 = 1 Then
                P8.Document.CacheToDisk = True
            End If
            P8.Run(P2)
            '
            '表紙追加
            '
            P8.Document.Pages.Insert(0, P5.Document.Pages(0))
            'データがあれば印刷・追加
            If P9.Rows.Count > 0 Then
                '帳票設定
                '
                utl_Rpt.FNC_RPT_INT(P10, P11, OP1, OP4)
                '
                P11.DataSource = P9
                P11.DataMember = P9.TableName
                '
                'ﾒﾓﾘﾘｿｰｽ不足を防止
                '
                If OP3 = 1 Then
                    P11.Document.CacheToDisk = True
                End If
                '
                P11.Run(P2)
                '
                '統括追加
                '
                If P12.Rows.Count > 0 Then
                    For I = 0 To P11.Document.Pages.Count - 1
                        P8.Document.Pages.Insert(FNC_CNV_NUL(P12.Rows(0).Item("明細ページ数"), 0) + 1 + I, P11.Document.Pages(I))
                    Next
                End If
            End If
            '
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_EXC)
                '
                'プリンターへ直接印刷
                '
                P8.Document.Print(False, False)
                If OP2 Then P_FRM_WIT.Hide()
            ElseIf P1 = 2 Then
                'プレビュー
                '
                Dim D_PRV As New Frm_Viewer
                '
                D_PRV.Viewer.Document = P8.Document
                '
                If OP2 Then P_FRM_WIT.Hide()
                '
                D_PRV.ShowDialog()
                D_PRV = Nothing
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_RPT_EXC_CR862 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：PDFﾌｧｲﾙ作成/保存(契約先一覧表)
    '*
    '*  引数　　：1.実行モード(True.同期 , False.非同期)
    '*            2.ﾃｰﾀﾃｰﾌﾞﾙ(表紙)
    '*            3.帳票コード(表紙)
    '*            4.帳票ﾌｫｰﾑ(表紙)
    '*            5.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            6.帳票ｺｰﾄﾞ
    '*            7.帳票ﾌｫｰﾑ
    '*            8.ﾃﾞｰﾀﾃｰﾌﾞﾙ（統括）
    '*            9.帳票ｺｰﾄﾞ
    '*           10.帳票ﾌｫｰﾑ
    '*           11.明細ページ数保持テーブル
    '*           12.ﾌｧｲﾙ名
    '* 
    '*            1.[ｵﾌﾟｼｮﾝ] 既定ﾊﾟｽ
    '*            2.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 部数
    '*            4.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            5.[ｵﾌﾟｼｮﾝ] ﾚﾎﾟｰﾄ生成時のﾚﾎﾟｰﾄﾍﾟｰｼﾞの格納場所(0.ﾒﾓﾘ、1.ﾊｰﾄﾞﾃﾞｨｽｸ)
    '*            6.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_PDF_CR862(ByVal P1 As Boolean,
                                             ByRef P2 As DataTable,
                                             ByVal P3 As String,
                                             ByRef P4 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P5 As DataTable,
                                             ByVal P6 As String,
                                             ByRef P7 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P8 As DataTable,
                                             ByVal P9 As String,
                                             ByRef P10 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P11 As DataTable,
                                             ByVal P12 As String,
                                             Optional ByVal OP1 As String = "",
                                             Optional ByVal OP2 As String = "",
                                             Optional ByVal OP3 As Integer = 1,
                                             Optional ByVal OP4 As Boolean = False,
                                             Optional ByVal OP5 As Byte = 0,
                                             Optional ByVal OP6 As Boolean = True) As Boolean
        Dim I As Integer = 0
        Dim D_RTN As Boolean = False
        Dim D_RES As DialogResult
        Dim D_SAV_DLG As New SaveFileDialog
        Dim D_PDF_EXP As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
        '
        Try
            '保存先取得
            '
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            D_SAV_DLG.FileName = P12.Replace("／" & C_APP_VER & C_APP_UPD, "")
            D_SAV_DLG.Filter = "PDF Files (*" & C_FIL_PDF_EXN & ")|*" & C_FIL_PDF_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            '
            If Not _SynchronizingObject Is Nothing Then
                D_RES = _SynchronizingObject.Invoke(New ShowDialogDelegate(AddressOf D_SAV_DLG.ShowDialog), Nothing)
            Else
                D_RES = D_SAV_DLG.ShowDialog()
            End If
            '
            If D_RES = DialogResult.OK Then
                If OP4 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
                '
                '帳票設定
                '
                FNC_RPT_INT(P3, P4, OP3, OP6)
                '
                P4.DataSource = P2
                P4.DataMember = P2.TableName
                '
                'ﾒﾓﾘﾘｿｰｽ不足を防止
                '
                If OP5 = 1 Then
                    P4.Document.CacheToDisk = True
                End If
                P4.Run(P1)
                '
                '帳票設定
                '
                FNC_RPT_INT(P6, P7, OP3, OP6)
                '
                P7.DataSource = P5
                P7.DataMember = P5.TableName
                '
                'ﾒﾓﾘﾘｿｰｽ不足を防止
                '
                If OP5 = 1 Then
                    P7.Document.CacheToDisk = True
                End If
                P7.Run(P1)
                '
                P7.Document.Pages.Insert(0, P4.Document.Pages(0))
                '
                If P8.Rows.Count > 0 Then
                    '帳票設定
                    '
                    utl_Rpt.FNC_RPT_INT(P9, P10, OP3, OP6)
                    '
                    P10.DataSource = P8
                    P10.DataMember = P8.TableName
                    '
                    'ﾒﾓﾘﾘｿｰｽ不足を防止
                    '
                    If OP5 = 1 Then
                        P10.Document.CacheToDisk = True
                    End If
                    P10.Run(P1)
                    '
                    '統括追加
                    '
                    If P11.Rows.Count > 0 Then
                        For I = 0 To P10.Document.Pages.Count - 1
                            P7.Document.Pages.Insert(FNC_CNV_NUL(P11.Rows(0).Item("明細ページ数"), 0) + 1 + I, P10.Document.Pages(I))
                        Next
                    End If
                End If
                '
                D_PDF_EXP.Export(P7.Document, D_SAV_DLG.FileName)
                OP2 = D_SAV_DLG.FileName.Trim
                '
                If Not _SynchronizingObject Is Nothing Then
                    _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
                Else
                    MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
                End If
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            D_SAV_DLG = Nothing
            D_PDF_EXP = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_PDF_CR862 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：帳票出力処理実行(CR851-請求書出力用)
    '*
    '*  引数　　：1.出力先(1.ﾌﾟﾘﾝﾀｰ,2.ﾌﾟﾚﾋﾞｭｰ)
    '*            2.実行モード(True.同期 , False.非同期)
    '*            3.ﾃｰﾀﾃｰﾌﾞﾙ
    '*            4.帳票コード
    '*            5.帳票ﾌｫｰﾑ
    '*
    '*            1.[ｵﾌﾟｼｮﾝ] 部数
    '*            2.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            3.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_RPT_EXC_CR851(ByVal P1 As Integer,
                                             ByVal P2 As Boolean,
                                             ByRef P3 As DataTable,
                                             ByVal P4 As String,
                                             ByRef P5 As GrapeCity.ActiveReports.SectionReport,
                                             Optional ByVal OP1 As Integer = 1,
                                             Optional ByVal OP2 As Boolean = False,
                                             Optional ByVal OP3 As Boolean = True,
                                             Optional ByVal OP4 As Byte = 0) As Boolean
        Dim D_RTN As Boolean = False
        '
        Try
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_RPT)
            ElseIf P1 = 2 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PRV)
            ElseIf P1 = 3 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
            End If
            '
            '帳票設定
            '
            FNC_RPT_INT(P4, P5, OP1, OP3)
            '
            P5.DataSource = P3
            P5.DataMember = P3.TableName
            '
            'ﾒﾓﾘﾘｿｰｽ不足を防止
            If OP4 = 1 Then
                P5.Document.CacheToDisk = True
            End If
            '
            P5.Run(P2)
            '
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_EXC)
                '
                'プリンターへ直接印刷(プリントダイアログを出さない)
                '
                P5.Document.Print(False, False)
                '
                System.Threading.Thread.Sleep(2000)
                '
                If OP2 Then P_FRM_WIT.Hide()
            ElseIf P1 = 2 Then
                '
                'プレビュー
                '
                Dim D_PRV As New Frm_Viewer
                '
                D_PRV.Viewer.Document = P5.Document
                '
                If OP2 Then P_FRM_WIT.Hide()
                '
                D_PRV.ShowDialog()
                D_PRV = Nothing
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        FNC_RPT_EXC_CR851 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：PDFﾌｧｲﾙ作成/保存(CR851-請求書出力用)
    '*
    '*  引数　　：1.実行モード(True.同期 , False.非同期)
    '*            2.ﾃｰﾀﾃｰﾌﾞﾙ
    '*            3.帳票コード
    '*            4.帳票ﾌｫｰﾑ
    '*            5.ﾌｧｲﾙ名
    '* 
    '*            1.[ｵﾌﾟｼｮﾝ] 既定ﾊﾟｽ
    '*            2.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 部数
    '*            4.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            5.[ｵﾌﾟｼｮﾝ] ﾚﾎﾟｰﾄ生成時のﾚﾎﾟｰﾄﾍﾟｰｼﾞの格納場所(0.ﾒﾓﾘ、1.ﾊｰﾄﾞﾃﾞｨｽｸ)
    '*            6.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_PDF_CR851(ByVal P1 As Boolean,
                                             ByRef P2 As DataTable,
                                             ByVal P3 As String,
                                             ByRef P4 As GrapeCity.ActiveReports.SectionReport,
                                             ByVal P5 As String,
                                             Optional ByVal OP1 As String = "",
                                             Optional ByVal OP2 As String = "",
                                             Optional ByVal OP3 As Integer = 1,
                                             Optional ByVal OP4 As Boolean = False,
                                             Optional ByVal OP5 As Byte = 0,
                                             Optional ByVal OP6 As Boolean = True) As Boolean
        Dim D_RTN As Boolean = False
        Dim D_RES As DialogResult
        Dim D_SAV_DLG As New SaveFileDialog
        Dim D_PDF_EXP As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
        '
        Try
            '保存先取得
            '
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            '
            D_SAV_DLG.FileName = P5.Replace("／" & C_APP_VER & C_APP_UPD, "") & ".pdf"
            D_SAV_DLG.Filter = "PDF Files (*" & C_FIL_PDF_EXN & ")|*" & C_FIL_PDF_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            '
            If OP4 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
            '
            '帳票設定
            '
            FNC_RPT_INT(P3, P4, OP3, OP6)
            '
            P4.DataSource = P2
            P4.DataMember = P2.TableName
            '
            'ﾒﾓﾘﾘｿｰｽ不足を防止
            '
            If OP5 = 1 Then
                P4.Document.CacheToDisk = True
            End If
            P4.Run(P1)
            '
            'ﾌｧｲﾙ作成
            '
            If Not Directory.Exists(OP1) Then
                Directory.CreateDirectory(OP1)
            End If
            '
            D_PDF_EXP.Export(P4.Document, OP1 & "\" & D_SAV_DLG.FileName)
            OP2 = D_SAV_DLG.FileName.Trim
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            D_SAV_DLG = Nothing
            D_PDF_EXP = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_PDF_CR851 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：PDFﾌｧｲﾙ作成/分割保存(SR002_売掛金管理一覧表)
    '*
    '*  引数　　：1.実行モード(True.同期 , False.非同期)
    '*            2.ﾃｰﾀｾｯﾄ
    '*            3.帳票コード
    '*            4.帳票ﾌｫｰﾑ
    '*            5.ﾌｧｲﾙ名
    '*            6.コード項目名称
    '*            7.名称項目名称
    '* 
    '*            1.[ｵﾌﾟｼｮﾝ] 既定ﾊﾟｽ
    '*            2.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 部数
    '*            4.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            5.[ｵﾌﾟｼｮﾝ] 既定ﾌｧｲﾙ名
    '*            6.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_PDF_SR002(ByVal P1 As Boolean,
                                             ByRef P2 As DataSet,
                                             ByVal P3 As String,
                                             ByRef P4 As GrapeCity.ActiveReports.SectionReport,
                                             ByVal P5 As String,
                                             ByVal P6 As String,
                                             ByVal P7 As String,
                                             Optional ByVal OP1 As String = "",
                                             Optional ByVal OP2 As String = "",
                                             Optional ByVal OP3 As Integer = 1,
                                             Optional ByVal OP4 As Boolean = False,
                                             Optional ByVal OP5 As String = "",
                                             Optional ByVal OP6 As Boolean = True,
                                             Optional ByVal OP8 As Boolean = True) As Boolean
        Dim I As Integer
        Dim D_RTN As Boolean = False
        Dim D_RES As DialogResult
        Dim D_GET_IPS As String
        Dim D_FIL_NAM As String
        Dim D_SAV_DLG As New SaveFileDialog
        Dim D_PDF_EXP As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
        Dim strMyPath As String     'マイドキュメントのパス
        Dim strDskPath As String    'デスクトップのパス
        '
        Try
            '保存場所＆ファイル名取得
            '
            If D_SAV_DLG.InitialDirectory.ToString.Equals("") Then
                '
                'マイドキュメントのパス
                '
                strMyPath = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal)
                '
                'デスクトップのパス
                '
                strDskPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)
                '
                'ファイル種類
                '
                D_SAV_DLG.Filter = "PDF Files (*" & C_FIL_PDF_EXN & ")|*" & C_FIL_PDF_EXN & "|All Files (*.*)|*.*"
                '
                D_GET_IPS = FNC_GET_IPS()
                '
                '起動チェック
                '
                If Not (D_GET_IPS.Equals("192.168.2.18") OrElse
                        D_GET_IPS.Equals("192.168.2.19") OrElse
                        D_GET_IPS.Equals("192.168.2.20") OrElse
                        D_GET_IPS.Equals("192.168.2.21") OrElse
                        D_GET_IPS.Equals("192.168.2.22") OrElse
                        D_GET_IPS.Equals("192.168.2.23") OrElse
                        D_GET_IPS.Equals("192.168.2.75") OrElse
                        D_GET_IPS.Equals("192.168.2.76") OrElse
                        D_GET_IPS.Equals("192.168.2.77") OrElse
                        D_GET_IPS.Equals("192.168.2.78") OrElse
                        D_GET_IPS.Equals("192.168.2.79")
                       ) OrElse D_GET_IPS.IndexOf("192.168.38.") > -1 Then   'ans環境用
                    'PC
                    '
                    D_SAV_DLG.FileName = strDskPath & "\" & FNC_CNV_FIL_NAM("売掛金管理") & "_" & FNC_CNV_NUL(P2.Tables(I).Rows(0).Item(P6), "") & "_" & FNC_CNV_NUL(P2.Tables(I).Rows(0).Item(P7), "") & C_FIL_PDF_EXN
                Else
                    '
                    'シンクライアント
                    '
                    D_SAV_DLG.FileName = "\\stk-srv-12\MyDoc$\" & C_USR_IDS & "\マイ ドキュメント\" & IIf(OP8 = True, C_USR_IDS & "_", "") & P5.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_PDF_EXN
                End If
            End If
            '
            '保存先取得
            '
            If Not _SynchronizingObject Is Nothing Then
                D_RES = _SynchronizingObject.Invoke(New ShowDialogDelegate(AddressOf D_SAV_DLG.ShowDialog), Nothing)
            Else
                D_RES = D_SAV_DLG.ShowDialog()
            End If
            '
            If D_RES = DialogResult.OK Then
                If OP4 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF_EXT)
                '
                '帳票設定
                '
                FNC_RPT_INT(P3, P4, OP3, OP6)
                '
                For I = 0 To P2.Tables.Count - 1 Step 1
                    If P2.Tables(I).Rows.Count > 0 Then
                        P4.DataSource = P2.Tables(I)
                        P4.DataMember = P2.Tables(I).TableName
                        '
                        P4.Run(P1)
                        '
                        D_FIL_NAM = FNC_CNV_FIL_NAM("売掛金管理") & "_" & FNC_CNV_NUL(P2.Tables(I).Rows(0).Item(P6), "") & "_" & FNC_CNV_NUL(P2.Tables(I).Rows(0).Item(P7), "")
                        D_PDF_EXP.Export(P4.Document, D_FIL_NAM & C_FIL_PDF_EXN)
                    End If
                Next
                OP2 = D_SAV_DLG.FileName.Trim
                '
                If Not _SynchronizingObject Is Nothing Then
                    _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
                Else
                    MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
                End If
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            D_SAV_DLG = Nothing
            D_PDF_EXP = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_PDF_SR002 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：帳票出力処理実行(JR001-給与明細用)
    '*
    '*  引数　　：1.出力先(1.ﾌﾟﾘﾝﾀｰ,2.ﾌﾟﾚﾋﾞｭｰ)
    '*            2.実行モード(True.同期 , False.非同期)
    '*            3.ﾃｰﾀﾃｰﾌﾞﾙ1
    '*            4.帳票コード1
    '*            5.帳票ﾌｫｰﾑ1
    '*            6.ﾃｰﾀﾃｰﾌﾞﾙ2
    '*            7.帳票コード2
    '*            8.帳票ﾌｫｰﾑ2
    '*
    '*            1.[ｵﾌﾟｼｮﾝ] 部数
    '*            2.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            3.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_RPT_EXC_JR001(ByVal P1 As Integer,
                                             ByVal P2 As Boolean,
                                             ByRef P3 As DataTable,
                                             ByVal P4 As String,
                                             ByRef P5 As GrapeCity.ActiveReports.SectionReport,
                                             ByRef P6 As DataTable,
                                             ByVal P7 As String,
                                             ByRef P8 As GrapeCity.ActiveReports.SectionReport,
                                             Optional ByVal OP1 As Integer = 1,
                                             Optional ByVal OP2 As Boolean = False,
                                             Optional ByVal OP3 As Boolean = True,
                                             Optional ByVal OP4 As Byte = 0) As Boolean

        Dim D_RTN As Boolean = False
        '
        Try
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_RPT)
            ElseIf P1 = 2 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PRV)
            ElseIf P1 = 3 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
            End If
            '
            '帳票設定
            '
            FNC_RPT_INT(P4, P5, OP1, OP3)
            FNC_RPT_INT(P7, P8, OP1, False)
            '
            P5.DataSource = P3
            P5.DataMember = P3.TableName
            '
            P8.DataSource = P6
            P8.DataMember = P6.TableName
            '
            'ﾒﾓﾘﾘｿｰｽ不足を防止
            '
            If OP4 = 1 Then
                P5.Document.CacheToDisk = True
                P8.Document.CacheToDisk = True
            End If
            P5.Run(P2)
            P8.Run(P2)
            '
            If P1 = 1 Then
                If OP2 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_EXC)
                '
                'プリンターへ直接印刷(プリントダイアログを出さない)
                '
                P5.Document.Print(False, False)
                '
                System.Threading.Thread.Sleep(2000)
                '
                P8.Document.Print(False, False)
                If OP2 Then P_FRM_WIT.Hide()
            ElseIf P1 = 2 Then
                '
                'プレビュー
                '
                Dim D_PRV As New Frm_Viewer
                '
                D_PRV.Viewer.Document = P5.Document
                '
                If OP2 Then P_FRM_WIT.Hide()
                '
                D_PRV.ShowDialog()
                D_PRV = Nothing
                '
                D_PRV = New Frm_Viewer
                '
                D_PRV.Viewer.Document = P8.Document
                '
                If OP2 Then P_FRM_WIT.Hide()
                D_PRV.ShowDialog()
                D_PRV = Nothing
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            '
        End Try
EXIT_FUNCTION:
        FNC_RPT_EXC_JR001 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：PDFﾌｧｲﾙ作成/保存(JR001-給与明細用)
    '*
    '*  引数　　：1.実行モード(True.同期 , False.非同期)
    '*            2.ﾃｰﾀﾃｰﾌﾞﾙ
    '*            3.帳票コード
    '*            4.帳票ﾌｫｰﾑ
    '*            5.ﾌｧｲﾙ名
    '* 
    '*            1.[ｵﾌﾟｼｮﾝ] 既定ﾊﾟｽ
    '*            2.[ｵﾌﾟｼｮﾝ] ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 部数
    '*            4.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*            5.[ｵﾌﾟｼｮﾝ] ﾚﾎﾟｰﾄ生成時のﾚﾎﾟｰﾄﾍﾟｰｼﾞの格納場所(0.ﾒﾓﾘ、1.ﾊｰﾄﾞﾃﾞｨｽｸ)
    '*            6.[ｵﾌﾟｼｮﾝ] 余白自動設定(True.する、False.しない(=帳票ﾃﾞｻﾞｲﾝに順ずる))
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_PDF_JR001(ByVal P1 As Boolean,
                                             ByRef P2 As DataTable,
                                             ByVal P3 As String,
                                             ByRef P4 As GrapeCity.ActiveReports.SectionReport,
                                             ByVal P5 As String,
                                             ByRef P6 As DataTable,
                                             ByVal P7 As String,
                                             ByRef P8 As GrapeCity.ActiveReports.SectionReport,
                                             ByVal P9 As String,
                                             Optional ByVal OP1 As String = "",
                                             Optional ByVal OP2 As String = "",
                                             Optional ByVal OP3 As Integer = 1,
                                             Optional ByVal OP4 As Boolean = False,
                                             Optional ByVal OP5 As Byte = 0,
                                             Optional ByVal OP6 As Boolean = True) As Boolean
        Dim D_RTN As Boolean = False
        Dim D_RES As DialogResult
        Dim D_SAV_DLG As New SaveFileDialog
        Dim D_PDF_EXP As New GrapeCity.ActiveReports.Export.Pdf.Section.PdfExport
        '
        Try
            '保存先取得
            '
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            D_SAV_DLG.FileName = P5.Replace("／" & C_APP_VER & C_APP_UPD, "")
            D_SAV_DLG.Filter = "PDF Files (*" & C_FIL_PDF_EXN & ")|*" & C_FIL_PDF_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            '
            If Not _SynchronizingObject Is Nothing Then
                D_RES = _SynchronizingObject.Invoke(New ShowDialogDelegate(AddressOf D_SAV_DLG.ShowDialog), Nothing)
            Else
                D_RES = D_SAV_DLG.ShowDialog()
            End If
            '
            If D_RES = DialogResult.OK Then
                If OP4 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
                '
                '帳票設定
                '
                FNC_RPT_INT(P3, P4, OP3, OP6)
                '
                P4.DataSource = P2
                P4.DataMember = P2.TableName
                '
                'ﾒﾓﾘﾘｿｰｽ不足を防止
                '
                If OP5 = 1 Then
                    P4.Document.CacheToDisk = True
                End If
                P4.Run(P1)
                '
                D_PDF_EXP.Export(P4.Document, D_SAV_DLG.FileName)
                OP2 = D_SAV_DLG.FileName.Trim
                '
                If Not _SynchronizingObject Is Nothing Then
                    _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
                Else
                    MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
                End If
                '
                '預り返却証
                '
                If P6.Rows.Count > 0 Then
                    '保存先取得
                    '
                    D_SAV_DLG.FileName = P9.Replace("／" & C_APP_VER & C_APP_UPD, "")
                    '
                    If Not _SynchronizingObject Is Nothing Then
                        D_RES = _SynchronizingObject.Invoke(New ShowDialogDelegate(AddressOf D_SAV_DLG.ShowDialog), Nothing)
                    Else
                        D_RES = D_SAV_DLG.ShowDialog()
                    End If
                    '
                    If D_RES = DialogResult.OK Then
                        If OP4 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_PDF)
                        '
                        '帳票設定
                        '
                        FNC_RPT_INT(P7, P8, OP3, False)
                        '
                        P8.DataSource = P6
                        P8.DataMember = P6.TableName
                        '
                        'ﾒﾓﾘﾘｿｰｽ不足を防止
                        '
                        If OP5 = 1 Then
                            P8.Document.CacheToDisk = True
                        End If
                        P8.Run(P1)
                        '
                        D_PDF_EXP.Export(P8.Document, D_SAV_DLG.FileName)
                        OP2 = D_SAV_DLG.FileName.Trim
                        '
                        If Not _SynchronizingObject Is Nothing Then
                            _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
                        Else
                            MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
                        End If
                    End If
                End If
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            D_SAV_DLG = Nothing
            D_PDF_EXP = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_PDF_JR001 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：EXCELﾌｧｲﾙ作成/保存（HTML型式）
    '*
    '*  引数　　：1.ﾃﾞｰﾀﾃﾌﾞﾙ
    '*            2.ﾌｧｲﾙ名
    '*            3.ｼｰﾄ名
    '* 
    '*            1.ｵﾌﾟｼｮﾝ ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ[シート名]
    '*            2.ｵﾌﾟﾘｮﾝ 既定ﾊﾟｽ
    '*            3.ｵﾌﾟｼｮﾝ 待機画面(True.表示、False.非表示[ﾃﾞﾌｫﾙﾄ])
    '*            4.ｵﾌﾟｼｮﾝ 確認ﾒｯｾｰｼﾞ(True.表示[ﾃﾞﾌｫﾙﾄ]、False.非表示)
    '*            5.ｵﾌﾟｼｮﾝ 罫線(True.あり、False.なし[ﾃﾞﾌｫﾙﾄ])
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_XLS_EXP(ByRef P1 As DataTable,
                                       ByVal P2 As String,
                                       ByVal P3 As String,
                                       Optional ByVal OP1 As String = "",
                                       Optional ByVal OP2 As String = "",
                                       Optional ByVal OP3 As Boolean = False,
                                       Optional ByVal OP4 As Boolean = True,
                                       Optional ByVal OP5 As Boolean = False)
        Dim D_RTN As Boolean = False
        Dim D_RES As DialogResult
        Dim D_DIR As String = ""
        Dim D_DAT_HED As String = ""
        Dim D_DAT_DTL As String = ""
        Dim D_DAT_END As String = ""
        Dim D_SAV_DLG As New SaveFileDialog
        Dim D_FIL_NAM As String = ""
        '
        Try
            If OP3 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_XLS)
            System.Windows.Forms.Application.DoEvents()
            '
            'ﾜｰｸﾃﾞｨﾚｸﾄﾘ作成
            '
            If Not Directory.Exists(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS) Then
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS)
            End If
            '
            'ﾌｧｲﾙ保存
            '
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            D_SAV_DLG.FileName = P2 'D_FIL_NAM
            D_SAV_DLG.Filter = "XLS Files (*" & C_FIL_XLS_EXN & ")|*" & C_FIL_XLS_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            D_DIR = OP1
            '
            'ﾌｫﾙﾀﾞ作成
            '
            If Not System.IO.Directory.Exists(D_DIR) Then
                System.IO.Directory.CreateDirectory(D_DIR)
            End If
            '
            Dim D_STM As System.IO.Stream = System.IO.File.Open(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2, System.IO.FileMode.Create, System.IO.FileAccess.ReadWrite, System.IO.FileShare.None)
            Dim D_STM_WIT As New System.IO.StreamWriter(D_STM, System.Text.Encoding.Default)
            '
            '罫線
            '
            If OP5 = True Then
                D_DAT_HED = "<html>" &
                            "<head>" &
                            "<meta http-equiv=" & """" & "Content-Type" & """" & "content=" & """" & "text/html; charset=shift_jis" & """" & ">" &
                            "</head>" &
                            "<body>" &
                            "<table cellpading=" & """" & "0" & """" & " cellspacing=" & """" & "0" & """" & " style=" & """" & "border-right: #000000 0.5pt solid; border-top: #000000 0.5pt solid; border-left: #000000 0.5pt solid; border-bottom: #000000 0.5pt solid" & """" & ">" &
                            "<tr>"
            Else
                D_DAT_HED = "<html>" &
                            "<head>" &
                            "<meta http-equiv=" & """" & "Content-Type" & """" & "content=" & """" & "text/html; charset=shift_jis" & """" & ">" &
                            "</head>" &
                            "<body>" &
                            "<table cellpading=" & """" & "0" & """" & " cellspacing=" & """" & "0" & """" & " style=" & """" & "" & """" & ">" &
                            "<tr>"
            End If
            '
            For ix As Integer = 0 To P1.Columns.Count - 1 Step 1
                '罫線
                If OP5 = True Then
                    D_DAT_HED &= "<td nowrap=" & """" & "nowrap" & """" & " style=" & """" & "border-right: #000000 0.5pt solid; border-top: #000000 0.5pt solid; border-left: #000000 0.5pt solid; border-bottom: #000000 0.5pt solid; background-color: #C0FFC0; color: #000000;" & """" & ">" &
                                 P1.Columns(ix).Caption & "</td>"
                Else
                    D_DAT_HED &= "<td nowrap=" & """" & "nowrap" & """" & " style=" & """" & "background-color: #C0FFC0; color: #000000;" & """" & ">" &
                                 P1.Columns(ix).Caption & "</td>"
                End If
            Next
            '
            D_DAT_HED &= "</tr>"
            D_STM_WIT.Write(D_DAT_HED)
            '
            For ix As Integer = 0 To P1.Rows.Count - 1 Step 1
                D_DAT_DTL &= "<tr>"
                For iy As Integer = 0 To P1.Columns.Count - 1 Step 1
                    '罫線
                    '
                    If OP5 = True Then
                        Select Case P1.Columns(iy).DataType.Name
                            Case "Integer", "Long", "Short", "Byte", "Int16", "Int32", "Int64", "SByte", "UInt16", "UInt32", "UInt64", "Decimal", "Double", "Single"
                                D_DAT_DTL &= "<td nowrap=" & """" & "nowrap" & """" & " style=" & """" & "border-right: #000000 0.5pt solid; border-top: #000000 0.5pt solid; border-left: #000000 0.5pt solid; border-bottom: #000000 0.5pt solid" & """" & "><br>" & FNC_CNV_NUL(P1.Rows(ix).Item(iy), "0") & "</td>"
                            Case "DateTime", "TimeSpan"
                                D_DAT_DTL &= "<td nowrap=" & """" & "nowrap" & """" & " style=" & """" & "border-right: #000000 0.5pt solid; border-top: #000000 0.5pt solid; border-left: #000000 0.5pt solid; border-bottom: #000000 0.5pt solid" & """" & "><br>" & Format(FNC_CNV_NUL(P1.Rows(ix).Item(iy), Nothing), "yyyy/MM/dd HH:mm:ss") & "</td>"
                            Case "Byte[]"
                                '
                                '空で出力
                                '
                                D_DAT_DTL &= "<td nowrap=" & """" & "nowrap" & """" & " style=" & """" & "border-right: #000000 0.5pt solid; border-top: #000000 0.5pt solid; border-left: #000000 0.5pt solid; border-bottom: #000000 0.5pt solid" & """" & "><br></td>"
                            Case Else
                                D_DAT_DTL &= "<td nowrap=" & """" & "nowrap" & """" & " style=" & """" & "border-right: #000000 0.5pt solid; border-top: #000000 0.5pt solid; border-left: #000000 0.5pt solid; border-bottom: #000000 0.5pt solid" & """" & "><br>" & FNC_CNV_NUL(P1.Rows(ix).Item(iy), "") & "</td>"
                        End Select
                    Else
                        Select Case P1.Columns(iy).DataType.Name
                            Case "Integer", "Long", "Short", "Byte", "Int16", "Int32", "Int64", "SByte", "UInt16", "UInt32", "UInt64", "Decimal", "Double", "Single"
                                D_DAT_DTL &= "<td nowrap=" & """" & "nowrap" & """" & " style=" & """" & "" & """" & "><br>" & FNC_CNV_NUL(P1.Rows(ix).Item(iy), "0") & "</td>"
                            Case "DateTime", "TimeSpan"
                                D_DAT_DTL &= "<td nowrap=" & """" & "nowrap" & """" & " style=" & """" & "" & """" & "><br>" & Format(FNC_CNV_NUL(P1.Rows(ix).Item(iy), Nothing), "yyyy/MM/dd HH:mm:ss") & "</td>"
                            Case "Byte[]"
                                '
                                '空で出力
                                '
                                D_DAT_DTL &= "<td nowrap=" & """" & "nowrap" & """" & " style=" & """" & "" & """" & "><br></td>"
                            Case Else
                                D_DAT_DTL &= "<td nowrap=" & """" & "nowrap" & """" & " style=" & """" & "" & """" & "><br>" & FNC_CNV_NUL(P1.Rows(ix).Item(iy), "") & "</td>"
                        End Select
                    End If
                Next
                D_DAT_DTL &= "</tr>"
                D_STM_WIT.Write(D_DAT_DTL)
                D_DAT_DTL = ""
            Next
            '
            D_DAT_END = "</table></body></html>"
            D_STM_WIT.Write(D_DAT_END)
            '
            D_STM_WIT.Flush()
            D_STM_WIT.Close()
            '
            D_STM = Nothing
            D_STM_WIT = Nothing
            '
            '指定ディレクトリにコピー
            '
            FileCopy(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), OP1 & D_SAV_DLG.FileName)
            OP2 = D_SAV_DLG.FileName.Trim
            '
            '1000ミリ秒 (1秒) 待機する
            System.Threading.Thread.Sleep(1000)
            '
            '確認メッセージ
            If (Not _SynchronizingObject Is Nothing) AndAlso OP4 = True Then
                _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果"})
            ElseIf OP4 = True Then
                MsgBox(OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果")
            End If
            D_RTN = True
            '
        Catch ex As Exception
            Throw ex
        Finally
            'ﾜｰｸﾌｧｲﾙ削除
            If File.Exists(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2) Then
                Kill(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2)
            End If
            If OP3 Then P_FRM_WIT.Hide()
            D_SAV_DLG = Nothing
        End Try
EXIT_FUNCTION:
        FNC_XLS_EXP = D_RTN
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：EXCELﾌｧｲﾙ作成/保存
    '*
    '*  引数　　：1.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            2.ﾌｧｲﾙ名
    '*            3.ｼｰﾄ名
    '* 
    '*            1.ｵﾌﾟｼｮﾝ 既定ﾊﾟｽ[ﾃﾞｨﾚｸﾄﾘ]
    '*            2.ｵﾌﾟﾘｮﾝ ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ[シート名]
    '*            3.ｵﾌﾟｼｮﾝ 待機画面(True.表示、False.非表示[ﾃﾞﾌｫﾙﾄ])
    '*            4.ｵﾌﾟｼｮﾝ 確認ﾒｯｾｰｼﾞ(True.表示、False.非表示[ﾃﾞﾌｫﾙﾄ])
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_XLS(ByRef P1 As DataTable,
                                       ByVal P2 As String,
                                       ByVal P3 As String,
                                       Optional ByVal OP1 As String = "",
                                       Optional ByVal OP2 As String = "",
                                       Optional ByVal OP3 As Boolean = False,
                                       Optional ByVal OP4 As Boolean = False) As Boolean
        Dim D_RTN As Boolean = False
        Dim D_DAT_DTL As String = ""
        Dim D_SAV_DLG As New SaveFileDialog
        Dim xlApplication As New Excel.Application
        Dim D_SHT_NAM As String = "WORK_EXCEL"  'シート名
        Dim D_HED As New ArrayList              'ヘッダー名称のリスト
        Dim D_COLIDX As Integer = 1             '書式設定列番号
        Dim startX As Integer = 1               'ｾﾙ値設定
        Dim startY As Integer = 2               'ｾﾙ値設定
        Dim addX As Integer = 0                 'ｾﾙ値設定
        Dim addY As Integer = 0                 'ｾﾙ値設定
        Dim D_MSG_FLG As Integer = 0            'メーッセージフラグ
        '
        ' COM オブジェクトの解放を保証するために Try ～ Finally を使用する
        '
        Try
            'シート名取得
            '
            If Not P3.Equals("") Then
                D_SHT_NAM = P3
            End If
            '
            For Each col As System.Data.DataColumn In P1.Columns
                D_HED.Add(col.ColumnName)
            Next
            If OP3 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_XLS)
            System.Windows.Forms.Application.DoEvents()
            '
            'ﾜｰｸﾃﾞｨﾚｸﾄﾘ作成
            '
            If Not Directory.Exists(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS) Then
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS)
            End If
            '
            xlApplication.DisplayAlerts = False     '警告メッセージなどを表示しないようにする
            '
            Dim xlBooks As Excel.Workbooks = xlApplication.Workbooks
            Try
                Dim xlBook As Excel.Workbook = xlBooks.Add()
                Try
                    Dim xlSheets As Excel.Sheets = xlBook.Worksheets
                    Try
                        Dim xlSheet As Excel.Worksheet = DirectCast(xlSheets(1), Excel.Worksheet)
                        Try
                            'シート名
                            xlSheet.Name = D_SHT_NAM
                            Dim xlCells As Excel.Range = xlSheet.Cells
                            Try
                                Dim xlRange As Excel.Range = Nothing
                                Dim xlRange3 As Excel.Range = Nothing
                                Dim xlInterior As Excel.Interior = Nothing
                                Dim xlBorders As Excel.Borders = Nothing
                                Dim xlBorder As Excel.Border = Nothing
                                Try
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    'ヘッダ設定
                                    For i As Integer = 0 To D_HED.Count - 1
                                        Try
                                            '開放
                                            If Not xlRange Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                            End If
                                            xlRange = DirectCast(xlSheet.Cells(1, i + 1), Excel.Range)
                                            xlRange.Value2 = D_HED.Item(i)
                                            xlRange.HorizontalAlignment = 3 '中央揃え
                                            '
                                            xlInterior = xlRange.Interior
                                            xlInterior.ColorIndex = 35
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlInterior)
                                            xlInterior = Nothing
                                            '
                                            ''罫線
                                            xlBorders = xlRange.Borders
                                            xlBorders.LineStyle = 1
                                            xlBorders.ColorIndex = 1
                                            '左
                                            xlBorder = xlBorders(1)
                                            xlBorder.Weight = 1
                                            '右
                                            xlBorder = xlBorders(2)
                                            xlBorder.Weight = 1
                                            '上
                                            xlBorder = xlBorders(3)
                                            xlBorder.Weight = 1
                                            '下
                                            xlBorder = xlBorders(4)
                                            xlBorder.Weight = 1
                                        Finally
                                            If Not xlBorder Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorder)
                                                xlBorder = Nothing
                                            End If
                                            If Not xlBorders Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorders)
                                                xlBorders = Nothing
                                            End If
                                            If Not xlInterior Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlInterior)
                                                xlInterior = Nothing
                                            End If
                                            If Not xlRange Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                                xlRange = Nothing
                                            End If
                                        End Try
                                    Next
                                    '
                                    '明細設定
                                    'DataTableを二次元配列に格納
                                    Dim D_DAT(P1.Rows.Count - 1, P1.Columns.Count - 1) As Object
                                    For Y As Integer = 0 To P1.Rows.Count - 1
                                        For X As Integer = 0 To P1.Columns.Count - 1
                                            D_DAT(Y, X) = P1.Rows(Y)(X).ToString
                                        Next
                                    Next
                                    '開放
                                    If Not xlBorder Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorder)
                                        xlBorder = Nothing
                                    End If
                                    If Not xlBorders Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorders)
                                        xlBorders = Nothing
                                    End If
                                    If Not xlInterior Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlInterior)
                                        xlInterior = Nothing
                                    End If
                                    If Not xlRange Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                        xlRange = Nothing
                                    End If
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    Try
                                        '範囲指定
                                        addX = UBound(D_DAT, 2)
                                        addY = UBound(D_DAT)
                                        xlRange3 = xlSheet.Range(xlCells(startY, startX), xlCells(startY + addY, startX + addX))
                                        '
                                        '貼り付け
                                        xlRange3.Value = D_DAT
                                        '開放
                                        If Not xlRange3 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange3)
                                            xlRange3 = Nothing
                                        End If
                                    Finally
                                        '開放
                                        If Not xlRange3 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange3)
                                            xlRange3 = Nothing
                                        End If
                                    End Try
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    'ﾜｰｸﾃﾞｨﾚｸﾄﾘへ保存
                                    xlBook.SaveAs(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2)
                                    '
                                    'ﾌｧｲﾙ保存
                                    D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
                                    D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
                                    D_SAV_DLG.FileName = P2
                                    D_SAV_DLG.Filter = "XLS Files (*" & C_FIL_XLS_EXN & ")|*" & C_FIL_XLS_EXN & "|All Files (*.*)|*.*"
                                    D_SAV_DLG.OverwritePrompt = True
                                    '
                                    '指定ﾃﾞｨﾚｸﾄﾘ作成
                                    If Not Directory.Exists(OP1) Then
                                        Directory.CreateDirectory(OP1)
                                    End If
                                    '指定ディレクトリにコピー
                                    FileCopy(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), OP1 & D_SAV_DLG.FileName)
                                    OP2 = D_SAV_DLG.FileName.Trim
                                    '確認メッセージ
                                    If (Not _SynchronizingObject Is Nothing) AndAlso OP4 = True Then
                                        _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果"})
                                    ElseIf OP4 = True Then
                                        D_MSG_FLG = 1
                                    End If
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    'EXCEL終了確認
                                    Dim st As Integer = System.Environment.TickCount
                                    Do While System.Environment.TickCount - st < 10000  '5000
                                        System.Windows.Forms.Application.DoEvents()
                                        System.Threading.Thread.Sleep(500)
                                        If Process.GetProcessesByName("Excel").Length = 0 Then
                                            'MessageBox.Show("Excel.EXE は解放されました。")
                                            'Debug.WriteLine("▲▲▲▲▲Excel.EXE は解放されました。")
                                            Exit Do
                                        End If
                                    Loop
                                    If Process.GetProcessesByName("Excel").Length >= 1 OrElse Process.GetProcessesByName("EXCEL").Length >= 1 Then
                                        If D_MSG_FLG.Equals(1) Then
                                            MsgBox(OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果")
                                            D_MSG_FLG = 2
                                        End If
                                        '
                                        '解放
                                        If Not xlBorder Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorder)
                                            xlBorder = Nothing
                                        End If
                                        If Not xlBorders Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorders)
                                            xlBorders = Nothing
                                        End If
                                        If Not xlInterior Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlInterior)
                                            xlInterior = Nothing
                                        End If
                                        If Not xlRange3 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange3)
                                            xlRange3 = Nothing
                                        End If
                                        If Not xlRange Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                            xlRange = Nothing
                                        End If
                                    End If
                                    'メッセージが表示されていない場合には表示する
                                    If D_MSG_FLG.Equals(1) Then
                                        MsgBox(OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果")
                                        D_MSG_FLG = 2
                                    End If
                                    '
                                    'EXCEL終了確認
                                    Dim st2 As Integer = System.Environment.TickCount
                                    Do While System.Environment.TickCount - st2 < 10000  '5000
                                        System.Windows.Forms.Application.DoEvents()
                                        System.Threading.Thread.Sleep(500)
                                        If Process.GetProcessesByName("Excel").Length = 0 Then
                                            'MessageBox.Show("Excel.EXE は解放されました。")
                                            'Debug.WriteLine("■■■■■Excel.EXE は解放されました。")
                                            Exit Do
                                        End If
                                    Loop
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                Finally
                                    '解放
                                    If Not xlBorder Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorder)
                                        xlBorder = Nothing
                                    End If
                                    If Not xlBorders Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorders)
                                        xlBorders = Nothing
                                    End If
                                    If Not xlInterior Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlInterior)
                                        xlInterior = Nothing
                                    End If
                                    If Not xlRange3 Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange3)
                                        xlRange3 = Nothing
                                    End If
                                    If Not xlRange Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                        xlRange = Nothing
                                    End If
                                End Try
                            Finally
                                If Not xlCells Is Nothing Then
                                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlCells)
                                    xlCells = Nothing
                                End If
                            End Try
                        Finally
                            If Not xlSheet Is Nothing Then
                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheet)
                                xlSheet = Nothing
                            End If
                        End Try
                    Finally
                        If Not xlSheets Is Nothing Then
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheets)
                            xlSheets = Nothing
                        End If
                    End Try
                Finally
                    If Not xlBook Is Nothing Then
                        Try
                            xlBook.Close(False)
                        Finally
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook)
                            xlBook = Nothing
                        End Try
                    End If
                End Try
            Finally
                If Not xlBooks Is Nothing Then
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBooks)
                    xlBooks = Nothing
                End If
            End Try
            xlApplication.DisplayAlerts = True      '元に戻す
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            If Not xlApplication Is Nothing Then
                Try
                    xlApplication.Quit()
                Finally
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApplication)
                End Try
            End If
            GC.Collect()
            GC.Collect(2)
            If OP3 Then P_FRM_WIT.Hide()
            D_SAV_DLG = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_XLS = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：COMｵﾌﾞｼﾞｪｸﾄ開放
    '*
    '*  引数　　：COMｵﾌﾞｼﾞｪｸﾄ
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Private Shared Sub ReleaseComObject(ByRef P1 As Object)
        '
        Try
            If Not P1 Is Nothing Then
                System.Runtime.InteropServices.Marshal.ReleaseComObject(P1)
            End If
        Finally
            P1 = Nothing
        End Try
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：EXCELﾌｧｲﾙ作成/保存(.xlsx版)
    '*
    '*  引数　　：1.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            2.ﾌｧｲﾙ名
    '*            3.ｼｰﾄ名
    '* 
    '*            1.ｵﾌﾟｼｮﾝ 既定ﾊﾟｽ[ﾃﾞｨﾚｸﾄﾘ]
    '*            2.ｵﾌﾟﾘｮﾝ ﾀﾞｲｱﾛｸﾞﾀｲﾄﾙ[シート名]
    '*            3.ｵﾌﾟｼｮﾝ 待機画面(True.表示、False.非表示[ﾃﾞﾌｫﾙﾄ])
    '*            4.ｵﾌﾟｼｮﾝ 確認ﾒｯｾｰｼﾞ(True.表示、False.非表示[ﾃﾞﾌｫﾙﾄ])
    '*            5.ｵﾌﾟｼｮﾝ 呼び出し元プログラム
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_XLSX(ByRef P1 As DataTable,
                                        ByVal P2 As String,
                                        ByVal P3 As String,
                                        Optional ByVal OP1 As String = "",
                                        Optional ByVal OP2 As String = "",
                                        Optional ByVal OP3 As Boolean = False,
                                        Optional ByVal OP4 As Boolean = False,
                                        Optional ByVal OP5 As String = "") As Boolean
        Dim D_RTN As Boolean = False
        Dim D_DAT_DTL As String = ""
        Dim D_SAV_DLG As New SaveFileDialog
        Dim xlApplication As New Excel.Application
        Dim D_SHT_NAM As String = "WORK_EXCEL"  'シート名
        Dim D_HED As New ArrayList              'ヘッダー名称のリスト
        Dim startX As Integer = 1               'ｾﾙ値設定
        Dim startY As Integer = 2               'ｾﾙ値設定
        Dim addX As Integer = 0                 'ｾﾙ値設定
        Dim addY As Integer = 0                 'ｾﾙ値設定
        Dim D_MSG_FLG As Integer = 0            'メッセージフラグ
        '
        ' COM オブジェクトの解放を保証するために Try ～ Finally を使用する
        Try
            'シート名取得
            '
            If Not P3.Equals("") Then
                D_SHT_NAM = P3
            End If
            '
            For Each col As System.Data.DataColumn In P1.Columns
                D_HED.Add(col.ColumnName)
            Next
            '
            If OP3 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_XLS) : System.Windows.Forms.Application.DoEvents()
            '
            'ﾜｰｸﾃﾞｨﾚｸﾄﾘ作成
            '
            If Not Directory.Exists(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS) Then
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS)
            End If
            '
            xlApplication.DisplayAlerts = False     '警告メッセージなどを表示しないようにする
            '
            Dim xlBooks As Excel.Workbooks = xlApplication.Workbooks
            Try
                Dim xlBook As Excel.Workbook = xlBooks.Add()
                Try
                    Dim xlSheets As Excel.Sheets = xlBook.Worksheets
                    Try
                        Dim xlSheet As Excel.Worksheet = DirectCast(xlSheets(1), Excel.Worksheet)
                        Try
                            'シート名
                            xlSheet.Name = D_SHT_NAM
                            Dim xlCells As Excel.Range = xlSheet.Cells
                            Try
                                Dim xlRange As Excel.Range = Nothing
                                Dim xlRange3 As Excel.Range = Nothing
                                Dim xlInterior As Excel.Interior = Nothing
                                Dim xlBorders As Excel.Borders = Nothing
                                Dim xlBorder As Excel.Border = Nothing
                                Try
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    'ヘッダ設定
                                    For i As Integer = 0 To D_HED.Count - 1
                                        Try
                                            '開放
                                            If Not xlRange Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                            End If
                                            xlRange = DirectCast(xlSheet.Cells(1, i + 1), Excel.Range)
                                            xlRange.Value2 = D_HED.Item(i)
                                            xlRange.HorizontalAlignment = 3 '中央揃え
                                            '
                                            xlInterior = xlRange.Interior
                                            xlInterior.ColorIndex = 35
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlInterior)
                                            xlInterior = Nothing
                                            '
                                            ''罫線
                                            xlBorders = xlRange.Borders
                                            xlBorders.LineStyle = 1
                                            xlBorders.ColorIndex = 1
                                            '左
                                            xlBorder = xlBorders(1)
                                            xlBorder.Weight = 1
                                            '右
                                            xlBorder = xlBorders(2)
                                            xlBorder.Weight = 1
                                            '上
                                            xlBorder = xlBorders(3)
                                            xlBorder.Weight = 1
                                            '下
                                            xlBorder = xlBorders(4)
                                            xlBorder.Weight = 1
                                        Finally
                                            If Not xlBorder Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorder)
                                                xlBorder = Nothing
                                            End If
                                            If Not xlBorders Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorders)
                                                xlBorders = Nothing
                                            End If
                                            If Not xlInterior Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlInterior)
                                                xlInterior = Nothing
                                            End If
                                            If Not xlRange Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                                xlRange = Nothing
                                            End If
                                        End Try
                                    Next
                                    '
                                    '明細設定
                                    'DataTableを二次元配列に格納
                                    Dim D_DAT(P1.Rows.Count - 1, P1.Columns.Count - 1) As Object
                                    For Y As Integer = 0 To P1.Rows.Count - 1
                                        For X As Integer = 0 To P1.Columns.Count - 1
                                            D_DAT(Y, X) = P1.Rows(Y)(X).ToString
                                        Next
                                    Next
                                    '開放
                                    If Not xlBorder Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorder)
                                        xlBorder = Nothing
                                    End If
                                    If Not xlBorders Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorders)
                                        xlBorders = Nothing
                                    End If
                                    If Not xlInterior Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlInterior)
                                        xlInterior = Nothing
                                    End If
                                    If Not xlRange Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                        xlRange = Nothing
                                    End If
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    Try
                                        '範囲指定
                                        addX = UBound(D_DAT, 2)
                                        addY = UBound(D_DAT)
                                        xlRange3 = xlSheet.Range(xlCells(startY, startX), xlCells(startY + addY, startX + addX))
                                        '
                                        If OP5.Equals("Frm_EI101_RPT") Then
                                            xlRange3.Columns("A").NumberFormatLocal = "@"
                                            xlRange3.Columns("L").NumberFormatLocal = "@"
                                            xlRange3.Columns("P").NumberFormatLocal = "@"
                                            xlRange3.Columns("T").NumberFormatLocal = "@"
                                            xlRange3.Columns("X").NumberFormatLocal = "@"
                                            xlRange3.Columns("AB").NumberFormatLocal = "@"
                                            xlRange3.Columns("AF").NumberFormatLocal = "@"
                                            xlRange3.Columns("AJ").NumberFormatLocal = "@"
                                            xlRange3.Columns("K").NumberFormatLocal = "#,##0"
                                        End If
                                        '
                                        '貼り付け
                                        xlRange3.Value = D_DAT
                                        '開放
                                        If Not xlRange3 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange3)
                                            xlRange3 = Nothing
                                        End If
                                    Finally
                                        '開放
                                        If Not xlRange3 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange3)
                                            xlRange3 = Nothing
                                        End If
                                    End Try
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    'ﾜｰｸﾃﾞｨﾚｸﾄﾘへ保存
                                    xlBook.SaveAs(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2)
                                    '
                                    'ﾌｧｲﾙ保存
                                    D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
                                    D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
                                    D_SAV_DLG.FileName = P2
                                    D_SAV_DLG.Filter = "XLS Files (*.xlsx)|*.xlsx|All Files (*.*)|*.*"
                                    D_SAV_DLG.OverwritePrompt = True
                                    '
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    'EXCEL終了確認
                                    Dim st As Integer = System.Environment.TickCount
                                    Do While System.Environment.TickCount - st < 10000  '5000
                                        System.Windows.Forms.Application.DoEvents()
                                        System.Threading.Thread.Sleep(500)
                                        If Process.GetProcessesByName("Excel").Length = 0 Then
                                            Exit Do
                                        End If
                                    Loop
                                    If Process.GetProcessesByName("Excel").Length >= 1 OrElse Process.GetProcessesByName("EXCEL").Length >= 1 Then
                                        'If D_MSG_FLG.Equals(1) Then
                                        '    MsgBox(OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果")
                                        '    D_MSG_FLG = 2
                                        'End If
                                        '
                                        '解放
                                        If Not xlBorder Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorder)
                                            xlBorder = Nothing
                                        End If
                                        If Not xlBorders Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorders)
                                            xlBorders = Nothing
                                        End If
                                        If Not xlInterior Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlInterior)
                                            xlInterior = Nothing
                                        End If
                                        If Not xlRange3 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange3)
                                            xlRange3 = Nothing
                                        End If
                                        If Not xlRange Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                            xlRange = Nothing
                                        End If
                                    End If
                                    '
                                    'EXCEL終了確認
                                    Dim st2 As Integer = System.Environment.TickCount
                                    Do While System.Environment.TickCount - st2 < 10000  '5000
                                        System.Windows.Forms.Application.DoEvents()
                                        System.Threading.Thread.Sleep(500)
                                        If Process.GetProcessesByName("Excel").Length = 0 Then
                                            Exit Do
                                        End If
                                    Loop
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    '指定ﾃﾞｨﾚｸﾄﾘ作成
                                    If Not Directory.Exists(OP1) Then
                                        Directory.CreateDirectory(OP1)
                                    End If
                                    '指定ディレクトリにコピー
                                    FileCopy(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), OP1 & D_SAV_DLG.FileName)
                                    OP2 = D_SAV_DLG.FileName.Trim
                                    '確認メッセージ
                                    If (Not _SynchronizingObject Is Nothing) AndAlso OP4 = True Then
                                        _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果"})
                                    ElseIf OP4 = True Then
                                        D_MSG_FLG = 1
                                    End If
                                    'メッセージが表示されていない場合には表示する
                                    If D_MSG_FLG.Equals(1) Then
                                        MsgBox(OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果")
                                        D_MSG_FLG = 2
                                    End If
                                    '
                                Finally
                                    '解放
                                    If Not xlBorder Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorder)
                                        xlBorder = Nothing
                                    End If
                                    If Not xlBorders Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBorders)
                                        xlBorders = Nothing
                                    End If
                                    If Not xlInterior Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlInterior)
                                        xlInterior = Nothing
                                    End If
                                    If Not xlRange3 Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange3)
                                        xlRange3 = Nothing
                                    End If
                                    If Not xlRange Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                        xlRange = Nothing
                                    End If
                                End Try
                            Finally
                                If Not xlCells Is Nothing Then
                                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlCells)
                                    xlCells = Nothing
                                End If
                            End Try
                        Finally
                            If Not xlSheet Is Nothing Then
                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheet)
                                xlSheet = Nothing
                            End If
                        End Try
                    Finally
                        If Not xlSheets Is Nothing Then
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheets)
                            xlSheets = Nothing
                        End If
                    End Try
                Finally
                    If Not xlBook Is Nothing Then
                        Try
                            xlBook.Close(False)
                        Finally
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook)
                            xlBook = Nothing
                        End Try
                    End If
                End Try
            Finally
                If Not xlBooks Is Nothing Then
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBooks)
                    xlBooks = Nothing
                End If
            End Try
            xlApplication.DisplayAlerts = True      '元に戻す
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            If Not xlApplication Is Nothing Then
                Try
                    xlApplication.Quit()
                Finally
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApplication)
                End Try
            End If
            GC.Collect()
            GC.Collect(2)
            If OP3 Then P_FRM_WIT.Hide()
            D_SAV_DLG = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_XLSX = D_RTN
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：EXCELﾌｧｲﾙ作成/保存
    '*
    '*  引数　　：1.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            2.ﾌｧｲﾙ名
    '*            3.ｼｰﾄ名
    '* 
    '*            1.ｵﾌﾟｼｮﾝ 既定ﾊﾟｽ
    '*            2.ｵﾌﾟﾘｮﾝ ﾀﾞｲﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_XLS1(ByRef P1 As DataTable,
                                        ByVal P2 As String,
                                        ByVal P3 As String,
                                        Optional ByVal OP1 As String = "",
                                        Optional ByVal OP2 As String = "",
                                        Optional ByVal OP3 As Boolean = False) As Boolean
        Dim D_RTN As Boolean = False
        Dim D_SAV_DLG As New SaveFileDialog
        Dim D_SHT_NAM As String = "WORK_EXCEL"  'シート名
        Dim D_HED As New ArrayList              'ヘッダー名称のリスト
        Dim D_COLIDX As Integer = 1             '書式設定列番号
        Dim startX As Integer = 1               'ｾﾙ値設定
        Dim startY As Integer = 2               'ｾﾙ値設定
        Dim addX As Integer = 0                 'ｾﾙ値設定
        Dim addY As Integer = 0                 'ｾﾙ値設定
        Dim xlApplication As Excel.Application
        '
        ' COM オブジェクトの解放を保証するために Try ～ Finally を使用する
        Try
            'シート名取得
            '
            If Not P3.Equals("") Then
                D_SHT_NAM = P3
            End If
            '
            For Each col As System.Data.DataColumn In P1.Columns
                D_HED.Add(col.ColumnName)
            Next
            If OP3 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_XLS) : System.Windows.Forms.Application.DoEvents()
            '
            'ﾜｰｸﾃﾞｨﾚｸﾄﾘ作成
            '
            If Not Directory.Exists(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS) Then
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS)
            End If
            '
            xlApplication = New Excel.Application
            xlApplication.DisplayAlerts = False     '警告メッセージなどを表示しないようにする
            '
            Dim xlBooks As Excel.Workbooks = xlApplication.Workbooks
            '
            Try
                Dim xlBook As Excel.Workbook = xlBooks.Add()
                '
                Try
                    Dim xlSheets As Excel.Sheets = xlBook.Worksheets
                    '
                    Try
                        Dim xlSheet As Excel.Worksheet = DirectCast(xlSheets(1), Excel.Worksheet)
                        '
                        Try
                            'シート名
                            xlSheet.Name = D_SHT_NAM : Dim xlCells As Excel.Range = xlSheet.Cells
                            '
                            Try
                                Dim xlRange As Excel.Range = Nothing
                                '
                                Try
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    'ヘッダ設定
                                    For i As Integer = 0 To D_HED.Count - 1
                                        Try
                                            '開放
                                            If Not xlRange Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                            End If
                                            xlRange = DirectCast(xlSheet.Cells(1, i + 1), Excel.Range)
                                            xlRange.Value2 = D_HED.Item(i)
                                        Finally
                                            If Not xlRange Is Nothing Then
                                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                            End If
                                        End Try
                                    Next
                                    If Not xlRange Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                    End If
                                    '
                                    'DataTableを二次元配列に格納
                                    Dim D_DAT(P1.Rows.Count - 1, P1.Columns.Count - 1) As Object
                                    For Y As Integer = 0 To P1.Rows.Count - 1
                                        For X As Integer = 0 To P1.Columns.Count - 1
                                            D_DAT(Y, X) = P1.Rows(Y)(X).ToString
                                        Next
                                    Next
                                    '開放
                                    If Not xlRange Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                    End If
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    Dim range1 As Excel.Range = Nothing
                                    Dim range2 As Excel.Range = Nothing
                                    Dim xlRange2 As Excel.Range = Nothing
                                    '
                                    Try
                                        'ｾﾙ書式設定
                                        For Each D_COL As DataColumn In P1.Columns
                                            For Each D_ROW As DataRow In P1.Rows
                                                If Not D_ROW.IsNull(D_COL) Then
                                                    '開放
                                                    If Not range1 Is Nothing Then
                                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(range1)
                                                    End If
                                                    If Not range2 Is Nothing Then
                                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(range2)
                                                    End If
                                                    If Not xlRange2 Is Nothing Then
                                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                                    End If
                                                    ReleaseComObject(DirectCast(xlRange2, Object))
                                                    ReleaseComObject(DirectCast(range1, Object))
                                                    ReleaseComObject(DirectCast(range2, Object))
                                                    Exit For
                                                End If
                                            Next
                                            D_COLIDX += 1
                                        Next
                                    Finally
                                        If Not xlRange2 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange2)
                                        End If
                                        If Not range1 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(range1)
                                        End If
                                        If Not range2 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(range2)
                                        End If
                                    End Try
                                    '
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    Dim xlRange3 As Excel.Range = Nothing
                                    Dim range3 As Excel.Range = Nothing
                                    Dim range4 As Excel.Range = Nothing
                                    '
                                    Try
                                        '範囲指定
                                        addX = UBound(D_DAT, 2)
                                        addY = UBound(D_DAT)
                                        xlRange3 = xlSheet.Range(xlCells(startY, startX), xlCells(startY + addY, startX + addX))
                                        ReleaseComObject(DirectCast(range3, Object))
                                        ReleaseComObject(DirectCast(range4, Object))
                                        '
                                        '貼り付け
                                        '
                                        xlRange3.Value = D_DAT
                                        '
                                        '開放
                                        '
                                        If Not xlRange3 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange3)
                                            xlRange3 = Nothing
                                        End If
                                        If Not range3 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(range3)
                                            range3 = Nothing
                                        End If
                                        If Not range4 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(range4)
                                            range4 = Nothing
                                        End If
                                    Finally
                                        '開放
                                        '
                                        If Not xlRange3 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange3)
                                            xlRange3 = Nothing
                                        End If
                                        If Not range3 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(range3)
                                            range3 = Nothing
                                        End If
                                        If Not range4 Is Nothing Then
                                            System.Runtime.InteropServices.Marshal.ReleaseComObject(range4)
                                            range4 = Nothing
                                        End If
                                    End Try
                                    '
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    'ﾜｰｸﾃﾞｨﾚｸﾄﾘへ保存
                                    xlBook.SaveAs(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2)
                                    '
                                    'ﾌｧｲﾙ保存
                                    D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
                                    D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
                                    D_SAV_DLG.FileName = P2
                                    D_SAV_DLG.Filter = "XLS Files (*" & C_FIL_XLS_EXN & ")|*" & C_FIL_XLS_EXN & "|All Files (*.*)|*.*"
                                    D_SAV_DLG.OverwritePrompt = True
                                    '
                                    '指定ﾃﾞｨﾚｸﾄﾘ作成
                                    If Not Directory.Exists(OP1) Then
                                        Directory.CreateDirectory(OP1)
                                    End If
                                    '指定ディレクトリにコピー
                                    FileCopy(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), OP1 & D_SAV_DLG.FileName)
                                    OP2 = D_SAV_DLG.FileName.Trim
                                    '
                                    ' 1000 ミリ秒 (1秒) 待機する
                                    System.Threading.Thread.Sleep(1000)
                                    '
                                    '確認メッセージ
                                    If Not _SynchronizingObject Is Nothing Then
                                        _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果"})
                                    Else
                                        MsgBox(OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果")
                                    End If
                                    '
                                Finally
                                    If Not xlRange Is Nothing Then
                                        System.Runtime.InteropServices.Marshal.ReleaseComObject(xlRange)
                                    End If
                                End Try
                            Finally
                                If Not xlCells Is Nothing Then
                                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlCells)
                                End If
                            End Try
                        Finally
                            If Not xlSheet Is Nothing Then
                                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheet)
                            End If
                        End Try
                    Finally
                        If Not xlSheets Is Nothing Then
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlSheets)
                        End If
                    End Try
                Finally
                    If Not xlBook Is Nothing Then
                        Try
                            xlBook.Close(False)
                        Finally
                            System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBook)
                        End Try
                    End If
                End Try
            Finally
                If Not xlBooks Is Nothing Then
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlBooks)
                End If
            End Try
            xlApplication.DisplayAlerts = True      '元に戻す
            D_RTN = True
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            If Not xlApplication Is Nothing Then
                Try
                    xlApplication.Quit()    'Excelを閉じる
                Finally
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApplication)  '解放
                End Try
            End If
            GC.Collect()
            GC.Collect(2)
            'ﾜｰｸﾌｧｲﾙ削除
            If File.Exists(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2) Then
                Kill(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2)
            End If
            System.Windows.Forms.Application.DoEvents()
            If OP3 Then P_FRM_WIT.Hide()
            D_SAV_DLG = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_XLS1 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：EXCELﾌｧｲﾙ作成/保存(HTML版)
    '*
    '*  引数　　：1.ﾃﾞｰﾀﾃﾌﾞﾙ
    '*            2.ﾌｧｲﾙ名
    '* 
    '*            1.ｵﾌﾟｼｮﾝ 既定ﾊﾟｽ
    '*            2.ｵﾌﾟﾘｮﾝ ﾀﾞｲﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*
    '*  戻り値　：True.正常、False.異常
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_XLS3(ByRef P1 As DataTable, ByVal P2 As String,
                                        Optional ByVal OP1 As String = "",
                                        Optional ByVal OP2 As String = "",
                                        Optional ByVal OP3 As Boolean = False) As Boolean
        Dim I As Integer
        Dim X As Integer
        Dim D_RTN As Boolean = False
        Dim D_RES As DialogResult
        Dim D_DAT_HED As String = ""
        Dim D_DAT_DTL As String = ""
        Dim D_SAV_DLG As New SaveFileDialog
        '
        Try
            'ﾌｧｲﾙ保存
            '
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            D_SAV_DLG.FileName = P2.Replace("／" & C_APP_VER & C_APP_UPD, "") & C_FIL_XLS_EXN
            D_SAV_DLG.Filter = "XLS Files (*" & C_FIL_XLS_EXN & ")|*" & C_FIL_XLS_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            '
            If OP3 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_XLS)
            '
            'ﾌｧｲﾙ作成
            If Not Directory.Exists(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS) Then
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS)
            End If
            '
            Dim D_STM As Stream = File.Open(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), FileMode.Create, FileAccess.ReadWrite, FileShare.None)
            Dim D_STM_WIT As New StreamWriter(D_STM, System.Text.Encoding.Default)
            '
            For I = 0 To P1.Columns.Count - 1 Step 1
                D_DAT_HED = D_DAT_HED & """" & P1.Columns(I).Caption & ""","
            Next
            D_STM_WIT.WriteLine(Mid(D_DAT_HED, 1, D_DAT_HED.Length - 1))
            I = 0
            For I = 0 To P1.Rows.Count - 1 Step 1
                For X = 0 To P1.Columns.Count - 1 Step 1
                    Select Case P1.Columns(X).DataType.Name
                        Case "Byte", "Int16", "Int32", "Int64", "SByte", "UInt16", "UInt32", "UInt64", "Decimal", "Double", "Single"
                            D_DAT_DTL = D_DAT_DTL & FNC_CNV_NUL(P1.Rows(I).Item(X), "0") & ","
                        Case "DateTime", "TimeSpan"
                            D_DAT_DTL = D_DAT_DTL & """" & Format(FNC_CNV_NUL(P1.Rows(I).Item(X), Nothing), "yyyy/MM/dd hh:mm:ss") & ""","
                        Case "Byte[]"
                            '空で出力
                            D_DAT_DTL = D_DAT_DTL & """" & ""","
                        Case Else
                            D_DAT_DTL = D_DAT_DTL & """" & FNC_CNV_NUL(P1.Rows(I).Item(X), "") & ""","
                    End Select
                Next
                D_STM_WIT.WriteLine(Mid(D_DAT_DTL, 1, D_DAT_DTL.Length - 1))
                D_DAT_DTL = ""
            Next
            D_STM_WIT.Flush()
            D_STM_WIT.Close()
            D_STM = Nothing
            D_STM_WIT = Nothing
            '
            FileCopy(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), OP1 & D_SAV_DLG.FileName)
            OP2 = D_SAV_DLG.FileName.Trim
            Kill(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""))
            '
            If Not _SynchronizingObject Is Nothing Then
                _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果"})
            Else
                MsgBox(D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "結果")
            End If
            '
            D_RTN = True
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            If OP3 Then P_FRM_WIT.Hide()
            D_SAV_DLG = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_XLS3 = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：Excelﾌｧｲﾙ作成
    '*
    '*  引数　　：1.ﾃﾞｰﾀﾃﾌﾞﾙ
    '*            2.ﾌｧｲﾙ名
    '*            3.ｼｰﾄ名
    '* 
    '*            1.ｵﾌﾟｼｮﾝ 既定ﾊﾟｽ
    '*            2.ｵﾌﾟﾘｮﾝ ﾀﾞｲﾛｸﾞﾀｲﾄﾙ
    '*            3.[ｵﾌﾟｼｮﾝ] 待機画面(True.表示、False.非表示)
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_SAV_EXL9(ByVal P1 As DataTable, ByVal P2 As String, ByVal P3 As String,
                                       Optional ByVal OP1 As String = "",
                                       Optional ByVal OP2 As String = "",
                                       Optional ByVal OP3 As Boolean = False) As Boolean
        Dim D_RTN As Boolean = False
        Dim sheetName As String = "WORK_EXCEL"
        Dim D_SAV_DLG As New SaveFileDialog
        Dim xlsApplication As Excel.Application = Nothing
        Dim xlsBooks As Excel.Workbooks = Nothing
        Dim xlsBook As Excel.Workbook = Nothing
        Dim xlsSheets As Excel.Sheets = Nothing
        Dim xlsSheet As Excel.Worksheet = Nothing
        Dim xlsRange As Excel.Range = Nothing
        Dim range As Excel.Range = Nothing
        Dim range1 As Excel.Range = Nothing
        Dim range2 As Excel.Range = Nothing
        'ヘッダー名称のリスト
        Dim D_HED As New ArrayList
        '
        Dim D_COLIDX As Integer = 1 '書式設定列番号
        'ｾﾙ値設定
        Dim startX As Integer = 1
        Dim startY As Integer = 2
        '
        Try
            'シート名取得
            '
            If Not P3.Equals("") Then
                sheetName = P3
            End If
            '
            For Each col As System.Data.DataColumn In P1.Columns
                D_HED.Add(col.ColumnName)
            Next
            '
            If OP3 Then P_FRM_WIT.FNC_SET_MSG(C_MSG_OUT_XLS)
            System.Windows.Forms.Application.DoEvents()
            'ﾜｰｸﾃﾞｨﾚｸﾄﾘ作成
            If Not Directory.Exists(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS) Then
                Directory.CreateDirectory(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS)
            End If
            '
            'xlsApplication = New Excel.Application
            xlsApplication.DisplayAlerts = False '保存時の確認ﾀﾞｲｱﾛｸﾞを表示しない
            '
            xlsBooks = xlsApplication.Workbooks
            xlsBook = xlsBooks.Add
            xlsSheets = xlsBook.Worksheets
            '
            'ｼｰﾄのｲﾝﾃﾞｯｸｽは1から
            xlsSheet = DirectCast(xlsSheets.Item(1), Excel.Worksheet)
            xlsSheet.Name = sheetName
            '
            For i As Integer = 0 To D_HED.Count - 1
                xlsRange = DirectCast(xlsSheet.Cells(1, i + 1), Excel.Range)
                xlsRange.Value = D_HED.Item(i)
            Next
            ReleaseComObject(DirectCast(xlsRange, Object))
            '
            'DataTableを二次元配列に格納
            Dim D_DAT(P1.Rows.Count - 1, P1.Columns.Count - 1) As Object
            For Y As Integer = 0 To P1.Rows.Count - 1
                For X As Integer = 0 To P1.Columns.Count - 1
                    D_DAT(Y, X) = P1.Rows(Y)(X).ToString
                Next
            Next
            '
            'ｾﾙ書式設定
            'Dim D_COLIDX As Integer = 1 '書式設定列番号
            For Each D_COL As DataColumn In P1.Columns
                For Each D_ROW As DataRow In P1.Rows
                    If Not D_ROW.IsNull(D_COL) Then
                        '始点
                        range1 = DirectCast(xlsSheet.Cells(2, D_COLIDX), Excel.Range)
                        '終点
                        range2 = DirectCast(xlsSheet.Cells(2 + UBound(D_DAT), D_COLIDX), Excel.Range)
                        '範囲指定
                        range = xlsSheet.Range(range1, range2)
                        Select Case D_COL.DataType.Name
                            Case "Integer", "Long", "Short", "Byte", "Int16", "Int32", "Int64", "SByte", "UInt16", "UInt32", "UInt64", "Decimal", "Double", "Single"
                                'ｾﾙ書式を数値型に
                                range.NumberFormatLocal = "G/標準"
                            Case "DateTime", "TimeSpan"
                                range.NumberFormatLocal = "yyyy/mm/dd hh:mm"
                            Case "Byte[]"
                                'ｾﾙ書式を文字列型に
                                range.NumberFormatLocal = "@"
                            Case Else
                                'ｾﾙ書式を文字列型に
                                range.NumberFormatLocal = "@"
                        End Select
                        ReleaseComObject(DirectCast(range, Object))
                        ReleaseComObject(DirectCast(range1, Object))
                        ReleaseComObject(DirectCast(range2, Object))
                        Exit For
                    End If
                Next
                D_COLIDX += 1
            Next
            '
            '始点
            range1 = DirectCast(xlsSheet.Cells(startY, startX), Excel.Range)
            '終点
            range2 = DirectCast(xlsSheet.Cells(startY + UBound(D_DAT), startX + UBound(D_DAT, 2)), Excel.Range)
            '範囲指定
            range = xlsSheet.Range(range1, range2)
            '貼り付け
            range.Value = D_DAT
            '
            'ﾜｰｸﾃﾞｨﾚｸﾄﾘへ保存
            xlsBook.SaveAs(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2)
            '
            'ﾌｧｲﾙ保存
            D_SAV_DLG.Title = IIf(OP1.Equals(""), D_SAV_DLG.Title, OP1)
            D_SAV_DLG.InitialDirectory = IIf(OP2.Equals(""), D_SAV_DLG.InitialDirectory, OP2)
            D_SAV_DLG.FileName = P2
            D_SAV_DLG.Filter = "XLS Files (*" & C_FIL_XLS_EXN & ")|*" & C_FIL_XLS_EXN & "|All Files (*.*)|*.*"
            D_SAV_DLG.OverwritePrompt = True
            '
            '指定ﾃﾞｨﾚｸﾄﾘ作成
            If Not Directory.Exists(OP1) Then
                Directory.CreateDirectory(OP1)
            End If
            '指定ディレクトリにコピー
            FileCopy(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2.Replace("／" & C_APP_VER & C_APP_UPD, ""), OP1 & D_SAV_DLG.FileName)
            OP2 = D_SAV_DLG.FileName.Trim
            '確認メッセージ
            If Not _SynchronizingObject Is Nothing Then
                _SynchronizingObject.Invoke(New MsgBoxDelegate(AddressOf MsgBox), New Object() {OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果"})
            Else
                MsgBox(OP1 & D_SAV_DLG.FileName & vbCrLf & vbCrLf & "上記に保存致しました。", MsgBoxStyle.Information, "EXCEL作成結果")
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        Finally
            'ｴｸｾﾙ関係のｵﾌﾞｼﾞｪｸﾄは必ず解放する
            ReleaseComObject(DirectCast(range, Object))
            ReleaseComObject(DirectCast(range1, Object))
            ReleaseComObject(DirectCast(range2, Object))
            ReleaseComObject(DirectCast(xlsRange, Object))
            ReleaseComObject(DirectCast(xlsSheet, Object))
            ReleaseComObject(DirectCast(xlsSheets, Object))
            xlsBook.Close(False)
            ReleaseComObject(DirectCast(xlsBook, Object))
            ReleaseComObject(DirectCast(xlsBooks, Object))
            xlsApplication.Quit()
            ReleaseComObject(DirectCast(xlsApplication, Object))
            'ﾜｰｸﾌｧｲﾙ削除
            Kill(System.Windows.Forms.Application.StartupPath & "\" & C_DIR_XLS & "\" & P2)
            If OP3 Then P_FRM_WIT.Hide()
            D_SAV_DLG = Nothing
        End Try
EXIT_FUNCTION:
        FNC_SAV_EXL9 = D_RTN
        Exit Function
    End Function

End Class
