using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace HardwareDashboard
{
    public partial class MultilevelLineGraph : UserControl
    {

        private List<List<float>> _values = new List<List<float>>() { new List<float>() { 25, 30, 15, 50, 20, 70, 75, 100 }, new List<float>() { 75, 15, 33, 22, 77, 55, 65, 30 } };
        private int _maxDisplay = 50;
        private bool _fill = true;
        private bool _dots = true;
        private bool _outlineLeft = true;
        private bool _outlineBottom = true;
        private bool _graphlines = true;
        private bool _displayValues = true;
        private bool _displayLegend = true;
        private List<Color> colors = new List<Color>();
        private Random rnd = new Random();
        private Color _textColor = Color.GhostWhite;
        private Color _backgroundOutline = Color.Black;
        private Color _graphLine = Color.Gray;
        private List<string> _captions = new List<string>();
        List<KeyValuePair<PointF, float>> pair = new List<KeyValuePair<PointF, float>>();
        ToolTip tooltip = new ToolTip();
        Point? prevPosition = null;
        Point? currentMousePos = null;

        public MultilevelLineGraph()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty
             | BindingFlags.Instance | BindingFlags.NonPublic, null,
             mainPanel, new object[] { true });
            mainPanel.Paint += MultilevelLineGraph_Paint;
            mainPanel.MouseMove += MultilevelLineGraph_MouseMove;
            legendPanel.Paint += LegendPanel_Paint;
            this.ForeColorChanged += MultilevelLineGraph_ForeColorChanged;
        }

        private void MultilevelLineGraph_ForeColorChanged(object sender, EventArgs e)
        {
            _textColor = this.ForeColor;
        }

        private void LegendPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            int i = 0;
            foreach (Color col in colors)
            {
                if (_captions.Count > i)
                {
                    Rectangle rect = new Rectangle(10, 10 + 20 * i, 10, 10);
                    g.FillRectangle(new SolidBrush(col), rect);
                    g.DrawString(_captions[i], this.Font, new SolidBrush(_textColor), new PointF(25, 10 + 20 * i++));
                }
            }
        }

        private void MultilevelLineGraph_MouseMove(object sender, MouseEventArgs e)
        {
            currentMousePos = e.Location;
            if (prevPosition.HasValue && currentMousePos == prevPosition.Value)
                return;
            tooltip.RemoveAll();
            prevPosition = currentMousePos;
            foreach (var result in pair)
            {
                var pointXPixel = result.Key.X;
                var pointYPixel = result.Key.Y;

                // check if the cursor is really close to the point (2 pixels around the point)
                if (Math.Abs(currentMousePos.Value.X - pointXPixel) < 2 &&
                    Math.Abs(currentMousePos.Value.Y - pointYPixel) < 2)
                {
                    tooltip.Show(result.Value.ToString(), this,
                                    currentMousePos.Value.X, currentMousePos.Value.Y - 15);
                }
            }
        }
        public Color RandomColor()
        {
            return Color.FromArgb(rnd.Next(40, 156), rnd.Next(40, 256), rnd.Next(40, 256));
        }
        private void MultilevelLineGraph_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            int width = mainPanel.Width - 10;
            int height = mainPanel.Height - 10;
            PointF drawPoint = new PointF(0, 0);
            PointF nextPoint = new PointF(0, 0);
            float curVal = 0;
            float curValNext = 0;
            float maxVal = 100;
            float levelMax = 120;
            if (_values.Count > 0 && _values.Count(x => x.Count > 0) > 0)
            {
                maxVal = _values.SelectMany(x => x).Max();
                levelMax = (float)Math.Ceiling(maxVal * 1.2);
            }
            SizeF stringSize = System.Windows.Forms.TextRenderer.MeasureText(maxVal.ToString("0.00"), this.Font);
            PointF origin = new PointF(stringSize.Width, 10);
            if (!_displayValues)
                origin.X = 10;

            for (float i = 0.0F; i < 1.0; i += 0.1F)
            {
                if (_graphlines)
                    g.DrawLine(new Pen(new SolidBrush(_graphLine), 1), new PointF(origin.X, 2 + origin.Y + ((height - origin.Y) * i)), new PointF(width + origin.X, 2 + origin.Y + ((height - origin.Y) * i)));
                if (_displayValues)
                    g.DrawString((levelMax - (levelMax * i)).ToString("0.00"), this.Font, new SolidBrush(_textColor), new PointF(0, origin.Y + 2 + ((height - origin.Y) * i)));
            }

            if (_values.Count != 0)
            {
                _values.ForEach(x => x.Add(levelMax));
                for (int col = 0; col < _values.Count; col++)
                {
                    if (_values[col].Count <= 2)
                        continue;
                    if (_maxDisplay != 0 && _values[col].Count > _maxDisplay)
                        _values[col] = _values[col].GetRange(_values[col].Count - _maxDisplay, _maxDisplay);
                    float steps = (width - 5) / (float)(_values[col].Count - 2);
                    steps = steps == 0 ? 2 : steps;
                    if (colors.Count < _values.Count)
                    {
                        colors.Add(RandomColor());
                        legendPanel.Invalidate();
                    }
                    for (int row = 0; row < _values[col].Count; row++)
                    {
                        curVal = _values[col][row];
                        float curStep = steps * row + origin.X + 1;
                        float perc = curVal / levelMax;
                        if (_values[col].Count > row + 1)
                        {
                            curValNext = _values[col][row + 1];
                            float percNext = curValNext / levelMax;
                            float Height = (height - origin.Y) - ((height - origin.Y) * perc);
                            float HeightNext = (height - origin.Y) - ((height - origin.Y) * percNext);
                            drawPoint = new PointF(curStep, Height + origin.Y);
                            nextPoint = new PointF((curStep + steps), HeightNext + origin.Y);

                            pair.Add(new KeyValuePair<PointF, float>(drawPoint, curVal));
                            if (curValNext == levelMax)
                                continue;
                            g.DrawLine(new Pen(colors[col], 2), drawPoint, nextPoint);
                            if (_fill)
                            {
                                PointF[] points = new PointF[] { new PointF(drawPoint.X - 0.15f, drawPoint.Y), new PointF(drawPoint.X - 0.15f, height), new PointF(nextPoint.X, height), nextPoint };
                                g.FillPolygon(new SolidBrush(Color.FromArgb(100, colors[col].R, colors[col].G, colors[col].B)), points);
                            }
                            if (_dots)
                            {
                                g.FillEllipse(new SolidBrush(colors[col]), nextPoint.X - 2, nextPoint.Y - 2, 4, 4);
                            }
                        }
                    }
                    _values.ForEach(x => x.Remove(levelMax));
                }
            }
            if (_outlineLeft)
                g.DrawLine(new Pen(new SolidBrush(_backgroundOutline), 3), new PointF(origin.X, origin.Y - 2), new PointF(origin.X, height + 3));
            if (_outlineBottom)
                g.DrawLine(new Pen(new SolidBrush(_backgroundOutline), 3), new PointF(origin.X, height + 2), new PointF(width + origin.X, height + 2));
        }

        [Description("Values used for the graph"), Category("Appearance")]
        public List<List<float>> Values
        {
            get { return _values; }
            set
            {
                _values = value;
                mainPanel.Invalidate();
            }
        }

        [Description("Max datapoints to display at the same time. 0 for infinite."), Category("Appearance")]
        public int MaxDisplay
        {
            get { return _maxDisplay; }
            set
            {
                _maxDisplay = value;
                mainPanel.Invalidate();
            }
        }

        [Description("Color of the outline of the graph"), Category("Appearance")]
        public Color GraphOutline
        {
            get { return _backgroundOutline; }
            set
            {
                _backgroundOutline = value;
                mainPanel.Invalidate();
            }
        }

        [Description("Color of the inner lines of the graph"), Category("Appearance")]
        public Color GraphLines
        {
            get { return _graphLine; }
            set
            {
                _graphLine = value;
                mainPanel.Invalidate();
            }
        }

        [Description("Adds a caption to the legend"), Category("Appearance")]
        public List<string> Captions
        {
            get { return _captions; }
            set
            {
                _captions = value;
                mainPanel.Invalidate();
            }
        }

        [Description("Display the legend"), Category("Appearance")]
        public bool DisplayLegend
        {
            get { return _displayLegend; }
            set
            {
                _displayLegend = value;
                if (!DisplayLegend)
                    mainPanel.Width = this.Width - 25;
                else if(DisplayLegend && mainPanel.Width == (this.Width - 25))
                    mainPanel.Width = mainPanel.Width - legendPanel.Width;
                mainPanel.Invalidate();
            }
        }

        [Description("Display left outline"), Category("Appearance")]
        public bool OutlineLeft
        {
            get { return _outlineLeft; }
            set
            {
                _outlineLeft = value;
                mainPanel.Invalidate();
            }
        }

        [Description("Display bottom outline"), Category("Appearance")]
        public bool OutlineBottom
        {
            get { return _outlineBottom; }
            set
            {
                _outlineBottom = value;
                mainPanel.Invalidate();
            }
        }

        [Description("Display text"), Category("Appearance")]
        public bool DisplayText
        {
            get { return _displayValues; }
            set
            {
                _displayValues = value;
                mainPanel.Invalidate();
            }
        }

        [Description("Displays dots at data points"), Category("Appearance")]
        public bool DisplayDots
        {
            get { return _dots; }
            set
            {
                _dots = value;
                mainPanel.Invalidate();
            }
        }

        [Description("Fills the transparent background of the graphs"), Category("Appearance")]
        public bool FillBackground
        {
            get { return _fill; }
            set
            {
                _fill = value;
                mainPanel.Invalidate();
            }
        }

        [Description("Display percentage lines"), Category("Appearance")]
        public bool PercentageLines
        {
            get { return _graphlines; }
            set
            {
                _graphlines = value;
                mainPanel.Invalidate();
            }
        }
    }
}
