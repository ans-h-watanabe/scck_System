<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_M002_ins
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
        Dim ThemeStateStyle1 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim ThemeStateStyle2 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim ThemeStateStyle3 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim NumberIntegerPartDisplayField1 As GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField = New GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField()
        Dim ThemeStateStyle4 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim NumberIntegerPartDisplayField2 As GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField = New GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_M002_ins))
        Dim Border1 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim Border2 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim Border3 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim Border4 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim Border5 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Dim Border6 As GrapeCity.Win.Containers.Border = New GrapeCity.Win.Containers.Border()
        Me.PNL_USR_IFO1 = New GrapeCity.Win.Containers.GcResizePanel()
        Me.CTL_USR_IFO1 = New GrapeCity.Win.Containers.GcTableLayoutContainer()
        Me.s1 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_事業所 = New GrapeCity.Win.Containers.TableColumn()
        Me.s2 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_支社 = New GrapeCity.Win.Containers.TableColumn()
        Me.s3 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_部 = New GrapeCity.Win.Containers.TableColumn()
        Me.s4 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_その他 = New GrapeCity.Win.Containers.TableColumn()
        Me.s5 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_処理モード = New GrapeCity.Win.Containers.TableColumn()
        Me.ROW_S01 = New GrapeCity.Win.Containers.TableRow()
        Me.LBL_MOD = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_部 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_支社 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_処理事業所 = New GrapeCity.Win.Buttons.GcLabel()
        Me.GcShortcut1 = New GrapeCity.Win.Editors.GcShortcut(Me.components)
        Me.TXT_略称 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.TXT_名称 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.TXT_XID = New GrapeCity.Win.Editors.GcNumber(Me.components)
        Me.TXT_業務分類区分 = New GrapeCity.Win.Editors.GcNumber(Me.components)
        Me.GcStylePlus1 = New GrapeCity.Win.Components.GcStylePlus()
        Me.STT_Status = New System.Windows.Forms.StatusStrip()
        Me.STT_Msg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FNC_KEY = New GrapeCity.Win.Bars.GcClassicFunctionKey()
        Me.CTL_UPD = New GrapeCity.Win.Containers.GcTableLayoutContainer()
        Me.c1 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_登録情報 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_登録ユーザー情報 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_登録日時 = New GrapeCity.Win.Containers.TableColumn()
        Me.c2 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_更新情報 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_更新ユーザー情報 = New GrapeCity.Win.Containers.TableColumn()
        Me.CEL_更新日時 = New GrapeCity.Win.Containers.TableColumn()
        Me.c3 = New GrapeCity.Win.Containers.TableColumn()
        Me.ROW_S02 = New GrapeCity.Win.Containers.TableRow()
        Me.ROW_S03 = New GrapeCity.Win.Containers.TableRow()
        Me.LBL_更新ユーザー情報 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_更新日時 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_登録ユーザー情報 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_登録日時 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_登録情報 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_更新情報 = New GrapeCity.Win.Buttons.GcLabel()
        Me.CTL_Main = New GrapeCity.Win.Containers.GcResizePanel()
        Me.LBL_略称 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_名称 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_XID = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_ブランク = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_業務分類区分 = New GrapeCity.Win.Buttons.GcLabel()
        CType(Me.PNL_USR_IFO1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_USR_IFO1.SuspendLayout()
        CType(Me.CTL_USR_IFO1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTL_USR_IFO1.SuspendLayout()
        CType(Me.TXT_略称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_XID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_業務分類区分, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STT_Status.SuspendLayout()
        CType(Me.CTL_UPD, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTL_UPD.SuspendLayout()
        CType(Me.CTL_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTL_Main.SuspendLayout()
        Me.SuspendLayout()
        '
        'PNL_USR_IFO1
        '
        Me.PNL_USR_IFO1.Controls.Add(Me.CTL_USR_IFO1)
        Me.PNL_USR_IFO1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PNL_USR_IFO1.Location = New System.Drawing.Point(0, 0)
        Me.PNL_USR_IFO1.Name = "PNL_USR_IFO1"
        Me.PNL_USR_IFO1.Size = New System.Drawing.Size(1400, 20)
        Me.PNL_USR_IFO1.TabIndex = 31
        '
        'CTL_USR_IFO1
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
        Me.CTL_USR_IFO1.Columns.AddRange(New GrapeCity.Win.Containers.TableColumn() {Me.s1, Me.CEL_事業所, Me.s2, Me.CEL_支社, Me.s3, Me.CEL_部, Me.s4, Me.CEL_その他, Me.s5, Me.CEL_処理モード})
        Me.CTL_USR_IFO1.Rows.AddRange(New GrapeCity.Win.Containers.TableRow() {Me.ROW_S01})
        Me.CTL_USR_IFO1.CellInfos.AddRange(New GrapeCity.Win.Containers.CellInfo() {New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(1, 0), System.Drawing.SystemColors.GradientActiveCaption, RoundedBorder1, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(2, 0), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(3, 0), System.Drawing.SystemColors.GradientInactiveCaption, RoundedBorder2, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(5, 0), System.Drawing.SystemColors.GradientInactiveCaption, RoundedBorder3, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(9, 0), System.Drawing.Color.PaleTurquoise, RoundedBorder4, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(7, 0), System.Drawing.SystemColors.ControlLight, RoundedBorder5, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0))})
        Me.CTL_USR_IFO1.Controls.Add(Me.LBL_MOD, 9, 0)
        Me.CTL_USR_IFO1.Controls.Add(Me.LBL_部, 5, 0)
        Me.CTL_USR_IFO1.Controls.Add(Me.LBL_支社, 3, 0)
        Me.CTL_USR_IFO1.Controls.Add(Me.LBL_処理事業所, 1, 0)
        Me.CTL_USR_IFO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CTL_USR_IFO1.Location = New System.Drawing.Point(0, 0)
        Me.CTL_USR_IFO1.Name = "CTL_USR_IFO1"
        Me.CTL_USR_IFO1.Size = New System.Drawing.Size(1400, 20)
        Me.CTL_USR_IFO1.TabIndex = 1
        '
        's1
        '
        Me.s1.Width = 0.15!
        '
        'CEL_事業所
        '
        Me.CEL_事業所.Width = 20.0!
        '
        's2
        '
        Me.s2.Width = 0.2!
        '
        'CEL_支社
        '
        Me.CEL_支社.Width = 20.0!
        '
        's3
        '
        Me.s3.Width = 0.2!
        '
        'CEL_部
        '
        Me.CEL_部.Width = 20.0!
        '
        's4
        '
        Me.s4.Width = 0.2!
        '
        'CEL_その他
        '
        Me.CEL_その他.Width = 19.05!
        '
        's5
        '
        Me.s5.Width = 0.2!
        '
        'CEL_処理モード
        '
        Me.CEL_処理モード.Width = 20.0!
        '
        'ROW_S01
        '
        Me.ROW_S01.Height = 100.0!
        '
        'LBL_MOD
        '
        Me.LBL_MOD.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_MOD.AutoSize = True
        Me.LBL_MOD.BackColor = System.Drawing.Color.Transparent
        Me.LBL_MOD.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_MOD.Location = New System.Drawing.Point(1122, 2)
        Me.LBL_MOD.Name = "LBL_MOD"
        Me.LBL_MOD.Size = New System.Drawing.Size(272, 15)
        Me.LBL_MOD.TabIndex = 3
        Me.LBL_MOD.Text = "処理モード"
        Me.LBL_MOD.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_MOD.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_部
        '
        Me.LBL_部.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_部.AutoSize = True
        Me.LBL_部.BackColor = System.Drawing.Color.Transparent
        Me.LBL_部.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_部.Location = New System.Drawing.Point(571, 2)
        Me.LBL_部.Name = "LBL_部"
        Me.LBL_部.Size = New System.Drawing.Size(272, 15)
        Me.LBL_部.TabIndex = 2
        Me.LBL_部.Text = "部名"
        Me.LBL_部.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_部.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_支社
        '
        Me.LBL_支社.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_支社.AutoSize = True
        Me.LBL_支社.BackColor = System.Drawing.Color.Transparent
        Me.LBL_支社.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_支社.Location = New System.Drawing.Point(289, 2)
        Me.LBL_支社.Name = "LBL_支社"
        Me.LBL_支社.Size = New System.Drawing.Size(272, 15)
        Me.LBL_支社.TabIndex = 1
        Me.LBL_支社.Text = "支社名"
        Me.LBL_支社.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_支社.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
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
        'TXT_略称
        '
        ThemeStateStyle1.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle1.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.TXT_略称, ThemeStateStyle1)
        Me.TXT_略称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_略称.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.TXT_略称.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_略称.DisabledForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_略称.DropDown.AllowDrop = False
        Me.TXT_略称.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_略称.HighlightText = True
        Me.TXT_略称.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.TXT_略称.Location = New System.Drawing.Point(129, 67)
        Me.TXT_略称.MaxLength = 10
        Me.TXT_略称.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.[Byte]
        Me.TXT_略称.Name = "TXT_略称"
        Me.TXT_略称.Padding = New System.Windows.Forms.Padding(3, 1, 1, 1)
        Me.CTL_Main.SetResizeMode(Me.TXT_略称, GrapeCity.Win.Components.ResizeMode.None)
        Me.GcShortcut1.SetShortcuts(Me.TXT_略称, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_略称.Size = New System.Drawing.Size(98, 19)
        Me.TXT_略称.TabIndex = 2
        '
        'TXT_名称
        '
        ThemeStateStyle2.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle2.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.TXT_名称, ThemeStateStyle2)
        Me.TXT_名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_名称.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.TXT_名称.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_名称.DisabledForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_名称.DropDown.AllowDrop = False
        Me.TXT_名称.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_名称.HighlightText = True
        Me.TXT_名称.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.TXT_名称.Location = New System.Drawing.Point(129, 49)
        Me.TXT_名称.MaxLength = 20
        Me.TXT_名称.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.[Byte]
        Me.TXT_名称.Name = "TXT_名称"
        Me.TXT_名称.Padding = New System.Windows.Forms.Padding(3, 1, 1, 1)
        Me.CTL_Main.SetResizeMode(Me.TXT_名称, GrapeCity.Win.Components.ResizeMode.None)
        Me.GcShortcut1.SetShortcuts(Me.TXT_名称, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_名称.Size = New System.Drawing.Size(178, 19)
        Me.TXT_名称.TabIndex = 1
        '
        'TXT_XID
        '
        ThemeStateStyle3.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle3.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.TXT_XID, ThemeStateStyle3)
        Me.TXT_XID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_XID.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TXT_XID.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_XID.DisabledForeColor = System.Drawing.SystemColors.WindowText
        NumberIntegerPartDisplayField1.GroupSizes = New Integer() {0}
        NumberIntegerPartDisplayField1.MinDigits = 0
        Me.TXT_XID.DisplayFields.AddRange(New GrapeCity.Win.Editors.Fields.NumberDisplayField() {NumberIntegerPartDisplayField1})
        Me.TXT_XID.DropDown.AllowDrop = False
        Me.TXT_XID.Enabled = False
        Me.TXT_XID.Fields.DecimalPart.MaxDigits = 0
        Me.TXT_XID.Fields.IntegerPart.GroupSizes = New Integer() {0}
        Me.TXT_XID.Fields.IntegerPart.MaxDigits = 10
        Me.TXT_XID.Fields.SignPrefix.NegativePattern = ""
        Me.TXT_XID.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_XID.HighlightText = True
        Me.TXT_XID.Location = New System.Drawing.Point(1092, 12)
        Me.TXT_XID.MaxMinBehavior = GrapeCity.Win.Editors.MaxMinBehavior.Keep
        Me.TXT_XID.MaxValue = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.TXT_XID.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TXT_XID.Name = "TXT_XID"
        Me.TXT_XID.Padding = New System.Windows.Forms.Padding(1, 1, 3, 1)
        Me.CTL_Main.SetResizeMode(Me.TXT_XID, GrapeCity.Win.Components.ResizeMode.None)
        Me.GcShortcut1.SetShortcuts(Me.TXT_XID, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_XID.Size = New System.Drawing.Size(88, 19)
        Me.TXT_XID.Spin.AllowSpin = False
        Me.TXT_XID.Spin.Increment = 0
        Me.TXT_XID.Spin.SpinOnKeys = False
        Me.TXT_XID.Spin.SpinOnWheel = False
        Me.TXT_XID.Spin.Wrap = False
        Me.TXT_XID.TabIndex = 3
        Me.TXT_XID.TabStop = False
        Me.TXT_XID.Value = Nothing
        '
        'TXT_業務分類区分
        '
        ThemeStateStyle4.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle4.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.TXT_業務分類区分, ThemeStateStyle4)
        Me.TXT_業務分類区分.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_業務分類区分.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TXT_業務分類区分.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_業務分類区分.DisabledForeColor = System.Drawing.SystemColors.WindowText
        NumberIntegerPartDisplayField2.GroupSizes = New Integer() {0}
        Me.TXT_業務分類区分.DisplayFields.AddRange(New GrapeCity.Win.Editors.Fields.NumberDisplayField() {NumberIntegerPartDisplayField2})
        Me.TXT_業務分類区分.DropDown.AllowDrop = False
        Me.TXT_業務分類区分.Fields.DecimalPart.MaxDigits = 0
        Me.TXT_業務分類区分.Fields.IntegerPart.GroupSizes = New Integer() {0}
        Me.TXT_業務分類区分.Fields.IntegerPart.MaxDigits = 2
        Me.TXT_業務分類区分.Fields.IntegerPart.MinDigits = 1
        Me.TXT_業務分類区分.Fields.SignPrefix.NegativePattern = ""
        Me.TXT_業務分類区分.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_業務分類区分.HighlightText = True
        Me.TXT_業務分類区分.Location = New System.Drawing.Point(129, 12)
        Me.TXT_業務分類区分.MaxMinBehavior = GrapeCity.Win.Editors.MaxMinBehavior.Keep
        Me.TXT_業務分類区分.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.TXT_業務分類区分.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TXT_業務分類区分.Name = "TXT_業務分類区分"
        Me.TXT_業務分類区分.Padding = New System.Windows.Forms.Padding(1, 1, 3, 1)
        Me.CTL_Main.SetResizeMode(Me.TXT_業務分類区分, GrapeCity.Win.Components.ResizeMode.None)
        Me.GcShortcut1.SetShortcuts(Me.TXT_業務分類区分, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_業務分類区分.Size = New System.Drawing.Size(34, 19)
        Me.TXT_業務分類区分.Spin.AllowSpin = False
        Me.TXT_業務分類区分.Spin.Increment = 0
        Me.TXT_業務分類区分.Spin.SpinOnKeys = False
        Me.TXT_業務分類区分.Spin.SpinOnWheel = False
        Me.TXT_業務分類区分.Spin.Wrap = False
        Me.TXT_業務分類区分.TabIndex = 0
        Me.TXT_業務分類区分.Value = Nothing
        '
        'STT_Status
        '
        Me.STT_Status.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.STT_Msg})
        Me.STT_Status.Location = New System.Drawing.Point(0, 863)
        Me.STT_Status.Name = "STT_Status"
        Me.STT_Status.Size = New System.Drawing.Size(1400, 22)
        Me.STT_Status.SizingGrip = False
        Me.STT_Status.TabIndex = 45
        Me.STT_Status.Text = "StatusStrip1"
        '
        'STT_Msg
        '
        Me.STT_Msg.Font = New System.Drawing.Font("Yu Gothic UI", 9.5!)
        Me.STT_Msg.Image = CType(resources.GetObject("STT_Msg.Image"), System.Drawing.Image)
        Me.STT_Msg.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.STT_Msg.Name = "STT_Msg"
        Me.STT_Msg.Size = New System.Drawing.Size(164, 17)
        Me.STT_Msg.Text = "ここにメッセージを表示します"
        Me.STT_Msg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'FNC_KEY
        '
        Me.FNC_KEY.KeySets.Remove("Default")
        Me.FNC_KEY.KeySets.Add("Initial", New GrapeCity.Win.Bars.KeySet(New GrapeCity.Win.Bars.KeyItem() {New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 0, True, System.Drawing.Color.Empty, -1, "新規", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 1, True, System.Drawing.Color.Empty, -1, "修正", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 2, True, System.Drawing.Color.Empty, -1, "削除", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 3, True, System.Drawing.Color.Empty, -1, "項目参照", "カーソルのある項目の参照画面を表示します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 4, True, System.Drawing.Color.Empty, -1, "<<", "先頭データへ移動します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 5, True, System.Drawing.Color.Empty, -1, "<", "表示しているデータの前データへ移動します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 6, True, System.Drawing.Color.Empty, -1, ">", "表示しているデータの後データへ移動します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 7, True, System.Drawing.Color.Empty, -1, ">>", "最終データへ移動します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 8, True, System.Drawing.Color.Empty, -1, "登録", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 9, True, System.Drawing.Color.Empty, -1, "検索", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 10, True, System.Drawing.Color.Empty, -1, "出力", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 11, True, System.Drawing.Color.Empty, -1, "閉じる", "画面を閉じます"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 12, True, System.Drawing.Color.Empty, -1, "Home", "Home"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 13, True, System.Drawing.Color.Empty, -1, "End", "End"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 14, True, System.Drawing.Color.Empty, -1, "Page Up", "Page Up"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 15, True, System.Drawing.Color.Empty, -1, "Page Down", "Page Down")}))
        Me.FNC_KEY.StyleSets.Add("XPThemeStyleSet1", New GrapeCity.Win.Bars.XPThemeStyleSet(GrapeCity.Win.Bars.AlignHorizontal.Center, GrapeCity.Win.Bars.AlignVertical.Middle, System.Drawing.SystemColors.Control, New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte)), System.Drawing.SystemColors.ControlText, GrapeCity.Win.Bars.ImagePosition.Left, 2, New GrapeCity.Win.Common.Margins(1, 0, 1, 1), GrapeCity.Win.Common.TextEffect.Flat, True, New GrapeCity.Win.Common.Bevel(System.Drawing.SystemColors.Control, 0, 25, -25), System.Windows.Forms.BorderStyle.None))
        Me.FNC_KEY.ActiveKeySet = "Initial"
        Me.FNC_KEY.ActiveStyleSet = "XPThemeStyleSet1"
        Me.FNC_KEY.ColumnGroups = "4|4|4"
        Me.FNC_KEY.GroupSpacing = 9
        Me.FNC_KEY.Location = New System.Drawing.Point(0, 827)
        Me.FNC_KEY.Margin = New System.Windows.Forms.Padding(0)
        Me.FNC_KEY.Margins = New GrapeCity.Win.Common.Margins(0, 0, 0, 1)
        Me.FNC_KEY.Name = "FNC_KEY"
        Me.FNC_KEY.Size = New System.Drawing.Size(1400, 36)
        Me.FNC_KEY.TabIndex = 46
        Me.FNC_KEY.TabStop = False
        '
        'CTL_UPD
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
        Me.CTL_UPD.Columns.AddRange(New GrapeCity.Win.Containers.TableColumn() {Me.c1, Me.CEL_登録情報, Me.CEL_登録ユーザー情報, Me.CEL_登録日時, Me.c2, Me.CEL_更新情報, Me.CEL_更新ユーザー情報, Me.CEL_更新日時, Me.c3})
        Me.CTL_UPD.Rows.AddRange(New GrapeCity.Win.Containers.TableRow() {Me.ROW_S02, Me.ROW_S03})
        Me.CTL_UPD.CellInfos.AddRange(New GrapeCity.Win.Containers.CellInfo() {New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(2, 0), System.Drawing.Color.Ivory, Border1, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(3, 0), System.Drawing.Color.Ivory, Border2, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(6, 0), System.Drawing.Color.Ivory, Border3, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(7, 0), System.Drawing.Color.Ivory, Border4, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(8, 0), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(5, 0), System.Drawing.SystemColors.ControlLight, Border5, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(1, 0), System.Drawing.SystemColors.ControlLight, Border6, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(0, 1), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(1, 1), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(2, 1), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(3, 1), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(4, 1), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(5, 1), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(6, 1), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(7, 1), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(8, 1), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0))})
        Me.CTL_UPD.Controls.Add(Me.LBL_更新ユーザー情報, 6, 0)
        Me.CTL_UPD.Controls.Add(Me.LBL_更新日時, 7, 0)
        Me.CTL_UPD.Controls.Add(Me.LBL_登録ユーザー情報, 2, 0)
        Me.CTL_UPD.Controls.Add(Me.LBL_登録日時, 3, 0)
        Me.CTL_UPD.Controls.Add(Me.LBL_登録情報, 1, 0)
        Me.CTL_UPD.Controls.Add(Me.LBL_更新情報, 5, 0)
        Me.CTL_UPD.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CTL_UPD.Location = New System.Drawing.Point(0, 791)
        Me.CTL_UPD.Name = "CTL_UPD"
        Me.CTL_UPD.Size = New System.Drawing.Size(1400, 36)
        Me.CTL_UPD.TabIndex = 47
        '
        'c1
        '
        Me.c1.Width = 4.0!
        '
        'CEL_登録情報
        '
        Me.CEL_登録情報.Width = 5.5!
        '
        'CEL_登録ユーザー情報
        '
        Me.CEL_登録ユーザー情報.Width = 30.0!
        '
        'CEL_登録日時
        '
        Me.CEL_登録日時.Width = 10.0!
        '
        'c2
        '
        Me.c2.Width = 1.0!
        '
        'CEL_更新情報
        '
        Me.CEL_更新情報.Width = 5.5!
        '
        'CEL_更新ユーザー情報
        '
        Me.CEL_更新ユーザー情報.Width = 30.0!
        '
        'CEL_更新日時
        '
        Me.CEL_更新日時.Width = 10.0!
        '
        'c3
        '
        Me.c3.Width = 4.0!
        '
        'ROW_S02
        '
        Me.ROW_S02.Height = 55.0!
        '
        'ROW_S03
        '
        Me.ROW_S03.Height = 45.0!
        '
        'LBL_更新ユーザー情報
        '
        Me.LBL_更新ユーザー情報.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_更新ユーザー情報.AutoSize = True
        Me.LBL_更新ユーザー情報.BackColor = System.Drawing.Color.Transparent
        Me.LBL_更新ユーザー情報.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_更新ユーザー情報.Location = New System.Drawing.Point(787, 2)
        Me.LBL_更新ユーザー情報.Name = "LBL_更新ユーザー情報"
        Me.LBL_更新ユーザー情報.Size = New System.Drawing.Size(412, 17)
        Me.LBL_更新ユーザー情報.TabIndex = 5
        Me.LBL_更新ユーザー情報.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_更新ユーザー情報.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_更新日時
        '
        Me.LBL_更新日時.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_更新日時.AutoSize = True
        Me.LBL_更新日時.BackColor = System.Drawing.Color.Transparent
        Me.LBL_更新日時.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_更新日時.Location = New System.Drawing.Point(1206, 2)
        Me.LBL_更新日時.Name = "LBL_更新日時"
        Me.LBL_更新日時.Size = New System.Drawing.Size(132, 17)
        Me.LBL_更新日時.TabIndex = 4
        Me.LBL_更新日時.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_更新日時.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_登録ユーザー情報
        '
        Me.LBL_登録ユーザー情報.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_登録ユーザー情報.AutoSize = True
        Me.LBL_登録ユーザー情報.BackColor = System.Drawing.Color.Transparent
        Me.LBL_登録ユーザー情報.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_登録ユーザー情報.Location = New System.Drawing.Point(138, 2)
        Me.LBL_登録ユーザー情報.Name = "LBL_登録ユーザー情報"
        Me.LBL_登録ユーザー情報.Size = New System.Drawing.Size(411, 17)
        Me.LBL_登録ユーザー情報.TabIndex = 3
        Me.LBL_登録ユーザー情報.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_登録ユーザー情報.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_登録日時
        '
        Me.LBL_登録日時.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_登録日時.AutoSize = True
        Me.LBL_登録日時.BackColor = System.Drawing.Color.Transparent
        Me.LBL_登録日時.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_登録日時.Location = New System.Drawing.Point(556, 2)
        Me.LBL_登録日時.Name = "LBL_登録日時"
        Me.LBL_登録日時.Size = New System.Drawing.Size(133, 17)
        Me.LBL_登録日時.TabIndex = 1
        Me.LBL_登録日時.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_登録日時.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_登録情報
        '
        Me.LBL_登録情報.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_登録情報.AutoSize = True
        Me.LBL_登録情報.BackColor = System.Drawing.Color.Transparent
        Me.LBL_登録情報.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_登録情報.Location = New System.Drawing.Point(61, 2)
        Me.LBL_登録情報.Name = "LBL_登録情報"
        Me.LBL_登録情報.Padding = New System.Windows.Forms.Padding(0, 1, 0, 0)
        Me.LBL_登録情報.Size = New System.Drawing.Size(70, 17)
        Me.LBL_登録情報.TabIndex = 0
        Me.LBL_登録情報.Text = "登録情報"
        Me.LBL_登録情報.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_登録情報.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_更新情報
        '
        Me.LBL_更新情報.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBL_更新情報.AutoSize = True
        Me.LBL_更新情報.BackColor = System.Drawing.Color.Transparent
        Me.LBL_更新情報.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.LBL_更新情報.Location = New System.Drawing.Point(710, 2)
        Me.LBL_更新情報.Name = "LBL_更新情報"
        Me.LBL_更新情報.Size = New System.Drawing.Size(70, 17)
        Me.LBL_更新情報.TabIndex = 2
        Me.LBL_更新情報.Text = "更新情報"
        Me.LBL_更新情報.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_更新情報.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'CTL_Main
        '
        Me.CTL_Main.Controls.Add(Me.TXT_略称)
        Me.CTL_Main.Controls.Add(Me.LBL_略称)
        Me.CTL_Main.Controls.Add(Me.TXT_名称)
        Me.CTL_Main.Controls.Add(Me.LBL_名称)
        Me.CTL_Main.Controls.Add(Me.TXT_XID)
        Me.CTL_Main.Controls.Add(Me.TXT_業務分類区分)
        Me.CTL_Main.Controls.Add(Me.LBL_XID)
        Me.CTL_Main.Controls.Add(Me.LBL_ブランク)
        Me.CTL_Main.Controls.Add(Me.LBL_業務分類区分)
        Me.CTL_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CTL_Main.Location = New System.Drawing.Point(0, 20)
        Me.CTL_Main.Margin = New System.Windows.Forms.Padding(0)
        Me.CTL_Main.Name = "CTL_Main"
        Me.CTL_Main.ResizeMode = GrapeCity.Win.Components.ResizeMode.None
        Me.CTL_Main.Size = New System.Drawing.Size(1400, 771)
        Me.CTL_Main.TabIndex = 48
        '
        'LBL_略称
        '
        Me.LBL_略称.BackColor = System.Drawing.Color.Transparent
        Me.LBL_略称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_略称.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_略称.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_略称.Location = New System.Drawing.Point(20, 67)
        Me.LBL_略称.Name = "LBL_略称"
        Me.LBL_略称.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.CTL_Main.SetResizeMode(Me.LBL_略称, GrapeCity.Win.Components.ResizeMode.None)
        Me.LBL_略称.Size = New System.Drawing.Size(1161, 20)
        Me.LBL_略称.TabIndex = 38
        Me.LBL_略称.Text = "略称"
        Me.LBL_略称.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_略称.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_名称
        '
        Me.LBL_名称.BackColor = System.Drawing.Color.Transparent
        Me.LBL_名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_名称.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_名称.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_名称.Location = New System.Drawing.Point(20, 49)
        Me.LBL_名称.Name = "LBL_名称"
        Me.LBL_名称.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.CTL_Main.SetResizeMode(Me.LBL_名称, GrapeCity.Win.Components.ResizeMode.None)
        Me.LBL_名称.Size = New System.Drawing.Size(1161, 20)
        Me.LBL_名称.TabIndex = 36
        Me.LBL_名称.Text = "名称"
        Me.LBL_名称.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_名称.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_XID
        '
        Me.LBL_XID.BackColor = System.Drawing.Color.Transparent
        Me.LBL_XID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_XID.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_XID.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_XID.Location = New System.Drawing.Point(1039, 12)
        Me.LBL_XID.Name = "LBL_XID"
        Me.LBL_XID.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.CTL_Main.SetResizeMode(Me.LBL_XID, GrapeCity.Win.Components.ResizeMode.None)
        Me.LBL_XID.Size = New System.Drawing.Size(54, 20)
        Me.LBL_XID.TabIndex = 33
        Me.LBL_XID.Text = "XID"
        Me.LBL_XID.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_XID.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_ブランク
        '
        Me.LBL_ブランク.BackColor = System.Drawing.Color.Transparent
        Me.LBL_ブランク.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_ブランク.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_ブランク.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_ブランク.Location = New System.Drawing.Point(20, 30)
        Me.LBL_ブランク.Name = "LBL_ブランク"
        Me.LBL_ブランク.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.CTL_Main.SetResizeMode(Me.LBL_ブランク, GrapeCity.Win.Components.ResizeMode.None)
        Me.LBL_ブランク.Size = New System.Drawing.Size(1161, 20)
        Me.LBL_ブランク.TabIndex = 35
        Me.LBL_ブランク.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_ブランク.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_業務分類区分
        '
        Me.LBL_業務分類区分.BackColor = System.Drawing.Color.Transparent
        Me.LBL_業務分類区分.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_業務分類区分.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_業務分類区分.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_業務分類区分.Location = New System.Drawing.Point(20, 12)
        Me.LBL_業務分類区分.Name = "LBL_業務分類区分"
        Me.LBL_業務分類区分.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.CTL_Main.SetResizeMode(Me.LBL_業務分類区分, GrapeCity.Win.Components.ResizeMode.None)
        Me.LBL_業務分類区分.Size = New System.Drawing.Size(1039, 20)
        Me.LBL_業務分類区分.TabIndex = 27
        Me.LBL_業務分類区分.Text = "業務分類区分"
        Me.LBL_業務分類区分.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_業務分類区分.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'frm_M002_ins
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1400, 885)
        Me.Controls.Add(Me.CTL_Main)
        Me.Controls.Add(Me.CTL_UPD)
        Me.Controls.Add(Me.FNC_KEY)
        Me.Controls.Add(Me.STT_Status)
        Me.Controls.Add(Me.PNL_USR_IFO1)
        Me.Name = "frm_M002_ins"
        Me.Text = "業務分類区分マスタ / M002 / 《Dev》 Ver 00000.00"
        CType(Me.PNL_USR_IFO1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_USR_IFO1.ResumeLayout(False)
        CType(Me.CTL_USR_IFO1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTL_USR_IFO1.ResumeLayout(False)
        Me.CTL_USR_IFO1.PerformLayout()
        CType(Me.TXT_略称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_XID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_業務分類区分, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STT_Status.ResumeLayout(False)
        Me.STT_Status.PerformLayout()
        CType(Me.CTL_UPD, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTL_UPD.ResumeLayout(False)
        Me.CTL_UPD.PerformLayout()
        CType(Me.CTL_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTL_Main.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PNL_USR_IFO1 As GrapeCity.Win.Containers.GcResizePanel
    Friend WithEvents CTL_USR_IFO1 As GrapeCity.Win.Containers.GcTableLayoutContainer
    Friend WithEvents CEL_事業所 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_支社 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_部 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_その他 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents LBL_処理事業所 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents ROW_S01 As GrapeCity.Win.Containers.TableRow
    Friend WithEvents s2 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s3 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_処理モード As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s1 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s4 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s5 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents LBL_支社 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_部 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_MOD As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents GcShortcut1 As GrapeCity.Win.Editors.GcShortcut
    Friend WithEvents GcStylePlus1 As GrapeCity.Win.Components.GcStylePlus
    Friend WithEvents STT_Status As StatusStrip
    Friend WithEvents FNC_KEY As GrapeCity.Win.Bars.GcClassicFunctionKey
    Friend WithEvents CTL_UPD As GrapeCity.Win.Containers.GcTableLayoutContainer
    Friend WithEvents c1 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_登録情報 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_登録ユーザー情報 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_登録日時 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents c2 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_更新情報 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_更新ユーザー情報 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_更新日時 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents c3 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents LBL_更新ユーザー情報 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_更新日時 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_登録ユーザー情報 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_登録日時 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_登録情報 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_更新情報 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents ROW_S02 As GrapeCity.Win.Containers.TableRow
    Friend WithEvents ROW_S03 As GrapeCity.Win.Containers.TableRow
    Friend WithEvents CTL_Main As GrapeCity.Win.Containers.GcResizePanel
    Friend WithEvents TXT_略称 As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents LBL_略称 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents TXT_名称 As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents LBL_名称 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents TXT_XID As GrapeCity.Win.Editors.GcNumber
    Friend WithEvents TXT_業務分類区分 As GrapeCity.Win.Editors.GcNumber
    Friend WithEvents LBL_XID As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_ブランク As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_業務分類区分 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents STT_Msg As ToolStripStatusLabel
End Class
