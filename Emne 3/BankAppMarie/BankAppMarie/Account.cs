namespace BankAppMarie
{ 
    public class Account
    {
        private int _balance;
        string _accountName;
        bool _savingsAccount;
        string _accountNumber;
        List<string> _accountTransactions;

        public void DepositMoney(int amountToDeposit)
        {
            _balance += amountToDeposit;
        }

        public void Withdraw(int amountToWithdraw)
        {
            if (_balance >= amountToWithdraw)
            {
                _balance -= amountToWithdraw;
            }
            else
            { 
                Console.WriteLine("Insufficient balance");
            }
        }

        public Account(bool isSavingsAccount,string accountName)
        {
            _savingsAccount = isSavingsAccount;
            _accountName = accountName;
        }

         public int GetAccountBalance()
         {
             return _balance;
         }
    }
}