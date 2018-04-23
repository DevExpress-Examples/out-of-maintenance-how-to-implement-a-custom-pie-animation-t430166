Namespace AnimationExample
    Partial Public Class MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint("Russia", New Object() { (DirectCast(17.0752R, Object))}, 0)
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint("Canada", New Object() { (DirectCast(9.98467R, Object))}, 1)
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint("USA", New Object() { (DirectCast(9.63142R, Object))}, 2)
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint("China", New Object() { (DirectCast(9.56696R, Object))}, 3)
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint("Brazil", New Object() { (DirectCast(8.511956R, Object))}, 4)
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint("Australia", New Object() { (DirectCast(7.68685R, Object))}, 5)
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint("India", New Object() { (DirectCast(3.28759R, Object))}, 6)
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint("Others", New Object() { (DirectCast(81.2R, Object))}, 7)
            Dim pieSeriesView1 As New DevExpress.XtraCharts.PieSeriesView()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            Me.pnlChart = New DevExpress.XtraEditors.PanelControl()
            Me.pnlButton = New DevExpress.XtraEditors.PanelControl()
            Me.btnAnimate = New DevExpress.XtraEditors.SimpleButton()
            DirectCast(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(pieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pnlChart, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlChart.SuspendLayout()
            DirectCast(Me.pnlButton, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.pnlButton.SuspendLayout()
            Me.SuspendLayout()
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' chartControl
            ' 
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Center
            Me.chartControl.Legend.AlignmentVertical = DevExpress.XtraCharts.LegendAlignmentVertical.BottomOutside
            Me.chartControl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl.Legend.Name = "Default Legend"
            Me.chartControl.Legend.Visibility = DevExpress.Utils.DefaultBoolean.True
            Me.chartControl.Location = New System.Drawing.Point(4, 4)
            Me.chartControl.Name = "chartControl"
            series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.False
            series1.LegendTextPattern = "{A}"
            series1.Name = "Series"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8})
            series1.View = pieSeriesView1
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1}
            Me.chartControl.Size = New System.Drawing.Size(776, 376)
            Me.chartControl.TabIndex = 2
            chartTitle1.Text = "Area of Countries"
            Me.chartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' pnlChart
            ' 
            Me.pnlChart.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlChart.Controls.Add(Me.chartControl)
            Me.pnlChart.Dock = System.Windows.Forms.DockStyle.Fill
            Me.pnlChart.Location = New System.Drawing.Point(0, 0)
            Me.pnlChart.Name = "pnlChart"
            Me.pnlChart.Padding = New System.Windows.Forms.Padding(4, 4, 4, 2)
            Me.pnlChart.Size = New System.Drawing.Size(784, 382)
            Me.pnlChart.TabIndex = 3
            ' 
            ' pnlButton
            ' 
            Me.pnlButton.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.pnlButton.Controls.Add(Me.btnAnimate)
            Me.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.pnlButton.Location = New System.Drawing.Point(0, 382)
            Me.pnlButton.Name = "pnlButton"
            Me.pnlButton.Padding = New System.Windows.Forms.Padding(4, 2, 4, 4)
            Me.pnlButton.Size = New System.Drawing.Size(784, 29)
            Me.pnlButton.TabIndex = 4
            ' 
            ' btnAnimate
            ' 
            Me.btnAnimate.Dock = System.Windows.Forms.DockStyle.Right
            Me.btnAnimate.Location = New System.Drawing.Point(680, 2)
            Me.btnAnimate.Name = "btnAnimate"
            Me.btnAnimate.Size = New System.Drawing.Size(100, 23)
            Me.btnAnimate.TabIndex = 0
            Me.btnAnimate.Text = "Animate"
            ' 
            ' MainForm
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(784, 411)
            Me.Controls.Add(Me.pnlChart)
            Me.Controls.Add(Me.pnlButton)
            Me.Name = "MainForm"
            Me.Text = "Custom Pie Animation Example"
            DirectCast(pieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pnlChart, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlChart.ResumeLayout(False)
            DirectCast(Me.pnlButton, System.ComponentModel.ISupportInitialize).EndInit()
            Me.pnlButton.ResumeLayout(False)
            Me.ResumeLayout(False)

        End Sub

        #End Region
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
        Private chartControl As DevExpress.XtraCharts.ChartControl
        Private pnlChart As DevExpress.XtraEditors.PanelControl
        Private pnlButton As DevExpress.XtraEditors.PanelControl
        Private WithEvents btnAnimate As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace

