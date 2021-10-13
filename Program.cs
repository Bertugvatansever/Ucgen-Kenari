using System;

namespace Ucgen_kenar
{
    class Program
    {
        static void Main(string[] args)
        {
            int kenar, kenar1, kenar2;
            Console.WriteLine("1.kenarı giriniz.");
            kenar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.kenarı giriniz.");
            kenar1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("3.kenarı giriniz.");
            kenar2 = Convert.ToInt32(Console.ReadLine());
            if (kenar+kenar1<kenar2)
            {
                Console.WriteLine("Hatalı kenar girişi yaptınız iki kenarın toplam uzunlugu diger kenardan kucuk olamaz");
            }
            else if(kenar+kenar2<kenar1)
            {
                Console.WriteLine("Hatalı kenar girişi yaptınız iki kenarın toplam uzunlugu diger kenardan kucuk olamaz");
            }
            else if(kenar2+kenar1<kenar)
            {
                Console.WriteLine("Hatalı kenar girişi yaptınız iki kenarın toplam uzunlugu diger kenardan kucuk olamaz");
            }
            int mutlakdeger = Math.Abs(kenar-kenar1);
            int mutlakdeger2 = Math.Abs(kenar - kenar2);
            int mutlakdeger3 = Math.Abs(kenar2 - kenar1);
            int mutlakdeger4 = Math.Abs(kenar2 - kenar);
            int mutlakdeger5 = Math.Abs(kenar1 - kenar);
            int mutlakdeger6 = Math.Abs(kenar1 - kenar2);
            if (mutlakdeger>kenar2)
            {
                Console.WriteLine("İki kenarin mutlak deger farki diger kenardan büyük olmamalıdır. ");
            }
            else if (mutlakdeger2>kenar1)
            {
                Console.WriteLine("İki kenarin mutlak deger farki diger kenardan büyük olmamalıdır. ");
            }
            else if (mutlakdeger3 > kenar)
            {
                Console.WriteLine("İki kenarin mutlak deger farki diger kenardan büyük olmamalıdır. ");
            }
            else if (mutlakdeger4 > kenar1)
            {
                Console.WriteLine("İki kenarin mutlak deger farki diger kenardan büyük olmamalıdır. ");
            }
            else if (mutlakdeger5>kenar2)
            {
                Console.WriteLine("İki kenarin mutlak deger farki diger kenardan büyük olmamalıdır. ");
            }
            else if (mutlakdeger6>kenar)
            {
                Console.WriteLine("İki kenarin mutlak deger farki diger kenardan büyük olmamalıdır. ");
            }
            else 
            {
                Console.WriteLine("Basariyla ucgen olusturdunuz.");
            }
        }
    }
}
