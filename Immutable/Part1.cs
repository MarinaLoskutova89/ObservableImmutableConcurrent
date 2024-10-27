using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    internal class Part1
    {
        public ImmutableList<string> Poem { get; private set; }
        public Part1(ImmutableList<string> poem)
        {
            Poem = AddPart(poem);
        }
        public ImmutableList<string> AddPart(ImmutableList<string> allPoem)
        {
            Poem = allPoem.Add("Вот дом,\r\nКоторый построил Джек.");
            return Poem;
        }
    }
}
