<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Viewer
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Viewer))
        Me.Viewer = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
        Me.SuspendLayout()
        '
        'Viewer
        '
        Me.Viewer.CurrentPage = 0
        Me.Viewer.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Viewer.Location = New System.Drawing.Point(0, 0)
        Me.Viewer.Name = "Viewer"
        Me.Viewer.PreviewPages = 0
        '
        '
        '
        '
        '
        '
        Me.Viewer.Sidebar.ParametersPanel.ContextMenu = Nothing
        Me.Viewer.Sidebar.ParametersPanel.Text = "パラメータ"
        Me.Viewer.Sidebar.ParametersPanel.Width = 200
        '
        '
        '
        Me.Viewer.Sidebar.SearchPanel.ContextMenu = Nothing
        Me.Viewer.Sidebar.SearchPanel.Text = "検索"
        Me.Viewer.Sidebar.SearchPanel.Width = 200
        '
        '
        '
        Me.Viewer.Sidebar.ThumbnailsPanel.ContextMenu = Nothing
        Me.Viewer.Sidebar.ThumbnailsPanel.Text = "サムネイル"
        Me.Viewer.Sidebar.ThumbnailsPanel.Width = 200
        Me.Viewer.Sidebar.ThumbnailsPanel.Zoom = 0.1R
        '
        '
        '
        Me.Viewer.Sidebar.TocPanel.ContextMenu = Nothing
        Me.Viewer.Sidebar.TocPanel.Expanded = True
        Me.Viewer.Sidebar.TocPanel.Text = "見出しマップラベル"
        Me.Viewer.Sidebar.TocPanel.Width = 200
        Me.Viewer.Sidebar.Width = 200
        Me.Viewer.Size = New System.Drawing.Size(1584, 861)
        Me.Viewer.TabIndex = 0
        '
        'frm_Viewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1584, 861)
        Me.Controls.Add(Me.Viewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frm_Viewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frm_Viewer"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Viewer As GrapeCity.ActiveReports.Viewer.Win.Viewer
End Class
