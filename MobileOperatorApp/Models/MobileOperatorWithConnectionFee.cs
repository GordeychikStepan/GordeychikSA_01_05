using System;
namespace MobileOperatorApp.Models
{
    // Класс-потомок "Оператор с платой за соединение"
    public class MobileOperatorWithConnectionFee : MobileOperator
    {
        public bool HasConnectionFee { get; set; }

        // Конструктор класса
        public MobileOperatorWithConnectionFee(string operatorName, double costPerMinute, double coverageArea, bool hasConnectionFee)
            : base(operatorName, costPerMinute, coverageArea)
        {
            HasConnectionFee = hasConnectionFee;
        }

        // Переопределенная функция качества объекта класса-потомка
        public override double Quality()
        {
            double baseQuality = base.Quality();

            return HasConnectionFee ? 0.7 * baseQuality : 1.5 * baseQuality;
        }

        // Вывод информации об объекте
        public override string ToString()
        {
            return $"Оператор: {OperatorName},\n" +
                $"Стоимость за минуту: {CostPerMinute},\n" +
                $"Площадь покрытия: {CoverageArea},\n" +
                $"Качество: {Quality()},\n" +
                $"Наличие платы за каждое соединение: {(HasConnectionFee ? "Да" : "Нет")}";
        }
    }
}
