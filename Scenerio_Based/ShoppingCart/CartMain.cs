/*
PROBLEM STATEMENT 2: Smart Shopping Cart System
Build a shopping cart system using collections. 
Use: 
- Dictionary for cart 
- List for discount rules 

Tasks:
1. Add items to cart (increase quantity if already present). 
2. Apply offers: 
   - Buy 2 Get 1 (same product) 
   - 10% discount if total > ₹5000 
   - Free delivery if item count >= 5 
3. Apply only one best offer. 
4. Generate final bill with breakdown. 

Edge Cases:
- Cart value exactly ₹5000 
- Multiple offers applicable simultaneously 
- Buy 2 Get 1 when quantity = 2 
- Removing item reduces eligibility 
- Empty cart checkout 


*/
using System;
namespace Scenerio_Based.ShoppingCart
{
   public class CartMain //main class
   {
        public  static void RunSmartShoppingCartSystem() //method to run program
        {
          
            CartManager cart = new CartManager(); //object 

            cart.AddToCart("Laptop", 45000, 1);// entries
            cart.AddToCart("Mouse", 500, 3);
            cart.AddToCart("Keyboard", 1200, 1);
            cart.AddToCart("USB Cable", 200, 1);
            
            cart.Checkout();

            Console.WriteLine("Test Case: Cart value exactly ₹5000");
            CartManager cart2 = new CartManager();
            cart2.AddToCart("Tablet", 5000, 1);
            cart2.Checkout();

            Console.WriteLine("Test Case: 5 items for free delivery");
            CartManager cart3 = new CartManager();
            cart3.AddToCart("Pen", 10, 5);
            cart3.Checkout();
        }
   }
   
}