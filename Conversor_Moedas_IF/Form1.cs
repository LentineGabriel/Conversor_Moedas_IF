using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Proxies;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_Moedas_IF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //btn1
            btnEscolha.Items.Add("Real Brasileiro");
            btnEscolha.Items.Add("Dolar Americano");
            btnEscolha.Items.Add("Euro");
            btnEscolha.Items.Add("Libra Esterlina (Inglaterra)");

            //btn2
            btnEscolha2.Items.Add("Real Brasileiro");
            btnEscolha2.Items.Add("Dolar Americano");
            btnEscolha2.Items.Add("Euro");
            btnEscolha2.Items.Add("Libra Esterlina (Inglaterra)");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string moedaOrigem = btnEscolha.SelectedItem.ToString();
            string moedaDestino = btnEscolha2.SelectedItem.ToString();

            if (double.TryParse(txtValorRec.Text, out double valor))
            {
                double resultado = ConverterMoeda(moedaOrigem, moedaDestino, valor);
                txtResultado.Text = "Valor convertido: " + resultado.ToString();
            }
            else MessageBox.Show("Insira um valor válido");
        }

        private double ConverterMoeda(string origem, string destino, double valor)
        {
            double taxaCambio = 1.0;

            //Real/Dolar
            if (origem == "Real Brasileiro" && destino == "Dolar Americano")
            {
                taxaCambio = 0.18;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }
            if (origem == "Dolar Americano" && destino == "Real Brasileiro")
            {
                taxaCambio = 5.54;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }

            // Real/Euro
            if (origem == "Real Brasileiro" && destino == "Euro")
            {
                taxaCambio = 0.17;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }
            if (origem == "Euro" && destino == "Real Brasileiro")
            {
                taxaCambio = 6.04;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }

            //Real/Libra Esterlina
            if (origem == "Real Brasileiro" && destino == "Libra Esterlina") 
            {
                taxaCambio = 0.14;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }
            if (origem == "Libra Esterlina" && destino == "Real Brasileiro")
            {
                taxaCambio = 7.18;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }

            //Dolar/Libra Esterlina
            if (origem == "Dolar Americano" && destino == "Libra Esterlina")
            {
                taxaCambio = 0.77;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }
            if(origem == "Libra Esterlina" && destino == "Dolar Americano")
            {
                taxaCambio = 1.29;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }

            //Dolar/Euro
            if (origem == "Dolar Americano" && destino == "Euro")
            {
                taxaCambio = 0.92;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }
            if (origem == "Euro" && destino == "Dolar Americano")
            {
                taxaCambio = 1.09;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }

            //Libra Esterlina/Euro
            if (origem == "Libra Esterlina" && destino == "Euro")
            {
                taxaCambio = 1.19;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }
            if(origem == "Euro" && destino == "Libra Esterlina")
            {
                taxaCambio = 0.84;
                txtInfo.Text = "A taxa de câmbio é: " + taxaCambio.ToString();
            }

            return valor * taxaCambio;
        }
    }
}
