using NUnit.Framework;

namespace cssarpAssignment.Tests
{
 
        [TestFixture]
        public class Tests
        {
            electricitybill obj1;
            [SetUp]
            public void Setup()
            {
                obj1 = new electricitybill();
            }


            [Test]
            public void checkUnits_customerUnit_returncharge1()
            {
                //Arrange
                double expected = 0;
                double customerUnit = -1;

                //Act
                var actual = obj1.checkUnits(customerUnit);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void checkUnits_customerUnit_returncharge2()
            {
                //Arrange
                double expected = 1.20;
                double customerUnit = 0;

                //Act
                var actual = obj1.checkUnits(customerUnit);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void checkUnits_customerUnit_returncharge3()
            {
                //Arrange
                double expected = 1.20;
                double customerUnit = 199;

                //Act
                var actual = obj1.checkUnits(customerUnit);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void checkUnits_customerUnit_returncharge4()
            {
                //Arrange
                double expected = 1.50;
                double customerUnit = 200;

                //Act
                var actual = obj1.checkUnits(customerUnit);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void checkUnits_customerUnit_returncharge5()
            {
                //Arrange
                double expected = 1.50;
                double customerUnit = 399;

                //Act
                var actual = obj1.checkUnits(customerUnit);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void checkUnits_customerUnit_returncharge6()
            {
                //Arrange
                double expected = 1.80;
                double customerUnit = 400;

                //Act
                var actual = obj1.checkUnits(customerUnit);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void checkUnits_customerUnit_returncharge7()
            {
                //Arrange
                double expected = 1.80;
                double customerUnit = 599;

                //Act
                var actual = obj1.checkUnits(customerUnit);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void checkUnits_customerUnit_returncharge8()
            {
                //Arrange
                double expected = 2.00;
                double customerUnit = 600;

                //Act
                var actual = obj1.checkUnits(customerUnit);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void checkUnits_customerUnit_returncharge9()
            {
                //Arrange
                double expected = 2.00;
                double customerUnit = 601;

                //Act
                var actual = obj1.checkUnits(customerUnit);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void calculateGramt_charge_customerUnit_gramt()
            {
                //Arrange
                double expected = 1202.00;
                double charge = 2.00;
                double customerUnit = 601;

                //Act
                var actual = obj1.calculateGramt(charge, customerUnit);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void calculateSurCharge_gramt_surcharge1()
            {
                //Arrange
                double expected = 0;
                double gramt = 399;


                //Act
                var actual = obj1.calculateSurCharge(gramt);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void calculateSurCharge_gramt_surcharge2()
            {
                //Arrange
                double expected = 0;
                double gramt = 400;


                //Act
                var actual = obj1.calculateSurCharge(gramt);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void calculateSurCharge_gramt_surcharge3()
            {
                //Arrange
                double expected = 75;
                double gramt = 500;


                //Act
                var actual = obj1.calculateSurCharge(gramt);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void calculateTotalAmount_gramt_surcharge_netamount1()
            {
                //Arrange
                double expected = 100;
                double gramt = 99;
                double surcharge = 0;


                //Act
                var actual = obj1.calculateTotalAmount(surcharge, gramt);

                //Assert
                Assert.AreEqual(expected, actual);

            }

            [Test]
            public void calculateTotalAmount_gramt_surcharge_netamount2()
            {
                //Arrange
                double expected = 101;
                double gramt = 101;
                double surcharge = 0;


                //Act
                var actual = obj1.calculateTotalAmount(surcharge, gramt);

                //Assert
                Assert.AreEqual(expected, actual);

            }



        }
    }
