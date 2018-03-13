Imports System.Data.SqlClient
Imports utl_Com.utl_Com
'機能概要*****************************************************************************************************
'*
'*  処理概要：ﾃﾞｰﾀﾍﾞｰｽ関数
'*
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*
'*           <残>
'*                FNC_WSV_GET_DAT -> WEBｻｰﾋﾞｽの参照
'*                FNC_WSV_UPD_EXC -> WEBｻｰﾋﾞｽの参照
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
'*  更新日　：2007/04/10
'*  更新者　：ANS落合 新規関数 FNC_UPD_IMG を追記
'*
'*  更新日　：2010/10/21
'*  更新者　：ANS野木
'*　更新内容：新規関数 FNC_UPD_FIL を追記

#End Region
'*
'*************************************************************************************************************
Public Class utl_Rdb
    '*********************************************************************************************************
    '*  ﾒﾝﾊﾞ変数
    '*********************************************************************************************************
    Public Shared D_CON As SqlConnection
    Public Shared D_CFG As String = System.Configuration.ConfigurationManager.AppSettings("RDB_CON")

    '*********************************************************************************************************
    '*
    '*  処理概要：ｺﾝｽﾄﾗｸﾀ
    '*
    '*  引数　　：なし
    '*
    '*********************************************************************************************************
    Public Sub New()

    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾃﾞｰﾀﾍﾞｰｽ接続
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_RDB_CON() As Boolean
        '
        Dim D_RTN As Boolean = False
        '
        Try
            If IsNothing(D_CON) Then
                D_CON = New SqlConnection(D_CFG)
            End If
            If D_CON.State = ConnectionState.Closed OrElse
               D_CON.State = ConnectionState.Broken Then
                D_CON.Open()
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
FNC_EXIT:
        FNC_RDB_CON = D_RTN
        Exit Function
    End Function

    '*****************************************************************************************************
    '*	
    '*  処理概要：  ｺﾈｸｼｮﾝｵﾌﾞｼﾞｪｸﾄ閉鎖
    '*	
    '*	引数　　：  1.ﾃﾞｰﾀﾍﾞｰｽ接続文字列
    '*	
    '*	戻り値　：  閉鎖結果(True、False)
    '*
    '*****************************************************************************************************
    Public Shared Function FNC_CLS_CON() As Boolean
        '
        Dim D_RTN As Boolean = False
        '
        Try
            If Not IsNothing(D_CON) AndAlso
               Not (D_CON.State = ConnectionState.Closed OrElse D_CON.State = ConnectionState.Broken) Then
                D_CON.Close()
            End If
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
FNC_EXIT:
        Return D_RTN
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾃﾞｰﾀｾｯﾄ取得
    '*
    '*  引数　　：1.SQLSentence
    '*
    '*  戻り値　：ﾃﾞｰﾀｾｯﾄ
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_GET_DAT(ByVal P1 As String) As DataSet
        '
        Dim D_RTN As New DataSet
        Dim D_CMD As SqlCommand
        Dim D_ADP As SqlDataAdapter
        Dim D_STS As Integer = 0
        '
        Try
            D_CMD = New SqlCommand(P1, D_CON)
            D_CMD.CommandTimeout = 10000000
            D_ADP = New SqlDataAdapter(D_CMD)
            D_STS = D_ADP.Fill(D_RTN)
        Catch ex As Exception
            FNC_ERR_RTN(ex, P1)
        Finally
            If Not IsNothing(D_ADP) Then
                D_ADP.Dispose() : D_ADP = Nothing
            End If
            If Not IsNothing(D_CMD) Then
                D_CMD.Dispose() : D_CMD = Nothing
            End If
        End Try
FNC_EXIT:
        FNC_GET_DAT = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾃﾞｰﾀﾃｰﾌﾞﾙ取得
    '*
    '*  引数　　：1.ｸｴﾘ
    '*            
    '*  戻り値　：ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_GET_TBL(ByVal P1 As String) As DataTable
        '
        Dim D_RTN As New DataTable
        '
        Try
            D_RTN = FNC_GET_DAT(P1).Tables(0)
        Catch ex As Exception
            FNC_ERR_RTN(ex, P1)
        End Try
EXIT_FUNCTION:
        FNC_GET_TBL = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾃﾞｰﾀﾘｰﾀﾞｰ取得
    '*
    '*  引数　　：1.SQLSentence
    '*
    '*  戻り値　：ﾃﾞｰﾀﾘｰﾀﾞｰ
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_GET_DRD(ByVal P1 As String) As SqlDataReader
        '
        Dim D_RTN As SqlDataReader
        Dim D_STS As Integer = 0
        Dim D_CMD As SqlCommand
        '
        Try
            If Not IsNothing(P1) Then
                If Not D_RTN.IsClosed Then D_RTN.Close()
            End If
            '
            D_CMD = New SqlCommand(P1, D_CON)
            D_CMD.CommandTimeout = 10000000
            '
            D_RTN = D_CMD.ExecuteReader()
        Catch ex As Exception
            FNC_ERR_RTN(ex, P1)
        Finally
            If Not IsNothing(D_CMD) Then
                D_CMD.Dispose() : D_CMD = Nothing
            End If
        End Try
FNC_EXIT:
        FNC_GET_DRD = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：更新
    '*
    '*  引数　　：1.ｺﾏﾝﾄﾞ
    '*            
    '*  戻り値　：True.成功 , False.失敗
    '*
    '*********************************************************************************************************    
    Public Shared Function FNC_UPD_EXC(ByVal P1 As String) As Boolean
        '
        Dim D_RTN As Boolean = False
        Dim D_STS As Integer = 0
        Dim D_CMD As SqlCommand
        Dim D_TRN As SqlTransaction
        '
        Try
            D_TRN = D_CON.BeginTransaction(IsolationLevel.Serializable)
            D_CMD = New Data.SqlClient.SqlCommand(P1, D_TRN.Connection, D_TRN)
            D_CMD.CommandTimeout = 10000000
            D_STS = D_CMD.ExecuteNonQuery()
            '
            D_RTN = True
        Catch ex As Exception
            FNC_ERR_RTN(ex, P1)
        Finally
            If D_RTN Then D_TRN.Commit() Else D_TRN.Rollback()
            '
            If Not IsNothing(D_CMD) Then
                D_CMD.Dispose() : D_CMD = Nothing
            End If
            '
            If Not (D_TRN Is Nothing) Then D_TRN.Dispose()
            '
            D_TRN = Nothing
        End Try
FNC_EXIT:
        FNC_UPD_EXC = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾃﾞｰﾀﾃｰﾌﾞﾙ破棄
    '*
    '*  引数　　：1.ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*            
    '*  戻り値　：ﾃﾞｰﾀｾｯﾄ
    '*
    '*********************************************************************************************************
    Public Shared Sub FNC_DPS_TBL(ByRef P1 As DataTable)
        Try
            '
            If Not IsNothing(P1) Then
                P1.Clear()
                P1 = Nothing
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
    '*  処理概要：ﾃﾞｰﾀﾃｰﾌﾞﾙ取得(Webｻｰﾋﾞｽ経由)
    '*
    '*  引数　　：1.ｸｴﾘ
    '*            
    '*  戻り値　：ﾃﾞｰﾀﾃｰﾌﾞﾙ
    '*
    '*********************************************************************************************************
    Public Function FNC_WSV_GET_TBL(ByVal P1 As String) As DataTable
        '
        Dim D_RTN As New DataTable
        '
        Try
            D_RTN = FNC_GET_DAT(P1).Tables(0)
        Catch ex As Exception
            FNC_ERR_RTN(ex, P1)
        End Try
EXIT_FUNCTION:
        FNC_WSV_GET_TBL = D_RTN
        '
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾃﾞｰﾀｾｯﾄ取得(Webｻｰﾋﾞｽ経由)
    '*
    '*  引数　　：1.ｸｴﾘ
    '*            
    '*  戻り値　：ﾃﾞｰﾀｾｯﾄ
    '*
    '*********************************************************************************************************
    '    Public Function FNC_WSV_GET_DAT(ByVal P1 As String) As DataSet
    '        '
    '        Dim D_RTN As New DataSet
    '        Dim D_WEB As New Web_RDB.Web_RDB
    '        '
    '        Try
    '            Utl_COM.FNC_WEB_URL(D_WEB)
    '            '
    '            D_RTN = D_WEB.FNC_DAT_SET(P1)
    '        Catch ex As Exception
    '            FNC_ERR_RTN(ex, P1)
    '        End Try
    'EXIT_FUNCTION:
    '        FNC_WSV_GET_DAT = D_RTN
    '        '
    '        Exit Function
    '    End Function
    '
    '*********************************************************************************************************
    '*
    '*  処理概要：更新(Webｻｰﾋﾞｽ経由)
    '*
    '*  引数　　：1.ｺﾏﾝﾄﾞ
    '*            
    '*  戻り値　：True.成功 , False.失敗
    '*
    '*********************************************************************************************************
    '    Public Function FNC_WSV_UPD_EXC(ByVal P1 As String) As Boolean
    '        '
    '        Dim D_RTN As Boolean = False
    '        Dim D_WEB As New Web_RDB.Web_RDB
    '        '
    '        Try
    '            Utl_COM.FNC_WEB_URL(D_WEB)
    '            '
    '            D_RTN = D_WEB.FNC_DAT_UPD(P1)
    '        Catch ex As Exception
    '            FNC_ERR_RTN(ex, P1)
    '        End Try
    'EXIT_FUNCTION:
    '        FNC_WSV_UPD_EXC = D_RTN
    '    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：画像ﾃﾞｰﾀ更新
    '*
    '*  引数　　：1.対象ﾌｧｲﾙ (1.M005社員ﾏｽﾀ、2.M006得意先ﾏｽﾀ、3.M009得意先支店ﾏｽﾀ)
    '*            2.更新KEY
    '*            3.画像ﾃﾞｰﾀ (Byte配列)
    '*
    '*  戻り値　：ﾃﾞｰﾀｾｯﾄ
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_UPD_IMG(ByVal P1 As Integer, ByVal P2 As Object(), ByVal P3 As Byte()) As DataTable
        '
        Dim D_RTN As New DataTable
        Dim D_SQL As String = ""
        Dim D_PRM As String
        Dim D_CMD As SqlCommand
        Dim D_ADP As SqlDataAdapter
        Dim D_STS As Integer = 0
        '
        Try
            Select Case P1
                Case 1 : D_SQL = "SPC_M005_UPD_IMG"
                Case 2 : D_SQL = "SPC_M006_UPD_IMG"
                Case 3 : D_SQL = "SPC_M009_UPD_IMG"
            End Select
            '
            D_CMD = New SqlCommand(D_SQL, D_CON)
            D_CMD.CommandTimeout = 10000000
            D_CMD.CommandType = System.Data.CommandType.StoredProcedure
            '
            Select Case P1
                Case 1, 2
                    Dim PRM1 As SqlParameter = D_CMD.Parameters.Add("@P1", System.Data.SqlDbType.Int)
                    Dim PRM2 As SqlParameter = D_CMD.Parameters.Add("@P2", System.Data.SqlDbType.Image)
                    '
                    PRM1.Value = P2(0)
                    PRM2.Value = P3
                    '
                    D_PRM = CStr(P2(0))
                Case 3
                    Dim PRM1 As SqlParameter = D_CMD.Parameters.Add("@P1", System.Data.SqlDbType.Int)
                    Dim PRM2 As SqlParameter = D_CMD.Parameters.Add("@P2", System.Data.SqlDbType.Int)
                    Dim PRM3 As SqlParameter = D_CMD.Parameters.Add("@P3", System.Data.SqlDbType.Image)
                    '
                    PRM1.Value = P2(0)
                    PRM2.Value = P2(1)
                    PRM3.Value = P3
                    '
                    D_PRM = CStr(P2(0)) & "," & CStr(P2(1))
            End Select
            D_ADP = New SqlDataAdapter(D_CMD)
            D_STS = D_ADP.Fill(D_RTN)
        Catch ex As Exception
            FNC_ERR_RTN(ex, D_SQL & " " & D_PRM)
        Finally
            If Not IsNothing(D_ADP) Then
                D_ADP.Dispose() : D_ADP = Nothing
            End If
            If Not IsNothing(D_CMD) Then
                D_CMD.Dispose() : D_CMD = Nothing
            End If
        End Try
FNC_EXIT:
        FNC_UPD_IMG = D_RTN
        Exit Function
    End Function

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾌｧｲﾙﾃﾞｰﾀ更新
    '*
    '*  引数　　：1.対象ﾌｧｲﾙ (1.市区町村マスタ)
    '*            2.更新KEY
    '*            3.ﾌｧｲﾙﾃﾞｰﾀ (Byte配列)
    '*
    '*  戻り値　：ﾃﾞｰﾀｾｯﾄ
    '*
    '*********************************************************************************************************
    Public Shared Function FNC_UPD_FIL(ByVal P1 As Integer, ByVal P2 As Object(), ByVal P3 As Byte()) As DataTable
        '
        Dim D_RTN As New DataTable
        Dim D_SQL As String = ""
        Dim D_PRM As String
        Dim D_CMD As SqlCommand
        Dim D_ADP As SqlDataAdapter
        Dim D_STS As Integer = 0
        '
        Try
            Select Case P1
                Case 1 : D_SQL = "SPC_M041_UPD_FIL"
            End Select
            D_CMD = New SqlCommand(D_SQL, D_CON)
            D_CMD.CommandTimeout = 10000000
            D_CMD.CommandType = System.Data.CommandType.StoredProcedure
            Select Case P1
                Case 1
                    Dim PRM1 As SqlParameter = D_CMD.Parameters.Add("@P1", System.Data.SqlDbType.Int)
                    Dim PRM2 As SqlParameter = D_CMD.Parameters.Add("@P2", System.Data.SqlDbType.VarBinary)
                    PRM1.Value = P2(0)
                    PRM2.Value = P3
                    D_PRM = CStr(P2(0))
            End Select
            D_ADP = New SqlDataAdapter(D_CMD)
            D_STS = D_ADP.Fill(D_RTN)
        Catch ex As Exception
            FNC_ERR_RTN(ex, D_SQL & " " & D_PRM)
        Finally
            If Not IsNothing(D_ADP) Then
                D_ADP.Dispose() : D_ADP = Nothing
            End If
            If Not IsNothing(D_CMD) Then
                D_CMD.Dispose() : D_CMD = Nothing
            End If
        End Try
FNC_EXIT:
        FNC_UPD_FIL = D_RTN
        Exit Function
    End Function

End Class
