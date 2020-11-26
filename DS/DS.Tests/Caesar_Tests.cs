using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DS.Tests
{
    [TestClass]
    public class Caesar_Tests
    {
        [TestMethod]
        public void Encrypt_Returns_CorrectResult()
        {
            string input = "IFYOU WANTT OSUCC EEDYO USHOU LDSTR IKEOU TONNE WPATH SRATH ERTHA NTRAV ELTHE WORNP ATHSO FACCEP TEDSU CCESS";
            int shift = 16;
            string expecteedOutput = "YVOEK MQDJJ EIKSS UUTOE KIXEK BTIJH YAUEK JEDDU MFQJX IHQJX UHJXQ DJHQL UBJXU MEHDF QJXIE VQSSUF JUTIK SSUII";

            string output;

            output = Caesar.Caesar.Encrypt(input, shift);

            Assert.AreEqual(output, expecteedOutput);
        }

        [TestMethod]
        public void Decrypt_Returns_CorrectResult()
        {
            string expecteedOutput = "IFYOU WANTT OSUCC EEDYO USHOU LDSTR IKEOU TONNE WPATH SRATH ERTHA NTRAV ELTHE WORNP ATHSO FACCEP TEDSU CCESS";
            int shift = 16;
            string input = "YVOEK MQDJJ EIKSS UUTOE KIXEK BTIJH YAUEK JEDDU MFQJX IHQJX UHJXQ DJHQL UBJXU MEHDF QJXIE VQSSUF JUTIK SSUII";

            string output;

            output = Caesar.Caesar.Decrypt(input, shift);

            Assert.AreEqual(output, expecteedOutput);
        }

    }
}
