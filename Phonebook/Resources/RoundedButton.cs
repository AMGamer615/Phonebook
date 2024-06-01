using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Resources
{
    public partial class RoundedButton : Button
    {
        private int round = 15;
        public int Round
        {
            get
            {
                return round;
            }
            set
            {
                round = value;
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, round, round));
            }
        }

        private Color color;

        private bool colortire = false;

        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nheightRect, int nweightRect);
        public RoundedButton()
        {
            InitializeComponent();
        }

        public RoundedButton(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(4, 4, this.Width-4, this.Height-4, round, round));
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            tire();
        }
        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            roshan();
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            tire();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            roshan();
        }
        private void tire()
        {
            if (!colortire)
            {
                color = this.BackColor;
                colortire = true;
            }

            int x = 20;

            int red = this.BackColor.R - x;
            int green = this.BackColor.G - x;
            int blue = this.BackColor.B - x;

            if (red < 0)
                red = 0;
            if (green < 0)
                green = 0;
            if (blue < 0)
                blue = 0;

            this.BackColor = System.Drawing.Color.FromArgb(red, green, blue);
        }

        private void roshan()
        {
            this.BackColor = color;
        }
    }
}
