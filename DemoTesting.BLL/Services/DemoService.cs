namespace DemoTesting.BLL.Services
{
    public class DemoService
    {
        public string ObtenirDateDuJour()
        {
            DateTime today = DateTime.Today;
            return today.ToShortDateString();
        }
    } 
}
