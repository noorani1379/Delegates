using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class GoldenUser : IUser
    {
        public string Name { get; set; }
        public ShoppingCartModel ShoppingCart { get; set; } = new ShoppingCartModel();

        public decimal Dlg_GetDiscountePrice(decimal totalPrice)
        {
            //default has 30% discount 
            return totalPrice * (1 - 0.30M);
        }

    }
}
