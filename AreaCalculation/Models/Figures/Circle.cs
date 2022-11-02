using AreaCalculation.Interfaces;
using AreaCalculation.Services;

namespace AreaCalculation.Models.Figures
{
    public class Circle : Figure
    {
        public override double Area { get; }

        public Circle(double radius) : base(radius)
        {
            Area = FigureCalculationService.CalculateCircleArea(radius);
        }
    }
}
