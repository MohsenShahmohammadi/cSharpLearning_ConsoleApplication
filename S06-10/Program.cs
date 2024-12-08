using Domain.Gnr;
using Services.Gnr;

Student student = new Student(1, "Ali", "Mohammadi");

StudentService service= new StudentService();
var result=service.Add(student);

Console.WriteLine("result: " + result);