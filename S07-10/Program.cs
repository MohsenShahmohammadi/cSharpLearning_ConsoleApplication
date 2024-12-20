using MyProject;

public class Token:IToken
{
    public string GetToken()
    {
        return Guid.NewGuid().ToString();
    }
}
public class Info:IInfo
{
    public string GetInfo()
    {
        string FName = "Ali";
        string LName = "Rezaee";
        return FName + " " + LName;
    }
}

public class EmailService:IToken,IInfo
{
    public string GetInfo()
    {
        string FName = "Ali";
        string LName = "Rezaee";
        return FName + " " + LName;
    }

    public string GetToken()
    {
        return Guid.NewGuid().ToString();
    }

    public void SendEmail(string name,string phone)
    {
        Console.WriteLine("Your Message Sent");
    }
}