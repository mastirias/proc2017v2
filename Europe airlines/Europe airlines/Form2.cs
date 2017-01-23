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
    //To do: read button 5 click event
    //To do: fix the autoincremention for plane ID
    //To do: report buttons must be implemented
    public partial class Form2 : Form
    {
        public string name;
        public int count = 100;
        private Airport airport;
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
            foreach (Airport ap in form.myAirport)
            {
                this.comboBox1.Items.Add(ap.name);
               
            }
            
        }

        private void Form2_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            e.Cancel = true;
            
        }

        private void AddAirplane_Click(object sender, EventArgs e)
        {
           
            airport.AddcurrentAirplane( textBox2.Text.ToString());
            this.listBox1.Items.Clear();
            foreach (Airplane a in airport.currentAirplanes)
            {
                listBox1.Items.Add("ID: "+ a.id+" Company name: " +a.companyName);
            }
             
            NotifyChange();
            //AddcurrentAirplane(count, textBox2.Text);
            //listBox1.Items.Add("ID: " + count + " -- Name: " + textBox2.Text);
            //textBox2.Clear();
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// notifies the update of the number of airplanes 
        /// </summary>
        public void NotifyChange()
        {
            int value = airport.GetNumberOfAirplanes(" ");
            form.NotifyAll(value);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (airport.RemoveAirplane(int.Parse(textBox3.Text)))
            {
                listBox1.Items.Clear();
                foreach (Airplane a in airport.currentAirplanes)
                {
                    listBox1.Items.Add("ID: " + a.id + " Company name: " + a.companyName);
                }
            }
            else
            {
                MessageBox.Show("No plane with that ID was found");
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //depending on how long the id is change the substring longtitude
            string fullText = listBox1.SelectedItem.ToString();
            string id=fullText.Substring(3, 4);
            textBox3.Text = id;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == airport.name)
            {
                MessageBox.Show("The airplane is already in the chosen airport!");
                return;
            }
            // do switch case with which you direct the marked airplane from the list in this airport to the list in the
            //desired airport using form.myAirport.
        }
        public void SetAirport(Airport a)
        {
            this.airport = a;
            AirportLocation.Text = this.airport.name;
            if (this.airport.currentAirplanes != null)
            {
                foreach (Airplane ap in airport.currentAirplanes)
                {
                    listBox1.Items.Add(ap);
                }
                this.listBox1.Items.Clear();
                foreach (Airplane ap in airport.currentAirplanes)
                {
                    listBox1.Items.Add("ID: " + ap.id + " Company name: " + ap.companyName);
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach ( Airplane a in airport.currentAirplanes)
            {
                listBox1.Items.Add(a.id);
            }
        }

        private void AirportLocation_Click(object sender, EventArgs e)
        {

        }
    }
            
        }
    

