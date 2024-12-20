using System.Text.Json;

Person person = new Person();
person.Id = 1;
person.FirstName = "Mohsen";
person.LastName = "Shahmohammadi";

var personJsoni=JsonSerializer.Serialize(person);
Console.WriteLine(personJsoni);

var serialized = "{\"Id\":1,\"FirstName\":\"Mohsen\",\"LastName\":\"Shahmohammadi\"}";

var personUI = JsonSerializer.Deserialize<PersonUI>(serialized);

Console.WriteLine(personUI.FirstName+" "+personUI.LastName);

class Person
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

class PersonUI
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
}
