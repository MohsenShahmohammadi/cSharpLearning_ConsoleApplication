using static MyProject.SeasonEnum;
namespace MyProject.Extention;

public static class EnumExtention
{
    public static Season Next(this Season season)
    {
        int num = (int)season;
        int nextNum = (num + 1) % 4;
        return (Season)nextNum;
    }
}
