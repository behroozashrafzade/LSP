
namespace LSP;

public
    class BanckAccount
{
    protected int balance;

    public void Deposit (int amount)
    {
        balance += amount;
        Console.WriteLine($"Deposit {amount} , Total Amount : {balance}");

    }

    public int getBalance()
    {
        return balance;
    }

    public virtual void Withdraw(int amount)
    {
        if (balance >= amount)
        {
            balance -= amount;
            Console.WriteLine($"Withdraw {amount} , Balance : {balance}");
        }
        else
            Console.WriteLine("Insufficient funds");
    }
}
