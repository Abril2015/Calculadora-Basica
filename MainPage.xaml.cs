using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraBasica
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            pkOper.Items.Add("Suma");
            pkOper.Items.Add("Resta");
            pkOper.Items.Add("Multiplicacion");
            pkOper.Items.Add("Division");

        }

        private void pkOper_SelectedIndexChanged(object sender, EventArgs e)
        {
            String op = pkOper.SelectedItem.ToString();
            int d1 = Int32.Parse(txtD1.Text);
            int d2 = Int32.Parse(txtD2.Text);
            double res = 0;

            if (op == "Suma")
                res = d1 + d2;
            else if (op == "Resta")
                res = d1 - d2;
            else if (op == "Multiplicacion")
                res = d1 * d2;
            else if (op == "Division")
                res = d1 / d2;

            lblRes.Text = res + "";
        }
    }
}
