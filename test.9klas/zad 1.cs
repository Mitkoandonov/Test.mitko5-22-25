using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace test._9klas
{
    
        
      public class Car
    {
        private string brand;
        private int year;
        private double fuelConsumption;

       public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public double FuelConsumption
        {
            get { return fuelConsumption; }
            set { fuelConsumption = value; }
        }

        public Car(string brand, int year, double fuelConsumption)
        {
            this.brand = brand;
            this.year = year;
            this.fuelConsumption = fuelConsumption;

        }
                
        public int GetCarAge()
        {
            return 2025 - year;
        }
        public string CalculatefuelCost(double distance, double fuelPrice) 
        {
            double liters = (distance / 100) * fuelConsumption;


            return liters.ToString();    

        }


    }
}
