using _04__Budget_App;
namespace UnitTests
{
    [TestClass]
    public sealed class Test1
    {

            //test objects

            private Category _cat1;
            private Category _cat2;
            private Expense _exp1;
            private Expense _exp2;
            private Expense _exp3;

            [TestInitialize]

            public void SetUp()
            {
                //setting up objects
                _cat1 = new Category()
                {
                    limit = 200,
                    description = "Groceries",
                    expenses = new List<Expense>()
                };

                _cat2 = new Category()
                {
                    limit = 150,
                    description = "Video Games",
                    expenses = new List<Expense>()
                };

                //expenses
                _exp1 = new Expense(50, "God of War");

                _exp2 = new Expense(60, "Hello Kitty Cruiser");

                _exp3 = new Expense(70, "Elder Scrolls VI");


            }

            [TestMethod]
            public void AddNewExpense()
            {
                //add the expense to category 2
                _cat2.AddExpense(_exp1);

                //calculate the length of the expenses array in _cat2
                double result = _cat2.expenses.Count();
                double test = 1;
                //see if it was added
                Assert.AreEqual(test, result);
            }

            [TestMethod]
            public void CheckTotalForCategory()
            {
                _cat1.AddExpense(_exp1);
                _cat1.AddExpense(_exp2);

                //get total of expenses
                double total = _cat1.Total();
                //double test = 110;
                Assert.AreEqual(110, total);
            }

        // Currently broken - Program not recognizing Assert.ThrowsException
            [TestMethod]
            public void OverbugetException()
            {
                //arrange
                _cat2.AddExpense(_exp1);
                _cat2.AddExpense(_exp2);

                //Act

                Assert.Throws<OverBudgetException>(() => _cat2.AddExpense(_exp3));
            }

        }
    }
