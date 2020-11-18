using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestExample.Controllers;
using UnitTestExample.Abstractions;
using UnitTestExample.Test;


namespace UnitTestExample.Test
{
    public class AccountControllerTestFixure
    {
        public AccountControllerTestFixure()
        {
            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
        
        [Test]
        public void TestValidateEmail(string email, bool expectedResult)
        {
          
            //,,,

        }



    }
}
