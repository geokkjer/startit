using System.Transactions;

namespace BankAppMarie
{
    internal class Customer
    {
        string _customerName;
        string _socialSecurityNumber;
        Account _savingsAccount;
        Account _currentAccount;
        List<Bill> _bills;

        public Customer(string customerName)
        {
            _customerName = customerName;
            _savingsAccount = new Account(true, "Savings");
            _currentAccount = new Account(false, "Brukskonto");   
            _bills = new List<Bill>();
        }
         public Customer(string customerName, bool hasBills)
         {
             _customerName = customerName;
             _savingsAccount = new Account(true, "Savings");
             _currentAccount = new Account(false, "Brukskonto");
             _bills = new List<Bill>() {
                 new Bill(2221233, "123456645744", new DateTime(2024,12,24),1), 
                 new Bill(1111133, "123124141666", new DateTime(2024,12,24),2), 
                 new Bill(2234444, "345679086667", new DateTime(2025,01,3),3)
             };
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
        public void PrintBills()
        {
            var billNr = 1;
            Console.Clear();
            foreach (Bill bill in _bills)
            {
                Console.WriteLine($"{billNr}.) KidNr: {bill.KidNr} Amount: {bill.Amount}DueDate: {bill.PayDate}");
                billNr++;
                
            }
            Console.WriteLine("Please selcet bill id:");
            var menuChoice = Convert.ToInt32(Console.ReadLine());
            
        }

        public void PayBill(int billId)
        {
            var bill = GetBill(billId);
            _currentAccount.Withdraw(bill.Amount);
            _bills.Remove(bill);
        }

        public Bill GetBill(int billId)
        {
            Bill foundBill = _bills.First(bill => bill.CustomerId == billId);
            return foundBill;
        }
    }
}