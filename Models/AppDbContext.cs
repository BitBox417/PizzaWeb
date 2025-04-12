using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace PizzaKing.Models;

public class AppDbContext : IdentityDbContext<IdentityUser>
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {
    }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     optionsBuilder.ConfigureWarnings(w => 
    //         w.Ignore(RelationalEventId.PendingModelChangesWarning)
    //     );
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        List<Pizza> pizzaList =
		[
			new ("香肠披萨", "全是香肠") { Id = 1, Price = 12, LongDescription = "真的全是香肠啊", ImageUrl="/images/毛细.png"},
			new ("什锦披萨", "全都有") { IsInStock=true, Id = 2, Price = 10, LongDescription = "蔬菜什锦还有大鱼大肉", ImageUrl="/images/细.png"},
			new ("奶酪披萨", "浓浓的芝士奶酪") { IsInStock=true, Id = 3, Price = 11, LongDescription = "可以拉丝的奶酪披萨", ImageUrl="/images/三细.png"},
			new ("夏威夷披萨", "有菠萝") { Id = 4,Price = 10, LongDescription = "意大利人的噩梦", ImageUrl="/images/二细.png"},
			new ("小龙虾披萨", "麻辣小龙虾口味") { Id = 5,Price = 11, LongDescription = "全国人民的最爱", ImageUrl="/images/二柱子.png"},
			new ("咸蛋黄虾仁披萨","啥") { IsInStock=true, Id = 6,Price = 12, LongDescription = "瞎编的", ImageUrl="/images/韭叶子.png"},
			new ("川式腊味披萨", "啥啥") { IsInStock=true, Id = 7,Price = 11, LongDescription = "还是我瞎编的", ImageUrl="/images/薄宽.png"},
			new ("螺狮粉披萨","臭臭的披萨") { IsInStock=true, Id = 8,Price = 10, LongDescription = "面上加面碳水爆炸", ImageUrl="/images/大宽.png"},
			new ("正宗意大利披萨", "薄低番茄口") { Id = 9,Price = 15, LongDescription = "可能也不太正宗", ImageUrl="/images/荞麦棱子.png"},
			new ("好吃的披萨", "从必胜客打包来的") { Id = 10,Price = 15, LongDescription = "应该还不错吧", ImageUrl="/images/一窝丝.png"}
		];

        List<Feedback> feedbackList =
        [
            new() { Id = 1, Name = "阿莱克斯", Email = "noname1@hotmail.com", Comments = "真不错", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 2, Name = "莱克斯", Email = "noname2@hotmail.com", Comments = "还是挺好吃的", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 3, Name = "克斯", Email = "noname3@hotmail.com", Comments = "啥轮七八糟的", CreateTimeUTC = DateTime.UtcNow},
			new() { Id = 4, Name = "克斯", Email = "noname4@hotmail.com", Comments = "厚切的才有嚼劲", CreateTimeUTC = DateTime.UtcNow},
		];

        modelBuilder.Entity<Pizza>().HasData(pizzaList);
        modelBuilder.Entity<Feedback>().HasData(feedbackList);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Pizza> Pizzas {get;set;}

    public DbSet<Feedback> Feedbacks {get;set;}

}