namespace GeometricFigures.Backend
{
    public class Parallelogram : Rectangle
    {
        //Fields

        private double _h;

        //Properties
        public double H
        {
            get => _h;
            set => _h = ValidateH(value);
        }

        //Constructor

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b) => H = h;

        //Methods

        public override double GetArea() => B * H;

        public override double GetPerimeter() => base.GetPerimeter();

        private double ValidateH(double h)
        {
            if (h <= 0)
            {
                throw new ArgumentException($"The height: {h}, is not valid.");
            }
            return h;
        }
    }
}
