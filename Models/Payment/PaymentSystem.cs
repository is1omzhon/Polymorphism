namespace Models.Payment.PaymentSystem;

class Payment
{
    public virtual void Pay()
    {
        Console.WriteLine("Payed!!!");
    }    
}

class ClickPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Paid with Click !!!");
    }
}

class PaymePayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Paid with Payme !!!");
    }
}

class CashPayment : Payment
{
    public override void Pay()
    {
        Console.WriteLine("Paid with Cash !!!");
    }
}