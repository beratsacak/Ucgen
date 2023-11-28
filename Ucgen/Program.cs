using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ucgen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucgen ucgen = new Ucgen();
            ucgen.A = 10;
            ucgen.B = 6;
            ucgen.C = 11;
            Console.WriteLine("A degeri={0},C degeri={1},B degeri ={2}",ucgen.A,ucgen.B,ucgen.C);

        }
    }
    public class Ucgen
    {
        int a;
        int b;
        int c;
        public int A 
        {
            get
            {
                return a;
            }
            set
            {
                if (0>= value) 
                {
                    Console.WriteLine("Hatalı Bilgi Girildi");
                }
                else
                {
                    a= value;
                }
            }
        }
        public int B 
        {
            get
            {
                return b;
            }
            set
            {
                if(0>= value)
                {
                    Console.WriteLine("Hatalı Bilgi Girişi");
                }
                else
                {
                    b= value;
                }
            }
        }
        public int C 
        {
            get
            {
                return c;
            }
            set 
            {
                if ( 0 >= value )
                {
                    Console.WriteLine("Hatalı Bilgi Girişi");
                }
                else
                {
                    c= value;
                }
            }
        }
    }
}
