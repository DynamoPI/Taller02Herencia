namespace GeometricFigures.Backend
{
    public class Rectangle : Square
    {
        //Fields

        private double _b;

        //Properties

        public double B
        {
            get => _b;
            set => _b = ValidateB(value);
        }

        //Constructor

        public Rectangle(string name, double a, double b) : base(name, a) => B = b;

        //Methods

        public override double GetArea() => A * B;

        public override double GetPerimeter() => 2 * (A + B);

        private double ValidateB(double b)
        {
            if (b <= 0)
            {
                throw new ArgumentException($"The side B: {b}, is not valid.");
            }
            return b;
        }
    }
}
