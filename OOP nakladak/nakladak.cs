using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_nakladak
{
    internal class nakladak
    {
        public string Name { get; set; }
        public int Nosnost { get; set; }
        public int Naklad { get; set; }
        public int Objemnadrze { get; set; }
        public int Spotrebapaliva { get; set; }
        public int Celkovavzdalenost { get; set; }

        public nakladak()
        {
            Nosnost = 66;
            Naklad = 100;
            Objemnadrze = 70;
            Spotrebapaliva = 150;
            Celkovavzdalenost = 156;
        }
    }
}
