using final_project_web_sales;

Database.CreateDataDemo();



// ctrl + K ctrl + U to uncomment code

//1.    Liệt kê các khách hàng có đơn hàng từ 5 triệu
{
    var user_ids = Database.orders
        .Where(order => order.GetTotalPrice() >= 5000000)
        .Select(order => order.UserId)
        .Distinct().ToArray();

    var users = Database.GetUsersById(user_ids);
    users.ForEach(x => Console.WriteLine(x));
}


//2.	Liệt kê 2 khung giờ có nhiều lượt đặt hàng nhất
{
//var take = 2;
//var counterOrderHours = Database.orders.GroupBy(
//    order => order.OrderDate.Hour,
//    order => order.OrderDate.Hour,
//    (hour, hours) => new
//    {
//        Count = hours.Count(),
//        Hour = hour
//    })
//    .Take(take)
//    .ToList();

//counterOrderHours.ForEach(x =>
//{
//    Console.WriteLine(x);
//});
}


//3.	Tìm 3 sản phẩm có số lượng mua nhiều nhất
{
//var take = 3;
//var prouctCounter = Database.orders
//    .SelectMany(order => order.ProductIds)
//    .GroupBy(
//        productId => productId,
//        productId => productId,
//        (productId, productIds) => new
//        {
//            Count = productIds.Count(),
//            Product = Database.products.Find(p => p.Id == productId)
//        })
//    .OrderByDescending(x => x.Count)
//    .Take(take);

//prouctCounter.ToList().ForEach(x =>
//{
//    Console.WriteLine(x.Product);
//    Console.WriteLine("Count: {0}\n", x.Count);
//});
}


//4.	In ra danh sách tên các loại sản phẩm
{
    //Database.products.ForEach(x => Console.WriteLine(x));
}


//5.	Tên các sản phẩm có giá trên 10000000
{
    //var products = Database.products
    //    .Where(p => p.Price >= 3000000)
    //    .ToList();

    //products.ForEach(product => Console.WriteLine(product));
}


//6.	In ra các sản phẩm có điểm đánh giá cao đến thấp
{
    //var products = Database.products.OrderByDescending(product => product.GetPoint()).ToList();

    //products.ForEach(product => Console.WriteLine(product));
}


//7.	In ra các sản phẩm thuộc loại là bàn phím
{
    //var keyboards = Database.products.Where(product => product.Type == "keyboard").ToList();

    //keyboards.ForEach(x => Console.WriteLine(x));
}


//8.	Danh sách tên người dùng đã đánh giá sản phẩm có id=6
{
    //var product = Database.products.Find(p => p.Id == 6);
    //var reviews = Database.GetReviewsById(product.ReviewIds);

    //var users = Database.users.Join(reviews,
    //                        user => user.Id,
    //                        review => review.UserId,
    //                        (user, review) => user)
    //    .ToList();

    //users.ForEach(x => Console.WriteLine(x));
}


//9.	In ra thông tin đơn hàng có giá trị đơn hàng cao nhất và người dùng đặt đơn hàng đó
{
    //var sorted_orders = Database.orders.OrderByDescending(order => order.GetTotalPrice()).ToList();
    //var user = Database.users.Find(user => user.Id == sorted_orders[0].UserId);

    //Console.WriteLine(sorted_orders[0]);
    //Console.WriteLine(user);
}


//10.	In ra danh sách các sản phẩm trong giỏ hàng của người có id=9
{
    //var cart = Database.carts.Find(cart => cart.UserId == 9);
    //var products = Database.products.Join(cart.ProductIds,
    //                            product => product.Id,
    //                            cart_id => cart_id,
    //                            (product, cart_id) => product)
    //    .ToList();

    //products.ForEach(x => Console.WriteLine(x));
}