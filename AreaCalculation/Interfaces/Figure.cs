using AreaCalculation.Services;

namespace AreaCalculation.Interfaces
{
    public abstract class Figure
    {
        public string FigureType => GetType().Name;
        public abstract double Area { get; }
        public bool IsRectangularTriangle { get; }

        public Figure(params double[] sides)
        {
            IsRectangularTriangle = FigureCalculationService.CheckIsIsRectangularTriangle(sides);
        }

        public override string ToString()
        {
            return $"FigureType: {FigureType}\nArea: {Area}\nIs rectangular triangle: {IsRectangularTriangle}";
        }
    }
}
