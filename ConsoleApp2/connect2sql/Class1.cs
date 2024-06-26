using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System;
using ConsoleApp2.connect2sql;

public class Program
{
    private static void Main(string[] args)
    {
        List<Properties> ReadDataFromExcel(string filePath)
        {
            var properties = new List<Properties>();

            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Assuming the data is in the first worksheet

                for (int row = 2; row <= worksheet.Dimension.End.Row; row++)
                {
                    var property = new Properties
                    {
                        Altitude = Convert.ToInt32(worksheet.Cells[row, 1].Value),
                        rollRate = Convert.ToInt32(worksheet.Cells[row, 2].Value),
                        pitchRate = Convert.ToInt32(worksheet.Cells[row, 3].Value),
                        yawRate = Convert.ToInt32(worksheet.Cells[row, 4].Value)
                        // Map other properties accordingly
                    };

                    properties.Add(property);
                }
            }
            return properties;
        }
    }
}