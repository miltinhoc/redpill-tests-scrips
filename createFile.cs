using System.IO;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("a.txt", "test");
        }
    }
}
