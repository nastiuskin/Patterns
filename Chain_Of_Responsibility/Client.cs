using Behave_Patterns.Chain_Of_Responsibility;

class Client
{
    static void main(string[] args)
    {
        // Создаем экземпляр Receiver, указывая, какие виды платежей поддерживаются
        Receiver receiver = new Receiver(canDoBankTransfer: false, canDoMoneyTransfer: true, canDoPayPalTransfer: true);
        createChain(receiver);
    }

    static void createChain(Receiver receiver) 
    {

        // Создаем и настраиваем обработчики платежей
        PaymentHandler bankPaymentHandler = new BankPaymentHandler();
        PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
        PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();

        // Устанавливаем порядок следования обработчиков
        bankPaymentHandler.NextHandler = moneyPaymentHadler;
        moneyPaymentHadler.NextHandler = paypalPaymentHandler;

        // Вызываем метод Handle для обработчика банковского перевода
        bankPaymentHandler.Handle(receiver);
    }
}
