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


            //assert regerhgerhr

            Assert.Equal(wynikDelty, wynik);
        }
        //herher

    }
}