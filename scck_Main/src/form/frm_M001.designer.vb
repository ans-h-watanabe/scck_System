<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_M001
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
        Me.components = New System.ComponentModel.Container()
        Dim RoundedBorder1 As GrapeCity.Win.Containers.RoundedBorder = New GrapeCity.Win.Containers.RoundedBorder()
        Dim RoundedBorder2 As GrapeCity.Win.Containers.RoundedBorder = New GrapeCity.Win.Containers.RoundedBorder()
        Dim RoundedBorder3 As GrapeCity.Win.Containers.RoundedBorder = New GrapeCity.Win.Containers.RoundedBorder()
        Dim RoundedBorder4 As GrapeCity.Win.Containers.RoundedBorder = New GrapeCity.Win.Containers.RoundedBorder()
        Dim RoundedBorder5 As GrapeCity.Win.Containers.RoundedBorder = New GrapeCity.Win.Containers.RoundedBorder()
        Dim Border1 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim Border2 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim Border3 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim Border4 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim Border5 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim Border6 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim ThemeStateStyle4 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim NumberIntegerPartDisplayField2 As GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField = New GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField()
        Dim ThemeStateStyle3 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim NumberIntegerPartDisplayField1 As GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField = New GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField()
        Dim ThemeStateStyle2 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim ThemeStateStyle1 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Me.fnc_KEY = New GrapeCity.Win.Bars.GcClassicFunctionKey()
        Me.pnl_USR_IFO1 = New GrapeCity.Win.Containers.GcResizePanel()
        Me.ctl_USR_IFO1 = New GrapeCity.Win.Containers.GcTableLayoutContainer()
        Me.事業所 = New GrapeCity.Win.Containers.TableColumn()
        Me.支社 = New GrapeCity.Win.Containers.TableColumn()
        Me.部 = New GrapeCity.Win.Containers.TableColumn()
        Me.その他 = New GrapeCity.Win.Containers.TableColumn()
        Me.TableRow1 = New GrapeCity.Win.Containers.TableRow()
        Me.LBL_処理事業所 = New GrapeCity.Win.Buttons.GcLabel()
        Me.ctl_Main = New GrapeCity.Win.Containers.GcResizePanel()
        Me.s2 = New GrapeCity.Win.Containers.TableColumn()
        Me.s3 = New GrapeCity.Win.Containers.TableColumn()
        Me.処理モード = New GrapeCity.Win.Containers.TableColumn()
        Me.s1 = New GrapeCity.Win.Containers.TableColumn()
        Me.s4 = New GrapeCity.Win.Containers.TableColumn()
        Me.s5 = New GrapeCity.Win.Containers.TableColumn()
        Me.lbl_支社 = New GrapeCity.Win.Buttons.GcLabel()
        Me.lbl_部 = New GrapeCity.Win.Buttons.GcLabel()
        Me.lbl_MOD = New GrapeCity.Win.Buttons.GcLabel()
        Me.pnl_UPD = New GrapeCity.Win.Containers.GcResizePanel()
        Me.ctl_UPD = New GrapeCity.Win.Containers.GcTableLayoutContainer()
        Me.c1 = New GrapeCity.Win.Containers.TableColumn()
        Me.登録情報 = New GrapeCity.Win.Containers.TableColumn()
        Me.登録ユーザー情報 = New GrapeCity.Win.Containers.TableColumn()
        Me.登録日時 = New GrapeCity.Win.Containers.TableColumn()
        Me.更新情報 = New GrapeCity.Win.Containers.TableColumn()
        Me.更新ユーザー情報 = New GrapeCity.Win.Containers.TableColumn()
        Me.更新日時 = New GrapeCity.Win.Containers.TableColumn()
        Me.c3 = New GrapeCity.Win.Containers.TableColumn()
        Me.TableRow2 = New GrapeCity.Win.Containers.TableRow()
        Me.lbl_登録情報 = New GrapeCity.Win.Buttons.GcLabel()
        Me.c2 = New GrapeCity.Win.Containers.TableColumn()
        Me.TableRow3 = New GrapeCity.Win.Containers.TableRow()
        Me.lbl_登録日時 = New GrapeCity.Win.Buttons.GcLabel()
        Me.lbl_更新情報 = New GrapeCity.Win.Buttons.GcLabel()
        Me.lbl_登録ユーザー情報 = New GrapeCity.Win.Buttons.GcLabel()
        Me.lbl_更新日時 = New GrapeCity.Win.Buttons.GcLabel()
        Me.lbl_更新ユーザー情報 = New GrapeCity.Win.Buttons.GcLabel()
        Me.lbl_業務分類区分 = New GrapeCity.Win.Buttons.GcLabel()
        Me.GcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
        Me.txt_業務分類区分 = New GrapeCity.Win.Editors.GcNumber(Me.components)
        Me.txt_XID = New GrapeCity.Win.Editors.GcNumber(Me.components)
        Me.lbl_XID = New GrapeCity.Win.Buttons.GcLabel()
        Me.lbl_ブランク = New GrapeCity.Win.Buttons.GcLabel()
        Me.lbl_名称 = New GrapeCity.Win.Buttons.GcLabel()
        Me.txt_名称 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.lbl_略称 = New GrapeCity.Win.Buttons.GcLabel()
        Me.txt_略称 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.GcStylePlus1 = New GrapeCity.Win.Components.GcStylePlus()
        CType(Me.pnl_USR_IFO1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_USR_IFO1.SuspendLayout()
        CType(Me.ctl_USR_IFO1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctl_USR_IFO1.SuspendLayout()
        CType(Me.ctl_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctl_Main.SuspendLayout()
        CType(Me.pnl_UPD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pnl_UPD.SuspendLayout()
        CType(Me.ctl_UPD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ctl_UPD.SuspendLayout()
        CType(Me.txt_業務分類区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_XID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_略称, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'fnc_KEY
        '
        Me.fnc_KEY.KeySets.Remove("Default")
        Me.fnc_KEY.KeySets.Add("Initial", New GrapeCity.Win.Bars.KeySet(New GrapeCity.Win.Bars.KeyItem() {New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 0, True, System.Drawing.Color.Empty, -1, "新規", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 1, True, System.Drawing.Color.Empty, -1, "修正", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 2, True, System.Drawing.Color.Empty, -1, "削除", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 3, True, System.Drawing.Color.Empty, -1, "項目参照", "カーソルのある項目の参照画面を表示します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 4, True, System.Drawing.Color.Empty, -1, "<<", "先頭データへ移動します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 5, True, System.Drawing.Color.Empty, -1, "<", "表示しているデータの前データへ移動します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 6, True, System.Drawing.Color.Empty, -1, ">", "表示しているデータの後データへ移動します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 7, True, System.Drawing.Color.Empty, -1, ">>", "最終データへ移動します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 8, True, System.Drawing.Color.Empty, -1, "登録", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 9, True, System.Drawing.Color.Empty, -1, "検索", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 10, True, System.Drawing.Color.Empty, -1, "出力", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 11, True, System.Drawing.Color.Empty, -1, "閉じる", "画面を閉じます"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 12, True, System.Drawing.Color.Empty, -1, "Home", "Home"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 13, True, System.Drawing.Color.Empty, -1, "End", "End"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 14, True, System.Drawing.Color.Empty, -1, "Page Up", "Page Up"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 15, True, System.Drawing.Color.Empty, -1, "Page Down", "Page Down")}))
        Me.fnc_KEY.StyleSets.Add("XPThemeStyleSet1", New GrapeCity.Win.Bars.XPThemeStyleSet(GrapeCity.Win.Bars.AlignHorizontal.Center, GrapeCity.Win.Bars.AlignVertical.Middle, System.Drawing.SystemColors.Control, New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)), System.Drawing.SystemColors.ControlText, GrapeCity.Win.Bars.ImagePosition.Left, 2, New GrapeCity.Win.Common.Margins(1, 0, 1, 1), GrapeCity.Win.Common.TextEffect.Flat, True, New GrapeCity.Win.Common.Bevel(System.Drawing.SystemColors.Control, 0, 25, -25), System.Windows.Forms.BorderStyle.None))
        Me.fnc_KEY.ActiveKeySet = "Initial"
        Me.fnc_KEY.ActiveStyleSet = "XPThemeStyleSet1"
        Me.fnc_KEY.ColumnGroups = "4|4|4"
        Me.fnc_KEY.GroupSpacing = 9
        Me.fnc_KEY.Location = New System.Drawing.Point(0, 849)
        Me.fnc_KEY.Margin = New System.Windows.Forms.Padding(0)
        Me.fnc_KEY.Margins = New GrapeCity.Win.Common.Margins(0, 0, 0, 1)
        Me.fnc_KEY.Name = "fnc_KEY"
        Me.fnc_KEY.Size = New System.Drawing.Size(1400, 36)
        Me.fnc_KEY.TabIndex = 13
        Me.fnc_KEY.TabStop = False
        '
        'pnl_USR_IFO1
        '
        Me.pnl_USR_IFO1.Controls.Add(Me.ctl_USR_IFO1)
        Me.pnl_USR_IFO1.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnl_USR_IFO1.Location = New System.Drawing.Point(0, 0)
        Me.pnl_USR_IFO1.Name = "pnl_USR_IFO1"
        Me.pnl_USR_IFO1.Size = New System.Drawing.Size(1400, 20)
        Me.pnl_USR_IFO1.TabIndex = 31
        '
        'ctl_USR_IFO1
        '
        RoundedBorder1.AllCornerRadius = 0.1!
        RoundedBorder1.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder1.BottomLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder1.BottomRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder1.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder1.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder1.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder1.TopLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder1.TopRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder2.AllCornerRadius = 0.1!
        RoundedBorder2.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder2.BottomLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder2.BottomRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder2.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder2.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder2.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder2.TopLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder2.TopRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder3.AllCornerRadius = 0.1!
        RoundedBorder3.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder3.BottomLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder3.BottomRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder3.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder3.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder3.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder3.TopLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder3.TopRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder4.AllCornerRadius = 0.1!
        RoundedBorder4.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder4.BottomLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder4.BottomRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder4.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder4.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder4.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder4.TopLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder4.TopRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder5.AllCornerRadius = 0.1!
        RoundedBorder5.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder5.BottomLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder5.BottomRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder5.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder5.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder5.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder5.TopLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder5.TopRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        Me.ctl_USR_IFO1.Columns.AddRange(New GrapeCity.Win.Containers.TableColumn() {Me.s1, Me.事業所, Me.s2, Me.支社, Me.s3, Me.部, Me.s4, Me.その他, Me.s5, Me.処理モード})
        Me.ctl_USR_IFO1.Rows.AddRange(New GrapeCity.Win.Containers.TableRow() {Me.TableRow1})
        Me.ctl_USR_IFO1.CellInfos.AddRange(New GrapeCity.Win.Containers.CellInfo() {New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(1, 0), System.Drawing.SystemColors.GradientActiveCaption, RoundedBorder1, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(2, 0), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(3, 0), System.Drawing.SystemColors.GradientInactiveCaption, RoundedBorder2, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(5, 0), System.Drawing.SystemColors.GradientInactiveCaption, RoundedBorder3, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(9, 0), System.Drawing.Color.PaleTurquoise, RoundedBorder4, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(7, 0), System.Drawing.SystemColors.ControlLight, RoundedBorder5, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0))})
        Me.ctl_USR_IFO1.Controls.Add(Me.lbl_MOD, 9, 0)
        Me.ctl_USR_IFO1.Controls.Add(Me.lbl_部, 5, 0)
        Me.ctl_USR_IFO1.Controls.Add(Me.lbl_支社, 3, 0)
        Me.ctl_USR_IFO1.Controls.Add(Me.LBL_処理事業所, 1, 0)
        Me.ctl_USR_IFO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctl_USR_IFO1.Location = New System.Drawing.Point(0, 0)
        Me.ctl_USR_IFO1.Name = "ctl_USR_IFO1"
        Me.ctl_USR_IFO1.Size = New System.Drawing.Size(1400, 20)
        Me.ctl_USR_IFO1.TabIndex = 1
        '
        '事業所
        '
        Me.事業所.Width = 20.0!
        '
        '支社
        '
        Me.支社.Width = 20.0!
        '
        '部
        '
        Me.部.Width = 20.0!
        '
        'その他
        '
        Me.その他.Width = 19.05!
        '
        'TableRow1
        '
        Me.TableRow1.Height = 100.0!
        '
        'LBL_処理事業所
        '
        Me.LBL_処理事業所.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_処理事業所.AutoSize = True
        Me.LBL_処理事業所.BackColor = System.Drawing.Color.Transparent
        Me.LBL_処理事業所.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_処理事業所.Location = New System.Drawing.Point(7, 2)
        Me.LBL_処理事業所.Name = "LBL_処理事業所"
        Me.LBL_処理事業所.Size = New System.Drawing.Size(272, 15)
        Me.LBL_処理事業所.TabIndex = 0
        Me.LBL_処理事業所.Text = "事業所名"
        Me.LBL_処理事業所.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_処理事業所.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'ctl_Main
        '
        Me.ctl_Main.Controls.Add(Me.txt_略称)
        Me.ctl_Main.Controls.Add(Me.lbl_略称)
        Me.ctl_Main.Controls.Add(Me.txt_名称)
        Me.ctl_Main.Controls.Add(Me.lbl_名称)
        Me.ctl_Main.Controls.Add(Me.txt_XID)
        Me.ctl_Main.Controls.Add(Me.txt_業務分類区分)
        Me.ctl_Main.Controls.Add(Me.lbl_XID)
        Me.ctl_Main.Controls.Add(Me.lbl_ブランク)
        Me.ctl_Main.Controls.Add(Me.lbl_業務分類区分)
        Me.ctl_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctl_Main.Location = New System.Drawing.Point(0, 20)
        Me.ctl_Main.Margin = New System.Windows.Forms.Padding(0)
        Me.ctl_Main.Name = "ctl_Main"
        Me.ctl_Main.ResizeMode = GrapeCity.Win.Components.ResizeMode.None
        Me.ctl_Main.Size = New System.Drawing.Size(1400, 829)
        Me.ctl_Main.TabIndex = 0
        '
        's2
        '
        Me.s2.Width = 0.2!
        '
        's3
        '
        Me.s3.Width = 0.2!
        '
        '処理モード
        '
        Me.処理モード.Width = 20.0!
        '
        's1
        '
        Me.s1.Width = 0.15!
        '
        's4
        '
        Me.s4.Width = 0.2!
        '
        's5
        '
        Me.s5.Width = 0.2!
        '
        'lbl_支社
        '
        Me.lbl_支社.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_支社.AutoSize = True
        Me.lbl_支社.BackColor = System.Drawing.Color.Transparent
        Me.lbl_支社.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_支社.Location = New System.Drawing.Point(289, 2)
        Me.lbl_支社.Name = "lbl_支社"
        Me.lbl_支社.Size = New System.Drawing.Size(272, 15)
        Me.lbl_支社.TabIndex = 1
        Me.lbl_支社.Text = "支社名"
        Me.lbl_支社.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.lbl_支社.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'lbl_部
        '
        Me.lbl_部.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_部.AutoSize = True
        Me.lbl_部.BackColor = System.Drawing.Color.Transparent
        Me.lbl_部.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_部.Location = New System.Drawing.Point(571, 2)
        Me.lbl_部.Name = "lbl_部"
        Me.lbl_部.Size = New System.Drawing.Size(272, 15)
        Me.lbl_部.TabIndex = 2
        Me.lbl_部.Text = "部名"
        Me.lbl_部.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.lbl_部.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'lbl_MOD
        '
        Me.lbl_MOD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_MOD.AutoSize = True
        Me.lbl_MOD.BackColor = System.Drawing.Color.Transparent
        Me.lbl_MOD.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_MOD.Location = New System.Drawing.Point(1122, 2)
        Me.lbl_MOD.Name = "lbl_MOD"
        Me.lbl_MOD.Size = New System.Drawing.Size(272, 15)
        Me.lbl_MOD.TabIndex = 3
        Me.lbl_MOD.Text = "処理モード"
        Me.lbl_MOD.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.lbl_MOD.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'pnl_UPD
        '
        Me.pnl_UPD.Controls.Add(Me.ctl_UPD)
        Me.pnl_UPD.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnl_UPD.Location = New System.Drawing.Point(0, 814)
        Me.pnl_UPD.Name = "pnl_UPD"
        Me.pnl_UPD.Size = New System.Drawing.Size(1400, 35)
        Me.pnl_UPD.TabIndex = 33
        '
        'ctl_UPD
        '
        Border1.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border1.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border1.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border1.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border2.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border2.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border2.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border2.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border3.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border3.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border3.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border3.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border4.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border4.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border4.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border4.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border5.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border5.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border5.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border5.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border6.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border6.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border6.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Border6.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.Silver)
        Me.ctl_UPD.Columns.AddRange(New GrapeCity.Win.Containers.TableColumn() {Me.c1, Me.登録情報, Me.登録ユーザー情報, Me.登録日時, Me.c2, Me.更新情報, Me.更新ユーザー情報, Me.更新日時, Me.c3})
        Me.ctl_UPD.Rows.AddRange(New GrapeCity.Win.Containers.TableRow() {Me.TableRow2, Me.TableRow3})
        Me.ctl_UPD.CellInfos.AddRange(New GrapeCity.Win.Containers.CellInfo() {New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(2, 0), System.Drawing.Color.Ivory, Border1, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(3, 0), System.Drawing.Color.Ivory, Border2, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(6, 0), System.Drawing.Color.Ivory, Border3, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(7, 0), System.Drawing.Color.Ivory, Border4, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(8, 0), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(5, 0), System.Drawing.SystemColors.ControlLight, Border5, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(1, 0), System.Drawing.SystemColors.ControlLight, Border6, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0))})
        Me.ctl_UPD.Controls.Add(Me.lbl_更新ユーザー情報, 6, 0)
        Me.ctl_UPD.Controls.Add(Me.lbl_更新日時, 7, 0)
        Me.ctl_UPD.Controls.Add(Me.lbl_登録ユーザー情報, 2, 0)
        Me.ctl_UPD.Controls.Add(Me.lbl_登録日時, 3, 0)
        Me.ctl_UPD.Controls.Add(Me.lbl_登録情報, 1, 0)
        Me.ctl_UPD.Controls.Add(Me.lbl_更新情報, 5, 0)
        Me.ctl_UPD.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctl_UPD.Location = New System.Drawing.Point(0, 0)
        Me.ctl_UPD.Name = "ctl_UPD"
        Me.ctl_UPD.Size = New System.Drawing.Size(1400, 35)
        Me.ctl_UPD.TabIndex = 1
        '
        'c1
        '
        Me.c1.Width = 4.0!
        '
        '登録情報
        '
        Me.登録情報.Width = 5.5!
        '
        '登録ユーザー情報
        '
        Me.登録ユーザー情報.Width = 30.0!
        '
        '登録日時
        '
        Me.登録日時.Width = 10.0!
        '
        '更新情報
        '
        Me.更新情報.Width = 5.5!
        '
        '更新ユーザー情報
        '
        Me.更新ユーザー情報.Width = 30.0!
        '
        '更新日時
        '
        Me.更新日時.Width = 10.0!
        '
        'c3
        '
        Me.c3.Width = 4.0!
        '
        'TableRow2
        '
        Me.TableRow2.Height = 55.0!
        '
        'lbl_登録情報
        '
        Me.lbl_登録情報.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_登録情報.AutoSize = True
        Me.lbl_登録情報.BackColor = System.Drawing.Color.Transparent
        Me.lbl_登録情報.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_登録情報.Location = New System.Drawing.Point(61, 2)
        Me.lbl_登録情報.Name = "lbl_登録情報"
        Me.lbl_登録情報.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.lbl_登録情報.Size = New System.Drawing.Size(70, 16)
        Me.lbl_登録情報.TabIndex = 0
        Me.lbl_登録情報.Text = "登録情報"
        Me.lbl_登録情報.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.lbl_登録情報.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'c2
        '
        Me.c2.Width = 1.0!
        '
        'TableRow3
        '
        Me.TableRow3.Height = 45.0!
        '
        'lbl_登録日時
        '
        Me.lbl_登録日時.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_登録日時.AutoSize = True
        Me.lbl_登録日時.BackColor = System.Drawing.Color.Transparent
        Me.lbl_登録日時.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_登録日時.Location = New System.Drawing.Point(556, 2)
        Me.lbl_登録日時.Name = "lbl_登録日時"
        Me.lbl_登録日時.Size = New System.Drawing.Size(133, 16)
        Me.lbl_登録日時.TabIndex = 1
        Me.lbl_登録日時.Text = "99/99/99 00:00"
        Me.lbl_登録日時.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.lbl_登録日時.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'lbl_更新情報
        '
        Me.lbl_更新情報.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_更新情報.AutoSize = True
        Me.lbl_更新情報.BackColor = System.Drawing.Color.Transparent
        Me.lbl_更新情報.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_更新情報.Location = New System.Drawing.Point(710, 2)
        Me.lbl_更新情報.Name = "lbl_更新情報"
        Me.lbl_更新情報.Size = New System.Drawing.Size(70, 16)
        Me.lbl_更新情報.TabIndex = 2
        Me.lbl_更新情報.Text = "更新情報"
        Me.lbl_更新情報.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.lbl_更新情報.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'lbl_登録ユーザー情報
        '
        Me.lbl_登録ユーザー情報.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_登録ユーザー情報.AutoSize = True
        Me.lbl_登録ユーザー情報.BackColor = System.Drawing.Color.Transparent
        Me.lbl_登録ユーザー情報.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_登録ユーザー情報.Location = New System.Drawing.Point(138, 2)
        Me.lbl_登録ユーザー情報.Name = "lbl_登録ユーザー情報"
        Me.lbl_登録ユーザー情報.Size = New System.Drawing.Size(411, 16)
        Me.lbl_登録ユーザー情報.TabIndex = 3
        Me.lbl_登録ユーザー情報.Text = "登録ユーザー情報"
        Me.lbl_登録ユーザー情報.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lbl_登録ユーザー情報.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'lbl_更新日時
        '
        Me.lbl_更新日時.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_更新日時.AutoSize = True
        Me.lbl_更新日時.BackColor = System.Drawing.Color.Transparent
        Me.lbl_更新日時.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_更新日時.Location = New System.Drawing.Point(1206, 2)
        Me.lbl_更新日時.Name = "lbl_更新日時"
        Me.lbl_更新日時.Size = New System.Drawing.Size(132, 16)
        Me.lbl_更新日時.TabIndex = 4
        Me.lbl_更新日時.Text = "99/99/99 00:00"
        Me.lbl_更新日時.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.lbl_更新日時.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'lbl_更新ユーザー情報
        '
        Me.lbl_更新ユーザー情報.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_更新ユーザー情報.AutoSize = True
        Me.lbl_更新ユーザー情報.BackColor = System.Drawing.Color.Transparent
        Me.lbl_更新ユーザー情報.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl_更新ユーザー情報.Location = New System.Drawing.Point(787, 2)
        Me.lbl_更新ユーザー情報.Name = "lbl_更新ユーザー情報"
        Me.lbl_更新ユーザー情報.Size = New System.Drawing.Size(412, 16)
        Me.lbl_更新ユーザー情報.TabIndex = 5
        Me.lbl_更新ユーザー情報.Text = "更新ユーザー情報"
        Me.lbl_更新ユーザー情報.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lbl_更新ユーザー情報.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'lbl_業務分類区分
        '
        Me.lbl_業務分類区分.BackColor = System.Drawing.Color.Transparent
        Me.lbl_業務分類区分.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_業務分類区分.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.lbl_業務分類区分.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_業務分類区分.Location = New System.Drawing.Point(20, 12)
        Me.lbl_業務分類区分.Name = "lbl_業務分類区分"
        Me.lbl_業務分類区分.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.ctl_Main.SetResizeMode(Me.lbl_業務分類区分, GrapeCity.Win.Components.ResizeMode.None)
        Me.lbl_業務分類区分.Size = New System.Drawing.Size(1039, 20)
        Me.lbl_業務分類区分.TabIndex = 27
        Me.lbl_業務分類区分.Text = "業務分類区分"
        Me.lbl_業務分類区分.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lbl_業務分類区分.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'txt_業務分類区分
        '
        ThemeStateStyle4.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle4.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.txt_業務分類区分, ThemeStateStyle4)
        Me.txt_業務分類区分.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_業務分類区分.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_業務分類区分.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.txt_業務分類区分.DisabledForeColor = System.Drawing.SystemColors.WindowText
        NumberIntegerPartDisplayField2.GroupSizes = New Integer() {0}
        Me.txt_業務分類区分.DisplayFields.AddRange(New GrapeCity.Win.Editors.Fields.NumberDisplayField() {NumberIntegerPartDisplayField2})
        Me.txt_業務分類区分.DropDown.AllowDrop = False
        Me.txt_業務分類区分.Fields.DecimalPart.MaxDigits = 0
        Me.txt_業務分類区分.Fields.IntegerPart.GroupSizes = New Integer() {0}
        Me.txt_業務分類区分.Fields.IntegerPart.MaxDigits = 2
        Me.txt_業務分類区分.Fields.IntegerPart.MinDigits = 1
        Me.txt_業務分類区分.Fields.SignPrefix.NegativePattern = ""
        Me.txt_業務分類区分.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.txt_業務分類区分.HighlightText = True
        Me.txt_業務分類区分.Location = New System.Drawing.Point(129, 12)
        Me.txt_業務分類区分.MaxMinBehavior = GrapeCity.Win.Editors.MaxMinBehavior.Keep
        Me.txt_業務分類区分.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.txt_業務分類区分.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_業務分類区分.Name = "txt_業務分類区分"
        Me.txt_業務分類区分.Padding = New System.Windows.Forms.Padding(1, 1, 3, 1)
        Me.ctl_Main.SetResizeMode(Me.txt_業務分類区分, GrapeCity.Win.Components.ResizeMode.None)
        Me.GcShortcut1.SetShortcuts(Me.txt_業務分類区分, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.txt_業務分類区分.Size = New System.Drawing.Size(34, 19)
        Me.txt_業務分類区分.Spin.AllowSpin = False
        Me.txt_業務分類区分.Spin.Increment = 0
        Me.txt_業務分類区分.Spin.SpinOnKeys = False
        Me.txt_業務分類区分.Spin.SpinOnWheel = False
        Me.txt_業務分類区分.Spin.Wrap = False
        Me.txt_業務分類区分.TabIndex = 0
        Me.txt_業務分類区分.Value = Nothing
        '
        'txt_XID
        '
        ThemeStateStyle3.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.txt_XID, ThemeStateStyle3)
        Me.txt_XID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_XID.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.txt_XID.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.txt_XID.DisabledForeColor = System.Drawing.SystemColors.WindowText
        NumberIntegerPartDisplayField1.GroupSizes = New Integer() {0}
        NumberIntegerPartDisplayField1.MinDigits = 0
        Me.txt_XID.DisplayFields.AddRange(New GrapeCity.Win.Editors.Fields.NumberDisplayField() {NumberIntegerPartDisplayField1})
        Me.txt_XID.DropDown.AllowDrop = False
        Me.txt_XID.Enabled = False
        Me.txt_XID.Fields.DecimalPart.MaxDigits = 0
        Me.txt_XID.Fields.IntegerPart.GroupSizes = New Integer() {0}
        Me.txt_XID.Fields.IntegerPart.MaxDigits = 10
        Me.txt_XID.Fields.SignPrefix.NegativePattern = ""
        Me.txt_XID.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.txt_XID.HighlightText = True
        Me.txt_XID.Location = New System.Drawing.Point(1092, 12)
        Me.txt_XID.MaxMinBehavior = GrapeCity.Win.Editors.MaxMinBehavior.Keep
        Me.txt_XID.MaxValue = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.txt_XID.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txt_XID.Name = "txt_XID"
        Me.txt_XID.Padding = New System.Windows.Forms.Padding(1, 1, 3, 1)
        Me.ctl_Main.SetResizeMode(Me.txt_XID, GrapeCity.Win.Components.ResizeMode.None)
        Me.GcShortcut1.SetShortcuts(Me.txt_XID, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.txt_XID.Size = New System.Drawing.Size(88, 19)
        Me.txt_XID.Spin.AllowSpin = False
        Me.txt_XID.Spin.Increment = 0
        Me.txt_XID.Spin.SpinOnKeys = False
        Me.txt_XID.Spin.SpinOnWheel = False
        Me.txt_XID.Spin.Wrap = False
        Me.txt_XID.TabIndex = 3
        Me.txt_XID.TabStop = False
        Me.txt_XID.Value = Nothing
        '
        'lbl_XID
        '
        Me.lbl_XID.BackColor = System.Drawing.Color.Transparent
        Me.lbl_XID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_XID.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.lbl_XID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_XID.Location = New System.Drawing.Point(1039, 12)
        Me.lbl_XID.Name = "lbl_XID"
        Me.lbl_XID.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.ctl_Main.SetResizeMode(Me.lbl_XID, GrapeCity.Win.Components.ResizeMode.None)
        Me.lbl_XID.Size = New System.Drawing.Size(54, 20)
        Me.lbl_XID.TabIndex = 33
        Me.lbl_XID.Text = "XID"
        Me.lbl_XID.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lbl_XID.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'lbl_ブランク
        '
        Me.lbl_ブランク.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ブランク.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_ブランク.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.lbl_ブランク.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_ブランク.Location = New System.Drawing.Point(20, 30)
        Me.lbl_ブランク.Name = "lbl_ブランク"
        Me.lbl_ブランク.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.ctl_Main.SetResizeMode(Me.lbl_ブランク, GrapeCity.Win.Components.ResizeMode.None)
        Me.lbl_ブランク.Size = New System.Drawing.Size(1161, 20)
        Me.lbl_ブランク.TabIndex = 35
        Me.lbl_ブランク.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lbl_ブランク.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'lbl_名称
        '
        Me.lbl_名称.BackColor = System.Drawing.Color.Transparent
        Me.lbl_名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_名称.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.lbl_名称.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_名称.Location = New System.Drawing.Point(20, 49)
        Me.lbl_名称.Name = "lbl_名称"
        Me.lbl_名称.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.ctl_Main.SetResizeMode(Me.lbl_名称, GrapeCity.Win.Components.ResizeMode.None)
        Me.lbl_名称.Size = New System.Drawing.Size(1161, 20)
        Me.lbl_名称.TabIndex = 36
        Me.lbl_名称.Text = "名称"
        Me.lbl_名称.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lbl_名称.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'txt_名称
        '
        ThemeStateStyle2.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.txt_名称, ThemeStateStyle2)
        Me.txt_名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_名称.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txt_名称.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.txt_名称.DisabledForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_名称.DropDown.AllowDrop = False
        Me.txt_名称.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.txt_名称.HighlightText = True
        Me.txt_名称.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt_名称.Location = New System.Drawing.Point(129, 49)
        Me.txt_名称.MaxLength = 20
        Me.txt_名称.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.[Byte]
        Me.txt_名称.Name = "txt_名称"
        Me.txt_名称.Padding = New System.Windows.Forms.Padding(3, 1, 1, 1)
        Me.ctl_Main.SetResizeMode(Me.txt_名称, GrapeCity.Win.Components.ResizeMode.None)
        Me.GcShortcut1.SetShortcuts(Me.txt_名称, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.txt_名称.Size = New System.Drawing.Size(170, 19)
        Me.txt_名称.TabIndex = 1
        Me.txt_名称.Text = "00008000080000800008"
        '
        'lbl_略称
        '
        Me.lbl_略称.BackColor = System.Drawing.Color.Transparent
        Me.lbl_略称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbl_略称.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.lbl_略称.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lbl_略称.Location = New System.Drawing.Point(20, 67)
        Me.lbl_略称.Name = "lbl_略称"
        Me.lbl_略称.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.ctl_Main.SetResizeMode(Me.lbl_略称, GrapeCity.Win.Components.ResizeMode.None)
        Me.lbl_略称.Size = New System.Drawing.Size(1161, 20)
        Me.lbl_略称.TabIndex = 38
        Me.lbl_略称.Text = "略称"
        Me.lbl_略称.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.lbl_略称.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'txt_略称
        '
        ThemeStateStyle1.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle1.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.txt_略称, ThemeStateStyle1)
        Me.txt_略称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_略称.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.txt_略称.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.txt_略称.DisabledForeColor = System.Drawing.SystemColors.WindowText
        Me.txt_略称.DropDown.AllowDrop = False
        Me.txt_略称.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.txt_略称.HighlightText = True
        Me.txt_略称.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt_略称.Location = New System.Drawing.Point(129, 67)
        Me.txt_略称.MaxLength = 10
        Me.txt_略称.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.[Byte]
        Me.txt_略称.Name = "txt_略称"
        Me.txt_略称.Padding = New System.Windows.Forms.Padding(3, 1, 1, 1)
        Me.ctl_Main.SetResizeMode(Me.txt_略称, GrapeCity.Win.Components.ResizeMode.None)
        Me.GcShortcut1.SetShortcuts(Me.txt_略称, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.txt_略称.Size = New System.Drawing.Size(95, 19)
        Me.txt_略称.TabIndex = 2
        Me.txt_略称.Text = "0000800008"
        '
        'frm_M001
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1400, 885)
        Me.Controls.Add(Me.pnl_UPD)
        Me.Controls.Add(Me.ctl_Main)
        Me.Controls.Add(Me.pnl_USR_IFO1)
        Me.Controls.Add(Me.fnc_KEY)
        Me.Name = "frm_M001"
        Me.Text = "業務分類区分マスター / M002 / 《Dev》 Ver 00000.00"
        CType(Me.pnl_USR_IFO1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_USR_IFO1.ResumeLayout(False)
        CType(Me.ctl_USR_IFO1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctl_USR_IFO1.ResumeLayout(False)
        Me.ctl_USR_IFO1.PerformLayout()
        CType(Me.ctl_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctl_Main.ResumeLayout(False)
        CType(Me.pnl_UPD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pnl_UPD.ResumeLayout(False)
        CType(Me.ctl_UPD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ctl_UPD.ResumeLayout(False)
        Me.ctl_UPD.PerformLayout()
        CType(Me.txt_業務分類区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_XID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_略称, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fnc_KEY As GrapeCity.Win.Bars.GcClassicFunctionKey
    Friend WithEvents pnl_USR_IFO1 As GrapeCity.Win.Containers.GcResizePanel
    Friend WithEvents ctl_USR_IFO1 As GrapeCity.Win.Containers.GcTableLayoutContainer
    Friend WithEvents 事業所 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents 支社 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents 部 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents その他 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents LBL_処理事業所 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents TableRow1 As GrapeCity.Win.Containers.TableRow
    Friend WithEvents ctl_Main As GrapeCity.Win.Containers.GcResizePanel
    Friend WithEvents s2 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s3 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents 処理モード As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s1 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s4 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s5 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents lbl_支社 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents lbl_部 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents lbl_MOD As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents pnl_UPD As GrapeCity.Win.Containers.GcResizePanel
    Friend WithEvents ctl_UPD As GrapeCity.Win.Containers.GcTableLayoutContainer
    Friend WithEvents c1 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents 登録情報 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents 登録日時 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents 更新情報 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents 更新ユーザー情報 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents 更新日時 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents c3 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents lbl_登録情報 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents TableRow2 As GrapeCity.Win.Containers.TableRow
    Friend WithEvents 登録ユーザー情報 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents c2 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents TableRow3 As GrapeCity.Win.Containers.TableRow
    Friend WithEvents lbl_登録日時 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents lbl_更新日時 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents lbl_登録ユーザー情報 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents lbl_更新情報 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents lbl_更新ユーザー情報 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents lbl_業務分類区分 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents txt_業務分類区分 As GrapeCity.Win.Editors.GcNumber
    Friend WithEvents GcShortcut1 As GrapeCity.Win.Editors.GcShortcut
    Friend WithEvents txt_XID As GrapeCity.Win.Editors.GcNumber
    Friend WithEvents lbl_XID As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents lbl_ブランク As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents lbl_名称 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents txt_名称 As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents lbl_略称 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents txt_略称 As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents GcStylePlus1 As GrapeCity.Win.Components.GcStylePlus
End Class
