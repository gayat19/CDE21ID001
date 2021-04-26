using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UnderstandingAsynProject
{
    class UnderstandingTask
    {
        static void Main(string[] args)
        {
            Task<int> tsk = Task.Run(() =>
            {
                int _sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    _sum += i;
                    Console.WriteLine(i);
                }
                return _sum;
            });
            tsk.Wait();
            if(tsk.IsCompleted)
            {
                Console.WriteLine(tsk.Result);
            }
            Console.ReadKey();
        }
    }
}
