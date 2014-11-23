using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

            //*************************************************************

            //Action是一種void的委派類型,搭配lambda
            Action<Films> print = film => Console.WriteLine("Name:{0}, Year:{1}", film.Name, film.Year);

            //Pridecate是一種回傳bool的委派類型
            Predicate<Films> isCheck = film => film.Year >= 1980;

            //電影列表
            var films = new List<Films>
            {
                new Films {Name = "Jams", Year = 1975},
                new Films {Name = "aams", Year = 1985},
                new Films {Name = "bams", Year = 1985},
                new Films {Name = "cams", Year = 1905},
                new Films {Name = "Jams", Year = 1945},
                new Films {Name = "Jams", Year = 1975},
            };

            //回圈列出
            films.ForEach(print);
            Console.WriteLine();

            //篩選後列印
            films.FindAll(isCheck).ForEach(print);
            Console.WriteLine();

            //排序
            films.Sort((f1, f2) => f1.Name.CompareTo(f2.Name));
            films.ForEach(print);
        }
    }
}
