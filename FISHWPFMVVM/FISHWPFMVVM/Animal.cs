using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISHWPFMVVM
{
    class Animal
    {
        private string name;
        private string lenght;
        private double weight;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Lenght
        {
            get
            {
                return lenght;
            }

            set
            {
                lenght = value;
            }
        }

        public double Weight
        {
            get
            {
                return weight;
            }

            set
            {
                weight = value;
            }
        }

        public Animal(string name, string lenght, double weight)
        {
            this.name = name;
            this.lenght = lenght;
            this.weight = weight;
        }
    }
}
