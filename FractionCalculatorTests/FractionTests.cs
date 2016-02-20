using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionCalculator.Tests
{
  [TestClass()]
  public class FractionTests
  {
    [TestMethod()]
    public void FractionTestAddTwoInt()
    {
      //Arrange
      Fraction first = new Fraction(1, 2);
      Fraction second = new Fraction(5, 2);

      //Act
      Fraction result = first + second;

      //Assert
      var expected = new Fraction(6, 2);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestAddTwoIntOneNegative()
    {
      //Arrange
      Fraction first = new Fraction(-1, 2);
      Fraction second = new Fraction(5, 2);

      //Act
      Fraction result = first + second;

      //Assert
      var expected = new Fraction(4, 2);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestAddTwoIntsecondNegative()
    {
      //Arrange
      Fraction first = new Fraction(1, 2);
      Fraction second = new Fraction(-5, 2);

      //Act
      Fraction result = first + second;

      //Assert
      var expected = new Fraction(-4, 2);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestAddTwoIntBothNegative()
    {
      //Arrange
      Fraction first = new Fraction(-1, 2);
      Fraction second = new Fraction(-5, 2);

      //Act
      Fraction result = first + second;

      //Assert
      var expected = new Fraction(-6, 2);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestAddTwoIntfirstZero()
    {
      //Arrange
      Fraction first = new Fraction(0, 2);
      Fraction second = new Fraction(-5, 2);

      //Act
      Fraction result = first + second;

      //Assert
      var expected = new Fraction(-5, 2);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    [ExpectedException(typeof(Exception),
    "Invalid Fraction , Cannot have a zero denominator.")]
    public void FractionTestAddTwoIntZeroDenominator()
    {
      //Arrange
      Fraction first = new Fraction(1, 0);
      Fraction second = new Fraction(-5, 2);

      //Act
      Fraction result = first + second;

      //Assert
      var expected = new Fraction(-5, 2);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestAddTwoIntDiffrentDenominator()
    {
      //Arrange
      Fraction first = new Fraction(3, 5);
      Fraction second = new Fraction(5, 2);

      //Act
      Fraction result = first + second;

      //Assert
      var expected = new Fraction(31, 10);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestSubTwoInt()
    {
      //Arrange
      Fraction first = new Fraction(3, 5);
      Fraction second = new Fraction(5, 2);

      //Act
      Fraction result = first - second;

      //Assert
      var expected = new Fraction(-19, 10);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestSubTwoIntbothzero()
    {
      //Arrange
      Fraction first = new Fraction(0, 5);
      Fraction second = new Fraction(0, 2);

      //Act
      Fraction result = first - second;

      //Assert
      var expected = new Fraction(0, 10);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestSubTwoIntWithFirstNegative()
    {
      //Arrange
      Fraction first = new Fraction(-4, 5);
      Fraction second = new Fraction(0, 2);

      //Act
      Fraction result = first - second;

      //Assert
      var expected = new Fraction(-8, 10);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestSubTwoIntWithBothNegative()
    {
      //Arrange
      Fraction first = new Fraction(-4, 5);
      Fraction second = new Fraction(-8, 2);

      //Act
      Fraction result = first - second;

      //Assert
      var expected = new Fraction(32, 10);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }


    [TestMethod()]
    public void FractionTestSubTwoIntWithNegativeDenominator()
    {
      //Arrange
      Fraction first = new Fraction(4, -5);
      Fraction second = new Fraction(-8, -2);

      //Act
      Fraction result = first - second;

      //Assert
      var expected = new Fraction(-48, 10);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestSubTwoIntWithFirstNegativeDenominator()
    {
      //Arrange
      Fraction first = new Fraction(4, -5);
      Fraction second = new Fraction(-8, 2);

      //Act
      Fraction result = first - second;

      //Assert
      var expected = new Fraction(-32, -10);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    [ExpectedException(typeof(Exception),
"Invalid Fraction , Cannot have a zero denominator.")]
    public void FractionTestSubTwoIntWithZroDenominator()
    {
      //Arrange
      Fraction first = new Fraction(4, 0);
      Fraction second = new Fraction(-8, 0);

      //Act
      Fraction result = first - second;
    }

    [TestMethod()]
    public void FractionTestDivideTwoInt()
    {
      //Arrange
      Fraction first = new Fraction(4, -5);
      Fraction second = new Fraction(-8, 2);

      //Act
      Fraction result = first / second;

      //Assert
      var expected = new Fraction(8, 40);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }

    [TestMethod()]
    public void FractionTestMultiplayTwoInt()
    {
      //Arrange
      Fraction first = new Fraction(4, -5);
      Fraction second = new Fraction(-8, 2);

      //Act
      Fraction result = first * second;

      //Assert
      var expected = new Fraction(-32, -10);
      Assert.AreEqual(expected.ToString(), result.ToString());
    }


  }
}