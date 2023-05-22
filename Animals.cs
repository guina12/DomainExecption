using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Projecto2023.Entities.Exeption;

namespace Projecto2023.Entities
{
    public class Animals : Atendimento
    {
        public double Peso { get; set; }
        
         public DateTime DataAnimals { get; set; }


        public Animals()
        {

        }

        public Animals(string name,string sexo, string tipodoenca ,DateTime dataanimals,double peso) : base(name,sexo,tipodoenca) 
        {
            Peso = peso;
            DataAnimals = dataanimals;
       

        }

    }
}