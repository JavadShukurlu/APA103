//1)
//Console.WriteLine("Ededleri daxil edin:");
//Console.Write("Birinci eded:");
//int birinci_eded= Convert.ToInt32(Console.ReadLine());
//Console.Write("Ikinci eded:");
//int ikinci_eded = Convert.ToInt32(Console.ReadLine());
//Addition(birinci_eded, ikinci_eded);
//Subtraction(birinci_eded, ikinci_eded);
//Multiplication(birinci_eded, ikinci_eded);
//Division(birinci_eded, ikinci_eded);


//static void Addition(int a,int b)
//{
//    int result = a + b;
//    Console.WriteLine(result);
//}
//static void Subtraction(int a, int b)
//{
//    int result = a - b;
//    Console.WriteLine(result);
//}
//static void Multiplication(int a, int b)
//{
//    int result = a * b;
//    Console.WriteLine(result);
//}
//static void Division(int a, int b)
//{
//    int result = a % b;
//    Console.WriteLine(result);
//}

//--------------------

//2)
//int [] numbers = { 14, 20, 35, 40, 57, 60, 100 }; 
//CheckNumber(numbers);
//static void CheckNumber(params int[] numbers) {
//    Console.WriteLine("Cut ededler:");
//    for(int i=0;i<numbers.Length; i++)
//    {                           
//        if(numbers[i] %2 == 0)
//            Console.WriteLine(numbers[i]);

//    }
//    Console.WriteLine("Tek ededler:");
//    for (int i = 0; i < numbers.Length; i++)
//    {
//        if (numbers[i] % 2 != 0)
//            Console.WriteLine(numbers[i]);
//    }
//}

//---------------------

//3)
//int [] numbers = { 14, 20, 35, 40, 57, 60, 100 };
//Sum(numbers);
//static void Sum(params int[] numbers)
//{
//    Console.WriteLine("Hem 4-e hem de 5-e bolunen ededler:");
//       for(int i = 0; i < numbers.Length; i++)
//    {
//        if(numbers[i] %4== 0 && numbers[i] %5==0)
//            Console.WriteLine(numbers[i]);
//    }
//}

//----------------------

//4)
//Console.WriteLine("Cumleni daxil edin:");
//string cumle = Console.ReadLine();
//Console.WriteLine("Simvolu daxil edin:");
//string simvol = Console.ReadLine();
//CountLetters(cumle, simvol);
//static void CountLetters(string cumle,string daxiledilen_simvol)
//{
//    int count = 0;
//    foreach(int simvol in cumle)
//    {
//        if(simvol==Convert.ToChar(daxiledilen_simvol))
//            count++;

        
//    }
//    Console.WriteLine($"Daxil edilmis simvol sayi:{count}");

//}