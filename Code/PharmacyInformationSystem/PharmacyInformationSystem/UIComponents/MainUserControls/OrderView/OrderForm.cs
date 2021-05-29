using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logic = PharmacyInformationSystem.BusinessLogic;

namespace PharmacyInformationSystem.UIComponents.MainUserControls.OrderView
{
    public partial class OrderForm : Form
    {
        private Logic::Order Order;

        public OrderForm()
        {
            InitializeComponent();
        }

        private void SellerLbl_Click(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void onPaint(object sender, PaintEventArgs e)
        {
            Graphics v = e.Graphics;
            DrawRoundRect(v, Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);
            //Without rounded corners
            //e.Graphics.DrawRectangle(Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        public void DrawRoundRect(Graphics g, Pen p, float X, float Y, float width, float height, float radius)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new GraphicsPath();
            //Upper-right arc:
            gp.AddArc(X + width - (radius * 2), Y, radius * 2, radius * 2, 270, 90);
            //Lower-right arc:
            gp.AddArc(X + width - (radius * 2), Y + height - (radius * 2), radius * 2, radius * 2, 0, 90);
            //Lower-left arc:
            gp.AddArc(X, Y + height - (radius * 2), radius * 2, radius * 2, 90, 90);
            //Upper-left arc:
            gp.AddArc(X, Y, radius * 2, radius * 2, 180, 90);
            gp.CloseFigure();
            g.DrawPath(p, gp);
            gp.Dispose();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
