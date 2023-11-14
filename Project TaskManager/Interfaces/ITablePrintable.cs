
namespace Project_TaskManager
{
    public interface ITablePrintable
    {
        string GetTableHeader();
        string GetTableRow();
        string GetTableFooter();
    }
}