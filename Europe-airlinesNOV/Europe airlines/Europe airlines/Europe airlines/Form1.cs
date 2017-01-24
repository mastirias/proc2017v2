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
using System.IO;

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
            foreach (var airport in this.myAirport)
            {
                airport.ClosestAirportObj = this.myAirport.Where(x => x.name == airport.ClosestAirport).First();
            }
        }

        private void airport_click(object sender, EventArgs e)
        {
            var airport = findAirport(((PictureBox)sender).Text);
            otherForm.SetAirport(airport, this.myAirport.Where(x => x.name != airport.name).ToList());
            otherForm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Airport port in myAirport)
            {
                PictureBox c = new PictureBox();
                c.Image = Europe_airlines.Properties.Resources.airport;
                c.Location = new Point(port.x, port.y);
                c.Text = port.name;
                c.Name = port.name;
                c.Click += new EventHandler(airport_click);
                c.Tag = index;
                this.Controls.Add(c);
                Label lblCount = new Label();
                lblCount.Location = new Point(port.x + 5, port.y);
                lblCount.Text = Convert.ToString(port.GetNumberOfAirplanes(port.name));
                lblCount.Width = 10;
                this.Controls.Add(lblCount);
                lblCount.BringToFront();
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
        }

        public void SetAirport()
        {

        }

        // Method for drawing the airplane during it
        public void DrawAirline(Airport departureAirport, Airport arrivalAirport, Airplane ourPlane)
        {
            var timer = new System.Timers.Timer()
            {
                AutoReset = true,
                Interval = 4000
            };


            var graphics = this.CreateGraphics();

            var currentAirportX = departureAirport.x;
            var currentAirportY = departureAirport.y;

            Image airplane = Europe_airlines.Properties.Resources.airplane;
            var currentPoint = new Point(departureAirport.x, departureAirport.y);
            //point for drawing the background without intersections;
            var backgroundPoint = new Point(1, 1);
            graphics.DrawImage(airplane, currentPoint);

            var initialPoint = new Point(currentAirportX, currentAirportY);

            timer.Start();

            arrivalAirport.OnStormReported += () =>
            {
                timer.Stop();
                DrawPoint(new Point(currentAirportX, currentAirportY), arrivalAirport.ClosestAirportObj, departureAirport, ourPlane);
            };

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


                var currentPoint2 = new Point(currentAirportX, currentAirportY);

                graphics.DrawImage(Europe_airlines.Properties.Resources.Europe_map, backgroundPoint);

                graphics.DrawImage(airplane, currentPoint2);

                if ((currentAirportX - arrivalAirport.x) < 20 && (currentAirportX - arrivalAirport.x) > -20
                    && (currentAirportY - arrivalAirport.y) < 20 && (currentAirportY - arrivalAirport.y) > -20)
                {
                    timer.Stop();
                    departureAirport.RemoveAirplane(ourPlane.Id);
                    arrivalAirport.AddcurrentAirplane(ourPlane.CompanyName);
                    graphics.DrawImage(Europe_airlines.Properties.Resources.Europe_map, backgroundPoint);
                }
            };
        }

        public void DrawPoint(Point departurePoint, Airport arrivalAirport, Airport departureAirport, Airplane ourPlane)
        {
            var timer = new System.Timers.Timer()
            {
                AutoReset = true,
                Interval = 4000
            };

            var graphics = this.CreateGraphics();

            var currentAirportX = departurePoint.X;
            var currentAirportY = departurePoint.Y;

            Point backgroundPoint = new Point(1, 1);

            Image airplane = Europe_airlines.Properties.Resources.airplane;
            var currentPoint = new Point(departurePoint.X, departurePoint.Y);
            graphics.DrawImage(airplane, currentPoint);

            var initialPoint = new Point(currentAirportX, currentAirportY);

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

                var currentPoint2 = new Point(currentAirportX, currentAirportY);

                graphics.DrawImage(Europe_airlines.Properties.Resources.Europe_map, backgroundPoint);
                graphics.DrawImage(airplane, currentPoint2);

                if ((currentAirportX - arrivalAirport.x) < 20 && (currentAirportX - arrivalAirport.x) > -20
                    && (currentAirportY - arrivalAirport.y) < 20 && (currentAirportY - arrivalAirport.y) > -20)
                {
                    timer.Stop();
                    arrivalAirport.AddcurrentAirplane(ourPlane.CompanyName);
                    departureAirport.RemoveAirplane(ourPlane.Id);
                }
            };
        }
    }
}
