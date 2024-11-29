Console.WriteLine("Please write Your First Name");
var FirstName = Console.ReadLine();
Console.WriteLine("Please write Your Last Name");
var LastName = Console.ReadLine();
string FullName = FirstName + " " + LastName;
Console.WriteLine("Dear " + FullName);
Console.WriteLine("Are you like[l] or disLike[d] this video?");
var resualt = Console.ReadLine();
//Console.WriteLine("Thank you for Like! :)");
if (resualt == "l" || resualt == "L")
{
    Console.WriteLine("Thank you for Like! :)");
}
else if (resualt == "d" || resualt == "D")
{
    Console.WriteLine("Thank you for disLike!");
}
else
{
    Console.WriteLine("It's wrong,...");
}