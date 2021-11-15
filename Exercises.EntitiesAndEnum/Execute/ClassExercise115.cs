using System;
using Exercises.Compositions.Enum;

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
            if (System.Enum.TryParse(status, out OrderStatus orderStatus))
            {
                Console.WriteLine($"\nStatus {orderStatus} exist");
            }
            else
            {
                Console.WriteLine($"\nStatus {status} is not found");
            }
        }
    }
}
