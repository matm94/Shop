namespace Shop.Infrastructure.Querys
{
    public class OrderQuery
    {
        public string SearchPhrase { get; set; }
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
