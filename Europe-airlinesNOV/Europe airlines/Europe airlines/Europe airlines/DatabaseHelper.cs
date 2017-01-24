using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Europe_airlines
{
    public class DatabaseHelper
    {

        public MySqlConnection connection;

        public DatabaseHelper()
        {
            String connectionInfo = "SERVER=studmysql01.fhict.local;" +//the iris-server
                                    "DATABASE=dbi334157;" +
                                    "UID=dbi334157;" +
                                    "password=Tfj0N]Cw;";
            //                                    "connect timeout=30;";



            connection = new MySqlConnection(connectionInfo);
        }


        public int NumberOfAirplane()
        {
            String sql = "SELECT COUNT(*) FROM Airplane ";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                return Convert.ToInt32(command.ExecuteScalar());
            }
            catch
            {
                return -1;

            }
            finally
            {
                connection.Close();
            }
        }






        public void AddAnAirplane( string companyName, string airportName)
        {
            string sql = "INSERT INTO airplane ( CompanyName, AirportName) VALUES ('" + companyName + "','" + airportName + "') ";

            MySqlCommand command = new MySqlCommand(sql, connection);


            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        


        public void RemoveAnAirplane(int tempId)
        {
            string sql = "Delete from airplane where AirplaneId=" + tempId + "";
            MySqlCommand command = new MySqlCommand(sql, connection);
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();

            }
        }

        public List<Airport> GetAllAirports()
        {
            string sql = "SELECT * FROM Airport ";
            MySqlCommand command = new MySqlCommand(sql, connection);


            List<Airport> myCurrentAirport = new List<Airport>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // create the 

                string AirportName;
                string ClosestAirport;
                int x;
                int y;


                while (reader.Read())
                {
                    AirportName = Convert.ToString(reader["AirportName"]);
                    ClosestAirport = Convert.ToString(reader["ClosestAirport"]);
                    x = Convert.ToInt32(reader["X"]);
                    y= Convert.ToInt32(reader["Y"]);
                    myCurrentAirport.Add(new Airport(AirportName, ClosestAirport,x,y));

                }

            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close();
            }
            return myCurrentAirport;
        }

        public List<Airplane> GetAllAirplanes(string airportname)
        {
            string sql = "SELECT * FROM airplane  where AirportName='" + airportname + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);


            List<Airplane> myCurrentAirplanes = new List<Airplane>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // create the 

                int tempId;
                string companyName;
                string airportName;


                while (reader.Read())
                {
                    tempId = Convert.ToInt32(reader["AirplaneId"]);
                    companyName = Convert.ToString(reader["CompanyName"]);
                    airportName = Convert.ToString(reader["AirportName"]);
                    myCurrentAirplanes.Add(new Airplane(companyName) { Id = tempId, CurrentAirport = airportname });
                }

            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close();
            }
            return myCurrentAirplanes;
        }
        public List<Airplane> GetAiplaneSpecific(string airportname)
        {



            string sql = "SELECT * FROM airplane  where AirportName='" + airportname + "'";
            MySqlCommand command = new MySqlCommand(sql, connection);


            List<Airplane> myCurrentAirplanes = new List<Airplane>();

            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();

                // create the 

                int tempId;
                string companyName;
                string airportName;


                while (reader.Read())
                {
                    tempId = Convert.ToInt32(reader["AirplaneId"]);
                    companyName = Convert.ToString(reader["CompanyName"]);
                    airportName = Convert.ToString(reader["AirportName"]);
                    myCurrentAirplanes.Add(new Airplane(companyName) { Id = tempId, CurrentAirport = airportname });
                }

            }
            catch (MySqlException ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

            finally
            {
                connection.Close();
            }
            return myCurrentAirplanes;
        }
    }


    }
    
