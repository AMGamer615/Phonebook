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
    public partial class RoundedComboBox : ComboBox
    {
        [DefaultValue(HorizontalAlignment.Left)]
        [Localizable(true)]
        public HorizontalAlignment TextAlign { get; set; }

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

        [DllImport("gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nheightRect, int nweightRect);

        public RoundedComboBox()
        {
            InitializeComponent();
            this.DrawMode = DrawMode.OwnerDrawFixed;
            this.DropDownStyle = ComboBoxStyle.DropDownList;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, round, round));
        }

        public RoundedComboBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, round, round));
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, round, round));
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(2, 3, this.Width, this.Height, round, round));
        }

        private string _placeholderText;

        public string PlaceholderText
        {
            get { return _placeholderText; }
            set
            {
                _placeholderText = value;
            }
        }

        protected override void OnDrawItem(DrawItemEventArgs e)
        {
            base.OnDrawItem(e);

            string text = PlaceholderText;

            if (e.Index >= 0)
            {
                text = this.Items[e.Index].ToString();
                this.ForeColor = Color.Black;
            }
            else
            {
                this.ForeColor = Color.Gray;

            }
            TextFormatFlags flags = TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter;
            TextRenderer.DrawText(e.Graphics, text, e.Font, e.Bounds, e.ForeColor, flags);
            e.DrawFocusRectangle();
        }
    }
}
