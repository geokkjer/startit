namespace BankAppMarie
{
    public class Bank
    {
        Customer _currentCustomer;

        public Bank()
        {
            _currentCustomer = new Customer("Kåre Knutsen");
            BankMenu();
        }
        void BankMenu()
        {
            var isRunning = true;
            while (isRunning)
            {
                Console.WriteLine($"Welcome to the Bank app, {_currentCustomer.GetCustomerName()}!");
                Console.WriteLine("1. Deposit Money");
                Console.WriteLine("2. Withdraw Money");
                Console.WriteLine("3. Pay Bill");
                Console.WriteLine("4. Transfer Money to savings");
                Console.WriteLine("5. Check account balance");
                Console.WriteLine("6. Exit");

                var userInput = Console.ReadLine();
                int userInputInt;

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Enter amount of money to deposit: ");
                        userInputInt = Convert.ToInt32(Console.ReadLine());
                        _currentCustomer.DepositToSavingsAccount(userInputInt);
                        Console.Clear();
                        break;
                    case "2":
                        Console.WriteLine("Enter amount of money to withdraw: ");
                        userInputInt = Convert.ToInt32(Console.ReadLine());
                        _currentCustomer.WithdrawMoney(userInputInt, true);
                        break;
                    case "3":
                        break;
                    case "4":
                        break;
                    case "5":
                        var accountBalance = _currentCustomer.GetAccountBalance();
                        Console.WriteLine($"{accountBalance}");
                        break;
                    case "6":
                        isRunning = false;
                        break;
                }
            }
        }
    }
}