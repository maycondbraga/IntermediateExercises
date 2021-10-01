using System;
using Exercises.Compositions.Entities.Enums;

namespace Exercises.Compositions.Execute
{
    public class ClassExercise115
    {
        /// <summary>
        /// Return true case status exist in Enumerador, or false, case status don't exist
        /// </summary>
        /// <param name="status"></param>
        public static void CheckStatus(string status)
        {
            if (Enum.TryParse<OrderStatus>(status, out OrderStatus orderStatus))
            {
                Console.WriteLine($"\nStatus {status} exist");
            }
            else
            {
                Console.WriteLine($"\nStatus {status} is not found");
            }
        }
    }
}
