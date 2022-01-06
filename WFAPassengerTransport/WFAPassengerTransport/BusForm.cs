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
    public partial class BusForm : Form
    {
        public BusForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try {
                string model = tBBrand.Text;
                string number = tBNumber.Text;
                int year = Convert.ToInt32(tBYear.Text);
                double cost = Convert.ToDouble(tBCostTicket.Text);
                int count = Convert.ToInt32(tBCountPass.Text);
                Transport exampleBus = new Bus(model, year, number, cost, count);
                tBResult.Text = exampleBus.ProfitCalculation().ToString();
            }
            catch (Exception exception) {
                MessageBox.Show(exception.Message, "Ошибка");
            }
        }
    }
}
