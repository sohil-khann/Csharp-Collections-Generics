using System;
using System.Collections.Generic;

namespace Scenerio_Based.ShoppingCart
{
    public class CartManager
    {
        
                private Dictionary<string, CartItem> cart;//dictionary to store
        private List<string> discountRules; //discount rules
        private const double DeliveryFee = 100.0; //delivery fees

        public CartManager()
        {
            cart = new Dictionary<string, CartItem>();
            discountRules = new List<string>
            {
                "Buy 2 Get 1 (Same Product)",
                "10% Discount on Total > ₹5000",
                "Free Delivery for 5+ Items"
            };
        }

        public void AddToCart(string name, double price, int quantity) //Add to Cart
        {
            if (cart.ContainsKey(name))
            {
                cart[name].Quantity += quantity;
            }
            else
            {
                cart[name] = new CartItem(name, price, quantity);
            }
            Console.WriteLine("Added " + quantity + " " + name + "(s) to cart.");
        }

        public void Checkout() //Addto cart
        {
            if (cart.Count == 0)
            {
                Console.WriteLine("\nCart is empty. Nothing to checkout.");
                return;
            }

            double subtotal = 0;
            int totalItems = 0;
            foreach (var item in cart.Values)
            {
                subtotal += item.GetTotal();
                totalItems += item.Quantity;
            }

            // Calculate discounts for each offer type
            double buy2Get1Discount = CalculateBuy2Get1Discount();
            double percentageDiscount = subtotal > 5000 ? subtotal * 0.10 : 0;
            double deliveryDiscount = totalItems >= 5 ? DeliveryFee : 0;

            // Determine the best offer
            double bestDiscount = 0;
            string bestOfferName = "No Offer Applied";

            if (buy2Get1Discount > bestDiscount)
            {
                bestDiscount = buy2Get1Discount;
                bestOfferName = "Buy 2 Get 1 (Same Product)";
            }

            if (percentageDiscount > bestDiscount)
            {
                bestDiscount = percentageDiscount;
                bestOfferName = "10% Discount on Total > ₹5000";
            }

            if (deliveryDiscount > bestDiscount)
            {
                bestDiscount = deliveryDiscount;
                bestOfferName = "Free Delivery for 5+ Items";
            }

            double currentDeliveryFee = totalItems >= 5 ? 0 : DeliveryFee;
            
            
            double finalDelivery = DeliveryFee;
            double finalDiscount = bestDiscount;

            // If the best offer was Free Delivery, then the discount is the delivery fee itself.
            // If another offer was better, we use that discount and pay the full delivery fee.
            if (bestOfferName == "Free Delivery for 5+ Items")
            {
                finalDelivery = 0;
                finalDiscount = 0; // We already accounted for it by setting delivery to 0
            }
            else
            {
               
            }

            double finalTotal = subtotal + finalDelivery - finalDiscount;

            GenerateBill(subtotal, finalDelivery, finalDiscount, bestOfferName, finalTotal);
        }

        private double CalculateBuy2Get1Discount()
        {
            double totalDiscount = 0;
            foreach (var item in cart.Values)
            {
                // For every 3 items, 1 is free
                int freeItems = item.Quantity / 3;
                totalDiscount += freeItems * item.Price;
            }
            return totalDiscount;
        }

        private void GenerateBill(double subtotal, double delivery, double discount, string offer, double total)
        {
            
            foreach (var item in cart.Values)
            {
                Console.WriteLine(item.Name + " x " + item.Quantity + " = ₹" + item.GetTotal());
            }
            
            Console.WriteLine("Subtotal:       ₹" + subtotal);
            Console.WriteLine("Delivery Fee:   ₹" + delivery);
            
            if (discount > 0)
            {
                Console.WriteLine("Offer Applied:  " + offer);
                Console.WriteLine("Discount:      -₹" + discount);
            }
            else if (offer == "Free Delivery for 5+ Items")
            {
                Console.WriteLine("Offer Applied:  " + offer + " (₹" + DeliveryFee + " saved)");
            }
            else
            {
                Console.WriteLine("Offer Applied:  None");
            }
            
            Console.WriteLine("");
            Console.WriteLine("TOTAL AMOUNT:   ₹" + total);
           
        }
    }
}
