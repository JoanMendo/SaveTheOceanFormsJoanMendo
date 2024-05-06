using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveTheOceanFormsJoanMendo.Classes
{
    internal abstract class Animal
    {
        private int rescueNumber;
        private DateTime rescueDate;
        private string espècieARescatar;
        private decimal grauDeAfectació;
        private string ubicació;

        protected Animal(int rescueNumber, DateTime rescueDate, string espècieARescatar, decimal grauDeAfectació, string ubicació)
        {
            RescueNumber = rescueNumber;
            RescueDate = rescueDate;
            EspècieARescatar = espècieARescatar;
            GrauDeAfectació = grauDeAfectació;
            Ubicació = ubicació;
        }

        public int RescueNumber
        {
            get { return rescueNumber; }
            set { rescueNumber = value; }
        }

        public DateTime RescueDate
        {
            get { return rescueDate; }
            set { rescueDate = value; }
        }

        public string EspècieARescatar
        {
            get { return espècieARescatar; }
            set { espècieARescatar = value; }
        }

        public decimal GrauDeAfectació
        {
            get { return grauDeAfectació; }
            set { grauDeAfectació = value; }
        }

        public string Ubicació
        {
            get { return ubicació; }
            set { ubicació = value; }
        }
    }

    internal interface IAnimal
    {
        void RecieveTreatment();
    }

    internal class Turtle : Animal, IAnimal
    {
        public Turtle(int rescueNumber, DateTime rescueDate, string espècieARescatar, decimal grauDeAfectació, string ubicació) : base(rescueNumber, rescueDate, espècieARescatar, grauDeAfectació, ubicació)
        {

        }
        public void RecieveTreatment()
        {
            GrauDeAfectació = GrauDeAfectació - ((GrauDeAfectació-2)*(2*GrauDeAfectació+3)-5);
        }
    }
}
