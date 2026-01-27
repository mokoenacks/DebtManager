using System.Globalization;

float effectiveRate = 20.75f;
float totalDebt = 50000.00f; 
float monthlyPayment = 2500.00f;
float whatToPay = 0 ;
float interestCharged = 0 ;

float monthlyInterest = (effectiveRate/100)/12;
int monthlyCount = 0;

// calculations
float totalBalance = 1000000000;

while (totalBalance > 1.00)
{
        
    //What to pay
    whatToPay = (totalDebt * monthlyInterest) + monthlyPayment;
    interestCharged = totalDebt * monthlyInterest;
    // total balance
    totalBalance = totalDebt + (totalDebt * monthlyInterest) - monthlyPayment;
    totalDebt = totalBalance; 

    monthlyCount += 1;

    Console.WriteLine("Month " + monthlyCount.ToString());
    // display
    Console.WriteLine("What to pay this month: " + whatToPay.ToString("C", new CultureInfo("en-ZA")) ) ;
    Console.WriteLine("Interest charged by bank: " + interestCharged.ToString("C", new CultureInfo("en-ZA")) ) ;
    Console.WriteLine("Balance after payment: " + totalBalance.ToString("C", new CultureInfo("en-ZA")) ) ;
    Console.WriteLine("");
    

}
