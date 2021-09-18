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
    public partial class ModernCheckBox : UserControl
    {
        private bool _checked = false;
        private Color _mainColor = Color.FromArgb(122, 193, 67);
        private Color _ballColor = Color.FromArgb(202, 204, 209);
        private Color _disabledColor = Color.Gray;
        private Color _borderColor = Color.DimGray;
        private SizeF _size = new SizeF(16, 16);
        private SizeF _ballSize = new SizeF(20, 20);

        /// <summary>
        /// Event to forward the change in checked flag
        /// </summary>
        public event EventHandler CheckedChanged = delegate { };



        public ModernCheckBox()
        {
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
            this.Width = (int)_ballSize.Width * 2 + 5;
            this.Height = (int)_ballSize.Height + 5;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.Paint += ModernCheckBox_Paint;
            this.Click += ModernCheckBox_Click;
            this.BackColorChanged += ModernCheckBox_BackColorChanged;
        }

        private void ModernCheckBox_BackColorChanged(object sender, EventArgs e)
        {
            this._borderColor = this.BackColor;
        }

        private void ModernCheckBox_Click(object sender, EventArgs e)
        {
            if (_checked)
                _checked = false;
            else
                _checked = true;
            CheckedChanged(null, EventArgs.Empty);
            this.Invalidate();
        }

        private void ModernCheckBox_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

            SolidBrush brush = new SolidBrush(_mainColor);
            SolidBrush ballBrush = new SolidBrush(_ballColor);
            SolidBrush borderBrush = new SolidBrush(_borderColor);
            if (!_checked)
                brush = new SolidBrush(_disabledColor);
            float offsetY = Math.Abs(_ballSize.Height / 2 - _size.Height / 2);
            float offsetX = 1;
            int offsetRect = (int)(_size.Width * 0.5);
            g.FillEllipse(brush, new RectangleF(offsetX, offsetY, _size.Width, _size.Height + 0.5f));
            g.FillRectangle(brush, new RectangleF(_size.Width / 2 + offsetX, offsetY + 0.25f, _size.Width + offsetRect, _size.Height + 0.5f));
            g.FillEllipse(brush, new RectangleF(_size.Width + offsetX + offsetRect, offsetY, _size.Width, _size.Height + 0.5f));
            if (_checked)
            {
                g.FillEllipse(borderBrush, Math.Abs(_ballSize.Width - _size.Width * 2) - offsetX + offsetRect, -0.5f, _ballSize.Width + 2, _ballSize.Height + 2);
                g.FillEllipse(ballBrush, Math.Abs(_ballSize.Width - _size.Width * 2) + offsetRect, 0.5f, _ballSize.Width, _ballSize.Height);
            }
            else
            {
                g.FillEllipse(borderBrush, new RectangleF(0, -0.5f, _ballSize.Width + 2, _ballSize.Height + 2));
                g.FillEllipse(ballBrush, new RectangleF(offsetX, 0.5f, _ballSize.Width, _ballSize.Height));
            }
        }

        [Description("Sets the Checked status"), Category("Data")]
        public bool Checked
        {
            get { return _checked; }
            set
            {
                _checked = value;
                CheckedChanged(null, EventArgs.Empty);
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

        [Description("Sets the main color"), Category("Appearance")]
        public Color MainColor
        {
            get { return _mainColor; }
            set
            {
                _mainColor = value;
                this.Invalidate();
            }
        }

        [Description("Sets the disabled color"), Category("Appearance")]
        public Color DisabledColor
        {
            get { return _disabledColor; }
            set
            {
                _disabledColor = value;
                this.Invalidate();
            }
        }

        [Description("Sets the border color of the ball"), Category("Appearance")]
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                this.Invalidate();
            }
        }
    }
}
