namespace final_project_web_sales
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public string Type { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public int[] ReviewIds { get; set; }

        public Product(string name, int price, string type, string description = "")
        {
            this.Id = Database.IdProductCounter;
            this.Name = name;
            this.Description = description;
            this.Price = price;
            this.Type = type;
            this.ReviewIds = Array.Empty<int>();
        }

        public double GetPoint()
        {
            var reviewPoints = Database.reviews.Join(ReviewIds.ToList(),
                                                review => review.Id,
                                                reviewId => reviewId,
                                                (review, reviewId) => review.Point);

            return reviewPoints.Any() ? reviewPoints.Average() : 0;
        }
        public override string ToString()
        {
            string ans = "";
            ans += $"\t Id: {Id}";
            ans += $"\n\t Name: {Name}";
            ans += $"\n\t Price: {Price}";
            ans += $"\n\t Type: {Type}";
            ans += $"\n\t Description: {Description}";
            ans += $"\n\t Review point: {GetPoint()}";
            ans += $"\n\t Review ids: {ReviewIds.ToStringArray()}";

            return "Product: {\n" + ans + "\n}";
        }
    }
}
