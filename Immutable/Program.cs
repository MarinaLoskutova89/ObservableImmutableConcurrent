using System.Collections.Immutable;
using System.IO;
using System.Net;

namespace Immutable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var MyPart1 = new Part1(ImmutableList<string>.Empty);
            var MyPart2 = new Part2(MyPart1.Poem);
            var MyPart3 = new Part3(MyPart2.Poem);
            var MyPart4 = new Part4(MyPart3.Poem);
            var MyPart5 = new Part5(MyPart4.Poem);
            var MyPart6 = new Part6(MyPart5.Poem);
            var MyPart7 = new Part7(MyPart6.Poem);
            var MyPart8 = new Part8(MyPart7.Poem);
            var MyPart9 = new Part9(MyPart8.Poem);

            Console.WriteLine(string.Join("\r\n", MyPart1.Poem) + Environment.NewLine);
            Console.WriteLine(string.Join("\r\n", MyPart2.Poem) + Environment.NewLine);
            Console.WriteLine(string.Join("\r\n", MyPart3.Poem) + Environment.NewLine);
            Console.WriteLine(string.Join("\r\n", MyPart4.Poem) + Environment.NewLine);
            Console.WriteLine(string.Join("\r\n", MyPart5.Poem) + Environment.NewLine);
            Console.WriteLine(string.Join("\r\n", MyPart6.Poem) + Environment.NewLine);
            Console.WriteLine(string.Join("\r\n", MyPart7.Poem) + Environment.NewLine);
            Console.WriteLine(string.Join("\r\n", MyPart8.Poem) + Environment.NewLine);
            Console.WriteLine(string.Join("\r\n", MyPart9.Poem));
        }
    }
}
