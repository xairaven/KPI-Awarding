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
        private int defaultBorderSize, startBorderSize;

        public ButtonZoom()
        {
            this.defaultBorderSize = this.BorderThickness - 5;
            this.startBorderSize = this.BorderThickness + 5;
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnMouseHover(System.EventArgs e)
        {
            this.BorderThickness = startBorderSize;
            this.ForeColor = Color.White;
            base.OnMouseHover(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            this.BorderThickness = startBorderSize;
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }
        protected override void OnMouseLeave(System.EventArgs e)
        {
            this.BorderThickness = defaultBorderSize;
            this.ForeColor = Color.Black;
            base.OnMouseLeave(e);
        }
    }
}