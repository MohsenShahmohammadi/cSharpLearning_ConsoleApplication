CustomerCRM data = new CustomerCRM("Ali", DateTime.Parse("2024-12-05"));

data.PrintCRM(data);

CustomerCRM data2 = new CustomerCRM("Reza", DateTime.Parse("2024-12-05"),DateTime.Parse("2024-12-20"));

data.PrintCRM(data2);

class CustomerCRM
{
    private Guid id;
    private string name;
    private DateTime invoicedate;
    private DateTime surveyDate;

    public CustomerCRM(string name,DateTime invoiceDate):this(name:name,invoiceDate:invoiceDate,7)
    {
    }
    public CustomerCRM(string name, DateTime invoiceDate,int duration)
    {
        id = Guid.NewGuid();
        this.name = name;
        this.invoicedate = invoiceDate;
        this.surveyDate = invoiceDate.AddDays(duration);
    }
    public CustomerCRM(string name, DateTime invoiceDate, DateTime surveyDate)
    {
        id = Guid.NewGuid();
        this.name = name;
        this.invoicedate = invoiceDate;
        this.surveyDate = surveyDate;
    }

    public void PrintCRM(CustomerCRM customerCRM)
    {
        Console.WriteLine("Id: " + customerCRM.id + " Name: " + customerCRM.name + " surveyDate: " + customerCRM.surveyDate);
    }
}
