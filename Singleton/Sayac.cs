using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Singleton
{
    public class Sayac
    {
        private int Counter = 0;
        public int SayacGetir()
        {
            return Counter;
        }

        public void BirArtir()
        {
            Counter++;
        }
    }

    public class SayacSingleton
    {
        //Nesneyi oluşturmakla alakalı kısım
        //----------------------------------

        private static SayacSingleton Sayac;
        private SayacSingleton()
        {

        }

        public static SayacSingleton NesneyiGetir()
        {
            if (Sayac == null)
                Sayac = new SayacSingleton();

            return Sayac;
        }

        //Class'ın işlevleri
        //--------------------
        private int Counter = 0;
        public int SayacGetir()
        {
            return Counter;
        }

        public void BirArtir()
        {
            Counter++;
        }
    }
}
