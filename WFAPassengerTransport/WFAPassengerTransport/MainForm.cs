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
    public partial class MainForm : Form
    {
        BusForm busForm = new BusForm();
        TaxiForm taxiForm = new TaxiForm();
        TrainForm trainForm = new TrainForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBus_Click(object sender, EventArgs e)
        {
            busForm.ShowDialog();
        }

        private void btnTaxi_Click(object sender, EventArgs e)
        {
            taxiForm.ShowDialog();
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            trainForm.ShowDialog();
        }
    }
}
