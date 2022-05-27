using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            //First
            Console.WriteLine("Write some word");
            string line = Console.ReadLine();
            Console.WriteLine("Written word reversed:" + ReverseString(line));
            Console.WriteLine();
           //Second
           int[] numbers = new int[100];
            for(int i= 0; i < 100; i++)
                numbers[i] = random.Next();

            int min = int.MaxValue;
            int max = 0;
            FindMinMax(numbers, ref min, ref max);
            Console.WriteLine("Min value in array:"+min);
            Console.WriteLine("Max value in array:"+max);
            Console.WriteLine();
            //Third
            int[] numbers1 = new int[100];
            for (int i = 0; i < 100; i++)
            {
                if(i%2==0)
                    numbers1[i] = i;
                else
                    numbers1[i] = i-1;
            }
            
            int[] dub = new int[numbers1.Length];
            dub =FindDublicates(numbers1);
            Console.WriteLine("Numbers that repeated:"+string.Join(" ", dub));
            Console.WriteLine();
            //Fourth
            string line1 = "Programuotojo ar tiesiog bet kokio IT specialisto profesija taps vis labiau įprasta.";
            FindVowelsAndConsonant(line1);
        }
        static string ReverseString(string line)
        {
            var newline = new StringBuilder();
            for (int i=line.Length-1; i>=0; i--)
                newline.Append(line[i]);
           
            return newline.ToString();
        }
        public static void FindMinMax(int[] array, ref int min, ref int max)
        {
            for(int i=0; i<array.Length; i++)
            {
                if(array[i]<=min)
                    min = array[i];
                if (array[i]>=max)
                    max = array[i];
            }
        }
        public static int[] FindDublicates(int[] array)
        {
            List<int> nodublicates = new List<int>();
            List<int> dub = new List<int>();

            for (int i = 0; i < array.Length; i++)
            {
                if (nodublicates.Contains(array[i]))
                    dub.Add(array[i]);
                else
                    nodublicates.Add(array[i]);
            }
            return dub.ToArray();
        }
        public static void FindVowelsAndConsonant(string line)
        {
            var vowelCount = line.Count("aąęėįųūeiouyAĄĘĖEĮIOUY".Contains);
            var consonantCount = line.Count("BbCcČčDdFfGgHhJjKkLlMmNnPpRrSsŠšTtVvZzŽž".Contains);
            Console.WriteLine("Vowel count:" + vowelCount);
            Console.WriteLine("Consonant count: "+ consonantCount);
        }
    }
}
