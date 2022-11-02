using AreaCalculation;

try
{
    var action = new ActionStart();
    var calcResult = action.GetCalculationAction(3);

    Console.WriteLine(calcResult.ToString());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadLine();