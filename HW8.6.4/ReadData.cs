using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace HW8._6._4
{
    static class ReadData
    {
        public static void Values(string path, string writedir)
        {
            if (File.Exists(path))
            {
                BinaryReader binRead = new BinaryReader(File.Open(path, FileMode.Open));
                using (var fileStream = new FileStream(path, FileMode.OpenOrCreate))
                {
                    Student students = new Student(); ;
                    Console.WriteLine($"Данные считаны из {path}");
                    foreach (var student in students)
                    {
                        string groupFile = writedir + "/" + student.Group + ".txt";
                        using (FileStream fs = new FileStream(groupFile, FileMode.Append))
                        {
                            using (StreamWriter sw = new StreamWriter(fs))
                                sw.WriteLine($"{student.Name}, {student.BirthDate}");
                        }
                    }
                }

                Console.WriteLine("Данные отсортированны по названию групп");
            }
            else
            {
                Console.WriteLine("File not found");
            }
        }
    }
}
