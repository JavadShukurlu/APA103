using _07_NullableEnumStruct.Enums;
using _07_NullableEnumStruct.Models;

DrinkOrder order1 = new DrinkOrder(101,"Ali",DrinkType.Coffee,DrinkSize.Medium);
order1.DisplayOrder();
order1.UpdateStatus(OrderStatus.Preparing);
order1.UpdateStatus(OrderStatus.Ready);
order1.UpdateStatus(OrderStatus.Delivered);
order1.CalculatePrice();

DrinkOrder order2 = new DrinkOrder(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
order2.DisplayOrder();
order2.UpdateStatus(OrderStatus.Ready);
order2.CalculatePrice();

DrinkOrder order3=new DrinkOrder(103,"Vuqar",DrinkType.Juice,DrinkSize.Small);
order3.DisplayOrder();
order3.CalculatePrice();


DrinkOrder.GetValues();

decimal umumiQiymet= order1.Price + order2.Price + order3.Price;
Console.WriteLine($"Umumi qiymet:{umumiQiymet}");


