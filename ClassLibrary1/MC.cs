using System;

namespace ClassLibrary1
{
    public class MC : BilBase
    {
        //public int _Nummerplade { get; set; }
        //public DateTime DateTime { get; set; }

        public override string Køretøj()
        {
            return "MC";
        }

        public override int Pris()
        {
            return 125;
        }

        public MC(string nummberplade, DateTime dato)
        {
        }
    }
}