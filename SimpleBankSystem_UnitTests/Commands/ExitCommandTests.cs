using NUnit.Framework;
using System.Windows;
namespace SimpleBankSystem.Commands.Tests
{
    [TestFixture]
    public class ExitCommandTests
    {

        // Do not test private methods

        [Test]
        public void CanExecuteTest_CanExecute_ReturnTrue()
        {
            var value = new ExitCommand();

            var result = value.CanExecute(value);

            Assert.That(result, Is.True);
        }

        //[Test]
        //public void ExecuteTest_CanSwapTheWindow_ReturnTrue( window, )
        //{
        //    var value = new ExitCommand();

        //    Window newWindow = null;
        //}
    }
}