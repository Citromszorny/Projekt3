using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt3SzmutkoBence
{
     public class Kerdes
    {
        public string temakor { get; }
        public string kerdes { get; }
        public int valasz { get;}
        public List<string> valaszok { get; }
        public string valasztott { get; }
        public string helyesValasz { get; }
        public Kerdes(string temakor, string kerdes, List<string> valaszok, int valasz) 
        {
            this.temakor = temakor;
            this.kerdes = kerdes;
            this.valaszok = valaszok;
            this.valasz = valasz;
            helyesValasz = valaszok[0];

        }
    }
    
}
