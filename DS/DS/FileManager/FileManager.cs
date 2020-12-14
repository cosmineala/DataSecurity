using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DS.FileManager
{
    public class FileManager
    {
        static public string CurentDirectory { get; } = Directory.GetCurrentDirectory();
        static public string InputsDirectory { get; } = FileManager.GetParent(CurentDirectory, 4) + "\\Inputs";
       
        static public string GetParent(string path) =>
            System.IO.Directory.GetParent(path).ToString();
        static public string GetParent(string path, int level)
        {
            string output = GetParent(path);
            for(int i=0; i < level-1; i++)
            {
                output = GetParent(output);
            }
            return output;
        }

        static public string GetInputFile( string fileName)
        {
            return InputsDirectory + "\\" + fileName;
        }

        static public bool IsFile(string file) =>
            File.Exists(file);

        static public System.IO.FileStream CreateFile(string file) =>
            File.Create(file);
    }
}
