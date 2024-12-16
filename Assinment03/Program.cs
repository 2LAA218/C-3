namespace Assinment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //Console.Write("Enter a number: ");
            //int number = int.Parse(Console.ReadLine());
            //string result = (number % 3 == 0 && number % 4 == 0) ? "Yes" : "No";
            //Console.WriteLine(result);
            #endregion
            #region Q2
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //string result = (number < 0) ? "negative" : "positive";
            //Console.WriteLine(result);
            #endregion
            #region Q3
            //Console.Write("Enter the first integer: ");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second integer: ");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the third integer: ");
            //int num3 = int.Parse(Console.ReadLine());
            //int maxElement = num1;
            //if (num2 > maxElement)
            //    maxElement = num2;
            //if (num3 > maxElement)
            //    maxElement = num3;
            //int minElement = num1;
            //if (num2 < minElement)
            //    minElement = num2;
            //if (num3 < minElement)
            //    minElement = num3;
            //Console.WriteLine($"Max element = {maxElement}");
            //Console.WriteLine($"Min element = {minElement}");
            #endregion
            #region Q4
            //Console.Write("Enter an integer number: ");
            //int number = int.Parse(Console.ReadLine());
            //string result = (number % 2 == 0) ? "Even" : "Odd";
            //Console.WriteLine($"The number is {result}");
            #endregion
            #region Q5
            //Console.Write("Enter a character: ");
            //char input = char.ToLower(Console.ReadKey().KeyChar);
            //Console.WriteLine();
            //string result = (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u')
            //                ? "vowel"
            //                : "consonant";
            //Console.WriteLine(result);
            #endregion
            #region Q6
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(i + (i < number ? ", " : ""));
            //}
            //Console.WriteLine();
            #endregion
            #region Q7
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.Write(number * i + (i < 12 ? " " : ""));
            //}
            //Console.WriteLine();
            #endregion
            #region Q8
            //Console.Write("Enter an integer: ");
            //int number = Convert.ToInt32(Console.ReadLine());
            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.Write(i + (i + 2 <= number ? " " : ""));
            //}
            //Console.WriteLine();
            #endregion
            #region Q9
            //Console.Write("Enter the base number: ");
            //int BaseNumber = int.Parse(Console.ReadLine());
            //Console.Write("Enter the exponent: ");
            //int exponent = int.Parse(Console.ReadLine());
            //int result = 1;
            //for (int i = 1; i <= exponent; i++)
            //{
            //    result *= BaseNumber;
            //}
            //Console.WriteLine($"The result of {BaseNumber}^{exponent} is: {result}");
            #endregion
            #region Q10
            //Console.WriteLine("Enter marks of five subjects one by one:");
            //Console.Write("Enter marks for subject 1: ");
            //int subject1 =int.Parse(Console.ReadLine());
            //Console.Write("Enter marks for subject 2: ");
            //int subject2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter marks for subject 3: ");
            //int subject3 = int.Parse(Console.ReadLine());
            //Console.Write("Enter marks for subject 4: ");
            //int subject4 = int.Parse(Console.ReadLine());
            //Console.Write("Enter marks for subject 5: ");
            //int subject5 = int.Parse(Console.ReadLine());
            //int totalMarks = subject1 + subject2 + subject3 + subject4 + subject5;
            //int averageMarks = totalMarks / 5;
            //int percentage = averageMarks; 
            //Console.WriteLine($"Total Marks = {totalMarks}");
            //Console.WriteLine($"Average Marks = {averageMarks}");
            //Console.WriteLine($"Percentage = {percentage}%");
            #endregion
            #region Q11
            //Console.Write("Enter Month Number (1:12): ");
            //int monthNumber = Convert.ToInt32(Console.ReadLine());
            //int daysInMonth;
            //if (monthNumber == 1 || monthNumber == 3 || monthNumber == 5 || monthNumber == 7 ||
            //    monthNumber == 8 || monthNumber == 10 || monthNumber == 12)
            //{
            //    daysInMonth = 31;
            //}
            //else if (monthNumber == 4 || monthNumber == 6 || monthNumber == 9 || monthNumber == 11)
            //{
            //    daysInMonth = 30;
            //}
            //else if (monthNumber == 2)
            //{
            //    daysInMonth = 28;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid month number!");
            //    return;
            //}
            //Console.WriteLine($"Days in Month: {daysInMonth}");
            #endregion
            #region Q12
            //Console.Write("Enter the first number: ");
            //double num1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter an operator (+, -, *, /): ");
            //char operation = char.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //double num2 = double.Parse(Console.ReadLine());
            //double result = 0;
            //switch (operation)
            //{
            //    case '+':
            //        result = num1 + num2;
            //        break;
            //    case '-':
            //        result = num1 - num2;
            //        break;
            //    case '*':
            //        result = num1 * num2;
            //        break;
            //    case '/':
            //        if (num2 != 0)
            //        {
            //            result = num1 / num2;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Error: Division by zero is not allowed.");
            //            return;
            //        }
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator!");
            //        return;
            //}
            //Console.WriteLine($"Result: {num1} {operation} {num2} = {result}");
            #endregion
            #region Q13
            //Console.Write("Enter a string: ");
            //string input = Console.ReadLine();
            //string reversed = "";

            //for (int i = input.Length - 1; i >= 0; i--)
            //{
            //    reversed += input[i];
            //}
            //Console.WriteLine($"Reversed string: {reversed}");
            #endregion
            #region Q14
            //Console.Write("Enter an integer: ");
            //int number = int.Parse(Console.ReadLine());
            //int reversed = 0;
            //while (number != 0)
            //{
            //    int digit = number % 10; 
            //    reversed = reversed * 10 + digit; 
            //    number /= 10; 
            //}
            //Console.WriteLine($"Reversed number: {reversed}");
            #endregion
            #region Q15
            //    Console.Write("Input starting number of range: ");
            //    int start = int.Parse(Console.ReadLine());
            //    Console.Write("Input ending number of range: ");
            //    int end = int.Parse(Console.ReadLine());
            //    Console.WriteLine($"The prime numbers between {start} and {end} are:");
            //    for (int num = start; num <= end; num++)
            //    {
            //        if (IsPrime(num))
            //        {
            //            Console.Write(num + " ");
            //        }
            //    }
            //}
            //static bool IsPrime(int number)
            //{
            //    if (number <= 1) return false;
            //    for (int i = 2; i <= Math.Sqrt(number); i++)
            //    {
            //        if (number % i == 0)
            //            return false;
            //    }
            //    return true;
            #endregion
            #region Q16
            //Console.Write("Enter a number to convert: ");
            //int decimalNumber = Convert.ToInt32(Console.ReadLine());
            //string binaryNumber = "";
            //while (decimalNumber > 0)
            //{
            //    int remainder = decimalNumber % 2;
            //    binaryNumber = remainder + binaryNumber; 
            //    decimalNumber /= 2; 
            //}
            //Console.WriteLine($"The Binary of {decimalNumber} is {binaryNumber}");
            #endregion
            #region Q17
            //Console.Write("Enter x1: ");
            //double x1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter y1: ");
            //double y1 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter x2: ");
            //double x2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter y2: ");
            //double y2 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter x3: ");
            //double x3 = Convert.ToDouble(Console.ReadLine());

            //Console.Write("Enter y3: ");
            //double y3 = Convert.ToDouble(Console.ReadLine());
            //double slope1 = (y2 - y1) / (x2 - x1);
            //double slope2 = (y3 - y2) / (x3 - x2);
            //if (slope1 == slope2)
            //{
            //    Console.WriteLine("The points lie on a single straight line.");
            //}
            //else
            //{
            //    Console.WriteLine("The points do not lie on a single straight line.");
            //}
            #endregion
            #region Q18
            //Console.Write("Enter the time taken by the worker (in hours): ");
            //double timeTaken =double.Parse(Console.ReadLine());
            //if (timeTaken >= 2 && timeTaken <= 3)
            //{
            //    Console.WriteLine("The worker is highly efficient.");
            //}
            //else if (timeTaken > 3 && timeTaken <= 4)
            //{
            //    Console.WriteLine("The worker needs to increase their speed.");
            //}
            //else if (timeTaken > 4 && timeTaken <= 5)
            //{
            //    Console.WriteLine("The worker needs training to enhance their speed.");
            //}
            //else if (timeTaken > 5)
            //{
            //    Console.WriteLine("The worker is required to leave the company.");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input. Time cannot be less than 0.");
            //}
            #endregion

        }
    }
}