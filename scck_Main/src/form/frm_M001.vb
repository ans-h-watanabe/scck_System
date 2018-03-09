Public Class frm_M001
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

    Private Sub btn_size_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Height->" & Me.Height & ":Width->" & Me.Width)
    End Sub

    Private Sub pnl_Main_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub LBL_XID_Click(sender As Object, e As EventArgs)

    End Sub
End Class