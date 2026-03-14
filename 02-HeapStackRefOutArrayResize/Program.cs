//Arrayin size-in artirmaq ucun method yazmaq lazimdir.Meslen arrayin ozunu ve yeni size-ni verecem paramatr olaraq ve bunu ref out la yazmaq lazimdir   
int yeniOlcu = 0;
Console.WriteLine("Arrayin olcusunu daxil edin:");
int olcu = int.Parse(Console.ReadLine());
int[] numbers = new int[olcu];
Console.WriteLine("Arrayin memberlerini daxil edin:");
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

int[] num = [12, 13, 14, 15,];
ChangeSizeOfArray(numbers,num);



static void ChangeSizeOfArray(int[] arr, params int[] newMembers)
{
    int[] newarr = new int[arr.Length + newMembers.Length];

    for (int i = 0; i < arr.Length; i++)
    {
        newarr[i] = arr[i];
    }

    for (int i = 0; i < newMembers.Length; i++)
    {
        newarr[arr.Length+i] = newMembers[i];

    }

    Console.WriteLine("Yeni array:");
    for (int i = 0; i < newarr.Length; i++)
    {
        Console.WriteLine(newarr[i]);
    }




}