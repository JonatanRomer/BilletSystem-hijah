using System;

namespace ClassLibrary1
{
    public class Bil
    {
        public string _NummerPlade { get; set; }
        public DateTime Dato { get; set; }

        public int Pris()
        {
            return 240;
        }

        public string Køretøj()
        {
            return "Bil";
        }



    }
}