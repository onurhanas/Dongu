using System;

namespace Dongu
{
    internal class Program
    {
        static void Main(string[] args)
        {   Console.Write("Bir sayı giriniz: ");
            int sayac =int.Parse(Console.ReadLine());
             for (int i =1; i < sayac; i++)
            {
                if(i%2==1){
                    Console.WriteLine(i);
                }
            }
            int tekToplam =0;
            int ciftToplam=0;
            for (int i = 1; i <=1000; i++)
            { if(i%2==1){
                    tekToplam+=i;

                }
                else{
                    ciftToplam+=i;
                }
                
            }
            Console.WriteLine(tekToplam);
            Console.WriteLine(ciftToplam);
        }
    }
}