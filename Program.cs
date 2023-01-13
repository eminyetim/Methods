using System;

namespace Methods
{
    class Program 
    {
        public static void Main(string[] args)
        {
            int a = 5;
            int b = 3;

           Methotlar ornek = new Methotlar();
           int sonuc = ornek.arttirVeTopla(ref a , ref b);
           ornek.EkranaYazdir(Convert.ToString(sonuc));
           ornek.EkranaYazdir(Convert.ToString(Topla(a,b)));

        }
    
        private static int Topla(int a , int b)
        {
            return (a+b);
        }
    }

    class Methotlar
    {
        public  void EkranaYazdir(string data)
        {
            System.Console.WriteLine("Sonuc :"+data);
        }

        public  int arttirVeTopla(ref int a , ref int b)
        {
            a+=1;
            b+=1;
            return (a + b);
        }
    }
}