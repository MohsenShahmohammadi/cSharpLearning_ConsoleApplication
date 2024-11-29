var names = new[]
{
    "Ali","Reza","Mohammad","Majid","Sahar","Mina","Pedram"
};
int otherCount;

var nameSelected = getOnlyELetterInName(names, out otherCount);
foreach (var item in nameSelected)
{
    Console.WriteLine(item);
}
Console.WriteLine($"Other Names are: {otherCount}");

List<string> getOnlyELetterInName(string[] datas, out int countOtherData)
{
    countOtherData = 0;
    var selectedList = new List<string>();
    foreach (var data in datas)
    {
        if (data.Contains("e") || data.Contains("E"))
        {
            selectedList.Add(data);
        }
        else
        {
            countOtherData++;
        }

    }
    return selectedList;
}