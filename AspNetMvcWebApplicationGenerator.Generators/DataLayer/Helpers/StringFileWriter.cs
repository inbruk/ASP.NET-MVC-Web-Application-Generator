namespace AspNetMvcWebApplicationGenerator.Generators.DataLayer.Helpers
{
    using System;
    using System.IO;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    internal class StringFileWriter
    {
        private StreamWriter writer = null;

        public StringFileWriter(String path, String fileName, OutputFileType fType)
        {
            String ext = OutputFileExtentions.GetExtentionByType(fType);
            String fullPath = path + fileName + ext;
            writer = new StreamWriter(fullPath);
        }

        public void Write(String str)
        {
            if (writer != null)
                writer.Write(str);
            else
                throw new Exception("Error: try to write, when file is closed !");
        }

        public void WriteString(String str)
        {
            if (writer != null)
                writer.WriteLine(str);
            else
                throw new Exception("Error: try to write, when file is closed !");
        }

        public void Close()
        {
            writer.Close();
            writer = null;
        }
    }
}
