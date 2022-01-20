using System;
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
            var a = menuStrip1.Items;
            Console.WriteLine(a);
            foreach (var item in a)
            {
                var t = (ToolStripMenuItem)item;
                Console.WriteLine(t.Text);
                if (t.Text.Equals("庫存"))
                {
                    t.Visible = false; 
                }
            }
        }

        private void ManagePage_SizeChanged(object sender, EventArgs e)
        {

        }

        private void 訂單查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var p = new Panel.UserControl1();
            p.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(p);
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
