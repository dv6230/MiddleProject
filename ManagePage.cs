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
            
        }

        private void ManagePage_SizeChanged(object sender, EventArgs e)
        {
            
        }

        private void 訂單查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var p =  new Panel.UserControl1();
            p.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(p);
        }
    }
}
