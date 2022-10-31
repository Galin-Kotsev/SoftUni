using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace _02._Articles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();  

            int n = int.Parse(Console.ReadLine());

            List<Article> articles = new List<Article>();

            string[] inputs = input
                .Split(", ");

            string title = inputs[0];
            string content = inputs[1];
            string author = inputs[2];

            Article article = new Article(title, content, author);

            articles.Add(article);


            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine();

                string[] inputs2 = input
                    .Split(": ",StringSplitOptions.RemoveEmptyEntries);

                string command = inputs2[0];
                string text = inputs2[1];

                if (command == "Edit")
                {
                    article.EditArticle(text);

                }
                else if (command == "ChangeAuthor")
                {
                    article.ChangeAuthor(text);
                }
                else if (command == "Rename")
                {
                    article.RenameTitle(text);
                }
            }

            foreach (var Article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
}

public class Article
{
    public Article(string title, string content, string author)
    {
        Title = title;
        Content = content;
        Author = author;
    }

    public string Title { get; set; }
    public string Content { get; set; }
    public string Author { get; set; }

    public void EditArticle(string text)
    {
        Content = text;
    }
    public void ChangeAuthor(string text)
    {
       Author = text;
    }
    public void RenameTitle(string text)
    {
        Title = text;
    }
}


