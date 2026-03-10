namespace _00P_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order();
            BreadStick breadstick = new BreadStick(true);

            List<string> toppings = new List<string>();
            toppings.Add("Pepperoni");
            toppings.Add("Mushroom");
            toppings.Add("Olives");

            Pizza pizza = new Pizza(toppings, "Large");
            order.Items.Add(pizza);
            order.Items.Add(breadstick);
            order.DisplayItems();
            Console.WriteLine(order.Total());

            
        }
    }
}
