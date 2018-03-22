Imports System.Windows.Forms
Imports GrapeCity.ActiveReports
Imports utl_Com.utl_Com
'*********************************************************************************************************
'*
'*  処理概要：帳票ﾌﾟﾚﾋﾞｭｰ画面
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

'*  作成日　：2005/05/07
'*  作成者　：ANS赤沢(博)
'*
'*  更新日　：		
'*  更新者　：		

#End Region
'*
'*********************************************************************************************************
Public Class frm_Viewer
    '*********************************************************************************************************
    '*  変数の宣言
    '*********************************************************************************************************
    '*********************************************************************************************************
    '*  定数の宣言
    '*********************************************************************************************************

    Private Sub Frm_Viewer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '
        Try
            FNC_FRM_CLR(Me)
            '
            Viewer.ReportViewer.Zoom = -2  ' ページ全体
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

    Private Sub Frm_Viewer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        '
        Try
            Select Case e.KeyCode
                Case Keys.P : Viewer.Document.Print(True, True)
                Case Keys.F12, Keys.Escape : Close() 'Dispose()
            End Select
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
SUB_EXIT:
        Exit Sub
    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        '
        Try
            '座標設定
            '
            'If Not Me.Location.Equals(Utl_COM.P_FRM_LCN) Then Me.Location = Utl_COM.P_FRM_LCN
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
    End Sub

    Private Sub Frm_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.LocationChanged
        '
        Try
            '座標格納
            '
            'If Not IsNothing(Me.ActiveControl) Then Utl_COM.P_FRM_LCN = Me.Location
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
    End Sub

End Class