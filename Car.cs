using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Proj
{
    class Car
    {
        private int year;
        private string make;
        private int speed;

        public Car()
        {
            this.year = 1994;
            this.make = "Ford";
            this.speed = 0;
        }

        public Car(string make, int year, int speed)
        {
            this.year = year;
            this.make = make;
            this.speed = speed;
        }

        public string Make
        {
            get { return make; }
            set { make = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public int Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        public void AccSpeed(int speedIncrement)
        {
            //Add check for speed limit ranges
            Speed += speedIncrement;
        }

        public void DecSpeed(int speedDecrement)
        {

            //Add check for speed limit ranges
            if (Speed - speedDecrement >= 0)
                Speed -= speedDecrement;
            else
                Speed = 0;
                     
            
            
        }
    }
}