using System;

namespace ClassLibrary1
{
    public class Bil : BilBase
    {
        //public override string _NummerPlade { get; set; }
        //public DateTime Dato { get; set; }

        public override int Pris()
        {
            return 240;
        }

        public Bil(string nummberplade, DateTime dato)
        {
        }
    }
}