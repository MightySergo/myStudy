// Напишите программу, которая задаёт массив из n элементов и выводит их на экран

int[] UserArray(int arrayL)
{
  int[] outputArray = new int [arrayL];
  Console.WriteLine("Do you want to fill your array with random numbers?"); // Даем выбор 
  Console.WriteLine("1.Yes");
  Console.WriteLine("2.No");
  int userInput = Convert.ToInt32(Console.ReadLine());

  if (userInput == 1){
    for (int i = 0; i < outputArray.Length;i++)    {
        outputArray[i] = new Random().Next();
    }
  } 
  
  else if (userInput == 2){
    for (int i = 0; i < outputArray.Length; i++)
    {
    Console.WriteLine($"Enter {i+1} number: ");
    outputArray[i] = Convert.ToInt32(Console.ReadLine());        
    }
  } 
  
  else {
    Console.WriteLine("Invalid choice");
  }
  
  for (int i = 0; i < outputArray.Length; i++)
  {
    Console.Write($"{outputArray[i]} ");
  }

  return outputArray;   
}

Console.WriteLine("Enter your array length: ");
int userLenght = Convert.ToInt32(Console.ReadLine());
UserArray(userLenght);

