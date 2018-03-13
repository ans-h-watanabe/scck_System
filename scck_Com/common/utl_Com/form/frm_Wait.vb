'機能概要*****************************************************************************************************
'*
'*  処理概要：待機ﾒｯｾｰｼﾞ表示
'*
'*  作成日　：2005/05/01
'*  作成者　：Ans赤沢(博)
'*
'*  更新日　：
'*  更新者　：
'*
'*************************************************************************************************************
Public Class frm_Wait

#Region "■ProcessingCode■"

    '*********************************************************************************************************
    '*
    '*  処理概要：ｺﾝｽﾄﾗｸﾀ
    '*
    '*  引数　　：
    '*
    '*********************************************************************************************************
    Public Sub New(ByVal P1 As String)
        MyBase.New()
        '
        ' この呼び出しは Windows フォーム デザイナで必要です。
        '
        InitializeComponent()
        '
        ' InitializeComponent() 呼び出しの後に初期化を追加します。
        '
        lbl_Msg.Text = P1
    End Sub

    '*********************************************************************************************************
    '*
    '*  処理概要：ﾒｯｾｰｼﾞ設定
    '*
    '*  引数　　：なし
    '*
    '*  戻り値　：なし
    '*
    '*********************************************************************************************************
    Public Sub FNC_SET_MSG(ByVal P1 As String)
        Try
            lbl_Msg.Text = P1
            '
            System.Windows.Forms.Application.DoEvents()
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

#End Region

#Region "■EventCode■"

    Public Overloads Sub show()
        Try
            MyBase.Show()
            '
            System.Windows.Forms.Application.DoEvents()
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

    Public Overloads Sub Dispose()
        '
        Try
            Me.Hide()
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
EXIT_FUNTION:
        Exit Sub
    End Sub

    Private Sub Frm_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        '
        Try
            '表示座標設定
            Dim D_PNT As System.Drawing.Point
            '
            D_PNT = utl_Com.P_FRM_LCN
            D_PNT.X = (D_PNT.X + (512 - (Width / 2)))
            D_PNT.Y = (D_PNT.Y + (368 - (Height / 2)))
            Location = D_PNT
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
    End Sub

    Private Sub BTN_HID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_HID.Click
        '
        Try
            Me.Hide()
            '
            System.Windows.Forms.Application.DoEvents()
        Catch ex As Exception
            utl_Com.FNC_ERR_RTN(ex)
        End Try
    End Sub
#End Region

End Class