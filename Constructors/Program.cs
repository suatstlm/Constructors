using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(15);
            //customerManager.Add();

            EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
            employeeManager.Add();
        }
    }

    class CustomerManager
    {
        private int _count;
        public CustomerManager(int count)
        {
            _count = count;
        }
        public void Add()
        {
            Console.WriteLine("Added {0}",_count);
        }
    }

    interface ILogger
    {
        void Log();
    }
    class FileLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
    class EmailLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Email'e loglandı");
        }
    }

    class EmployeeManager
    {
        ILogger _logger;
        public EmployeeManager(ILogger logger)
        {
            _logger = logger;
        }
        public void Add()
        {
            _logger.Log();
            Console.WriteLine("Added!");
        }
    }
}
