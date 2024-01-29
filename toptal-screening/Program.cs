// See https://aka.ms/new-console-template for more information

using toptal_screening;

var client = new HttpClient();

//Items 1 and 2 - Read and convert Json Data to Model
var jsonString = await client.GetStringAsync("https://topt.al/kjcmWA");
var jsonContent = Order.FromJson(jsonString);

//Item 3 - Show Order id and number
Console.WriteLine($"Item 3:");
foreach (var order in jsonContent)
{    
    Console.WriteLine($"{order.OrderId}, {order.OrderNumber}");
}

//Item 4 - Show order status and total of same status 
Console.WriteLine($"Item 4:");
foreach (var order in jsonContent.OrderBy(x => x.CustomerName))
{
    var sumStatus = jsonContent.Count(x => x.OrderStatus == order.OrderStatus);    
    Console.WriteLine($"{order.OrderId}, {order.CustomerName}, {order.OrderStatus}, Qtd orders status: {sumStatus}");
}

//Item 5 - Show amount of items with Grocery produts
Console.WriteLine($"Item 5:");
foreach (var order in jsonContent.OrderBy(x => x.CustomerName))
{
    if (order.OrderItems.Any(o => o.ProductCategory == ProductCategory.Grocery))
    {
        var sumOrderItems = order.OrderItems.Sum(o => o.UnitPrice);
        if (sumOrderItems < 100)
        {
            Console.WriteLine($"{order.OrderId}, Total price: {sumOrderItems}");
        }
    }
}

//Item 6 - Show avg of prices in a single order
Console.WriteLine("Item 6:");
foreach (var order in jsonContent.OrderBy(x => x.CustomerName))
{
    var avgPrice = order.OrderItems.Average(o => o.UnitPrice);
    Console.WriteLine($"{order.OrderId}, avg: {avgPrice}");

}

Console.ReadLine();


