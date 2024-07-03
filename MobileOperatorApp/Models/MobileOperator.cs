using System;

namespace MobileOperatorApp.Models
{
    // Базовый класс "Оператор мобильной связи"
    public class MobileOperator
    {
        public string OperatorName { get; set; }
        public double CostPerMinute { get; set; }
        public double CoverageArea { get; set; }

        // Конструктор класса
        public MobileOperator(string operatorName, double costPerMinute, double coverageArea)
        {
            OperatorName = operatorName;
            CostPerMinute = costPerMinute;
            CoverageArea = coverageArea;
        }

        // Функция, которая определяет качество объекта
        public virtual double Quality()
        {
            return 100 * CoverageArea / CostPerMinute;
        }


        // Вывод информации об объекте
        public override string ToString()
        {
            return $"Оператор: {OperatorName},\n" +
                $"Стоимость за минуту: {CostPerMinute},\n" +
                $"Площадь покрытия: {CoverageArea},\n" +
                $"Качество: {Quality()}";
        }
    }
}
