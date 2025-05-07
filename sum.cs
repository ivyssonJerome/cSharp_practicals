using System;
class HelloWorld {
  static void Main() {
    int sum = 0;
			
	Console.WriteLine("Enter the first number: ");
	int num1 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the second number: ");
	int num2 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the third number: ");
	int num3 = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the fourth number: ");
	int num4 = Convert.ToInt32(Console.ReadLine());
	
	sum = num1 + num2 + num3 + num4;
	Console.WriteLine("The sum of the four numbers is: " + sum);
	Console.ReadLine();
  }
}
