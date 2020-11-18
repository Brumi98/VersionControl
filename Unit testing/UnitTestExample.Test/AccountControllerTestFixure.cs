using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using UnitTestExample.Controllers;



namespace UnitTestExample.Test
{
    public class AccountControllerTestFixure
    {

        [
            Test,
            TestCase("ABCD1234", false),
            TestCase("Ab1234", false),
            TestCase("Abcd1234", true),
            TestCase("abcd1234", false),
            TestCase("abcdABCD", false)
        ]

        public void TestValidatePassword(string password, bool expectedResult2)
        {
            var accountController2 = new AccountController();

            var actualResult2 = accountController2.ValidatePassword(password);

            Assert.AreEqual(expectedResult2, actualResult2);

        }

        [
            Test,
            TestCase("abcd1234", false),
            TestCase("irf@uni-corvinus", false),
            TestCase("irf.uni-corvinus.hu", false),
            TestCase("irf@uni-corvinus.hu", true)

        ]

        public void TestValidateEmail(string email, bool expectedResult)
        {

            // Arrange
            var accountController = new AccountController();

            // Act
            var actualResult = accountController.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expectedResult, actualResult);


        }



    }
}
