using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp52_Bilgi_Yarışması_Oyunu_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title="Bilgi Yarışması";
            Console.WriteLine("***********************");
            Console.WriteLine("BİLGİ YARIŞMASI");
            Console.WriteLine("***********************");

            Console.WriteLine("Yarışmaya HoşGeldiniz");

            string ad, soyad, meslek;

            Console.WriteLine("İsim Giriniz");
            ad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Soy Ad Giriniz");
            soyad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Meslek Giriniz");
            meslek = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Başlıyoruz Enter Tuşuna Basın");

            Console.WriteLine("Her Yanıttan Sonra Enter Tuşuna Basmayı Unutmayın");

            Console.WriteLine("Cevapları BÜYÜK HARFLER İLE YAZIN");

            Console.ReadLine();


            int dogru, yanlış, para;
            dogru = 0;
            yanlış = 0;
            para = 0;

            string soru1;

            Console.WriteLine("Soru-1:Cumhuriyet kaç yılında ilan edildi?");
            soru1 = Convert.ToString(Console.ReadLine());

            string cevap1;

            Console.WriteLine("Cevap-1:A)1920\n B)1923\n C)1925\n D)1927\n");
            cevap1 = Convert.ToString(Console.ReadLine());

            if (cevap1=="B")
            {
                dogru = dogru + 1;
                para = para + 1000;
                Console.WriteLine("Tebrikler Doğru Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                Console.WriteLine("Yanlış Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }


            string soru2;

            Console.WriteLine("Soru-2:Türkiye nin Başkenti Neresidir?");
            soru2 = Convert.ToString(Console.ReadLine());

            string cevap2;

            Console.WriteLine("Cevap-2:A)İstanbul\n B)İzmir\n C)Ankara\n D)Antalya\n");
            cevap2 = Convert.ToString(Console.ReadLine());

            if (cevap2=="C")
            {
                dogru = dogru+1;
                para = para + 1000;
                Console.WriteLine("Doğru Cevap Verdiniz.Enter Tuşuna Basın.");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış+1;
                Console.WriteLine("Yanlış Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }


            string soru3;

            Console.WriteLine("Soru-3: Maki Hangi Bölgenin Bitki Örtüsüdür");
            soru3 = Convert.ToString(Console.ReadLine());

            string cevap3;

            Console.WriteLine("Cevap-3: A)Akdeniz\n B)Karadniz\n C)Marmara\n D)Ege\n");
            cevap3 = Convert.ToString(Console.ReadLine());

            if (cevap3=="A")
            {
                dogru = dogru+1;
                para = para + 1000;
                Console.WriteLine("Doğru Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                Console.WriteLine("Yanlış Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }

            string soru4;

            Console.WriteLine("Soru-4:Hangisi İstanbulun Bir Semti Değildir");
            soru4 = Convert.ToString(Console.ReadLine());

            string cevap4;

            Console.WriteLine("Cevap-4:A)K.Çekmece\n B)Beşiktaş\n C)Sariyer\n D)Urla\n");
            cevap4 = Convert.ToString(Console.ReadLine());

            if (cevap4=="D")
            {
                dogru = dogru+1;
                para = para + 1000;
                Console.WriteLine("Doğru Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış+1;
                Console.WriteLine("Yanlış Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }


            string soru5;

            Console.WriteLine("Soru-5:Programlamanın temel renklerinden değildir");
            soru5 = Convert.ToString(Console.ReadLine());

            string cevap5;

            Console.WriteLine("Cevap-5:A)Kırmızı\n B)Yeşil\n C)Mavi\n D)Sarı");
            cevap5 = Convert.ToString(Console.ReadLine());

            if (cevap5=="D")
            {
                dogru = dogru+1;
                para = para + 1000;
                Console.WriteLine("Doğru Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış+1;
                Console.WriteLine("Yanlış Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }

            string soru6;

            Console.WriteLine("Soru-6:Avrupanın Kullandığı Para Birimi Nedir.");
            soru6 = Convert.ToString(Console.ReadLine());

            string cevap6;

            Console.WriteLine("Cevap-6:A)Euro\n B)Dolar\n C)Sterlin\n D)Ruble\n");
            cevap6 = Convert.ToString(Console.ReadLine());

            if (cevap6=="A")
            {
                dogru = dogru+1;
                para = para + 1000;
                Console.WriteLine("Doğru Cevap Verdiniz.Enter Tuşuna Basınız");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                Console.WriteLine("Yanlış Cevap Verdiniz.Enter Tuşuna Basınız");
                Console.ReadLine();
            }

            string soru7;

            Console.WriteLine("Soru-7: Hangi İlimiz Ege Bölgesinde Değildir");
            soru7 = Convert.ToString(Console.ReadLine());

            string cevap7;

            Console.WriteLine("Cevap-7:A)İstanbul\n B)Muğla\n C)Manisa\n D)İzmir\n");
            cevap7 = Convert.ToString(Console.ReadLine());

            if (cevap7=="A")
            {
                dogru = dogru+1;
                para = para + 1000;
                Console.WriteLine("Doğru Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış+1;
                Console.WriteLine("Yanlış Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }

            string soru8;

            Console.WriteLine("Soru-8:Süper ligde Sezonu Namağlup Bitiren Tek Kulüp Kimdir");
            soru8 = Convert.ToString(Console.ReadLine());

            string cevap8;

            Console.WriteLine("Cevap-8:A)Beşiktaş\n B)Trabzon\n C)Fenerbahçe\n D)Galatasaray\n");
            cevap8 = Convert.ToString(Console.ReadLine());

            if (cevap8=="A")
            {
                dogru = dogru+1;
                para = para + 1000;
                Console.WriteLine("Doğru Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();

            }
            else
            {
                yanlış = yanlış+1;
                Console.WriteLine("Yanlış Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }

            string soru9;

            Console.WriteLine("Soru-9:Sefiller Kitabının Yazarı Kimdir.");
            soru9 = Convert.ToString(Console.ReadLine());

            string cevap9;

            Console.WriteLine("Cevap-9:A)Jules Verne\n B)Gogol\n C)Tolstoy\n D)Victor Hugo\n");
            cevap9 = Convert.ToString(Console.ReadLine());

            if (cevap9=="D")
            {
                dogru = dogru+1;
                para = para + 1000;
                Console.WriteLine("Doğru Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();

            }
            else
            {
                yanlış = yanlış+1;
                Console.WriteLine("Yanlış Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }

            string soru10;

            Console.WriteLine("Soru-10:Mustafa Kemal Atatürk'ün Nüfusa Kayıtlı Olduğu İl Hangisidir");
            soru10 = Convert.ToString(Console.ReadLine());

            string cevap10;

            Console.WriteLine("Cevap-10:A)İstanbul\n B)Ankara\n C)Gaziantep\n D)İzmir\n");
            cevap10 = Convert.ToString(Console.ReadLine());


            if (cevap10=="C")
            {
                dogru = dogru+1;
                para = para + 1000;
                Console.WriteLine("Doğru Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }
            else
            {
                yanlış = yanlış + 1;
                Console.WriteLine("Yanlış Cevap Verdiniz.Enter Tuşuna Basın");
                Console.ReadLine();
            }


            Console.WriteLine("Adınız:" + ad);
            Console.WriteLine("Soy Adınız:" + soyad);
            Console.WriteLine("Meslek:" + meslek);
            Console.WriteLine("Doğru Sayınız:" + dogru);
            Console.WriteLine("Yanlış Sayınız:" + yanlış);
            Console.WriteLine("Toplam Kazanılan Ödül:" + para);
            Console.WriteLine();
            Console.WriteLine("OYUN BİTTİ.....");

            Console.Read();




















        }
    }
}
