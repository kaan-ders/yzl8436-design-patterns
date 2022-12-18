using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DesignPatterns.Composite
{
    public interface IKatalogBileseni
    {
        void HiyerarsiyiCiz();
    }

    public class UrunKatalogu : IKatalogBileseni
    {
        private string _adi;
        private List<IKatalogBileseni> KatalogBilesenleri;

        public UrunKatalogu(string adi)
        {
            _adi = adi;
            KatalogBilesenleri = new List<IKatalogBileseni>();
        }

        public void Ekle(IKatalogBileseni katalogBileseni)
        {
            KatalogBilesenleri.Add(katalogBileseni);
        }

        public void Sil(int no)
        {
            KatalogBilesenleri.RemoveAt(no);
        }

        public void HiyerarsiyiCiz()
        {
            Console.WriteLine(_adi);
            foreach (IKatalogBileseni component in KatalogBilesenleri)
            {
                component.HiyerarsiyiCiz();
            }
        }
    }

    public class Urun : IKatalogBileseni
    {
        private string _adi;

        public Urun(string adi)
        {
            _adi = adi;
        }

        public void HiyerarsiyiCiz()
        {
            Console.WriteLine(_adi);
        }
    }
}
