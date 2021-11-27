using Exercises.Files.Entities;
using System;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Exercises.Files.Execute
{
    public class ClassExercise189
    {
        public void CsvConverter()
        {
            try
            {
                Console.Write("Enter file full path: ");
                string sourceFilePath = Console.ReadLine(); //@"C:\Users\Maycon\source\repos\IntermediateExercises\Exercises.Files\UsedFiles";

                FileInfo[] files = new DirectoryInfo(sourceFilePath).GetFiles("*.csv");

                string targetFilePath = sourceFilePath + @"\out\summary.csv";

                foreach (var file in files)
                {
                    using (StreamWriter sw = File.AppendText(targetFilePath))
                    {
                        var lines = File.ReadAllLines(file.FullName);

                        lines.ToList().ForEach(x =>
                        {
                            var fields = x.Split(',');

                            Product product = new Product(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture), int.Parse(fields[2]));

                            sw.WriteLine(product.Name + "," + product.Total().ToString("F2", CultureInfo.InvariantCulture));
                        });
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}
