using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VKN
{
    public partial class SalerForm : Form
    {
        public SalerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form goodsDeliveryForm = new GoodsDelivery();
            goodsDeliveryForm.ShowDialog();
        }
    }
}
