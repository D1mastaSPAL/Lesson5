namespace Lesson5._1
{
    internal class Book
    {
        private string _title;
        private string _author;
        private int _pages;

        public Book() : this("Unknown", "Unknown", 0)
        {
        }
        public Book(string title, string author, int pages)
        {
            Title = title;
            Author = author;
            Pages = pages;
        }
        public string Title
        {
            get
            {
                return _title;
            }
            set
            {
                _title = value;
            }
        }
        public string Author
        {
            get
            {
                return _author;
            }
            set
            {
                _author = value;
            }
        }
        public int Pages
        {
            get
            {
                return _pages;
            }
            set
            {
                _pages = value;
            }
        }
        public void GetDescription()
        {
            Console.Write($"Название: {Title}, Автор: {Author}, Страниц: {Pages}");
        }
    }
}
