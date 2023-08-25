using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class NormalUser : IUser
    {
        public string Name { get ; set; }
        public ShoppingCartModel ShoppingCart { get; set; }= new ShoppingCartModel();

        decimal IUser.Dlg_GetDiscountePrice(decimal totalPrice)
        {
            if (ShoppingCart.Products.Count > 5)
            {
                //if buy more, havee %Off
                return totalPrice * (1 - 0.30M);
            }
            else
            {
                return totalPrice;
            }
        }
    }
}
