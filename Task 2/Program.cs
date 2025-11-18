Calculator calc = new Calculator();

calc.PrintWelcome();

int sum = calc.Add(10, 20);
Console.WriteLine("Addition: " + sum);

int result1 = calc.Multiply(5);
Console.WriteLine("Multiply with one number: " + result1);

int result2 = calc.Multiply(5, 4);
Console.WriteLine("Multiply with two numbers: " + result2);