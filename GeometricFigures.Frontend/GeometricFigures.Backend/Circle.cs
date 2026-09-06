namespace GeometricFigures.Backend
{
    public class Circle : GeometricFigure
    {
        //Fields

        private double _r = 0;

        //Properties

        public double R
        {
            get => _r;
            set => _r = ValidateR(value);
        }

        //Constructor

        public Circle(string name, double r) : base(name) => R = r;

        //Methods

        public override double GetArea() => Math.PI * R * R;

        public override double GetPerimeter() => 2 * Math.PI * R;

        private double ValidateR(double r)
        {
            if (r <= 0)
            {
                throw new ArgumentException($"The radius: {r}, is not valid.");
            }
            return r;
        }
    }
}
