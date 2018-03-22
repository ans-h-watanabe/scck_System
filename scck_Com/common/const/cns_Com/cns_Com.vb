'機能概要*****************************************************************************************************
'*
'*  処理概要：定数
'*
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*
'*  更新日　：
'*  更新者　：
'*  更新内容：
'*
#Region " 旧履歴 "

'*  作成日　：2005/04/20
'*  作成者　：Ans赤沢(博)
'*　　▼
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*
'*  更新日　：2007/04/09
'*  更新者　：ANS落合 C_MOD_INQ_CLR, C_MOD_INQ_MSG, C_DIR_IMG を追記
'*
'*  更新日　：2008/03/11
'*  更新者　：軽部
'*  更新内容：C_MOD_ADD_UPD_CLR, C_MOD_ADD_UPD_MSG を追加
'*
'*  更新日　：2009/07/29
'*  更新者　：村上
'*  更新内容：ﾄﾗｽﾄ用にC_COM_CLR_006を追加
'*
'*  更新者　：村上
'*  更新日　：2010/01/22
'*  更新内容：事業所コード変更対応[処理ﾓｰﾄﾞ配色]
'*
'*  更新者　：渡辺
'*  更新日　：2017/11/06
'*  更新内容：ﾒﾝﾃｯｸ､ｱｸｱ用の画面背景色を追加

#End Region
'*
'*************************************************************************************************************
'*************************************************************************************************************
'*  ｲﾝﾎﾟｰﾄ
'*************************************************************************************************************
'*************************************************************************************************************
'*  ｸﾗｽ
'*************************************************************************************************************
Imports System.Drawing
Public Class cns_Com

    '*********************************************************************************************************
    '*  ﾒﾝﾊﾞ変数1
    '*********************************************************************************************************
    Public Shared C_APP_VER As String = " Ver.1.2.1_182" 'ﾊﾞｰｼﾞｮﾝ
    Public Shared C_APP_UPD As String = "(2018/03/02 09:30)" '最終更新日時
    '
    'WEBｻｰﾋﾞｽﾀｲﾑｱｳﾄ
    Public Shared C_WEB_TIM_OUT As Integer = 600000 '10分
    '
    'ﾌｧｲﾙ名
    Public Shared C_FIL_HST_NAM As String = "WebHost.ini" 'ﾎｽﾄ名格納
    '
    '処理ﾓｰﾄﾞ配色
    Public Shared C_COM_CLR_001 As Color = SystemColors.Control
    Public Shared C_COM_CLR_004 As Color = Color.AntiqueWhite
    Public Shared C_COM_CLR_005 As Color = Color.WhiteSmoke
    Public Shared C_COM_CLR_002 As Color = Color.LightSteelBlue
    '
    'Public Shared C_COM_CLR_002 As Color = Color.Honeydew
    'Public Shared C_COM_CLR_003 As Color = Color.Lavender
    '
    '▼2017.11.06
    Public Shared C_COM_CLR_006 As Color = Color.PowderBlue
    Public Shared C_COM_CLR_007 As Color = Color.Beige

    '処理ﾓｰﾄﾞ配色
    Public Shared C_MOD_ADD_CLR As Color = Color.FromArgb(CType(175, Byte), CType(238, Byte), CType(238, Byte))
    Public Shared C_MOD_UPD_CLR As Color = Color.FromArgb(CType(255, Byte), CType(255, Byte), CType(192, Byte))
    Public Shared C_MOD_DEL_CLR As Color = Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
    Public Shared C_MOD_FND_CLR As Color = Color.White
    Public Shared C_MOD_RPT_CLR As Color = Color.White
    Public Shared C_MOD_MNU_CLR As Color = Color.White
    Public Shared C_MOD_BAC_CLR As Color = Color.White
    Public Shared C_MOD_INQ_CLR As Color = Color.White
    Public Shared C_MOD_ADD_UPD_CLR As Color = Color.White

    Public Shared C_BAK_ACT_CLR As Color = SystemColors.Info
    'Public Shared C_BAK_DEL_CLR As Color = Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))
    'Public Shared C_BAK_DEL_CLR As Color = Color.Red
    Public Shared C_BAK_DEL_CLR As Color = Color.FromArgb(CType(255, Byte), CType(99, Byte), CType(71, Byte))
    Public Shared C_FNT_ACT_CLR As Color = Color.Black
    Public Shared C_FNT_DEL_CLR As Color = Color.White

    '処理ﾓｰﾄﾞﾒｯｾｰｼﾞ
    Public Shared C_MOD_ADD_MSG As String = "新  規"
    Public Shared C_MOD_UPD_MSG As String = "修  正"
    Public Shared C_MOD_DEL_MSG As String = "削  除"
    Public Shared C_MOD_FND_MSG As String = "検  索"
    Public Shared C_MOD_RPT_MSG As String = "出  力"
    Public Shared C_MOD_MNU_MSG As String = "処理を選択して下さい"
    Public Shared C_MOD_BAC_MSG As String = "更  新"
    Public Shared C_MOD_INQ_MSG As String = "問  合"
    Public Shared C_MOD_ADD_UPD_MSG As String = "新  規　／　修  正"
    '処理ﾎﾞﾀﾝ
    Public Shared C_BTN_MSG_REG As String = "登録"
    Public Shared C_BTN_MSG_EXC As String = "実行"
    Public Shared C_BTN_MSG_CCL As String = "取込ｷｬﾝｾﾙ"
    Public Shared C_BTN_MSG_RPT As String = "出力"
    Public Shared C_BTN_MSG_RTN As String = "戻る"

    'ﾃｷｽﾄﾌｫｰｶｽ取得時配色
    Public Shared C_TXT_GOT_CLR As Color = Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
    'ﾃｷｽﾄﾌｫｰｶｽ消失時配色
    Public Shared C_TXT_LST_CLR As Color = SystemColors.Window
    'ﾃｷｽﾄｴﾗｰ時配色
    Public Shared C_ERR_CLR As Color = Color.FromArgb(CType(255, Byte), CType(192, Byte), CType(192, Byte))

    'ﾎﾞﾀﾝﾌｫｰｶｽ取得時配色
    Public Shared C_BTN_GOT_CLR As Color = Color.FromArgb(CType(192, Byte), CType(255, Byte), CType(255, Byte))
    'ﾎﾞﾀﾝﾌｫｰｶｽ消失時配色
    Public Shared C_BTN_LST_CLR As Color = SystemColors.Control

    'ｴﾗｰ発生時ﾏｰｸ表示幅
    Public Shared C_ERR_WID As Integer = 20
    '
    '検索結果配色
    Public Shared C_LST_NOT_CLR As Color = Color.Red
    Public Shared C_LST_GET_CLR As Color = Color.RoyalBlue
    Public Shared C_LST_NTL_CLR As Color = Color.Black

    '格納ﾃﾞｲﾚｸﾄﾘ
    Public Shared C_DIR_LST As String = "_▼Parameter\List"
    Public Shared C_DIR_FND As String = "_▼Parameter\Find"
    Public Shared C_DIR_RPT As String = "_▼Parameter\Report"
    Public Shared C_DIR_INP As String = "_▼Parameter\Input"
    Public Shared C_DIR_CSV As String = "_▼Work\Csv"
    Public Shared C_DIR_XLS As String = "_▼Work\Excel"
    Public Shared C_DIR_FNB As String = "_▼Work\FNB"
    Public Shared C_DIR_IMG As String = "_▼Work\Img"

    '拡張子
    Public Shared C_FIL_PRM_EXN As String = ".ini" 'ﾊﾟﾗﾒｰﾀﾌｧｲﾙ
    Public Shared C_FIL_CSV_EXN As String = ".csv" 'CSVﾀﾞﾝﾛｰﾄﾞﾌｧｲﾙ
    Public Shared C_FIL_PDF_EXN As String = ".pdf" 'PDFﾀﾞﾝﾛｰﾄﾞﾌｧｲﾙ
    Public Shared C_FIL_FNB_EXN As String = ".txt" 'FBﾌｧｲﾙ
    Public Shared C_FIL_XLS_EXN As String = ".xls" 'EXCELﾀﾞﾝﾛｰﾄﾞﾌｧｲﾙ

    'ﾒｯｾｰｼﾞ
    Public Shared C_MSG_SRC_WIT As String = "暫くお待ち下さい" '処理中
    Public Shared C_MSG_SRC_RST As String = "結果件数：" '検索結果
    Public Shared C_MSG_SRC_NOT As String = "該当情報がありませんでした" '該当ﾃﾞｰﾀなし
    Public Shared C_MSG_SRC_NUT As String = "以下に検索結果を表示します" '検索待受
    Public Shared C_MSG_MST_INP As String = "入力してください" '必修項目入力要請
    Public Shared C_MSG_DEL_APT As String = "本当に削除してよろしいですか" '削除処理実行確認
    Public Shared C_MSG_CCL_APT As String = "本当にｷｬﾝｾﾙしてよろしいですか" 'ｷｬﾝｾﾙ処理実行確認
    Public Shared C_MSG_BAC_APT As String = "本当に更新してよろしいですか" '更新処理実行確認
    Public Shared C_MSG_CMD_CPT As String = "正常に終了しました" '処理正常終了
    Public Shared C_MSG_ERR_TTL As String = "以下、入力値を見直してください" 'ｴﾗｰﾘｽﾄﾀｲﾄﾙ
    Public Shared C_MSG_KEY_DEF As String = "呼出キーと更新キーが異なります" 'ｷｰ値ｱﾝﾏｯﾁ
    Public Shared C_MSG_NOT_LST As String = "この項目は参照出来ません" '非項目参照警告
    Public Shared C_MSG_NOT_OUT_DAT As String = "出力対象データがありませんでした" '出力対象データ無し
    Public Shared C_MSG_END_OUT As String = "正常に出力されました" '出力終了メッセージ
    Public Shared C_MSG_KOU_DBL As String = "項目が重複指定されています" '重複指定エラー
    Public Shared C_MSG_SCR_CAL As String = "画面呼出中" '画面呼出中
    Public Shared C_MSG_OUT_DAT As String = "出力データ抽出中" '
    Public Shared C_MSG_FND_DAT As String = "検索データ抽出中" '
    Public Shared C_MSG_OUT_CSV As String = "CSVファイル作成中" '
    Public Shared C_MSG_OUT_PDF As String = "PDFファイル作成中" '
    Public Shared C_MSG_OUT_PDF_EXT As String = "分割PDFファイル作成中" '
    Public Shared C_MSG_OUT_XLS As String = "EXCELファイル作成中" '
    Public Shared C_MSG_OUT_RPT As String = "印刷準備中" '
    Public Shared C_MSG_OUT_PRV As String = "プレビュー準備中" '
    Public Shared C_MSG_OUT_EXC As String = "印刷中" '

    '更新ｽﾃｰﾀｽﾗｲﾝ
    Public Shared C_BAC_LIN_SRT As String = "【開  始】□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□" '
    Public Shared C_BAC_LIN_END As String = "【終  了】□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□□" '
    Public Shared C_BAC_LIN_ERR As String = "《 E r r o r ! ! 》" '
    Public Shared C_BAC_LIN_IFO As String = "----------------------------------------------------------------------------------------------------------------------------------------" '

    '帳票
    Public Shared C_RPT_MGN_TOP As Single = 0.59 '1.5cm
    Public Shared C_RPT_MGN_BTM As Single = 0.0
    Public Shared C_RPT_MGN_LFT As Single = 0.59 '1.5cm
    Public Shared C_RPT_MGN_RIT As Single = 0.0
    '
    'ｷｬﾗｸﾀｰ
    Public Shared C_CHR_STR_MAX As String = "Z"
    Public Shared C_CHR_STR_MIN As String = ""

End Class
