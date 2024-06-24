namespace site.Components.Menu
{

    public class Menu
    {
        public List<Category> Categories { get; set; } = new List<Category>();
    }

    public class Category
    {
        public string Name { get; set; } = string.Empty;
        public List<string> PriceCategories { get; set; } = new List<string>();
        public List<Item> Items { get; set; } = new List<Item>();
    }

    public class Item
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public Dictionary<string, string> Prices { get; set; } = new Dictionary<string, string>();
    }
}
