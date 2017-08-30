using System;

namespace ClassLibrary1
{
    public abstract class BilBase
    {
        public String Nummerplade { get; set; }
        public DateTime Dato { get; set; }


        public abstract int Pris();

        public virtual string Køretøj()
        {
            return "Bil";
        }

        public string Nummberpladecount()
        {

            if (Nummerplade.Length <= 7)
            {
                throw new ArgumentException("Ups: Nummerpladen skal være 7 tegn eller mindre");
            }
            return Nummerplade;
        }

    }
}