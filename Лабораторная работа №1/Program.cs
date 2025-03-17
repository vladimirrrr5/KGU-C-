using Za1;

namespace Name
{
    public class Program{
        static void Main(string[] args){
            int n = 50;
int ch = 2;
List <int> mas = new List<int>();

for (int i = 0; i < n-1; i++)
    {
        mas.Add(ch);
        ch += 1;
        
    }
int count = 2;
while (count * count <= n)
    {
        for (int i = count * 2; i <= n + 1; i += count)
        {
            int index = mas.IndexOf(i);
            if (index != -1)
            {
                mas[index] = 0;
            }
            
        }
       
        count ++;
        
    }

Console.WriteLine("Простые числа:");
        foreach (int num in mas)
        {
            if (num != 0)
            {
                Console.WriteLine(num);
            }
        }
        F2 f2 =new F2();
        f2.B1();
        }
    }

}

