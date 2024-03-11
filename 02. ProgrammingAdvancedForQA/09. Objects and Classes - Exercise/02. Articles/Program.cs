namespace _02._Articles
{
    public class Article
    {
        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string Title { get; private set; }
        public string Content { get; private set; }
        public string Author { get; private set; }

        public void Edit(string newContent)
        {
            Content = newContent;
        }

        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }

        public void Rename(string newTitle)
        {
            Title = newTitle;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            var articleInfo = Console.ReadLine().Split(", ");
            var title = articleInfo[0];
            var content = articleInfo[1];
            var author = articleInfo[2];

            var article = new Article(title, content, author);

            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var command = Console.ReadLine().Split(": ");
                var action = command[0];
                var parameter = command[1];

                switch (action)
                {
                    case "Edit": article.Edit(parameter); break;
                    case "ChangeAuthor": article.ChangeAuthor(parameter); break;
                    case "Rename": article.Rename(parameter); break;
                }
            }

            Console.WriteLine(article.ToString());
        }
    }
}