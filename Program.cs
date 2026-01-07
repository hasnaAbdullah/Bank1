namespace Bank1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            {
                static void Main()
                {

                    int acc1 = 1111;
                    int acc2 = 2222;

                    double balance1 = 1000;
                    double balance2 = 500;
                    double fees = 10;

                    Console.WriteLine("Welcome to the Bank");
                    Console.WriteLine("1 - Withdraw");
                    Console.WriteLine("2 - Transfer");
                    Console.Write("Choose service: ");

                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {

                        case 1:
                            Console.Write("Enter account number: ");
                            int acc = int.Parse(Console.ReadLine());

                            Console.Write("Enter amount: ");
                            double amount = double.Parse(Console.ReadLine());

                            if (acc == acc1)
                            {
                                if (balance1 >= amount + fees)
                                {
                                    balance1 -= (amount + fees);

                                    Console.WriteLine("Withdraw successful");
                                    Console.WriteLine("Remaining balance: " + balance1);
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient balance");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Account not found");
                            }
                            break;


                        case 2:
                            Console.Write("Enter sender account number: ");
                            int sender = int.Parse(Console.ReadLine());

                            Console.Write("Enter receiver account number: ");
                            int receiver = int.Parse(Console.ReadLine());

                            Console.Write("Enter amount: ");
                            double transferAmount = double.Parse(Console.ReadLine());

                            if (sender == acc1 && receiver == acc2)
                            {
                                if (balance1 >= transferAmount + fees)
                                {
                                    balance1 -= (transferAmount + fees);
                                    balance2 += transferAmount;

                                    Console.WriteLine("Transfer successful");
                                    Console.WriteLine("Sender balance: " + balance1);
                                    Console.WriteLine("Receiver balance: " + balance2);
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient sender balance");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Account not found");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid choice");
                            

                            break;
                            Console.ReadLine();
                            Console.WriteLine("Press Enter to exit...");
                            Console.ReadLine();




                    }
                }
            }
        }
    }
}
   



    


