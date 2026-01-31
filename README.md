Debt Repayment Calculator

A simple console-based application that calculates and displays a month-by-month breakdown of debt repayment, including interest charges and remaining balance.
Overview
This C# application helps users understand how long it will take to pay off their debt and how much interest they'll pay over time. It uses a compound interest calculation based on a fixed effective annual rate and displays the repayment schedule in South African Rand (ZAR).
Features

Monthly Interest Calculation: Automatically calculates monthly interest based on an effective annual rate of 20.75%
Payment Schedule: Displays a detailed month-by-month breakdown showing:

Total amount due each month
Interest charged
Remaining balance after payment


Currency Formatting: Displays all amounts in South African Rand (ZAR) format
Loop Until Payoff: Continues calculations until the debt is fully paid (balance < R1.00)

How It Works
The application uses the following calculation logic:

Takes user input for total debt amount
Takes user input for monthly payment amount
Calculates monthly interest using the formula: (effectiveRate / 100) / 12
For each month:

Calculates interest on current balance
Applies monthly payment
Updates remaining balance
Displays all relevant information



Formula:

Monthly Interest Rate = (20.75% / 100) / 12 = 0.01729%
Interest Charged = Current Debt × Monthly Interest Rate
New Balance = Current Debt + Interest Charged - Monthly Payment

Prerequisites

.NET SDK (version 6.0 or higher recommended)
A C# compatible IDE or text editor (Visual Studio, VS Code, Rider, etc.)

Important Notes

⚠️ Minimum Payment Required: Ensure your monthly payment is greater than the monthly interest charge, otherwise the debt will never be paid off
The calculation stops when the balance falls below R1.00
All currency values are displayed in South African Rand (ZAR) format

Future Enhancements
Potential improvements for this application:

Allow user to input custom interest rate
Add input validation for negative numbers or invalid entries
Display total interest paid and total time to pay off debt
Export results to CSV or text file
Add option to make extra payments in specific months
Create a GUI version
Add comparison between different payment scenarios

Contributing
Contributions are welcome! Please feel free to submit a Pull Request.
License
This project is open source and available under the MIT License.
Author
Your Name - Your GitHub Profile
Acknowledgments

Built with C# and .NET
Uses South African Rand (ZAR) currency formatting

