using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demon_Delegae
{
    delegate string str2str(string str);
    internal class NumberSort
    {
        public string Content { get; }
        private string winFormRead(string filePath = "")
        {
            var fileContent = string.Empty;
            filePath = string.Empty;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = "c:\\";

        }

        private string consoleRead(string fileName)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            path += "\\" + fileName;
            var sr = new StreamReader(path);
            string fileContent = sr.ReadToEnd();
            sr.Close();
            return fileContent;
        }

        public NumberSort(string trigger = "")
        {
            str2str read;
            if(trigger == "console")
            {
                read = consoleRead;
            }
            else
            {
                Content = winFormRead();
            }
            Content = read?.Invoke("Numbers.txt");
        }
    }
}
