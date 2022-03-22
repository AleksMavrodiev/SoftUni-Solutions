using System;

namespace _2._Articles
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public void EditContent(string newContent)
        {
            this.Content = newContent;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void RenameTitle(string newTitle)
        {
            this.Title = newTitle;
        }

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] initilaArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string title = initilaArticle[0];
            string content = initilaArticle[1];
            string author = initilaArticle[2];
            Article article = new Article(title, content, author);
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] cmdArgs = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string command = cmdArgs[0];
                string text = cmdArgs[1];
                switch (command)
                {
                    case "Edit":
                        article.EditContent(text);
                        break;
                    case "ChangeAuthor":
                        article.ChangeAuthor(text);
                        break;
                    case "Rename":
                        article.RenameTitle(text);
                        break;
                }
            }
            Console.WriteLine(article);
        }
    }
}
