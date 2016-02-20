using System;

namespace FractionCalculator
{
  public class Fraction
  {
    private int numerator { get; set; }
    private int denominator { get; set; }

    /// <summary>
    /// Create new instance of fraction object.
    /// </summary>
    /// <param name="numerator">The numerator value.</param>
    /// <param name="denominator">The denominator value.</param>
    public Fraction(int numerator, int denominator)
    {
      if (denominator == 0)
        throw new Exception("Invalid Fraction , Cannot have a zero denominator.");

      this.numerator = numerator;
      this.denominator = denominator;
    }

    /// <summary>
    /// Sum operation for two fraction numbers.
    /// </summary>
    /// <param name="first">The first fraction.</param>
    /// <param name="second">The second fraction.</param>
    /// <returns>The result.</returns>
    public static Fraction operator +(Fraction first, Fraction second)
    {
      var numerator = first.denominator == second.denominator ? first.numerator + second.numerator : first.numerator * second.denominator
                           + second.numerator * first.denominator;
      var denominator = first.denominator == second.denominator ? first.denominator : first.denominator * second.denominator;

      return new Fraction(numerator, denominator);

    }

    /// <summary>
    /// the substraction operation for two fraction numbers 
    /// </summary>
    /// <param name="first">The first fraction.</param>
    /// <param name="second">The second fraction.</param>
    /// <returns>The result.</returns>
    public static Fraction operator -(Fraction first, Fraction second)
    {
      var numerator = first.denominator == second.denominator ? first.numerator + second.numerator : first.numerator * second.denominator
                                - second.numerator * first.denominator;
      var denominator = first.denominator == second.denominator ? first.denominator : first.denominator * second.denominator;
      return new Fraction(numerator, denominator);

    }

    /// <summary>
    /// The multiplay operation for two fraction.
    /// </summary>
    /// <param name="first">The first fraction.</param>
    /// <param name="second">The second fraction.</param>
    /// <returns>The result.</returns>
    public static Fraction operator *(Fraction first, Fraction second)
    {
      return new Fraction(first.numerator * second.numerator,
         first.denominator * second.denominator);
    }

    /// <summary>
    /// The division operation for two fraction.
    /// </summary>
    /// <param name="first">The first fraction.</param>
    /// <param name="second">The second fraction.</param>
    /// <returns>The result.</returns>
    public static Fraction operator /(Fraction first, Fraction second)
    {
      return new Fraction(first.numerator * second.denominator,
         first.denominator * second.numerator);

    }

    /// <summary>
    /// Override of tosting method to return fraction value.
    /// </summary>
    /// <returns>The string value.</returns>
    public override string ToString()
    {
      return this.numerator.ToString() + "/" + this.denominator.ToString();

    }


  }
}
