using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class Program
    {
        /*
         * Kalıtım (Miras) Nedir?
         * 
         * Nesneye dayalı programlamanın en önemli özelliklerinden biridir. Kalıtım yolu ile sınıflar
         * birbirinden türetilebilir. Bir sınıf diğer bir sınıftan türediği zaman, türediği sınıfın
         * bütün özelliklerini içerir. Bunun yanında kendisine has özellikeri de barındırabilir.
         * 
         */
        static void Main(string[] args)
        {
            B b = new B();

            b.degisken_1 = 10;
            b.Metot_1();

            b.degisken_2 = 20;
            b.Metot_2();


            /*
             * Türetme işleminden dolayı B sınıfı, A sınıfına ait tüm özellikleri kendi içinde 
             * tanımlanmış gibi kullanabilmektedir.
             * 
             * [Dikkat]: Türetilmiş sınıf temel sınıf içerisindeki özellikeri kendi içerisinde
             * tanımlanmış gibi kullanabilir fakat temel sınıf, türetilmiş sınıf içerisindeki
             * özellikleri kullanamaz!
             */
            Console.ReadLine();
        }
    }
}
