using System;
using ExerciseEnum.Entities.Enum;

namespace ExerciseEnum.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"Id:{Id}\nMoment:{Moment}\nStatus:{Status}";
        }
    }
}
