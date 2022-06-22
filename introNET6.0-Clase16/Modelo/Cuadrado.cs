using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introNET6._0_Clase16.Modelo
{
    public sealed class Cuadrado : Cuadrilatero
    {
        public Cuadrado(int ValorX1,int ValorY1, int ValorX2, int ValorY2, int ValorX3, int ValorY3, int ValorX4, int ValorY4)
        {
            this.ValorX1 = ValorX1;
            this.ValorY1 = ValorY1;
            this.ValorX2 = ValorX2;
            this.ValorY2 = ValorY2;
            this.ValorX3 = ValorX3;
            this.ValorY3 = ValorY3;
            this.ValorX4 = ValorX4;
            this.ValorY4 = ValorY4;
        }

        public override int CalcularArea()
        {
            int resultado;

            int[] arrayX = { ValorX1, ValorX2, ValorX3, ValorX4 };
            int[] arrayY = { ValorY1, ValorY2, ValorY3, ValorY4 };

            int ladoX = Mayor(arrayX)-Menor(arrayX);
            int ladoY = Mayor(arrayY)-Menor(arrayY);

            resultado = ladoX * ladoY;

            return resultado;
        }
    }
}
