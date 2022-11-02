namespace AreaCalculation.Services
{
    public static class FigureCalculationService
    {
        public static double CalculateCircleArea(double radius)
        {
            var result = Math.PI * Math.Pow(radius, 2);

            return Math.Round(result, 3);
        }

        public static double CalculateTriangleArea(params double[] sides)
        {
            if(sides.Length != 3)
            {
                throw new ArgumentException("Не верно задано количество параметров");
            }

            var p = sides.Sum() / 2;
            var productSidesByP = p - sides.First();

            foreach (var side in sides.Skip(1))
            {
                productSidesByP *= p - side;
            }

            var result = Math.Sqrt(p * productSidesByP);

            return Math.Round(result, 3);
        }

        public static bool CheckIsIsRectangularTriangle(params double[] sides)
        {
            if(sides.Length == 3)
            {
                var squareSides = new List<double>();

                foreach (var side in sides)
                {
                    squareSides.Add(Math.Pow(side, 2));
                }

                var squareHypotenuse = squareSides.Max();
                squareSides.Remove(squareHypotenuse);

                if(squareSides.Sum() == squareHypotenuse)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
