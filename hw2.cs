using System;

namespace ConsoleApplication
{
    public class Program
    {
        

        public static void Main(string[] args)
        {
            
            
           int userInput = 0;

           do
           {
               userInput = DisplayMenu();

               int caseswitch = userInput;

                switch (caseswitch)
                {
                    case 1: 
                    CreateAccount();
                    break;
                    case 2:
                    RemoveAccount();
                    break;
                    case 3:
                    AddFunds();
                    break;
                    case 4:
                    WithdrawFunds();
                    break;
                    case 5:
                    ViewDetails();
                    break;
                    case 6:
                    ViewBankBalance();
                    break;
                    default:

                    break;
                }

           }
           while(userInput != 7);
           
        }//END OF Main
        static public int AccountNumber = 1;

                public static Account account1 = new Account();
                public static Account account2 = new Account();
                public static Account account3 = new Account();
                public static Account account4 = new Account();
                public static Account account5 = new Account();
                public static Account account6 = new Account();
                public static Account account7 = new Account();
                public static Account account8 = new Account();
                public static Account account9 = new Account();
                public static Account account10 = new Account();
                public static Account account11 = new Account();
                public static Account account12 = new Account();
                public static Account account13 = new Account();
                public static Account account14 = new Account();
                public static Account account15 = new Account();
                public static Account account16 = new Account();
                public static Account account17 = new Account();
                public static Account account18 = new Account();
                public static Account account19 = new Account();
                public static Account account20 = new Account();
                public static Account account21 = new Account();
                public static Account account22 = new Account();
                public static Account account23 = new Account();
                public static Account account24 = new Account();
                public static Account account25 = new Account();

                 public static Account[] accounts = {account1, account2, account3, account4, account5,
                 account6,
                 account7,
                 account8,
                 account9,
                 account10,
                 account11,
                 account12,
                 account13,
                 account14,
                 account15,
                 account16,
                 account17,
                 account18,
               account19,
               account20,
                account21,
                 account22,
                 account23,
                 account24,
                 account25};

        //function for menu
        public static int DisplayMenu()
        {
              
            Console.WriteLine("Welcome to MDC Bank. Please choose an option.\n");
            Console.WriteLine("1. Create a new account.");
            Console.WriteLine("2. Remove an account.");
            Console.WriteLine("3. Add money to an account.");
            Console.WriteLine("4. Withdraw money from an account.");
            Console.WriteLine("5. View details of an account.");
            Console.WriteLine("6. View total bank funds.");
            Console.WriteLine("7. Exit.");

            var result = Console.ReadLine();
            return Convert.ToInt32(result);
            
        }

        //function to create a new account
        
        public static void CreateAccount()
        {
            //first get the account number
            string yes = "Yes";
            string no = "No";
            var response;
            int compare = 0;

            Console.WriteLine("Create Account Number " + AccountNumber + "? Yes/No");
            response = Console.ReadLine();
            
            if(compare(yes, response bool ignoreCase) == 1)
            {

            }

            if(Compai)

            public static string mmm;
            int chc = 0;
            int subtraction = 0;
            string ggg;

            if(mmm == "Yes")
            {

            }

            do
            {
                 Console.WriteLine("Please choose the account to withdraw funds from.");

                 mmm = Console.ReadLine();

                 chc = Convert.ToInt32(mmm); 
            }
            while( (chc < 1) || (chc > 25 ) );

                Console.WriteLine("What is customer name?");  
                accounts[AccountNumber].CustomerName = Console.ReadLine(); 
                Console.WriteLine("What is the starting balance?");
                string startbalance = Console.ReadLine();
                int srtbalance = Convert.ToInt32(startbalance);

                accounts[AccountNumber].AccountBalance = srtbalance; 
                accounts[AccountNumber].AccountStatus = "Active";

                 //If youre not setting to either a savings or checking account, keep asking?
                    bool x = true;
                    while (x)
                    {
                        Console.WriteLine("Please choose the account type. 1 for Checking or 2 for Savings");
                        var type = Console.ReadLine();
                        int choice = Convert.ToInt32(type);

                            if(choice == 1)
                            {
                                accounts[AccountNumber].AccountType = "Checking";
                                x = false;
                            }
                            else if(choice == 2)
                            {
                                accounts[AccountNumber].AccountType = "Savings";
                                accounts[AccountNumber].InterestRate = 1.5;
                                x = false;
                            }
                    } //end of while loop
            
                 AccountNumber++;  
                 return;      
        }//end of CreateAccount
            
        //function to remove an account
        static public void RemoveAccount()
        {
            string mmm;
            int chc = 0;

            do
            {
                 Console.WriteLine("Please choose the account to deactivate.");

                 mmm = Console.ReadLine();

                 chc = Convert.ToInt32(mmm); 
            }
            while( (chc < 1) || (chc > 25 ) );

                //clear all values

                Account x = accounts[chc];
                x.AccountStatus = "Inactive";
                x.AccountBalance = 0;
                x.CustomerName = "";
                x.AccountType = "";
                x.InterestRate = 0;

            return;

        }//end of RemoveAccount

        //function to add money to an account
        public static void AddFunds()
        {
            
            string mmm;
            int chc = 0;
            int addition = 0;
            string ggg;

            do
            {
                 Console.WriteLine("Please choose the account to add funds.");

                 mmm = Console.ReadLine();

                 chc = Convert.ToInt32(mmm); 
            }
            while( (chc < 1) || (chc > 25 ) );

            Console.WriteLine("Deposit $____?");
            ggg = Console.ReadLine();
            addition = Convert.ToInt32(ggg);

            Account x = accounts[chc];
            Console.WriteLine("Old Account Balance: $" + x.AccountBalance + "\n");
            x.AccountBalance+= addition;
            Console.WriteLine("New Account Balance is: $" + x.AccountBalance + "\n");
            return;

        }
                

        //function to withdraw money from an account
        public static void WithdrawFunds()
        {
            string mmm;
            int chc = 0;
            int subtraction = 0;
            string ggg;

            do
            {
                 Console.WriteLine("Please choose the account to withdraw funds from.");

                 mmm = Console.ReadLine();

                 chc = Convert.ToInt32(mmm); 
            }
            while( (chc < 1) || (chc > 25 ) );

            Console.WriteLine("Withdraw $____?");
            ggg = Console.ReadLine();
            subtraction = Convert.ToInt32(ggg);

            Account x = accounts[chc];
            Console.WriteLine("Old Account Balance: $" + x.AccountBalance + "\n");
            x.AccountBalance-= subtraction;
            Console.WriteLine("New Account Balance is: $" + x.AccountBalance + "\n");
            return;



        }

        //function to view account details of any account
        public static void ViewDetails()
        {
            string yyy;
            int zzz = 0;
             do 
            {
               Console.WriteLine("Please choose the account to display.");
                yyy = Console.ReadLine();
                zzz = Convert.ToInt32(yyy);
            }
            while ( (zzz < 1) || (zzz > 25 ) );

               Console.WriteLine("Customer Name: " + accounts[zzz].CustomerName + "\n");
               Console.WriteLine("Account Balance: " +accounts[zzz].AccountBalance + "\n");
               Console.WriteLine("Account Status: " +accounts[zzz].AccountStatus + "\n");
               Console.WriteLine("Account Type: " +accounts[zzz].AccountType + "\n");
               Console.WriteLine("Interest Rate: " +accounts[zzz].InterestRate + "\n");

            return;
        }

        //function to view total money in all bank accounts
        public static void ViewBankBalance()
        {
            int totalBalance = 0;

            foreach(Account x in accounts)
            {
                totalBalance+=x.AccountBalance;

            }
            Console.WriteLine("Funds in all accounts total: $" + totalBalance + "\n");
        }









        //Account class
         public class Account
            {
                public int AccountBalance {get; set;}
                public string CustomerName {get; set;}
                public string AccountType {get; set;}
                public double InterestRate {get; set;}

                public string AccountStatus {get; set;}

                // //constructor takes arguments and assigns property values
                // public Account(string type, int balance)
                // {
                //     public int AccountID = 0;

                //     AccountType = type;
                    
                //     StartingBalance = balance;

                   
                // }//end of constructor

                 
                       
                        

                

                }//end of Account class

    }}


