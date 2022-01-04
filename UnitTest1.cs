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


        [Fact]
        public void liczRownanie_SprawdzanieObliczeñDlaPierwiastkow_dlaDeltyDodatniej()
        {
            //arange
            RownanieKwadratowe o2 = new RownanieKwadratowe();
            o2.a = -2;
            o2.b = 1;
            o2.c = 3;

            //act
            o2.liczRownanie();
            double wynik_x_1 = o2.x1;
            double wynik_x_2 = o2.x2;
            double wynik_prawidlowy_x1 = 1.5;
            double wynik_prawidlowy_x2 = -1;

            //assert
            Assert.Equal(wynik_prawidlowy_x1, wynik_x_1);
            Assert.Equal(wynik_prawidlowy_x2, wynik_x_2);


            

        }
    }
}