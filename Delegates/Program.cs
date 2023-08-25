using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//The Dlg_ prefix means delgeted methos!


namespace Delegates
{
    internal class Program
    {
        #region functions
        //fields initialization
        private static ShoppingCartModel fillShoppingCart()
        {
            //سبد خرید
            ShoppingCartModel cart = new ShoppingCartModel();

            cart.Products.Add(new ProductModel() { ProductName = "Tshirt1", Price = 10.5M });
            cart.Products.Add(new ProductModel() { ProductName = "Tshirt2", Price = 15.3M });
            cart.Products.Add(new ProductModel() { ProductName = "Tshirt3", Price = 21M });
            cart.Products.Add(new ProductModel() { ProductName = "Tshirt4", Price = 18.8M });

            return cart;
        }

        //it will use in Func<>
        private static decimal Dlg_calculateTotal(List<ProductModel> items)
        {
            return items.Sum(x => x.Price);
        }

        //it's void, so we will use Action<>
        private static void Dlg_printDiscountAmount(decimal total, decimal discount)
        {
            Console.WriteLine($"% amount is: {total - discount} OFF!");
        }
        #endregion

        static void Main(string[] args)
        {
            //polymorphism instance
            IUser normalUser = new NormalUser() { Name = "Brad Pitt" };
            IUser goldenUser = new GoldenUser() { Name = "Angelina Jolie" };


            normalUser.ShoppingCart = fillShoppingCart();
            goldenUser.ShoppingCart = fillShoppingCart();


            //1st Argument delegted with "delegate" keyword. & need its dependency className.Method
            //2nd  //       //      with  Func<>    keyword. just method name cuz define here!
            //3rd  //       //      with  Action<>  keyword.
            decimal normalUserFinalPrice = normalUser.ShoppingCart.GetFinalPrice(normalUser.Dlg_GetDiscountePrice, Dlg_calculateTotal, Dlg_printDiscountAmount);
            Console.WriteLine($"> {normalUser.Name} payment: ${normalUserFinalPrice}\n");
            
            decimal goldenUserFinalPrice = goldenUser.ShoppingCart.GetFinalPrice(goldenUser.Dlg_GetDiscountePrice, Dlg_calculateTotal, Dlg_printDiscountAmount);
            Console.WriteLine($"> {goldenUser.Name} payment: ${goldenUserFinalPrice}");


            Console.ReadKey();
        }
    }
}

