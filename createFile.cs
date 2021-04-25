using System.Diagnostics;
namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.File.WriteAllText("a.txt", "test");
        }
    }
}
