namespace Lesson5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book objBook1 = new Book();
            objBook1.GetDescription();
            Console.Write("\n");
            try
            {
                Book objBook2 = new Book();
                Console.Write("Введите название книги" + "\n");
                objBook2.Title = Console.ReadLine();

                if (objBook2.Title == "")
                {
                    Console.WriteLine("Вы ничего не ввели!");
                    throw new ArgumentNullException(nameof(objBook2.Title));
                }

                Console.Write("Введите имя автора" + "\n");
                objBook2.Author = Console.ReadLine();

                if (objBook2.Author == "")
                {
                    Console.WriteLine("Вы ничего не ввели!");
                    throw new ArgumentNullException(nameof(objBook2.Author));
                }

                Console.Write("Введите количество страниц" + "\n");
                objBook2.Pages = int.Parse(Console.ReadLine());
                if (objBook2.Pages < 0 && objBook2.Pages < int.MaxValue)
                {
                    Console.WriteLine("Книг с таким количеством страницы - нет!");
                    throw new ArgumentOutOfRangeException(nameof(objBook2.Pages));
                }
                objBook2.GetDescription();
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка! Вы не ввели количество страниц!");
            }
            finally
            {
                Console.WriteLine("\n" + "Конец программы");
            }
        }
    }
}
