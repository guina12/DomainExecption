
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projecto2023.Entities
{
    public class Pessoa : Atendimento
    {
        public DateTime PersonnDate { get; set; }


        public Pessoa()
        {

        }

        public Pessoa(string name, string sexo, string email, string numberphone, string tipodoenca, DateTime persondate) : base(name, sexo, email, numberphone, tipodoenca)
        {
            PersonnDate = persondate;
        }
    }
}