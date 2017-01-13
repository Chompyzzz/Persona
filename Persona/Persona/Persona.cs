using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persona
{
    class Persona
    {
        private string _nome;
        public string nome { get; set; }

        private string _cognome;
        public string cognome { get; set; }

        private int _anni;
        public int anni
        {
            get
            {
                return _anni;
            }
            set
            {
                if (value <= 0) value = 1;
                _anni = value;
            }
        }
          

        private string _cf;
        public string cf { get { return _nome + _cognome + _anni} }
      

        public Persona(string nome, string cognome, int anni)
        {
            _nome = nome;



        }
    }
}
