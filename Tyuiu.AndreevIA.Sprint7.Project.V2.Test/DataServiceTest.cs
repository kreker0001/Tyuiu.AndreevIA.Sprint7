using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.AndreevIA.Sprint7.Project.V2.Lib;
namespace Tyuiu.AndreevIA.Sprint7.Project.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void LoadFromFileData()
        {
            string path = @"""""C:\Progects\Tyuiu.AndreevIA.Sprint7\Tyuiu.AndreevIA.Sprint7.Project.V2\DataBase.csv""""";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }


}