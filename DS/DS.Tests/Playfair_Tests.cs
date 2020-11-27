using Microsoft.VisualStudio.TestTools.UnitTesting;

using DS.Playfair;

namespace DS.Tests
{
    [TestClass]
    public class Playfair_Tests
    {
        [TestMethod]
        public void Encrypt_Returns_CorrectResault()
        {
            // Test formatted text
            string input = "AN AX RE ME RE SI GU TU IX";
            string key = "CORNEL";
            string output = "";
            string output_check = "DO BW NC UF NC XS MP UP SR";

            output = Playfair.Playfair.Encrypt(input, key);

            Assert.AreEqual(output_check, output);

            // Test unformateed text
            input = "Ana a re mere si gutu   i    ";
            key = "CO RNe L";
            output = "";
            output_check = "DO BW NC UF NC XS MP UP SR";

            output = Playfair.Playfair.Encrypt(input, key);

            Assert.AreEqual(output_check, output);

        }

        [TestMethod]
        public void Decrypt_Returns_CorrectResault()
        {
            // Test formatted text
            string output_check = "AN AX RE ME RE SI GU TU IX";
            string key = "CORNEL";
            string output = "";
            string input = "DO BW NC UF NC XS MP UP SR";

            output = Playfair.Playfair.Decrypt(input, key);

            Assert.AreEqual(output_check, output);

            // Test unformateed text
            input = " DobW NCUF NcxS MP UP SR";
            key = "CO RNe L";
            output = "";
            output_check = "AN AX RE ME RE SI GU TU IX";

            output = Playfair.Playfair.Decrypt(input, key);

            Assert.AreEqual(output_check, output);
        }

    }
}
