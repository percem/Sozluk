using System;

namespace Sozluk
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<string, int> manav = new MyDictionary<string, int>();
            manav.Add("Ananas: ",14);
            manav.Add("Avokado: ",18);
            manav.Add("Kiraz: ",22);

            manav.Getir();
            
        }
    }
}
