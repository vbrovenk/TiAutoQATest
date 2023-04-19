using System;
using System.Diagnostics.Metrics;

namespace Task5
{
	public class Polynomial
	{
		private int[] coeffs = new int[4];
		private int[] pows = { 2, 5, 7 };

		public int[] Coeffs
		{
			get { return coeffs; }
		}

        public Polynomial(int c1, int c2, int c3, int c4)
		{
			this.coeffs[0] = c1;
			this.coeffs[1] = c2;
			this.coeffs[2] = c3;
			this.coeffs[3] = c4;
		}

		public override string ToString()
		{
			string resultString = "";
			int indexPow = 0;

			for (int i = 0; i < coeffs.Length; i++)
			{
				if (i == 0)
				{
					resultString += coeffs[i];
				} else if (coeffs[i] >= 0)
				{
					resultString += "+" + coeffs[i] + "x^" + pows[indexPow];
					indexPow += 1;
				} else
				{
                    resultString += coeffs[i] + "x^" + pows[indexPow];
                    indexPow += 1;
                }
			}

			return resultString;
		}

        public static Polynomial operator +(Polynomial p1, Polynomial p2)
        {
			Polynomial polynomNew = new Polynomial(p1.Coeffs[0] + p2.Coeffs[0],
													p1.Coeffs[1] + p2.Coeffs[1],
													p1.Coeffs[2] + p2.Coeffs[2],
													p1.Coeffs[3] + p2.Coeffs[3]);

			return polynomNew;
        }

        public static Polynomial operator -(Polynomial p1, Polynomial p2)
        {
            Polynomial polynomNew = new Polynomial(p1.Coeffs[0] - p2.Coeffs[0],
                                                    p1.Coeffs[1] - p2.Coeffs[1],
                                                    p1.Coeffs[2] - p2.Coeffs[2],
                                                    p1.Coeffs[3] - p2.Coeffs[3]);

            return polynomNew;
        }

        public static Polynomial operator *(Polynomial p1, Polynomial p2)
        {
            Polynomial polynomNew = new Polynomial(p1.Coeffs[0] * p2.Coeffs[0],
                                                    p1.Coeffs[1] * p2.Coeffs[1],
                                                    p1.Coeffs[2] * p2.Coeffs[2],
                                                    p1.Coeffs[3] * p2.Coeffs[3]);

            return polynomNew;
        }
    }
}

