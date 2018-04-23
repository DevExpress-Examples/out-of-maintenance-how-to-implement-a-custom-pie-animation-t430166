using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;

namespace AnimationExample {
    public partial class MainForm : DevExpress.XtraEditors.XtraForm {
        Series series { get { return chartControl.Series[0]; } }
        PieSeriesView view { get { return series.View as PieSeriesView; } }

        public MainForm() {
            InitializeComponent();
        }

        #region #AnimationConfig
        protected override void OnLoad(EventArgs e) {
            base.OnLoad(e);

            view.Animation = new GripPieAnimation {
                BeginTime = new TimeSpan(0, 0, 0, 0),
                PointDelay = new TimeSpan(0, 0, 0, 0, 250),
                Duration = new TimeSpan(0, 0, 0, 1, 500),
                EasingFunction = new LinearEasingFunction {
                    EasingMode = EasingMode.Out
                }
            };

            chartControl.AnimationStartMode = ChartAnimationMode.OnLoad;
        }

        private void buttonOnClick(object sender, EventArgs e) {
            chartControl.Animate();
        }
        #endregion #AnimationConfig
    }
}

