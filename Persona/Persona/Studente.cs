using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Studente : Persona
    {
        private string _sezione;
        public string sezione { get; set; }
        
        public Studente(string nome, string cognome, int anni, string sezione) :base (nome,cognome,anni)
        {
            _sezione = sezione;
        }
    }
}
