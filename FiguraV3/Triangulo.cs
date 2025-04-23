using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguraV3
{
    internal class Triangulo : Figura
    {
        private float bT;
        private float hT;

        public Triangulo(float bT, float hT)
        {
            this.bT = bT;
            this.hT = hT;
        }

        public override float CalculateArea()
        {
            return (bT * hT) / 2;
        }
    }
}
