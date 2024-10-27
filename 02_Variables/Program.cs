using Microsoft.CSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_variables
{
    internal class Program2
    {


        static void Main(string[] args)
        {



            #region Double değişkenler

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberryPrice, potatoPrice, tomatoPrice;



            //applePrice = 14.85;
            //orangePrice = 20.95;
            //strawberryPrice = 45;
            //potatoPrice = 9.74;
            //tomatoPrice = 6.88;

            //Console.WriteLine("-> Elma Birim Fiyatı: " + applePrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("-> Portakal Birim Fiyatı: " + orangePrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("-> Çilek Birim Fiyatı: " + strawberryPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("-> Patates Birim Fiyatı: " + potatoPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine("->Domates Birim Fiyatı: " + tomatoPrice + "TL");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("------------------------------------------------------------------------------------------");

            //Console.WriteLine();
            //Console.WriteLine();

            //double appleGram, orangeGram, strawberryGram, potatoGram, tomatoGram;

            //appleGram = 1.245;
            //orangeGram = 2.650;
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double appleTotalPrice = appleGram * applePrice;
            //double orangeTotalPrice = orangeGram * orangePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan ürün: Elma - " + "Birim fiyat:" + applePrice + " - Gramaj:" + appleGram + " - Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün: Portakal - " + "Birim fiyat:" + orangePrice + " - Gramaj:" + orangeGram + " - Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün: Çilek - " + "Birim fiyat:" + strawberryPrice + " - Gramaj:" + strawberryGram + " - Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün: Patates - " + "Birim fiyat:" + potatoPrice + " - Gramaj:" + potatoGram + " - Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine();
            //Console.WriteLine("Alınan ürün: Domates - " + "Birim fiyat:" + tomatoPrice + " - Gramaj:" + tomatoGram + " - Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalprice = appleTotalPrice + strawberryTotalPrice + orangeTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("--------------------------------------------------------------------------------------------------------------------");
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(" => Alışveriş Toplam Tutar <= : " + shoppingTotalprice + " TL");
            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';

            #endregion

            #region Klavyeden Veri Girişi

            //Console.WriteLine("**** CSharp Hava Yolları Yolcu Bilgisi****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentyNumber;

            //Console.Write("YOLCU ADI: ");
            //passengerName = Console.ReadLine();

            ////Console.WriteLine();

            //Console.Write("YOLCU SOYADI: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İL ADI: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("İLÇE ADI: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("YOLCU YAŞI: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("YOLCU *TC* KİMLİK NO: ");
            //passengerIdentyNumber = Console.ReadLine();

            //Console.WriteLine();


            //Console.WriteLine("---------------------------------");

            //Console.WriteLine();

            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentyNumber + " - Yolcu Adı Soyadı: " + passengerName + " " + passengerSurname + " " + passengerCity + "/" + passengerDistrict + " " + passengerAge + " ");
            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;
            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;
            //Console.Write("Lütfen aldığınız ayakkabı sayısını giriniz! : ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız bilgisayar sayısını giriniz! :");
            //computerCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız sandalye sayısını giriniz! :");
            //chairCount = int.Parse(Console.ReadLine());

            //Console.Write("Lütfen aldığınız televizyon sayısını giriniz! :");
            //tvCount = int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount * shoesPrice + computerCount * computerPrice + chairCount * chairPrice + tvCount * tvPrice;
            //Console.WriteLine();
            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar! : " + totalPrice);


            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz: ");
            //exam1 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz: ");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz: ");
            //exam3 = double.Parse(Console.ReadLine());

            //result = (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);


            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("Lütfen Cinsiyet Seçiniz: ");
            //gender = char.Parse(Console.ReadLine());

            //Console.WriteLine("Seçtiğiniz Cinsiyet : " + gender);

            #endregion

            Console.Read();
        }
    }
}