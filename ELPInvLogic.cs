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
                }
            }

        }
    }
}