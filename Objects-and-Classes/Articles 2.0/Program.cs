using System;
using System.Linq;
using System.Collections.Generic;

namespace Articles
{
    class Program
    {
        public class Article
        {
            public Article(string title, string content, string author)
            {
                Title = title;
                Author = author;
                Content = content;
            }
            public string Title { get; set; }
            public string Author { get; set; }
            public string Content { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
            }
        }
        static void Main(string[] args)
        {
            int numberOfComands = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            string[] input;
            for (int i = 0; i < numberOfComands; i++)
            {
                input = Console.ReadLine().Split(", ");

                var article = new Article(input[0], input[1], input[2]);

                articles.Add(article);

            }
            string orderByWhat = Console.ReadLine();

            switch (orderByWhat)
            {
                case "title":
                    articles = articles.OrderBy(X => X.Title).ToList();
                    break;

                case "content":
                    articles = articles.OrderBy(X => X.Content).ToList();
                    break;

                case "author":
                    articles = articles.OrderBy(X => X.Author).ToList();
                    break;
            }

            Console.WriteLine(string.Join(Environment.NewLine, articles));
        }
    }
}