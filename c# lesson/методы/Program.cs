using System;

namespace Name{

    class Program{
        static void Main(){
            // Print("Hello");
            // string words = "Hello world";
            // Print(words);
            int res1 = Summa(10, 5);
            int a = 4, b = 7;
            int res2 = Summa(a, b);

            Print(res1.ToString());
            Print(res2.ToString());
        }
        public static void Print(string word){
            
            Console.WriteLine(word);
            
        }
        public static int Summa(int x, int y){
            return x + y;
        }

    }

}
