using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.LavrentevVA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.LavrentevVA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создангия методов тестирования методов из билиотеки
            var name = "Влад";
            var res = DataService.GetMessage(name);

            // Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет, Влад!", res);
        }
    }
}
