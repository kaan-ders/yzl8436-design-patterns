using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public interface IMesajGonderici
    {
        void MesajGonder(Mesaj mesaj);
    }

    public class TextMesajGonderici : IMesajGonderici
    {
        public void MesajGonder(Mesaj mesaj)
        {
            //sms olarak gönderilme kodu
            Console.WriteLine("Bu mesaj text olarak gönderildi");
        }
    }

    public class EmailMesajGonderici : IMesajGonderici
    {
        public void MesajGonder(Mesaj mesaj)
        {
            //mail olarak gönderilme kodu
            Console.WriteLine("Bu mesaj eposta olarak gönderildi");
        }
    }
}
