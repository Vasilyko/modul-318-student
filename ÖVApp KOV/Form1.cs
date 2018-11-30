using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;

namespace ÖVApp_KOV
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            UserInput();
        }
        private void UserInput()
        {
            if (comboBox_Abfahrtsort.Text != null)
            {
                var instance = new Transport();
                var stations = instance.GetStations(comboBox_Abfahrtsort.Text);
                //comboBox_Abfahrtsort.DataSource = "";
                comboBox_Abfahrtsort.DisplayMember = "name";
                comboBox_Abfahrtsort.DataSource = stations.StationList;
                comboBox_Abfahrtsort.DroppedDown = true;
            }
            return;
        }

        private void comboBox_Abfahrtsort_TextUpdate(object sender, EventArgs e)
        {
            //UserInput();
        }
        private void Output(string query)
        {

        }
    }
}
