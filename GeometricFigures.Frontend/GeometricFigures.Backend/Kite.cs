namespace GeometricFigures.Backend
{
    public class Kite : Rhombus
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

        public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2) => B = b;

        //Methods

        public override double GetArea() => base.GetArea();

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
