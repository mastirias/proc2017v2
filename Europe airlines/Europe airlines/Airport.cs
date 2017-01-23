using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Europe_airlines
{
    public class Airport : IAirport
    {
        public string name;
        public string ClosestAirport;
        public int x, y;
        public List<Airplane> currentAirplanes = new List<Airplane>();
        public List<Airplane> allAirplanes = new List<Airplane>();
        DatabaseHelper myHelper = new DatabaseHelper();

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
                if (a.id == id)
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
