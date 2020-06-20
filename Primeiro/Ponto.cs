using System;
using System.Collections.Generic;
using System.Text;

namespace Primeiro
{
    struct Ponto
    {
        public double X;
        public double Y;

        public override string ToString()
        {
            return $"X: {X} Y: {Y}";
        }
    }
}
