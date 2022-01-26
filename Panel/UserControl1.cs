using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiddleProject.Panel
{
    public partial class SearchOrderPanel : UserControl
    {
        public SearchOrderPanel()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {
            sizeChange();
        }

        void sizeChange()
        {
            
            dataGridView1.Location = new Point(25,65); 
            dataGridView1.Size = new Size((int)(this.Width - 25 * 2 ), (int)((panel3.Height - 65) * 0.9));
        }

        private void UserControl1_SizeChanged(object sender, EventArgs e)
        {
            sizeChange();
        }
    }
}
