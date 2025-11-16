using System;
interface DepWith
{
    void Deposit(double summa);
    void Withdraw(double summa);
}
interface Perevod
{
    void Transfer(double summa, DepWith Account);
}
class Account : DepWith, Perevod
{
    public string Number { get; }
    public double Balance { get; set; }
    public Account(string number, double balance = 0)
    {
        Number = number;
        Balance = balance;
    }
    public void Deposit(double summa)
    {
        if (summa <= 0) return;
        Balance += summa;
    }
    public void Withdraw(double summa)
    {
        if (summa <= 0 || summa > Balance) return;
        Balance -= summa;
    }
    public void Transfer(double summa, DepWith Account)
    {
        if (summa <= 0 || summa > Balance) return;
        Withdraw(summa);
        Account.Deposit(summa);
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Создаем два счёта
        Account account1 = new Account("1", 50000);
        Account account2 = new Account("2", 60000);
        account1.Transfer(6767, account2);
        Console.WriteLine($"Баланс первого аккаунта: {account1.Balance}");
        Console.WriteLine($"Баланс второго аккаунта: {account2.Balance}");
    }
}