namespace WebAppFinanceiro.Dtos
{
    public class CategoryTotalDto
    {
        public int CategoryId { get; set; }
        public decimal Total { get; set; }
        public string CategoryName { get; set; } = "";
    }
}
