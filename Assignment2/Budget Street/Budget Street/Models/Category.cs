using System.Collections.Generic;

namespace Budget_Street.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<CategoryItem> CategoryItems { get; set; }

    }

    public class CategoryItem
    {
        public int CategoryItemId { get; set; }
        public string CategoryItemName { get; set; }
        public int BudgetedAmount { get; set; }
        public int TotalSpent { get; set; }
        public List<Transaction> Transactions { get; set; }
    }

    public class Categories : List<Category> { };
}
