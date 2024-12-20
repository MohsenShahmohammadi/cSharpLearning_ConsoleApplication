using MyProject;
using MyProject.Extention;
using static MyProject.SeasonEnum;


var multiText = @"Hi Dear Mohsen
Please attach your image
Best Regard
Saman";


Console.WriteLine(multiText.CountLines());
Console.WriteLine(StringExtention.CountLines(multiText));

//int CountLines(string text)
//{
//    return text.Split(Environment.NewLine).Length;
//}

Console.WriteLine(Season.Summer.Next());

