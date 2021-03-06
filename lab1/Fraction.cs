using System;

namespace oop
{
	public class Fraction
	{
		private int numerator { get; }
		private int denominator { get; }

		public Fraction() {
			numerator = 1;
			denominator = 1;
		}

		public Fraction(int numerator, int denominator)
		{
			this.numerator = numerator;
			this.denominator = denominator;
		}

		public Fraction(Fraction fraction)
		{
			numerator = fraction.numerator;
			denominator = fraction.denominator;
		}

		public override string ToString()
		{
			return String.Format("{0}/{1}", numerator, denominator);
		}

		public int Ceil()
		{
			var rest = numerator % denominator;
			var baseProduct = numerator / denominator;

			return rest != 0 ? baseProduct + 1 : baseProduct;
		}

		public int Floor()
		{
			return numerator / denominator;
		}
	}
}

