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
        private ITransport transport;
        private Stations stationsArrival;
        private Stations stationsDeparture;

        public Form1()
        {
            InitializeComponent();

            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Value = DateTime.Now;

            transport = new Transport();
            stationsArrival = new Stations();
            stationsDeparture = new Stations();
            stationsArrival.StationList = new List<Station>();
            stationsDeparture.StationList = new List<Station>();


            comboBox_Abfahrtsort.DataSource = stationsDeparture.StationList;
            comboBox_Abfahrtsort.DisplayMember = "name";
            comboBox_Ankunftsort.DataSource = stationsArrival.StationList;
            comboBox_Ankunftsort.DisplayMember = "name";

        }

        private void btn_Suchen_Click(object sender, EventArgs e)
        {
            if (comboBox_Ankunftsort.Text != "" && comboBox_Abfahrtsort.Text != "") { 

            Connections connections = transport.GetConnectionsWithTime(((Station)comboBox_Abfahrtsort.SelectedItem).Name, ((Station)comboBox_Ankunftsort.SelectedItem).Name, dateTimePicker1.Value);

            for(int i = 0; i <= 3; i++)
                {
                    var departure = Convert.ToDateTime(connections.ConnectionList[i].From.Departure);
                    var arrival = Convert.ToDateTime(connections.ConnectionList[i].To.Arrival);

                    var obj = connections.ConnectionList[i].Duration.Split('d');
                    var obj2 = obj[1].Split(':');

                    var customStringDeparture = String.Format("{0} Uhr {1} Minuten", departure.Hour, departure.Minute);
                    var customStringArrival = String.Format("{0} Uhr {1} Minuten", arrival.Hour, arrival.Minute);
                    var customStringDuration = String.Format("{0} Minuten", int.Parse(obj2[0]) * 60 + int.Parse(obj2[1]));

                    listBox_Ausgabe.Items.Add(customStringDeparture + "\t" + customStringDuration + "\t" + customStringArrival);
                }
        }
            else if (comboBox_Abfahrtsort.Text != "" && comboBox_Ankunftsort.Text == "") {

               new Form2((Station)comboBox_Abfahrtsort.SelectedItem, transport).Show();
               

            }
        }
        private void UserInput(ComboBox Input, ref Stations stations)
        {
            if (Input.Text != string.Empty)
            {
                var text = Input.Text;
                var newStations = transport.GetStations(Input.Text);
                if(newStations.StationList.Count > 0)
                {   
                    stations = newStations;
                    Input.DataSource = newStations.StationList;
                    Input.DroppedDown = true;
                    Input.Text = text;
                    Input.SelectionStart = text.Length;
                }
            }
        }

        private void comboBox_Abfahrtsort_TextUpdate(object sender, EventArgs e)
        {
            
            ComboBox Input = comboBox_Abfahrtsort;

            UserInput(Input, ref stationsDeparture);
        }
        private void Output(string query)
        {

        }

        private void comboBox_Ankunftsort_TextUpdate(object sender, EventArgs e)
        {
            ComboBox Input = comboBox_Ankunftsort;
            UserInput(Input, ref stationsArrival);
        }
    }
}
