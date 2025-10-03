
using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services
{
    public interface IGroceryListItemsService
    {
        public List<GroceryListItem> GetAll();

        public List<GroceryListItem> GetAllOnGroceryListId(int groceryListId);

        public List<BestSellingProducts> GetBestSellingProducts(int topX = 5);

        public GroceryListItem Add(GroceryListItem item);

        public GroceryListItem? Delete(GroceryListItem item);

        public GroceryListItem? Get(int id);

        public GroceryListItem? Update(GroceryListItem item);
    }
}
