using System;
using System.Threading;

namespace ConsoleApp10
{
    /// <summary>
    /// https://www.c-sharpcorner.com/article/overview-of-threadstatic-attribute-in-c-sharp/
    /// </summary>
    class ThreadStaticAttributeDemo
    {
        static int StaticId;
        [ThreadStatic]
        static int ThreadStaticId = 2;

        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Hello World!");
        //    for (int i =1; i <= 5; i++)
        //    {
        //        Thread newThread = new Thread(() => IncrementId());
        //        newThread.Name = i.ToString();
        //        newThread.Start();
        //    }

        //    Console.ReadLine();
        //}

        private static void IncrementId()
        {
            StaticId++;
            ThreadStaticId++;
            Console.WriteLine("Static ID Value in thread" + Thread.CurrentThread.Name + " is " + StaticId);
            Console.WriteLine("Thread Static ID Value in thread" + Thread.CurrentThread.Name + " is " + ThreadStaticId);
        }
    }
}
