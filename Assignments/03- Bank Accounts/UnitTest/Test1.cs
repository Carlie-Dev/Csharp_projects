using _03__Bank_Accounts;
using System.Runtime.CompilerServices;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UnitTest
{
    [TestClass]
    public sealed class Test1
    {
        //created objects
        private Checking _checking;
        private Saving _saving;
        private Transaction _transaction0;
        private Transaction _transaction1;
        private Transaction _transaction2;

        [TestInitialize]
        public void Setup()
        {
            _checking = new Checking()
            {
                accountNumber = "001",
                balance = 100,
                holderFirstName = "Test",
                holderLastName = "Test",
                transactions = new List<Transaction>()
            };

            _saving = new Saving()
            {
                accountNumber = "002",
                balance = 500,
                holderFirstName = "Test",
                holderLastName = "Test",
                transactions = new List<Transaction>(),
                InterestRate = .02
            };

            _transaction0 = new Transaction()
            {
                Credit = true,
                Amount = 100,
                Description = "Test",
                Date = DateTime.Today
            };

            _transaction1 = new Transaction()
            {
                Credit = false,
                Amount = 50,
                Description = "Test",
                Date = DateTime.Today
            };

            _transaction2 = new Transaction()
            {
                Credit = false,
                Amount = 1000,
                Description = "Test",
                Date = DateTime.Today
            };
        }

        [TestMethod]
        public void AddtoChecking()
        {
            //tests if checking balance is added to?
            _checking.AddTransaction(_transaction0);
            Assert.AreEqual(200, _checking.balance);
        }

        [TestMethod]
        public void OverDrawnChecking()
        {
            _checking.AddTransaction(_transaction2);
            Assert.AreEqual(-910, _checking.balance);
        }

        [TestMethod]
        public void AddToSavings()
        {
            _saving.AddTransaction(_transaction0);
            Assert.AreEqual(600,_saving.balance);
        }
        [TestMethod]
        public void SubtractFromSavings()
        {
            _saving.AddTransaction(_transaction1);
            Assert.AreEqual(450, _saving.balance);
        }

        [TestMethod]
        public void SubtractFromChecking()
        {
            _checking.AddTransaction(_transaction1);
            Assert.AreEqual(50, _checking.balance);
        }

        [TestMethod]
        public void IncurInterest()
        {
            _saving.AddInterest();

            //fixed delta issue
            Assert.AreEqual(500.83, _saving.balance,0.01);

        }
            
        }
    }

