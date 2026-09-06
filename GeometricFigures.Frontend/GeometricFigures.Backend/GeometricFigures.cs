namespace GeometricFigures.Backend
{
    public abstract class GeometricFigure
    {
        //Properties

        public string Name { get; set; }

        public GeometricFigure(string name) => Name = name;

        //Methods

        public abstract double GetArea();
        public abstract double GetPerimeter();
        public override string ToString() => $"{Name,-16} => Area.....: {GetArea(),14:N5}   Perimeter: {GetPerimeter(),14:N5}";

    }
}
