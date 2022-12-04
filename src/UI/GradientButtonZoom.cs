using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Program.UI
{
    public class GradientZoom : Guna2GradientButton
    {
        private int defaultBorderSize, startBorderSize;
        
        public GradientZoom()
        {
            this.defaultBorderSize = this.BorderRadius - 5;
            this.startBorderSize = this.BorderRadius + 5;
        }
        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }
        protected override void OnMouseHover(System.EventArgs e)
        {
            this.BorderThickness = startBorderSize;
            this.ForeColor = Color.Black;
            base.OnMouseHover(e);
        }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            Cursor = Cursors.Hand;
            base.OnMouseMove(e);
        }
        protected override void OnMouseLeave(System.EventArgs e)
        {
            this.BorderThickness = defaultBorderSize;
            this.ForeColor = Color.White;
            base.OnMouseLeave(e);
        }
    }
}