<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Error
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Error))
        Dim ItemTemplate1 As GrapeCity.Win.Editors.ItemTemplate = New GrapeCity.Win.Editors.ItemTemplate()
        Dim ItemTemplate2 As GrapeCity.Win.Editors.ItemTemplate = New GrapeCity.Win.Editors.ItemTemplate()
        Me.LBL_TTL = New GrapeCity.Win.Buttons.GcLabel()
        Me.PNL_Status = New System.Windows.Forms.Panel()
        Me.LBL_MSG = New GrapeCity.Win.Buttons.GcLabel()
        Me.PIC_CLS = New System.Windows.Forms.PictureBox()
        Me.PNL_Msg = New System.Windows.Forms.Panel()
        Me.LST_MSG = New GrapeCity.Win.Editors.GcListBox()
        Me.項目名 = New GrapeCity.Win.Editors.ListColumn()
        Me.メッセージ = New GrapeCity.Win.Editors.ListColumn()
        Me.PNL_Status.SuspendLayout()
        CType(Me.PIC_CLS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_Msg.SuspendLayout()
        CType(Me.LST_MSG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_TTL
        '
        Me.LBL_TTL.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_TTL.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.LBL_TTL.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LBL_TTL.Location = New System.Drawing.Point(0, 0)
        Me.LBL_TTL.Name = "LBL_TTL"
        Me.LBL_TTL.Padding = New System.Windows.Forms.Padding(5, 3, 0, 0)
        Me.LBL_TTL.Size = New System.Drawing.Size(1034, 31)
        Me.LBL_TTL.TabIndex = 0
        Me.LBL_TTL.Text = "メッセージ"
        Me.LBL_TTL.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_TTL.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'PNL_Status
        '
        Me.PNL_Status.Controls.Add(Me.LBL_MSG)
        Me.PNL_Status.Controls.Add(Me.PIC_CLS)
        Me.PNL_Status.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PNL_Status.Location = New System.Drawing.Point(0, 491)
        Me.PNL_Status.Name = "PNL_Status"
        Me.PNL_Status.Padding = New System.Windows.Forms.Padding(5, 0, 0, 0)
        Me.PNL_Status.Size = New System.Drawing.Size(1034, 20)
        Me.PNL_Status.TabIndex = 2
        '
        'LBL_MSG
        '
        Me.LBL_MSG.Dock = System.Windows.Forms.DockStyle.Left
        Me.LBL_MSG.Font = New System.Drawing.Font("Yu Gothic UI", 8.5!)
        Me.LBL_MSG.ForeColor = System.Drawing.Color.DarkRed
        Me.LBL_MSG.Location = New System.Drawing.Point(21, 0)
        Me.LBL_MSG.Name = "LBL_MSG"
        Me.LBL_MSG.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.LBL_MSG.Size = New System.Drawing.Size(359, 20)
        Me.LBL_MSG.TabIndex = 4
        Me.LBL_MSG.Text = "[F12][Esc]=閉じる"
        Me.LBL_MSG.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_MSG.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'PIC_CLS
        '
        Me.PIC_CLS.Dock = System.Windows.Forms.DockStyle.Left
        Me.PIC_CLS.Image = CType(resources.GetObject("PIC_CLS.Image"), System.Drawing.Image)
        Me.PIC_CLS.Location = New System.Drawing.Point(5, 0)
        Me.PIC_CLS.Margin = New System.Windows.Forms.Padding(0)
        Me.PIC_CLS.Name = "PIC_CLS"
        Me.PIC_CLS.Size = New System.Drawing.Size(16, 20)
        Me.PIC_CLS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PIC_CLS.TabIndex = 1
        Me.PIC_CLS.TabStop = False
        '
        'PNL_Msg
        '
        Me.PNL_Msg.Controls.Add(Me.LST_MSG)
        Me.PNL_Msg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PNL_Msg.Location = New System.Drawing.Point(0, 31)
        Me.PNL_Msg.Name = "PNL_Msg"
        Me.PNL_Msg.Padding = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.PNL_Msg.Size = New System.Drawing.Size(1034, 460)
        Me.PNL_Msg.TabIndex = 4
        '
        'LST_MSG
        '
        Me.LST_MSG.BackColor = System.Drawing.SystemColors.Info
        Me.LST_MSG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LST_MSG.Columns.AddRange(New GrapeCity.Win.Editors.ListColumn() {Me.項目名, Me.メッセージ})
        Me.LST_MSG.DisabledItemStyle.BackColor = System.Drawing.SystemColors.Info
        Me.LST_MSG.DisabledItemStyle.ForeColor = System.Drawing.Color.Firebrick
        Me.LST_MSG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LST_MSG.Font = New System.Drawing.Font("Yu Gothic UI", 9.5!)
        Me.LST_MSG.ForeColor = System.Drawing.Color.Firebrick
        Me.LST_MSG.GridLines.HorizontalLines = New GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.Dotted, System.Drawing.SystemColors.ControlDark)
        Me.LST_MSG.GridLines.VerticalLines = New GrapeCity.Win.Editors.Line(GrapeCity.Win.Editors.LineStyle.None, System.Drawing.Color.Empty)
        Me.LST_MSG.ItemTemplates.Add(ItemTemplate1)
        Me.LST_MSG.ItemTemplates.Add(ItemTemplate2)
        Me.LST_MSG.ListHeaderPane.Height = 24
        Me.LST_MSG.ListHeaderPane.Visible = False
        Me.LST_MSG.Location = New System.Drawing.Point(15, 0)
        Me.LST_MSG.Margin = New System.Windows.Forms.Padding(0)
        Me.LST_MSG.Name = "LST_MSG"
        Me.LST_MSG.SelectedItemStyle.BackColor = System.Drawing.SystemColors.Info
        Me.LST_MSG.SelectedItemStyle.ForeColor = System.Drawing.Color.Firebrick
        Me.LST_MSG.Size = New System.Drawing.Size(1004, 460)
        Me.LST_MSG.TabIndex = 4
        '
        '項目名
        '
        Me.項目名.Header.Text = "Column1"
        Me.項目名.Width = 150
        '
        'メッセージ
        '
        Me.メッセージ.Header.Text = "Column2"
        Me.メッセージ.Width = 854
        '
        'frm_Error
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Info
        Me.ClientSize = New System.Drawing.Size(1034, 511)
        Me.Controls.Add(Me.PNL_Msg)
        Me.Controls.Add(Me.PNL_Status)
        Me.Controls.Add(Me.LBL_TTL)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Error"
        Me.Opacity = 0.99R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "エラー一覧"
        Me.PNL_Status.ResumeLayout(False)
        CType(Me.PIC_CLS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_Msg.ResumeLayout(False)
        CType(Me.LST_MSG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LBL_TTL As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents PNL_Status As Windows.Forms.Panel
    Friend WithEvents PIC_CLS As Windows.Forms.PictureBox
    Friend WithEvents LBL_MSG As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents PNL_Msg As Windows.Forms.Panel
    Friend WithEvents LST_MSG As GrapeCity.Win.Editors.GcListBox
    Friend WithEvents 項目名 As GrapeCity.Win.Editors.ListColumn
    Friend WithEvents メッセージ As GrapeCity.Win.Editors.ListColumn
End Class
