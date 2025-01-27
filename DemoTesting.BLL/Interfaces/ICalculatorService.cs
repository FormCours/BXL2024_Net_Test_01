
namespace DemoTesting.BLL.Interfaces
{
    public interface ICalculatorService
    {
        int Addition(int nb1, int nb2);
        double Addition(double nb1, double nb2);

        int Soustraction(int nb1, int nb2);
        double Soustraction(double nb1, double nb2);

        int Multiplication(int nb1, int nb2);
        double Multiplication(double nb1, double nb2);

        double Division(double nb1, double nb2);
    }
}
