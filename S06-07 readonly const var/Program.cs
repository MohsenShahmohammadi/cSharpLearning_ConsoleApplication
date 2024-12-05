CustomerCRM data3= new CustomerCRM("Ali",DateTime.Now,5);
Console.WriteLine("name: "+data3.name);

class CustomerCRM
{
    public readonly Guid id;
    public readonly string name;
    public readonly DateTime invoicedate;
    private DateTime surveyDate;

    public CustomerCRM(string name, DateTime invoiceDate, int duration)
    {
        id = Guid.NewGuid();
        this.name = name;
        this.invoicedate = invoiceDate;
        this.surveyDate = invoiceDate.AddDays(duration);
    }

    public void PrintSurveyData(CustomerCRM data)
    {
        const int  number = 12;
        surveyDate=invoicedate.AddDays(number);
        Console.WriteLine("surveyDate: " + surveyDate);
    }
}
