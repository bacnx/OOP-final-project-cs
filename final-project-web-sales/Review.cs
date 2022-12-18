namespace final_project_web_sales
{
    internal class Review
    {
        public int Id;
        public int Point;
        public string? Content;
        public int UserId;
        public int ProductId;

        public Review(int point, string? content, int user_id, int product_id)
        {
            this.Id = Database.IdReviewCounter;
            this.Point = point;
            this.Content = content;
            this.UserId = user_id;
            this.ProductId = product_id;
        }

        public override string ToString()
        {
            string ans = "";
            ans += $"\t id: {Id}";
            ans += $"\n\t Point: {Point}";
            ans += $"\n\t Content: {Content}";
            ans += $"\n\t User id: {UserId}";
            ans += $"\n\t Product id: {ProductId}";

            return "Review: {\n" + ans + "\n}";
        }
    }
}
