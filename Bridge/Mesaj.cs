using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Bridge
{
    public abstract class Mesaj
    {
        protected IMesajGonderici _mesajGonderici;

        public Mesaj(IMesajGonderici mesajGonderici)
        {
            _mesajGonderici = mesajGonderici;
        }

        public abstract void Gonder();

        public string MesajYazisi { get; set; }
    }

    public class TextMesaji : Mesaj
    {
        public TextMesaji(IMesajGonderici mesajGonderici) : base(mesajGonderici)
        {

        }

        public string Telefon { get; set; }

        public override void Gonder()
        {
            _mesajGonderici.MesajGonder(this);
        }
    }

    //public class WhatsappMesaji : TextMesaji
    //{

    //}

    public class EmailMesaji : Mesaj
    {
        public EmailMesaji(IMesajGonderici mesajGonderici) : base(mesajGonderici)
        {
        }

        public override void Gonder()
        {
            _mesajGonderici.MesajGonder(this);
        }

        public string To { get; set; }
    }
}
