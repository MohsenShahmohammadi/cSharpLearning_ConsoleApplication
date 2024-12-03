var nowDate = "2024-12-03";
var myDate2 = new DateTime(2024, 12, 03);
var myDate3 = DateTime.Now;

Console.WriteLine(nowDate);
Console.WriteLine(myDate2);
Console.WriteLine(myDate3);

Console.WriteLine(myDate3.AddDays(6));
Console.WriteLine(myDate3.DayOfWeek);
Console.WriteLine(myDate3.Month);


Console.WriteLine(myDate3.AddDays(6).DayOfWeek);