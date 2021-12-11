using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Threading;
using ClassLibrary1;
using WinRTComponent;

namespace ExcelAddInTHING
{
    static class Extensions
    {
        public static Excel.Range Range(this Excel.Worksheet ws, string options)
        {
            if (ws != null)
                return ws.get_Range(options);
            return null;
        }
    }
    public partial class ThisAddIn
    {
        public static Excel.Application App;
        private void OnSaveRequested(Excel.Workbook Wb, bool SaveAsUI, ref bool Cancel)
        {
            string i; 
            Excel.Worksheet activeWorksheet;

            activeWorksheet = App.ActiveSheet;
            activeWorksheet.Range("C3").Value = "TESTING";

            ClassLibrary1.Class1 _interface = new ClassLibrary1.Class1();

            i = _interface.foo(); // Could not find Windows Runtime type 'WinRTComponent.Class'
            activeWorksheet.Range("D4").Value = i;
        }
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            App = Application;
            App.WorkbookBeforeSave += new Microsoft.Office.Interop.Excel.AppEvents_WorkbookBeforeSaveEventHandler(OnSaveRequested);
        }
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }
        #endregion
    }
}
