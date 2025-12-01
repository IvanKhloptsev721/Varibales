namespace Varibales
{
    internal class Program
    {
        //homeWork.Add(1);  // Добавить значение
        //homeWork.Insert(2, 20);  // Вставка по индексу
        //homeWork.Remove(2); // Удалить значение
        //homeWork.Contains(2); // Проверка
        //homeWork.IndexOf(5); // Индекс элемента
        //homeWork.Clear(); // Уборка очистка 
        static void Main(string[] args)
        {
            int age;
            string name;

            Console.WriteLine("Введите имя пользователя ");
            name = Console.ReadLine();

            Console.WriteLine($"Понял пользователь:{name} Укажите сколько вам лет?\n ");

            age = int.Parse(Console.ReadLine());

            Console.WriteLine($"Вам значит , {age} лет.");
            bool is_greater = age > 7;
            Console.WriteLine($",Приятно познакомится {age} летний {name}.");
            Console.WriteLine("перейдём на Ты ?");
            string yesOrNo  = Console.ReadLine();
            if (yesOrNo.Equals("да", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"О ладно дружище {name}");
                Console.WriteLine("Я могу попробывать тебя научить чему то?");
                string yesOrNo2 = Console.ReadLine();
                if (yesOrNo2.Equals("да", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"О ладно {name} смотри в языке програмирования есть такие классы как int string ");
                }
            }

        }
    }
}