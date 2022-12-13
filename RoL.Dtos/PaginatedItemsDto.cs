namespace RoL.Dtos;

public class PaginatedItemsDto<T>
{
    public T Items { get; set; }
    public PaginationInfoDto Pagination { get; set; }
}