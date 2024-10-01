try
{
    //collecting the first number from the user
    Console.WriteLine("Enter the First Number");
    int firstNumber = Convert.ToInt32(Console.ReadLine());
    //collecting the second number from the user
    Console.WriteLine("Enter the Second Number");
    int secondNumber = Convert.ToInt32(Console.ReadLine());
    //Making the user to choose the operation to perform
    Console.WriteLine("Choose the operation to perform ('+','-','*','/')");
    char operation= Convert.ToChar(Console.ReadLine());
    //performing the calculation
    double result = 0;
    switch (operation)
    {
        case '+':
            result=firstNumber + secondNumber; 
            break;
        case '*':
            result = firstNumber * secondNumber;
            break;
        case '-':
            result = firstNumber - secondNumber;
            break;
        case '/':
            result = firstNumber / secondNumber;
            break;
        default:
            Console.WriteLine("Invalid Input");
            return;
    }
    Console.WriteLine($"The Result is {result}");
}
catch (Exception ex)
{
    Console.WriteLine($"Error in application. The error is: {ex.Message}. Please restart the application.");
	
}
