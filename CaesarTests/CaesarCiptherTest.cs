using CaesarLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CaesarTests
{
    [TestClass]
    public class CaesarCiptherTest
    {
        [TestMethod]
        [DataRow(2, "Labas rytas!" ,"Ncdcu tavcu!")]
        [DataRow(-2, "Labas rytas!", "Jyzyq pwryq!")]
        [DataRow(10, "Labas rytas!", "Vklkc bidkc!")]
        [DataRow(36, "Labas rytas!", "Vklkc bidkc!")]
        [DataRow(-36, "Labas rytas!", "Bqrqi hojqi!")]
        [DataRow(2, "@#$%^&*(", "@#$%^&*(")]
        public void TestEncrypt(int offset, string input, string expectedResult)
        {
            string result = CaesarCypher.Encrypt(input, offset);

            Assert.AreEqual(expectedResult,result);
          
        }


        [TestMethod]
        [DataRow(2, "Ncdcu tavcu!", "Labas rytas!")]
        [DataRow(-2, "Jyzyq pwryq!", "Labas rytas!")]
        [DataRow(10, "Vklkc bidkc!", "Labas rytas!")]
        [DataRow(36, "Vklkc bidkc!", "Labas rytas!")]
        [DataRow(-36, "Bqrqi hojqi!", "Labas rytas!")]
        [DataRow(2, "@#$%^&*(", "@#$%^&*(")]
        public void TestDecrypt(int offset, string input, string expectedResult)
        {
            string result = CaesarCypher.Decrypt(input, offset);

            Assert.AreEqual(expectedResult, result);

        }
    }
}
