using Microsoft.Office.Interop.Word;
using Sunny.UI.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Word = Microsoft.Office.Interop.Word;

namespace KimPhuong
{
    public class WordExport
    {
        private Word.Application _app;
        private Word.Document _doc;
        private object _missing;

        public WordExport(string templatePath, bool visible)
        {
            _missing = System.Reflection.Missing.Value;
            _app = new Word.Application();
            _app.Visible = visible;

            object template = templatePath;
            _doc = _app.Documents.Add(ref template, ref _missing, ref _missing, ref _missing);
        }

        public void WriteFields(Dictionary<string, string> vValues)
        {
            foreach (Word.Field field in _doc.Fields)
            {
                string fieldName = field.Code.Text.Substring(11, field.Code.Text.IndexOf("\\") - 12).Trim();
                if (vValues.ContainsKey(fieldName))
                {
                    field.Select();
                    _app.Selection.TypeText(vValues[fieldName]);
                }
            }
        }

        public void WriteTable(System.Data.DataTable vDataTable, int vIndexTable)
        {
            Word.Table tbl = _doc.Tables[vIndexTable];
            int lenrow = vDataTable.Rows.Count;
            int lencol = vDataTable.Columns.Count;

            for (int i = 0; i < lenrow; ++i)
            {
                object ob = System.Reflection.Missing.Value;
                tbl.Rows.Add(ref ob);
                for (int j = 0; j < lencol; ++j)
                {
                    tbl.Cell(i + 2, j + 1).Range.Text = vDataTable.Rows[i][j].ToString();
                }
            }
        }

        public void SaveAs(string filePath)
        {
            try
            {
                object fileName = filePath;
                object format = WdSaveFormat.wdFormatDocumentDefault;

                _doc.SaveAs2(ref fileName,
                    ref format,
                    ref _missing, ref _missing, ref _missing, ref _missing,
                    ref _missing, ref _missing, ref _missing, ref _missing,
                    ref _missing, ref _missing, ref _missing, ref _missing,
                    ref _missing, ref _missing);

                _doc.Close(ref _missing, ref _missing, ref _missing);
                _app.Quit(ref _missing, ref _missing, ref _missing);
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi khi lưu file: " + ex.Message);
            }
            finally
            {
                if (_doc != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(_doc);
                }
                if (_app != null)
                {
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(_app);
                }

                _doc = null;
                _app = null;
                GC.Collect();
            }
        }
    }
}
