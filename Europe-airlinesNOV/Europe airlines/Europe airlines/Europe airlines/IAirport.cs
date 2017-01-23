using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Europe_airlines
{
    public interface IAirport
    {
        int GetNumberOfAirplanes(string airportname);
        //bool CheckAirplane(int createdid);
        void AddcurrentAirplane(string companyName);
        bool RemoveAirplane(int id);
        void NotifyChange();

    }
}
