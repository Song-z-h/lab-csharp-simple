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

        public double Modulus
        {
            get => Math.Sqrt(Real * Real + Imaginary * Imaginary);
        }

        public double Phase
        {
            get => Math.Atan2(Imaginary, Real);  
        }
        private static bool IsZero(double num) => (Math.Abs(num) < 0.001);

        public Complex Complement() => new Complex(Real, Imaginary * -1);

        public Complex Plus(Complex c) => new Complex(c.Real + Real, c.Imaginary + Imaginary);

        public Complex Minus(Complex c) => new Complex(Real - c.Real, Imaginary - c.Imaginary);

        public override string ToString()
        {
            string sign = Imaginary > 0 ? " + " : " - ";
            string real = IsZero(Real) ? "" : $"{Real}";
            string ima = IsZero(Imaginary) ? "" : $"{sign}{Imaginary}i";
            string zero = real.Equals("") && ima.Equals("") ? "0" : "";
            return $"{zero}{real}{ima}";
        }

        public bool Equals(Complex c) => c.Real.Equals(Real) && c.Imaginary.Equals(Imaginary);

    }
}