using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HardwareDashboard
{
    public partial class ModernSlider : UserControl
    {
        private Color _sliderBackColor = Color.DimGray;
        private Color _sliderForeColor = Color.DarkOrange;
        private Color _ballColor = Color.Orange;
        private PointF _dragPoint = new PointF(0, 0);
        private float _value = 0.0f;
        private float _maxValue = 100.0f;
        private float _ballSize = 15;
        private int _sliderHeight = 5;
        public event EventHandler ValueChanged = delegate { };
        bool drag = false;
        PointF origin = new PointF(0, 0);
        public ModernSlider()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            this.Paint += ModernSlider_Paint;
            this.MouseMove += ModernSlider_MouseMove;
            this.MouseDown += ModernSlider_MouseDown;
            this.MouseUp += ModernSlider_MouseUp;
        }

        private void ModernSlider_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drag = false;
            }
        }

        private void ModernSlider_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pos = e.Location;

                if (Math.Abs(pos.X - _dragPoint.X) < _ballSize &&
                    Math.Abs(pos.Y - _dragPoint.Y) < _ballSize)
                {
                    drag = true;
                }
            }
        }

        private void ModernSlider_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag)
            {
                var pos = e.Location;
                float perc = (float)(pos.X - origin.X) / (float)this.Width;
                if (perc < 0)
                    perc = 0;
                else if (perc > 1)
                    perc = 1;
                _value = _maxValue * perc;
                ValueChanged(null, EventArgs.Empty);
                this.Invalidate();
            }
        }

        private void ModernSlider_Paint(object sender, PaintEventArgs e)
        {
            int width = this.Width - _sliderHeight;
            float center = this.Height / 2 - _sliderHeight;
            float value = _value / _maxValue;
            SolidBrush sliderBackBrush = new SolidBrush(_sliderBackColor);
            SolidBrush sliderForeBrush = new SolidBrush(_sliderForeColor);
            SolidBrush ballBrush = new SolidBrush(_ballColor);
            SolidBrush backBrush = new SolidBrush(this.BackColor);
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            origin = new PointF(_sliderHeight, center);

            g.FillEllipse(sliderBackBrush, width - _sliderHeight / 2 - 2, center - 0.5f, _sliderHeight + 0.5f, _sliderHeight + 1f);
            g.FillRectangle(sliderBackBrush, new RectangleF(origin.X, center - 0.25f, width - _sliderHeight, _sliderHeight + 0.5f));
            g.FillEllipse(sliderForeBrush, _sliderHeight / 2, center - 0.5f, _sliderHeight + 0.5f, _sliderHeight + 1f);
            g.FillRectangle(sliderForeBrush, new RectangleF(origin.X, center - 0.25f, width * value - _sliderHeight, _sliderHeight + 0.5f));
            float posX = (width * value) + _ballSize + 1 > width ? width - (_ballSize + 1) : width * value;
            g.FillEllipse(backBrush, new RectangleF(posX - 2.5f, center - _ballSize / 2 + _sliderHeight / 2 - 2.5f, _ballSize + 5, _ballSize + 5));
            g.FillEllipse(ballBrush, new RectangleF(posX, center - _ballSize / 2 + _sliderHeight / 2, _ballSize, _ballSize));
            _dragPoint = new PointF(posX + _ballSize / 2, center - _ballSize / 2 + _sliderHeight / 2);
        }

        [Description("Sets the current Value of the slider"), Category("Data")]
        public float Value
        {
            get { return _value; }
            set
            {
                if (value < 0)
                    _value = 0;
                else if (value > _maxValue)
                    _value = _maxValue;
                else
                    _value = value;
                ValueChanged(null, EventArgs.Empty);
                this.Invalidate();
            }
        }

        [Description("Sets the current Maxvalue of the slider"), Category("Data")]
        public float MaxValue
        {
            get { return _maxValue; }
            set
            {
                _maxValue = value;
                this.Invalidate();
            }
        }

        [Description("Sets the sliders bar height"), Category("Appearance")]
        public int SliderBarHeight
        {
            get { return _sliderHeight; }
            set
            {
                _sliderHeight = value;
                this.Invalidate();
            }
        }

        [Description("Sets the ball size"), Category("Appearance")]
        public float BallSize
        {
            get { return _ballSize; }
            set
            {
                _ballSize = value;
                this.Invalidate();
            }
        }

        [Description("Sets the sliders bar backcolor"), Category("Appearance")]
        public Color BarBackColor
        {
            get { return _sliderBackColor; }
            set
            {
                _sliderBackColor = value;
                this.Invalidate();
            }
        }

        [Description("Sets the sliders color"), Category("Appearance")]
        public Color BarColor
        {
            get { return _sliderForeColor; }
            set
            {
                _sliderForeColor = value;
                this.Invalidate();
            }
        }

        [Description("Sets the balls color"), Category("Appearance")]
        public Color BallColor
        {
            get { return _ballColor; }
            set
            {
                _ballColor = value;
                this.Invalidate();
            }
        }
    }
}
