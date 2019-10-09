using System;
using System.Collections.Generic;
using System.Text;

namespace Istrate
{
    class Curs
    {

        public Curs()
        {
            Multiplicator = 1;
        }
        public int id { get; set; }

        public string Valuta { get; set; }

        public double Valoare { get; set; }

        public int Multiplicator { get; set; }

        public string Data { get; set; }

    }
}
