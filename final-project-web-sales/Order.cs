namespace final_project_web_sales
{
    internal class Order
    {
        public int Id;
        public int UserId;
        public DateTime OrderDate;
        public string Status;
        public int[] ProductIds;

        public Order(int user_id, DateTime order_date, string status, int[] product_ids)
        {
            this.Id = Database.IdOrderCounter;
            this.UserId = user_id;
            this.OrderDate = order_date;
            this.Status = status;
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
            ans += $"\t Id: {Id}";
            ans += $"\n\t UserId: {UserId}";
            ans += $"\n\t OrderDate: {OrderDate}";
            ans += $"\n\t PriceTotal: {GetTotalPrice()}";
            ans += $"\n\t Status: {Status}";
            ans += $"\n\t ProductIds: {ProductIds.ToStringArray()}";

            return "Order: {\n" + ans + "\n}";
        }

        // Status: pending -> done
        public void Done()
        {
            Status = "done";
        }
    }
}
