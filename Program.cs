using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Console.WriteLine("Program started");

        Task task1 = DownloadData();
        Task task2 = ProcessData();

        Console.WriteLine("Main method continues working...");

        await task1;
        await task2;

        Console.WriteLine("Program finished");
    }

    static async Task DownloadData()
    {
        Console.WriteLine("Downloading data...");

        await Task.Delay(3000); // simulate 3 second work

        Console.WriteLine("Download complete");
    }

    static async Task ProcessData()
    {
        Console.WriteLine("Processing data...");

        await Task.Delay(2000); // simulate 2 second work

        Console.WriteLine("Processing finished");
    }
}