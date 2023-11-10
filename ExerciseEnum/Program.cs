using System;
using ExerciseEnum.Entities;
using ExerciseEnum.Entities.Enum;
namespace ExerciseEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            Order order = new Order {
                Id = 198,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}