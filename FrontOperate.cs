using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiddleProject
{
    public partial class FrontOperate : Form
    {

        float panel3Width = 0.55f;

        public FrontOperate()
        {
            InitializeComponent();
        }

        private void FrontOperate_Load(object sender, EventArgs e)
        {

            TabPage tpg = new TabPage();
            tpg.Location = new System.Drawing.Point(4, 25);
            tpg.Name = "tabPage3";
            tpg.Padding = new System.Windows.Forms.Padding(3);
            tpg.Size = new System.Drawing.Size(192, 71);
            tpg.TabIndex = 0;
            tpg.Text = "tabPage3";
            tpg.UseVisualStyleBackColor = true;
            tabControl1.Controls.Add(tpg);


            for (int i = 0; i < 10; i++)
            {
                var p = new Panel.UserPurchaseItem();
                p.numberLabel.Text = (i + 1).ToString();
                if (i % 2 == 0 && i % 3 > 0) { p.BackColor = Color.FromArgb(179, 204, 255); }
                else if (i % 3 == 0) { p.BackColor = Color.FromArgb(179, 236, 255); }
                p.lblNote.Text = (i + new Random().Next(10, 1000)).GetHashCode().ToString() ;
                panel4.Controls.Add(p);
            }


            flowLayoutPanel1.Controls.Add(new Button());
            flowLayoutPanel1.Controls.Add(new Button());
            flowLayoutPanel1.Controls.Add(new Button());
            flowLayoutPanel1.Controls.Add(new Button());
            flowLayoutPanel1.Controls.Add(new Button());

            panel3.Size = new Size((int)((this.Width - panel1.Width) * panel3Width), this.Height);
            panel4.Size = new Size((int)(this.Width - panel1.Width - panel3.Width), this.Height);
            tabControl1.Size = new Size(panel3.Width, tabControl1.Height);


        }

        private void FrontOperate_SizeChanged(object sender, EventArgs e)
        {
            panel3.Size = new Size((int)((this.Width - panel1.Width) * panel3Width), this.Height);
            panel4.Size = new Size((int)(this.Width - panel1.Width - panel3.Width), this.Height);
            tabControl1.Size = new Size(panel3.Width, tabControl1.Height);
        }

        private void btnCloseSystem_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("確定關閉嗎?","確認",MessageBoxButtons.YesNo);
            if (a == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // this.Hide();
            var manage = new ManagePage();
            manage.Closed += (s, args) => this.Close();
            manage.Show();
        }
    }
}
