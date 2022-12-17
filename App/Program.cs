using System.Threading;

var max = args.Length != 0 ? Convert.ToInt32(args[0]) : int.MaxValue;
for(var x = 0; x < max; x++)
{
    System.Console.WriteLine("Chug!");
    Thread.Sleep(500);
}