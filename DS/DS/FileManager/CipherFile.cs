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
            else
            {
                FileManager.CreateFile(File);
            }  
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

    }
}
