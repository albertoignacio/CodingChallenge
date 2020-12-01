using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                FormaGeometrica.Imprimir(new List<Forma>(), 1));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                FormaGeometrica.Imprimir(new List<Forma>(), 2));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<Forma> {new Cuadrado(1, 5)};

            var resumen = FormaGeometrica.Imprimir(cuadrados, 1);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrados | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 Formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<Forma>
            {
                new Cuadrado(2, 5),
                new Cuadrado(2, 1),
                new Cuadrado(2, 3),
            };

            var resumen = FormaGeometrica.Imprimir(cuadrados, 2);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<Forma>
            {
                new Cuadrado(2, 5),
                new Circulo(2, 3),
                new TrianguloEquilatero(2, 4),
                new Cuadrado(2, 2),
                new TrianguloEquilatero(2, 9),
                new Circulo(2, 2.75),
                new TrianguloEquilatero(2, 4.2)
            };

            var resumen = FormaGeometrica.Imprimir(formas, 2);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 Shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<Forma>
            {
                new Cuadrado(1, 5),
                new Circulo(1, 3),
                new TrianguloEquilatero(1, 4),
                new Cuadrado(1, 2),
                new TrianguloEquilatero(1, 9),
                new Circulo(1, 2.75),
                new TrianguloEquilatero(1, 4.2)
            };

            var resumen = FormaGeometrica.Imprimir(formas, 1);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 Formas Perimetro 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecioEnAleman()
        {
            var trapecios = new List<Forma>
            {
                new Trapecio(3, 5, 6, 4, 3, 8)
            };

            var resumen = FormaGeometrica.Imprimir(trapecios, 3);

            Assert.AreEqual("<h1>Formenbericht</h1>1 Trapezien | Fläche 44 | Perimeter 18 <br/>TOTAL:<br/>1 Formen Perimeter 18 Fläche 44", resumen);
        }

    }
}
