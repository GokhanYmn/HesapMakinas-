namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char islem;
            double sayi1, sayi2, sonuc;
            Console.WriteLine("1. Sayı giriniz");
            sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2. Sayı giriniz");
            sayi2 = Convert.ToDouble(Console.ReadLine());
            sonuc = 0;

            Console.WriteLine("İşlem seçiniz : [+|-|*|/] çıkış yapmak için boş geçiniz");
            islem = Convert.ToChar(Console.ReadLine());



            switch (islem)
            {

                case '+':
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine(sonuc);
                    break;
                case '-':
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine(sonuc);
                    break;
                case '*':
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine(sonuc);
                    break;
                case '/':
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine(sonuc);
                    break;
                default:
                    Console.WriteLine();
                    break;


            }
        }
    }
}