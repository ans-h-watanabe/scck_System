'機能概要*****************************************************************************************************
'*
'*  処理概要：業務分類ﾏｽﾀｰﾒﾝﾃﾅﾝｽ
'*
'*  作成日　：2018/02/01
'*  作成者　：渡辺      1.基幹システム更改
'*
'*  更新日　：
'*  更新者　：
'*  更新内容：
'*
#Region " 旧履歴 "

'*  作成日　：2005/09/13
'*  作成者　：ANS佐藤太希
'*
'*  更新日　：2006/03/03
'*  更新者　：ANS和泉慶子
'*  更新内容：2006/03/03 新規登録時、keyをｸﾘｱ
'*            2006/04/06 機能別ユーザー権限制御処置
'*            2006/04/07 削除処理
'*            2006/04/27 Form位置調整処理　追加
'*            2006/07/12 F4参照部分  修正
'*
'*  更新者　：軽部
'*  更新日　：2007/08/30
'*  更新内容：Windows Vista上でF10が効かない現象の対応
'*
'*  更新者　：山田
'*  更新日　：2008/08/08
'*  更新内容：事業部コード⇒業務分類区分に変更

#End Region
'*
'*************************************************************************************************************
Public Class frm_M002_fnd

#Region "■ItemCode■"
    '*********************************************************************************************************
    '*  ﾒﾝﾊﾞ変数
    '*********************************************************************************************************
    Private D_SQL As String
    'Private D_DAT As New DataSet
    Private D_TBL As New DataTable
    Private D_MOD As String
    Private D_ERR As New utl_Err.utl_ERR


    Private D_KEY(1) As String

#End Region

    Private Sub frm_M001_Load(sender As Object, e As EventArgs) Handles Me.Load
        'これはデザインでもコードでもどっちでもいいみたい。 
        'MaximizeBoxと,MinimizeBoxはTrueのままでも問題ないみたい。 
        'Me.ControlBox = False

        '明示的に「FormBorderStyle.FixedToolWindow」をコード指定 
        'しないと駄目っぽい。ちなみにデザイン上は何でも良いみたい 
        Me.FormBorderStyle = FormBorderStyle.FixedToolWindow

        'これも明示的にコードで指定しないと駄目。 
        'しかもデザイン上は「FormWindowState.Normal」じゃないと駄目。 
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub FNC_KEY_FunctionKeyPress(sender As Object, e As GrapeCity.Win.Bars.FunctionKeyPressEventArgs) Handles FNC_KEY.FunctionKeyPress
        If e.Key = GrapeCity.Win.Bars.ButtonKeys.F3 Then
            CON_Heading.IsExpanded = Not CON_Heading.IsExpanded
        End If
    End Sub
End Class