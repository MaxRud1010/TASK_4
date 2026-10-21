namespace ShopDesktop.Models;

// Те же классы, что в API (папка ShopAPI/Models). API присылает данные в таком виде,
// а программа превращает их в эти объекты.

// Категория товаров
public class Category
{
    public int Id { get; set; }
    public string Name { get; set; } = "";

    // Так категория выглядит в выпадающем списке (ComboBox) — просто название
    public override string ToString() => Name;
}

// Товар
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int CategoryId { get; set; }
    public int Price { get; set; }
    public int Stock { get; set; }
}

// Заказ
public class Order
{
    public int Id { get; set; }
    public int ClientId { get; set; }
    public DateOnly OrderDate { get; set; }
    public string Status { get; set; } = "";
}

// Строка заказа: какой товар, сколько штук и по какой цене за штуку
public class OrderItem
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
    public int Price { get; set; }

    // Бонус 10. Сумма строки считается сама: количество × цена за штуку
    public int Sum => Quantity * Price;

    // Бонус 11. Название товара подставляет код окна перед показом таблицы
    public string ProductName { get; set; } = "";
}
