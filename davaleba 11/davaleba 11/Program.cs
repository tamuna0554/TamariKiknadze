
using davaleba_11;

Console.WriteLine("Hello, World!");
//davaleba #1
Console.WriteLine("davaleba #1: ");
Counter c1 = new Counter();
Console.WriteLine("raodenoba: " + Counter.GetCount());
Counter c2 = new Counter();
Console.WriteLine("raodenoba: " + Counter.GetCount());
Counter c3 = new Counter();
Console.WriteLine("raodenoba: " + Counter.GetCount());


Counter.ResetCount();
Console.WriteLine("saboloo: " + Counter.GetCount());


//davaleba #2
Console.WriteLine("davaleba #2: sheiuvanet ricxvebi ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{a} da {b} jami " + MathHelper.Add(a, b));
Console.WriteLine($"{a} da {b} sxvaoba " + MathHelper.Subtract(a, b));
Console.WriteLine($"{a} da {b} namravli " + MathHelper.Multiply(a, b));
//Console.WriteLine($"{a} da {b} namravli " + MathHelper.Divide(a, b));

try
{

    Console.WriteLine($"{a} da {b} namravli " + MathHelper.Divide(a, b));
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Error: " + ex.Message);
}