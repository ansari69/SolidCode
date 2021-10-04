using System;

namespace SingleResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomersRepository customersRepository = new CustomersRepository();

            customersRepository.Add();

           // Console.WriteLine("Hello World!");
        }
    }



    public class FileLogger
    {
        public void Log(string content)
        {
            System.IO.File.WriteAllText("d:\\errors.txt", content);
        }
    }

    public class CustomersRepository
    {
        FileLogger logger = new FileLogger();

        public void Add()
        {
            try
            {
                // add customer to database
                Console.WriteLine("Hello World!");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                logger.Log(ex.ToString());
            }
        }
    }
}
