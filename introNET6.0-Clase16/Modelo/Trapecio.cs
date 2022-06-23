﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introNET6._0_Clase16.Modelo
{
    public sealed class Trapecio : Cuadrilatero
    {
        public Trapecio(int valorX1, int valorY1, int valorX2, int valorY2, int valorX3, int valorY3, int valorX4, int valorY4): base(valorX1,valorY1,valorX2,valorY2,valorX3,valorY3, valorX4, valorY4) { }

        public override int CalcularArea()
        {
            int resultado;

            int[] arrayX = { ValorX1, ValorX2, ValorX3, ValorX4 };
            int[] arrayY = { ValorY1, ValorY2, ValorY3, ValorY4 };

            int ladoX = Mayor(arrayX) - Menor(arrayX); //base 1
            int ladoY = Mayor(arrayY) - Menor(arrayY); //altura

            int[] valorBase = Sort(arrayX);

            int valorA = valorBase[1];
            int valorB = valorBase[2];

            int baseB = valorB - valorA;

            resultado = ((ladoX + baseB) / 2) * ladoY;

            return resultado;
        }

    }
}