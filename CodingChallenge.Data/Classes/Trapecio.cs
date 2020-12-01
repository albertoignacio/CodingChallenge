using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Trapecio : Forma
    {
        #region Properties

        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Base3 { get; set; }

        public double Base4 { get; set; }
        public double Altura { get; set; }

        #endregion

        public Trapecio() { }

        public Trapecio(int idiomaTipo, double base1, double base2, double base3, double base4, double altura) : base(idiomaTipo)
        {
            Base1 = base1;
            Base2 = base2;
            Base3 = base3;
            Base4 = base4;
            Altura = altura;
        }

        public override string TraducirForma(bool plural = false)
        {
            return plural ? base.idioma.Trapecios : base.idioma.Trapecio;
        }

        public override double CalcularArea()
        {
            return ((Base1 + Base2) / 2)*Altura;
        }

        public override double CalcularPerimetro()
        {
            return (Base1 + Base2 + Base3 + Base4);
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
