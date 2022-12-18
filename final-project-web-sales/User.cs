namespace final_project_web_sales
{
    internal class User
    {
        public int Id;
        public string Name;
        public string Phone;
        public string Email;

        public User(string name, string phone, string email)
        {
            this.Id = Database.IdUserCounter;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;

            // create new cart for new user
            Database.carts.Add(new Cart(this.Id, Array.Empty<int>()));
        }

        public override string ToString()
        {
            string ans = "";
            ans += $"\t Id: {Id}";
            ans += $"\n\t Name: {Name}";
            ans += $"\n\t Phone: {Phone}";
            ans += $"\n\t Email: {Email}";

            return "User: {\n" + ans + "\n}";
        }

        public void Review(int product_id, int point, string content = "")
        {
            // get product with product_id
            var product = Database.products.Find(product => (product.Id == product_id));
            if (product == null) return;

            // add new review to database
            Database.reviews.Add(new Review(point, content, this.Id, product_id));

            // add review_id to product
            int review_id = Database.IdReviewCounterNotIncrease;
            product.ReviewIds = product.ReviewIds.Append(review_id);
        }
    }
}
