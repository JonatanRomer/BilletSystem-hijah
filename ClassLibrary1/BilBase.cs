namespace ClassLibrary1
{
    public abstract class BilBase
    {
        public abstract int Pris();

        public virtual string Køretøj()
        {
            return "Bil";
        }
    }
}