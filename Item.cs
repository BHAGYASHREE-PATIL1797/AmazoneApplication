
using Catalog;

namespace ShoppingCart
{
    public class Item
    {

        private int Quality;
        public Product theProduct { get; set; }
        public int Quantity { get; set; }
        public Item(Product theproduct, int Quantity)
        {
            this.theProduct = theproduct;
           this.Quantity = Quantity;
        }


        public override string ToString()
        {
            //
            //return base.ToString();
            return (this.theProduct+" "+ this.Quantity);


        }




        }





       
}
