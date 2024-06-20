using System;

namespace Course{
    class Dark{
        static void Main(string[] args){

            Console.WriteLine("Boa noite");
            int x = int.Parse(Console.ReadLine());


            if(x % 2 == 0){
                Console.WriteLine("Par");
            }

            else if(x % 3 == 0){
                Console.WriteLine("Dois");
                Console.WriteLine("Dois");
            }

            else{
                Console.WriteLine("Impar");
            }
        }

    }
}