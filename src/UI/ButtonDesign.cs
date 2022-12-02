using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Program.UI
{
    public class ButtonDesign  : Button
    {
        public static int width, height, borderSize, borderRadius;
        public static Color borderColor, backColor, foreColor;
        public ButtonDesign(int width, int height, Color backColor, Color foreColor)
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(width, height);
            this.BackColor = backColor;
            this.ForeColor = foreColor;
            this.Resize += new EventHandler(Button_Resize);
        }
        
        private void Button_Resize(object sender, EventArgs e)
        {
            if (borderRadius > this.Height)
                borderRadius = this.Height;
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }
        protected override void OnPaint(PaintEventArgs e) 
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = this.ClientRectangle;
            RectangleF rectBorder = RectangleF.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
            {
                smoothSize = borderSize;
            }
            if (borderRadius > 2) 
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius-borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);
                    if (borderSize >= 1)
                    {
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            } 
            else
            {
                e.Graphics.SmoothingMode = SmoothingMode.None;
                this.Region = new Region(rectSurface);
                if (borderSize >= 1)
                {
                    using (Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width-1, this.Height-1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnMouseHover(System.EventArgs e)
        {
            float fontSize = Font.SizeInPoints;
            fontSize += 1;
            System.Drawing.Size buttonSize = Size;
            this.ForeColor = Color.White;
            Size = new System.Drawing.Size(Size.Width+5, Size.Height+5);
            base.OnMouseHover(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }
        protected override void OnMouseLeave(System.EventArgs e)
        {
            float fontSize = Font.SizeInPoints;
            fontSize -= 1;
            System.Drawing.Size buttonSize = Size;
            this.ForeColor = foreColor;
            Size = new System.Drawing.Size(Size.Width-5, Size.Height-5);
            base.OnMouseLeave(e);
        }
    }
}