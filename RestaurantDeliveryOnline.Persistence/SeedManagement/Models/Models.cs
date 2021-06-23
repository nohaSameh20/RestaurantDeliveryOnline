 
using System;
using System.Collections.Generic;

namespace RestaurantDeliveryOnline.Presistence.Data
{

    public class CountrySD
    {
        public CountrySD(string shortName, string code, string name)
        {
            Name = name;
            ShortName = shortName;
            Code = code;
        }

        public CountrySD(string shortName, string code, string name, string arName)
        {
            Name = name;
            ShortName = shortName;
            Code = code;
            ArName = arName;
        }

        public CountrySD(string shortName, string code, string name, string arName, string nationality, string arNationality)
        {
            Name = name;
            ShortName = shortName;
            Code = code;
            ArName = arName;
            Nationality = nationality;
            ArNationality = arNationality;
        }


        public string Name { set; get; }
        public string ArName { set; get; }
        public string Nationality { set; get; }
        public string ArNationality { set; get; }

        
        public string ShortName { set; get; }
        public string Code { set; get; }
        public string Flag { set; get; }

        public bool InScope { set; get; }
    }

}