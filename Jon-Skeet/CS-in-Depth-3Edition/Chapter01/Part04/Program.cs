﻿#region Russian

/*
 
 1.1.3.Автоматически реализуемые свойства в С# 3

 Мы начнем с исследования ряда довольно простых средств, появившихся С# 3.
 Автоматически реализуемые свойства и упрощенная инициализация, продемонстрированные
 в листинге 1.3, относительно тривиальны по сравнению с лямбда-выражениями
 и прочими средствами, однако они помогают сделать код намного проще.

*/

// Листинг 1.3. Автоматически реализуемые свойства и упрощенная инициализация (С# 3)

using System.Collections.Generic;
using System.ComponentModel;

[Description("Listing 1.3")]

class Product
{
    public string Name { get; private set; }
    public decimal Price { get; private set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    Product()
    {
    }

    public static List<Product> GetSampleProducts()
    {
        return new List<Product>
        {
            new Product{Name = "West Side Story", Price = 9.99m},
            new Product{Name = "Assassins", Price = 14.99m},
            new Product{Name = "Frogs", Price = 13.99m},
            new Product{Name = "Sweeney Todd", Price = 10.99m}
        };
    }
    public override string ToString()
    {
        return string.Format("{0}: {1:C}", Name, Price);
    }

    public static void Main()
    {
        List<Product> product = Product.GetSampleProducts();

        // Корректное отображение символа рубля.
       Console.OutputEncoding = System.Text.Encoding.Unicode;

        for (int i = 0; i < product.Count; i++)
        {
            Console.WriteLine(product[i].ToString());
        }

       Console.ReadKey();
    }
}

/*
 
 Как видите, со свойствами не связан какой-либо код (или видимые переменные), а
 жестко закодированный список строится совершенно по-другому. Поскольку переменные
 name и price теперь отсутствуют, в классе приходится повсеместно применять свойства,
 улучшая согласованность. В коде предусмотрен закрытый конструктор без параметров,
 предназначенный для выполнения новой инициализации с помощью свойств. (Этот
 конструктор вызывается для каждого элемента списка перед установкой свойств.)
 В приведенном выше примере можно было бы полностью удалить открытый конструктор,
 но тогда во внешнем коде не удалось бы создавать другие экземпляры товаров.

*/

#endregion