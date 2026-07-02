double a, b, e, x, y;
a = 1;
b = 2;
e = 1;
x = 3;
y = 2;


var num1 = ((Math.Exp(x) * (Math.Sqrt((Math.Pow(a, 2)+(Math.Pow(b, x-y)))))));
var num2 = ((2*Math.PI * Math.Pow(x, 2)))-(Math.Pow(y, 2));
var result = num1 / num2;


Console.WriteLine($"Result: {result:F3}");