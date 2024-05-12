using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl1
{
	public class Fraction
	{

		public int Numerator { get; set; }
		public int FractionDenominator { get; set; }

		public Fraction(int numP, int deNumP)
		{
			Numerator = numP;
			FractionDenominator = deNumP;
		}

		public override string ToString()
		{
			return $"{Numerator}/{FractionDenominator}";
		}

		
	}
}
