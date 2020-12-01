using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class FormasGrupo : Forma
    {
        private List<Forma> FormaGeometricaLista { get; set; } = new List<Forma>();

        //private readonly ILocalization Localization;

        //public FormaGroup(ILocalization localization)
        //{
        //    this.Localization = localization;
        //}

        public FormasGrupo() { }

        public FormasGrupo(List<Forma> list)
        {
            this.FormaGeometricaLista = list;
        }

        public override double CalcularArea()
        {
            double area = 0;
            foreach (var forma in FormaGeometricaLista)
                area += forma.CalcularArea();
            return area;
        }

        public override double CalcularPerimetro()
        {
            double perimetro = 0;
            foreach (var forma in FormaGeometricaLista)
                perimetro += forma.CalcularPerimetro();

            return perimetro ;
        }

        public override string ObtenerLinea()
        {
            if(FormaGeometricaLista.Any())
            {
                if (FormaGeometricaLista.Any() && FormaGeometricaLista.Count > 0)
                    return $"{GetListCount()} {FormaGeometricaLista.FirstOrDefault().TraducirForma(true)} | {base.idioma.Area} {CalcularArea():#.##} | {base.idioma.Perimetro} {CalcularPerimetro():#.##} <br/>";
            }
            return string.Empty;
        }

        public override int GetListCount()
        {
            return FormaGeometricaLista.Count();
        }


        public override void Add(Forma forma)
        {
            FormaGeometricaLista.Add(forma);
            this.idioma = forma.idioma;
        }

        public override void Remove(Forma forma)
        {
            throw new NotImplementedException();
        }
    }
}
