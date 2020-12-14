using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DS.Tests
{
    [TestClass]
    public class Vigenere_Tests
    {
        // Clasic

        [TestMethod]
        public void Encrypt_Returns_CorrectResult()
        {
            string expecteedOutput = "SMBIH STSFL WQHVW HIOBH WYLLV FMMBR HANVD WJIXV NBLMF QLVGC GZPVL LAUXH DCFXP VJLWV GBDGT ZEUXJ HTDNP MUHLY PMALQ QHRXK UMVTZ VMGAA MFEXK XBXKR LVRWP C";
            string key = "DINTWOFNTHTITTF";
            string input = "PEOPL EOFME DIOCR EABIL ITYSO METIM ESACH IEVEO UTSTA NDING SUCCE SSBEC AUSET HEYDO NTKNO WWHEN TOQUI TMOST MENSU CCEED BECAU SETHE YARED ETERM INEDT O";

            string output;

            output = Vigenere.Vigenere.Encrypt(input, key);

            Assert.AreEqual( expecteedOutput, output);
        }

        [TestMethod]
        public void Decrypt_Returns_CorrectResult()
        {
            string input = "SMBIH STSFL WQHVW HIOBH WYLLV FMMBR HANVD WJIXV NBLMF QLVGC GZPVL LAUXH DCFXP VJLWV GBDGT ZEUXJ HTDNP MUHLY PMALQ QHRXK UMVTZ VMGAA MFEXK XBXKR LVRWP C";
            string key = "DINTWOFNTHTITTF";
            string expecteedOutput = "PEOPL EOFME DIOCR EABIL ITYSO METIM ESACH IEVEO UTSTA NDING SUCCE SSBEC AUSET HEYDO NTKNO WWHEN TOQUI TMOST MENSU CCEED BECAU SETHE YARED ETERM INEDT O";

            string output;

            output = Vigenere.Vigenere.Decrypt(input, key);

            Assert.AreEqual( expecteedOutput, output);
        }

        // Auto key

        [TestMethod]
        public void AutoEncrypt_Returns_CorrectResult()
        {
            string expecteedOutput = "SMBIH STSFL WQHVW TEPXW MHDES PMHKD ISBKS QXTWC GXLBM RVIPN AYXGS MLTXC NXARZ ZYAFS FLLRQ WQZIG ASOXW GFYFH IAUWH VQUYL UQQSN EIGZY ACVIG FXGRG ARXKX M";
            string key = "DINTWOFNTHTITTF";
            string input = "PEOPL EOFME DIOCR EABIL ITYSO METIM ESACH IEVEO UTSTA NDING SUCCE SSBEC AUSET HEYDO NTKNO WWHEN TOQUI TMOST MENSU CCEED BECAU SETHE YARED ETERM INEDT O";

            string output;

            output = Vigenere.Vigenere.AutoEncrypt(input, key);

            Assert.AreEqual( expecteedOutput, output);
        }

        [TestMethod]
        public void AutoDecrypt_Returns_CorrectResult()
        {
            string input = "SMBIH STSFL WQHVW TEPXW MHDES PMHKD ISBKS QXTWC GXLBM RVIPN AYXGS MLTXC NXARZ ZYAFS FLLRQ WQZIG ASOXW GFYFH IAUWH VQUYL UQQSN EIGZY ACVIG FXGRG ARXKX M";
            string key = "DINTWOFNTHTITTF";
            string expecteedOutput = "PEOPL EOFME DIOCR EABIL ITYSO METIM ESACH IEVEO UTSTA NDING SUCCE SSBEC AUSET HEYDO NTKNO WWHEN TOQUI TMOST MENSU CCEED BECAU SETHE YARED ETERM INEDT O";

            string output;

            output = Vigenere.Vigenere.AutoDecrypt(input, key);

            Assert.AreEqual( expecteedOutput, output );
        }
    }
}
