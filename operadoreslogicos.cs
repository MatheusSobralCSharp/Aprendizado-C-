using System;

namespace Curso{
        class Programa{
            static void Main(string[] args) {
               
               bool c1 = 2 > 3 && 4 != 5;
               bool c2 = 2 > 3 || 4 != 5;
               bool c3 = !(2 > 3) && 5 != 5;

               Console.WriteLine(c1);

               bool c4 = 10 < 5; //false
               
               bool c5 = c1 || c2 && c3;
            }
        }
}

