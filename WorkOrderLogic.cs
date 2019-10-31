using System;
using System.IO;
using System.Linq;

namespace WOI
{
    public class WorkOrderLogic
    {
        public void ImportWorkOrderLogic()
        {
            string DirectoryPath = @"C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\SAP\SAP GUI\";
            string FileNames = "CooisWorkOrders";
            string Extention = ".txt";
            string RenameFileDate = DateTime.Now.ToString("MMddyyyyHHmmss");

            using (_databaseContext dbContext = new _databaseContext())
            {

                if (File.Exists(DirectoryPath + FileNames + Extention))
                {
                    // Clean workOrder table.
                    var WO = dbContext.WorkOrders;
                    dbContext.WorkOrders.RemoveRange(WO);
                    dbContext.SaveChanges();
                    // Starting with new data from file.
                    string[] CooisLineas = File.ReadAllLines(DirectoryPath + FileNames + Extention);

                    foreach (var item in CooisLineas)
                    {
                        int position = Array.LastIndexOf(CooisLineas, item);

                        if (position > 2)
                        {

                            // Hace la separacion en objetos
                            var CooisFile = item.Split('|');
                            if (CooisFile.Length > 1)
                            {
                                // Consulta a Base de datos por WorkOrder
                                string won = CooisFile[1];
                                var Wos = dbContext.WorkOrders.FirstOrDefault(w => w.WorkOrderNumber == won);
                                //if (Wos == null) continue;

                                // Comparar si la Orden Existe...
                                if (Wos == null)
                                {
                                    if (CooisFile.Length > 1)
                                    {
                                        WorkOrder newOrder = new WorkOrder();

                                        newOrder.WorkOrderNumber = CooisFile[1];
                                        newOrder.MaterialNumber = CooisFile[2];
                                        newOrder.Seq_no_ = CooisFile[3];
                                        newOrder.Priority = CooisFile[4];
                                        newOrder.MaterialDescription = CooisFile[5];
                                        newOrder.Target_qty = CooisFile[6];
                                        newOrder.Del_qty = CooisFile[7];
                                        newOrder.Bsc_start = CooisFile[8];
                                        newOrder.Release = CooisFile[9];
                                        newOrder.MRP_ctrlr = CooisFile[10];
                                        newOrder.Order_Type = CooisFile[11];
                                        newOrder.System_Status = CooisFile[12];

                                        dbContext.WorkOrders.Add(newOrder);
                                    }
                                }
                            }
                        }
                    }
                    // Transaction to Sql Server
                    dbContext.SaveChanges();
                    // Rename the file.
                    File.Move(DirectoryPath + FileNames + Extention, DirectoryPath + FileNames + RenameFileDate + Extention);
                }
            }
        }
    }
}