using CROSSWORKERS.CHEMICLEAN.Utilities.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace CROSSWORKERS.CHEMICLEAN.UnitTest
{
   public class SafetyDataSheetsManagerTests
    {
         
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void SafetyDataSheetsManager_UpdateSafetyDataSheet_NullParameters()
        {
           var result=  SafetyDataSheetsManager.UpdateSafetyDataSheet(null,null,null);

            Assert.AreEqual(false,result);
        }
        [Test]
        public void SafetyDataSheetsManager_Update_NullLocalFile()
        {
            var result = SafetyDataSheetsManager.Update(null, new byte[0]);

            Assert.AreEqual(true, result);
        }
        [Test]
        public void SafetyDataSheetsManager_Update_NullLocalFileNullServerFile()
        {
            var result = SafetyDataSheetsManager.Update(null, null);

            Assert.AreEqual(false, result);
        }
        [Test]
        public void SafetyDataSheetsManager_FileToByteArray_NotExistedFile()
        {
            var result = SafetyDataSheetsManager.FileToByteArray("NOTAFILE");

            Assert.AreEqual(null, result);
        }
    }
}
