using System;
using System.Threading.Tasks;

namespace async
{
    class Program
    {
        public static void Main(string[] args)
        {
            AsynClass aobj = new AsynClass();
            aobj.DoStuff();

            for(int i=0;i<1000;i++)
            {
                Console.WriteLine("THis is from the main thread " + i);
            }
        }
    }

    public class AsynClass
    {
        public async Task DoStuff()
        {
            await Task.Run(() => LongRunningTask());
        }

        private static async Task LongRunningTask()
        {
            int counter = 0;
            for (int i = 0; i <= 500; i++)
            {
                Console.WriteLine("Async class = " + i);
                counter += 1;
            }
        }
    }
}