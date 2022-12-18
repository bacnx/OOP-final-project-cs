namespace final_project_web_sales
{
    static class Database
    {
        // counter: auto create id for List
        private static int idUserCounter = 0;
        public static int IdUserCounter { get { return ++idUserCounter; } }
        private static int idProductCounter = 0;
        public static int IdProductCounter { get { return ++idProductCounter; } }
        private static int idOrderCounter = 0;
        public static int IdOrderCounter { get { return ++idOrderCounter; } }
        public static int IdOrderCounterNotIncrease { get { return idOrderCounter; } }
        private static int idReviewCounter = 0;
        public static int IdReviewCounter { get { return ++idReviewCounter; } }
        public static int IdReviewCounterNotIncrease { get { return idReviewCounter; } }


        public static List<Cart> carts = new(); // declare before users to add new cart when add new user (at ./User.cs:line 18)
        public static List<User> users = new();
        public static List<Product> products = new();
        public static List<Order> orders = new();
        public static List<Review> reviews = new();

        public static List<Cart> GetCartsById(int[] ids)
        {
            return carts.Join(ids,
                cart => cart.UserId,
                id => id,
                (cart, id) => cart)
            .ToList();
        }
        public static List<User> GetUsersById(int[] ids)
        {
            return users.Join(ids,
                user => user.Id,
                id => id,
                (user, id) => user)
            .ToList();
        }
        public static List<Product> GetProductsById(int[] ids)
        {
            return products.Join(ids,
                product => product.Id,
                id => id,
                (product, id) => product)
            .ToList();
        }
        public static List<Order> GetOrdersById(int[] ids)
        {
            return orders.Join(ids,
                order => order.Id,
                id => id,
                (order, id) => order)
            .ToList();
        }
        public static List<Review> GetReviewsById(int[] ids)
        {
            return reviews.Join(ids,
                review => review.Id,
                id => id,
                (review, id) => review)
            .ToList();
        }

        public static void CreateDataDemo()
        {
            //users
            users.Add(new User("Phan Thi Hong Nam", "067851000", "linnea99@hotmail.com"));
            users.Add(new User("Lee Thi Ngoc Thuy", "001413356", "katharina.pagac@yahoo.com"));
            users.Add(new User("Le Hong Nguyen", "036971124", "ellsworth.beer@hotmail.com"));
            users.Add(new User("Pham Duy Hong", "059598368", "thad_goldner@gmail.com"));
            users.Add(new User("Duong Quoc Thai", "0160567225", "lelah.west@hotmail.com"));
            users.Add(new User("Tran Thi Thu", "035766290", "celine_rosenbaum@gmail.com"));
            users.Add(new User("Nguyen Le Tuan", "026239572", "marcelina.walker4@gmail.com"));
            users.Add(new User("Phung Thi Bich Thuy", "073038164", "michale51@hotmail.com"));
            users.Add(new User("Nguyen Thanh Binh", "026051436", "hertha.farrell72@hotmail.com"));
            users.Add(new User("Do Thi Thanh Huyen", "070427798", "jackeline57@hotmail.com"));
            users.Add(new User("Nguyen Quoc Hung", "037215528", "maci.rohan69@yahoo.com"));
            users.Add(new User("Nguyen Van Son", "0168544290", "onie.swaniawski53@hotmail.com"));

            // products
            products.Add(new Product("MacBook Air 2022", 25900000, "laptop"));
            products.Add(new Product("Dell XPS 13 9310", 19990000, "laptop"));
            products.Add(new Product("Levono ThinkPad X1 Nano Gen 2", 36990000, "laptop"));
            products.Add(new Product("Dell XPS 13 Plus 9320", 24190000, "laptop"));
            products.Add(new Product("Microsoft Surface Pro 9", 26990000, "laptop"));

            products.Add(new Product("Bàn phím Keychron K6 (Case Nhôm - Gateron Brown Switch - Hotswap)", 1590000, "keyboard"));
            products.Add(new Product("Bàn phím Keychron K3 v2 (Optical Red Switch - Led RGB)", 2190000, "keyboard"));
            products.Add(new Product("Bàn phím cơ AKKO 3087 Steam Engine (AKKO V2 Pink Switch)", 1499000, "keyboard"));
            products.Add(new Product("Bàn phím cơ AKKO 3068B Plus World Tour Tokyo R2 (AKKO CS Switch Jelly Pink)", 1949000, "keyboard"));

            products.Add(new Product("Loa Bluetooth Harman Kardon Aura Studio 3", 6900000, "sound"));
            products.Add(new Product("Loa Bluetooth Harman Kardon Onyx Studio 5", 3900000, "sound"));
            products.Add(new Product("Loa Harman Karrdon Go + Play", 5990000, "sound"));
            products.Add(new Product("Loa Bluetooth Harman Kardon Soundstick 4", 7990000, "sound"));
            products.Add(new Product("Loa Marshall Emberton (Black & Brass)", 2990000, "sound"));

            products.Add(new Product("Chuột Logitech G102 (G203) LIGHTSYNC (BLack)", 420000, "mouse"));
            products.Add(new Product("Chuột logitech M331 Silent (Black)", 359000, "mouse"));
            products.Add(new Product("Chuột không dây Microsoft Arc Mouse Bluetooth (ELG-00005)", 990000, "mouse"));

            // orders
            orders.Add(new Order( 1, new DateTime(2022, 11, 5, 23, 4, 5), "done", new int[] { 1, 1, 2, 4 } ));
            orders.Add(new Order( 1, new DateTime(2022, 12, 14, 20, 45, 00), "pending", new int[] { 1, 3, 4 } ));
            orders.Add(new Order( 2, new DateTime(2022, 12, 15, 19, 45, 54), "pending", new int[] { 1, 3, 4 } ));

            // fake user review
            users[2].Review(1, 4, "Do dep qua shop a <3");
            users[1].Review(1, 3);
            users[3].Review(1, 5);
            users[4].Review(1, 5);
            users[1].Review(1, 4);
            users[4].Review(1, 3);
            users[6].Review(2, 2);
            users[0].Review(2, 5);
            users[5].Review(2, 5);
            users[0].Review(2, 4);
            users[7].Review(3, 3);
            users[5].Review(3, 2);
            users[2].Review(3, 5);
            users[3].Review(3, 5);
            users[4].Review(4, 4);
            users[1].Review(4, 3);
            users[6].Review(4, 2);
            users[6].Review(4, 2);
            users[7].Review(5, 1);
            users[9].Review(5, 4);
            users[2].Review(5, 3);
            users[0].Review(6, 2);
            users[0].Review(7, 2);
            users[5].Review(7, 1);
            users[1].Review(8, 4);
            users[1].Review(8, 3);
            users[1].Review(9, 2);
            users[2].Review(9, 2);
            users[3].Review(9, 1);
            users[3].Review(10, 4);
            users[4].Review(10, 3);
            users[4].Review(11, 4);
            users[5].Review(11, 5);
            users[5].Review(11, 5);
            users[6].Review(12, 4);
            users[6].Review(12, 3);
            users[6].Review(12, 4);
            users[7].Review(13, 5);
            users[7].Review(14, 5);
            users[8].Review(14, 4);
            users[8].Review(15, 3);
            users[9].Review(15, 4);
            users[9].Review(15, 5);
            users[3].Review(16, 5);
            users[1].Review(16, 4);
            users[2].Review(16, 3);
            users[2].Review(16, 4);
            users[1].Review(16, 5);
            users[3].Review(16, 5);

            // add products to carts
            carts[0].AddProduct(1);
            carts[0].AddProduct(2);
            carts[0].AddProduct(3);
            carts[0].AddProduct(1);
            carts[0].AddProduct(1);
            carts[1].AddProduct(2);
            carts[1].AddProduct(3);
            carts[1].AddProduct(4);
            // add products to cart of user with id=9
            carts[8].AddProduct(1);
            carts[8].AddProduct(1);
            carts[8].AddProduct(2);
            carts[8].AddProduct(3);
            carts[8].AddProduct(4);

            // pay cart
            int order_id_1 = carts[0].Pay();
            carts[1].Pay();

            orders.Find(x => x.Id == order_id_1).Done();
        }
    }
}
