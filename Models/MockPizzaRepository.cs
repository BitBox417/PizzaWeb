
namespace PizzaKing.Models;

public class MockPizzaRepository : IPizzaRepository
{
	public MockPizzaRepository() 
	{
		Initialize();
	}

	private List<Pizza> _pizzaList = new();

	private void Initialize()
	{
		_pizzaList =
		[
			 new ("香腸披薩", "滿滿的香腸") { Id = 1, Price = 12, LongDescription = "真的全是香腸，喜歡肉食的你不容錯過！", ImageUrl="/images/sausage_pizza.png"},
    new ("什錦披薩", "什麼都有") { Id = 2, Price = 10, LongDescription = "結合蔬菜與肉類，滿足所有人的口味需求。", ImageUrl="/images/mixed_pizza.png"},
    new ("奶酪披薩", "濃濃芝士") { Id = 3, Price = 11, LongDescription = "馬蘇里拉芝士滿滿，拉絲效果超讚！", ImageUrl="/images/cheese_pizza.png"},
    new ("夏威夷披薩", "菠蘿風味") { Id = 4, Price = 10, LongDescription = "菠蘿與火腿的完美結合，酸甜口感清爽可口。", ImageUrl="/images/hawaiian_pizza.png"},
    new ("小龍蝦披薩", "麻辣小龍蝦") { Id = 5, Price = 11, LongDescription = "小龍蝦愛好者的福音，濃郁麻辣風味讓人上癮！", ImageUrl="/images/lobster_pizza.png"},
    new ("鹹蛋黃蝦仁披薩", "獨特風味") { Id = 6, Price = 12, LongDescription = "鹹蛋黃與鮮蝦的結合，口感豐富濃郁。", ImageUrl="/images/salted_egg_shrimp_pizza.png"},
    new ("川式臘味披薩", "地道川味") { Id = 7, Price = 11, LongDescription = "臘腸與川味香料完美融合，帶來獨特風味。", ImageUrl="/images/sichuan_pizza.png"},
    new ("螺螄粉披薩", "螺螄粉風味") { Id = 8, Price = 10, LongDescription = "臭香結合，搭配米粉與濃郁湯底，碳水滿滿！", ImageUrl="/images/luosifen_pizza.png"},
    new ("正宗義大利披薩", "薄底番茄風味") { Id = 9, Price = 15, LongDescription = "遵循傳統義大利披薩做法，口感經典。", ImageUrl="/images/italian_pizza.png"},
    new ("經典披薩", "必勝客風味") { Id = 10, Price = 15, LongDescription = "濃郁醬料與經典配料，讓你一口愛上。", ImageUrl="/images/classic_pizza.png"}
		];
	}

    public IEnumerable<Pizza> GetAllPizzas()
    {
        return _pizzaList;
    }

    public Pizza? GetPizzaById(int id)
    {
        return _pizzaList.FirstOrDefault(p => p.Id == id);
    }
}