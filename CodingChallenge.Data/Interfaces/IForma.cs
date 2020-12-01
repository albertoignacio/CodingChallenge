using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Interfaces
{
    public interface IForma
    {
        double Lado { get; set; }
        double CalcularArea();
        double CalcularPerimetro();
        
        string TraducirForma(bool plural);

        void Traducir(int idiomaTipo);
    }
}
