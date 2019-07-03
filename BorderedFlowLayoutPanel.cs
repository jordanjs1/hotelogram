using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotelogram
{
    /// <summary>
    /// Defines a FlowLayoutPanel user control with a colored border. Used for button panels located in the bottom of forms and dialogs.
    /// </summary>
    public class BorderedFlowLayoutPanel : FlowLayoutPanel
    {
        private readonly ColorBlend gradientBlender = new ColorBlend(3);
        private Color _BorderColor = Color.Cyan;
        private bool _BorderDraw;
        private int _BorderWidth = 1;
        private bool _GradientEnable = true;
        private LinearGradientMode _GradientMode = LinearGradientMode.Vertical;

        private IContainer components = null;

        [Category("Behavior"),
         Description(
             "Set or Get the gradient colors")]
        public Color[] GradientColors
        {
            get { return gradientBlender.Colors; }
            set
            {
                gradientBlender.Colors[0] = value[0];
                gradientBlender.Colors[1] = value[1];
                gradientBlender.Colors[2] = value[2];
                Invalidate(true);
            }
        }

        [Category("Behavior"),
         Description(
             "Set or Get the lower,center,upper bounds for the gradient brush")]
        public float[] GradientPositions
        {
            get { return gradientBlender.Positions; }
            set
            {
                gradientBlender.Positions[0] = value[0];
                gradientBlender.Positions[1] = value[1];
                gradientBlender.Positions[2] = value[2];
                Invalidate(true);
            }
        }

        [Category("Behavior"), Description("If enabled, gradient will be used.")]
        public bool GradientEnable
        {
            get { return _GradientEnable; }
            set
            {
                _GradientEnable = value;
                Invalidate(true);
            }
        }

        [Description("Sets the color of the border.")]
        public Color BorderColor
        {
            get { return _BorderColor; }
            set
            {
                _BorderColor = value;
                Invalidate(true);
            }
        }

        [Description("Enable or disable the border.")]
        public bool BorderDraw
        {
            get { return _BorderDraw; }
            set
            {
                _BorderDraw = value;
                Invalidate(true);
            }
        }

        [Description("Adjusts the border width.")]
        public int BorderWidth
        {
            get { return _BorderWidth; }
            set
            {
                _BorderWidth = value;
                Invalidate(true);
            }
        }

        [Description("Sets the direction of the gradient.")]
        public LinearGradientMode GradientMode
        {
            get { return _GradientMode; }
            set
            {
                _GradientMode = value;
                Invalidate(true);
            }
        }

        public BorderedFlowLayoutPanel()
        {
            InitializeComponent();
            SetStyle(
                ControlStyles.UserPaint | ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer,
                true);

            gradientBlender.Positions[0] = 0f;
            gradientBlender.Positions[1] = 0.5f;
            gradientBlender.Positions[2] = 1f;


            gradientBlender.Colors[0] = Color.SkyBlue;
            gradientBlender.Colors[1] = Color.DeepSkyBlue;
            gradientBlender.Colors[2] = Color.DodgerBlue;
        }

        protected override void OnResize(EventArgs eventargs)
        {
            base.OnResize(eventargs);
            var rec = new Rectangle(_BorderWidth, _BorderWidth, Width - 2, Height + 2);
            Region = new Region(rec);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;

            if (_GradientEnable)
            {
                var _Drawer = new LinearGradientBrush(ClientRectangle,
                    Color.Black, Color.White, _GradientMode)
                { InterpolationColors = gradientBlender };

                e.Graphics.FillRectangle(_Drawer, 0, 0, Width, Height);
            }
            else
            {
                if (BackgroundImage == null)
                    e.Graphics.FillRectangle(new SolidBrush(BackColor), 0, 0, Width, Height);
            }

            if (_BorderDraw)
                e.Graphics.DrawRectangle(
                    new Pen(new SolidBrush(_BorderColor), _BorderWidth),
                    0,
                    1,
                    Width - 1,
                    Height - 1);

            base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            components = new Container();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
