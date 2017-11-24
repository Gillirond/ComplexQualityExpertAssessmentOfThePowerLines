using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
//using Excel;
using System.Data;

namespace Диплом
{
    class ConvertExcel
    {
        static public DataTable FromExcel(string filePath, int maxcolumns)
        {
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(filePath, 0, true, 5, "", "", false, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];

            DataTable DT = new DataTable();
            Microsoft.Office.Interop.Excel.Range ObjWorkSheetRange = (Microsoft.Office.Interop.Excel.Range)ObjWorkSheet.UsedRange.Columns;

            object[,] data = (object[,])ObjWorkSheetRange.Value2;
            // Create new Column in DataTable
            for (int cCnt = 1; cCnt <= maxcolumns; cCnt++)
            {
                DataColumn Column = new DataColumn();
                Column.DataType = System.Type.GetType("System.String");
                //Column.ColumnName = cCnt.ToString();
                Column.ColumnName = (data[1, cCnt]).ToString();
                DT.Columns.Add(Column);
            }
            for (int cCnt = 1; cCnt <= maxcolumns; cCnt++)
            {
                string cellVal = string.Empty;
                for (int rCnt = 2; rCnt <= ObjWorkSheetRange.Rows.Count; rCnt++)
                {
                    cellVal = (ObjWorkSheetRange.Cells[rCnt, cCnt] as Microsoft.Office.Interop.Excel.Range).Value2.ToString();
                   

                    DataRow Row;
                    // Add to the DataTable
                    if (cCnt == 1)
                    {

                        Row = DT.NewRow();
                        Row[cCnt-1] = cellVal;
                        DT.Rows.Add(Row);
                    }
                    else
                    {

                        Row = DT.Rows[rCnt-2];
                        Row[cCnt-1] = cellVal;
                    }
                    
                }

            }
            ObjWorkBook.Close();
            /*
                FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read);
     
            //Reading from a binary Excel file ('97-2003 format; *.xls)
            //IExcelDataReader excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
            IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
            excelReader.IsFirstRowAsColumnNames = true;
            DataSet result = excelReader.AsDataSet();
            return result;
            */
            
            return DT;
        }

        static public void AddToExcel(string filePath, params string[] values)
        {
            Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Open(filePath, 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "", true, false, 0, true, false, false);
            Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
            Microsoft.Office.Interop.Excel.Range ObjWorkSheetRange = (Microsoft.Office.Interop.Excel.Range)ObjWorkSheet.UsedRange.Columns;
            int i = 0;
            foreach (string val in values)
            {
                i++;
                (ObjWorkSheetRange.Cells[ObjWorkSheetRange.Rows.Count + 1, i] as Microsoft.Office.Interop.Excel.Range).Value2 = val;
            }
            ObjWorkBook.Save();
            ObjWorkBook.Close();
        }
    }
}
