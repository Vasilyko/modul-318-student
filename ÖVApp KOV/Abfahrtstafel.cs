using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ÖVApp_KOV
{
    public partial class Form2 : Form
    {
        private StationBoardRoot stationBoard;
        public Form2()
        {
            InitializeComponent();
        }

        public Form2(Station station, ITransport transport)
        {
            InitializeComponent();
            stationBoard =  transport.GetStationBoard(station.Name, station.Id);

            foreach (StationBoard arrival in stationBoard.Entries)
            {
                listBoxStationBoard.Items.Add(station.Name + "\t" + "\t" +  arrival.To + "\t" + "\t" +arrival.Stop.Departure);
            }

            

        }

    }
}
