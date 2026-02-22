namespace Intercore.shared.DTOs.common;
public record PagedRequest(int PageNumber = 1, int PageSize = 10);


public record PagedResult<T>(
    IEnumerable<T> Items,
    int TotalItems,
    int PageNumber,
    int PageSize)
{
    public int TotalPages => (int)Math.Ceiling(TotalItems / (double)PageSize);
    public bool HasNextPage => PageNumber < TotalPages;
    public bool HasPreviousPage => PageNumber > 1;
}