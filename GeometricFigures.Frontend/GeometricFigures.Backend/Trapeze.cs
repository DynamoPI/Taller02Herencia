namespace GeometricFigures.Backend
{
    public class Trapeze : Triangle
    {
        // Fields
        
        private double _d = 0;

        // Properties

        public double D
        {
            get => _d;
            set => _d = ValidateD(value);
        }

        // Constructor

        public Trapeze(string name, double a, double b, double h, double d, double c) : base(name, a, b, c, h) => D = d;

        // Methods

        public override double GetArea() => ((B + D) * H) / 2.0;

        public override double GetPerimeter() => A + B + C + D;

        private double ValidateD(double d)
        {
            if (d <= 0)
            {
                throw new ArgumentException($"The side D: {d}, is not valid.");
            }
            return d;
        }
    }
}
