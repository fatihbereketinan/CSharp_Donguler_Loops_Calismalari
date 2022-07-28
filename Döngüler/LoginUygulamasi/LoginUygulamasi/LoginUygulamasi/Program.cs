using System;

namespace LoginUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            string isim = "Fatih";
            string sifre = "qwerty";
            int deneme = 0;

            Console.WriteLine("*****Kullanıcı Giriş Sayfasına Hoş Geldiniz.*****");

            while (true)
            {
                Console.Write("Lütfen kullanıcı adınızı giriniz: ");
                string kullaniciadi = Console.ReadLine();
                Console.Write("Lütfen sifrenizi giriniz: ");
                string kullaniciSifresi = Console.ReadLine();

                if (isim == kullaniciadi)
                {
                    if (sifre == kullaniciSifresi)
                    {
                        Console.WriteLine("Tebrikler başarılı bir şekilde giriş yaptınız..");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Kullanıcı adı veya şifresi hatalı. Lütfen tekrar deneyiniz.");
                    deneme = deneme + 1;

                    if (deneme == 3)
                    {
                        Console.WriteLine("3 kere hatalı giriş yaptınız. İşleminiz sonlandırılıyor...");
                        break;
                    }
                }
            }
        }
    }
}
