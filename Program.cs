using System;

namespace WOI
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instance of WorkOrder
            WorkOrderLogic WOILogic = new WorkOrderLogic();
            WOILogic.ImportWorkOrderLogic();

            // Intance of JrzInv
            JRZInventoryLogic JrzInvLogic = new JRZInventoryLogic();
            JrzInvLogic.ImporterJRZInventoryLogic();

            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
}
