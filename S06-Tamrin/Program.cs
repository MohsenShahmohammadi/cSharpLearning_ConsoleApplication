using S06_Tamrin;
using static S06_Tamrin.ResultStatus;

Console.WriteLine("Welcome to My Game!");

var rand = new Random();
var card = new Card(rand);
var game = new Guessing(card);
ResaultCode playResualt = game.Play();
Notification.PrintNotification(playResualt);