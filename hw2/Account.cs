namespace hw2;

public class Account
{
    double _balance;
    public Account(double balance)
    {
        _balance=balance;
    }
    public double Heikkisaccount()
    {
        return _balance -100;
    }
    public double Personalaccount()
    {
        return _balance+100;
    }
    public void ToString()
    {
        Console.WriteLine($"Heikki's account balance: {Heikkisaccount()}");
    }
    public void ToString1()
    {
         Console.WriteLine($"Personal account balance: {Personalaccount()}");
    }
}
