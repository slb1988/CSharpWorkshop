using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    /// <summary>
    /// https://docs.microsoft.com/en-us/dotnet/api/system.threading.threadlocal-1?view=net-5.0
    /// </summary>
    class ThreadLocalDemo
    {
        public static void Main()
        {
            Console.WriteLine("haha");
            ThreadLocal<string> ThreadName = new ThreadLocal<string>(() =>
            {
                return "Thread " + Thread.CurrentThread.ManagedThreadId;
            });

            Action action = () =>
            {
                bool repeat = ThreadName.IsValueCreated;

                Console.WriteLine("ThreadName {0} {1}", ThreadName.Value, repeat ? "(repeat)" : "");
            };

            Parallel.Invoke(action, action, action, action, action, action, action, action, action, action, action, action);

            ThreadName.Dispose();

            Console.ReadLine();
        }
    }
}
