Imports System.Windows.Forms
Imports utl_Com.utl_Com
'機能概要*****************************************************************************************************
'*
'*  機能概要：ｴﾗｰ表示画面
'*
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*
'*           <残>
'*               SUB_INT_RTN→ElTabelles処理
'*
'*
'*  更新日　：
'*  更新者　：
'*  更新内容：
'*
#Region " 旧履歴 "

'*  作成日：　　　　　2005/01/05
'*  作成者：　　　　　渡辺
'*
'*  更新日：　　　　　2005/05/05
'*  更新者：　　　　　ANS赤沢(博)

#End Region
'*
'*
'*************************************************************************************************************
Public Class frm_Error

    Public Sub New(ByVal P1 As String, ByRef P2() As Object, ByRef P3() As String, ByRef P4 As Object)
        MyBase.New()
        '
        InitializeComponent()
        '
        LBL_TTL.Text = P1 : SUB_INT_RTN(P2, P3)
        '
        StartPosition = FormStartPosition.Manual
        '
        Dim D_PNT As New System.Drawing.Point(P4.Location.X, P4.Location.Y)
        '
        D_PNT.X = (D_PNT.X + (P4.Width - Width))
        D_PNT.Y = D_PNT.Y + 48
        '
        Location = D_PNT
    End Sub

    Private Sub Frm_Error_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        '
        Try
            If e.KeyCode = Keys.Escape Or e.KeyCode = Keys.F12 Then
                Me.Dispose()
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

    Private Sub PIC_CLS_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PIC_CLS.Click
        '
        Try
            Me.Dispose()
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：　　　　初期設定処理
    '*
    '*  引数　　：　　　　1.ｵﾌﾞｼﾞｪｸﾄ配列
    '*  　　　　　　　　　2.ﾒｯｾｰｼﾞ配列
    '*
    '*  戻り値　：　　　　なし
    '*
    '*********************************************************************************************************
    Private Sub SUB_INT_RTN(ByRef P1() As Object, ByRef P2() As String)
        '
        Dim I As Integer
        Dim D_POS As Integer
        Dim D_NAM As String = ""
        Dim D_ITM As GrapeCity.Win.Editors.ListItem
        Dim D_SUB As GrapeCity.Win.Editors.SubItem
        '
        Try
            For I = 0 To P1.GetUpperBound(0) Step 1
                If Not IsNothing(P1(I)) Then
                    If InStr(1, P1(I).GetType.Namespace, "ElTabelle", CompareMethod.Text) > 0 Then
                        'D_NAM = CType(P1(I), GrapeCity.Win.ElTabelle.MCell).Key
                    Else
                        D_NAM = CType(P1(I), Control).Name
                    End If
                    D_POS = InStr(1, D_NAM, "_", CompareMethod.Text)
                    If D_POS > 0 Then
                        D_NAM = Mid(D_NAM, D_POS + 1, Len(D_NAM) - D_POS)
                    End If
                Else
                    D_NAM = "※論理ｴﾗｰ"
                End If
                '
                D_ITM = New GrapeCity.Win.Editors.ListItem : D_ITM.Text = D_NAM
                '
                '▼新バージョンでは不要
                '
                'D_SUB = New GrapeCity.Win.Editors.SubItem : D_SUB.Value = D_NAM : D_ITM.SubItems.Add(D_SUB)
                '
                D_SUB = New GrapeCity.Win.Editors.SubItem : D_SUB.Value = P2(I) : D_ITM.SubItems.Add(P2(I))
                '
                D_SUB.Value = D_NAM : D_ITM.SubItems.Add(D_SUB)
                '
                LST_MSG.Items.Add(D_ITM)
            Next
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

End Class