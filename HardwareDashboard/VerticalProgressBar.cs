using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CircleLoadingBar
{
    public partial class VerticalProgressBar : UserControl
    {
        public VerticalProgressBar()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint
   | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            InitializeComponent();
            this.Paint += VerticalProgressBar_Paint;
        }

        Color[] _barColor = { Color.LimeGreen };
        Color _backColor = Color.LightGray;
        Color _edgeColor = Color.Black;
        float _colorAngle = 0F;
        double _value = 25;
        double _maxValue = 100;
        bool _edge = true;
        private readonly object balanceLock = new object();

        private void VerticalProgressBar_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            double value = _value / _maxValue * 100;
            float Height = (float)this.Height * (float)(value / 100);
            Rectangle rect = new Rectangle(0, 0, this.Width, this.Height);
            g.FillRectangle(new SolidBrush(_backColor), rect);

            if (_barColor.Count() > 1)
            {
                using (LinearGradientBrush lgb = new LinearGradientBrush(rect, Color.Black, Color.White, _colorAngle))
                {
                    float[] pos = new float[_barColor.Count()];
                    float[] fact = new float[_barColor.Count()];
                    for (int i = 0; i < _barColor.Count(); i++)
                    {
                        pos[i] = 1f * ((float)i / ((float)_barColor.Count() - 1));
                        fact[i] = .125f;
                        //{ 0f, .125f, .25f, .375f, .5f, .625f, .75f, .875f, 1f };
                    }
                    Blend b = new Blend();
                    b.Positions = pos;
                    b.Factors = fact; // new float[] { .125f, .125f, .125f, .125f, .125f, .125f, .125f, .125f, .125f };
                    ColorBlend cb = new ColorBlend();
                    cb.Positions = pos;
                    cb.Colors = _barColor;
                    lgb.Blend = b;
                    lgb.WrapMode = WrapMode.Tile;
                    lgb.GammaCorrection = true;
                    lgb.InterpolationColors = cb;
                    g.FillRectangle(lgb, 0, this.Height - Height, this.Width, Height);
                }
            }
            else
            {
                g.FillRectangle(new SolidBrush(_barColor.First()), 0, this.Height - Height, this.Width, Height);
            }
            if (_edge)
                g.DrawRectangle(new Pen(new SolidBrush(_edgeColor)), 0, 0, this.Width - 1, this.Height - 1);
        }

        [Description("De/activates the edge of the bar"), Category("Appearance")]
        public bool Edge
        {
            get { return _edge; }
            set
            {
                _edge = value;
                this.Invalidate();
            }
        }

        [Description("Main color of the bar"), Category("Appearance")]
        public Color[] BarColor
        {
            get { return _barColor; }
            set
            {
                _barColor = value;
                this.Invalidate();
            }
        }

        [Description("Color of the edge"), Category("Appearance")]
        public Color EdgeColor
        {
            get { return _edgeColor; }
            set
            {
                _edgeColor = value;
                this.Invalidate();
            }
        }

        [Description("Background color of the bar"), Category("Appearance")]
        public Color BackgroundColor
        {
            get { return _backColor; }
            set
            {
                _backColor = value;
                this.Invalidate();
            }
        }

        [Description("Angle of the color gradient"), Category("Appearance")]
        public float ColorAngle
        {
            get { return _colorAngle; }
            set
            {
                _colorAngle = value;
                this.Invalidate();
            }
        }

        [Description("Sets the max value the bar can display"), Category("Appearance")]
        public double MaxValue
        {
            get { return _maxValue; }
            set
            {
                _maxValue = value;
                this.Invalidate();
            }
        }

        [Description("Bars Value in percent"), Category("Data")]
        public double Value
        {
            get { return _value; }
            set
            {
                _value = _value > _maxValue ? _maxValue : _value;
                if (_value != tempValue)
                {
                    _value = tempValue;
                    this.Invalidate();
                }
                tempValue = value;
                if (tempValue > _value)
                    valuePercentage = (float)(_value / tempValue);
                else
                    valuePercentage = 1;
                if (valueTimer.Enabled != true)
                    valueTimer.Start();
            }
        }

        float BezierBlend(float t)
        {
            return t * t * (3.0f - 2.0f * t);
        }

        private float valuePercentage = 0.1f;
        private double tempValue = 0;
        private void valueTimer_Tick(object sender, EventArgs e)
        {
            if (tempValue > _value + 1)
            {
                _value = tempValue * BezierBlend(valuePercentage += 0.1f);
                this.Invalidate();
                return;
            }
            if (tempValue < _value - 1)
            {
                _value = _value * BezierBlend(valuePercentage -= 0.1f);
                this.Invalidate();
                return;
            }
            _value = tempValue;
            this.Invalidate();
            valueTimer.Stop();
        }
    }
}
