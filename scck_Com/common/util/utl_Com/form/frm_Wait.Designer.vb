<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Wait
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Wait))
        Me.LBL_Msg = New GrapeCity.Win.Buttons.GcLabel()
        Me.BTN_HID = New GrapeCity.Win.Buttons.GcShapeButton()
        Me.SuspendLayout()
        '
        'LBL_Msg
        '
        Me.LBL_Msg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LBL_Msg.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_Msg.Location = New System.Drawing.Point(0, 0)
        Me.LBL_Msg.Name = "LBL_Msg"
        Me.LBL_Msg.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.LBL_Msg.Size = New System.Drawing.Size(484, 31)
        Me.LBL_Msg.TabIndex = 0
        Me.LBL_Msg.Text = "メッセージ"
        Me.LBL_Msg.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_Msg.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'BTN_HID
        '
        Me.BTN_HID.BackColor = System.Drawing.Color.White
        Me.BTN_HID.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.BTN_HID.FlatAppearance.BorderSize = 0
        Me.BTN_HID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.BTN_HID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.BTN_HID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTN_HID.Image = CType(resources.GetObject("BTN_HID.Image"), System.Drawing.Image)
        Me.BTN_HID.Location = New System.Drawing.Point(453, 0)
        Me.BTN_HID.Name = "BTN_HID"
        Me.BTN_HID.Size = New System.Drawing.Size(28, 30)
        Me.BTN_HID.SizeMode = GrapeCity.Win.Buttons.GcShapeButtonSizeMode.CenterImage
        Me.BTN_HID.TabIndex = 999
        Me.BTN_HID.UseVisualStyleBackColor = False
        '
        'frm_Wait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 31)
        Me.ControlBox = False
        Me.Controls.Add(Me.BTN_HID)
        Me.Controls.Add(Me.LBL_Msg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "frm_Wait"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "暫くお待ち下さい・・・"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LBL_Msg As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents BTN_HID As GrapeCity.Win.Buttons.GcShapeButton
End Class
