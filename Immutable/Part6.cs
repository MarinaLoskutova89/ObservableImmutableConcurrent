﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Immutable
{
    internal class Part6
    {
        public ImmutableList<string> Poem { get; private set; }
        public Part6(ImmutableList<string> poem)
        {
            Poem = AddPart(poem);
        }
        public ImmutableList<string> AddPart(ImmutableList<string> allPoem)
        {
            string _part6 = "\nА это корова безрогая," +
            "\r\nЛягнувшая старого пса без хвоста," +
            "\r\nКоторый за шиворот треплет кота," +
            "\r\nКоторый пугает и ловит синицу," +
            "\r\nКоторая часто ворует пшеницу," +
            "\r\nКоторая в темном чулане хранится" +
            "\r\nВ доме," +
            "\r\nКоторый построил Джек."; 

            Poem = allPoem.Add(_part6);
            return Poem;
        }
    }
}
