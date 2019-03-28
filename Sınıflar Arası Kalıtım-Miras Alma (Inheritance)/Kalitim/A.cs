using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim
{
    class A
    {
        public int degisken_1;

        public void Metot_1()
        {
            Console.WriteLine("A sınıfının Metodu");
        }
    }

    class B : A
    {
        public int degisken_2;

        public void Metot_2()
        {
            Console.WriteLine("B sınfının metodu");
        }
    }

    /*
     * Yukarıdaki örnekte A temel sınıf, B ise türetilmiş sınıftır. B sınıfı kalıtım yolu ile A
     * sınıfındaki değişken ve metotları kalıtım yolu ile almıştır.
     */
}
