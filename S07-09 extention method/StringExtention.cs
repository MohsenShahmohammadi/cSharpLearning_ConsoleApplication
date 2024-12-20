
namespace MyProject.Extention;

public static class StringExtention
{
    public static int CountLines(this string text)
    {
        return text.Split(Environment.NewLine).Length;
    }
}
