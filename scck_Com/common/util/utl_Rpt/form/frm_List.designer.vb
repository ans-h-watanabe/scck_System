<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_List
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_List))
        Me.LBL_LST_MSG = New GrapeCity.Win.Buttons.GcLabel()
        Me.PNL_Status = New System.Windows.Forms.Panel()
        Me.LBL_END = New GrapeCity.Win.Buttons.GcLabel()
        Me.PNL_Msg = New System.Windows.Forms.Panel()
        Me.LST_VIW = New System.Windows.Forms.ListView()
        Me.PNL_Status.SuspendLayout()
        Me.PNL_Msg.SuspendLayout()
        Me.SuspendLayout()
        '
        'LBL_LST_MSG
        '
        Me.LBL_LST_MSG.BackColor = System.Drawing.SystemColors.Window
        Me.LBL_LST_MSG.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_LST_MSG.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LBL_LST_MSG.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LBL_LST_MSG.Location = New System.Drawing.Point(0, 0)
        Me.LBL_LST_MSG.Name = "LBL_LST_MSG"
        Me.LBL_LST_MSG.Padding = New System.Windows.Forms.Padding(5, 3, 0, 0)
        Me.LBL_LST_MSG.Size = New System.Drawing.Size(1034, 31)
        Me.LBL_LST_MSG.TabIndex = 0
        Me.LBL_LST_MSG.Text = "以下に検索結果を表示します"
        Me.LBL_LST_MSG.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_LST_MSG.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'PNL_Status
        '
        Me.PNL_Status.Controls.Add(Me.LBL_END)
        Me.PNL_Status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNL_Status.Location = New System.Drawing.Point(0, 521)
        Me.PNL_Status.Name = "PNL_Status"
        Me.PNL_Status.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.PNL_Status.Size = New System.Drawing.Size(1034, 20)
        Me.PNL_Status.TabIndex = 2
        '
        'LBL_END
        '
        Me.LBL_END.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBL_END.Font = New System.Drawing.Font("Yu Gothic UI", 8.5!)
        Me.LBL_END.ForeColor = System.Drawing.Color.DarkRed
        Me.LBL_END.Location = New System.Drawing.Point(5, 0)
        Me.LBL_END.Name = "LBL_END"
        Me.LBL_END.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.LBL_END.Size = New System.Drawing.Size(359, 20)
        Me.LBL_END.TabIndex = 4
        Me.LBL_END.Text = "[F12][Esc]=閉じる"
        Me.LBL_END.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_END.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'PNL_Msg
        '
        Me.PNL_Msg.Controls.Add(Me.LST_VIW)
        Me.PNL_Msg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL_Msg.Location = New System.Drawing.Point(0, 31)
        Me.PNL_Msg.Name = "PNL_Msg"
        Me.PNL_Msg.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.PNL_Msg.Size = New System.Drawing.Size(1034, 490)
        Me.PNL_Msg.TabIndex = 4
        '
        'LST_VIW
        '
        Me.LST_VIW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LST_VIW.Font = New System.Drawing.Font("Yu Gothic UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LST_VIW.FullRowSelect = True
        Me.LST_VIW.GridLines = True
        Me.LST_VIW.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.LST_VIW.Location = New System.Drawing.Point(15, 0)
        Me.LST_VIW.MultiSelect = False
        Me.LST_VIW.Name = "LST_VIW"
        Me.LST_VIW.Size = New System.Drawing.Size(1004, 490)
        Me.LST_VIW.TabIndex = 1
        Me.LST_VIW.UseCompatibleStateImageBehavior = False
        Me.LST_VIW.View = System.Windows.Forms.View.Details
        '
        'frm_List
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1034, 541)
        Me.Controls.Add(Me.PNL_Msg)
        Me.Controls.Add(Me.PNL_Status)
        Me.Controls.Add(Me.LBL_LST_MSG)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_List"
        Me.Opacity = 0.99R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "一覧参照"
        Me.PNL_Status.ResumeLayout(False)
        Me.PNL_Msg.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LBL_LST_MSG As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents PNL_Status As Windows.Forms.Panel
    Friend WithEvents LBL_END As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents PNL_Msg As Windows.Forms.Panel
    Friend WithEvents LST_VIW As Windows.Forms.ListView
End Class
