using System;

namespace WOI
{
    class Program
    {
        static void Main(string[] args)
        {
            WorkOrderLogic WOILogic = new WorkOrderLogic();
            WOILogic.ImportWorkOrderLogic();
            Console.WriteLine("Hello World!");
        }
    }
}
