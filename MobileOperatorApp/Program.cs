using MobileOperatorApp.Models;

// Создание объекта базового класса
MobileOperator basicOperator = new MobileOperator("BasicOperator", 2.5, 1000);
Console.WriteLine(basicOperator + "\n");

// Создание объектов класса-потомка
MobileOperatorWithConnectionFee premiumOperatorWithFee = new MobileOperatorWithConnectionFee("PremiumOperator", 2.5, 1000, true);
Console.WriteLine(premiumOperatorWithFee + "\n");

MobileOperatorWithConnectionFee premiumOperatorWithoutFee = new MobileOperatorWithConnectionFee("PremiumOperator", 2.5, 1000, false);
Console.WriteLine(premiumOperatorWithoutFee);
