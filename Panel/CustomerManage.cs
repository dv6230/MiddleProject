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
    public partial class CustomerManage : UserControl
    {

        Model.Customer customer;
        public delegate void CustomerManageDelegate();
        public CustomerManageDelegate method; 

        public CustomerManage()
        {
            InitializeComponent();
        }

        private void CustomerManage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string phone = txtPhone.Text; 
            var ls = Model.GolbalVar.db.Queryable<Model.Customer>().Where(item=>item.phone == phone).ToList();
            if (ls.Count == 0)
            {
                MessageBox.Show("查無資料");
                return;
            }
            customer = ls[0];
            tBoxName.Text = customer.name;
            tBoxEmail.Text = customer.email;
            tBoxAddress.Text = customer.address;
            tpBirth.Value = customer.birth;
            if (customer.gender == 1)
            {
                radioButton1.Checked = true;
            }else
            {
                radioButton2.Checked = true;
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (this.customer == null)
            {
                MessageBox.Show("無資料");
                return;
            }
            customer.name = tBoxName.Text;
            customer.email = tBoxEmail.Text;    
            customer.address= tBoxAddress.Text;
            customer.birth = tpBirth.Value;
            customer.gender = radioButton1.Checked == true ? 1 : 0 ;
            customer.phone = txtPhone.Text;
            Console.WriteLine(customer.birth);
            Model.GolbalVar.db.Updateable(customer).ExecuteCommand();
            MessageBox.Show("更改成功");
            this.customer = null;
            method();
            this.Dispose();
        }
    }
}
