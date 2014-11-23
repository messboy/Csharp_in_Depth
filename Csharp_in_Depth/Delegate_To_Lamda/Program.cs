using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_To_Lamda
{
    class Program
    {
        static void Main(string[] args)
        {
            //Func是一個委派類型 <參數 參數...,最後一個是回傳型別>
            Func<string, int> returnLength;

            //1.以匿名方法開始
            returnLength = delegate(string text) { return text.Length; };

            //2.Lambda
            returnLength = (string text) => { return text.Length; };

            //3.單個表達是
            returnLength = (text) => text.Length;

            //4.不用刮號
            returnLength = x => x.Length;

            Console.WriteLine(returnLength("Hello"));
        }
    }
}
