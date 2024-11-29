//int[] scoreMath = new int[4];
//Console.WriteLine("first value= " + scoreMath[0]);
//Console.WriteLine("first value= " + scoreMath[1]);
//Console.WriteLine("first value= " + scoreMath[2]);
//Console.WriteLine("first value= " + scoreMath[3]);

//scoreMath[0] = 12;
//scoreMath[1] = 13;
//scoreMath[2] = 14;
//scoreMath[3] = 15;

//Console.WriteLine("first value= " + scoreMath[0]);
//Console.WriteLine("first value= " + scoreMath[1]);
//Console.WriteLine("first value= " + scoreMath[2]);
//Console.WriteLine("first value= " + scoreMath[3]);

//int total = 0;
//for(int i = 0; i < scoreMath.Length; i++)
//{
//    total += scoreMath[i];
//}
//Console.WriteLine(total.ToString());




//string[] studentName = new string[]
//{
//    "Ali","Mohamad","Sahar","Lila"
//};
//Console.WriteLine("first value= " + studentName[0]);
//Console.WriteLine("first value= " + studentName[1]);
//Console.WriteLine("first value= " + studentName[2]);
//Console.WriteLine("first value= " + studentName[3]);

int[,] score = new int[2, 3];
score[0, 0] = 12;
score[0, 1] = 13;
score[0, 2] = 14;
score[1, 0] = 15;
score[1, 1] = 16;
score[1, 2] = 17;

int iCount = score.GetLength(0);
int jCount = score.GetLength(1);

int total = 0;
for (int i = 0; i < iCount; i++)
{
    for (int j = 0; j < jCount; j++)
    {
        total += score[i, j];
    }
}
Console.WriteLine(total.ToString());