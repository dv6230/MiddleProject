using System;
using System.Drawing;
using System.Windows.Forms;

namespace MiddleProject
{
    public partial class FrontOperate : Form
    {

        float panel3Width = 0.6f;

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


            flowLayoutPanel1.Controls.Add(new Button());
            flowLayoutPanel1.Controls.Add(new Button());
            flowLayoutPanel1.Controls.Add(new Button());
            flowLayoutPanel1.Controls.Add(new Button());
            flowLayoutPanel1.Controls.Add(new Button());

            panel3.Size = new Size((int)((this.Width - panel1.Width) * panel3Width), this.Height);
            panel4.Size = new Size((int)(this.Width - panel1.Width - panel3.Width), this.Height);
            tabControl1.Size = new Size(panel3.Width, tabControl1.Height);

            userPurchaseItem1.lblNote.Text = "lorem*10 lsafj o jsaodfj fp jw oj727 5373 7838 w jfow jwjofij woj op jw 246489 65 4";
            userPurchaseItem1.lblNote.Height = userPurchaseItem1.lblNote.PreferredHeight;
            userPurchaseItem1.Height = userPurchaseItem1.PreferredSize.Height + 10;
            //userPurchaseItem1.Width = panel4.Width - 75;


        }
      
        private void FrontOperate_SizeChanged(object sender, EventArgs e)
        {
            panel3.Size = new Size((int)((this.Width-panel1.Width)* panel3Width), this.Height);
            panel4.Size = new Size((int)(this.Width - panel1.Width - panel3.Width), this.Height);
            tabControl1.Size = new Size(panel3.Width, tabControl1.Height);
        }
    }
}
