using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValueReference
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Reference, value types
            //value types
            //int x = 10;
            //int y = x; //y=10
            //y = 20;
            //Console.WriteLine($"x: {x}");
            //Console.WriteLine($"y: {y}");
            //int a = 10;
            //ChangeNumber(a);
            //Console.WriteLine(a);
            //int number;
            //ChangeValue(out number);
            //Console.WriteLine(number);


            //reference types

            //int[] arr1 = { 10, 20, 30 };
            //int[] arr2 = arr1;
            //arr2[0] = 100;
            //int[] arr3 = arr2;
            //arr3[0] = 200;
            //Console.WriteLine($"arr1:{arr1[0]}");
            //Console.WriteLine($"arr2:{arr2[0]}");
            //string[] arrStr = new string[3];
            //Console.WriteLine(arrStr[0]);
            //arrStr[0] = null;
            //int[] arr = { 10, 100, 1000 };
            //ChangeIndex(arr);
            //Console.WriteLine(arr[0]);
            #endregion

            #region StringBuilder
            //Console.WriteLine(ChangeToString(new string[3] { "Zahid", "Javidan", "Seynur" }));
            //StringBuilder builder = new StringBuilder();
            //builder.Append("Zahid");
            //builder.Append("Osman");
            //builder.Clear();
            //builder.Insert(5, ",");
            //builder.Remove(6,5);
            //builder.Replace("Zahid", "Javidan");
            //Console.WriteLine(builder);
            //Console.WriteLine(ReverseWordOfSent("Salam qrup uzuvleri"));
            #endregion
        }

        #region Reference - value types,ref & out keyword
        //static void ChangeValue(out int num)
        //{
        //    num = 100;
        //    Console.WriteLine(num);
        //}
        //static void ChangeIndex(int[] arr)
        //{
        //    arr[0] = 20;
        //    Console.WriteLine(arr[0]);
        //}

        //static void ChangeNumber(int a)
        //{
        //    a = 100;
        //    Console.WriteLine(a);
        //}


        #endregion

        #region StringBuilder
        //homework - 2
        //static StringBuilder ReverseWordOfSent(string senteces)
        //{
        //    StringBuilder result = new StringBuilder();
        //    string[] arr = senteces.Split(' ');
        //    foreach (string item in arr)
        //    {
        //        for (int i = item.Length-1; i >= 0; i--)
        //        {
        //            result.Append(item[i]);
        //        }
        //        if (item != arr[arr.Length - 1])
        //            result.Append(" "); 
        //    }

        //    return result;
        //}

        //homework - 1
        //static StringBuilder ChangeToString(string[] arr)
        //{
        //    StringBuilder result=new StringBuilder();
        //    result.Append(arr[0]);
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        result.Append("," + arr[i]);
        //    }
        //    return result;
        //}
        //static string ChangeToString(string[] arr)
        //{
        //    string result = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        result += "," + arr[i];
        //    }
        //    return result;
        //}
        #endregion
    }
}
