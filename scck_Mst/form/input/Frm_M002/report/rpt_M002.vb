Imports GrapeCity.ActiveReports
Imports GrapeCity.ActiveReports.Document
Imports utl_Com.utl_Com
'機能概要*****************************************************************************************************
'*
'*  処理概要：業務分類ﾏｽﾀﾘｽﾄ
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
'*  作成者　：Ans佐藤太希
'*
'*  更新日　：2006/04/19
'*  更新者　：ANS和泉慶子
'*  更新内容：ﾏｽﾀﾘｽﾄ全体調整
'*
'*  更新日　：2008/08/08
'*  更新者　：山田
'*  更新内容：事業部コード⇒業務分類区分に変更

#End Region
'*
'*************************************************************************************************************
Public Class rpt_M002

    Private Sub Detail_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail.Format
        '
        Try
            If FID_業務分類区分.Text.Equals("00") Then
                FID_業務分類区分.Text = ""
            End If
            If FID_登録ユーザーID.Text.Equals("0000000") Then
                FID_登録ユーザーID.Text = ""
            End If
            If FID_更新ユーザーID.Text.Equals("0000000") Then
                FID_更新ユーザーID.Text = ""
            End If
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub PageHeader_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageHeader.Format
        '
        Try
            LBL_印刷日時.Text = Format(Now(), "yy/MM/dd HH:mm:ss")
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

    Private Sub PageFooter_Format(ByVal sender As Object, ByVal e As System.EventArgs) Handles PageFooter.Format
        '
        Try
            '
        Catch ex As Exception
            FNC_ERR_RTN(ex)
        End Try
EXIT_SUB:
        Exit Sub
    End Sub

End Class
