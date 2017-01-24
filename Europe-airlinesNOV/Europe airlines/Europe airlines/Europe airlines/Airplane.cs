using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Europe_airlines
{
    /// <summary>
    /// Declaring variables in the Airplane class
    /// </summary>
    public class Airplane
    {
        private int id; // the id of the airplane
        private string companyName; //the name of the airplane company
        private string currentAirport; //the current airport 
        public Airplane(string newCompanyName)
        {
            CompanyName = newCompanyName;
        }

        /// <summary>
        /// properties
        /// </summary>
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }
        public string CompanyName
        {
            get
            {
                return companyName;
            }
            set
            {
                companyName = value;
            }
        }
        public string CurrentAirport
        {
            get
            {
                return currentAirport;
            }
            set
            {
                currentAirport = value;
            }
        }



      
    }
}
  