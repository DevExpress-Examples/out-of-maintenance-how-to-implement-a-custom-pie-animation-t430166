#region #CustomAnimation
using DevExpress.XtraCharts;
using System.Drawing;

namespace AnimationExample {
    class GripPieAnimation : PieAnimationBase {
        public static PointF CalculateOffset(RectangleF pointBounds, float progress) {
            float offsetX = (pointBounds.Width / 2 + pointBounds.X) * progress;
            float offsetY = (pointBounds.Height / 2 + pointBounds.Y) * progress;
            return new PointF(offsetX, offsetY);
        }
        public override void ApplyState(
                SceneModifier modifier, 
                RectangleF diagramBounds, 
                PieSeriesPointLayoutParameters pieParameters, 
                float progress
        ) {
            float pieCenterX = pieParameters.PieCenter.X;
            float pieCenterY = pieParameters.PieCenter.Y;
            float scale = (progress <= 0.5)
                ? 1 - 0.2f * progress
                : 0.8f + 0.2f * progress;

            // Note that methods requiered for correct transform are called in inverse order.
            // This is a feature of affine transformations.
            modifier.Translate(pieCenterX, pieCenterY);
            modifier.Scale(scale, scale);
            modifier.Translate(-pieCenterX, -pieCenterY);
        }

        protected override ChartElement CreateObjectForClone() {
            return new GripPieAnimation();
        }
    }
}
#endregion #CustomAnimation