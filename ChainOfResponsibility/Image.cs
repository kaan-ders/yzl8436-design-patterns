using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainOfResponsibility
{
    public class Image
    {
        public string name;
        public string extension;

        public Image(string name, string extension)
        {
            this.name = name;
            this.extension = extension;
        }
    }

    // Zincirin bir sonraki halkasının referansının tutulduğu sınıftır.
    // İşlemi gerçekleştirecek olan metot tanımı bulunur.
    public abstract class BaseCevirici
    {
        protected BaseCevirici _nextHandler;
        public void SetNextHandler(BaseCevirici nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void Cevir(Image image);
    }

    // JPEG dosyalarını dönüştüren sınıf.
    public class JPEGCevirici : BaseCevirici
    {
        public override void Cevir(Image image)
        {
            if (image.extension == "JPEG")
            {
                Console.WriteLine("JPEG to PNG");
                // JPEG işlemine ait dönüştürme kodları işlemleri.
            }
            else
            {
                // Bu sınıfa ait bir işlem değilse zincirin bir sonraki halkasına aktarılır.
                _nextHandler.Cevir(image);
            }
        }
    }

    // Gif dosyalarını dönüştüren sınıf.
    public class GifCevirici : BaseCevirici
    {
        public override void Cevir(Image image)
        {
            if (image.extension == "GIF")
            {
                Console.WriteLine("GIF to PNG");
                // JPG işlemine ait dönüştürme kodları işlemleri.
            }
            else
            {
                // Bu sınıfa ait bir işlem değilse zincirin bir sonraki halkasına aktarılır.
                _nextHandler.Cevir(image);
            }
        }
    }

    // Herhangi bir tipteki dosyayı dönüştüren sınıf.
    public class DigerCevirici : BaseCevirici
    {
        public override void Cevir(Image image)
        {
            if (image.extension == "OtherExtension")
            {
                Console.WriteLine("OtherExtension to PNG");
                // Herhangi bir tipteki dosyanın işlemine ait dönüştürme kodları işlemleri.
            }
            // Burada else ifadesi bulunmamaktadır bu da zincirin son halkası olduğu anlamına gelir.
        }
    }
}
