using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Idiomas
    {
        //Formas
        public string Cuadrado { get; set; }
        public string Circulo { get; set; }
        public string TrianguloEquilatero { get; set; }
        public string Trapecio { get; set; }
        public string Cuadrados { get; set; }
        public string Circulos { get; set; }
        public string TriangulosEquilateros { get; set; }
        public string Trapecios { get; set; }
        public string ListaVacia { get; set; }
        public string Cabecera { get; set; }
        public string Area { get; set; }
        public string Perimetro { get; set; }
        public string Total { get; set; }
        public string Formas { get; set; }

        public void ObtenerIdioma(int idioma)
        {
            var paqueteIdioma = new Idiomas();
            switch (idioma)
            {
                case Castellano.Tipo:
                    paqueteIdioma = new Castellano();
                    break;
                case Ingles.Tipo:
                    paqueteIdioma = new Ingles();
                    break;
                case Aleman.Tipo:
                    paqueteIdioma = new Aleman();
                    break;
            }
            Cuadrado = paqueteIdioma.Cuadrado;
            Cuadrados = paqueteIdioma.Cuadrados;
            Trapecio = paqueteIdioma.Trapecio;
            Trapecios = paqueteIdioma.Trapecios;
            TrianguloEquilatero = paqueteIdioma.TrianguloEquilatero;
            TriangulosEquilateros = paqueteIdioma.TriangulosEquilateros;
            Circulo = paqueteIdioma.Circulo;
            Circulos = paqueteIdioma.Circulos;
            ListaVacia = paqueteIdioma.ListaVacia;
            Cabecera = paqueteIdioma.Cabecera;
            Area = paqueteIdioma.Area;
            Perimetro = paqueteIdioma.Perimetro;
            Total = paqueteIdioma.Total;
            Formas = paqueteIdioma.Formas;

        } 
        public Idiomas() { }
        public Idiomas(int idioma)
        {
            ObtenerIdioma(idioma);
        }

        public class Castellano : Idiomas
        {
            public const int Tipo = 1;
            public Castellano()
            {
                Cuadrado = "Cuadrado";
                Cuadrados = "Cuadrados";
                Trapecio = "Trapecio";
                Trapecios = "Trapecios";
                TrianguloEquilatero = "Triángulo";
                TriangulosEquilateros = "Triángulos";
                Circulo = "Círculo";
                Circulos = "Círculos";
                ListaVacia = "Lista vacía de formas!";
                Cabecera = "Reporte de Formas";
                Area = "Area";
                Perimetro = "Perimetro";
                Total = "TOTAL";
                Formas = "Formas";
            }
        }

        public class Ingles : Idiomas
        {
            public const int Tipo = 2;
            public Ingles()
            {
                Cuadrado = "Square";
                Cuadrados = "Squares";
                Trapecio = "Trapezium";
                Trapecios = "Trapeziums";
                TrianguloEquilatero = "Triangle";
                TriangulosEquilateros = "Triangles";
                Circulo = "Circle";
                Circulos = "Circles";
                ListaVacia = "Empty list of shapes!";
                Cabecera = "Shapes report";
                Area = "Area";
                Perimetro = "Perimeter";
                Total = "TOTAL";
                Formas = "Shapes";
            }
        }

        public class Aleman : Idiomas
        {
            public const int Tipo = 3;
            public Aleman()
            {
                Cuadrado = "Quadrat";
                Cuadrados = "Quadrate";
                Trapecio = "Trapez";
                Trapecios = "Trapezien";
                TrianguloEquilatero = "Dreieck";
                TriangulosEquilateros = "Dreiecke";
                Circulo = "Kreis";
                Circulos = "Kreise";
                ListaVacia = "Leere Liste der Formen!";
                Cabecera = "Formenbericht";
                Area = "Fläche";
                Perimetro = "Perimeter";
                Total = "TOTAL";
                Formas = "Formen";
            }
        }
    }
}

