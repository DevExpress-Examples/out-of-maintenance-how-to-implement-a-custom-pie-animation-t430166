Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms

Namespace AnimationExample
    Partial Public Class MainForm
        Inherits DevExpress.XtraEditors.XtraForm

        Private ReadOnly Property series() As Series
            Get
                Return chartControl.Series(0)
            End Get
        End Property
        Private ReadOnly Property view() As PieSeriesView
            Get
                Return TryCast(series.View, PieSeriesView)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub

        #Region "#AnimationConfig"
        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)

            view.Animation = New GripPieAnimation With { _
                .BeginTime = New TimeSpan(0, 0, 0, 0), .PointDelay = New TimeSpan(0, 0, 0, 0, 250), .Duration = New TimeSpan(0, 0, 0, 1, 500), .EasingFunction = New LinearEasingFunction With {.EasingMode = EasingMode.Out} _
            }

            chartControl.AnimationStartMode = ChartAnimationMode.OnLoad
        End Sub

        Private Sub buttonOnClick(ByVal sender As Object, ByVal e As EventArgs) Handles btnAnimate.Click
            chartControl.Animate()
        End Sub
        #End Region ' #AnimationConfig
    End Class
End Namespace

