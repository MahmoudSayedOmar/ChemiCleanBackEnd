using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;

namespace CROSSWORKERS.CHEMICLEAN.Utilities.Utilities
{
    public static class SafetyDataSheetsManager
    {

        public static bool UpdateSafetyDataSheet(string Url, string UserName, string Password)
        {

            if (Url==null)
            {
                return false;
            }

            using (var client = new WebClient())
            {

                if (UserName != null && Password != null)
                {
                    client.Credentials = new NetworkCredential(UserName, Password);
                }

                var fileName = Url.Split('/').Last();
                byte[] LocalFile = FileToByteArray(fileName);

                byte[] ServerFile;
                try
                {
                    ServerFile = client.DownloadData(Url);
                }
                catch (Exception)
                {

                    ServerFile = null;
                }

                bool _update = Update(LocalFile, ServerFile);

                if (_update == true)
                {
                    try
                    {
                        File.WriteAllBytes(@"C:\Users\mahmoud.omar\source\repos\CROSSWORKERS.CHEMICLEAN\CROSSWORKERS.CHEMICLEAN.Service\wwwroot\safetydatasheets\" + fileName, ServerFile);
                    }
                    catch (Exception)
                    {

                    }

                }
                return _update;
            }
        }
        public static byte[] FileToByteArray(string fileName)
        {

            if (File.Exists(@"C:\Users\mahmoud.omar\source\repos\CROSSWORKERS.CHEMICLEAN\CROSSWORKERS.CHEMICLEAN.Service\wwwroot\safetydatasheets\" + fileName))
            {
                return File.ReadAllBytes(@"C:\Users\mahmoud.omar\source\repos\CROSSWORKERS.CHEMICLEAN\CROSSWORKERS.CHEMICLEAN.Service\wwwroot\safetydatasheets\" + fileName);

            }
            else
            {
                return null;
            }
        }
        public static bool Update(byte[] LocalFile, byte[] ServerFile)
        {
            if (LocalFile == null && ServerFile != null)
            {

                return true;
            }
            else if (LocalFile != null && ServerFile != null)
            {
                return !(((IStructuralEquatable)LocalFile).Equals(ServerFile, StructuralComparisons.StructuralEqualityComparer));

            }


            return false;


        }
    }
}
