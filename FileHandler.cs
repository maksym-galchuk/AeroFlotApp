using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AeroFlotApp
{
    public class FileHandler {
        private readonly string filePath;

        public FileHandler(string filePath) {
            this.filePath = filePath;
        }

        public void WriteToFile(string content) {
            File.WriteAllText(filePath, content);
        }

        public string ReadFromFile() {
            return File.ReadAllText(filePath);
        }

        public bool FileExists() {
            return File.Exists(filePath);
        }
    }
}
