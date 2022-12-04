using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.Designer;
using Guna.UI2.WinForms;

namespace Program.UI
{
    public class ButtonZoom : Guna2Button
    {
        private int defaultWidth, defaultHeight;

        public ButtonZoom()
        {
            this.defaultWidth =  (int)(Size.Width - Size.Width * 0.25);
            this.defaultHeight = (int)(Size.Height - Size.Height * 0.2);
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
            Size = new Size(Size.Width+5, Size.Height+5);
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
            this.ForeColor = Color.Black;
            System.Drawing.Size buttonSize = Size;
            Size = new Size(defaultWidth, defaultHeight);
            base.OnMouseLeave(e);
        }
    }
}