using System;
using System.Linq;

namespace ToolTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("dotnet tool 功能测试");
            Console.WriteLine(string.Join(',', args));
            Console.WriteLine($"工具所在目录{AppContext.BaseDirectory}");
        }
    }
}
