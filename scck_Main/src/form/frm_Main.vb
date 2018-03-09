Imports System.Windows.Forms

Public Class frm_Main
    Private Sub ToolStripButton7_Click(sender As Object, e As EventArgs) Handles ToolStripButton7.Click
        Try
            Dim intCnt As Integer = 0


            Dim NewMDIChild As New frm_M001
            NewMDIChild.MdiParent = Me

            NewMDIChild.Show()
            NewMDIChild = Nothing
            '
        Catch ex As Exception
            Throw ex
        Finally
            Debug.WriteLine("TSM_M01_Click＿完了")
        End Try
    End Sub

    Private Sub frm_Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.StartPosition = FormStartPosition.Manual
        Me.Size = New Size(1700, 980)
        Me.WindowState = FormWindowState.Normal
    End Sub

End Class
