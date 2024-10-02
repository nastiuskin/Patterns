using System;

// Подсистема, отвечающая за кофейный аппарат
class CoffeeMachine  
{
    public void TurnOn()
    {  
        Console.WriteLine("Включение кофейного аппарата");
    }

    public void GrindCoffeeBeans()
    {
        Console.WriteLine("Моление кофейных зерен");
    }

    public void BrewCoffee()
    {
        Console.WriteLine("Приготовление кофе");
    }

    public void TurnOff()
    {
        Console.WriteLine("Выключение кофейного аппарата");
    }
}

class Milk
{
    public void AddMilk()
    {
        Console.WriteLine("Добавление молока");
    }
}

// Дополнительный компонент - добавление сиропа
class Syrup
{
    public void AddSyrup()
    {
        Console.WriteLine("Добавление сиропа");
    }
}

// Фасад, предоставляющий унифицированный интерфейс для приготовления кофе
class CoffeeFacade
{
    private CoffeeMachine coffeeMachine;
    private Milk milk;
    private Syrup syrup;

    public CoffeeFacade()
    {
        coffeeMachine = new CoffeeMachine();
        milk = new Milk();
        syrup = new Syrup();
    }

    public void MakeCoffee(bool addMilk, bool addSyrup)
    {
        coffeeMachine.TurnOn();
        coffeeMachine.GrindCoffeeBeans();
        coffeeMachine.BrewCoffee();
        if (addMilk)
            milk.AddMilk();
        if (addSyrup)
            syrup.AddSyrup();
        coffeeMachine.TurnOff();
    }
}

class Program
{
    static void main(string[] args)
    {
        // Использование фасада для приготовления кофе
        CoffeeFacade coffeeMaker = new CoffeeFacade();
        coffeeMaker.MakeCoffee(true, true);
    }
}
