﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tabuleiro;
using xadrez;

namespace xadrez
{
    class Program
    {
        static void Main(string[] args)
        {

            PosicaoXadrez pos = new PosicaoXadrez('b', 2);

            Console.WriteLine(pos);

            Console.WriteLine(pos.toPosicao());

            Console.ReadLine();
        }
    }
}
