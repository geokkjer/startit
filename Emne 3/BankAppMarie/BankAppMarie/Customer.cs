namespace BankAppMarie
{
    internal class Customer
    {
        string _customerName;
        string _socialSecurityNumber;
        Account _savingsAccount;
        Account _currentAccount;

        public Customer(string customerName)
        {
            _customerName = customerName;
            _savingsAccount = new Account(true, "Savings");
            _currentAccount = new Account(false, "Brukskonto");   
        }
            

        public string GetCustomerName()
        {
            return _customerName;
        }

        public void DepositToSavingsAccount(int amount)
        {
            _savingsAccount.DepositMoney(amount);
        }

        public void WithdrawMoney(int amount, bool fromSavingsAccount)
        {
            if (fromSavingsAccount)
            {
                _savingsAccount.Withdraw(amount);
            }
            else
            {
                _currentAccount.Withdraw(amount);
            }
        }

        public int GetAccountBalance()
        {
            return _currentAccount.GetAccountBalance();
        }
       
    }
}