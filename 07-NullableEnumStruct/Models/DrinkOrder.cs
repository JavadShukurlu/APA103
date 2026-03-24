using _07_NullableEnumStruct.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _07_NullableEnumStruct.Models
{
    internal class DrinkOrder
    {
        public int OrderNumber { get; set; }
        public string? CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; } = OrderStatus.New;
        public decimal Price { get; set; }

        public DrinkOrder(int orderNumber, string customerName, DrinkType drink, DrinkSize size)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
        }

        

        public void CalculatePrice()
        {
            Console.WriteLine("Secimler:");
            Console.WriteLine("0-Coffe\n" +
                "1-Tea\n" +
                "2-Juice\n" +
                "3-Water");
            Console.WriteLine("Size ucun seciminizi daxil edin:");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Icki secmini  daxil edin:");
            int chose = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Secdiyiniz ickinin miqdarini daxil edin:");
            int say = Convert.ToInt32(Console.ReadLine());

            switch (chose)
            {
                case (int)DrinkType.Tea:
                    switch (size)
                    {
                        case (int)DrinkSize.Small:
                            Price = 2m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                        case (int)DrinkSize.Medium:
                            Price = 3m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                        case (int)DrinkSize.Large:
                            Price = 4m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                        default:
                            Console.WriteLine("Duzgun secim edin:");
                            break;

                    }
                    break;
                case (int)DrinkType.Coffee:
                    switch (size)
                    {
                        case (int)DrinkSize.Small:
                            Price = 3m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                         case (int)DrinkSize.Medium:
                            Price = 4m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                          case (int)DrinkSize.Large:
                            Price = 5m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                        default:
                            Console.WriteLine("Duzgun secim edin:");
                            break;
                    }
                    break;

                case (int)DrinkType.Juice:
                    switch(size)
                    {
                        case (int)DrinkSize.Small:
                            Price = 4m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                        case (int)DrinkSize.Medium:
                            Price = 5m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                        case (int)DrinkSize.Large:
                            Price = 6m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                        default:
                            Console.WriteLine("Duzgun secim edin:");
                            break;


                    }
                    break;
                case (int)DrinkType.Water:
                    switch (size)
                    {
                        case (int)DrinkSize.Small:
                            Price = 1m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                        case (int)DrinkSize.Medium:
                            Price = 1.5m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                        case (int)DrinkSize.Large:
                            Price = 2m * say;
                            Console.WriteLine($"Price:{Price}");
                            break;
                        default:
                            Console.WriteLine("Duzgun secim edin:");
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Duzgun secim edin:");
                    break;
                    

            }
        }

        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;
            Console.WriteLine($"Sifaris:{OrderNumber} Statusu:{newStatus}");
        }
         public void DisplayOrder()
        {
            Console.WriteLine($"OrderNumber:{OrderNumber},Customer:{CustomerName} Size:{Size} Statusu:{Status}");
        }

        public static  void GetValues()
        {
            Console.WriteLine("Drink Types:");
            foreach(var item in Enum.GetValues(typeof(DrinkType)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Drink Sizes:");
            foreach(var item in Enum.GetValues(typeof(DrinkSize)))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Order Status:");
            foreach(var item in Enum.GetValues(typeof(OrderStatus)))
            {
                Console.WriteLine(item);
            }
            
        }

    }
}
