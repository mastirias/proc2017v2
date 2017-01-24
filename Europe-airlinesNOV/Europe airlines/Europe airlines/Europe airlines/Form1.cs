using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Europe_airlines
{
    public partial class Form1 : Form
    {

        public List<Airport> myAirport;
        public Form2 otherForm;

        int index = 0;
        public DatabaseHelper myHelper;
        // To do: label for airplane numbur must be added on every airport
        public Form1()
        {
            InitializeComponent();
            otherForm = new Form2(this);
            myAirport = new List<Airport>();
            myHelper = new DatabaseHelper();
            myAirport = myHelper.GetAllAirports();
        }

        private void airport_click(object sender, EventArgs e)
        {
            otherForm.SetAirport(findAirport(((Button)sender).Text));
            otherForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Airport port in myAirport)
            {
                Button c = new Button();
                c.Location = new Point(port.x, port.y);
                c.Text = port.name;
                c.Name = port.name;
                c.Click += new EventHandler(airport_click);
                c.Tag = index;
                this.Controls.Add(c);
                Label lblCount = new Label();
                lblCount.Location = new Point(port.x + 10, port.y + 10);
                lblCount.Text = port.name;
                lblCount.Name = port.name;

                this.Controls.Add(lblCount);

                index++;
            }
        }


        Airport findAirport(string name)
        {
            foreach (Airport a in myAirport)
            {
                if (a.name == name)
                {
                    return a;
                }
            }
            return null;
        }

        /// <summary>
        ///  Updates the value of the label containg the information about the no of planes of each airport 
        /// </summary>
        public void NotifyAll(int num)
        {
            label1.Text = num.ToString();

        }

        public void SetAirport()
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {
            var t = this.myAirport[0];
            var t1 = this.myAirport[1];
            this.DrawAirline(t, t1);
        }


        public void DrawAirline(Airport departureAirport, Airport arrivalAirport)
        {
            var timer = new System.Timers.Timer()
            {
                AutoReset = true,
                Interval = 2000
            };


            var graphics = this.CreateGraphics();

            var currentAirportX = departureAirport.x;
            var currentAirportY = departureAirport.y;

            //TODO JAK REMOVE
            var rect = new Rectangle(new Point(departureAirport.x, departureAirport.y), new Size(20, 20));
            graphics.DrawRectangle(Pens.Red, rect);

            var initialPoint = new Point(currentAirportX,currentAirportY);
            // graphics.DrawImage(image, initialPoint);
            timer.Start();

            timer.Elapsed += (s, e) =>
            {
                if (currentAirportX < arrivalAirport.x)
                {
                    currentAirportX += 20;
                }
                if (currentAirportX > arrivalAirport.x)
                {
                    currentAirportX -= 20;
                }
                if (currentAirportY < arrivalAirport.y)
                {
                    currentAirportY += 20;
                }
                if (currentAirportY > arrivalAirport.y)
                {
                    currentAirportY -= 20;
                }

                //TODO JAK REMOVE
                var newRect = new Rectangle(new Point(currentAirportX, currentAirportY), new Size(40, 40));
                graphics.DrawRectangle(Pens.Red, newRect);

                var currentPoint = new Point(currentAirportX, currentAirportY);
                // graphics.DrawImage(image, currentPoint);

                if ((currentAirportX - arrivalAirport.x) < 20 && (currentAirportX - arrivalAirport.x) > -20
                    && (currentAirportY - arrivalAirport.y) < 20 && (currentAirportY - arrivalAirport.y) > -20)
                {
                    timer.Stop();
                }
            };
        }
    }
}
