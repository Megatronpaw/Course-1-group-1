string LoanApproval(double balance)
{
    if (balance < 0)
        return "Кредит одобрен!";
    else
        return "У вас достаточно средств, кредит не нужен.";
}

double InterestCalculation1( int amountToWithdraw,double balance)
{
    double interest = amountToWithdraw * 0.05;
    double new_balance = balance - interest;
    return new_balance;
}
double InterestCalculation2(int amountToWithdraw, double balance)
{
    double interest = amountToWithdraw * 0.05;
    double bank_profit = interest;
    return bank_profit;
}
double DepositWithdrawal(int deposit, double balance)
{
    return balance - deposit;
}

double CulculateCompoundInterest(double balance, float godovaya_stavka, int years)
{
    double stavka = (1 + (godovaya_stavka / 100));
    for (int i = 1; i < years; i++)
    {
        stavka *= (1 + (godovaya_stavka / 100));
    }
    double sum = balance * stavka;
    return sum;
}
double balance = 100;
double beginBalans = 1000;
int proc = 18;
int years = 6;
balance = InterestCalculation1(50, balance);
double bank_profit = InterestCalculation2(50, balance);
Console.WriteLine($"Баланс после снятия: {balance}, прибыль банка: {bank_profit}");
balance = DepositWithdrawal(50, balance);
Console.WriteLine($"Баланс после вклада: {balance}");
string loan_status = LoanApproval(balance);
Console.WriteLine(loan_status);
double sum = CulculateCompoundInterest(beginBalans, proc, years);
Console.WriteLine($"Итоговая сумма: {Math.Round(sum, 3)}");