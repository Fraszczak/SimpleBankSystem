using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleBankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Tests
{
    [TestClass()]
    public class BackToCommandTests
    {
        [TestMethod()]
        public void CanExecuteTest_CanExecute_ReturnTrue()
        {
            var value = new BackToCommand();

            var result = value.CanExecute(value);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ExecuteTest_CanExecute_ReturnTrue()
        {
            
        }
    }
}