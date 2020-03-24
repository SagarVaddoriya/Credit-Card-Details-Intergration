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
    public partial class Form1 : Form
    {

        public static Card CardInfo { get; set; }
        public Form1()
        {
            InitializeComponent();



            btnProceed.Enabled = false;
            txtNumber.TextChanged += Team1Q2_TextChanged;
            txtName.TextChanged += Team1Q2_TextChanged;
            txtCvv.TextChanged += Team1Q2_TextChanged;

        }
        private void Team1Q2_TextChanged(object sender, EventArgs e)
        {
            
            
            if (txtName.Text == "" || txtNumber.Text == "" || txtCvv.Text == "" || cmbMonth.SelectedItem == null || cmbYear.SelectedItem == null)
            {
                btnProceed.Enabled = false;
            }
            else
            {
                btnProceed.Enabled = true;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        
        private void btnProceed_Click(object sender, EventArgs e)
        {
            Card card = new Card();
           
            card.Name = txtName.Text;
            card.Number = long.Parse(txtNumber.Text);
            card.Ccv = int.Parse(txtNumber.Text);
            var month = cmbMonth.SelectedItem.ToString();
            var year = cmbYear.SelectedItem.ToString();
            card.ExpirtyDate = month + "/" + year;
            if(rdoVisa.Checked)
            {
                card.TypeOfCard = CardType.Visa;
 
            }
            else
            {
                card.TypeOfCard = CardType.MasterCard;
            }
           
            CardInfo = card;

          
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to quit?", "Quit?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // if NO is clicked, cancel the "Closing" event
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
