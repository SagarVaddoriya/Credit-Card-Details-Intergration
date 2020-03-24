using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MTSagarVaddoriya
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Card card = Form1.CardInfo;

             lblDetail.Text =   card.ToString();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
