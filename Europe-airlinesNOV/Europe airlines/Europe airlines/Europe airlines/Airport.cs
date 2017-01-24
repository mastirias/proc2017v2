using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Europe_airlines
{
    public class Airport : IAirport
    {
        public string name; //the name of the airport
        public string ClosestAirport; //the name of the closest airport
        public int x, y; //the coordinates
        public List<Airplane> currentAirplanesInAirport; //the list of all airplanes in the current airport
        public List<Airplane> currentAirplanesAndArriving; //the list of the current airplanes and the arriving airplanes
        DatabaseHelper myHelper = new DatabaseHelper(); //the connection with the DataBase
        /// <summary>
        /// constructor of the Airport class
        /// </summary>
        /// <param name="name"></param>
        /// <param name="closeOne"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>

        public Airport(string name, string closeOne,int x , int y)
        {
            this.name = name;
            this.ClosestAirport = closeOne;
            this.x = x;
            this.y = y;
            currentAirplanesInAirport = new List<Airplane>();
            currentAirplanesInAirport = myHelper.GetAllAirplanes(name);
            currentAirplanesAndArriving = new List<Airplane>();
        }



        //public bool CheckAirplane(int createdid)
        //{
        //    if (allAirplanes.Count() != 0)
        //    {
        //        foreach (Airplane AP in allAirplanes)
        //        {
        //            if (AP.id == createdid)
        //            {
        //                return true;
        //            }
        //        }
        //        return false;
        //    }
        //    else return false;
        //}
        /// <summary>
        /// Returns the number of airplanes of the current airport
        /// </summary>
        /// <param name="airportname"></param>
        /// <returns></returns>
        public int GetNumberOfAirplanes(string airportname)
        {

            currentAirplanesInAirport=myHelper.GetAllAirplanes(airportname);
            return currentAirplanesInAirport.Count();

        }
        public List<Airplane> GetCurrentAirplanes(string airportName)
        {
            currentAirplanesInAirport = myHelper.GetAllAirplanes(airportName);
            return currentAirplanesInAirport;
        }

        /// <summary>
        /// Checks if there is space in the airport and adds an airplane
        /// </summary>
        /// <param name="companyName"></param>
        public void AddcurrentAirplane(string companyName)
        {
            if (GetNumberOfAirplanes(this.name) < 10)
            {

                  currentAirplanesInAirport.Add(new Airplane(companyName));
                    myHelper.AddAnAirplane(companyName, this.name);
                    NotifyChange();    
            }
        }
        /// <summary>
        /// Removes and airplane, from the current airport, by the selected id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool RemoveAirplane(int id)
        {
            foreach (Airplane a in currentAirplanesInAirport)
            {
                if (a.Id == id)
                {
                    currentAirplanesInAirport.Remove(a);
                    myHelper.RemoveAnAirplane(id);
                    return true;
                }
            }
            return false;
        }


        public void NotifyChange()
        {

        }
    }
}
