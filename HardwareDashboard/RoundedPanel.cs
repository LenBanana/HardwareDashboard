using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using System.Collections;
using System.Drawing.Design;

namespace CircleLoadingBar
{
    [Designer(typeof(MyUserControlDesigner))]
    public partial class RoundedPanel : UserControl
    {
        private Size size = new Size(100, 100);
        private Color _backColor = Color.DimGray;
        private int _cornerRadius = 10;
        private bool[] _enabledCorners = { true, true, true, true };
        public RoundedPanel()
        {
            this.SetStyle(ControlStyles.AllPaintingInWmPaint
   | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            _backColor = this.BackColor;
            size = new Size(this.Width, this.Height);
            InitializeComponent();
            TypeDescriptor.AddAttributes(this.panel1,
                new DesignerAttribute(typeof(MyPanelDesigner)));
            this.Paint += RoundedPanel_Paint;
            this.SizeChanged += RoundedPanel_SizeChanged;
            panel1.Paint += Panel1_Paint;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            int width = size.Width;
            int height = size.Height;
            Graphics g = e.Graphics;
            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            Brush backBrush = new SolidBrush(this.BackColor);
            Brush parentBrush = new SolidBrush(_backColor);
            //Angles
            //Top Left
            if (_enabledCorners[0])
            {
                g.FillRectangle(parentBrush, -1, -1, _cornerRadius - 1, _cornerRadius - 1);
                g.FillPie(backBrush, new Rectangle(-1, -1, _cornerRadius * 2, _cornerRadius * 2), 180F, 90F);
            }
            //Top Right
            if (_enabledCorners[1])
            {
                g.FillRectangle(parentBrush, width - _cornerRadius + 1, -1, _cornerRadius, _cornerRadius - 1);
                g.FillPie(backBrush, new Rectangle(width - _cornerRadius * 2, -1, _cornerRadius * 2, _cornerRadius * 2), 270F, 90F);
            }
            //Bottom Right
            if (_enabledCorners[2])
            {
                g.FillRectangle(parentBrush, width - _cornerRadius + 1, height - _cornerRadius + 1, _cornerRadius - 1, _cornerRadius - 1);
                g.FillPie(backBrush, new Rectangle(width - _cornerRadius * 2, height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2), 0F, 90F);
            }
            //Bottom Left
            if (_enabledCorners[3])
            {
                g.FillRectangle(parentBrush, -1, height - _cornerRadius + 1, _cornerRadius - 1, _cornerRadius - 1);
                g.FillPie(backBrush, new Rectangle(-1, height - _cornerRadius * 2, _cornerRadius * 2, _cornerRadius * 2), 90F, 90F);
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public Panel ContentsPanel
        {
            get { return panel1; }
        }

        private void RoundedPanel_SizeChanged(object sender, EventArgs e)
        {
            size = new Size(this.Width, this.Height);
        }

        protected override void OnParentChanged(EventArgs e)
        {
            if (this.Parent != null)
            {
                _backColor = this.Parent.BackColor;
            }
            base.OnParentChanged(e);
        }
        protected override void OnParentBackColorChanged(EventArgs e)
        {
            _backColor = this.Parent.BackColor;
            base.OnParentBackColorChanged(e);
        }

        private void RoundedPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        [Description("Sets the corner radius of the panel"), Category("Appearance")]
        public int CornerRadius
        {
            get { return _cornerRadius; }
            set
            {
                _cornerRadius = value;
                this.Invalidate();
            }
        }

        [Description("Enables or disables the corners"), Category("Appearance")]
        public bool[] Corners
        {
            get { return _enabledCorners; }
            set
            {
                _enabledCorners = value;
                this.Invalidate();
            }
        }
    }


    public class MyPanelDesigner : ParentControlDesigner
    {
        public override SelectionRules SelectionRules
        {
            get
            {
                SelectionRules selectionRules = base.SelectionRules;
                selectionRules &= ~SelectionRules.AllSizeable;
                return selectionRules;
            }
        }
        protected override void PostFilterAttributes(IDictionary attributes)
        {
            base.PostFilterAttributes(attributes);
            attributes[typeof(DockingAttribute)] =
                new DockingAttribute(DockingBehavior.Never);
        }
        protected override void PostFilterProperties(IDictionary properties)
        {
            base.PostFilterProperties(properties);
            var propertiesToRemove = new string[] {
            "Dock", "Anchor", "Size", "Location", "Width", "Height",
            "MinimumSize", "MaximumSize", "AutoSize", "AutoSizeMode",
            "Visible", "Enabled",
        };
            foreach (var item in propertiesToRemove)
            {
                if (properties.Contains(item))
                    properties[item] = TypeDescriptor.CreateProperty(this.Component.GetType(),
                        (PropertyDescriptor)properties[item],
                        new BrowsableAttribute(false));
            }
        }
    }

    public class MyUserControlDesigner : ParentControlDesigner
    {
        public override void Initialize(IComponent component)
        {
            base.Initialize(component);
            var contentsPanel = ((RoundedPanel)this.Control).ContentsPanel;
            this.EnableDesignMode(contentsPanel, "ContentsPanel");
        }
        public override bool CanParent(Control control)
        {
            return false;
        }
        protected override void OnDragOver(DragEventArgs de)
        {
            de.Effect = DragDropEffects.None;
        }
        protected override IComponent[] CreateToolCore(ToolboxItem tool, int x,
            int y, int width, int height, bool hasLocation, bool hasSize)
        {
            return null;
        }
    }
}
