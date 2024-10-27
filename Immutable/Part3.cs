using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    internal class Part3
    {
        public ImmutableList<string> Poem { get; private set; }
        public Part3(ImmutableList<string> poem)
        {
            Poem = AddPart(poem);
        }
        public ImmutableList<string> AddPart(ImmutableList<string> allPoem)
        {
            string _part3 = "\nА это веселая птица-синица," +
            "\r\nКоторая часто ворует пшеницу," +
            "\r\nКоторая в темном чулане хранится" +
            "\r\nВ доме," +
            "\r\nКоторый построил Джек.";

            Poem = allPoem.Add(_part3);
            return Poem;
        }
    }
}
