using Microsoft.VisualStudio.TestTools.UnitTesting;

using DS.Dictionary;

namespace DS.Tests
{
    [TestClass]
    public class LetterConvertor_Tests
    {
        [TestMethod]
        public void ToNumber_Returns_CorrectResult()
        {
            char input_H = 'D';
            char input_L = 'e';

            int output_Exprecteed_H = 3;
            int output_Exprecteed_L = 4;

            int output_H;
            int output_L;

            output_H = LetterConvertor.ToNumber( input_H );
            output_L = LetterConvertor.ToNumber(input_L);

            Assert.AreEqual( output_H , output_Exprecteed_H);
            Assert.AreEqual(output_L, output_Exprecteed_L);
        }

        [TestMethod]
        public void ToCharUpper_Returns_CorrectResult()
        {
            int input = 'D' - 'A'; // 3
            char output_Expecteed = 'D';

            char output;

            output = LetterConvertor.ToCharUpper(input);

            Assert.AreEqual(output, output_Expecteed);
        }

        [TestMethod]
        public void ToCharLower_Returns_CorrectResult()
        {
            int input = 'e' - 'a'; // 3
            char output_Expecteed = 'e';

            char output;

            output = LetterConvertor.ToCharLower(input);

            Assert.AreEqual(output, output_Expecteed);
        }

    }
}
