using System;

// Интерфейс для базового компонента (кофе)
interface ICoffee
{
    string GetDescription();
    double GetCost();
}

// Конкретная реализация базового компонента (обычный кофе)
class SimpleCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Simple Coffee";
    }

    public double GetCost()
    {
        return 1.0;
    }
}

// Абстрактный класс для декоратора
abstract class CoffeeDecorator : ICoffee
{
    protected readonly ICoffee DecoratedCoffee;

    public CoffeeDecorator(ICoffee decoratedCoffee)
    {
        this.DecoratedCoffee = decoratedCoffee;
    }

    public virtual string GetDescription()
    {
        return DecoratedCoffee.GetDescription();
    }

    public virtual double GetCost()
    {
        return DecoratedCoffee.GetCost();
    }
}

// Конкретные декораторы (добавление молока)
class MilkDecorator : CoffeeDecorator
{
    public MilkDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Milk";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.5;
    }
}

// Конкретные декораторы (добавление взбитых сливок)
class WhipDecorator : CoffeeDecorator
{
    public WhipDecorator(ICoffee decoratedCoffee) : base(decoratedCoffee)
    {
    }

    public override string GetDescription()
    {
        return base.GetDescription() + ", Whip";
    }

    public override double GetCost()
    {
        return base.GetCost() + 0.7;
    }
}

class Decorator
{
    static void Main(string[] args)
    {
        // Создаем базовый компонент (простой кофе)
        ICoffee coffee = new SimpleCoffee();
        Console.WriteLine("Description: " + coffee.GetDescription() + ", Cost: $" + coffee.GetCost());

        // Добавляем молоко к кофе
        coffee = new MilkDecorator(coffee);
        Console.WriteLine("Description: " + coffee.GetDescription() + ", Cost: $" + coffee.GetCost());

        // Добавляем взбитые сливки к кофе
        coffee = new WhipDecorator(coffee);
        Console.WriteLine("Description: " + coffee.GetDescription() + ", Cost: $" + coffee.GetCost());
    }
}
