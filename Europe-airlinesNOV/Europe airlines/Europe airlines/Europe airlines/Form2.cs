using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Europe_airlines
{
    public partial class Form2 : Form
    {
        //declare variables
        public string name;
        public int count = 100;
        private Airport airport;
        private List<Airport> allAirports = new List<Airport>();
        Form1 form;

        public Form2( Form1 fo)
        {
            InitializeComponent();
            form = fo;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //fills the comboBox with all available destinations
            foreach (Airport ap in form.myAirport)
            {
                if (ap.name != lb_AirportLocation.Text)
                this.cBox_desiredDestination.Items.Add(ap.name);     
            }
            
        }

        private void Form2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            
        }

        private void AddAirplane_Click(object sender, EventArgs e)
        {
           //Adds the airplane to the Database and updates the list
            airport.AddcurrentAirplane(tb_CompanyName.Text.ToString());
            airport.currentAirplanesInAirport = airport.GetCurrentAirplanes(airport.name);
            this.lb_Airplanes.Items.Clear();
            foreach (Airplane a in airport.currentAirplanesInAirport)
            {
                lb_Airplanes.Items.Add("ID: "+ a.Id+" Company name: " +a.CompanyName);
            }
             
            NotifyChange();  
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Notifies the update of the number of airplanes 
        /// </summary>
        public void NotifyChange()
        {
            int value = airport.GetNumberOfAirplanes(" ");
            form.NotifyAll(value);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        //Event for "Remove Airplane" button
        private void button4_Click(object sender, EventArgs e)
        {
            if (airport.RemoveAirplane(int.Parse(tb_removeAirplanes.Text)))
            {
                lb_Airplanes.Items.Clear();
                foreach (Airplane a in airport.currentAirplanesInAirport)
                {
                    lb_Airplanes.Items.Add("ID: " + a.Id + " Company name: " + a.CompanyName);
                }
            }
            else
            {
                MessageBox.Show("No plane with that ID was found");
            }
        }
       
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //shows the id of the selected airplane 
            string fullText = lb_Airplanes.SelectedItem.ToString();
            string id = fullText.Substring(4, 6);
            tb_removeAirplanes.Text = id;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (cBox_desiredDestination.SelectedItem.ToString() == airport.name)
            {
                MessageBox.Show("The airplane is already in the chosen airport!");
                return;
            }
            var selectedAirport = this.allAirports[cBox_desiredDestination.SelectedIndex];
            var airPlane = this.airport.currentAirplanesInAirport[lb_Airplanes.SelectedIndex];
            selectedAirport.airplanesArriving.Add(airPlane);
            form.Focus();
            form.DrawAirline(this.airport, selectedAirport);
            this.Close();
        }
        public void SetAirport(Airport a,List<Airport> allAirports)
        {
            this.airport = a;
            this.allAirports = allAirports;

            lb_AirportLocation.Text = this.airport.name;
            if (this.airport.currentAirplanesInAirport != null)
            {
                this.lb_Airplanes.Items.Clear();
                foreach (Airplane ap in airport.currentAirplanesInAirport)
                {
                    lb_Airplanes.Items.Add("ID: " + ap.Id + " Company name: " + ap.CompanyName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach ( Airplane a in airport.currentAirplanesInAirport)
            {
                lb_Airplanes.Items.Add(a.Id);
            }
        }

        private void AirportLocation_Click(object sender, EventArgs e)
        {

        }

        private void tb_CompanyName_Click(object sender, EventArgs e)
        {
            tb_CompanyName.Clear();

        }

        private void cBox_desiredDestination_Click(object sender, EventArgs e)
        {
            cBox_desiredDestination.Text = "";
        }

        private void btn_reportStorm_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to close the current airport, due to a storm report?", "Report Storm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.airport.StopAirport();
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }

        private void btn_reportConstruction_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure that you want to close the current airport, due to a construction?", "Report construction", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.airport.StopAirport();
            }
            else if (dialogResult == DialogResult.No)
            {

            }
        }
    }
            
}
    

