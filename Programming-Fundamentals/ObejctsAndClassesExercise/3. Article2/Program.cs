using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Article2
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

        public override string ToString()
        {
            return $"{this.Title} - {this.Content}: {this.Author}";
        }
    }
    internal class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < n; i++)
            {
                string[] initilaArticle = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = initilaArticle[0];
                string content = initilaArticle[1];
                string author = initilaArticle[2];
                Article article = new Article(title, content, author);
                articles.Add(article);
            }
            string command = Console.ReadLine();
            if (command == "title")
            {
                articles = articles.OrderBy(x => x.Title).ToList();
            }
            else if (command == "content")
            {
                articles = articles.OrderBy(x => x.Content).ToList();
            }
            else if (command == "author")
            {
                articles = articles.OrderBy(x => x.Author).ToList();
            }
            foreach (Article article in articles)
            {
                Console.WriteLine(article);
            }
        }
        
    }
}
