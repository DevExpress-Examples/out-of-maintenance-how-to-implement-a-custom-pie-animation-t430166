#Region "#CustomAnimation"
Imports DevExpress.XtraCharts
Imports System.Drawing

Namespace AnimationExample
    Friend Class GripPieAnimation
        Inherits PieAnimationBase

        Public Shared Function CalculateOffset(ByVal pointBounds As RectangleF, ByVal progress As Single) As PointF
            Dim offsetX As Single = (pointBounds.Width / 2 + pointBounds.X) * progress
            Dim offsetY As Single = (pointBounds.Height / 2 + pointBounds.Y) * progress
            Return New PointF(offsetX, offsetY)
        End Function
        Public Overrides Sub ApplyState(ByVal modifier As SceneModifier, ByVal diagramBounds As RectangleF, ByVal pieParameters As PieSeriesPointLayoutParameters, ByVal progress As Single)
            Dim pieCenterX As Single = pieParameters.PieCenter.X
            Dim pieCenterY As Single = pieParameters.PieCenter.Y
            Dim scale As Single = If(progress <= 0.5, 1 - 0.2F * progress, 0.8F + 0.2F * progress)

            ' Note that methods requiered for correct transform are called in inverse order.
            ' This is a feature of affine transformations.
            modifier.Translate(pieCenterX, pieCenterY)
            modifier.Scale(scale, scale)
            modifier.Translate(-pieCenterX, -pieCenterY)
        End Sub

        Protected Overrides Function CreateObjectForClone() As ChartElement
            Return New GripPieAnimation()
        End Function
    End Class
End Namespace
#End Region ' #CustomAnimation