ParameterDemo pd = new ParameterDemo();

// ref
int value = 5;
pd.Increase(ref value);
Console.WriteLine("After Increase: " + value);

// out
pd.GetFullName(out string myname);
Console.WriteLine("Full Name: " + myname);

// params
int total = pd.SumAll(1, 2, 3, 4);
Console.WriteLine("Sum: " + total);