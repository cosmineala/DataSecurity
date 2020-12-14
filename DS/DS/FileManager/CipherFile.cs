using System;
using System.Collections.Generic;
using System.Text;

namespace DS.FileManager
{
    public class CipherFile
    {
        public string Name { get; set; }

        public string Message { get; set; }
        public string Key { get; set; }

        public string File { get; set; }

        public CipherFile( string file )
        {
            Name = file;
            File = FileManager.GetInputFile(Name);

            if( FileManager.IsFile(File))
            {
                ExtractData();
            }
        }

        public CipherFile(string file, string message, string key)
        {
            Name = file;
            File = FileManager.GetInputFile(Name);
            Message = message;
            Key = key;
            Create();
        }

        public void Print()
        {
            Console.WriteLine("Key:" + Key);
            Console.WriteLine("Message:" + Message);
        }


        private void ExtractData()
        {
            string[] lines = System.IO.File.ReadAllLines(File);
            Key = lines[0];
            Message = lines[1];
        }

        public void Create()
        {
            System.IO.File.WriteAllText(File, Key + "\n" + Message );
        }

    }
}
