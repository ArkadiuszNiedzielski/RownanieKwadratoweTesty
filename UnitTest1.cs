using System;
using Xunit;

namespace RownanieKwadratowe1.Testy
{
    public class RownanieKwadratoweTesty
    {
        [Theory]
        [InlineData(-2,1,3,25)]
        [InlineData(-3, 0, 4, 48)]
        [InlineData(2, 1, 1, -7)]
        [InlineData(2, 4, 2, 0)]

        public void liczRownanie_SprawdzanieObliczeñDlaDelty(double a, double b, double c, double wynik)
        {
            //arrange
            RownanieKwadratowe o1 = new RownanieKwadratowe();
            o1.a = a;
            o1.b = b;
            o1.c = c;

            //act

            o1.liczRownanie();
            double wynikDelty=o1.delta;


            //assert

            Assert.Equal(wynikDelty, wynik);
        }


        [Theory]
        [InlineData(-2, 1, 3, 25,1.5,-1)]
        /*[InlineData(-3, 0, 4, 48)]
        [InlineData(2, 1, 1, -7)]
        [InlineData(2, 4, 2, 0)]*/
        public void liczRownanie_SprawdzanieObliczeñDlaPierwiastkow_dlaDeltyDodatniej(double a, double b, double c, double delta, double wynik1, double wynik2)
        {
            //arange
            RownanieKwadratowe o2 = new RownanieKwadratowe();

            //act
            o2.liczRownanie();
            wynik1 = o2.x1;
            wynik2 = o2.x2;

            //assert
            Assert.Equal(wynik1, o2.x1);
            Assert.Equal(wynik2, o2.x2);

        }
    }
}