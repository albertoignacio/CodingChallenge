using CodingChallenge.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Forma : IForma
    {
        public Idiomas idioma = new Idiomas(1);
        public double Lado { get; set; }

        public Forma()
        {
        }

        public Forma(int idiomaTipo)
        {
            idioma.ObtenerIdioma(idiomaTipo);
        }

        public virtual double CalcularArea()
        {
            throw new NotImplementedException();
        }

        public virtual double CalcularPerimetro()
        {
            throw new NotImplementedException();
        }

        public virtual string ObtenerLinea()
        {
            throw new NotImplementedException();
        }

        public virtual int GetListCount()
        {
            throw new NotImplementedException();
        }

        public abstract void Add(Forma forma);
        public abstract void Remove(Forma forma);

        public virtual string TraducirForma(bool plural)
        {
            throw new NotImplementedException();
        }

        public void Traducir(int idiomaTipo)
        {
            idioma.ObtenerIdioma(idiomaTipo);
        }
        public void Traducir(Idiomas _idioma)
        {
            idioma = _idioma;
        }

    }
}
