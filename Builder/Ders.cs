using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Builder
{
    public class Ders
    {
        public int id;
        public string name;
        public double price;
        public double discountedPrice;
        public bool discountApplied;
        public string lessonNote;

        //....
    }

    public abstract class DersBuilder
    {
        protected Ders ders;

        public abstract void ApplyDiscount();
        public abstract void AddLessonNote();
        public abstract Ders Build();
    }

    public class YeniOgrenciDersBuilder : DersBuilder
    {
        public YeniOgrenciDersBuilder()
        {
            ders = new Ders();

            ders.id = 1;
            ders.name = "Artificial Intelligence -  Beginner to Advanced in 10 Minute.";
            ders.price = 49;
        }

        public override void AddLessonNote()
        {
            ders.lessonNote = "Hey, welcome. Your discount code has been applied!";
        }

        // Burada yeni öğrenciler için geçerli derste %50'lik bir indirim mevcut.
        public override void ApplyDiscount()
        {
            ders.discountedPrice = ders.price * 0.5;
            ders.discountApplied = true;
        }

        public override Ders Build()
        {
            return ders;
        }
    }

    public class EskiOgrenciDersBuilder : DersBuilder
    {
        public EskiOgrenciDersBuilder()
        {
            ders = new Ders();

            ders.id = 1;
            ders.name = "Artificial Intelligence -  Beginner to Advanced in 10 Minute.";
            ders.price = 49;
        }

        public override void AddLessonNote()
        {
            ders.lessonNote = "";
        }

        // Burada eski öğrenciler için geçerli derste herhangi bir indirim yapılmadı.
        public override void ApplyDiscount()
        {
            ders.discountedPrice = ders.price;
            ders.discountApplied = false;
        }

        public override Ders Build()
        {
            return ders;
        }
    }
}
