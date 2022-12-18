using DesignPatterns.Adaptor;
using DesignPatterns.Bridge;
using DesignPatterns.Builder;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Composite;
using DesignPatterns.Factory;
using DesignPatterns.Mediator;
using DesignPatterns.Singleton;
using System.Collections;
using System.Data;

namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SINGLETON
            //-----------------------------------------------------

            /*Sayac sayac = new Sayac();
            sayac.BirArtir();
            sayac.BirArtir();
            sayac.BirArtir();
            sayac.BirArtir();
            sayac.BirArtir();
            sayac.BirArtir();

            Console.WriteLine(sayac.SayacGetir());

            Sayac sayac2 = new Sayac();
            sayac2.BirArtir();

            Console.WriteLine(sayac2.SayacGetir());*/


            /*SayacSingleton sayac3 = SayacSingleton.NesneyiGetir();
            sayac3.BirArtir();
            sayac3.BirArtir();
            sayac3.BirArtir();
            sayac3.BirArtir();
            sayac3.BirArtir();
            sayac3.BirArtir();

            Console.WriteLine(sayac3.SayacGetir());

            SayacSingleton sayac4 = SayacSingleton.NesneyiGetir();
            sayac4.BirArtir();

            Console.WriteLine(sayac4.SayacGetir());*/

            //FACTORY
            //---------------------------------

            //User user = new User
            //{
            //    Email = "asd@asd.com",
            //    Name = "Fatma Girik",
            //    Phone = "555 22 33"
            //};

            //Notification notification = new Notification();
            //notification.SendNotification(user);

            /*INotify notitication = new SmsNotification();
            notitication.SendNotification(user);*/

            //var factory = new NotificationFactory();
            /*INotify notitication = NotificationFactory.CreateNotification(NotificationType.Email);
            notitication.SendNotification(user);

            INotify notitication2 = NotificationFactory.CreateNotification(NotificationType.Sms);
            notitication2.SendNotification(user);*/

            //Builder
            //---------------------------------------------

            //Ders ders = new Ders
            //{
            //    discountApplied = false,
            //    discountedPrice= 10,

            //}

            /*var eskiOgrenciDersBuilder = new EskiOgrenciDersBuilder();
            eskiOgrenciDersBuilder.ApplyDiscount();
            eskiOgrenciDersBuilder.AddLessonNote();

            var ders = eskiOgrenciDersBuilder.Build();

            var yeniOgrenciDersBuilder = new YeniOgrenciDersBuilder();
            yeniOgrenciDersBuilder.ApplyDiscount();
            yeniOgrenciDersBuilder.AddLessonNote();

            var ders2 = yeniOgrenciDersBuilder.Build();*/

            //Adaptor
            //-----------------------------------------------

            //IJsonSerializer serializer = new FilmSerializer();
            //serializer.Serialize("dsfsf");

            //IJsonSerializer serializer2 = new DiziSerializer();
            //serializer2.Serialize("fghfghfg");

            //IJsonSerializer serializer3 = new MicrosoftSerializerAdapter();
            //serializer3.Serialize("asd");

            //Bridge
            //--------------------------------

            //Mesaj mesaj = new Mesaj();

            /*TextMesaji mesaj = new TextMesaji(new TextMesajGonderici());
            mesaj.Gonder();

            EmailMesaji emailMesaji = new EmailMesaji(new EmailMesajGonderici());
            emailMesaji.Gonder();*/

            //Composite
            //--------------------------------------

            //UrunKatalogu urunKatalogu = new UrunKatalogu("Ürünler");
            //UrunKatalogu telefonlar = new UrunKatalogu("Telefonlar");
            //UrunKatalogu iphone = new UrunKatalogu("IPhone telefonlar");
            //UrunKatalogu samsung = new UrunKatalogu("Samsung telefonlar");

            //Urun iphone14 = new Urun("IPhone 14");
            //Urun iphone14Pro = new Urun("IPhone 14 Pro");
            //Urun iphone14ProMax = new Urun("IPhone 14 Pro Max");

            //Urun samsungGalaxyS22 = new Urun("Samsung Galaxy S22");
            //Urun samsungGalaxyS22Mini = new Urun("Samsung Galaxy S22 Mini");

            //urunKatalogu.Ekle(telefonlar);
            //telefonlar.Ekle(iphone);
            //telefonlar.Ekle(samsung);

            //iphone.Ekle(iphone14);
            //iphone.Ekle(iphone14Pro);
            //iphone.Ekle(iphone14ProMax);

            //samsung.Ekle(samsungGalaxyS22);
            //samsung.Ekle(samsungGalaxyS22Mini);

            //urunKatalogu.HiyerarsiyiCiz();

            //Chain of Responsibility
            //------------------------------------

            Image image = new Image("tatil-fotografim", "GIF");
            //YANLIŞŞ

            //if (image.extension == "JPG")
            //{
            //    // JPG işlemine ait dönüştürme kodları işlemleri.
            //}
            //else if (image.extension == "JPEG")
            //{
            //    // JPEG işlemine ait dönüştürme kodları işlemleri.
            //}
            //else
            //{
            //    // Diğer türlere ait dönüştürme işlemleri.
            //}

            //DOĞRU

            //JPEGCevirici jpegHandler = new JPEGCevirici();
            //GifCevirici gifHandler = new GifCevirici();
            //DigerCevirici customHandler = new DigerCevirici();

            //jpegHandler.SetNextHandler(gifHandler);
            //gifHandler.SetNextHandler(customHandler);

            //jpegHandler.Cevir(image);

            //Mediator
            //------------------------------------------------

            IChatRoomMediator chatRoom = new ChatRoomMediator();

            // Sohbet odasına dahil olacak kullanıcıların oluşturulması.
            // Ortak Mediator arayüzü ile haberleşmesi.
            Kullanici yusuf = new ChatUser(chatRoom);
            yusuf.id = 1;
            yusuf.name = "Yusuf";

            Kullanici sema = new ChatUser(chatRoom);
            sema.id = 2;
            sema.name = "Semanur";

            Kullanici derya = new ChatUser(chatRoom);
            derya.id = 3;
            derya.name = "Derya";

            Kullanici aleyna = new ChatUser(chatRoom);
            aleyna.id = 4;
            aleyna.name = "Aleyna";

            // Mediator içerisindeki kullanıcı listesine atama işlemleri.
            chatRoom.AddUserInRoom(yusuf);
            chatRoom.AddUserInRoom(sema);
            chatRoom.AddUserInRoom(derya);
            chatRoom.AddUserInRoom(aleyna);

            yusuf.SendMessage("Naber kız?", sema.id);
            sema.SendMessage("Sanane be?", yusuf.id);
        }
    }
}