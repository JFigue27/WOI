using System;
using System.IO;
using System.Linq;

namespace WOI
{
    public class ELPInvLogic
    {
        public void ImporterElPInvLogic()
        {

            string DirectoryPath = @"C:\Users\jjfigueroa\OneDrive - kochind.com\Documents\SAP\SAP GUI\";
            string FileNames = "ELPInv";
            string Extention = ".txt";
            string RenameFileDate = DateTime.Now.ToString("MMddyyyyHHmmss");

            using (_databaseContext dbContext = new _databaseContext())
            {
                if (File.Exists(DirectoryPath + FileNames + Extention))
                {
                    var ELPInvTable = dbContext.ELPInvs;
                    dbContext.ELPInvs.RemoveRange(ELPInvTable);
                    dbContext.SaveChanges();

                    string[] ELPInvLines = File.ReadAllLines(DirectoryPath + FileNames + Extention);

                    foreach (var item in ELPInvLines)
                    {
                        int position = Array.LastIndexOf(ELPInvLines, item);

                        if (position > 2)
                        {
                            var ELPInvFile = item.Split('|');
                            if (ELPInvFile.Length > 1)
                            {
                                ELPInv newElpInv = new ELPInv();

                                newElpInv.Material = ELPInvFile[1];
                                newElpInv.Plnt = ELPInvFile[2];
                                newElpInv.Batch = ELPInvFile[3];
                                newElpInv.MaterialDescription = ELPInvFile[4];
                                newElpInv.Typ = ELPInvFile[5];
                                newElpInv.StorageBin = ELPInvFile[6];
                                newElpInv.S = ELPInvFile[7];
                                newElpInv.BUn = ELPInvFile[8];
                                newElpInv.TotalStock = ELPInvFile[9];
                                newElpInv.GRDate = ELPInvFile[10];

                                dbContext.ELPInvs.Add(newElpInv);
                            }
                        }
                    }
                    dbContext.SaveChanges();

                    File.Move(DirectoryPath + FileNames + Extention, DirectoryPath + FileNames + RenameFileDate + Extention);
                }
            }

        }
    }
}