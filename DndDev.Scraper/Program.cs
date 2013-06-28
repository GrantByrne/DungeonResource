using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
using System.Web;
using DndDev.Domain.Book;
using DndDev.Repository.Abstract;
using DndDev.Repository;
using Raven.Client.Document;
using Raven.Client;
using Raven;
using Raven.Database;
using Raven.Database.Util;

namespace DndDev.Scraper
{
    public class Meh
    {
        private readonly IBookRepository _bookrepository;

        public Meh(IBookRepository bookservice)
        {
            _bookrepository = bookservice;
        }

        public void something(Book book)
        {
            _bookrepository.Create(book);
        }
        
    }
    
    
    public class Program
    {
        
        static void Main(string[] args)
        {
            //HtmlWeb web = new HtmlWeb();
            //HtmlDocument doc = web.Load(Url);
            HtmlDocument doc = new HtmlDocument();
            doc.Load("webfile.txt");
            var browser = doc.DocumentNode.SelectNodes(@"//body//table[@class='common']//tr//td//a");

            for (int x = 0; x < browser.Count; x++)
            {
                var first = browser[x].InnerHtml;
                var second = browser[x + 1].InnerHtml;

                var decodedFirst = HttpUtility.HtmlDecode(first);
                var decodedSecond = HttpUtility.HtmlDecode(second);

                int start = decodedSecond.IndexOf("(");
                int stop = decodedSecond.IndexOf(")");
                string output = decodedSecond.Substring(start + 1, stop - start - 1);

                var title = decodedFirst;
                var type = decodedSecond.Substring(0, start).TrimEnd(" ".ToCharArray());
                var edition = output;

                Console.WriteLine("Title: " + title);
                Console.WriteLine("Type: " + type);
                Console.WriteLine("Edition: " + edition);
                Console.WriteLine();
                x += 1;

                var book = new Book
                {
                    Title = title,
                    Edition = edition,
                    BookType = type
                };

                IDocumentStore store = new DocumentStore { ConnectionStringName="RavenHQ" };
                store.Initialize();


                //var repo = new DndDev.Repository.BookRepository(store);
                //repo.Create(book);



            }
            Console.ReadLine();
        }
    }


}
