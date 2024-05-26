string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

string[] orderIds = orderStream.Split(",");

Array.Sort(orderIds);

foreach (string orderId in orderIds)
{
    if (orderId.Length == 4)
    {
        Console.WriteLine(orderId);
    }
    else
    {
        Console.WriteLine($"{orderId}  - Error");
    }
}