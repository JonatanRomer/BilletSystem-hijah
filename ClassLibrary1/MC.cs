using System;

namespace ClassLibrary1
{
    public class MC : BilBase
    {
        public int _Nummerplade { get; set; }
        public DateTime DateTime { get; set; }

        public string Køretøj()
        {
            return "MC";
        }

        public override int Pris()
        {
            return 125;
        }
    }
}