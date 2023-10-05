// See https://aka.ms/new-console-template for more information

// Get the input from the user 
Console.WriteLine("plesse Enter the first number ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine(" plese Enter the second number");
int number2 = int.Parse(Console.ReadLine());
Console.WriteLine(" Palindrome numbers between {0} and {1} are :");

for ( int i = number1; i <= number2; i++ )
{
    if (IsPalindrome(i))
    {
        Console.WriteLine(i);
    }
}
 static bool IsPalindrome(int number)
{
    int originalNumber = number;
    int reversedNumber = 0;

    while (number > 0)
    {
        int remainder = number % 10;
        reversedNumber = (reversedNumber * 10) + remainder;
        number /= 10;
    }
    return originalNumber == reversedNumber;
}
 Console.Read()



    
    
   

  

    
        
        
       
    
     
