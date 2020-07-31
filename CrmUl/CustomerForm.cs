using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUl
{
    public partial class CustomerForm : Form
    {
        public Customer Customer { get; set; }
        public CustomerForm()
        {
            InitializeComponent();
        }

        public CustomerForm(Customer customer) : this()
        {
            Customer = customer;
            textBox1.Text = customer.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = Customer ?? new Customer();
            p.Name = textBox1.Text;
         

            Close();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {

        }

      

       
    }
}
