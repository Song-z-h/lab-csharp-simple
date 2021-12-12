using System;

namespace ComplexAlgebra
{
    /// <summary>
    /// A type for representing Complex numbers.
    /// </summary>
    ///
    /// TODO: Model Complex numbers in an object-oriented way and implement this class.
    /// TODO: In other words, you must provide a means for:
    /// TODO: * instantiating complex numbers
    /// TODO: * accessing a complex number's real, and imaginary parts
    /// TODO: * accessing a complex number's modulus, and phase
    /// TODO: * complementing a complex number
    /// TODO: * summing up or subtracting two complex numbers
    /// TODO: * representing a complex number as a string or the form Re +/- iIm
    /// TODO:     - e.g. via the ToString() method
    /// TODO: * checking whether two complex numbers are equal or not
    /// TODO:     - e.g. via the Equals(object) method
    public class Complex
    {
        // TODO: fill this class\
        public double Real { get; }
        public double Imaginary { get; }

        public Complex(double real, double immaginary)
        {
            Real = real;
            Imaginary = immaginary;
        }

        public double Modulus => Math.Sqrt(Real * Real + Imaginary * Imaginary);

        public double Phase => Math.Atan2(Imaginary, Real);  

        public Complex Complement() => new Complex(Real, Imaginary * -1);

        public Complex Plus(Complex c) => new Complex(c.Real + Real, c.Imaginary + Imaginary);

        public Complex Minus(Complex c) => new Complex(Real - c.Real, Imaginary - c.Imaginary);

        /*in order to complete the function ToString, i need to write code for all of 4 cases
             real immaginary
              0        0   print real
              0        1   print sign + immaginary + i
              1        0   print real
              1        1   print both
        The merit of thinking like this would reduce redundant codes. */
        public override string ToString()
        {
            // for (0,0)  and (1, 0)
            if (Imaginary.Equals(0)) return Real.ToString();

            string ima = Math.Abs(Imaginary).Equals(1) ? "" : Imaginary.ToString();
            string sign;
            //for (0, 1)
            if (Real.Equals(0))
            {
                 sign = Imaginary > 0 ? "" : "-";
                return $"{sign} {ima}i";
            }
            //for (1, 1)
            sign = Imaginary > 0 ? "+" : "-";
            return $"{Real}{sign}{ima}i";
        }

        public bool Equals(Complex c) => c.Real.Equals(Real) && c.Imaginary.Equals(Imaginary);

    }
}