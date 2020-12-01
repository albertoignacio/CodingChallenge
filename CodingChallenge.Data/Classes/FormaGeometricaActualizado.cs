using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodingChallenge.Data.Interfaces;

namespace CodingChallenge.Data.Classes
{
    public class FormaGeometrica
    {
        
        public FormaGeometrica()
        {

        }

        public static string Imprimir(IEnumerable<Forma> formasList, int _idioma)
        {
            var sb = new StringBuilder();

            var idioma = new Idiomas(_idioma);
            if (!formasList.Any())
            {
                sb.Append("<h1>" + idioma.ListaVacia + "</h1>");
            }
            else
            {
                int cantidadFormas = 0;
                double sumArea = 0;
                double sumPerimetro = 0;

                sb.Append("<h1>" + idioma.Cabecera + "</h1>");
                var cuadrados = new FormasGrupo();
                foreach (var forma in formasList)
                {
                    if (typeof(Cuadrado).IsInstanceOfType(forma))
                        cuadrados.Add(forma);
                }
                var circulos = new FormasGrupo();
                foreach (var forma in formasList)
                {
                    if (typeof(Circulo).IsInstanceOfType(forma))
                        circulos.Add(forma);
                }
                var triangulos = new FormasGrupo();
                foreach (var forma in formasList)
                {
                    if (typeof(TrianguloEquilatero).IsInstanceOfType(forma))
                        triangulos.Add(forma);
                }
                var trapecios = new FormasGrupo();
                foreach (var forma in formasList)
                {
                    if (typeof(Trapecio).IsInstanceOfType(forma))
                        trapecios.Add(forma);
                }
                sb.Append(cuadrados.ObtenerLinea());
                sb.Append(circulos.ObtenerLinea());
                sb.Append(triangulos.ObtenerLinea());
                sb.Append(trapecios.ObtenerLinea());

                foreach (var formas in formasList)
                {
                    cantidadFormas += formas.GetListCount();
                    sumArea += formas.CalcularArea();
                    sumPerimetro += formas.CalcularPerimetro();
                }

                //FOOTER
                sb.Append(idioma.Total+":<br/>");
                sb.Append(cantidadFormas + " " + idioma.Formas + " ");
                sb.Append(idioma.Perimetro + " " + sumPerimetro.ToString("#.##") + " ");
                sb.Append(idioma.Area + " " + sumArea.ToString("#.##"));
            }

            return sb.ToString();
        }
    }
}
