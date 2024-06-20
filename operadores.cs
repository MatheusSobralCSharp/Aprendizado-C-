using System;
using System.Globalization;

namespace Curso{
        class Programa{
            static void Main(string[] args) {
                //++a; a++; (implementa números, ++a implementa ambos e a++; implementa somente a variável a)
               int a = 10;
               a += 2;
               a -= 2;
               a *= 2;

               string s = "ABC";
               s += "CDEF";
               Console.WriteLine(s);

            }
        }
}

