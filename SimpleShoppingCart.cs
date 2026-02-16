namespace LabsAssessments;

public class SimpleShoppingCart
{
    public List<string> ItemNames { get; set; } = [];
    public List<decimal> ItemPrices { get; set; } = [];
    public const decimal DISCOUNTABLE_TOTAL = 10000m;
    public const decimal DISCOUNT_PERCENTAGE = 0.05m;

    public void ShoppingBasket()
    {
        Console.WriteLine("Enter your items into the shopping basket.\nType `done` when you are satisfied!");

        while (true)
        {
            Console.Write("Enter item name: ");
            string itemName = Console.ReadLine()!;

            if (itemName.ToLower() == "done")
            {
                break;
            }

            Console.Write("Enter item price: ");
            decimal itemPrice = decimal.Parse(Console.ReadLine()!);

            ItemNames.Add(itemName);
            ItemPrices.Add(itemPrice);
        }
    }

    public void ShoppingCartSummary()
    {
        var totalCost = GetTotalCost(ItemPrices);

        Console.WriteLine($"Total Items: {ItemNames.Count}");
        Console.WriteLine($"Sub Total: {ItemPrices.Sum()}");
        Console.WriteLine($"Discount: {totalCost.discountedAmount:F2}");
        Console.WriteLine($"Net total: {totalCost.total:F2}");
        Console.WriteLine($"Most Expensive Item: {ItemPrices.Max():F2}");
        Console.WriteLine($"Cheapest Item: {ItemPrices.Min()}");
    }

    (decimal total, decimal discountedAmount) GetTotalCost(List<decimal> prices)
    {
        var result = CalculateDiscount(prices);

        return result;
    }

    (decimal total, decimal discountedAmount) CalculateDiscount(List<decimal> prices)
    {
        var total = prices.Sum();
        var discountedAmount = 0.00m;

        if (total > DISCOUNTABLE_TOTAL)
        {
            discountedAmount = total * DISCOUNT_PERCENTAGE;
            total -= discountedAmount;
            return (total, discountedAmount);
        }

        return (total, discountedAmount); ;
    }
}
