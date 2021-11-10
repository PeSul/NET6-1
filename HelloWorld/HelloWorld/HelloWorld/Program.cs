using System;
using System.Collections.Generic;
using System.IO;
using HelloWorld.Data;
using HelloWorld.Model;
using System.Linq;

namespace HelloWorld
{
    class Program
    {

        static void Main(string[] args)
        {

            var numbers = new[] { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var strings = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var numTOstring = numbers.Select(n => strings[n]);
            //var numTOstring = strings.Select(s => s.ToUpper());
            var numTOstring = strings.Select(s => s.ToLower() + " " + s.ToUpper());

            PrintJoin<string>(numTOstring);

            //foreach (var item in numTOstring)
            //{
            //    Console.WriteLine(item);
            //}

            static void PrintJoin<T>(IEnumerable<T> items)
            {
                Console.WriteLine(string.Join(", ", items));
            }


            //int[] numbers = { -2079, -498, 2920, -1856, 332, -2549, -674, -120, -992, 2782, 320, -524, 135, 952, 1868, 2509, -230, -138, -904, -480 };

            /// z "numebers" zjistěte:
            /// 1. počet prvků v poli
            //var count = numbers.Count();
            //Console.WriteLine(count);
            /// 2. největší hodnotu
            //var max = numbers.Max();
            //Console.WriteLine(max);
            /// 3. nejmenší hodnotu
            //var min = numbers.Min();
            //Console.WriteLine(min);
            /// 4. průměr
            //var average = numbers.Average();
            //Console.WriteLine(average.ToString());
            /// 5. kolik obsahuje pole kladných čísel
            //var countpositive = numbers.Where(x => x>= 0).Count();
            //var countpositive = numbers.Count(x => x >= 0);
            //Console.WriteLine(countpositive);
            /// 6. kolik obsahuje pole záporných čísel
            //var countnegative = numbers.Count(x => x < 0);
            //Console.WriteLine(countnegative);
            /// 7. sumu všech hodnot
            //var sumtotal = numbers.Sum();
            //Console.WriteLine(sumtotal);
            /// 8. sumu kladných hodnot
            //var sumpositive = numbers.Where(x => x > 0).Sum();
            //Console.WriteLine(sumpositive);
            /// seřaďte pole od njmenší po největší hodnoty,
            ///9. přeskočte první 3 prvky a sečtěte zbytek
            //var result = numbers.OrderBy(x => x).Skip(3).Sum();
            //Console.WriteLine(result);
            ///10.Najděte tři největší tři absolotní hodnoty
            //var maxabs = numbers.OrderByDescending(x => System.Math.Abs(x)).Take(3);
            //var maxabs = numbers.OrderByDescending(x => System.Math.Abs(x)).Take(3);
            //Console.WriteLine("maxabs: " + string.Join(", ",maxabs));

            //Select transformace

            //var result = numbers.Select(number => number + 10);
            //var result = numbers.Select(x => System.Math.Abs(x))
            //    .OrderByDescending(x => x)
            //    .Take(3);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

        }

    }



    }

//ARCH
//int[] numbers = { 1, 2, -30, 4, 20, 256, -45, 99 };

/*
// where  - filtruje kolekci => "lambda výraz"

//where pomocí složené podmínky
var result = numbers.Where(number => number > 0 && number < 100);

foreach (var item in result)
{
    Console.WriteLine(item);
}

//where pomocí řetězení
var result1 = numbers
    .Where(number => number > 0)
    .Where(number => number < 100);

foreach (var item in result1)
{
    Console.WriteLine(item);
}

// řazení
var result2 = numbers.OrderBy(number => number);

foreach (var item in result2)
{
    Console.WriteLine(item);
}

*/

//přeskočení nebo oseknutí
//take, skip
//var result3 = numbers.SkipWhile(n => n > 0);
//var result3 = numbers.TakeWhile(n => n > 0);


//foreach (var item in result3)
//{
//    Console.WriteLine(item);

//var result4 = numbers.Sum();
//var result4 = numbers.Max();
//var result4 = numbers.Average();
//var result4 = numbers.First();
//var result4 = numbers.Last();


//Console.WriteLine(result4);

