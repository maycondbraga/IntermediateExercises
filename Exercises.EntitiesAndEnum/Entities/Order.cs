using System;
using Exercises.EntitiesAndEnum.Entities.Enums;

namespace Exercises.EntitiesAndEnum.Entities
{
    class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return $"\nOrder \nId: {Id} \nMoment: {Moment} \nStatus: {Status}";
        }
    }
}
