
Console.ForegroundColor = ConsoleColor.Red; //Just to change the display

Console.WriteLine("ATM CLASS WORK");

//This class work will be implemented using a Switch statement first.
/*
 * This program will prompt the user to do the following
 * Withdraw, Transfer, Deposit, Balance and Exit by selecting numbers from (1-5)
 * The whole program will be enclosed in a While loop which may execute or exit by command
 */

//Global variables
double accountBalance = 250000.00;
double amountEntered = 0.00;
bool choice = true;

//Methods for the ATM program
//1) Withdraw method
 void Withdraw()
{
    Console.WriteLine("Enter amount to withdraw: ");
    
    //user input
    string userInput = Console.ReadLine();

    //Checks if user input can be converted to double
    bool numberChecker = double.TryParse(userInput, out double amount);

    //If user input is a digit...proceed to the rest of the if - statement
    if (numberChecker)
    {
        amountEntered = double.Parse(userInput);

        if (amountEntered < accountBalance)
        {
            accountBalance -= amountEntered; //amountEntered is subtracted from accountBalance
            Console.WriteLine($" You withdrew ${amountEntered:N2}. Your new account Balance is: ${accountBalance:N2} ");
        }

        else
        {
            Console.WriteLine($"Amount entered exceeds withdrawable balance.");
        }
    }

    //If user input is not a digit, gives a warning.
    else
    {
        Console.WriteLine($"{userInput} is not a digit!!");
    }
    
}

//2) Transfer method
void Transfer()
{
    Console.WriteLine("Enter amount to Transfer: ");

    //user input
    string userInput = Console.ReadLine();

    //Checks if user input can be converted to double
    bool numberChecker = double.TryParse(userInput, out double amount);

    //If user input is a digit...proceed to the rest of the if - statement
    if (numberChecker)
    {
        amountEntered = double.Parse(userInput);

        if (amountEntered < accountBalance)
        {
            accountBalance -= amountEntered; //amountEntered is subtracted from accountBalance
            Console.WriteLine($" You transferred ${amountEntered:N2}. Your new account Balance is: ${accountBalance:N2} ");
        }

        else
        {
            Console.WriteLine($"Amount entered exceeds transferable balance.");
        }
    }

    //If user input is not a digit...gives a warning.
    else
    {
        Console.WriteLine($"{userInput} is not a digit. Enter a valid amount.");
    }
    
}

//3) Deposit Method
void Deposit()
{
    Console.WriteLine("Enter amount to Deposit: ");

    //user input
    string userInput = Console.ReadLine();

    //Checks if user input can be converted to double
    bool numberChecker = double.TryParse(userInput, out double amount);

    //If user input is a digit...proceed to the rest of the if - statement
    if (numberChecker)
    {
        amountEntered = double.Parse(userInput);

        if (amountEntered > 0.00)
        {
            accountBalance += amountEntered; //amountEntered is added to accountBalance
            Console.WriteLine($" You deposited ${amountEntered:N2}. Your new account Balance is: ${accountBalance:N2} ");
        }

        else
        {
            Console.WriteLine($"Amount entered can not be deposited.");
        }
    }

    //If user input is not a digit...gives a warning.
    else
    {
        Console.WriteLine($"{userInput} is not a digit. Enter a valid amount.");
    }

}


//4) Deposit Method
void Balance()
{
    Console.WriteLine($" Your account Balance is: ${accountBalance:N2}");
}

/*
//First implementation using while loop
while (choice)
{
    Console.WriteLine($"Welcome John Doe. Your Account Balance is: ${accountBalance:F2}");
    Console.WriteLine("Press 1 to Withdraw.");
    Console.WriteLine("Press 2 to Transfer.");
    Console.WriteLine("Press 3 to Deposit.");
    Console.WriteLine("Press 4 to Check Balance.");
    Console.WriteLine("Press 5 to Exit.");

    //Prompts user for input
    string userInput = Console.ReadLine();

    //Check if user's input is valid
    bool numberChecker = int.TryParse(userInput, out int amount);

    if (numberChecker == true)
    {
        amountEntered = int.Parse(userInput);

        //Using switch for users to select options
        switch (amountEntered)
        {
            case 1:
                Withdraw();
                break;
            case 2:
                Transfer();
                break;
            case 3:
                Deposit();
                break;
            case 4:
                Balance();
                break;
            case 5:
                Console.WriteLine("Thank you for using the ATM machine. Goodbye!");
                choice = false;
                break;
            default:
                Console.WriteLine(" You should select between 1 and 5.");
                break;
        }

     // User gets asked if they want to exit...
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }

}
*/

//Second implementation using do-while loop
do
{
    Console.WriteLine($"Welcome John Doe. Your Account Balance is: ${accountBalance:N2}");
    Console.WriteLine("Press 1 to Withdraw.");
    Console.WriteLine("Press 2 to Transfer.");
    Console.WriteLine("Press 3 to Deposit.");
    Console.WriteLine("Press 4 to Check Balance.");
    Console.WriteLine("Press 5 to Exit.");

    //Prompts user for input
    string userInput = Console.ReadLine();

    //Check if user's input is valid
    bool numberChecker = int.TryParse(userInput, out int amount);

    if (numberChecker == true)
    {
        amountEntered = int.Parse(userInput);

        //Using switch for users to select options
        
        switch (amountEntered)
        {
            case 1:
                Withdraw();
                break;
            case 2:
                Transfer();
                break;
            case 3:
                Deposit();
                break;
            case 4:
                Balance();
                break;
            case 5:
                Console.WriteLine("Thank you for using the ATM machine. Goodbye!");
                choice = false;
                break;
            default:
                Console.WriteLine(" You should select between 1 and 5.");
                break;
        }

        // User gets asked if they want to exit...
    }
    else
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
} while (choice);

