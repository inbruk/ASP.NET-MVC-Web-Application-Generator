namespace Auxiliary.FileGeneration
{
    using System;
    using System.Collections.Generic;

    public static class OutputFileExtentions
    {
        private static Dictionary<int, String> values = new Dictionary<int, string>()
        {
            { (int)( OutputFileType.SqlScript ), ".sql" },
            { (int)( OutputFileType.CSharpSource ), ".cs" }
        };

        public static String GetExtentionByType(OutputFileType type)
        {
            return values[(int)(type)];
        }
    }
}
