<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rpt_M002
    Inherits GrapeCity.ActiveReports.SectionReport

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(rpt_M002))
        Me.Detail = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.PageHeader = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.PageFooter = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.LBL_業務分類区分 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.LBL_TTL = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.LBL_印刷日時 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TXT_現ページ = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TXT_総ページ = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.LBL_PRG_IDS = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.LBL_名称 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.LBL_略称 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.FID_事業所名 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.LBL_更新情報 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.LBL_登録情報 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.FID_名称 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FID_略称 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.FID_業務分類区分 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FID_更新日時 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FID_更新ユーザー名 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FID_更新ユーザーID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FID_登録日時 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FID_登録ユーザー名 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.FID_登録ユーザーID = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.LBL_業務分類区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBL_TTL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBL_印刷日時, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_現ページ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TXT_総ページ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBL_PRG_IDS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBL_名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBL_略称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FID_事業所名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBL_更新情報, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LBL_登録情報, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FID_名称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FID_略称, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FID_業務分類区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FID_更新日時, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FID_更新ユーザー名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FID_更新ユーザーID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FID_登録日時, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FID_登録ユーザー名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FID_登録ユーザーID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.CanGrow = False
        Me.Detail.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.FID_名称, Me.FID_略称, Me.Line5, Me.FID_業務分類区分, Me.FID_更新日時, Me.FID_更新ユーザー名, Me.FID_更新ユーザーID, Me.FID_登録日時, Me.FID_登録ユーザー名, Me.FID_登録ユーザーID})
        Me.Detail.Height = 0.2034722!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'PageHeader
        '
        Me.PageHeader.CanGrow = False
        Me.PageHeader.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.LBL_業務分類区分, Me.LBL_TTL, Me.Label2, Me.LBL_印刷日時, Me.Label3, Me.Label4, Me.TXT_現ページ, Me.TXT_総ページ, Me.LBL_PRG_IDS, Me.LBL_名称, Me.LBL_略称, Me.FID_事業所名, Me.Line6, Me.LBL_更新情報, Me.LBL_登録情報, Me.Line4})
        Me.PageHeader.Height = 0.4541667!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.1875!
        Me.PageFooter.Name = "PageFooter"
        '
        'LBL_業務分類区分
        '
        Me.LBL_業務分類区分.Height = 0.1875!
        Me.LBL_業務分類区分.HyperLink = Nothing
        Me.LBL_業務分類区分.Left = 0!
        Me.LBL_業務分類区分.MultiLine = False
        Me.LBL_業務分類区分.Name = "LBL_業務分類区分"
        Me.LBL_業務分類区分.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "left; vertical-align: middle"
        Me.LBL_業務分類区分.Text = "業務分類区分"
        Me.LBL_業務分類区分.Top = 0.25!
        Me.LBL_業務分類区分.Width = 0.875!
        '
        'LBL_TTL
        '
        Me.LBL_TTL.Height = 0.25!
        Me.LBL_TTL.HyperLink = Nothing
        Me.LBL_TTL.Left = 4.1875!
        Me.LBL_TTL.MultiLine = False
        Me.LBL_TTL.Name = "LBL_TTL"
        Me.LBL_TTL.Style = "font-family: \00FF2D\00FF33\000020\0030B4\0030B7\0030C3\0030AF; font-size: 12pt; " &
    "text-align: center; vertical-align: middle"
        Me.LBL_TTL.Text = "業務分類マスターリスト"
        Me.LBL_TTL.Top = 0!
        Me.LBL_TTL.Width = 2.125!
        '
        'Label2
        '
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 7.25!
        Me.Label2.MultiLine = False
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "center; vertical-align: middle"
        Me.Label2.Text = "RUN："
        Me.Label2.Top = 0!
        Me.Label2.Width = 0.4375!
        '
        'LBL_印刷日時
        '
        Me.LBL_印刷日時.Height = 0.1875!
        Me.LBL_印刷日時.HyperLink = Nothing
        Me.LBL_印刷日時.Left = 7.6875!
        Me.LBL_印刷日時.MultiLine = False
        Me.LBL_印刷日時.Name = "LBL_印刷日時"
        Me.LBL_印刷日時.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "justify; vertical-align: middle"
        Me.LBL_印刷日時.Text = "yy/MM/dd HH:mm:ss"
        Me.LBL_印刷日時.Top = 0!
        Me.LBL_印刷日時.Width = 1.375!
        '
        'Label3
        '
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 9.125!
        Me.Label3.MultiLine = False
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "center; vertical-align: middle"
        Me.Label3.Text = "PAGE："
        Me.Label3.Top = 0!
        Me.Label3.Width = 0.5625!
        '
        'Label4
        '
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 9.9375!
        Me.Label4.MultiLine = False
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "center; vertical-align: middle"
        Me.Label4.Text = "／"
        Me.Label4.Top = 0!
        Me.Label4.Width = 0.25!
        '
        'TXT_現ページ
        '
        Me.TXT_現ページ.Height = 0.1875!
        Me.TXT_現ページ.Left = 10.1875!
        Me.TXT_現ページ.MultiLine = False
        Me.TXT_現ページ.Name = "TXT_現ページ"
        Me.TXT_現ページ.OutputFormat = resources.GetString("TXT_現ページ.OutputFormat")
        Me.TXT_現ページ.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "right; vertical-align: middle"
        Me.TXT_現ページ.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.TXT_現ページ.Text = "ZZ9"
        Me.TXT_現ページ.Top = 0!
        Me.TXT_現ページ.Width = 0.25!
        '
        'TXT_総ページ
        '
        Me.TXT_総ページ.Height = 0.1875!
        Me.TXT_総ページ.Left = 9.6875!
        Me.TXT_総ページ.MultiLine = False
        Me.TXT_総ページ.Name = "TXT_総ページ"
        Me.TXT_総ページ.OutputFormat = resources.GetString("TXT_総ページ.OutputFormat")
        Me.TXT_総ページ.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "right; vertical-align: middle"
        Me.TXT_総ページ.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TXT_総ページ.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.TXT_総ページ.Text = "ZZ9"
        Me.TXT_総ページ.Top = 0!
        Me.TXT_総ページ.Width = 0.25!
        '
        'LBL_PRG_IDS
        '
        Me.LBL_PRG_IDS.Height = 0.1875!
        Me.LBL_PRG_IDS.HyperLink = Nothing
        Me.LBL_PRG_IDS.Left = 0!
        Me.LBL_PRG_IDS.MultiLine = False
        Me.LBL_PRG_IDS.Name = "LBL_PRG_IDS"
        Me.LBL_PRG_IDS.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "justify; vertical-align: middle"
        Me.LBL_PRG_IDS.Text = "ID:M002"
        Me.LBL_PRG_IDS.Top = 0!
        Me.LBL_PRG_IDS.Width = 1.0!
        '
        'LBL_名称
        '
        Me.LBL_名称.Height = 0.188!
        Me.LBL_名称.HyperLink = Nothing
        Me.LBL_名称.Left = 1.0625!
        Me.LBL_名称.MultiLine = False
        Me.LBL_名称.Name = "LBL_名称"
        Me.LBL_名称.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "justify; vertical-align: middle"
        Me.LBL_名称.Text = "名称"
        Me.LBL_名称.Top = 0.25!
        Me.LBL_名称.Width = 1.438!
        '
        'LBL_略称
        '
        Me.LBL_略称.Height = 0.188!
        Me.LBL_略称.HyperLink = Nothing
        Me.LBL_略称.Left = 2.8125!
        Me.LBL_略称.MultiLine = False
        Me.LBL_略称.Name = "LBL_略称"
        Me.LBL_略称.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "justify; vertical-align: middle"
        Me.LBL_略称.Text = "略称"
        Me.LBL_略称.Top = 0.25!
        Me.LBL_略称.Width = 0.771!
        '
        'FID_事業所名
        '
        Me.FID_事業所名.DataField = "事業所名"
        Me.FID_事業所名.Height = 0.1875!
        Me.FID_事業所名.Left = 1.0!
        Me.FID_事業所名.MultiLine = False
        Me.FID_事業所名.Name = "FID_事業所名"
        Me.FID_事業所名.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "justify; vertical-align: bottom"
        Me.FID_事業所名.Text = "XXXXXXXX10XXXXXXXX20XXXXXXXX30"
        Me.FID_事業所名.Top = 0!
        Me.FID_事業所名.Width = 2.0625!
        '
        'Line6
        '
        Me.Line6.Height = 0!
        Me.Line6.Left = 0!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.448!
        Me.Line6.Width = 10.5!
        Me.Line6.X1 = 0!
        Me.Line6.X2 = 10.5!
        Me.Line6.Y1 = 0.448!
        Me.Line6.Y2 = 0.448!
        '
        'LBL_更新情報
        '
        Me.LBL_更新情報.Height = 0.1875!
        Me.LBL_更新情報.HyperLink = Nothing
        Me.LBL_更新情報.Left = 7.8125!
        Me.LBL_更新情報.MultiLine = False
        Me.LBL_更新情報.Name = "LBL_更新情報"
        Me.LBL_更新情報.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "justify; vertical-align: middle"
        Me.LBL_更新情報.Text = "更新情報"
        Me.LBL_更新情報.Top = 0.25!
        Me.LBL_更新情報.Width = 2.625!
        '
        'LBL_登録情報
        '
        Me.LBL_登録情報.Height = 0.1875!
        Me.LBL_登録情報.HyperLink = Nothing
        Me.LBL_登録情報.Left = 5.0!
        Me.LBL_登録情報.MultiLine = False
        Me.LBL_登録情報.Name = "LBL_登録情報"
        Me.LBL_登録情報.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "justify; vertical-align: middle"
        Me.LBL_登録情報.Text = "登録情報"
        Me.LBL_登録情報.Top = 0.25!
        Me.LBL_登録情報.Width = 2.625!
        '
        'Line4
        '
        Me.Line4.Height = 0!
        Me.Line4.Left = 0!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.25!
        Me.Line4.Width = 10.5!
        Me.Line4.X1 = 0!
        Me.Line4.X2 = 10.5!
        Me.Line4.Y1 = 0.25!
        Me.Line4.Y2 = 0.25!
        '
        'FID_名称
        '
        Me.FID_名称.DataField = "名称"
        Me.FID_名称.Height = 0.1875!
        Me.FID_名称.Left = 1.0625!
        Me.FID_名称.MultiLine = False
        Me.FID_名称.Name = "FID_名称"
        Me.FID_名称.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "left; vertical-align: bottom"
        Me.FID_名称.Text = "XXXXXXXX10XXXXXXXX20"
        Me.FID_名称.Top = 0!
        Me.FID_名称.Width = 1.4375!
        '
        'FID_略称
        '
        Me.FID_略称.DataField = "略称"
        Me.FID_略称.Height = 0.1875!
        Me.FID_略称.Left = 2.8125!
        Me.FID_略称.MultiLine = False
        Me.FID_略称.Name = "FID_略称"
        Me.FID_略称.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "left; vertical-align: bottom"
        Me.FID_略称.Text = "XXXXXXXX10"
        Me.FID_略称.Top = 0!
        Me.FID_略称.Width = 0.7708333!
        '
        'Line5
        '
        Me.Line5.Height = 0!
        Me.Line5.Left = 0!
        Me.Line5.LineColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Line5.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.1979167!
        Me.Line5.Width = 10.5!
        Me.Line5.X1 = 0!
        Me.Line5.X2 = 10.5!
        Me.Line5.Y1 = 0.1979167!
        Me.Line5.Y2 = 0.1979167!
        '
        'FID_業務分類区分
        '
        Me.FID_業務分類区分.DataField = "業務分類区分"
        Me.FID_業務分類区分.Height = 0.188!
        Me.FID_業務分類区分.Left = 0!
        Me.FID_業務分類区分.MultiLine = False
        Me.FID_業務分類区分.Name = "FID_業務分類区分"
        Me.FID_業務分類区分.OutputFormat = resources.GetString("FID_業務分類区分.OutputFormat")
        Me.FID_業務分類区分.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "right; vertical-align: bottom"
        Me.FID_業務分類区分.Text = "99"
        Me.FID_業務分類区分.Top = 0!
        Me.FID_業務分類区分.Width = 0.1875!
        '
        'FID_更新日時
        '
        Me.FID_更新日時.DataField = "更新日時"
        Me.FID_更新日時.Height = 0.188!
        Me.FID_更新日時.Left = 9.4375!
        Me.FID_更新日時.MultiLine = False
        Me.FID_更新日時.Name = "FID_更新日時"
        Me.FID_更新日時.OutputFormat = resources.GetString("FID_更新日時.OutputFormat")
        Me.FID_更新日時.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "left; vertical-align: bottom"
        Me.FID_更新日時.Text = "yy/MM/dd HH:mm"
        Me.FID_更新日時.Top = 0!
        Me.FID_更新日時.Width = 1.0!
        '
        'FID_更新ユーザー名
        '
        Me.FID_更新ユーザー名.DataField = "更新ユーザー名"
        Me.FID_更新ユーザー名.Height = 0.188!
        Me.FID_更新ユーザー名.Left = 8.313!
        Me.FID_更新ユーザー名.MultiLine = False
        Me.FID_更新ユーザー名.Name = "FID_更新ユーザー名"
        Me.FID_更新ユーザー名.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "left; vertical-align: bottom"
        Me.FID_更新ユーザー名.Text = "XXXXXXXX10XXXX16"
        Me.FID_更新ユーザー名.Top = 0.000499934!
        Me.FID_更新ユーザー名.Width = 1.1245!
        '
        'FID_更新ユーザーID
        '
        Me.FID_更新ユーザーID.DataField = "更新ユーザーID"
        Me.FID_更新ユーザーID.Height = 0.188!
        Me.FID_更新ユーザーID.Left = 7.75!
        Me.FID_更新ユーザーID.MultiLine = False
        Me.FID_更新ユーザーID.Name = "FID_更新ユーザーID"
        Me.FID_更新ユーザーID.OutputFormat = resources.GetString("FID_更新ユーザーID.OutputFormat")
        Me.FID_更新ユーザーID.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "right; vertical-align: bottom"
        Me.FID_更新ユーザーID.Text = "9999999"
        Me.FID_更新ユーザーID.Top = 0!
        Me.FID_更新ユーザーID.Width = 0.5629997!
        '
        'FID_登録日時
        '
        Me.FID_登録日時.DataField = "登録日時"
        Me.FID_登録日時.Height = 0.188!
        Me.FID_登録日時.Left = 6.625!
        Me.FID_登録日時.MultiLine = False
        Me.FID_登録日時.Name = "FID_登録日時"
        Me.FID_登録日時.OutputFormat = resources.GetString("FID_登録日時.OutputFormat")
        Me.FID_登録日時.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "left; vertical-align: bottom"
        Me.FID_登録日時.Text = "yy/MM/dd HH:mm"
        Me.FID_登録日時.Top = 0!
        Me.FID_登録日時.Width = 1.0!
        '
        'FID_登録ユーザー名
        '
        Me.FID_登録ユーザー名.DataField = "登録ユーザー名"
        Me.FID_登録ユーザー名.Height = 0.188!
        Me.FID_登録ユーザー名.Left = 5.5!
        Me.FID_登録ユーザー名.MultiLine = False
        Me.FID_登録ユーザー名.Name = "FID_登録ユーザー名"
        Me.FID_登録ユーザー名.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "left; vertical-align: bottom"
        Me.FID_登録ユーザー名.Text = "XXXXXXXX10XXXX16"
        Me.FID_登録ユーザー名.Top = 0!
        Me.FID_登録ユーザー名.Width = 1.125!
        '
        'FID_登録ユーザーID
        '
        Me.FID_登録ユーザーID.DataField = "登録ユーザーID"
        Me.FID_登録ユーザーID.Height = 0.188!
        Me.FID_登録ユーザーID.Left = 4.9375!
        Me.FID_登録ユーザーID.MultiLine = False
        Me.FID_登録ユーザーID.Name = "FID_登録ユーザーID"
        Me.FID_登録ユーザーID.OutputFormat = resources.GetString("FID_登録ユーザーID.OutputFormat")
        Me.FID_登録ユーザーID.Style = "font-family: \00FF2D\00FF33\000020\00660E\00671D; font-size: 9.75pt; text-align: " &
    "right; vertical-align: bottom"
        Me.FID_登録ユーザーID.Text = "9999999"
        Me.FID_登録ユーザーID.Top = 0!
        Me.FID_登録ユーザーID.Width = 0.5629997!
        '
        'rpt_M002
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0!
        Me.PageSettings.Margins.Left = 0!
        Me.PageSettings.Margins.Right = 0!
        Me.PageSettings.Margins.Top = 0!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 10.51042!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule(resources.GetString("$this.StyleSheet"), "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 16pt; font-size-adjust: inherit; font-stretch: inherit", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-style: italic; font-variant: inherit; font-wei" &
            "ght: bold; font-size: 14pt; font-size-adjust: inherit; font-stretch: inherit", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: inherit; font-style: inherit; font-variant: inherit; font-weight: bo" &
            "ld; font-size: 13pt; font-size-adjust: inherit; font-stretch: inherit", "Heading3", "Normal"))
        CType(Me.LBL_業務分類区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBL_TTL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBL_印刷日時, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_現ページ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TXT_総ページ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBL_PRG_IDS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBL_名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBL_略称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FID_事業所名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBL_更新情報, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LBL_登録情報, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FID_名称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FID_略称, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FID_業務分類区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FID_更新日時, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FID_更新ユーザー名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FID_更新ユーザーID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FID_登録日時, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FID_登録ユーザー名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FID_登録ユーザーID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Private WithEvents Detail As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents FID_名称 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FID_略称 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents FID_業務分類区分 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FID_更新日時 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FID_更新ユーザー名 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FID_更新ユーザーID As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FID_登録日時 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FID_登録ユーザー名 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents FID_登録ユーザーID As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents PageHeader As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents LBL_業務分類区分 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents LBL_TTL As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents LBL_印刷日時 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents TXT_現ページ As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents TXT_総ページ As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents LBL_PRG_IDS As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents LBL_名称 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents LBL_略称 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents FID_事業所名 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents LBL_更新情報 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents LBL_登録情報 As GrapeCity.ActiveReports.SectionReportModel.Label
    Private WithEvents Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Private WithEvents PageFooter As GrapeCity.ActiveReports.SectionReportModel.PageFooter
End Class
