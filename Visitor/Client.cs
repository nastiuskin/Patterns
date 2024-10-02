using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behave_Patterns.Visitor
{
    internal class Client
    {
        public static void main(string[] args)
        {
            List<IProduct> products = new List<IProduct>()
            {
                new Electronics{Price = 500},
                new Clothes { Price = 300},
                new Book {Price= 250},
                new Book {Price = 300}
            };
            var totalPriceVisitor = new TotalPriceVisitor();
            foreach(var product in products)
            {
                product.Accept(totalPriceVisitor);
            }

            Console.WriteLine($"Total price before discount: {totalPriceVisitor.totalPrice}");

            var discountVisitor = new DiscountVisitor();
            foreach(var product in products)
            {
                product.Accept(discountVisitor);
            }

            totalPriceVisitor.totalPrice = 0;
            foreach(var product in products)
            {
                product.Accept(totalPriceVisitor);
            }

            Console.WriteLine($"Total price before discount: {totalPriceVisitor.totalPrice}");

        }
    }
}
