using CrmBl.Model;
using System;
using System.Windows.Forms;

namespace CrmUl
{
    public partial class SellerForm : Form
    {
        public Seller Seller { get; set; }
        public SellerForm()
        {
            InitializeComponent();
        }

        public SellerForm(Seller seller) : this()
        {
            Seller = seller;
            textBox1.Text = seller.Name;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = Seller ?? new Seller();
            p.Name = textBox1.Text;
          

            Close();
        }

        
        private void SellerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
