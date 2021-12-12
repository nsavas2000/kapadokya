using System;

namespace AlgOdv
{
    class Program
    {
        static void Main(string[] args)
        {
            //Soru 1: Eşkenar üçgenin alanını hesaplama
            Console.WriteLine("Üçgenin 1.Kenar Uzunluğunu Yazınız: ");
            int kenar1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üçgenin 2.Kenar Uzunluğunu Yazınız: ");
            int kenar2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Üçgenin 3.Kenar Uzunluğunu Yazınız: ");
            int kenar3 = Convert.ToInt32(Console.ReadLine());


            int u = (kenar1 + kenar2 + kenar3)/2;
            
            int sayi = u * (u - kenar1) * (u - kenar2) * (u - kenar3);
            

            double karekok = 1;

            for (int i = 0; i <= sayi; i++)
            {
                
                karekok = (sayi / karekok + karekok) / 2;
                
                if (i == sayi)
                {
                    Console.WriteLine("Üçgenin alanı: {0}", karekok);
                }
            }



            //Soru 2: En büyük sayıyı bulma
            Console.WriteLine("Lütfen birinci sayıyı girin: ");
            int sayi1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı girin: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Lütfen üçüncü sayıyı girin: ");
            int sayi3 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 > sayi2 && sayi1 > sayi3)
            {
                Console.WriteLine("En büyük sayi: {0}", sayi1);
            }
            else if (sayi2 > sayi3)
            {
                Console.WriteLine("En büyük sayi: {0}", sayi2);
            }
            else
            {
                Console.WriteLine("En büyük sayi: {0}", sayi3);
            }

            //Soru 3: ÖTV, KDV ve Damga Vergisini hesaplama
            Console.WriteLine("Araç Fiyatı Giriniz: ");
            int fiyat = Convert.ToInt32(Console.ReadLine());

            double otv = (fiyat * 45) / 100;
            double kdv = (fiyat * 18) / 100;
            double damga = (fiyat * 1) / 100;


            Console.WriteLine("Araç ÖTV : {0} TL", otv);
            Console.WriteLine("Araç KDV : {0} TL", kdv);
            Console.WriteLine("Araç DAMGA VERGİSİ : {0} TL", damga);


            //Soru 4 : MTV hesaplama
            double tutar = 0;
            Console.WriteLine("Araç türünü seçin: ");
            Console.WriteLine("(1)-Binek araç");
            Console.WriteLine("(2)-Ticari araç");
            Console.WriteLine("Hangi tip araç kullanıyor sunuz? (1)-(2): ");
            int secim1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Araç Yaşı : ");
            Console.WriteLine("(1) - 1-3 Yaş");
            Console.WriteLine("(2) - 4-7 Yaş");
            Console.WriteLine("(3) - 1-11 Yaş");
            Console.WriteLine("(4) - 11 Yaş Üzeri");
            Console.WriteLine("Araç yaş aralığı nedir? (1)-(2)-(3)-(4) : ");
            int secim2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Motor Hacmi : ");
            Console.WriteLine("(1) - 0-1300 cc");
            Console.WriteLine("(2) - 1301-1600 cc");
            Console.WriteLine("(3) - 1601-2000 cc");
            Console.WriteLine("(4) - 1601-2500 cc");
            Console.WriteLine("(5) - 2501 cc Üzeri");
            Console.WriteLine("Aracın motor hacmi nedir? (1)-(2)-(3) : ");
            int secim3 = Convert.ToInt32(Console.ReadLine());

            switch (secim1)
            {
                case 1:
                    tutar = 150;
                    break;
                case 2:
                    tutar = 225;
                    break;
            }

            switch (secim2)
            {
                case 1:
                    tutar = tutar * 1.80;
                    break;
                case 2:
                    tutar = tutar * 1.60;
                    break;
                case 3:
                    tutar = tutar * 1.40;
                    break;
                case 4:
                    tutar = tutar * 1.15;
                    break;
            }

            switch (secim3)
            {
                case 1:
                    tutar = tutar *= 2;
                    break;
                case 2:
                    tutar = tutar *= 3;
                    break;
                case 3:
                    tutar = tutar *= 4; ;
                    break;
                case 4:
                    tutar = tutar *= 5;
                    break;
                case 5:
                    tutar = tutar *= 6;
                    break;
            }

            Console.WriteLine("Ödenecek MTV Tutarı : {0}", tutar);
        }
    }
}

