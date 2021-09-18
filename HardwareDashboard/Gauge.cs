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
    public partial class Gauge : UserControl
    {
        private Size size = new Size(100, 100);
        private Color[] _barBackground = { Color.Gray };
        private Color[] _barColor = { Color.DarkCyan };
        private Color _backColor = Color.DimGray;
        private Color _foreColor = Color.Black;
        private Color _arrowColor = Color.Red;
        private Color _percentageColor = Color.Red;
        private int _percentageLineWidth = 1;
        private int _barWidth = 10;
        private double _value = 0;
        private double _maxValue = 100;
        private float _colorAngleBackground = 0f;
        private float _startAngle = 135f;
        private float _sweepAngle = 270f;
        private float _colorAngleForeground = 0f;
        private float _textHeightPerc = 0.9f;
        private float _percentagePointerLength = 1.0f;
        private int _ballSize = 10;
        private int _pointerBase = 5;
        private bool _colorLive = true;
        private bool _drawPercentages = false;
        private bool _displayMinMax = true;
        private bool _displayPointer = true;
        private bool _displayText = true;


        public Gauge()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint
   | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            _backColor = this.BackColor;
            size = new Size(this.Width - 2, this.Height - 2);
            InitializeComponent();
            this.Paint += Gauge_Paint;
            this.ForeColorChanged += Gauge_ForeColorChanged;
            this.SizeChanged += Gauge_SizeChanged;
        }

        private void Gauge_SizeChanged(object sender, EventArgs e)
        {
            size = new Size(this.Width - 2, this.Height - 2);
        }

        private void Gauge_ForeColorChanged(object sender, EventArgs e)
        {
            _foreColor = this.ForeColor;
            this.Invalidate();
        }

        protected override void OnParentChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                this.BackColor = this.Parent.BackColor;
                _backColor = this.Parent.BackColor;
            }
            base.OnParentChanged(e);
        }
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            this.BackColor = this.Parent.BackColor;
            _backColor = this.Parent.BackColor;
            base.OnParentBackColorChanged(e);
        }

        private void Gauge_Paint(object sender, PaintEventArgs e)
        {
            int width = size.Width;
            int height = size.Height;
            //_value = _value > 100 ? 100 : _value;
            double value = _value / _maxValue * 100;
            float startAngle = _startAngle;
            float sweepAngle = (float)((double)_sweepAngle * value / 100);
            int Width = (int)(width - _barWidth);
            int Height = (int)(height - _barWidth);
            Rectangle rect = new Rectangle(0, 0, width, height);

            Graphics g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            if (_barBackground.Count() > 1)
            {
                using (LinearGradientBrush lgb = new LinearGradientBrush(rect, Color.Black, Color.White, _colorAngleBackground))
                {
                    float[] pos = new float[_barBackground.Count()];
                    float[] fact = new float[_barBackground.Count()];
                    for (int i = 0; i < _barBackground.Count(); i++)
                    {
                        pos[i] = 1f * ((float)i / ((float)_barBackground.Count() - 1));
                        fact[i] = .125f;
                        //{ 0f, .125f, .25f, .375f, .5f, .625f, .75f, .875f, 1f };
                    }
                    Blend b = new Blend();
                    b.Positions = pos;
                    b.Factors = fact; // new float[] { .125f, .125f, .125f, .125f, .125f, .125f, .125f, .125f, .125f };
                    ColorBlend cb = new ColorBlend();
                    cb.Positions = pos;
                    cb.Colors = _barBackground;
                    lgb.Blend = b;
                    lgb.WrapMode = WrapMode.Tile;
                    lgb.GammaCorrection = true;
                    lgb.InterpolationColors = cb;
                    g.FillPie(lgb, rect, _startAngle, _sweepAngle);
                }
            }
            else
            {
                g.FillPie(new SolidBrush(_barBackground.First()), rect, _startAngle, _sweepAngle);
            }

            if (_barColor.Count() > 1)
            {
                using (LinearGradientBrush lgb = new LinearGradientBrush(rect, Color.Black, Color.White, _colorAngleForeground))
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
                    lgb.WrapMode = WrapMode.TileFlipXY;
                    lgb.GammaCorrection = true;
                    lgb.InterpolationColors = cb;
                    if (_colorLive)
                        g.FillPie(lgb, rect, startAngle, sweepAngle);
                    else
                        g.FillPie(lgb, rect, _startAngle, _sweepAngle);
                }
            }
            else
            {
                if (_colorLive)
                    g.FillPie(new SolidBrush(_barColor.First()), rect, startAngle, sweepAngle);
                else
                    g.FillPie(new SolidBrush(_barColor.First()), rect, _startAngle, _sweepAngle);
            }

            g.FillEllipse(new SolidBrush(_backColor), new Rectangle((width / 2) - (Width / 2), (height / 2) - (Height / 2), Width, Height));
            if (_drawPercentages)
            {
                for (float i = 0; i <= 1.1; i += 0.1f)
                {
                    double rad = DegToRad(_sweepAngle * i) + DegToRad(_startAngle);
                    float X = (width / 2) + (float)((Width * 0.4f) * Math.Cos(rad));
                    float Y = (height / 2) + (float)((Height * 0.4f) * Math.Sin(rad));
                    float X1 = (width / 2) + (float)((Width * 0.45f) * Math.Cos(rad));
                    float Y1 = (height / 2) + (float)((Height * 0.45f) * Math.Sin(rad));
                    g.DrawLine(new Pen(_percentageColor, _percentageLineWidth), X, Y, X1, Y1);
                }
            }

            if(_displayPointer)
            {
                double radian = DegToRad(sweepAngle) + DegToRad(_startAngle);
                double x = (width / 2) + ((width / 2) * _percentagePointerLength) * Math.Cos(radian);
                double y = (height / 2) + ((height / 2) * _percentagePointerLength) * Math.Sin(radian);

                double radOffset = _sweepAngle <= 130 ? DegToRad(45) : _sweepAngle > 270 ? DegToRad(90) : DegToRad(-45);
                double radian0 = DegToRad(sweepAngle) - Math.PI / 2 + radOffset;
                double xPointer0 = (width / 2) + _pointerBase * Math.Cos(radian0);
                double yPointer0 = (height / 2) + _pointerBase * Math.Sin(radian0);

                double radian1 = DegToRad(sweepAngle) + Math.PI / 2 + radOffset;
                double xPointer1 = (width / 2) + _pointerBase * Math.Cos(radian1);
                double yPointer1 = (height / 2) + _pointerBase * Math.Sin(radian1);

                PointF GaugePoint = new PointF((float)x, (float)y);
                g.FillEllipse(new SolidBrush(_arrowColor), new Rectangle((width / 2) - (_ballSize / 2), (height / 2) - (_ballSize / 2), _ballSize, _ballSize));

                g.FillPolygon(new SolidBrush(_arrowColor), new PointF[] { new PointF((float)xPointer0, (float)yPointer0), GaugePoint, new PointF((float)xPointer1, (float)yPointer1) });
            }

            if(_displayText)
            {
                SizeF fontSize = _value % 1 != 0 ? g.MeasureString(_value.ToString("0.00"), this.Font) : g.MeasureString(_value.ToString("0."), this.Font);
                g.DrawString(_value % 1 != 0 ? _value.ToString("0.00") : _value.ToString("0."), this.Font, new SolidBrush(_foreColor), new PointF(width / 2 - (int)(fontSize.Width / 2), height * _textHeightPerc - (int)(fontSize.Height)));
            }
            if (_displayMinMax)
            {
                double xText = (width / 2) + (width / 2) * Math.Cos(0 + DegToRad(_startAngle));
                double yText = (height / 2) + (height / 2) * Math.Sin(0 + DegToRad(_startAngle));
                double xTextEnd = (width / 2) + (width / 2) * Math.Cos(DegToRad(_sweepAngle) + DegToRad(_startAngle));
                double yTextEnd = (height / 2) + (height / 2) * Math.Sin(DegToRad(_sweepAngle) + DegToRad(_startAngle));
                SizeF maxvalSize = g.MeasureString(_maxValue.ToString("0."), this.Font);
                float yOffset = _sweepAngle < 180 ? maxvalSize.Height : 0;
                g.DrawString("0", this.Font, new SolidBrush(_foreColor), new PointF((float)xText + 5, (float)yText+ yOffset));
                g.DrawString(_maxValue.ToString("0."), this.Font, new SolidBrush(_foreColor), new PointF((float)xTextEnd - maxvalSize.Width + 5, (float)yTextEnd+ yOffset));
            }
        }

        static double DegToRad(float angleInDegrees)
        {
            return angleInDegrees * Math.PI / 180F;
        }

        [Description("Color used for the main bar"), Category("Appearance")]
        public Color[] BarColor
        {
            get { return _barColor; }
            set
            {
                _barColor = value;
                this.Invalidate();
            }
        }

        [Description("Color used for the main bar background"), Category("Appearance")]
        public Color[] BarBackground
        {
            get { return _barBackground; }
            set
            {
                _barBackground = value;
                this.Invalidate();
            }
        }

        [Description("Color used for the main bar"), Category("Appearance")]
        public Color ArrowColor
        {
            get { return _arrowColor; }
            set
            {
                _arrowColor = value;
                this.Invalidate();
            }
        }

        [Description("Color used for the percentage marks"), Category("Appearance")]
        public Color PercentageMarkColor
        {
            get { return _percentageColor; }
            set
            {
                _percentageColor = value;
                this.Invalidate();
            }
        }

        [Description("Sets the width of the percentage marks"), Category("Appearance")]
        public int MarkLineWidth
        {
            get { return _percentageLineWidth; }
            set
            {
                _percentageLineWidth = value;
                this.Invalidate();
            }
        }

        [Description("Sets the angle at which the colors blend into each other"), Category("Appearance")]
        public float ColorAngle
        {
            get { return _colorAngleBackground; }
            set
            {
                _colorAngleBackground = value;
                this.Invalidate();
            }
        }

        [Description("Max angle of the bar"), Category("Appearance")]
        public float SweepAngle
        {
            get { return _sweepAngle; }
            set
            {
                _sweepAngle = value;
                this.Invalidate();
            }
        }

        [Description("Size of the center point of the gauge"), Category("Appearance")]
        public int BallSize
        {
            get { return _ballSize; }
            set
            {
                _ballSize = value;
                this.Invalidate();
            }
        }

        [Description("Size of the base of the pointer, connected to the Ball"), Category("Appearance")]
        public int PointerBase
        {
            get { return _pointerBase; }
            set
            {
                _pointerBase = value;
                this.Invalidate();
            }
        }

        [Description("Height of the text from 0 to 1"), Category("Appearance")]
        public float TextHeightPercentage
        {
            get { return _textHeightPerc; }
            set
            {
                _textHeightPerc = _textHeightPerc > 1 ? 1 : _textHeightPerc;
                _textHeightPerc = value;
                this.Invalidate();
            }
        }

        [Description("Length of the pointer from 0 to 1"), Category("Appearance")]
        public float PointerLengthPercentage
        {
            get { return _percentagePointerLength; }
            set
            {
                _percentagePointerLength = _percentagePointerLength > 1 ? 1 : _percentagePointerLength;
                _percentagePointerLength = value;
                this.Invalidate();
            }
        }

        [Description("Width of the loading bar"), Category("Appearance")]
        public int BarWidth
        {
            get { return _barWidth; }
            set
            {
                _barWidth = value;
                this.Invalidate();
            }
        }

        [Description("Start angle of the bar"), Category("Appearance")]
        public float StartAngle
        {
            get { return _startAngle; }
            set
            {
                _startAngle = value;
                this.Invalidate();
            }
        }

        [Description("Display the min- and maximum values and the start and end of the bar"), Category("Appearance")]
        public bool DisplayMinMax
        {
            get { return _displayMinMax; }
            set
            {
                _displayMinMax = value;
                this.Invalidate();
            }
        }

        [Description("Displays the gauges pointer"), Category("Appearance")]
        public bool DisplayPointer
        {
            get { return _displayPointer; }
            set
            {
                _displayPointer = value;
                this.Invalidate();
            }
        }

        [Description("Display the text for the current value"), Category("Appearance")]
        public bool DisplayText
        {
            get { return _displayText; }
            set
            {
                _displayText = value;
                this.Invalidate();
            }
        }

        [Description("When true, colors the bar according to the current value"), Category("Appearance")]
        public bool ColorLive
        {
            get { return _colorLive; }
            set
            {
                _colorLive = value;
                this.Invalidate();
            }
        }

        [Description("When true, colors the bar according to the current value"), Category("Appearance")]
        public bool DisplayPercentages
        {
            get { return _drawPercentages; }
            set
            {
                _drawPercentages = value;
                this.Invalidate();
            }
        }

        [Description("Sets the angle at which the Main colors blend into each other"), Category("Appearance")]
        public float ColorAngleForeground
        {
            get { return _colorAngleForeground; }
            set
            {
                _colorAngleForeground = value;
                this.Invalidate();
            }
        }

        [Description("Sets the max value which the gauge can display"), Category("Appearance")]
        public double MaxValue
        {
            get { return _maxValue; }
            set
            {
                _maxValue = value;
                this.Invalidate();
            }
        }

        [Description("Sets the bar value"), Category("Data")]
        public double Value
        {
            get { return _value; }
            set
            {
                _value = _value > _maxValue ? _maxValue : _value;
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

        private double tempValue = 0;
        private float valuePercentage = 0.1f;
        private void valueTimer_Tick(object sender, EventArgs e)
        {
            if (valuePercentage > 1)
                valuePercentage = 1;
            if (valuePercentage < 0)
                valuePercentage = 0;
            if (tempValue > _value)
            {
                _value = tempValue * BezierBlend(valuePercentage > 0.9 ? 1 : valuePercentage += 0.1f);
                this.Invalidate();
                return;
            }
            if (tempValue < _value)
            {
                _value = _value * BezierBlend(valuePercentage < 0.1 ? 0 : valuePercentage -= 0.1f);
                this.Invalidate();
                return;
            }
            _value = tempValue;
            this.Invalidate();
            valueTimer.Stop();
        }
    }
}
