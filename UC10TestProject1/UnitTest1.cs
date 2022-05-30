using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UC10TestProject1
{
    //validation for first name
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("Shalini", "Shalini")]
        [DataRow("Sha", "Sha")]
        [DataRow("s", null)]
        [DataRow("Shalu05", null)]

        public void ValidateFirstname(string a, string expected)
        {
            try
            {

                var actual = RegexSample.ValidatingFirstName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }
        //Validating for Last Name
        [TestMethod]
        [DataRow("Venkatesh", "Venkatesh")]
        [DataRow("Ve", null)]
        [DataRow("Venkat", "Venkat")]
        [DataRow("Venkat05", null)]
        public void ValidateUserLastname(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingLastName(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }
        //Validation for Email
        [TestMethod]
        [DataRow("abc@gmail.com", "abc@gmail.com")]
        [DataRow("abc-100@yahoo.com", "abc-100@yahoo.com")]
        [DataRow("abc.100@yahoo.com", "abc.100@yahoo.com")]
        [DataRow("abc111@yahoo.com", "abc111@yahoo.com")]
        [DataRow("abc111@abc.com", "abc111@abc.com")]
        [DataRow("abc-100@abc.net", "abc-100@abc.net")]
        [DataRow("abc.100@abc.com.au", "abc.100@abc.com.au")]
        [DataRow("abc@1.com", "abc@1.com")]
        [DataRow("abc@gmail.com.com", "abc@gmail.com.com")]
        [DataRow("abc+100@gmail.com", "abc+100@gmail.com")]
        [DataRow("abc", null)]
        [DataRow("abc@.com.my", null)]
        [DataRow("abc123@.com", null)]
        [DataRow("abc123@.com.com", null)]
        [DataRow("abc()*@gmail.com", null)]
        [DataRow(".abc@abc.com", null)]
        [DataRow("abc@%*.com", null)]
        [DataRow("abc..2002@gmail.com", null)]
        [DataRow("abc.@gmail.com", null)]
        [DataRow("abc@abc@gmail.com", null)]
        [DataRow("abc@gmail.com.1a", null)]
        [DataRow("abc@gmail.com.aa.au", null)]

        public void ValidateUserEmail(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingEmailId(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }

        //Validation for Phone Number
        [TestMethod]
        [DataRow("1 1000987267", "1 1000987267")]
        [DataRow("91 9842905050", "91 9842905050")]
        [DataRow("100 9842905050", "100 9842905050")]
        [DataRow("919842905050", null)]
        [DataRow("919842905", null)]
        [DataRow("91 984290", null)]
        [DataRow("91 984290505000000", null)]
        public void ValidateUserPhoneNumber(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingPhoneNum(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }

        ////Validation for Password
        [TestMethod]
        [DataRow("Shalu@123", "Shalu@123")]
        [DataRow("Shai#lini123", "Sha#lini123")]
        [DataRow("Sha@lini1S ", "Sha@lini1S")]
        [DataRow("@Shalini129", "@Shalini129")]
        [DataRow("Sha-lini123", "Sha-lini123")]
        [DataRow("shalini123)@1234", null)]
        [DataRow("Sha@lini", null)]
        [DataRow("sha123", null)]
        [DataRow("sha@123", null)]
        [DataRow("@sha#12sha", null)]
        [DataRow(")shalu12", null)]
        [DataRow(")shaLu12", null)]
        [DataRow("sha-lu@12S", null)]
        [DataRow("shaLU@s", null)]

        public void ValidateUserPassword(string a, string expected)
        {
            try
            {
                var actual = RegexSample.ValidatingPassWord(a);
                Assert.AreEqual(expected, actual);
            }
            catch (CustomException actual)
            {
                Assert.AreEqual(expected, actual.message);
            }
        }



    }
}

    
