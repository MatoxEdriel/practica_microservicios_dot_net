namespace Intercore.shared.Helpers;

public static class PaginationHelper
{
    public static string BuildPagedSql(string originalSql, int pageNumber, int pageSize, string orderBy)
    {
        int offset = (pageNumber - 1) * pageSize;
        
        return $@"
            {originalSql}
            ORDER BY {orderBy}
            OFFSET {offset} ROWS
            FETCH NEXT {pageSize} ROWS ONLY;";
    }
    
    public static string BuildCountSql(string originalSql)
    {
        return $"SELECT COUNT(*) FROM ({originalSql}) AS TotalCountQuery";
    }
}