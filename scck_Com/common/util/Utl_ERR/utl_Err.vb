Imports System.Windows.Forms
Imports utl_Com.utl_Com
'機能概要*****************************************************************************************************
'*
'*  処理概要：画面入力ｴﾗｰ処理
'*
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*     
'*            <残>
'*                FNC_ERR_ADD_MRS→ElTabelle変更
'*                FNC_FID_INTS→ElTabelle変更
'*     
'*     
'*  更新日　：
'*  更新者　：
'*  更新内容：
'*
#Region " 旧履歴 "

'*  作成日　：2005/01/05
'*  作成者　：渡辺
'*
'*  更新日　：2006/03/01		
'*  更新者　：赤澤		

#End Region
'*
'*************************************************************************************************************

Public Class utl_ERR
    '*********************************************************************************************************
    '*   ﾒﾝﾊﾞ変数
    '*********************************************************************************************************
    Private D_ERR_OBJ() As Object
    Private D_ERR_MSG() As String

    '*********************************************************************************************************
    '*
    '*  処理概要：		ｴﾗｰ項目背景色の変更
    '*
    '*  引数　　：		1.項目ｵﾌﾞｼﾞｪｸﾄ
    '*      　　 		2.ｴﾗｰﾒｯｾｰｼﾞ
    '*
    '*                  ｵﾌﾟｼｮﾝ1.ｴﾗｰ処理ﾓｰﾄﾞ(True.項目ｴﾗｰ、False.ﾒｯｾｰｼﾞのみ)
    '*
    '*  戻り値　：		なし　　　　
    '*
    '*********************************************************************************************************
    Public Sub FNC_ERR_ADD(ByRef P1 As Object, ByVal P2 As String, Optional ByVal OP1 As Boolean = True)
        '
        Dim D_CTL As Control
        '
        Try
            If IsNothing(D_ERR_OBJ) Then
                ReDim D_ERR_OBJ(0)
                ReDim D_ERR_MSG(0)
            Else
                ReDim Preserve D_ERR_OBJ(D_ERR_OBJ.GetUpperBound(0) + 1)
                ReDim Preserve D_ERR_MSG(D_ERR_MSG.GetUpperBound(0) + 1)
            End If
            '
            If OP1 AndAlso Not IsNothing(P1) Then
                D_CTL = CType(P1, Control)
                D_ERR_OBJ(D_ERR_OBJ.GetUpperBound(0)) = D_CTL
                D_CTL.BackColor = cns_Com.cns_Com.C_ERR_CLR
            End If
            '
            D_ERR_MSG(D_ERR_MSG.GetUpperBound(0)) = P2
            '
            If D_ERR_OBJ.GetUpperBound(0) = 0 Then
                If OP1 AndAlso Not IsNothing(P1) Then
                    If D_CTL.Visible AndAlso D_CTL.Enabled Then
                        D_CTL.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：		ｴﾗｰ項目背景色の変更
    '*
    '*  引数　　：		1.項目ｵﾌﾞｼﾞｪｸﾄ
    '*      　　 		2.ｴﾗｰﾒｯｾｰｼﾞ
    '*
    '*                  ｵﾌﾟｼｮﾝ1.ｴﾗｰ処理ﾓｰﾄﾞ(True.項目ｴﾗｰ、False.ﾒｯｾｰｼﾞのみ)
    '*
    '*  戻り値　：		なし　　　　
    '*
    '*********************************************************************************************************
    Public Sub FNC_ERR_ADD(ByRef P1 As Object, ByVal P2 As String, ByRef P3 As GrapeCity.Win.Components.GcStylePlus)
        '
        Dim D_CTL As Control
        '
        Try
            If IsNothing(D_ERR_OBJ) Then
                ReDim D_ERR_OBJ(0)
                ReDim D_ERR_MSG(0)
            Else
                ReDim Preserve D_ERR_OBJ(D_ERR_OBJ.GetUpperBound(0) + 1)
                ReDim Preserve D_ERR_MSG(D_ERR_MSG.GetUpperBound(0) + 1)
            End If
            '
            If Not IsNothing(P1) Then
                D_CTL = CType(P1, Control)
                D_ERR_OBJ(D_ERR_OBJ.GetUpperBound(0)) = D_CTL
                '
                If D_ERR_OBJ.GetUpperBound(0) = 0 Then P3.RemoveActiveStyle(D_CTL)
                '
                D_CTL.BackColor = cns_Com.cns_Com.C_ERR_CLR
            End If
            '
            D_ERR_MSG(D_ERR_MSG.GetUpperBound(0)) = P2
            '
            If D_ERR_OBJ.GetUpperBound(0) = 0 Then
                If Not IsNothing(P1) Then
                    If D_CTL.Visible AndAlso D_CTL.Enabled Then
                        D_CTL.Focus()
                    End If
                End If
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：		ｴﾗｰ項目背景色の変更
    '*
    '*  引数　　：		1.MultiRowSheet
    '*                  2.行ｲﾝﾃﾞｯｸｽ
    '*                  3.列ｲﾝﾃﾞｯｸｽ
    '*                  4.行内複数行ｲﾝﾃﾞｯｸｽ
    '*      　　 		5.ｴﾗｰﾒｯｾｰｼﾞ
    '*
    '*                  ｵﾌﾟｼｮﾝ1.ｴﾗｰ処理ﾓｰﾄﾞ(True.項目ｴﾗｰ、False.ﾒｯｾｰｼﾞのみ)
    '*
    '*  戻り値　：		なし　　　　
    '*
    '*********************************************************************************************************
    '    Public Sub FNC_ERR_ADD_MRS(ByRef P1 As GrapeCity.Win.ElTabelle.MultiRowSheet, ByVal P2 As Integer, ByVal P3 As Integer, ByVal P4 As Integer, ByVal P5 As String, Optional ByVal OP1 As Boolean = True)
    '        '
    '        Dim D_CTL As GrapeCity.Win.ElTabelle.MCell
    '        '
    '        Try
    '            If IsNothing(D_ERR_OBJ) Then
    '                ReDim D_ERR_OBJ(0)
    '                ReDim D_ERR_MSG(0)
    '            Else
    '                ReDim Preserve D_ERR_OBJ(D_ERR_OBJ.GetUpperBound(0) + 1)
    '                ReDim Preserve D_ERR_MSG(D_ERR_MSG.GetUpperBound(0) + 1)
    '            End If
    '            '
    '            'ｾﾙ抽出
    '            If OP1 AndAlso Not IsNothing(P1) Then
    '                D_CTL = CType(P1.GetMRow(P2).Item(P3, P4), GrapeCity.Win.ElTabelle.MCell)
    '                D_ERR_OBJ(D_ERR_OBJ.GetUpperBound(0)) = CObj(D_CTL)
    '                D_CTL.BackColor = cns_Com.cns_Com.C_ERR_CLR
    '            End If
    '            D_ERR_MSG(D_ERR_MSG.GetUpperBound(0)) = "【" & P2 + 1 & "行目】" & P5
    '            '
    '            If D_ERR_OBJ.GetUpperBound(0) = 0 Then
    '                P1.Focus()
    '                If OP1 AndAlso Not IsNothing(P1) Then
    '                    P1.ActivePosition = New GrapeCity.Win.ElTabelle.MPosition(P2, P3, P4)
    '                End If
    '            End If
    '        Catch ex As Exception
    '            FNC_ERR_RTN(ex)
    '        End Try
    'EXIT_FUNCTION:
    '        Exit Sub
    '    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：		ｴﾗｰ項目背景色の初期化
    '*
    '*  引数　　：		なし
    '*
    '*  戻り値　：		なし　　　　
    '*
    '*********************************************************************************************************
    Public Sub FNC_FID_INT()
        '
        Dim I As Integer
        '
        Try
            If Not IsNothing(D_ERR_OBJ) Then
                For I = 0 To D_ERR_OBJ.GetUpperBound(0) Step 1
                    If Not IsNothing(D_ERR_OBJ(I)) Then
                        If InStr(1, D_ERR_OBJ(I).GetType.Namespace, "ElTabelle", CompareMethod.Text) > 0 Then
                            'CType(D_ERR_OBJ(I), GrapeCity.Win.ElTabelle.MCell).BackColor = Cns_COM.C_TXT_LST_CLR
                        Else
                            CType(D_ERR_OBJ(I), Control).BackColor = cns_Com.cns_Com.C_TXT_LST_CLR
                        End If
                    End If
                Next
            End If
            '
            Erase D_ERR_OBJ, D_ERR_MSG

        Catch ex As System.ArgumentOutOfRangeException
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：		ｴﾗｰ画面の表示
    '*
    '*  引数　　：		1.ｴﾗｰﾀｲﾄﾙ
    '*
    '*  戻り値　：		なし
    '*
    '*********************************************************************************************************
    Public Sub FNC_SHW_ERR(ByRef P1 As Form, ByVal P2 As String)
        '
        Try
            If Not IsNothing(D_ERR_OBJ) Then
                Dim D_FRM As New frm_Error(P2, D_ERR_OBJ, D_ERR_MSG, P1)
                '
                D_FRM.ShowDialog(P1)
                '
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
    '*  処理概要：		ｴﾗｰｵﾌﾞｼﾞｪｸﾄの初期化
    '*
    '*  引数　　：		なし
    '*
    '*  戻り値　：		なし
    '*
    '*********************************************************************************************************
    Public Sub FNC_ERR_INT()
        '
        Try
            Erase D_ERR_OBJ, D_ERR_MSG
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_FUNCTION:
        Exit Sub
    End Sub

End Class
