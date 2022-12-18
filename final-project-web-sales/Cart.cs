namespace final_project_web_sales
{
    internal class Cart
    {
        public int UserId; // primary key
        public int[] ProductIds;

        public Cart(int user_id, int[] product_ids)
        {
            this.UserId = user_id;
            this.ProductIds = product_ids;
        }

        public int GetTotalPrice()
        {
            var productPrices = Database.products.Join(ProductIds,
                                            product => product.Id,
                                            productId => productId,
                                            (product, productId) => product.Price);
            return productPrices.Sum();
        }

        public override string ToString()
        {
            string ans = "";
            ans += $"\t User id: {UserId}";
            ans += $"\n\t Product ids: {ProductIds.ToStringArray()}";

            return "Cart: {\n" + ans + "\n}";
        }

        public void AddProduct(int product_id)
        {
            ProductIds = ProductIds.Append(product_id);
        }

        public int Pay()
        {
            Database.orders.Add(new Order(UserId, DateTime.Now, "pending", ProductIds));
            int order_id = Database.IdOrderCounterNotIncrease;

            // clear cart products
            ProductIds = Array.Empty<int>();

            return order_id;
        }
    }
}
