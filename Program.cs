using System.Reflection.Metadata.Ecma335;

namespace Class_Activity2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int questionNum = 0;

            {
                Console.WriteLine("Enter the question number: ");
                questionNum = int.Parse(Console.ReadLine());

                switch (questionNum)
                {

                    case 1://///////////////////////////////////////////////////////////////////////////////////////////
                        Boolean isValid = true;
                        Boolean isContinue = false; //In the case that a user enters 999
                        string input1 = "";

                        do
                        {
                            isValid = true;

                            Console.WriteLine("Enter 10 numbers");
                            input1 = Console.ReadLine();

                            if (input1.Contains("999"))
                            {
                                isContinue = true;
                                break;
                            }

                            if (input1.Length > 10)
                            {
                                Console.WriteLine("Your input is too long");
                                isValid = false;
                            }

                            if (input1.Length < 10)
                            {
                                Console.WriteLine("Your input is too short");
                                isValid = false;
                            }

                            for (int i = 0; i < input1.Length; i++)
                            {
                                try
                                {
                                    int intTest = int.Parse(input1[i].ToString());
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine("Invalid input type. Only input string");
                                    isValid = false;
                                }
                                ;
                            }

                        } while (!isValid); //input is valid after this do-while

                        if (isContinue)
                        {
                            Console.WriteLine("You have entered the text \'999\'. Closing application.");
                            break;
                        }

                        String output1 = input1.Insert(0, "(");
                        output1 = output1.Insert(4, ") ");
                        output1 = output1.Insert(9, "-");

                        Console.WriteLine("The output is:\t" + output1);

                        break;

                    case 2://///////////////////////////////////////////////////////////////////////////////////////////

                        string input2 = "";
                        string output2 = "";
                        int spaceCount = 0;

                        do
                        {
                            spaceCount = 0;
                            Console.WriteLine("Enter at least 3 words to create an acronym");
                            input2 = Console.ReadLine();

                            foreach (char c in input2)
                            {
                                if (c == ' ')
                                    spaceCount++;
                            }

                        } while (spaceCount < 2);

                        for (int f = 0; f < 3; f++)
                        {
                            output2 += char.ToUpper(input2[0]);

                            input2 = input2.Remove(0, input2.IndexOf(" ") + 1);
                        }

                        Console.WriteLine("Acronym: " + output2);

                        break;

                    case 3://///////////////////////////////////////////////////////////////////////////////////////////

                        Console.WriteLine("This is a calculator that calculates the sum of two numbers\nEnter first number:");
                        int num1 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Enter second number:");
                        int num2 = int.Parse(Console.ReadLine());

                        int result = Calculator.Add(num1, num2);

                        Console.WriteLine("Sum: " + result);

                        break;

                    case 4://///////////////////////////////////////////////////////////////////////////////////////////
                        double input4 = 0;
                        double output4 = 0;

                        Console.WriteLine("Enter how many degrees Celsius: ");
                        input4 = double.Parse(Console.ReadLine());

                        Console.WriteLine(input4 + "°C is equal to " + TemperatureConverter.CelsiusToFahrenheit(input4) + "°F");

                        break;


                    case 5://///////////////////////////////////////////////////////////////////////////////////////////
                        int input5 = 0;

                        Console.WriteLine("Enter a number and the program will determine if it is odd or even");
                        input5 = int.Parse(Console.ReadLine());

                        if (Validator.isEven(input5))
                        {
                            Console.WriteLine("The number " + input5 + " is even");
                        }
                        else
                        {
                            Console.WriteLine("The number " + input5 + " is odd");
                        }

                        break;

                    case 6://///////////////////////////////////////////////////////////////////////////////////////////
                        // ! function, but for +

                        int input6 = 0;
                        int subrtact = -2;
                        int addition = 0;

                        string output6 = "";

                        do
                        {
                            isValid = true;

                            Console.WriteLine("Enter a number and the '!' function will be changed from '*' to '+'");

                            try
                            {
                                input6 = int.Parse(Console.ReadLine());

                                if (input6 == 0)
                                {
                                    isValid = false;
                                }

                            }
                            catch (Exception ex)
                            {
                                isValid = false;

                            }

                        } while (!isValid);

                        for (int i = 0; i < input6; i++)
                        {
                            subrtact++;

                            for (int k = input6 - subrtact - 1; k >= 1; k--)
                            {
                                output6 += k + "+";
                                addition += k;
                            }
                        }

                        output6 = output6.Remove(output6.Length - 1, 1);

                        output6 += "=" + addition;

                        Console.WriteLine(output6);

                        break;

                    default:
                        Console.WriteLine("Closing");
                        break;
                }
            } while ((questionNum < 0) || (questionNum > 6)) ;


        }
    }
}
