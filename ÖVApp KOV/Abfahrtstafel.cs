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

            IList<StationBoardViewModel> listArrivals = new List<StationBoardViewModel>();

            foreach (StationBoard arrival in stationBoard.Entries)
            {
                var stationBoardViewModel = new StationBoardViewModel();

                stationBoardViewModel.DeparturePoint = station.Name;
                stationBoardViewModel.DepartureTime = arrival.Stop.Departure.ToShortTimeString();
                stationBoardViewModel.ArrivalPoint = arrival.To;

                listArrivals.Add(stationBoardViewModel);
            }


            dataGrid_Ausgabe.DataSource = listArrivals;

            //dataGrid_Ausgabe.Columns.Add()
        }

    }
}
