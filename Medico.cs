
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projecto2023.Entities
{
    public class Medico:Atendimento
    {
        public string Department { get; set; }
  

        public Medico()
        {

        }

        public Medico(string  nome,string sexo,string department):base(nome,sexo)
        {
            Department = department;
     
        }

     

    }

}