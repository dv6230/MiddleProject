using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiddleProject
{
    public partial class ManagePage : Form
    {
        public ManagePage()
        {
            InitializeComponent();
        }

        private void ManagePage_Load(object sender, EventArgs e)
        {
            contentPanel.Size = new Size(this.Width, this.Height - menuStrip1.Height);
            contentPanel.BackColor = Color.Red;
        }

        private void ManagePage_SizeChanged(object sender, EventArgs e)
        {
            contentPanel.Size = new Size(this.Width, this.Height - menuStrip1.Height);
        }
    }
}
