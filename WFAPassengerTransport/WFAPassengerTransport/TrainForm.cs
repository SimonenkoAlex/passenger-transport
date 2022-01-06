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
    public partial class TrainForm : Form
    {
        public TrainForm()
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
                string type = cBWagons.Text.ToLower();
                double cost = Convert.ToDouble(tBCost.Text);
                Transport exampleTrain = new ElectricTrain(model, year, number, type, cost);
                tBResult.Text = exampleTrain.ProfitCalculation().ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Ошибка");
            }
        }
    }
}
