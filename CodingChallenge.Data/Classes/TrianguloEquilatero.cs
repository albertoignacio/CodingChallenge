using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : Forma
    {
        public TrianguloEquilatero() { }

        public TrianguloEquilatero(int idiomaTipo, double lado) : base(idiomaTipo)
        {
            Lado = lado;
        }

        public override string TraducirForma(bool plural = false)
        {
            return plural ? base.idioma.TriangulosEquilateros : base.idioma.TrianguloEquilatero;
        }

        public override double CalcularArea()
        {
            return ((double)Math.Sqrt(3)/4)*Lado*Lado;
        }

        public override double CalcularPerimetro()
        {
            return Lado*3;
        }

        public override string ObtenerLinea()
        {
            return $"1 {CalcularArea():#.##} | ";
        }

        public override int GetListCount()
        {
            return 1;
        }

        public override void Add(Forma forma)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Forma forma)
        {
            throw new NotImplementedException();
        }

    }
}
