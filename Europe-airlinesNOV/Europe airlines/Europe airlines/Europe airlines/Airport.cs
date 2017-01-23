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
        public List<Airplane> currentAirplanes = new List<Airplane>(); // the list of all current airplanes
        public List<Airplane> allAirplanes = new List<Airplane>(); // the list of all airplanes
        DatabaseHelper myHelper = new DatabaseHelper(); //the connection 

        public Airport(string name, string closeOne,int x , int y)
        {
            this.name = name;
            this.ClosestAirport = closeOne;
            this.x = x;
            this.y = y;
            currentAirplanes = myHelper.GetAllAirplanes(name);
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
        public int GetNumberOfAirplanes(string airportname)
        {

            currentAirplanes=myHelper.GetAllAirplanes(airportname);
            return currentAirplanes.Count();



        }


        public void AddcurrentAirplane( string companyName)
        {
            //bool value = CheckAirplane();
            if (GetNumberOfAirplanes(this.name) < 10)
            {
                  currentAirplanes.Add(new Airplane( companyName));
                    myHelper.AddAnAirplane( companyName, this.name);
                    NotifyChange();

               
            }
        }
        public bool RemoveAirplane(int id)
        {
            foreach (Airplane a in currentAirplanes)
            {
                if (a.Id == id)
                {
                    currentAirplanes.Remove(a);
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
