using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    internal class Part2
    {
        public ImmutableList<string> Poem { get; private set; }
        public Part2(ImmutableList<string> poem)
        {
            Poem = AddPart(poem);
        }
        public ImmutableList<string> AddPart(ImmutableList<string> allPoem)
        {
            string _part2 = "\nА это пшеница," +
            "\r\nКоторая в темном чулане хранится," +
            "\r\nВ доме," +
            "\r\nКоторый построил Джек.";

            Poem = allPoem.Add(_part2);
            return Poem;
        }
    }
}
