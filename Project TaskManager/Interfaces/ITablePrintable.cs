using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project_TaskManager
{
    public interface ITablePrintable
    {
        string GetTableHeader();
        string GetTableRow();
        string GetTableFooter();
    }
}