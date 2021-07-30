using NUnit.Framework;
using AwesomeCalculator;

namespace CalcTest
{
    [TestFixture]
    public class Tests
    {
             
        Calc calc = new Calc();   

        [Test]
        public void Addition_of_two_integers()
        {
            double a = 5, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 9); //assert
        }

        [Test]
        public void Addition_of_two_integers1()
        {
            double a = 5, b = 5;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 10); //assert
        }

        [Test]
        public void Addition_of_two_integers2()
        {
            double a = 5, b = 10;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetAddition(); //act
            Assert.AreEqual(res, 15); //assert
        }
        [Test]
        public void sub_of_two_integers()
        {
            double a = 5, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetSubtraction(); //act
            Assert.AreEqual(res, 1); //assert
        }

        [Test]
        public void sub_of_two_integers1()
        {
            double a = 5, b = 3;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetSubtraction(); //act
            Assert.AreEqual(res, 2); //assert
        }

        [Test]
        public void sub_of_two_integers2()
        {
            double a = 5, b = 2;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetSubtraction(); //act
            Assert.AreEqual(res, 3); //assert
        }
        [Test]
        public void mul_of_two_integers()
        {
            double a = 5, b = 2;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetMultiplication(); //act
            Assert.AreEqual(res, 10); //assert
        }

        [Test]
        public void mul_of_two_integers1()
        {
            double a = 5, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetMultiplication(); //act
            Assert.AreEqual(res, 20); //assert
        }

        [Test]
        public void mul_of_two_integers2()
        {
            double a = 5, b = 5;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetMultiplication(); //act
            Assert.AreEqual(res, 25); //assert
        }
        [Test]
        public void div_of_two_integers()
        {
            double a = 15, b = 5;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 3); //assert
        }
        [Test]
        public void div_of_two_integers1()
        {
            double a = 15, b = 3;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 5); //assert
        }
        [Test]
        public void div_of_two_integers2()
        {
            double a = 20, b = 4;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 5); //assert
        }
        [Test]
        public void div_of_two_integers3()
        {
            double a = 1, b = 3;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 0.3); //assert
        }
        [Test]
        public void div_of_two_integers4()
        {
            double a = 2, b = 1;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 2); //assert
        }
        [Test]
        public void div_of_two_integers5()
        {
            double a = 9, b = 3;//arrange
            calc.SetFirstNumber(a);//arrange
            calc.SetSecondNumber(b);//arrange
            double res = calc.GetDivision(); //act
            Assert.AreEqual(res, 3); //assert
        }


    }
}
