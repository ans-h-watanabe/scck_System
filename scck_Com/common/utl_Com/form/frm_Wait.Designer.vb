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
        Me.lbl_Msg = New GrapeCity.Win.Buttons.GcLabel()
        Me.btn_HID = New GrapeCity.Win.Buttons.GcShapeButton()
        Me.SuspendLayout()
        '
        'lbl_Msg
        '
        Me.lbl_Msg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbl_Msg.Font = New System.Drawing.Font("Yu Gothic UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_Msg.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Msg.Name = "lbl_Msg"
        Me.lbl_Msg.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lbl_Msg.Size = New System.Drawing.Size(484, 31)
        Me.lbl_Msg.TabIndex = 0
        Me.lbl_Msg.Text = "メッセージ"
        Me.lbl_Msg.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.lbl_Msg.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'btn_HID
        '
        Me.btn_HID.BackColor = System.Drawing.Color.White
        Me.btn_HID.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.btn_HID.FlatAppearance.BorderSize = 0
        Me.btn_HID.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_HID.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.btn_HID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_HID.Image = CType(resources.GetObject("btn_HID.Image"), System.Drawing.Image)
        Me.btn_HID.Location = New System.Drawing.Point(453, 0)
        Me.btn_HID.Name = "btn_HID"
        Me.btn_HID.Size = New System.Drawing.Size(28, 30)
        Me.btn_HID.SizeMode = GrapeCity.Win.Buttons.GcShapeButtonSizeMode.CenterImage
        Me.btn_HID.TabIndex = 999
        Me.btn_HID.UseVisualStyleBackColor = False
        '
        'frm_Wait
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(484, 31)
        Me.ControlBox = False
        Me.Controls.Add(Me.btn_HID)
        Me.Controls.Add(Me.lbl_Msg)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.HelpButton = True
        Me.KeyPreview = True
        Me.Name = "frm_Wait"
        Me.Opacity = 0.8R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "暫くお待ち下さい・・・"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lbl_Msg As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents btn_HID As GrapeCity.Win.Buttons.GcShapeButton
End Class
