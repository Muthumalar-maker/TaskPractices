using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using TaskPractices;

class Program
{
    public static async Task Main(string[] args)
    //public static void Main(String[] args)
    {
        LearnAsyncProgramming Obj = new LearnAsyncProgramming();

        await Obj.Run();

        Console.WriteLine();
        
    }
}