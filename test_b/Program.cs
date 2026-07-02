//declare
string Code,Name;
double Salary, Sale,Rate, Commission, Netincome;

//input
//รหัสพนักงาน
//ชื่อพนักงาน
//เงินเดือน
//ยอดขาย
//อัตราเงินเดือน
Console.WriteLine("Enter Code: ");
Code = Console.ReadLine();

Console.WriteLine("Enter Name: ");
Name = Console.ReadLine();

Console.WriteLine("Enter Salary: ");
Salary = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Sale: ");
Sale = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter Rate 1-100: ");
Rate = Convert.ToDouble(Console.ReadLine());



//process
//เงินตอบแทน คำนวณจากยอดขาย x อัตราเงินเดือนของพนักงาน
//รายได้ทั้งหมดหักภาษี5%

Commission = Sale * (Rate / 100);

Netincome = Salary + Commission;

//output
//รายได้สุทธิ

Console.WriteLine($"Commission = {Commission:C}");
Console.WriteLine($"Netincome = {Netincome:C}");