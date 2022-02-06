﻿using System;
using System.Windows.Forms;

namespace MiddleProject
{
    public partial class ManagePage : Form
    {

        public FrontSide frontSide { get; set; }

        public ManagePage()
        {
            InitializeComponent();
        }

        private void ManagePage_Load(object sender, EventArgs e)
        {
            var a = menuStrip1.Items;
        }

        private void ManagePage_SizeChanged(object sender, EventArgs e)
        {

        }

        private void 訂單查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var p = new Panel.SearchOrderPanel();
            p.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(p);
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void 新增配料ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var p = new Panel.IngredientAdd();
            p.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(p);
        }

        private void 配料管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var p = new Panel.IngredientManage();
            p.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(p);
        }

        private void 新增商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var p = new Panel.AddProduct();
            p.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(p);
        }

        private void 類別管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var p = new Panel.ProductTypePanel();
            p.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(p);
        }



        private void ManagePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (frontSide != null)
            {
                new Initialization();
                frontSide.ReFreshProduct();
            }
        }

        private void 管理商品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();
            var p = new Panel.ProductManage();
            p.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(p);
        }
    }
}
