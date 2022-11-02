using AreaCalculation.Interfaces;
using AreaCalculation.Services;

namespace AreaCalculation.Models.Figures
{
    public class Triangle : Figure
    {
        public override double Area { get; }

        public Triangle(double sideA, double sideB, double sideC) : base(sideA, sideB, sideC)
        {
            Area = FigureCalculationService.CalculateTriangleArea(sideA, sideB, sideC);
        }
    }
}
