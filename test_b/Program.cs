//declar
string ID ;
Double Sales, Salary, Commission, Rate, Bonus = 0, Total, Bonus_Spacial=0 ;


//input
Console.Write("Enter ID : ");
ID = Console.ReadLine();

Console.Write("Enter Total : ");
Total = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Sales : ");
Sales = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Salary : ");
Salary = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter Rate 0-1 : ");
Rate = Convert.ToDouble(Console.ReadLine());

//process

Commission = Sales * Rate;

if (Total > 5)
    {
    Bonus = 9000;
}

if (Commission > Salary)
{
    Bonus_Spacial = Sales*0.1;
}

var Result = Sales + Commission + Bonus + Bonus_Spacial;

//output

Console.WriteLine($"-------------------");
Console.WriteLine($"ID : {ID}");
Console.WriteLine($"Sales : {Sales}");
Console.WriteLine($"Salary : {Salary}");
Console.WriteLine($"Bonus : {Bonus}");
Console.WriteLine($"Bonus_Spacial : {Bonus_Spacial}");
Console.WriteLine($"Commission : {Commission}");
Console.WriteLine($"Result : {Result}");
