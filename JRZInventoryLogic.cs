using System;
using System.IO;

namespace WOI
{
    public class JRZInventoryLogic
    {
        public void ImporterJRZInventoryLogic()
        {
            string DirectoryPath = @"C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\SAP\SAP GUI\";
            string FileNames = "JRZInventory";
            string Extention = ".txt";
            string RenameFileDate = DateTime.Now.ToString("MMddyyyyHHmmss");

            using (_databaseContext dbContext = new _databaseContext())
            {
                if (File.Exists(DirectoryPath + FileNames + Extention))
                {
                    string[] JRZInventoryLines = File.ReadAllLines(DirectoryPath + FileNames + Extention);

                    foreach (var item in JRZInventoryLines)
                    {
                        int position = Array.LastIndexOf(JRZInventoryLines, item);

                        if (position > 2)
                        {
                            // Splitting each line in objects
                            var JRZInvFile = item.Split('|');
                            if (JRZInvFile.Length > 1)
                            {
                                JRZInventory newJRZInv = new JRZInventory();
                                newJRZInv.Material = JRZInvFile[1];
                                newJRZInv.Plnt = JRZInvFile[2];
                                newJRZInv.Batch = JRZInvFile[3];
                                newJRZInv.MaterialDescription = JRZInvFile[4];
                                newJRZInv.Typ = JRZInvFile[5];
                                newJRZInv.StorageBin = JRZInvFile[6];
                                newJRZInv.BUn = JRZInvFile[7];
                                newJRZInv.TotalStock = JRZInvFile[8];
                                newJRZInv.GRDate = JRZInvFile[9];

                                // Adding each record to the intance
                                dbContext.JRZInventories.Add(newJRZInv);
                            }
                        }
                    }

                    // Transactio to Sql Server
                    dbContext.SaveChanges();
                    // Rename the file.
                    File.Move(DirectoryPath + FileNames + Extention, DirectoryPath + FileNames + RenameFileDate + Extention);
                }
            }


        }
    }
}