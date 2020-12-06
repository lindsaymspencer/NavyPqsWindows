using System.IO;
using System.Windows.Forms;

namespace NavyPqsWindows.Services
{
    public class FileHelper
    {
        public static void WriteTo(string path, string content)
        {
            EnsureDirectoryExists(path);
            EnsureFileExists(path);
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(content);
            }
        }

        public static void WriteOver(string path, string content)
        {
            EnsureFileExists(path);
            using (StreamWriter sw = File.CreateText(path))
            {
                sw.WriteLine(content);
            }
        }

        private static void EnsureDirectoryExists(string path)
        {
            string directory = Path.GetDirectoryName(path);
            if (!File.Exists(directory))
            {
                CreateDirectory(directory);
            }
        }

        private static void EnsureFileExists(string path)
        {
            EnsureDirectoryExists(path);
            if (!File.Exists(path))
            {
                using (FileStream f = File.Create(path)) { }
            }
        }

        private static void CreateDirectory(string directory)
        {
            Directory.CreateDirectory(directory);
        }

        public static string ReadFile()
        {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = openFileDialog.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }

            return fileContent;
        }

        public static string GetDirectory()
        {
            var folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            return result == DialogResult.OK ? folderBrowserDialog.SelectedPath : null;
        }
    }
}
