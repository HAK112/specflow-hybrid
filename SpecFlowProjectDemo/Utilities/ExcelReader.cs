using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;

namespace SpecFlowProjectDemo.Utilities
{
    static class ExcelReader
    {
        public static object getdataFromExcel(string filePath, string sheetName, int row, string columnName)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(filePath, FileMode.Open, FileAccess.Read))
            {
                // Auto-detect format, supports:
                //  - Binary Excel files (2.0-2003 format; *.xls)
                //  - OpenXml Excel files (2007 format; .xlsx, .xlsb)
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    // 2. Use the AsDataSet extension method
                    DataSet result = reader.AsDataSet(
                       new ExcelDataSetConfiguration()
                       {
                           ConfigureDataTable = (tableReader) => new ExcelDataTableConfiguration()
                           {
                               UseHeaderRow = true
                           }
                       });
                    return result.Tables[sheetName].Rows[row][columnName];
                }
            }

        }
    }
}