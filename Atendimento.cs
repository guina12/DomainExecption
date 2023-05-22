using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Projecto2023.Entities.Exeption;

namespace Projecto2023.Entities
{
    public class Atendimento
    {
        public string Nome { get; set; }
        public DateTime Date { get; set; }
        public string Sexo { get; set; }
        public string Email { get; set; }
        public string NumberPhone { get; set; }
        public string TipoDoenca { get; set; }






        public Atendimento()
        {


        }
        public Atendimento(string name, string sexo, string email, string numberphone, string tipodoenca)
        {
            if(numberphone.Length > 13)
            {
                throw new DomainException("The limite of this number is to large...");
            }
            else
            {
                NumberPhone = numberphone;
                Nome = name;
                Sexo = sexo;
                TipoDoenca = tipodoenca;
                Email = email;
                NumberPhone = numberphone;
            }
    
    }
            public Atendimento(string name, string sexo,string tipodoenca) {

            Nome = name;
            Sexo = sexo;
            TipoDoenca = tipodoenca;
            }

        public Atendimento(string name, string sexo)
        {

            Nome = name;
            Sexo = sexo;
    
        }



        public  DateTime  Time()
        {
            Date = DateTime.Now;
            return Date;

        }

    }
}

