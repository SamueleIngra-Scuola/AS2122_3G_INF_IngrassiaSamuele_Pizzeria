using System;
using System.Windows.Forms;

namespace AS2122_3G_INF_IngrassiaSamuele_Pizzeria
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnOrdina_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtQuantita.Text) || string.IsNullOrEmpty(cmbTipoPizza.Text))
                MessageBox.Show("Riempi tutti i campi!");
            else
            {
                int quantita = Convert.ToInt32(txtQuantita.Text);
                string pizza = cmbTipoPizza.Text;
                
                switch (pizza)
                {
                    case "Pizza Margherita":
                        lstRiepilogo.Items.Add($"{quantita}x {pizza}");
                        lblQuantitaMargherite.Text = Convert.ToString(Convert.ToInt32(lblQuantitaMargherite.Text) + quantita);
                        break;
                    case "Pizza Marinara":
                        lstRiepilogo.Items.Add($"{quantita}x {pizza}");
                        lblQuantitaMarinare.Text = Convert.ToString(Convert.ToInt32(lblQuantitaMarinare.Text) + quantita);
                        break;
                    case "Pizza Wurstel":
                        lstRiepilogo.Items.Add($"{quantita}x {pizza}");
                        lblQuantitaWurstel.Text = Convert.ToString(Convert.ToInt32(lblQuantitaWurstel.Text) + quantita);
                        break;
                    default:
                        MessageBox.Show("Questa pizza non esiste nel nostro menù");
                        break;

                }
            }     
        }
    }
}
