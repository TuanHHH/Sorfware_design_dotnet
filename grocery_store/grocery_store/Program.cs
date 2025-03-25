//var builder = WebApplication.CreateBuilder(args);

//// Add services to the container.
//builder.Services.AddControllersWithViews();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

//app.UseHttpsRedirection();
//app.UseStaticFiles();

//app.UseRouting();

//app.UseAuthorization();

//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller=Home}/{action=Index}/{id?}");

//app.Run();
using grocery_store.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Đăng ký AppDbContext và chuỗi kết nối
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
    ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));

var app = builder.Build();

// Cấu hình middlewares và routes
//test
app.MapGet("/", () => "Hello World!");
//test
app.MapGet("/cart", async (AppDbContext dbContext) =>
{
    // Lấy tất cả các CartItems từ cơ sở dữ liệu
    var cartItems = await dbContext.cart.ToListAsync();

    // Trả về danh sách CartItems dưới dạng JSON
    return Results.Ok(cartItems);
});
//test
app.MapGet("/product", async (AppDbContext dbContext) =>
{
    // Lấy tất cả các CartItems từ cơ sở dữ liệu
    var productItem = await dbContext.products.ToListAsync();

    // Trả về danh sách CartItems dưới dạng JSON
    return Results.Ok(productItem);
});

app.Run();
