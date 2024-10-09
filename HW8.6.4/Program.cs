namespace HW8._6._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь к файлу");
            string path = Console.ReadLine();
            string writeDirectory = @"C:\Users\ogisl\OneDrive\Desktop\Students";
            if (!Directory.Exists(writeDirectory))
            {
                Directory.CreateDirectory(writeDirectory);
            }
            ReadData.Values(path, writeDirectory);
        }
    }
}
