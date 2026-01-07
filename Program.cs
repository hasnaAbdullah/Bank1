namespace Bank1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int accNumber = 1234;     
            double balance = 500;     
            double fees = 5;            

            Console.Write("Enter account number: ");
            int enteredAcc = int.Parse(Console.ReadLine());

            Console.Write("Enter amount to withdraw: ");
            double amount = double.Parse(Console.ReadLine());

           
            if (enteredAcc == accNumber)
            {
                
                if (balance >= amount + fees)
                {
                    balance = balance - (amount + fees);

                    Console.WriteLine("Withdraw successful");
                    Console.WriteLine("Amount withdrawn: " + amount);
                    Console.WriteLine("Fees: " + fees);
                    Console.WriteLine("Remaining balance: " + balance);
                }
                else
                {
                    Console.WriteLine("Sorry, insufficient balance");
                }
            }
            else
            {
                Console.WriteLine("Account not found");
            }
        }
    }


}
  
