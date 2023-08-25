using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public interface IUser
    {
        //نام کاربر
        string Name { get; set; }

        //سبد خرید کابر
        ShoppingCartModel ShoppingCart { get; set; }
        
      
        // میزان تخفیف براساس نوع کابر
        decimal Dlg_GetDiscountePrice(decimal totalPrice);
    }
}
