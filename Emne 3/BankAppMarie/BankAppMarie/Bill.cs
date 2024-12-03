using System.Security.Cryptography;

namespace BankAppMarie
{
    public class Bill
    {
        public int Amount { get; private set; }
        public string AccountNumber { get; set; }
        public string Sender { get; set; }
        public string KidNr { get; set; }
        public int Id { get; set; }
        public DateTime PayDate { get; set; }

        public Bill(int billAmount, string billNumber, DateTime timeToPay, int id)
        {
            Amount = billAmount;
            KidNr = billNumber;
            PayDate = timeToPay;
            Id = id;

        }
    }
    
    
}
