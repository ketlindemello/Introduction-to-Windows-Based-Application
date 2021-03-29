using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter9
{
    class Employee
    {
        private string fullname;
        private string address;
        private string city;
        private string state;
        private string zip;
        private double hours;


        public Employee()
        {

        }

        public Employee(string fullname, string address, string city, string state, string zip, double hours)
        {
            this.fullname = fullname;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.hours = hours;
        }


        public string Fullname { get => fullname; set => fullname = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public string Zip { get => zip; set => zip = value; }
        public double Hours { get => hours; set => hours = value; }

        public override string ToString()
        {
            //return base.ToString();
            String retVal = Fullname + "\n" + Address + " " + City + " " + State + " " + Zip + " " + Hours;
            return retVal;
        }
    }

   
}
