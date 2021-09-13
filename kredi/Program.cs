using System;

namespace kredi
{
    class Program
    {
        static void Main(string[] args)
        {

             Hesapla();

            /*

            int kesinti = 250;
            double krediTutari;
            int vade;
            int rakam;
            int kredi;
            string krediTipi;
            Console.WriteLine("Hosgeldiniz..");
            
            Console.Write("Kredi miktarı giriniz:");
            kredi = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");

            Console.WriteLine("Sigortalı:\t\tSigortasız:\nFaiz Oranı:1,29\t\tFaiz Oranı:1,59\nKesinti=250 TL\t\tKesinti=0 TL\nVade:12-24-36\t\tVade:6-18-24");
            // Console.WriteLine("Sigortasız:\nFaiz Oranı:1,59 \nKesinti=0 TL \nVade:6-18-24"); 

            Console.WriteLine("\nKredi Çekme İşlemini Onaylıyorsanız 1'e; Onaylamıyorsanız Herhangi bir Rakam Tuşuna Basınız.");
            rakam = Convert.ToInt32(Console.ReadLine());
            if (rakam == 1)
            {
                Console.WriteLine("Kredi Tipi Giriniz.");
                krediTipi = Convert.ToString(Console.ReadLine());
                if (krediTipi == "sigortali")
                {
                    double faiz = 1.29;
                    Console.WriteLine("Vade Giriniz.");
                    vade = Convert.ToInt32(Console.ReadLine());
                    if (vade == 12)
                    {

                        krediTutari = kredi + kesinti + (vade * faiz);
                        Console.WriteLine("Toplam Tutar=" + krediTutari);
                        Console.WriteLine("Aylık Tutar=" + krediTutari / 12);
                    }

                    else if (vade == 24)
                    {
                        krediTutari = kredi + kesinti + (vade * faiz);
                        Console.WriteLine("Toplam Tutar=" + krediTutari);
                        Console.WriteLine("Aylık Tutar=" + krediTutari / 24);
                    }
                    else if (vade == 36)
                    {
                        krediTutari = kredi + kesinti + (vade * faiz);
                        Console.WriteLine("Toplam Tutar=" + krediTutari);
                        Console.WriteLine("Aylık Tutar=" + krediTutari / 36);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Vade Girişi Yaptınız.");
                    }
                }
                else if (krediTipi == "sigortasiz") // direkt else ile de yapabiliriz.
                {
                    double faiz = 1.59;
                    Console.WriteLine("Vade Giriniz.");
                    vade = Convert.ToInt32(Console.ReadLine());
                    if (vade == 6)
                    {

                        krediTutari = kredi + (vade * faiz);
                        Console.WriteLine("Toplam Tutar=" + krediTutari);
                        Console.WriteLine("Aylık Tutar=" + krediTutari / 6);
                    }

                    else if (vade == 18)
                    {
                        krediTutari = kredi + kesinti + (vade * faiz);
                        Console.WriteLine("Toplam Tutar=" + krediTutari);
                        Console.WriteLine("Aylık Tutar=" + krediTutari / 18);
                    }
                    else if (vade == 24)
                    {
                        krediTutari = kredi + (vade * faiz);
                        Console.WriteLine("Toplam Tutar=" + krediTutari);
                        Console.WriteLine("Aylık Tutar=" + krediTutari / 24);
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Vade Girişi Yaptınız.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Krediniz Onaylanmamıştır. İyi Günler Dileriz.");
            }
            Console.ReadLine();
            */
        }

        static double Hesapla()
        {
            int kredi;
            Console.WriteLine("Kredi Tutari Gir.");
            kredi = Convert.ToInt32(Console.ReadLine());
            double faiz = 1.59;
            int vade;
            Console.WriteLine("Vade Giriniz");
            vade = Convert.ToInt32(Console.ReadLine());
            kredi = Convert.ToInt32(Console.ReadLine());

            var krediTutari = kredi + (vade * faiz);
            return krediTutari;
        }
        
    }
}
