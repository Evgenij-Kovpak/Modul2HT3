// See https://aka.ms/new-console-template for more information
using Modul2HT3.Gift;

IGift gift = new Gift();

Sweet candy1 = new Candy("Забодайка", "Ukraine", 33, 180, TypeOfCandy.Caramel);
Sweet candy2 = new Candy("Toffifee", "Germany", 41, 125, TypeOfCandy.ChocalateCandy);
Sweet candy3 = new Chocalate("Milenium", "Ukraine", 15, 85, ColorOfChocalate.WhiteChocolate);
Sweet candy4 = new Chocalate("Milka", "Switzerland", 13, 100, ColorOfChocalate.BlackChocolate);
Sweet candy5 = new Biscuit("Thick&Crunchy Oatcakes", "The United Kingdom", 14, 300, TypeOfBiscuit.OatCookies);
Sweet candy6 = new Biscuit("Leibniz Petit Beurre", "Poland", 22, 220, TypeOfBiscuit.Shortbread);

gift.Add(candy1);
gift.Add(candy2);
gift.Add(candy3);
gift.Add(candy4);
gift.Add(candy5);
gift.Add(candy6);

gift.GiftPrint();

gift.SortByWeight();

Console.WriteLine("После сортировки : \n");
gift.GiftPrint();

int left_border, right_border;
do
{
    Console.WriteLine("Введите границы содержания сахара :");
    Console.Write("Нижняя граница : ");
    left_border = int.Parse(Console.ReadLine());

    Console.Write("Верхняя граница : ");
    right_border = int.Parse(Console.ReadLine());

    if (left_border < 0 || right_border < 0 || left_border > right_border)
    {
        Console.Clear();
        Console.WriteLine("Неверный ввод!");
    }
} while (left_border < 0 || right_border < 0 || left_border > right_border);

Console.WriteLine($"\nСладости, соответствующие [{left_border}g ; {right_border}g] диапазон содержания сахара:");
foreach (var item in gift.FindCandyBySugar(left_border, right_border))
{
    Console.WriteLine($" Название сладостей: {item.Name}, Сахар: {item.Sugar}g");
}

Console.WriteLine($"\nВес подарка: {gift.GiftWeight()}g");
        
