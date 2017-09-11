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

        /// <summary>
        /// Lav en test over Nummberpladecount() i Bilbase klassen (denne klasse)
        /// </summary>
        /// <returns></returns>
        public string Nummberpladecount()
        {
            // (Nummerplade.Length > 7)
            if (Nummerplade.Length <= 7)
            {
                throw new ArgumentException("Ups: Nummerpladen skal være 7 tegn eller mindre");
            }
            return Nummerplade;
        }

    }
}