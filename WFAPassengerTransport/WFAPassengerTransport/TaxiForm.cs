using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAPassengerTransport
{
    public partial class TaxiForm : Form
    {
        public TaxiForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                string model = tBBrand.Text;
                string number = tBNumber.Text;
                int year = Convert.ToInt32(tBYear.Text);
                double cost = Convert.ToDouble(tBCost.Text);
                int discount = Convert.ToInt32(tBDiscount.Text);
                double mileage = Convert.ToDouble(tBMileage.Text);
                Transport exampleTaxi = new Taxi(model, year, number, cost, discount, mileage);
                tBResult.Text = exampleTaxi.ProfitCalculation().ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка");
            }
        }
    }
}
