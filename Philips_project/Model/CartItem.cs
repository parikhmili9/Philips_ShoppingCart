namespace Philips_Project.Model
{
    /**
    * This class represents the model for the items in a shopping cart
    * with attributes - Name, Price and Quanitity.
    **/
    public class CartItem 
    {
        public string Name {get; set;}
        public double Price {get; set;}
        public int Quantity {get; set;}

        public override string ToString()
        {
            return $"Name: {Name}, Price: {Price}, Quantity: {Quantity}";
        }
    }
}