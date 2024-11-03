using System;
using System.Collections;

//შექმენით მეთოდი, რომელიც ორ პარამეტრს მიიღებს მომხმარებლისგან -  პირველ პარამეტრად იღებს მთელი რიცხვების მასივს (int[] array),
//მეორე პარამეტრად იღებს მთელ რიცხვს (int index),
//ორივე პარამეტრი მომხმარებელს უნდა შეავსებინოთ, მასივიც და მთელი რიცხვიც
//მეთოდმა უნდა ნახოს array-ში მოცემულ index-ზე რა რიცხვი წერია და უნდა დაითვალოს ამ რიცხვის ციფრების ჯამი, მაგალითად: 
//array { 116, 42, 123, 6, 7532 }
//index 2
//ინდექს 2-ზე წერია ელემენტი 123
//მეთოდმა უნდა დააბრუნოს 6 (1+2+3).

//საბოლოოდ, დაბეჭდეთ მეთოდისგან დაბრუნებული პასუხი.
namespace MyApp
{
    internal class Program
    {
        static void Main()
        {


            int[] array = new int[5];

            for (int i = 0;
                i < array.Length;
                i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }


            int index = int.Parse(Console.ReadLine());
            int digitSum = CalculateSum(array, index);
            Console.WriteLine("saboloo shedegi: " + digitSum);


            //int number = array[index];
            //int sum = 0;
            //while (number > 0)
            //{
            //    int digit = number % 10; // ბოლო ციფრის გამოთვლა
            //    sum += digit; // ციფრის დამატება ჯამში
            //    number /= 10; // ბოლო ციფრის გაწყვეტა
            //}
            //Console.WriteLine("cifrebis jami: " + sum);

        }

        static int CalculateSum(int[] array, int index)
        {
            int number = array[index];
            int sum = 0;

            //როგორ უნდა დამეჯამებინა მიღებული რიცხვები ვერ მივხვდი და ეს while ფორმულა მოვიძიე, 
            while (number > 0)
            {
                int digit = number % 10; // ბოლო ციფრის გამოთვლა
                sum += digit; // ციფრის დამატება ჯამში
                number /= 10; // ბოლო ციფრის გაწყვეტა
            }
            return sum;


        }
    }


}