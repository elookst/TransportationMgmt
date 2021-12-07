using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void adminCreateIntNormal()
        {
            int expected = 1;
            var myAdmin = new Admin(); 
            //Admin myAdmin = Admin();
            int actual = myAdmin.AdminInt(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminReadIntNormal()
        {
            int expected = 1;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            int actual = myAdmin.AdminInt(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminUpdateIntNormal()
        {
            int expected = 1;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            int actual = myAdmin.AdminInt(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminDeleteIntNormal()
        {
            int expected = 1;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            int actual = myAdmin.AdminInt(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuyerIntNormal()
        {
            int expected = 1;
            var myBuyer = new Buyer();
            //Buyer myBuyer = Buyer();
            int actual = myBuyer.BuyerInt(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlannerIntNormal()
        {
            int expected = 1;
            var myPlanner = new Planner();
            //Planner myPlanner = Planner();
            int actual = myPlanner.PlannerInt(1, 1);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminCreateDoubleNormal()
        {
            double expected = 1.00;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            double actual = myAdmin.AdminDouble(1.00, 1.00);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminReadDoubleNormal()
        {
            double expected = 1.00;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            double actual = myAdmin.AdminDouble(1.00, 1.00);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminUpdateDoubleNormal()
        {
            double expected = 1.00;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            double actual = myAdmin.AdminDouble(1.00, 1.00);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminDeleteDoubleNormal()
        {
            double expected = 1.00;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            double actual = myAdmin.AdminDouble(1.00, 1.00);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuyerDoubleNormal()
        {
            double expected = 1.00;
            var myBuyer = new Buyer();
            //Buyer myBuyer = Buyer();
            double actual = myBuyer.BuyerDouble(1.00, 1.00);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlannerDoubleNormal()
        {
            double expected = 1.00;
            var myPlanner = new Planner();
            //Planner myPlanner = Planner();
            double actual = myPlanner.PlannerDouble(1.00, 1.00);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminCreateStringNormal()
        {
            string expected = "test";
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            string actual = myAdmin.Adminstring("test", "test");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminReadStringNormal()
        {
            string expected = "test";
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            string actual = myAdmin.Adminstring("test", "test");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminUpdateStringNormal()
        {
            string expected = "test";
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            string actual = myAdmin.Adminstring("test", "test");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminDeleteStringNormal()
        {
            string expected = "test";
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            string actual = myAdmin.Adminstring("test", "test");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BuyerstringNormal()
        {
            string expected = "test";
            var myBuyer = new Buyer();
            //Buyer myBuyer = Buyer();
            string actual = myBuyer.Buyerstring("test", "test");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PlannerstringNormal()
        {
            string expected = "test";
            var myPlanner = new Planner();
            //Planner myPlanner = Planner();
            string actual = myPlanner.Plannerstring("test", "test");
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void adminCreateIntException()
        {
            int expected = 2;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            int actual = myAdmin.AdminInt(1, 1);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminReadIntException()
        {
            int expected = 2;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            int actual = myAdmin.AdminInt(1, 1);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminUpdateIntException()
        {
            int expected = 2;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            int actual = myAdmin.AdminInt(1, 1);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminDeleteIntException()
        {
            int expected = 2;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            int actual = myAdmin.AdminInt(1, 1);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void BuyerIntException()
        {
            int expected = 2;
            var myBuyer = new Buyer();
            //Buyer myBuyer = Buyer();
            int actual = myBuyer.BuyerInt(1, 1);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void PlannerIntException()
        {
            int expected = 2;
            var myPlanner = new Planner();
            //Planner myPlanner = Planner();
            int actual = myPlanner.PlannerInt(1, 1);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminCreateDoubleException()
        {
            double expected = 2.00;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            double actual = myAdmin.AdminDouble(1.00, 1.00);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminReadDoubleException()
        {
            double expected = 2.00;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            double actual = myAdmin.AdminDouble(1.00, 1.00);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminUpdateDoubleException()
        {
            double expected = 2.00;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            double actual = myAdmin.AdminDouble(1.00, 1.00);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminDeleteDoubleException()
        {
            double expected = 2.00;
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            double actual = myAdmin.AdminDouble(1.00, 1.00);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void BuyerDoubleException()
        {
            double expected = 2.00;
            var myBuyer = new Buyer();
            //Buyer myBuyer = Buyer();
            double actual = myBuyer.BuyerDouble(1.00, 1.00);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void PlannerDoubleException()
        {
            double expected = 2.00;
            var myPlanner = new Planner();
            //Planner myPlanner = Planner();
            double actual = myPlanner.PlannerDouble(1.00, 1.00);
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminCreateStringException()
        {
            string expected = "testing";
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            string actual = myAdmin.Adminstring("test", "test");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminReadStringException()
        {
            string expected = "testing";
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            string actual = myAdmin.Adminstring("test", "test");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminUpdateStringException()
        {
            string expected = "testing";
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            string actual = myAdmin.Adminstring("test", "test");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void adminDeleteStringException()
        {
            string expected = "testing";
            var myAdmin = new Admin();
            //Admin myAdmin = Admin();
            string actual = myAdmin.Adminstring("test", "test");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void BuyerstringException()
        {
            string expected = "testing";
            var myBuyer = new Buyer();
            //Buyer myBuyer = Buyer();
            string actual = myBuyer.Buyerstring("test", "test");
            Assert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void PlannerstringException()
        {
            string expected = "testing";
            var myPlanner = new Planner();
            //Planner myPlanner = Planner();
            string actual = myPlanner.Plannerstring("test", "test");
            Assert.AreNotEqual(expected, actual);
        }
    }

    public class Admin
    {
        public int AdminInt(int userEntry, int data)
        {
            if (userEntry == data)
            {
                return userEntry;
            }
            else
            {
                return 1;
            }
        }

        public double AdminDouble(double userEntry, double data)
        {
            if (userEntry == data)
            {
                return userEntry;
            }
            else
            {
                return 1;
            }
        }

        public string Adminstring(string userEntry, string data)
        {
            if (userEntry == data)
            {
                return userEntry;
            }
            else
            {
                return null;
            }
        }
    }


    public class Buyer
    {
        public int BuyerInt(int userEntry, int data)
        {
            if (userEntry == data)
            {
                return userEntry;
            }
            else
            {
                return 1;
            }
        }

        public double BuyerDouble(double userEntry, double data)
        {
            if (userEntry == data)
            {
                return userEntry;
            }
            else
            {
                return 1;
            }
        }

        public string Buyerstring(string userEntry, string data)
        {
            if (userEntry == data)
            {
                return userEntry;
            }
            else
            {
                return null;
            }
        }
    }

    public class Planner
    {
        public int PlannerInt(int userEntry, int data)
        {
            if (userEntry == data)
            {
                return userEntry;
            }
            else
            {
                return 1;
            }
        }

        public double PlannerDouble(double userEntry, double data)
        {
            if (userEntry == data)
            {
                return userEntry;
            }
            else
            {
                return 1; 
            }
        }

        public string Plannerstring(string userEntry, string data)
        {
            if (userEntry == data)
            {
                return userEntry;
            }
            else
            {
                return null;
            }
        }
    }

}
