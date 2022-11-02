using AreaCalculation.Interfaces;
using System.Reflection;

namespace AreaCalculation
{
    public class ActionStart
    {
        public Figure GetCalculationAction(params double[] sides)
        {
            if (!sides.Any())
            {
                throw new ArgumentNullException("Не заданы параметры фигруры.");
            }

            var type = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.IsSubclassOf(typeof(Figure)) && 
                                     t.GetConstructors().Any(c => c.GetParameters().Length == sides.Length));

            if (type is null)
            {
                throw new ArgumentException("Тип фигуры с заданными параметрами не найден!");
            }

            var typesToConstructor = new Type[sides.Length];
            sides.Select(s => s.GetType())
                .ToArray()
                .CopyTo(typesToConstructor, 0);

            var objectsToConstructor = new object[sides.Length];
            sides.CopyTo(objectsToConstructor, 0);

            var result = (Figure)type.GetConstructor(typesToConstructor)
                .Invoke(objectsToConstructor);

            return result;
        }
    }
}
