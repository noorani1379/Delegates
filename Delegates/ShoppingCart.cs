using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Delegates
{
    //سبد خرید
    
    public class ShoppingCartModel
    {
        //list of products, fields
        public List<ProductModel> Products { get; set; } = new List<ProductModel>();


        //simple Delegate; this kins is like placeHolder for method in Interface
        public delegate decimal GetDiscountePrice(decimal totalPrice);


        //Delegated methods will be passed to this method👇; just need save method signature types
        public decimal GetFinalPrice(
            GetDiscountePrice finalPrice, 
            Func< List<ProductModel>, decimal> caculateTotalPrice,
            Action<decimal, decimal> printDiscountAmount
            ) {

            decimal total = caculateTotalPrice(Products);
            decimal FinalPrice = finalPrice(total);
            printDiscountAmount(total, FinalPrice);

            return FinalPrice;
       
        }
    }
}
