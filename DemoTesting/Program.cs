using DemoTesting.BLL.Services;

// Application client (Interface graphique)
string today = new DemoService().ObtenirDateDuJour();
Console.WriteLine(today);

