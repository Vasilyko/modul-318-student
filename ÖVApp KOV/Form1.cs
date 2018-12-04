﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwissTransport;
using System.Windows.Forms;
using System.Diagnostics;
using System.Net.Mail;
using System.IO;

namespace ÖVApp_KOV
{
    public partial class Form1 : Form
    {
        private ITransport transport;
        private Stations stationsArrival;
        private Stations stationsDeparture;


        public Form1()
        {
            System.IO.Stream str = Properties.Resources.ElevatorMusic;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();

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
            btn_Suchen.BackColor = Color.SkyBlue;
            listBox_Ausgabe.Items.Clear();

            //Falls Ankunftsort angegeben wurde, werden die Verbindungen angezeigt
            if (comboBox_Ankunftsort.Text != "" && comboBox_Abfahrtsort.Text != "")
            {

                comboBox_Abfahrtsort.SelectedIndex = 0;
                comboBox_Ankunftsort.SelectedIndex = 0;
                Connections connections = transport.GetConnectionsWithTime(((Station)comboBox_Abfahrtsort.SelectedItem).Name, ((Station)comboBox_Ankunftsort.SelectedItem).Name, dateTimePicker1.Value);


                //Es werden bis zu 4 verbindungen angezeigt
                for (int i = 0; i <= 3; i++)
                {
                    var departure = Convert.ToDateTime(connections.ConnectionList[i].From.Departure);
                    var arrival = Convert.ToDateTime(connections.ConnectionList[i].To.Arrival);

                    
                    var obj = connections.ConnectionList[i].Duration.Split('d');
                    var obj2 = obj[1].Split(':');

                    //sorgt für eine schönere Ausgabe beim benuzer....
                    var customStringDeparture = String.Format("{0} Uhr {1} Minuten", departure.Hour, departure.Minute);
                    var customStringArrival = String.Format("{0} Uhr {1} Minuten", arrival.Hour, arrival.Minute);
                    var customStringDuration = String.Format("{0} Minuten", int.Parse(obj2[0]) * 60 + int.Parse(obj2[1]));
                    //...+das
                    listBox_Ausgabe.Items.Add(customStringDeparture + "               " + customStringDuration + "               " + customStringArrival);
                }
            }
            //Falls nur Abfahrtsort angegeben, sollte Abfahrttafel erscheinen
            else if (comboBox_Abfahrtsort.Text != "" && comboBox_Ankunftsort.Text == "")
            {

                new Form2((Station)comboBox_Abfahrtsort.SelectedItem, transport).Show();


            }

            else
            {
                MessageBox.Show("Bitte geben Sie einen Abfahrtsort ein");
                btn_Suchen.BackColor = Color.Red;
            }
        }
        private void UserInput(ComboBox input, ref Stations stations)
        {

            if (input.Text != string.Empty)
            {

                var text = input.Text;
                var newStations = transport.GetStations(input.Text);

                //ist für Autofill zuständig
                if (newStations.StationList.Count > 0)
                {
                    stations = newStations;
                    input.DataSource = newStations.StationList;
                    input.DroppedDown = true;
                    
                    //da ich Probleme mit der Eingabe hatte, habe ich den text vom benutzer wieder in die Eingabe gesetzt 
                    input.Text = text;
                    input.SelectionStart = text.Length;
                }
            }
            else {

                MessageBox.Show("Es wurde keine Station mit îhrer Eingabe gefunden");
 
                }
        }

        private void comboBox_Abfahrtsort_TextUpdate(object sender, EventArgs e)
        {
            ComboBox input = comboBox_Abfahrtsort;
            UserInput(input, ref stationsDeparture);
            
        }

        private void comboBox_Ankunftsort_TextUpdate(object sender, EventArgs e)
        {
            ComboBox input = comboBox_Ankunftsort;
            UserInput(input, ref stationsArrival);
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            /* Ist für das versenden von mails zuständig
             funktioniert noch nicht einwandfrei*/

            MailMessage message = new MailMessage();
            //SmtpClient smtp = new SmtpClient("192.168.0.113", 25);
            SmtpClient client = new SmtpClient();
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.UseDefaultCredentials = false;
            client.Host = "smtp.gmail.com";

            message.From = new MailAddress("Vasily.kozlov.hasler@gmail.com");
            message.To.Add(new MailAddress("Vasily.kozlov.hasler@gmail.com"));
            message.Subject = "SBB Verbindungen";

            var body = string.Empty;

            foreach (var item in listBox_Ausgabe.Items)
            {
                body += (string)item;
            }

            message.Body = body;

            client.Send(message);
        }

        private void button_Help_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Sie werden mit unserem Kompetentesten Mitarbeiter reden dürfen", "TopHilfe.Vasily", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                System.Diagnostics.Process.Start("https://www.google.com/");
        }

        private void button_Sponoring_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://databerg.rocks/de");
        }
    }
}
