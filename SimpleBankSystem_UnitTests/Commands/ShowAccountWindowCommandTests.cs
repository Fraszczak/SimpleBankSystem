﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleBankSystem.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBankSystem.Commands.Tests
{
    [TestClass()]
    public class ShowAccountWindowCommandTests
    {
        [TestMethod()]
        public void CanExecuteTest_CanExecute_ReturnTrue()
        {
            var value = new ShowAccountWindowCommand();

            var result = value.CanExecute(value);

            Assert.IsTrue(result);
        }

        [TestMethod()]
        public void ExecuteTest()
        {
     
        }
    }
}