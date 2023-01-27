using NunitTestRegex;

namespace UnitTest1
{
    [TestClass]
    public class Tests
    {
        UserRegistrationDetails user;
        [TestMethod]
        public void Setup()
        {
            user = new UserRegistrationDetails();
        }

        [TestMethod]
        public void FirstName()
        {
            // Arrange 
            bool expected = true;
            string name = "Shivaraj";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateFirstName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }


        [TestMethod]
        public void LastName()
        {
            // Arrange 
            bool expected = true;
            string name = "Gowda";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateLastName(name);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Email()
        {
            // Arrange 
            bool expected = true;
            string email = "4shivaraj.gowda@gmail.com";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateEmail(email);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void MobileNumber()
        {
            // Arrange 
            bool expected = true;
            string mobile = "91 8618199771";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidateMobileNumber(mobile);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Password()
        {
            // Arrange 
            bool expected = true;
            string password = "abcdfghihgE1@";
            UserRegistrationDetails user = new UserRegistrationDetails();

            // Act
            bool result = user.ValidatePassword(password);

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}