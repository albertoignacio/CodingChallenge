using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : Forma
    {
        public Cuadrado() {}

        public Cuadrado(int idiomaTipo, double lado): base(idiomaTipo) 
        {
            Lado = lado;
        }
        
        public override string TraducirForma(bool plural = false)
        {
            return plural ? base.idioma.Cuadrados : base.idioma.Cuadrado;
        }
        public override double CalcularArea()
        {
            return Lado * Lado;
        }

        public override double CalcularPerimetro()
        {
            return Lado * 4;
        }

        public override string ObtenerLinea()
        {
            return $"1 {TraducirForma()} | {base.idioma.Area} {CalcularArea():#.##} | {base.idioma.Perimetro} {CalcularPerimetro():#.##} <br/>";
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
