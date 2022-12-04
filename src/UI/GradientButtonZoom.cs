using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Program.UI
{
    public class GradientZoom : Guna2GradientButton
    {
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
            Size = new Size(this.Width + 5, this.Height + 5);
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
            Size = new Size(this.Width - 5, this.Height - 5);
            base.OnMouseLeave(e);
        }
    }
}