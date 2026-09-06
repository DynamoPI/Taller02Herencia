namespace GeometricFigures.Backend
{
    public class Rhombus : Square
    {
        //Fields

        private double _d1 = 0;
        private double _d2 = 0;

        //Properties

        public double D1
        {
            get => _d1;
            set => _d1 = ValidateD1(value);
        }

        public double D2
        {
            get => _d2;
            set => _d2 = ValidateD2(value);
        }

        //Constructor

        public Rhombus(string name, double a, double d1, double d2) : base(name, a)
        {
            D1 = d1;
            D2 = d2;
        }

        //Methods

        public override double GetArea() => (D1 * D2) / 2.0;

        public override double GetPerimeter() => base.GetPerimeter();

        private double ValidateD1(double d1)
        {
            if (d1 <= 0)
            {
                throw new ArgumentException($"The diagonal 1: {d1}, is not valid.");
            }
            return d1;
        }

        private double ValidateD2(double d2)
        {
            if (d2 <= 0)
            {
                throw new ArgumentException($"The diagonal 2: {d2}, is not valid.");
            }
            return d2;
        }
    }
}

