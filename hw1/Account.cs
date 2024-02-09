namespace hw1;

public class Account
{
    int _balance;
    int _balance2;
    public Account(int balance,int balance2)
    {
        _balance=balance;
        _balance2=balance2;
    }
    public int GetBalance()
    {
        _balance+=_balance2;
        return _balance;
    }

}
