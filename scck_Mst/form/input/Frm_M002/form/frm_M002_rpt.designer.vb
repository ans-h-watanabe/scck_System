Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_M002_rpt
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
        Dim RoundedBorder6 As GrapeCity.Win.Containers.RoundedBorder = New GrapeCity.Win.Containers.RoundedBorder()
        Dim RoundedBorder7 As GrapeCity.Win.Containers.RoundedBorder = New GrapeCity.Win.Containers.RoundedBorder()
        Dim RoundedBorder8 As GrapeCity.Win.Containers.RoundedBorder = New GrapeCity.Win.Containers.RoundedBorder()
        Dim RoundedBorder9 As GrapeCity.Win.Containers.RoundedBorder = New GrapeCity.Win.Containers.RoundedBorder()
        Dim RoundedBorder10 As GrapeCity.Win.Containers.RoundedBorder = New GrapeCity.Win.Containers.RoundedBorder()
        Dim ThemeStateStyle6 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim ThemeStateStyle7 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim NumberIntegerPartDisplayField4 As GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField = New GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField()
        Dim ThemeStateStyle8 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim NumberIntegerPartDisplayField5 As GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField = New GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField()
        Dim ThemeStateStyle9 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim ThemeStateStyle10 As GrapeCity.Win.Components.ThemeStateStyle = New GrapeCity.Win.Components.ThemeStateStyle()
        Dim NumberIntegerPartDisplayField6 As GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField = New GrapeCity.Win.Editors.Fields.NumberIntegerPartDisplayField()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_M002_rpt))
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
        Me.TXT_名称 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.TXT_業務分類区分_TO = New GrapeCity.Win.Editors.GcNumber(Me.components)
        Me.TXT_業務分類区分_FROM = New GrapeCity.Win.Editors.GcNumber(Me.components)
        Me.TXT_帳票コード = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.TXT_出力先 = New GrapeCity.Win.Editors.GcNumber(Me.components)
        Me.TXT_LOG = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.TXT_HIS1 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.TXT_HIS2 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.TXT_HIS3 = New GrapeCity.Win.Editors.GcTextBox(Me.components)
        Me.GcStylePlus1 = New GrapeCity.Win.Components.GcStylePlus()
        Me.STT_Status = New System.Windows.Forms.StatusStrip()
        Me.STT_Msg = New System.Windows.Forms.ToolStripStatusLabel()
        Me.FNC_KEY = New GrapeCity.Win.Bars.GcClassicFunctionKey()
        Me.CTL_Main = New GrapeCity.Win.Containers.GcResizePanel()
        Me.CON_Main = New GrapeCity.Win.Containers.GcContainer()
        Me.CON_Status = New GrapeCity.Win.Containers.GcContainer()
        Me.TAB_Message = New GrapeCity.Win.Containers.GcTabControl()
        Me.TAB_Status = New GrapeCity.Win.Containers.GcTabPage()
        Me.LBL_ステータス = New GrapeCity.Win.Buttons.GcLabel()
        Me.TAB_History1 = New GrapeCity.Win.Containers.GcTabPage()
        Me.TAB_History2 = New GrapeCity.Win.Containers.GcTabPage()
        Me.TAB_History3 = New GrapeCity.Win.Containers.GcTabPage()
        Me.CON_出力設定 = New GrapeCity.Win.Containers.GcHeadingContainer()
        Me.DSP_設置支社 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_設置支社 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_IPアドレス = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_用紙属性 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_プリンター名 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_帳票コード = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_出力先 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_出力先情報 = New GrapeCity.Win.Buttons.GcLabel()
        Me.DSP_帳票名 = New GrapeCity.Win.Buttons.GcLabel()
        Me.DSP_プリンター名 = New GrapeCity.Win.Buttons.GcLabel()
        Me.DSP_用紙属性 = New GrapeCity.Win.Buttons.GcLabel()
        Me.DSP_IPアドレス = New GrapeCity.Win.Buttons.GcLabel()
        Me.CON_Heading = New GrapeCity.Win.Containers.GcHeadingContainer()
        Me.LBL_名称 = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_業務分類区分_FROM = New GrapeCity.Win.Buttons.GcLabel()
        Me.LBL_業務分類区分 = New GrapeCity.Win.Buttons.GcLabel()
        CType(Me.PNL_USR_IFO1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PNL_USR_IFO1.SuspendLayout()
        CType(Me.CTL_USR_IFO1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTL_USR_IFO1.SuspendLayout()
        CType(Me.TXT_名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_業務分類区分_TO, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_業務分類区分_FROM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_帳票コード, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_出力先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_LOG, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_HIS1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_HIS2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_HIS3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.STT_Status.SuspendLayout()
        CType(Me.CTL_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CTL_Main.SuspendLayout()
        Me.CON_Main.SuspendLayout()
        Me.CON_Status.SuspendLayout()
        CType(Me.TAB_Message, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TAB_Message.SuspendLayout()
        Me.TAB_Status.SuspendLayout()
        Me.TAB_History1.SuspendLayout()
        Me.TAB_History2.SuspendLayout()
        Me.TAB_History3.SuspendLayout()
        Me.CON_出力設定.Panel.SuspendLayout()
        Me.CON_出力設定.SuspendLayout()
        Me.CON_Heading.Panel.SuspendLayout()
        Me.CON_Heading.SuspendLayout()
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
        RoundedBorder6.AllCornerRadius = 0.1!
        RoundedBorder6.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder6.BottomLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder6.BottomRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder6.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder6.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder6.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder6.TopLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder6.TopRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder7.AllCornerRadius = 0.1!
        RoundedBorder7.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder7.BottomLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder7.BottomRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder7.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder7.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder7.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder7.TopLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder7.TopRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder8.AllCornerRadius = 0.1!
        RoundedBorder8.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder8.BottomLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder8.BottomRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder8.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder8.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder8.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder8.TopLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder8.TopRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder9.AllCornerRadius = 0.1!
        RoundedBorder9.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder9.BottomLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder9.BottomRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder9.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder9.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder9.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder9.TopLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder9.TopRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder10.AllCornerRadius = 0.1!
        RoundedBorder10.Bottom = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder10.BottomLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder10.BottomRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder10.Left = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder10.Right = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder10.Top = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder10.TopLeftCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        RoundedBorder10.TopRightCornerLine = New GrapeCity.Win.Containers.Line(GrapeCity.Win.Containers.LineStyle.Thin, System.Drawing.Color.DarkGray)
        Me.CTL_USR_IFO1.Columns.AddRange(New GrapeCity.Win.Containers.TableColumn() {Me.s1, Me.CEL_事業所, Me.s2, Me.CEL_支社, Me.s3, Me.CEL_部, Me.s4, Me.CEL_その他, Me.s5, Me.CEL_処理モード})
        Me.CTL_USR_IFO1.Rows.AddRange(New GrapeCity.Win.Containers.TableRow() {Me.ROW_S01})
        Me.CTL_USR_IFO1.CellInfos.AddRange(New GrapeCity.Win.Containers.CellInfo() {New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(2, 0), System.Drawing.Color.Empty, Nothing, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(9, 0), System.Drawing.Color.Empty, RoundedBorder6, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(7, 0), System.Drawing.Color.Empty, RoundedBorder7, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(5, 0), System.Drawing.Color.Empty, RoundedBorder8, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(3, 0), System.Drawing.Color.Empty, RoundedBorder9, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0)), New GrapeCity.Win.Containers.CellInfo(New GrapeCity.Win.Containers.CellPosition(1, 0), System.Drawing.Color.Empty, RoundedBorder10, Nothing, Nothing, Nothing, System.Windows.Forms.ImageLayout.Tile, New GrapeCity.Win.Common.Bevel(System.Drawing.Color.Empty, 0, 0, 0))})
        Me.CTL_USR_IFO1.Controls.Add(Me.LBL_MOD, 9, 0)
        Me.CTL_USR_IFO1.Controls.Add(Me.LBL_部, 5, 0)
        Me.CTL_USR_IFO1.Controls.Add(Me.LBL_支社, 3, 0)
        Me.CTL_USR_IFO1.Controls.Add(Me.LBL_処理事業所, 1, 0)
        Me.CTL_USR_IFO1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CTL_USR_IFO1.Location = New System.Drawing.Point(0, 0)
        Me.CTL_USR_IFO1.Name = "CTL_USR_IFO1"
        Me.CTL_USR_IFO1.Size = New System.Drawing.Size(1400, 20)
        Me.CTL_USR_IFO1.TabIndex = 3
        '
        's1
        '
        Me.s1.Width = 0.15!
        '
        'CEL_事業所
        '
        Me.CEL_事業所.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CEL_事業所.Width = 20.0!
        '
        's2
        '
        Me.s2.Width = 0.2!
        '
        'CEL_支社
        '
        Me.CEL_支社.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CEL_支社.Width = 20.0!
        '
        's3
        '
        Me.s3.Width = 0.2!
        '
        'CEL_部
        '
        Me.CEL_部.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.CEL_部.Width = 20.0!
        '
        's4
        '
        Me.s4.Width = 0.2!
        '
        'CEL_その他
        '
        Me.CEL_その他.BackColor = System.Drawing.SystemColors.ControlLight
        Me.CEL_その他.Width = 19.05!
        '
        's5
        '
        Me.s5.Width = 0.2!
        '
        'CEL_処理モード
        '
        Me.CEL_処理モード.BackColor = System.Drawing.Color.Transparent
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
        Me.LBL_処理事業所.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_処理事業所.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'TXT_名称
        '
        ThemeStateStyle6.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle6.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.TXT_名称, ThemeStateStyle6)
        Me.TXT_名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_名称.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.TXT_名称.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_名称.DisabledForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_名称.DropDown.AllowDrop = False
        Me.TXT_名称.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_名称.HighlightText = True
        Me.TXT_名称.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.TXT_名称.Location = New System.Drawing.Point(109, 19)
        Me.TXT_名称.MaxLength = 20
        Me.TXT_名称.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.[Byte]
        Me.TXT_名称.Name = "TXT_名称"
        Me.TXT_名称.Padding = New System.Windows.Forms.Padding(3, 1, 1, 1)
        Me.GcShortcut1.SetShortcuts(Me.TXT_名称, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_名称.Size = New System.Drawing.Size(178, 19)
        Me.TXT_名称.TabIndex = 2
        '
        'TXT_業務分類区分_TO
        '
        ThemeStateStyle7.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle7.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.TXT_業務分類区分_TO, ThemeStateStyle7)
        Me.TXT_業務分類区分_TO.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_業務分類区分_TO.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TXT_業務分類区分_TO.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_業務分類区分_TO.DisabledForeColor = System.Drawing.SystemColors.WindowText
        NumberIntegerPartDisplayField4.GroupSizes = New Integer() {0}
        Me.TXT_業務分類区分_TO.DisplayFields.AddRange(New GrapeCity.Win.Editors.Fields.NumberDisplayField() {NumberIntegerPartDisplayField4})
        Me.TXT_業務分類区分_TO.DropDown.AllowDrop = False
        Me.TXT_業務分類区分_TO.Fields.DecimalPart.MaxDigits = 0
        Me.TXT_業務分類区分_TO.Fields.IntegerPart.GroupSizes = New Integer() {0}
        Me.TXT_業務分類区分_TO.Fields.IntegerPart.MaxDigits = 2
        Me.TXT_業務分類区分_TO.Fields.IntegerPart.MinDigits = 1
        Me.TXT_業務分類区分_TO.Fields.SignPrefix.NegativePattern = ""
        Me.TXT_業務分類区分_TO.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_業務分類区分_TO.HighlightText = True
        Me.TXT_業務分類区分_TO.Location = New System.Drawing.Point(163, 1)
        Me.TXT_業務分類区分_TO.MaxMinBehavior = GrapeCity.Win.Editors.MaxMinBehavior.Keep
        Me.TXT_業務分類区分_TO.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.TXT_業務分類区分_TO.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TXT_業務分類区分_TO.Name = "TXT_業務分類区分_TO"
        Me.TXT_業務分類区分_TO.Padding = New System.Windows.Forms.Padding(1, 1, 3, 1)
        Me.GcShortcut1.SetShortcuts(Me.TXT_業務分類区分_TO, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_業務分類区分_TO.Size = New System.Drawing.Size(34, 19)
        Me.TXT_業務分類区分_TO.Spin.AllowSpin = False
        Me.TXT_業務分類区分_TO.Spin.Increment = 0
        Me.TXT_業務分類区分_TO.Spin.SpinOnKeys = False
        Me.TXT_業務分類区分_TO.Spin.SpinOnWheel = False
        Me.TXT_業務分類区分_TO.Spin.Wrap = False
        Me.TXT_業務分類区分_TO.TabIndex = 1
        Me.TXT_業務分類区分_TO.Value = New Decimal(New Integer() {99, 0, 0, 0})
        '
        'TXT_業務分類区分_FROM
        '
        ThemeStateStyle8.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle8.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.TXT_業務分類区分_FROM, ThemeStateStyle8)
        Me.TXT_業務分類区分_FROM.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_業務分類区分_FROM.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TXT_業務分類区分_FROM.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_業務分類区分_FROM.DisabledForeColor = System.Drawing.SystemColors.WindowText
        NumberIntegerPartDisplayField5.GroupSizes = New Integer() {0}
        Me.TXT_業務分類区分_FROM.DisplayFields.AddRange(New GrapeCity.Win.Editors.Fields.NumberDisplayField() {NumberIntegerPartDisplayField5})
        Me.TXT_業務分類区分_FROM.DropDown.AllowDrop = False
        Me.TXT_業務分類区分_FROM.Fields.DecimalPart.MaxDigits = 0
        Me.TXT_業務分類区分_FROM.Fields.IntegerPart.GroupSizes = New Integer() {0}
        Me.TXT_業務分類区分_FROM.Fields.IntegerPart.MaxDigits = 2
        Me.TXT_業務分類区分_FROM.Fields.IntegerPart.MinDigits = 1
        Me.TXT_業務分類区分_FROM.Fields.SignPrefix.NegativePattern = ""
        Me.TXT_業務分類区分_FROM.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_業務分類区分_FROM.HighlightText = True
        Me.TXT_業務分類区分_FROM.Location = New System.Drawing.Point(109, 1)
        Me.TXT_業務分類区分_FROM.MaxMinBehavior = GrapeCity.Win.Editors.MaxMinBehavior.Keep
        Me.TXT_業務分類区分_FROM.MaxValue = New Decimal(New Integer() {99, 0, 0, 0})
        Me.TXT_業務分類区分_FROM.MinValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.TXT_業務分類区分_FROM.Name = "TXT_業務分類区分_FROM"
        Me.TXT_業務分類区分_FROM.Padding = New System.Windows.Forms.Padding(1, 1, 3, 1)
        Me.GcShortcut1.SetShortcuts(Me.TXT_業務分類区分_FROM, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_業務分類区分_FROM.Size = New System.Drawing.Size(34, 19)
        Me.TXT_業務分類区分_FROM.Spin.AllowSpin = False
        Me.TXT_業務分類区分_FROM.Spin.Increment = 0
        Me.TXT_業務分類区分_FROM.Spin.SpinOnKeys = False
        Me.TXT_業務分類区分_FROM.Spin.SpinOnWheel = False
        Me.TXT_業務分類区分_FROM.Spin.Wrap = False
        Me.TXT_業務分類区分_FROM.TabIndex = 0
        '
        'TXT_帳票コード
        '
        ThemeStateStyle9.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle9.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.TXT_帳票コード, ThemeStateStyle9)
        Me.TXT_帳票コード.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_帳票コード.ContentAlignment = System.Drawing.ContentAlignment.MiddleLeft
        Me.TXT_帳票コード.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_帳票コード.DisabledForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_帳票コード.DropDown.AllowDrop = False
        Me.TXT_帳票コード.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_帳票コード.HighlightText = True
        Me.TXT_帳票コード.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TXT_帳票コード.Location = New System.Drawing.Point(169, 19)
        Me.TXT_帳票コード.MaxLength = 20
        Me.TXT_帳票コード.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.[Byte]
        Me.TXT_帳票コード.Name = "TXT_帳票コード"
        Me.TXT_帳票コード.Padding = New System.Windows.Forms.Padding(3, 1, 1, 1)
        Me.GcShortcut1.SetShortcuts(Me.TXT_帳票コード, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_帳票コード.Size = New System.Drawing.Size(158, 19)
        Me.TXT_帳票コード.TabIndex = 1
        '
        'TXT_出力先
        '
        ThemeStateStyle10.BackColor = System.Drawing.Color.LightCyan
        ThemeStateStyle10.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.GcStylePlus1.SetActiveStyle(Me.TXT_出力先, ThemeStateStyle10)
        Me.TXT_出力先.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TXT_出力先.ContentAlignment = System.Drawing.ContentAlignment.MiddleRight
        Me.TXT_出力先.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_出力先.DisabledForeColor = System.Drawing.SystemColors.WindowText
        NumberIntegerPartDisplayField6.GroupSizes = New Integer() {0}
        Me.TXT_出力先.DisplayFields.AddRange(New GrapeCity.Win.Editors.Fields.NumberDisplayField() {NumberIntegerPartDisplayField6})
        Me.TXT_出力先.DropDown.AllowDrop = False
        Me.TXT_出力先.Fields.DecimalPart.MaxDigits = 0
        Me.TXT_出力先.Fields.IntegerPart.GroupSizes = New Integer() {0}
        Me.TXT_出力先.Fields.IntegerPart.MaxDigits = 1
        Me.TXT_出力先.Fields.IntegerPart.MinDigits = 1
        Me.TXT_出力先.Fields.SignPrefix.NegativePattern = ""
        Me.TXT_出力先.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_出力先.HighlightText = True
        Me.TXT_出力先.Location = New System.Drawing.Point(169, 1)
        Me.TXT_出力先.MaxMinBehavior = GrapeCity.Win.Editors.MaxMinBehavior.Keep
        Me.TXT_出力先.MaxValue = New Decimal(New Integer() {4, 0, 0, 0})
        Me.TXT_出力先.MinValue = New Decimal(New Integer() {1, 0, 0, 0})
        Me.TXT_出力先.Name = "TXT_出力先"
        Me.TXT_出力先.Padding = New System.Windows.Forms.Padding(1, 1, 3, 1)
        Me.GcShortcut1.SetShortcuts(Me.TXT_出力先, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_出力先.Size = New System.Drawing.Size(28, 19)
        Me.TXT_出力先.Spin.AllowSpin = False
        Me.TXT_出力先.Spin.Increment = 0
        Me.TXT_出力先.Spin.SpinOnKeys = False
        Me.TXT_出力先.Spin.SpinOnWheel = False
        Me.TXT_出力先.Spin.Wrap = False
        Me.TXT_出力先.TabIndex = 0
        '
        'TXT_LOG
        '
        Me.TXT_LOG.BackColor = System.Drawing.Color.Ivory
        Me.TXT_LOG.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_LOG.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_LOG.DisabledForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_LOG.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_LOG.DropDown.AllowDrop = False
        Me.TXT_LOG.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_LOG.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TXT_LOG.Location = New System.Drawing.Point(3, 23)
        Me.TXT_LOG.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.[Byte]
        Me.TXT_LOG.Multiline = True
        Me.TXT_LOG.Name = "TXT_LOG"
        Me.TXT_LOG.Padding = New System.Windows.Forms.Padding(3, 3, 1, 1)
        Me.TXT_LOG.ScrollBarMode = GrapeCity.Win.Editors.ScrollBarMode.Automatic
        Me.TXT_LOG.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GcShortcut1.SetShortcuts(Me.TXT_LOG, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_LOG.Size = New System.Drawing.Size(1344, 565)
        Me.TXT_LOG.TabIndex = 68
        '
        'TXT_HIS1
        '
        Me.TXT_HIS1.BackColor = System.Drawing.SystemColors.Control
        Me.TXT_HIS1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_HIS1.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_HIS1.DisabledForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_HIS1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_HIS1.DropDown.AllowDrop = False
        Me.TXT_HIS1.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_HIS1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TXT_HIS1.Location = New System.Drawing.Point(3, 3)
        Me.TXT_HIS1.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.[Byte]
        Me.TXT_HIS1.Multiline = True
        Me.TXT_HIS1.Name = "TXT_HIS1"
        Me.TXT_HIS1.Padding = New System.Windows.Forms.Padding(3, 3, 1, 1)
        Me.TXT_HIS1.ScrollBarMode = GrapeCity.Win.Editors.ScrollBarMode.Automatic
        Me.TXT_HIS1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GcShortcut1.SetShortcuts(Me.TXT_HIS1, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_HIS1.Size = New System.Drawing.Size(1344, 585)
        Me.TXT_HIS1.TabIndex = 69
        '
        'TXT_HIS2
        '
        Me.TXT_HIS2.BackColor = System.Drawing.SystemColors.Control
        Me.TXT_HIS2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_HIS2.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_HIS2.DisabledForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_HIS2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_HIS2.DropDown.AllowDrop = False
        Me.TXT_HIS2.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_HIS2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TXT_HIS2.Location = New System.Drawing.Point(3, 3)
        Me.TXT_HIS2.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.[Byte]
        Me.TXT_HIS2.Multiline = True
        Me.TXT_HIS2.Name = "TXT_HIS2"
        Me.TXT_HIS2.Padding = New System.Windows.Forms.Padding(3, 3, 1, 1)
        Me.TXT_HIS2.ScrollBarMode = GrapeCity.Win.Editors.ScrollBarMode.Automatic
        Me.TXT_HIS2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GcShortcut1.SetShortcuts(Me.TXT_HIS2, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_HIS2.Size = New System.Drawing.Size(1344, 585)
        Me.TXT_HIS2.TabIndex = 70
        '
        'TXT_HIS3
        '
        Me.TXT_HIS3.BackColor = System.Drawing.SystemColors.Control
        Me.TXT_HIS3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TXT_HIS3.DisabledBackColor = System.Drawing.SystemColors.Info
        Me.TXT_HIS3.DisabledForeColor = System.Drawing.SystemColors.WindowText
        Me.TXT_HIS3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TXT_HIS3.DropDown.AllowDrop = False
        Me.TXT_HIS3.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.TXT_HIS3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.TXT_HIS3.Location = New System.Drawing.Point(3, 3)
        Me.TXT_HIS3.MaxLengthUnit = GrapeCity.Win.Editors.LengthUnit.[Byte]
        Me.TXT_HIS3.Multiline = True
        Me.TXT_HIS3.Name = "TXT_HIS3"
        Me.TXT_HIS3.Padding = New System.Windows.Forms.Padding(3, 3, 1, 1)
        Me.TXT_HIS3.ScrollBarMode = GrapeCity.Win.Editors.ScrollBarMode.Automatic
        Me.TXT_HIS3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GcShortcut1.SetShortcuts(Me.TXT_HIS3, New GrapeCity.Win.Editors.ShortcutCollection(New System.Windows.Forms.Keys() {System.Windows.Forms.Keys.[Return], CType((System.Windows.Forms.Keys.Shift Or System.Windows.Forms.Keys.[Return]), System.Windows.Forms.Keys), System.Windows.Forms.Keys.Up, System.Windows.Forms.Keys.Down}, New Object() {CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object), CType(Me.GcShortcut1, Object)}, New String() {"NextControl", "PreviousControl", "PreviousControl", "NextControl"}))
        Me.TXT_HIS3.Size = New System.Drawing.Size(1344, 585)
        Me.TXT_HIS3.TabIndex = 70
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
        Me.FNC_KEY.KeySets.Add("Initial", New GrapeCity.Win.Bars.KeySet(New GrapeCity.Win.Bars.KeyItem() {New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 0, True, System.Drawing.Color.Empty, -1, "検索条件", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 1, True, System.Drawing.Color.Empty, -1, "出力設定", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 2, True, System.Drawing.Color.Empty, -1, "クリア", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 3, True, System.Drawing.Color.Empty, -1, "項目参照", "カーソルのある項目の参照画面を表示します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 4, False, System.Drawing.Color.Empty, -1, "", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 5, False, System.Drawing.Color.Empty, -1, "", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 6, False, System.Drawing.Color.Empty, -1, "", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 7, False, System.Drawing.Color.Empty, -1, "中断", "処理を中断します"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 8, True, System.Drawing.Color.Empty, -1, "出力", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 9, False, System.Drawing.Color.Empty, -1, "", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 10, False, System.Drawing.Color.Empty, -1, "", ""), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 11, True, System.Drawing.Color.Empty, -1, "戻る", "画面を閉じます"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 12, True, System.Drawing.Color.Empty, -1, "Home", "Home"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 13, True, System.Drawing.Color.Empty, -1, "End", "End"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 14, True, System.Drawing.Color.Empty, -1, "Page Up", "Page Up"), New GrapeCity.Win.Bars.KeyItem(System.Drawing.Color.Empty, 15, True, System.Drawing.Color.Empty, -1, "Page Down", "Page Down")}))
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
        'CTL_Main
        '
        Me.CTL_Main.Controls.Add(Me.CON_Main)
        Me.CTL_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CTL_Main.Location = New System.Drawing.Point(0, 20)
        Me.CTL_Main.Margin = New System.Windows.Forms.Padding(0)
        Me.CTL_Main.Name = "CTL_Main"
        Me.CTL_Main.ResizeMode = GrapeCity.Win.Components.ResizeMode.None
        Me.CTL_Main.Size = New System.Drawing.Size(1400, 807)
        Me.CTL_Main.TabIndex = 48
        '
        'CON_Main
        '
        Me.CON_Main.Controls.Add(Me.CON_Status)
        Me.CON_Main.Controls.Add(Me.CON_出力設定)
        Me.CON_Main.Controls.Add(Me.CON_Heading)
        Me.CON_Main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CON_Main.Location = New System.Drawing.Point(0, 0)
        Me.CON_Main.Name = "CON_Main"
        Me.CON_Main.Padding = New System.Windows.Forms.Padding(20, 10, 20, 10)
        Me.CON_Main.Size = New System.Drawing.Size(1400, 807)
        Me.CON_Main.TabIndex = 55
        '
        'CON_Status
        '
        Me.CON_Status.Controls.Add(Me.TAB_Message)
        Me.CON_Status.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CON_Status.Location = New System.Drawing.Point(20, 68)
        Me.CON_Status.Name = "CON_Status"
        Me.CON_Status.Padding = New System.Windows.Forms.Padding(0, 5, 0, 5)
        Me.CON_Status.Size = New System.Drawing.Size(1360, 633)
        Me.CON_Status.TabIndex = 62
        '
        'TAB_Message
        '
        Me.TAB_Message.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TAB_Message.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.TAB_Message.Location = New System.Drawing.Point(0, 5)
        Me.TAB_Message.Name = "TAB_Message"
        Me.TAB_Message.Size = New System.Drawing.Size(1360, 623)
        Me.TAB_Message.SizeMode = GrapeCity.Win.Containers.TabSizeMode.Fixed
        Me.TAB_Message.TabIndex = 67
        Me.TAB_Message.TabPages.Add(Me.TAB_Status)
        Me.TAB_Message.TabPages.Add(Me.TAB_History1)
        Me.TAB_Message.TabPages.Add(Me.TAB_History2)
        Me.TAB_Message.TabPages.Add(Me.TAB_History3)
        Me.TAB_Message.TabStyle = New GrapeCity.Win.Containers.TabStyle(System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, Nothing, GrapeCity.Win.Common.TextEffect.Flat, GrapeCity.Win.Common.TextHAlign.NotSet, GrapeCity.Win.Common.TextVAlign.NotSet, GrapeCity.Win.Common.ImageAlign.NotSet, GrapeCity.Win.Common.TextWrapMode.NotSet, GrapeCity.Win.Common.EllipsisMode.None, Nothing, Nothing, New GrapeCity.Win.Common.Margins(0, 0, 0, 0), New System.Drawing.Size(115, 22), New System.Drawing.Size(0, 0))
        '
        'TAB_Status
        '
        Me.TAB_Status.BackColor = System.Drawing.Color.Ivory
        Me.TAB_Status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB_Status.Controls.Add(Me.TXT_LOG)
        Me.TAB_Status.Controls.Add(Me.LBL_ステータス)
        Me.TAB_Status.Location = New System.Drawing.Point(4, 26)
        Me.TAB_Status.Name = "TAB_Status"
        Me.TAB_Status.SingleBorderColor = System.Drawing.SystemColors.ScrollBar
        Me.TAB_Status.Size = New System.Drawing.Size(1352, 593)
        Me.TAB_Status.TabIndex = 0
        Me.TAB_Status.Text = "ステータス"
        Me.TAB_Status.UseVisualStyleBackColor = True
        '
        'LBL_ステータス
        '
        Me.LBL_ステータス.BackColor = System.Drawing.Color.Transparent
        Me.LBL_ステータス.Dock = System.Windows.Forms.DockStyle.Top
        Me.LBL_ステータス.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_ステータス.ForeColor = System.Drawing.Color.RoyalBlue
        Me.LBL_ステータス.Location = New System.Drawing.Point(3, 3)
        Me.LBL_ステータス.Name = "LBL_ステータス"
        Me.LBL_ステータス.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_ステータス.Size = New System.Drawing.Size(1344, 20)
        Me.LBL_ステータス.TabIndex = 67
        Me.LBL_ステータス.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_ステータス.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        Me.LBL_ステータス.Visible = False
        '
        'TAB_History1
        '
        Me.TAB_History1.BackColor = System.Drawing.Color.Transparent
        Me.TAB_History1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB_History1.Controls.Add(Me.TXT_HIS1)
        Me.TAB_History1.Location = New System.Drawing.Point(4, 26)
        Me.TAB_History1.Name = "TAB_History1"
        Me.TAB_History1.SingleBorderColor = System.Drawing.SystemColors.ScrollBar
        Me.TAB_History1.Size = New System.Drawing.Size(1352, 593)
        Me.TAB_History1.TabIndex = 1
        Me.TAB_History1.UseVisualStyleBackColor = True
        Me.TAB_History1.Visible = False
        '
        'TAB_History2
        '
        Me.TAB_History2.BackColor = System.Drawing.Color.Transparent
        Me.TAB_History2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB_History2.Controls.Add(Me.TXT_HIS2)
        Me.TAB_History2.Location = New System.Drawing.Point(4, 26)
        Me.TAB_History2.Name = "TAB_History2"
        Me.TAB_History2.SingleBorderColor = System.Drawing.SystemColors.ScrollBar
        Me.TAB_History2.Size = New System.Drawing.Size(1352, 593)
        Me.TAB_History2.TabIndex = 2
        Me.TAB_History2.UseVisualStyleBackColor = True
        Me.TAB_History2.Visible = False
        '
        'TAB_History3
        '
        Me.TAB_History3.BackColor = System.Drawing.Color.Transparent
        Me.TAB_History3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TAB_History3.Controls.Add(Me.TXT_HIS3)
        Me.TAB_History3.Location = New System.Drawing.Point(4, 26)
        Me.TAB_History3.Name = "TAB_History3"
        Me.TAB_History3.SingleBorderColor = System.Drawing.SystemColors.ScrollBar
        Me.TAB_History3.Size = New System.Drawing.Size(1352, 593)
        Me.TAB_History3.TabIndex = 3
        Me.TAB_History3.UseVisualStyleBackColor = True
        Me.TAB_History3.Visible = False
        '
        'CON_出力設定
        '
        Me.CON_出力設定.Appearance = GrapeCity.Win.Containers.HeadingContainerAppearance.System
        Me.CON_出力設定.DesignSize = New System.Drawing.Size(1360, 96)
        Me.CON_出力設定.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.CON_出力設定.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CON_出力設定.HeaderSettings.Bevel = New GrapeCity.Win.Common.Bevel(System.Drawing.SystemColors.Control, 0, 0, 0)
        Me.CON_出力設定.HeaderSettings.EllipsisMode = GrapeCity.Win.Common.EllipsisMode.None
        Me.CON_出力設定.HeaderSettings.Padding = New System.Windows.Forms.Padding(0, 1, 0, -2)
        Me.CON_出力設定.HeaderSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CON_出力設定.Location = New System.Drawing.Point(20, 701)
        Me.CON_出力設定.Margin = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.CON_出力設定.Name = "CON_出力設定"
        '
        'CON_出力設定.InnerPannel
        '
        Me.CON_出力設定.Panel.Controls.Add(Me.DSP_設置支社)
        Me.CON_出力設定.Panel.Controls.Add(Me.LBL_設置支社)
        Me.CON_出力設定.Panel.Controls.Add(Me.LBL_IPアドレス)
        Me.CON_出力設定.Panel.Controls.Add(Me.LBL_用紙属性)
        Me.CON_出力設定.Panel.Controls.Add(Me.LBL_プリンター名)
        Me.CON_出力設定.Panel.Controls.Add(Me.TXT_帳票コード)
        Me.CON_出力設定.Panel.Controls.Add(Me.LBL_帳票コード)
        Me.CON_出力設定.Panel.Controls.Add(Me.TXT_出力先)
        Me.CON_出力設定.Panel.Controls.Add(Me.LBL_出力先)
        Me.CON_出力設定.Panel.Controls.Add(Me.LBL_出力先情報)
        Me.CON_出力設定.Panel.Controls.Add(Me.DSP_帳票名)
        Me.CON_出力設定.Panel.Controls.Add(Me.DSP_プリンター名)
        Me.CON_出力設定.Panel.Controls.Add(Me.DSP_用紙属性)
        Me.CON_出力設定.Panel.Controls.Add(Me.DSP_IPアドレス)
        Me.CON_出力設定.Panel.Name = "InnerPannel"
        Me.CON_出力設定.Panel.TabIndex = 0
        Me.CON_出力設定.Size = New System.Drawing.Size(1360, 96)
        Me.CON_出力設定.TabIndex = 61
        Me.CON_出力設定.Text = "出力設定"
        '
        'DSP_設置支社
        '
        Me.DSP_設置支社.BackColor = System.Drawing.SystemColors.Info
        Me.DSP_設置支社.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DSP_設置支社.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.DSP_設置支社.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DSP_設置支社.Location = New System.Drawing.Point(972, 58)
        Me.DSP_設置支社.Name = "DSP_設置支社"
        Me.DSP_設置支社.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.DSP_設置支社.Size = New System.Drawing.Size(189, 20)
        Me.DSP_設置支社.TabIndex = 54
        Me.DSP_設置支社.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.DSP_設置支社.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_設置支社
        '
        Me.LBL_設置支社.BackColor = System.Drawing.Color.Transparent
        Me.LBL_設置支社.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_設置支社.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_設置支社.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_設置支社.Location = New System.Drawing.Point(892, 58)
        Me.LBL_設置支社.Name = "LBL_設置支社"
        Me.LBL_設置支社.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_設置支社.Size = New System.Drawing.Size(81, 20)
        Me.LBL_設置支社.TabIndex = 47
        Me.LBL_設置支社.Text = "設置場所"
        Me.LBL_設置支社.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_設置支社.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_IPアドレス
        '
        Me.LBL_IPアドレス.BackColor = System.Drawing.Color.Transparent
        Me.LBL_IPアドレス.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_IPアドレス.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_IPアドレス.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_IPアドレス.Location = New System.Drawing.Point(892, 39)
        Me.LBL_IPアドレス.Name = "LBL_IPアドレス"
        Me.LBL_IPアドレス.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_IPアドレス.Size = New System.Drawing.Size(81, 20)
        Me.LBL_IPアドレス.TabIndex = 46
        Me.LBL_IPアドレス.Text = "IPアドレス"
        Me.LBL_IPアドレス.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_IPアドレス.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_用紙属性
        '
        Me.LBL_用紙属性.BackColor = System.Drawing.Color.Transparent
        Me.LBL_用紙属性.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_用紙属性.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_用紙属性.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_用紙属性.Location = New System.Drawing.Point(0, 58)
        Me.LBL_用紙属性.Name = "LBL_用紙属性"
        Me.LBL_用紙属性.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_用紙属性.Size = New System.Drawing.Size(170, 20)
        Me.LBL_用紙属性.TabIndex = 40
        Me.LBL_用紙属性.Text = "用紙（属性/サイズ/方向/給紙）"
        Me.LBL_用紙属性.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_用紙属性.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_プリンター名
        '
        Me.LBL_プリンター名.BackColor = System.Drawing.Color.Transparent
        Me.LBL_プリンター名.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_プリンター名.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_プリンター名.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_プリンター名.Location = New System.Drawing.Point(0, 39)
        Me.LBL_プリンター名.Name = "LBL_プリンター名"
        Me.LBL_プリンター名.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_プリンター名.Size = New System.Drawing.Size(170, 20)
        Me.LBL_プリンター名.TabIndex = 39
        Me.LBL_プリンター名.Text = "プリンタ名"
        Me.LBL_プリンター名.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_プリンター名.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_帳票コード
        '
        Me.LBL_帳票コード.BackColor = System.Drawing.Color.Transparent
        Me.LBL_帳票コード.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_帳票コード.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_帳票コード.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_帳票コード.Location = New System.Drawing.Point(0, 19)
        Me.LBL_帳票コード.Name = "LBL_帳票コード"
        Me.LBL_帳票コード.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_帳票コード.Size = New System.Drawing.Size(170, 20)
        Me.LBL_帳票コード.TabIndex = 38
        Me.LBL_帳票コード.Text = "帳票コード"
        Me.LBL_帳票コード.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_帳票コード.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_出力先
        '
        Me.LBL_出力先.BackColor = System.Drawing.Color.Transparent
        Me.LBL_出力先.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_出力先.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_出力先.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_出力先.Location = New System.Drawing.Point(0, 1)
        Me.LBL_出力先.Name = "LBL_出力先"
        Me.LBL_出力先.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_出力先.Size = New System.Drawing.Size(170, 20)
        Me.LBL_出力先.TabIndex = 29
        Me.LBL_出力先.Text = "出力先"
        Me.LBL_出力先.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_出力先.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_出力先情報
        '
        Me.LBL_出力先情報.BackColor = System.Drawing.SystemColors.Info
        Me.LBL_出力先情報.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_出力先情報.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.LBL_出力先情報.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_出力先情報.Location = New System.Drawing.Point(196, 1)
        Me.LBL_出力先情報.Name = "LBL_出力先情報"
        Me.LBL_出力先情報.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_出力先情報.Size = New System.Drawing.Size(965, 20)
        Me.LBL_出力先情報.TabIndex = 49
        Me.LBL_出力先情報.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_出力先情報.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'DSP_帳票名
        '
        Me.DSP_帳票名.BackColor = System.Drawing.SystemColors.Info
        Me.DSP_帳票名.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DSP_帳票名.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.DSP_帳票名.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DSP_帳票名.Location = New System.Drawing.Point(326, 19)
        Me.DSP_帳票名.Name = "DSP_帳票名"
        Me.DSP_帳票名.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.DSP_帳票名.Size = New System.Drawing.Size(835, 20)
        Me.DSP_帳票名.TabIndex = 50
        Me.DSP_帳票名.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.DSP_帳票名.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'DSP_プリンター名
        '
        Me.DSP_プリンター名.BackColor = System.Drawing.SystemColors.Info
        Me.DSP_プリンター名.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DSP_プリンター名.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.DSP_プリンター名.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DSP_プリンター名.Location = New System.Drawing.Point(169, 39)
        Me.DSP_プリンター名.Name = "DSP_プリンター名"
        Me.DSP_プリンター名.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.DSP_プリンター名.Size = New System.Drawing.Size(723, 20)
        Me.DSP_プリンター名.TabIndex = 51
        Me.DSP_プリンター名.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.DSP_プリンター名.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'DSP_用紙属性
        '
        Me.DSP_用紙属性.BackColor = System.Drawing.SystemColors.Info
        Me.DSP_用紙属性.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DSP_用紙属性.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.DSP_用紙属性.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DSP_用紙属性.Location = New System.Drawing.Point(169, 58)
        Me.DSP_用紙属性.Name = "DSP_用紙属性"
        Me.DSP_用紙属性.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.DSP_用紙属性.Size = New System.Drawing.Size(723, 20)
        Me.DSP_用紙属性.TabIndex = 52
        Me.DSP_用紙属性.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.DSP_用紙属性.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'DSP_IPアドレス
        '
        Me.DSP_IPアドレス.BackColor = System.Drawing.SystemColors.Info
        Me.DSP_IPアドレス.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DSP_IPアドレス.Font = New System.Drawing.Font("Yu Gothic UI", 10.5!)
        Me.DSP_IPアドレス.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.DSP_IPアドレス.Location = New System.Drawing.Point(972, 39)
        Me.DSP_IPアドレス.Name = "DSP_IPアドレス"
        Me.DSP_IPアドレス.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.DSP_IPアドレス.Size = New System.Drawing.Size(189, 20)
        Me.DSP_IPアドレス.TabIndex = 53
        Me.DSP_IPアドレス.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.DSP_IPアドレス.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'CON_Heading
        '
        Me.CON_Heading.Appearance = GrapeCity.Win.Containers.HeadingContainerAppearance.System
        Me.CON_Heading.DesignSize = New System.Drawing.Size(1360, 58)
        Me.CON_Heading.Dock = System.Windows.Forms.DockStyle.Top
        Me.CON_Heading.Font = New System.Drawing.Font("Yu Gothic UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.CON_Heading.HeaderSettings.Bevel = New GrapeCity.Win.Common.Bevel(System.Drawing.SystemColors.Control, 0, 0, 0)
        Me.CON_Heading.HeaderSettings.EllipsisMode = GrapeCity.Win.Common.EllipsisMode.None
        Me.CON_Heading.HeaderSettings.Padding = New System.Windows.Forms.Padding(0, 1, 0, -2)
        Me.CON_Heading.HeaderSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.CON_Heading.Location = New System.Drawing.Point(20, 10)
        Me.CON_Heading.Margin = New System.Windows.Forms.Padding(0, 50, 0, 0)
        Me.CON_Heading.Name = "CON_Heading"
        '
        'CON_Heading.InnerPannel
        '
        Me.CON_Heading.Panel.Controls.Add(Me.TXT_名称)
        Me.CON_Heading.Panel.Controls.Add(Me.LBL_名称)
        Me.CON_Heading.Panel.Controls.Add(Me.LBL_業務分類区分_FROM)
        Me.CON_Heading.Panel.Controls.Add(Me.TXT_業務分類区分_TO)
        Me.CON_Heading.Panel.Controls.Add(Me.TXT_業務分類区分_FROM)
        Me.CON_Heading.Panel.Controls.Add(Me.LBL_業務分類区分)
        Me.CON_Heading.Panel.Name = "InnerPannel"
        Me.CON_Heading.Panel.TabIndex = 0
        Me.CON_Heading.Size = New System.Drawing.Size(1360, 58)
        Me.CON_Heading.TabIndex = 0
        Me.CON_Heading.Text = "検索条件"
        '
        'LBL_名称
        '
        Me.LBL_名称.BackColor = System.Drawing.Color.Transparent
        Me.LBL_名称.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_名称.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_名称.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_名称.Location = New System.Drawing.Point(0, 19)
        Me.LBL_名称.Name = "LBL_名称"
        Me.LBL_名称.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_名称.Size = New System.Drawing.Size(571, 20)
        Me.LBL_名称.TabIndex = 38
        Me.LBL_名称.Text = "名称"
        Me.LBL_名称.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_名称.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_業務分類区分_FROM
        '
        Me.LBL_業務分類区分_FROM.BackColor = System.Drawing.Color.Transparent
        Me.LBL_業務分類区分_FROM.Font = New System.Drawing.Font("Yu Gothic UI", 8.0!)
        Me.LBL_業務分類区分_FROM.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_業務分類区分_FROM.Location = New System.Drawing.Point(143, 2)
        Me.LBL_業務分類区分_FROM.Name = "LBL_業務分類区分_FROM"
        Me.LBL_業務分類区分_FROM.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_業務分類区分_FROM.Size = New System.Drawing.Size(20, 18)
        Me.LBL_業務分類区分_FROM.TabIndex = 1
        Me.LBL_業務分類区分_FROM.Text = "～"
        Me.LBL_業務分類区分_FROM.TextHAlign = GrapeCity.Win.Common.TextHAlign.Center
        Me.LBL_業務分類区分_FROM.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'LBL_業務分類区分
        '
        Me.LBL_業務分類区分.BackColor = System.Drawing.Color.Transparent
        Me.LBL_業務分類区分.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LBL_業務分類区分.Font = New System.Drawing.Font("Yu Gothic UI", 10.0!)
        Me.LBL_業務分類区分.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.LBL_業務分類区分.Location = New System.Drawing.Point(0, 1)
        Me.LBL_業務分類区分.Name = "LBL_業務分類区分"
        Me.LBL_業務分類区分.Padding = New System.Windows.Forms.Padding(1, 1, 0, 0)
        Me.LBL_業務分類区分.Size = New System.Drawing.Size(571, 20)
        Me.LBL_業務分類区分.TabIndex = 29
        Me.LBL_業務分類区分.Text = "業務分類区分"
        Me.LBL_業務分類区分.TextHAlign = GrapeCity.Win.Common.TextHAlign.Left
        Me.LBL_業務分類区分.TextVAlign = GrapeCity.Win.Common.TextVAlign.Middle
        '
        'frm_M002_rpt
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1400, 885)
        Me.Controls.Add(Me.CTL_Main)
        Me.Controls.Add(Me.FNC_KEY)
        Me.Controls.Add(Me.STT_Status)
        Me.Controls.Add(Me.PNL_USR_IFO1)
        Me.Name = "frm_M002_rpt"
        Me.Text = "業務分類区分マスター"
        CType(Me.PNL_USR_IFO1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PNL_USR_IFO1.ResumeLayout(False)
        CType(Me.CTL_USR_IFO1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTL_USR_IFO1.ResumeLayout(False)
        Me.CTL_USR_IFO1.PerformLayout()
        CType(Me.TXT_名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_業務分類区分_TO, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_業務分類区分_FROM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_帳票コード, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_出力先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_LOG, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_HIS1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_HIS2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_HIS3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.STT_Status.ResumeLayout(False)
        Me.STT_Status.PerformLayout()
        CType(Me.CTL_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CTL_Main.ResumeLayout(False)
        Me.CON_Main.ResumeLayout(False)
        Me.CON_Status.ResumeLayout(False)
        CType(Me.TAB_Message, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TAB_Message.ResumeLayout(False)
        Me.TAB_Status.ResumeLayout(False)
        Me.TAB_History1.ResumeLayout(False)
        Me.TAB_History2.ResumeLayout(False)
        Me.TAB_History3.ResumeLayout(False)
        Me.CON_出力設定.Panel.ResumeLayout(False)
        Me.CON_出力設定.ResumeLayout(False)
        Me.CON_Heading.Panel.ResumeLayout(False)
        Me.CON_Heading.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PNL_USR_IFO1 As GrapeCity.Win.Containers.GcResizePanel
    Friend WithEvents GcShortcut1 As GrapeCity.Win.Editors.GcShortcut
    Friend WithEvents GcStylePlus1 As GrapeCity.Win.Components.GcStylePlus
    Friend WithEvents STT_Status As StatusStrip
    Friend WithEvents CTL_Main As GrapeCity.Win.Containers.GcResizePanel
    Friend WithEvents STT_Msg As ToolStripStatusLabel
    Friend WithEvents CON_Main As GrapeCity.Win.Containers.GcContainer
    Friend WithEvents CON_Heading As GrapeCity.Win.Containers.GcHeadingContainer
    Friend WithEvents TXT_名称 As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents LBL_名称 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_業務分類区分_FROM As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents TXT_業務分類区分_TO As GrapeCity.Win.Editors.GcNumber
    Friend WithEvents TXT_業務分類区分_FROM As GrapeCity.Win.Editors.GcNumber
    Friend WithEvents LBL_業務分類区分 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents CON_出力設定 As GrapeCity.Win.Containers.GcHeadingContainer
    Friend WithEvents LBL_帳票コード As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_出力先 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents CON_Status As GrapeCity.Win.Containers.GcContainer
    Friend WithEvents LBL_プリンター名 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_用紙属性 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_IPアドレス As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_設置支社 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents CTL_USR_IFO1 As GrapeCity.Win.Containers.GcTableLayoutContainer
    Friend WithEvents s1 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_事業所 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s2 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_支社 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s3 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_部 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s4 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_その他 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents s5 As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents CEL_処理モード As GrapeCity.Win.Containers.TableColumn
    Friend WithEvents LBL_MOD As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_部 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_支社 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents LBL_処理事業所 As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents ROW_S01 As GrapeCity.Win.Containers.TableRow
    Friend WithEvents TAB_Message As GrapeCity.Win.Containers.GcTabControl
    Friend WithEvents TAB_Status As GrapeCity.Win.Containers.GcTabPage
    Friend WithEvents TAB_History1 As GrapeCity.Win.Containers.GcTabPage
    Friend WithEvents TAB_History2 As GrapeCity.Win.Containers.GcTabPage
    Friend WithEvents TAB_History3 As GrapeCity.Win.Containers.GcTabPage
    Friend WithEvents LBL_ステータス As GrapeCity.Win.Buttons.GcLabel
    Friend WithEvents TXT_LOG As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents TXT_HIS1 As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents TXT_HIS2 As GrapeCity.Win.Editors.GcTextBox
    Friend WithEvents TXT_HIS3 As GrapeCity.Win.Editors.GcTextBox
    Public WithEvents TXT_帳票コード As GrapeCity.Win.Editors.GcTextBox
    Public WithEvents TXT_出力先 As GrapeCity.Win.Editors.GcNumber
    Public WithEvents LBL_出力先情報 As GrapeCity.Win.Buttons.GcLabel
    Public WithEvents DSP_帳票名 As GrapeCity.Win.Buttons.GcLabel
    Public WithEvents DSP_設置支社 As GrapeCity.Win.Buttons.GcLabel
    Public WithEvents DSP_プリンター名 As GrapeCity.Win.Buttons.GcLabel
    Public WithEvents DSP_用紙属性 As GrapeCity.Win.Buttons.GcLabel
    Public WithEvents DSP_IPアドレス As GrapeCity.Win.Buttons.GcLabel
    Public WithEvents FNC_KEY As GrapeCity.Win.Bars.GcClassicFunctionKey
End Class
