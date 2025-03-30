    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;
    using BankAccountNS;

    namespace BankTests2
    {
        [TestClass]
        public class BankAccountTests2
        {
            [TestMethod]
            [ExpectedException(typeof(ArgumentOutOfRangeException))]
            public void Credit_WhenAmountIsLessThanZero_ShouldThrowArgumentOutOfRange()
            {
                // Arrange
                double beginningBalance = 11.99;
                double creditAmount = -100.00;
                BankAccount account = new BankAccount("Mr. Roman Abramovich", beginningBalance);

                // Act
                account.Credit(creditAmount);
            }

            [TestMethod]
            public void Credit_WhenAmountIsPositive_ShouldIncreaseBalance()
            {
                // Arrange
                double beginningBalance = 11.99;
                double creditAmount = 20.0;
                double expectedBalance = beginningBalance + creditAmount;
                BankAccount account = new BankAccount("Mr. Bryan Walton", beginningBalance);

                // Act
                account.Credit(creditAmount);

                // Assert
                Assert.AreEqual(expectedBalance, account.Balance, 0.01, "Balance was not updated correctly.");
            }
        }
    }
